// Copyright 2022 Google LLC
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

// Generated code. DO NOT EDIT!

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gaxgrpccore = Google.Api.Gax.Grpc.GrpcCore;
using gagr = Google.Api.Gax.ResourceNames;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Kms.V1
{
    /// <summary>Settings for <see cref="EkmServiceClient"/> instances.</summary>
    public sealed partial class EkmServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="EkmServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="EkmServiceSettings"/>.</returns>
        public static EkmServiceSettings GetDefault() => new EkmServiceSettings();

        /// <summary>Constructs a new <see cref="EkmServiceSettings"/> object with default settings.</summary>
        public EkmServiceSettings()
        {
        }

        private EkmServiceSettings(EkmServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListEkmConnectionsSettings = existing.ListEkmConnectionsSettings;
            GetEkmConnectionSettings = existing.GetEkmConnectionSettings;
            CreateEkmConnectionSettings = existing.CreateEkmConnectionSettings;
            UpdateEkmConnectionSettings = existing.UpdateEkmConnectionSettings;
            OnCopy(existing);
        }

        partial void OnCopy(EkmServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EkmServiceClient.ListEkmConnections</c> and <c>EkmServiceClient.ListEkmConnectionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListEkmConnectionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EkmServiceClient.GetEkmConnection</c> and <c>EkmServiceClient.GetEkmConnectionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetEkmConnectionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EkmServiceClient.CreateEkmConnection</c> and <c>EkmServiceClient.CreateEkmConnectionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateEkmConnectionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EkmServiceClient.UpdateEkmConnection</c> and <c>EkmServiceClient.UpdateEkmConnectionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateEkmConnectionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="EkmServiceSettings"/> object.</returns>
        public EkmServiceSettings Clone() => new EkmServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="EkmServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class EkmServiceClientBuilder : gaxgrpc::ClientBuilderBase<EkmServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public EkmServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public EkmServiceClientBuilder()
        {
            UseJwtAccessWithScopes = EkmServiceClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref EkmServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<EkmServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override EkmServiceClient Build()
        {
            EkmServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<EkmServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<EkmServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private EkmServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return EkmServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<EkmServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return EkmServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => EkmServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => EkmServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => EkmServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>EkmService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Google Cloud Key Management EKM Service
    /// 
    /// Manages external cryptographic keys and operations using those keys.
    /// Implements a REST model with the following objects:
    /// * [EkmConnection][google.cloud.kms.v1.EkmConnection]
    /// </remarks>
    public abstract partial class EkmServiceClient
    {
        /// <summary>
        /// The default endpoint for the EkmService service, which is a host of "cloudkms.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "cloudkms.googleapis.com:443";

        /// <summary>The default EkmService scopes.</summary>
        /// <remarks>
        /// The default EkmService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloudkms</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/cloudkms",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes, UseJwtAccessWithScopes);

        internal static bool UseJwtAccessWithScopes
        {
            get
            {
                bool useJwtAccessWithScopes = true;
                MaybeUseJwtAccessWithScopes(ref useJwtAccessWithScopes);
                return useJwtAccessWithScopes;
            }
        }

        static partial void MaybeUseJwtAccessWithScopes(ref bool useJwtAccessWithScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="EkmServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="EkmServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="EkmServiceClient"/>.</returns>
        public static stt::Task<EkmServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new EkmServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="EkmServiceClient"/> using the default credentials, endpoint and settings.
        /// To specify custom credentials or other settings, use <see cref="EkmServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="EkmServiceClient"/>.</returns>
        public static EkmServiceClient Create() => new EkmServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="EkmServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="EkmServiceSettings"/>.</param>
        /// <returns>The created <see cref="EkmServiceClient"/>.</returns>
        internal static EkmServiceClient Create(grpccore::CallInvoker callInvoker, EkmServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            EkmService.EkmServiceClient grpcClient = new EkmService.EkmServiceClient(callInvoker);
            return new EkmServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/>. Channels which weren't automatically created are not
        /// affected.
        /// </summary>
        /// <remarks>
        /// After calling this method, further calls to <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/> will create new channels, which could in turn be shut down
        /// by another call to this method.
        /// </remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => ChannelPool.ShutdownChannelsAsync();

        /// <summary>The underlying gRPC EkmService client</summary>
        public virtual EkmService.EkmServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists [EkmConnections][google.cloud.kms.v1.EkmConnection].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="EkmConnection"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEkmConnectionsResponse, EkmConnection> ListEkmConnections(ListEkmConnectionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists [EkmConnections][google.cloud.kms.v1.EkmConnection].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="EkmConnection"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEkmConnectionsResponse, EkmConnection> ListEkmConnectionsAsync(ListEkmConnectionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists [EkmConnections][google.cloud.kms.v1.EkmConnection].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [EkmConnections][google.cloud.kms.v1.EkmConnection] to list, in the format
        /// `projects/*/locations/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="EkmConnection"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEkmConnectionsResponse, EkmConnection> ListEkmConnections(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListEkmConnections(new ListEkmConnectionsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists [EkmConnections][google.cloud.kms.v1.EkmConnection].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [EkmConnections][google.cloud.kms.v1.EkmConnection] to list, in the format
        /// `projects/*/locations/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="EkmConnection"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEkmConnectionsResponse, EkmConnection> ListEkmConnectionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListEkmConnectionsAsync(new ListEkmConnectionsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists [EkmConnections][google.cloud.kms.v1.EkmConnection].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [EkmConnections][google.cloud.kms.v1.EkmConnection] to list, in the format
        /// `projects/*/locations/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="EkmConnection"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEkmConnectionsResponse, EkmConnection> ListEkmConnections(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListEkmConnections(new ListEkmConnectionsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists [EkmConnections][google.cloud.kms.v1.EkmConnection].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [EkmConnections][google.cloud.kms.v1.EkmConnection] to list, in the format
        /// `projects/*/locations/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="EkmConnection"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEkmConnectionsResponse, EkmConnection> ListEkmConnectionsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListEkmConnectionsAsync(new ListEkmConnectionsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns metadata for a given
        /// [EkmConnection][google.cloud.kms.v1.EkmConnection].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EkmConnection GetEkmConnection(GetEkmConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns metadata for a given
        /// [EkmConnection][google.cloud.kms.v1.EkmConnection].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EkmConnection> GetEkmConnectionAsync(GetEkmConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns metadata for a given
        /// [EkmConnection][google.cloud.kms.v1.EkmConnection].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EkmConnection> GetEkmConnectionAsync(GetEkmConnectionRequest request, st::CancellationToken cancellationToken) =>
            GetEkmConnectionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns metadata for a given
        /// [EkmConnection][google.cloud.kms.v1.EkmConnection].
        /// </summary>
        /// <param name="name">
        /// Required. The [name][google.cloud.kms.v1.EkmConnection.name] of the
        /// [EkmConnection][google.cloud.kms.v1.EkmConnection] to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EkmConnection GetEkmConnection(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEkmConnection(new GetEkmConnectionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns metadata for a given
        /// [EkmConnection][google.cloud.kms.v1.EkmConnection].
        /// </summary>
        /// <param name="name">
        /// Required. The [name][google.cloud.kms.v1.EkmConnection.name] of the
        /// [EkmConnection][google.cloud.kms.v1.EkmConnection] to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EkmConnection> GetEkmConnectionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEkmConnectionAsync(new GetEkmConnectionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns metadata for a given
        /// [EkmConnection][google.cloud.kms.v1.EkmConnection].
        /// </summary>
        /// <param name="name">
        /// Required. The [name][google.cloud.kms.v1.EkmConnection.name] of the
        /// [EkmConnection][google.cloud.kms.v1.EkmConnection] to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EkmConnection> GetEkmConnectionAsync(string name, st::CancellationToken cancellationToken) =>
            GetEkmConnectionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns metadata for a given
        /// [EkmConnection][google.cloud.kms.v1.EkmConnection].
        /// </summary>
        /// <param name="name">
        /// Required. The [name][google.cloud.kms.v1.EkmConnection.name] of the
        /// [EkmConnection][google.cloud.kms.v1.EkmConnection] to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EkmConnection GetEkmConnection(EkmConnectionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEkmConnection(new GetEkmConnectionRequest
            {
                EkmConnectionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns metadata for a given
        /// [EkmConnection][google.cloud.kms.v1.EkmConnection].
        /// </summary>
        /// <param name="name">
        /// Required. The [name][google.cloud.kms.v1.EkmConnection.name] of the
        /// [EkmConnection][google.cloud.kms.v1.EkmConnection] to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EkmConnection> GetEkmConnectionAsync(EkmConnectionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEkmConnectionAsync(new GetEkmConnectionRequest
            {
                EkmConnectionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns metadata for a given
        /// [EkmConnection][google.cloud.kms.v1.EkmConnection].
        /// </summary>
        /// <param name="name">
        /// Required. The [name][google.cloud.kms.v1.EkmConnection.name] of the
        /// [EkmConnection][google.cloud.kms.v1.EkmConnection] to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EkmConnection> GetEkmConnectionAsync(EkmConnectionName name, st::CancellationToken cancellationToken) =>
            GetEkmConnectionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new [EkmConnection][google.cloud.kms.v1.EkmConnection] in a given
        /// Project and Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EkmConnection CreateEkmConnection(CreateEkmConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new [EkmConnection][google.cloud.kms.v1.EkmConnection] in a given
        /// Project and Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EkmConnection> CreateEkmConnectionAsync(CreateEkmConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new [EkmConnection][google.cloud.kms.v1.EkmConnection] in a given
        /// Project and Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EkmConnection> CreateEkmConnectionAsync(CreateEkmConnectionRequest request, st::CancellationToken cancellationToken) =>
            CreateEkmConnectionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new [EkmConnection][google.cloud.kms.v1.EkmConnection] in a given
        /// Project and Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [EkmConnection][google.cloud.kms.v1.EkmConnection], in the format
        /// `projects/*/locations/*`.
        /// </param>
        /// <param name="ekmConnectionId">
        /// Required. It must be unique within a location and match the regular
        /// expression `[a-zA-Z0-9_-]{1,63}`.
        /// </param>
        /// <param name="ekmConnection">
        /// Required. An [EkmConnection][google.cloud.kms.v1.EkmConnection] with
        /// initial field values.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EkmConnection CreateEkmConnection(string parent, string ekmConnectionId, EkmConnection ekmConnection, gaxgrpc::CallSettings callSettings = null) =>
            CreateEkmConnection(new CreateEkmConnectionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                EkmConnectionId = gax::GaxPreconditions.CheckNotNullOrEmpty(ekmConnectionId, nameof(ekmConnectionId)),
                EkmConnection = gax::GaxPreconditions.CheckNotNull(ekmConnection, nameof(ekmConnection)),
            }, callSettings);

        /// <summary>
        /// Creates a new [EkmConnection][google.cloud.kms.v1.EkmConnection] in a given
        /// Project and Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [EkmConnection][google.cloud.kms.v1.EkmConnection], in the format
        /// `projects/*/locations/*`.
        /// </param>
        /// <param name="ekmConnectionId">
        /// Required. It must be unique within a location and match the regular
        /// expression `[a-zA-Z0-9_-]{1,63}`.
        /// </param>
        /// <param name="ekmConnection">
        /// Required. An [EkmConnection][google.cloud.kms.v1.EkmConnection] with
        /// initial field values.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EkmConnection> CreateEkmConnectionAsync(string parent, string ekmConnectionId, EkmConnection ekmConnection, gaxgrpc::CallSettings callSettings = null) =>
            CreateEkmConnectionAsync(new CreateEkmConnectionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                EkmConnectionId = gax::GaxPreconditions.CheckNotNullOrEmpty(ekmConnectionId, nameof(ekmConnectionId)),
                EkmConnection = gax::GaxPreconditions.CheckNotNull(ekmConnection, nameof(ekmConnection)),
            }, callSettings);

        /// <summary>
        /// Creates a new [EkmConnection][google.cloud.kms.v1.EkmConnection] in a given
        /// Project and Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [EkmConnection][google.cloud.kms.v1.EkmConnection], in the format
        /// `projects/*/locations/*`.
        /// </param>
        /// <param name="ekmConnectionId">
        /// Required. It must be unique within a location and match the regular
        /// expression `[a-zA-Z0-9_-]{1,63}`.
        /// </param>
        /// <param name="ekmConnection">
        /// Required. An [EkmConnection][google.cloud.kms.v1.EkmConnection] with
        /// initial field values.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EkmConnection> CreateEkmConnectionAsync(string parent, string ekmConnectionId, EkmConnection ekmConnection, st::CancellationToken cancellationToken) =>
            CreateEkmConnectionAsync(parent, ekmConnectionId, ekmConnection, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new [EkmConnection][google.cloud.kms.v1.EkmConnection] in a given
        /// Project and Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [EkmConnection][google.cloud.kms.v1.EkmConnection], in the format
        /// `projects/*/locations/*`.
        /// </param>
        /// <param name="ekmConnectionId">
        /// Required. It must be unique within a location and match the regular
        /// expression `[a-zA-Z0-9_-]{1,63}`.
        /// </param>
        /// <param name="ekmConnection">
        /// Required. An [EkmConnection][google.cloud.kms.v1.EkmConnection] with
        /// initial field values.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EkmConnection CreateEkmConnection(gagr::LocationName parent, string ekmConnectionId, EkmConnection ekmConnection, gaxgrpc::CallSettings callSettings = null) =>
            CreateEkmConnection(new CreateEkmConnectionRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EkmConnectionId = gax::GaxPreconditions.CheckNotNullOrEmpty(ekmConnectionId, nameof(ekmConnectionId)),
                EkmConnection = gax::GaxPreconditions.CheckNotNull(ekmConnection, nameof(ekmConnection)),
            }, callSettings);

        /// <summary>
        /// Creates a new [EkmConnection][google.cloud.kms.v1.EkmConnection] in a given
        /// Project and Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [EkmConnection][google.cloud.kms.v1.EkmConnection], in the format
        /// `projects/*/locations/*`.
        /// </param>
        /// <param name="ekmConnectionId">
        /// Required. It must be unique within a location and match the regular
        /// expression `[a-zA-Z0-9_-]{1,63}`.
        /// </param>
        /// <param name="ekmConnection">
        /// Required. An [EkmConnection][google.cloud.kms.v1.EkmConnection] with
        /// initial field values.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EkmConnection> CreateEkmConnectionAsync(gagr::LocationName parent, string ekmConnectionId, EkmConnection ekmConnection, gaxgrpc::CallSettings callSettings = null) =>
            CreateEkmConnectionAsync(new CreateEkmConnectionRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EkmConnectionId = gax::GaxPreconditions.CheckNotNullOrEmpty(ekmConnectionId, nameof(ekmConnectionId)),
                EkmConnection = gax::GaxPreconditions.CheckNotNull(ekmConnection, nameof(ekmConnection)),
            }, callSettings);

        /// <summary>
        /// Creates a new [EkmConnection][google.cloud.kms.v1.EkmConnection] in a given
        /// Project and Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [EkmConnection][google.cloud.kms.v1.EkmConnection], in the format
        /// `projects/*/locations/*`.
        /// </param>
        /// <param name="ekmConnectionId">
        /// Required. It must be unique within a location and match the regular
        /// expression `[a-zA-Z0-9_-]{1,63}`.
        /// </param>
        /// <param name="ekmConnection">
        /// Required. An [EkmConnection][google.cloud.kms.v1.EkmConnection] with
        /// initial field values.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EkmConnection> CreateEkmConnectionAsync(gagr::LocationName parent, string ekmConnectionId, EkmConnection ekmConnection, st::CancellationToken cancellationToken) =>
            CreateEkmConnectionAsync(parent, ekmConnectionId, ekmConnection, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an [EkmConnection][google.cloud.kms.v1.EkmConnection]'s metadata.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EkmConnection UpdateEkmConnection(UpdateEkmConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an [EkmConnection][google.cloud.kms.v1.EkmConnection]'s metadata.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EkmConnection> UpdateEkmConnectionAsync(UpdateEkmConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an [EkmConnection][google.cloud.kms.v1.EkmConnection]'s metadata.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EkmConnection> UpdateEkmConnectionAsync(UpdateEkmConnectionRequest request, st::CancellationToken cancellationToken) =>
            UpdateEkmConnectionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an [EkmConnection][google.cloud.kms.v1.EkmConnection]'s metadata.
        /// </summary>
        /// <param name="ekmConnection">
        /// Required. [EkmConnection][google.cloud.kms.v1.EkmConnection] with updated
        /// values.
        /// </param>
        /// <param name="updateMask">
        /// Required. List of fields to be updated in this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EkmConnection UpdateEkmConnection(EkmConnection ekmConnection, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEkmConnection(new UpdateEkmConnectionRequest
            {
                EkmConnection = gax::GaxPreconditions.CheckNotNull(ekmConnection, nameof(ekmConnection)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates an [EkmConnection][google.cloud.kms.v1.EkmConnection]'s metadata.
        /// </summary>
        /// <param name="ekmConnection">
        /// Required. [EkmConnection][google.cloud.kms.v1.EkmConnection] with updated
        /// values.
        /// </param>
        /// <param name="updateMask">
        /// Required. List of fields to be updated in this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EkmConnection> UpdateEkmConnectionAsync(EkmConnection ekmConnection, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEkmConnectionAsync(new UpdateEkmConnectionRequest
            {
                EkmConnection = gax::GaxPreconditions.CheckNotNull(ekmConnection, nameof(ekmConnection)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates an [EkmConnection][google.cloud.kms.v1.EkmConnection]'s metadata.
        /// </summary>
        /// <param name="ekmConnection">
        /// Required. [EkmConnection][google.cloud.kms.v1.EkmConnection] with updated
        /// values.
        /// </param>
        /// <param name="updateMask">
        /// Required. List of fields to be updated in this request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EkmConnection> UpdateEkmConnectionAsync(EkmConnection ekmConnection, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateEkmConnectionAsync(ekmConnection, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>EkmService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Google Cloud Key Management EKM Service
    /// 
    /// Manages external cryptographic keys and operations using those keys.
    /// Implements a REST model with the following objects:
    /// * [EkmConnection][google.cloud.kms.v1.EkmConnection]
    /// </remarks>
    public sealed partial class EkmServiceClientImpl : EkmServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListEkmConnectionsRequest, ListEkmConnectionsResponse> _callListEkmConnections;

        private readonly gaxgrpc::ApiCall<GetEkmConnectionRequest, EkmConnection> _callGetEkmConnection;

        private readonly gaxgrpc::ApiCall<CreateEkmConnectionRequest, EkmConnection> _callCreateEkmConnection;

        private readonly gaxgrpc::ApiCall<UpdateEkmConnectionRequest, EkmConnection> _callUpdateEkmConnection;

        /// <summary>
        /// Constructs a client wrapper for the EkmService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="EkmServiceSettings"/> used within this client.</param>
        public EkmServiceClientImpl(EkmService.EkmServiceClient grpcClient, EkmServiceSettings settings)
        {
            GrpcClient = grpcClient;
            EkmServiceSettings effectiveSettings = settings ?? EkmServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callListEkmConnections = clientHelper.BuildApiCall<ListEkmConnectionsRequest, ListEkmConnectionsResponse>(grpcClient.ListEkmConnectionsAsync, grpcClient.ListEkmConnections, effectiveSettings.ListEkmConnectionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListEkmConnections);
            Modify_ListEkmConnectionsApiCall(ref _callListEkmConnections);
            _callGetEkmConnection = clientHelper.BuildApiCall<GetEkmConnectionRequest, EkmConnection>(grpcClient.GetEkmConnectionAsync, grpcClient.GetEkmConnection, effectiveSettings.GetEkmConnectionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetEkmConnection);
            Modify_GetEkmConnectionApiCall(ref _callGetEkmConnection);
            _callCreateEkmConnection = clientHelper.BuildApiCall<CreateEkmConnectionRequest, EkmConnection>(grpcClient.CreateEkmConnectionAsync, grpcClient.CreateEkmConnection, effectiveSettings.CreateEkmConnectionSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateEkmConnection);
            Modify_CreateEkmConnectionApiCall(ref _callCreateEkmConnection);
            _callUpdateEkmConnection = clientHelper.BuildApiCall<UpdateEkmConnectionRequest, EkmConnection>(grpcClient.UpdateEkmConnectionAsync, grpcClient.UpdateEkmConnection, effectiveSettings.UpdateEkmConnectionSettings).WithGoogleRequestParam("ekm_connection.name", request => request.EkmConnection?.Name);
            Modify_ApiCall(ref _callUpdateEkmConnection);
            Modify_UpdateEkmConnectionApiCall(ref _callUpdateEkmConnection);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListEkmConnectionsApiCall(ref gaxgrpc::ApiCall<ListEkmConnectionsRequest, ListEkmConnectionsResponse> call);

        partial void Modify_GetEkmConnectionApiCall(ref gaxgrpc::ApiCall<GetEkmConnectionRequest, EkmConnection> call);

        partial void Modify_CreateEkmConnectionApiCall(ref gaxgrpc::ApiCall<CreateEkmConnectionRequest, EkmConnection> call);

        partial void Modify_UpdateEkmConnectionApiCall(ref gaxgrpc::ApiCall<UpdateEkmConnectionRequest, EkmConnection> call);

        partial void OnConstruction(EkmService.EkmServiceClient grpcClient, EkmServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC EkmService client</summary>
        public override EkmService.EkmServiceClient GrpcClient { get; }

        partial void Modify_ListEkmConnectionsRequest(ref ListEkmConnectionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetEkmConnectionRequest(ref GetEkmConnectionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateEkmConnectionRequest(ref CreateEkmConnectionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateEkmConnectionRequest(ref UpdateEkmConnectionRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists [EkmConnections][google.cloud.kms.v1.EkmConnection].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="EkmConnection"/> resources.</returns>
        public override gax::PagedEnumerable<ListEkmConnectionsResponse, EkmConnection> ListEkmConnections(ListEkmConnectionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEkmConnectionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListEkmConnectionsRequest, ListEkmConnectionsResponse, EkmConnection>(_callListEkmConnections, request, callSettings);
        }

        /// <summary>
        /// Lists [EkmConnections][google.cloud.kms.v1.EkmConnection].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="EkmConnection"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListEkmConnectionsResponse, EkmConnection> ListEkmConnectionsAsync(ListEkmConnectionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEkmConnectionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListEkmConnectionsRequest, ListEkmConnectionsResponse, EkmConnection>(_callListEkmConnections, request, callSettings);
        }

        /// <summary>
        /// Returns metadata for a given
        /// [EkmConnection][google.cloud.kms.v1.EkmConnection].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override EkmConnection GetEkmConnection(GetEkmConnectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEkmConnectionRequest(ref request, ref callSettings);
            return _callGetEkmConnection.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns metadata for a given
        /// [EkmConnection][google.cloud.kms.v1.EkmConnection].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<EkmConnection> GetEkmConnectionAsync(GetEkmConnectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEkmConnectionRequest(ref request, ref callSettings);
            return _callGetEkmConnection.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new [EkmConnection][google.cloud.kms.v1.EkmConnection] in a given
        /// Project and Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override EkmConnection CreateEkmConnection(CreateEkmConnectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEkmConnectionRequest(ref request, ref callSettings);
            return _callCreateEkmConnection.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new [EkmConnection][google.cloud.kms.v1.EkmConnection] in a given
        /// Project and Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<EkmConnection> CreateEkmConnectionAsync(CreateEkmConnectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEkmConnectionRequest(ref request, ref callSettings);
            return _callCreateEkmConnection.Async(request, callSettings);
        }

        /// <summary>
        /// Updates an [EkmConnection][google.cloud.kms.v1.EkmConnection]'s metadata.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override EkmConnection UpdateEkmConnection(UpdateEkmConnectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEkmConnectionRequest(ref request, ref callSettings);
            return _callUpdateEkmConnection.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an [EkmConnection][google.cloud.kms.v1.EkmConnection]'s metadata.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<EkmConnection> UpdateEkmConnectionAsync(UpdateEkmConnectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEkmConnectionRequest(ref request, ref callSettings);
            return _callUpdateEkmConnection.Async(request, callSettings);
        }
    }

    public partial class ListEkmConnectionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListEkmConnectionsResponse : gaxgrpc::IPageResponse<EkmConnection>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<EkmConnection> GetEnumerator() => EkmConnections.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}