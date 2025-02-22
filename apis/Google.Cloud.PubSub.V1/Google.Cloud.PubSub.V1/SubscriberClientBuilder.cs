// Copyright 2022 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License").
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at 
//
// https://www.apache.org/licenses/LICENSE-2.0 
//
// Unless required by applicable law or agreed to in writing, software 
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and 
// limitations under the License.

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.PubSub.V1;

/// <summary>
/// Builder class for <see cref="SubscriberClient"/> to provide simple configuration of credentials,
/// endpoint, client count, subscription settings etc.
/// </summary>
public sealed class SubscriberClientBuilder : ClientBuilderBase<SubscriberClient>
{
    private static readonly GrpcChannelOptions s_unlimitedSendReceiveChannelOptions = GrpcChannelOptions.Empty
        .WithMaxReceiveMessageSize(int.MaxValue)
        .WithMaxSendMessageSize(int.MaxValue)
        // Set max metadata size to 4 MB i.e., 4194304 bytes.
        .WithCustomOption("grpc.max_metadata_size", 4194304);

    /// <summary>
    /// The name of the subscription that the subscriber subscribes to.
    /// This must be non-null by the time <see cref="Build"/> or <see cref="BuildAsync(CancellationToken)"/> is called.
    /// </summary>
    public SubscriptionName SubscriptionName
    {
        get; set;
    }

    private int? _clientCount;

    /// <summary>
    /// The number of <see cref="SubscriberServiceApiClient"/>s to create and use within a <see cref="SubscriberClient"/> instance.
    /// If this is null, the number of clients created will depend on the processor count.
    /// </summary>
    public int? ClientCount
    {
        get => _clientCount;
        set
        {
            if (value is int count)
            {
                // Fairly arbitrary upper limit.
                _clientCount = GaxPreconditions.CheckArgumentRange(count, nameof(value), 1, 256);
            }
            else
            {
                _clientCount = value;
            }
        }
    }

    /// <summary>
    /// Additional settings for batching, message ordering etc. Default settings will be used if this is null.
    /// </summary>
    public SubscriberClient.Settings Settings { get; set; }

    /// <summary>
    /// The settings to use when creating<see cref= "SubscriberServiceApiClient" /> instances.
    /// Default settings will be used if this is null.
    /// </summary>
    public SubscriberServiceApiSettings ApiSettings { get; set; }

    /// <summary>
    /// Specifies how to respond to the presence of emulator environment variables.
    /// </summary>
    /// <remarks>
    /// This property defaults to <see cref="EmulatorDetection.None"/>, meaning that
    /// environment variables are ignored.
    /// </remarks>
    public new EmulatorDetection EmulatorDetection
    {
        get => base.EmulatorDetection;
        set => base.EmulatorDetection = value;
    }

    /// <summary>
    /// Creates a new instance with default settings. <see cref="TopicName"/> must be set
    /// before calling either <see cref="Build"/> or <see cref="BuildAsync"/>.
    /// </summary>
    public SubscriberClientBuilder() : base(SubscriberServiceApiClient.ServiceMetadata)
    {
    }

    /// <summary>Builds the resulting client.</summary>
    public override SubscriberClient Build() =>
        // With isAsync set to false, the returned task will already be completed(either successfully or faulted),
        // so .ResultWithUnwrappedExceptions() will always return immediately.
        BuildAsyncImpl(default, false).ResultWithUnwrappedExceptions();

    /// <summary>Builds the resulting client asynchronously.</summary>
    public override Task<SubscriberClient> BuildAsync(CancellationToken cancellationToken = default) =>
        BuildAsyncImpl(cancellationToken, true);

    private async Task<SubscriberClient> BuildAsyncImpl(CancellationToken cancellationToken, bool isAsync)
    {
        Validate();
        var clientCount = ClientCount ?? Environment.ProcessorCount;
        var clients = new SubscriberServiceApiClient[clientCount];
        var settings = Settings?.Clone() ?? new SubscriberClient.Settings();
        var shutdowns = new Func<Task>[clientCount];
        for (int i = 0; i < clientCount; i++)
        {
            // Use a random arg to prevent sub-channel re-use in gRPC, so each channel uses its own connection.
            var grpcChannelOptions = s_unlimitedSendReceiveChannelOptions
                .WithCustomOption("sub-channel-separator", Guid.NewGuid().ToString());

            var builder = new SubscriberServiceApiClientBuilder(this, grpcChannelOptions);
            clients[i] = isAsync
                ? await builder.BuildAsync(cancellationToken).ConfigureAwait(false)
                : builder.Build();
            var channel = builder.LastCreatedChannel;
            shutdowns[i] = () => DisposeChannelAsync(channel);
        }
        Func<Task> shutdown = () => Task.WhenAll(shutdowns.Select(x => x()));
        return new SubscriberClientImpl(SubscriptionName, clients, settings, shutdown);

        // TODO: Move this local method to a common place. We have it here and in PublisherClientBuilder.
        static Task DisposeChannelAsync(Grpc.Core.ChannelBase channel)
        {
            if (channel is null)
            {
                return Task.CompletedTask;
            }
            if (channel is IDisposable disposable)
            {
                disposable.Dispose();
            }

            return channel.ShutdownAsync();
        }
    }

    /// <inheritdoc />
    protected override ChannelPool GetChannelPool() => throw new NotImplementedException();

    /// <inheritdoc />
    protected override void Validate()
    {
        base.Validate();
        GaxPreconditions.CheckState(SubscriptionName != null, "The subscription name must be set before building a client.");
    }
}
