// Copyright 2018 Google LLC
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     https://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Api.Gax.Testing;
using Google.Cloud.Spanner.V1.Internal;
using Google.Cloud.Spanner.V1.Internal.Logging;
using Google.Protobuf;
using Grpc.Core;
using NSubstitute;
using NSubstitute.Extensions;
using System;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using static Google.Cloud.Spanner.V1.TransactionOptions.ModeOneofCase;
using ResourceInfo = Google.Rpc.ResourceInfo;

namespace Google.Cloud.Spanner.V1.Tests
{
    public class PooledSessionTests
    {
        private static readonly SessionName s_sampleSessionName = new SessionName("project", "instance", "database", "session");
        // In various tests we don't care whether things are evicted "on" or "after" a particular tick, so add one tick.
        private static readonly TimeSpan OneTick = TimeSpan.FromTicks(1);

        [Fact]
        public void FromSessionName_BasicProperties()
        {
            var pool = new FakeSessionPool();

            var pooledSession = PooledSession.FromSessionName(pool, s_sampleSessionName);

            Assert.Same(s_sampleSessionName, pooledSession.SessionName);
            Assert.False(pooledSession.ShouldBeEvicted);
            Assert.False(pooledSession.RequiresRefresh);
            Assert.False(pooledSession.ServerExpired);
            Assert.Null(pooledSession.TransactionId);
            Assert.Equal(TransactionOptions.ModeOneofCase.None, pooledSession.TransactionMode);
        }

        [Fact]
        public void Expiry()
        {
            var pool = new FakeSessionPool();
            var options = pool.Options;
            var clock = pool.Clock;
            var originalTime = clock.GetCurrentDateTimeUtc();

            // If we evict sessions before we refresh them, things get weird.
            Assert.True(options.IdleSessionRefreshDelay < options.PoolEvictionDelay);

            var pooledSession = PooledSession.FromSessionName(pool, s_sampleSessionName);
            Assert.False(pooledSession.ShouldBeEvicted);
            Assert.False(pooledSession.RequiresRefresh);

            // Detect the need for a refresh
            clock.AdvanceTo(originalTime + options.IdleSessionRefreshDelay + OneTick);
            Assert.False(pooledSession.ShouldBeEvicted);
            Assert.True(pooledSession.RequiresRefresh);

            // Detect the need for eviction
            clock.AdvanceTo(originalTime + options.PoolEvictionDelay + OneTick);
            Assert.True(pooledSession.ShouldBeEvicted);
            Assert.True(pooledSession.RequiresRefresh);
        }

        // TODO: We'd quite like to check the next three methods for all operations (and maybe more?), but it's not easy to parameterize.
        // Options:
        // - Live with lots of duplication
        // - Live without good unit test coverage
        // - Have horribly complex parameterization

        [Fact]
        public async Task AutoRefreshOnSuccessfulRpc()
        {
            var pool = new FakeSessionPool();
            var options = pool.Options;
            var clock = pool.Clock;

            var originalTime = clock.GetCurrentDateTimeUtc();
            var pooledSession = PooledSession.FromSessionName(pool, s_sampleSessionName);

            var halfRefresh = TimeSpan.FromTicks(options.IdleSessionRefreshDelay.Ticks / 2);
            clock.Advance(halfRefresh);

            // Make a successful request
            var request = new BeginTransactionRequest();
            var response = new Transaction();
            pool.Client.Configure().BeginTransactionAsync(request, Arg.Any<CallSettings>())
                .Returns(Task.FromResult(response));
            await pooledSession.BeginTransactionAsync(request, null);

            // The request will have extended the refresh time.
            Assert.Equal(clock.GetCurrentDateTimeUtc() + options.IdleSessionRefreshDelay, pooledSession.RefreshTimeForTest);

            _ = pool.Client.Received(1).BeginTransactionAsync(request, Arg.Any<CallSettings>());
        }

        [Fact]
        public async Task DetectSessionExpiry()
        {
            var pool = new FakeSessionPool();
            var pooledSession = PooledSession.FromSessionName(pool, s_sampleSessionName);

            // Make a request which fails due to the session not being found (because it has expired).
            var request = new BeginTransactionRequest();
            var exception = CreateSessionExpiredException();
            pool.Client.Configure().BeginTransactionAsync(request, Arg.Any<CallSettings>())
                .Returns(Task.FromException<Transaction>(exception));
            await Assert.ThrowsAsync<RpcException>(() => pooledSession.BeginTransactionAsync(request, null));
            Assert.True(pooledSession.ServerExpired);

            _ = pool.Client.Received(1).BeginTransactionAsync(request, Arg.Any<CallSettings>());
        }

        [Fact]
        public async Task RequestSessionIsPopulated()
        {
            var pool = new FakeSessionPool();
            var pooledSession = PooledSession.FromSessionName(pool, s_sampleSessionName);

            // Make a successful request
            var request = new BeginTransactionRequest();
            pool.Client.Configure().BeginTransactionAsync(request, Arg.Any<CallSettings>())
                .Returns(Task.FromResult(new Transaction()));
            await pooledSession.BeginTransactionAsync(request, null);
            
            // The call modifies the request. (We can't easily check that it was modified before the RPC)
            Assert.Equal(s_sampleSessionName, request.SessionAsSessionName);

            _ = pool.Client.Received(1).BeginTransactionAsync(request, Arg.Any<CallSettings>());
        }

        [Fact]
        public void WithTransaction()
        {
            var pool = new FakeSessionPool();
            var pooledSession = PooledSession.FromSessionName(pool, s_sampleSessionName);
            var transactionId = ByteString.CopyFromUtf8("transaction");
            var mode = TransactionOptions.ModeOneofCase.PartitionedDml;
            var sessionWithTransaction = pooledSession.WithTransaction(transactionId, mode);
            Assert.Equal(mode, sessionWithTransaction.TransactionMode);
            Assert.Equal(transactionId, sessionWithTransaction.TransactionId);
            Assert.Equal(s_sampleSessionName, sessionWithTransaction.SessionName);
        }

        [Fact]
        public async Task RequestTransactionIsPopulated()
        {
            var pool = new FakeSessionPool();
            var transactionId = ByteString.CopyFromUtf8("transaction");
            var mode = TransactionOptions.ModeOneofCase.ReadWrite;
            var pooledSession = PooledSession.FromSessionName(pool, s_sampleSessionName);
            var sessionWithTransaction = pooledSession.WithTransaction(transactionId, mode);

            // Make a successful request
            var request = new CommitRequest();
            pool.Client.Configure().CommitAsync(request, Arg.Any<CallSettings>())
                .Returns(Task.FromResult(new CommitResponse()));
            await sessionWithTransaction.CommitAsync(request, null);

            // The call modifies the request. (We can't easily check that it was modified before the RPC)
            Assert.Equal(s_sampleSessionName, request.SessionAsSessionName);
            Assert.Equal(transactionId, request.TransactionId);

            _ = pool.Client.Received(1).CommitAsync(request, Arg.Any<CallSettings>());
        }

        // TODO: Revisit the names of the following 4 tests.

        [Fact]
        public async Task ExecuteSqlAsync_RequestTransactionIsPopulatedWhenNotPresent()
        {
            var pool = new FakeSessionPool();
            var transactionId = ByteString.CopyFromUtf8("transaction");
            var mode = TransactionOptions.ModeOneofCase.ReadWrite;
            var pooledSession = PooledSession.FromSessionName(pool, s_sampleSessionName);
            var sessionWithTransaction = pooledSession.WithTransaction(transactionId, mode);

            // Make a successful request
            var request = new ExecuteSqlRequest();
            pool.Client.Configure().ExecuteSqlAsync(request, Arg.Any<CallSettings>())
                .Returns(Task.FromResult(new ResultSet()));
            await sessionWithTransaction.ExecuteSqlAsync(request, null);

            // The call modifies the request. (We can't easily check that it was modified before the RPC)
            Assert.Equal(s_sampleSessionName, request.SessionAsSessionName);
            Assert.Equal(transactionId, request.Transaction.Id);

            _ = pool.Client.Received(1).ExecuteSqlAsync(request, Arg.Any<CallSettings>());
        }

        [Fact]
        public async Task ExecuteSqlAsync_RequestTransactionIsLeftAloneWhenPresent()
        {
            var pool = new FakeSessionPool();
            var pooledSession = PooledSession.FromSessionName(pool, s_sampleSessionName);

            // Make a successful request
            var request = new ExecuteSqlRequest { Transaction = new TransactionSelector { Begin = new TransactionOptions { ReadOnly = new TransactionOptions.Types.ReadOnly() } } };
            pool.Client.Configure().ExecuteSqlAsync(request, Arg.Any<CallSettings>())
                .Returns(Task.FromResult(new ResultSet()));
            await pooledSession.ExecuteSqlAsync(request, null);

            // The call modifies the request's session, but not transaction.
            Assert.Equal(s_sampleSessionName, request.SessionAsSessionName);
            Assert.Equal(TransactionSelector.SelectorOneofCase.Begin, request.Transaction.SelectorCase);
            Assert.Equal(new TransactionOptions.Types.ReadOnly(), request.Transaction.Begin.ReadOnly);

            _ = pool.Client.Received(1).ExecuteSqlAsync(request, Arg.Any<CallSettings>());
        }

        [Fact]
        public async Task ExecuteBatchDmlAsync_RequestTransactionIsPopulatedWhenNotPresent()
        {
            var pool = new FakeSessionPool();
            var transactionId = ByteString.CopyFromUtf8("transaction");
            var pooledSession = PooledSession.FromSessionName(pool, s_sampleSessionName);
            var sessionWithTransaction = pooledSession.WithTransaction(transactionId, ReadWrite);

            // Make a successful request
            var request = new ExecuteBatchDmlRequest();
            pool.Client.Configure().ExecuteBatchDmlAsync(request, Arg.Any<CallSettings>())
                .Returns(Task.FromResult(new ExecuteBatchDmlResponse()));
            await sessionWithTransaction.ExecuteBatchDmlAsync(request, null);

            // The call modifies the request. (We can't easily check that it was modified before the RPC)
            Assert.Equal(s_sampleSessionName, request.SessionAsSessionName);
            Assert.Equal(transactionId, request.Transaction.Id);

            _ = pool.Client.Received(1).ExecuteBatchDmlAsync(request, Arg.Any<CallSettings>());
        }

        [Fact]
        public async Task ExecuteBatchDmlAsync_RequestTransactionIsLeftAloneWhenPresent()
        {
            var pool = new FakeSessionPool();
            var pooledSession = PooledSession.FromSessionName(pool, s_sampleSessionName);

            // Make a successful request
            var request = new ExecuteBatchDmlRequest { Transaction = new TransactionSelector { Begin = new TransactionOptions { ReadOnly = new TransactionOptions.Types.ReadOnly() } } };
            pool.Client.Configure().ExecuteBatchDmlAsync(request, Arg.Any<CallSettings>())
                .Returns(Task.FromResult(new ExecuteBatchDmlResponse()));
            await pooledSession.ExecuteBatchDmlAsync(request, null);

            // The call modifies the request's session, but not transaction.
            Assert.Equal(s_sampleSessionName, request.SessionAsSessionName);
            Assert.Equal(TransactionSelector.SelectorOneofCase.Begin, request.Transaction.SelectorCase);
            Assert.Equal(new TransactionOptions.Types.ReadOnly(), request.Transaction.Begin.ReadOnly);

            _ = pool.Client.Received(1).ExecuteBatchDmlAsync(request, Arg.Any<CallSettings>());
        }

        [Fact]
        public void ReleaseToPool_NoDelete()
        {
            var pool = new FakeSessionPool();
            var pooledSession = PooledSession.FromSessionName(pool, s_sampleSessionName);
            pooledSession.ReleaseToPool(false);
            Assert.False(pool.ReleasedSessionDeleted);
            Assert.Null(pool.RolledBackTransaction);
        }

        [Fact]
        public void ReleaseToPool_ForceDelete()
        {
            var pool = new FakeSessionPool();
            var pooledSession = PooledSession.FromSessionName(pool, s_sampleSessionName);
            pooledSession.ReleaseToPool(true);
            Assert.True(pool.ReleasedSessionDeleted);
            Assert.Null(pool.RolledBackTransaction);
        }

        [Fact]
        public async Task ReleaseToPool_SessionInvalidatedByServer()
        {
            var pool = new FakeSessionPool();
            var pooledSession = PooledSession.FromSessionName(pool, s_sampleSessionName);

            // Make a request which fails due to the session not being found (because it has expired).
            var request = new BeginTransactionRequest();
            var exception = CreateSessionExpiredException();
            pool.Client.Configure().BeginTransactionAsync(request, Arg.Any<CallSettings>())
                .Returns(Task.FromException<Transaction>(exception));
            await Assert.ThrowsAsync<RpcException>(() => pooledSession.BeginTransactionAsync(request, null));

            // When we release the session, the pool should delete it even if we didn't ask it to.
            pooledSession.ReleaseToPool(false);
            Assert.True(pool.ReleasedSessionDeleted);
            Assert.Null(pool.RolledBackTransaction);

            _ = pool.Client.Received(1).BeginTransactionAsync(request, Arg.Any<CallSettings>());
        }

        [Fact]
        public void ReleaseToPool_SessionExpired()
        {
            var pool = new FakeSessionPool();
            var pooledSession = PooledSession.FromSessionName(pool, s_sampleSessionName);

            // Let it go past its eviction time
            var clock = pool.Clock;
            clock.Advance(pool.Options.PoolEvictionDelay + OneTick);

            // When we release the session, the pool should delete it even if we didn't ask it to.
            pooledSession.ReleaseToPool(false);
            Assert.True(pool.ReleasedSessionDeleted);
            Assert.Null(pool.RolledBackTransaction);
        }

        [Fact]
        public async Task ReleaseToPool_FurtherRpcsInvalid()
        {
            var pool = new FakeSessionPool();
            var pooledSession = PooledSession.FromSessionName(pool, s_sampleSessionName);

            // Release the session immediately
            pooledSession.ReleaseToPool(false);

            // We now can't make RPCs
            await Assert.ThrowsAsync<ObjectDisposedException>(
                () => pooledSession.BeginTransactionAsync(new BeginTransactionRequest(), null));
        }

        [Fact]
        public void ReleaseToPool_ReadOnlyTransactionNotRolledBack()
        {
            var pool = new FakeSessionPool();
            var pooledSession = CreateWithTransaction(pool, ReadOnly);
            pooledSession.ReleaseToPool(false);
            Assert.Null(pool.RolledBackTransaction);
        }

        [Fact]
        public void ReleaseToPool_PartitionedDmlTransactionNotRolledBack()
        {
            var pool = new FakeSessionPool();
            var pooledSession = CreateWithTransaction(pool, PartitionedDml);
            pooledSession.ReleaseToPool(false);
            Assert.Null(pool.RolledBackTransaction);
        }

        [Fact]
        public async Task ReleaseToPool_CommittedTransactionNotRolledBack()
        {
            var pool = new FakeSessionPool();
            pool.Client.Configure().CommitAsync(Arg.Any<CommitRequest>(), Arg.Any<CallSettings>())
                .Returns(Task.FromResult(new CommitResponse()));

            var pooledSession = CreateWithTransaction(pool, ReadWrite);
            await pooledSession.CommitAsync(new CommitRequest(), null);
            pooledSession.ReleaseToPool(false);
            Assert.Null(pool.RolledBackTransaction);
        }

        [Fact]
        public async Task ReleaseToPool_RolledBackTransactionNotRolledBack()
        {
            var pool = new FakeSessionPool();
            pool.Client.Configure().RollbackAsync(Arg.Any<RollbackRequest>(), Arg.Any<CallSettings>())
                .Returns(Task.CompletedTask);

            var pooledSession = CreateWithTransaction(pool, ReadWrite);
            await pooledSession.RollbackAsync(new RollbackRequest(), null);
            pooledSession.ReleaseToPool(false);
            Assert.Null(pool.RolledBackTransaction);
        }

        [Fact]
        public void ReleaseToPool_ReadWriteUncommittedTransactionRolledBack()
        {
            var pool = new FakeSessionPool();
            var pooledSession = CreateWithTransaction(pool, ReadWrite);
            pooledSession.ReleaseToPool(false);
            Assert.Equal(pool.RolledBackTransaction, pooledSession.TransactionId);
        }

        private static RpcException CreateSessionExpiredException() =>
            new RpcException(new Status(StatusCode.NotFound, "Session not found"),
                new Metadata { { ExecuteHelper.ResourceInfoMetadataKey, new ResourceInfo { ResourceType = ExecuteHelper.SessionResourceType }.ToByteArray() } });

        private PooledSession CreateWithTransaction(SessionPool.ISessionPool pool, TransactionOptions.ModeOneofCase mode)
        {
            ByteString transactionId = ByteString.CopyFromUtf8(Guid.NewGuid().ToString());
            return PooledSession.FromSessionName(pool, s_sampleSessionName).WithTransaction(transactionId, mode);
        }

        private class FakeSessionPool : SessionPool.ISessionPool
        {
            public SpannerClient Client { get; }
            public SessionPoolOptions Options { get; }
            IClock SessionPool.ISessionPool.Clock => Clock;
            public FakeClock Clock => (FakeClock) Client.Settings.Clock;
            public Logger Logger { get; } = Logger.DefaultLogger;

            public bool? ReleasedSessionDeleted { get; private set; }
            public ByteString RolledBackTransaction { get; private set; }

            internal FakeSessionPool()
            {
                Client = SpannerClientHelpers.CreateMockClient(Logger);
                Options = new SessionPoolOptions
                {
                    SessionEvictionJitter = RetrySettings.NoJitter,
                    SessionRefreshJitter = RetrySettings.NoJitter
                };
            }

            public void Release(PooledSession session, ByteString transactionToRollback, bool deleteSession)
            {
                RolledBackTransaction = transactionToRollback;
                ReleasedSessionDeleted = deleteSession;
            }

            public void Detach(PooledSession session) => throw new NotImplementedException();

            public Task<PooledSession> WithFreshTransactionOrNewAsync(PooledSession session, TransactionOptions transactionOptions, CancellationToken cancellationToken) =>
                throw new NotImplementedException();
        }
    }
}
