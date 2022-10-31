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

#pragma warning disable CS8981
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gagr = Google.Api.Gax.ResourceNames;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.EnterpriseKnowledgeGraph.V1
{
    /// <summary>Settings for <see cref="EnterpriseKnowledgeGraphServiceClient"/> instances.</summary>
    public sealed partial class EnterpriseKnowledgeGraphServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="EnterpriseKnowledgeGraphServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="EnterpriseKnowledgeGraphServiceSettings"/>.</returns>
        public static EnterpriseKnowledgeGraphServiceSettings GetDefault() => new EnterpriseKnowledgeGraphServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="EnterpriseKnowledgeGraphServiceSettings"/> object with default settings.
        /// </summary>
        public EnterpriseKnowledgeGraphServiceSettings()
        {
        }

        private EnterpriseKnowledgeGraphServiceSettings(EnterpriseKnowledgeGraphServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateEntityReconciliationJobSettings = existing.CreateEntityReconciliationJobSettings;
            GetEntityReconciliationJobSettings = existing.GetEntityReconciliationJobSettings;
            ListEntityReconciliationJobsSettings = existing.ListEntityReconciliationJobsSettings;
            CancelEntityReconciliationJobSettings = existing.CancelEntityReconciliationJobSettings;
            DeleteEntityReconciliationJobSettings = existing.DeleteEntityReconciliationJobSettings;
            OnCopy(existing);
        }

        partial void OnCopy(EnterpriseKnowledgeGraphServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EnterpriseKnowledgeGraphServiceClient.CreateEntityReconciliationJob</c> and
        /// <c>EnterpriseKnowledgeGraphServiceClient.CreateEntityReconciliationJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateEntityReconciliationJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EnterpriseKnowledgeGraphServiceClient.GetEntityReconciliationJob</c> and
        /// <c>EnterpriseKnowledgeGraphServiceClient.GetEntityReconciliationJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetEntityReconciliationJobSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EnterpriseKnowledgeGraphServiceClient.ListEntityReconciliationJobs</c> and
        /// <c>EnterpriseKnowledgeGraphServiceClient.ListEntityReconciliationJobsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListEntityReconciliationJobsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EnterpriseKnowledgeGraphServiceClient.CancelEntityReconciliationJob</c> and
        /// <c>EnterpriseKnowledgeGraphServiceClient.CancelEntityReconciliationJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CancelEntityReconciliationJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EnterpriseKnowledgeGraphServiceClient.DeleteEntityReconciliationJob</c> and
        /// <c>EnterpriseKnowledgeGraphServiceClient.DeleteEntityReconciliationJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteEntityReconciliationJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="EnterpriseKnowledgeGraphServiceSettings"/> object.</returns>
        public EnterpriseKnowledgeGraphServiceSettings Clone() => new EnterpriseKnowledgeGraphServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="EnterpriseKnowledgeGraphServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class EnterpriseKnowledgeGraphServiceClientBuilder : gaxgrpc::ClientBuilderBase<EnterpriseKnowledgeGraphServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public EnterpriseKnowledgeGraphServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public EnterpriseKnowledgeGraphServiceClientBuilder() : base(EnterpriseKnowledgeGraphServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref EnterpriseKnowledgeGraphServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<EnterpriseKnowledgeGraphServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override EnterpriseKnowledgeGraphServiceClient Build()
        {
            EnterpriseKnowledgeGraphServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<EnterpriseKnowledgeGraphServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<EnterpriseKnowledgeGraphServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private EnterpriseKnowledgeGraphServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return EnterpriseKnowledgeGraphServiceClient.Create(callInvoker, Settings, Logger);
        }

        private async stt::Task<EnterpriseKnowledgeGraphServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return EnterpriseKnowledgeGraphServiceClient.Create(callInvoker, Settings, Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => EnterpriseKnowledgeGraphServiceClient.ChannelPool;
    }

    /// <summary>EnterpriseKnowledgeGraphService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// APIs for enterprise knowledge graph product.
    /// </remarks>
    public abstract partial class EnterpriseKnowledgeGraphServiceClient
    {
        /// <summary>
        /// The default endpoint for the EnterpriseKnowledgeGraphService service, which is a host of
        /// "enterpriseknowledgegraph.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "enterpriseknowledgegraph.googleapis.com:443";

        /// <summary>The default EnterpriseKnowledgeGraphService scopes.</summary>
        /// <remarks>
        /// The default EnterpriseKnowledgeGraphService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(EnterpriseKnowledgeGraphService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="EnterpriseKnowledgeGraphServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="EnterpriseKnowledgeGraphServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="EnterpriseKnowledgeGraphServiceClient"/>.</returns>
        public static stt::Task<EnterpriseKnowledgeGraphServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new EnterpriseKnowledgeGraphServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="EnterpriseKnowledgeGraphServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="EnterpriseKnowledgeGraphServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="EnterpriseKnowledgeGraphServiceClient"/>.</returns>
        public static EnterpriseKnowledgeGraphServiceClient Create() =>
            new EnterpriseKnowledgeGraphServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="EnterpriseKnowledgeGraphServiceClient"/> which uses the specified call invoker for
        /// remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="EnterpriseKnowledgeGraphServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="EnterpriseKnowledgeGraphServiceClient"/>.</returns>
        internal static EnterpriseKnowledgeGraphServiceClient Create(grpccore::CallInvoker callInvoker, EnterpriseKnowledgeGraphServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            EnterpriseKnowledgeGraphService.EnterpriseKnowledgeGraphServiceClient grpcClient = new EnterpriseKnowledgeGraphService.EnterpriseKnowledgeGraphServiceClient(callInvoker);
            return new EnterpriseKnowledgeGraphServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC EnterpriseKnowledgeGraphService client</summary>
        public virtual EnterpriseKnowledgeGraphService.EnterpriseKnowledgeGraphServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a EntityReconciliationJob. A EntityReconciliationJob once created
        /// will right away be attempted to start.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EntityReconciliationJob CreateEntityReconciliationJob(CreateEntityReconciliationJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a EntityReconciliationJob. A EntityReconciliationJob once created
        /// will right away be attempted to start.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntityReconciliationJob> CreateEntityReconciliationJobAsync(CreateEntityReconciliationJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a EntityReconciliationJob. A EntityReconciliationJob once created
        /// will right away be attempted to start.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntityReconciliationJob> CreateEntityReconciliationJobAsync(CreateEntityReconciliationJobRequest request, st::CancellationToken cancellationToken) =>
            CreateEntityReconciliationJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a EntityReconciliationJob. A EntityReconciliationJob once created
        /// will right away be attempted to start.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the
        /// EntityReconciliationJob in. Format:
        /// `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="entityReconciliationJob">
        /// Required. The EntityReconciliationJob to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EntityReconciliationJob CreateEntityReconciliationJob(string parent, EntityReconciliationJob entityReconciliationJob, gaxgrpc::CallSettings callSettings = null) =>
            CreateEntityReconciliationJob(new CreateEntityReconciliationJobRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                EntityReconciliationJob = gax::GaxPreconditions.CheckNotNull(entityReconciliationJob, nameof(entityReconciliationJob)),
            }, callSettings);

        /// <summary>
        /// Creates a EntityReconciliationJob. A EntityReconciliationJob once created
        /// will right away be attempted to start.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the
        /// EntityReconciliationJob in. Format:
        /// `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="entityReconciliationJob">
        /// Required. The EntityReconciliationJob to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntityReconciliationJob> CreateEntityReconciliationJobAsync(string parent, EntityReconciliationJob entityReconciliationJob, gaxgrpc::CallSettings callSettings = null) =>
            CreateEntityReconciliationJobAsync(new CreateEntityReconciliationJobRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                EntityReconciliationJob = gax::GaxPreconditions.CheckNotNull(entityReconciliationJob, nameof(entityReconciliationJob)),
            }, callSettings);

        /// <summary>
        /// Creates a EntityReconciliationJob. A EntityReconciliationJob once created
        /// will right away be attempted to start.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the
        /// EntityReconciliationJob in. Format:
        /// `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="entityReconciliationJob">
        /// Required. The EntityReconciliationJob to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntityReconciliationJob> CreateEntityReconciliationJobAsync(string parent, EntityReconciliationJob entityReconciliationJob, st::CancellationToken cancellationToken) =>
            CreateEntityReconciliationJobAsync(parent, entityReconciliationJob, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a EntityReconciliationJob. A EntityReconciliationJob once created
        /// will right away be attempted to start.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the
        /// EntityReconciliationJob in. Format:
        /// `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="entityReconciliationJob">
        /// Required. The EntityReconciliationJob to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EntityReconciliationJob CreateEntityReconciliationJob(gagr::LocationName parent, EntityReconciliationJob entityReconciliationJob, gaxgrpc::CallSettings callSettings = null) =>
            CreateEntityReconciliationJob(new CreateEntityReconciliationJobRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EntityReconciliationJob = gax::GaxPreconditions.CheckNotNull(entityReconciliationJob, nameof(entityReconciliationJob)),
            }, callSettings);

        /// <summary>
        /// Creates a EntityReconciliationJob. A EntityReconciliationJob once created
        /// will right away be attempted to start.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the
        /// EntityReconciliationJob in. Format:
        /// `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="entityReconciliationJob">
        /// Required. The EntityReconciliationJob to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntityReconciliationJob> CreateEntityReconciliationJobAsync(gagr::LocationName parent, EntityReconciliationJob entityReconciliationJob, gaxgrpc::CallSettings callSettings = null) =>
            CreateEntityReconciliationJobAsync(new CreateEntityReconciliationJobRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EntityReconciliationJob = gax::GaxPreconditions.CheckNotNull(entityReconciliationJob, nameof(entityReconciliationJob)),
            }, callSettings);

        /// <summary>
        /// Creates a EntityReconciliationJob. A EntityReconciliationJob once created
        /// will right away be attempted to start.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the
        /// EntityReconciliationJob in. Format:
        /// `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="entityReconciliationJob">
        /// Required. The EntityReconciliationJob to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntityReconciliationJob> CreateEntityReconciliationJobAsync(gagr::LocationName parent, EntityReconciliationJob entityReconciliationJob, st::CancellationToken cancellationToken) =>
            CreateEntityReconciliationJobAsync(parent, entityReconciliationJob, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a EntityReconciliationJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EntityReconciliationJob GetEntityReconciliationJob(GetEntityReconciliationJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a EntityReconciliationJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntityReconciliationJob> GetEntityReconciliationJobAsync(GetEntityReconciliationJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a EntityReconciliationJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntityReconciliationJob> GetEntityReconciliationJobAsync(GetEntityReconciliationJobRequest request, st::CancellationToken cancellationToken) =>
            GetEntityReconciliationJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a EntityReconciliationJob.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the EntityReconciliationJob resource.
        /// Format:
        /// `projects/{project}/locations/{location}/entityReconciliationJobs/{entity_reconciliation_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EntityReconciliationJob GetEntityReconciliationJob(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEntityReconciliationJob(new GetEntityReconciliationJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a EntityReconciliationJob.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the EntityReconciliationJob resource.
        /// Format:
        /// `projects/{project}/locations/{location}/entityReconciliationJobs/{entity_reconciliation_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntityReconciliationJob> GetEntityReconciliationJobAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEntityReconciliationJobAsync(new GetEntityReconciliationJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a EntityReconciliationJob.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the EntityReconciliationJob resource.
        /// Format:
        /// `projects/{project}/locations/{location}/entityReconciliationJobs/{entity_reconciliation_job}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntityReconciliationJob> GetEntityReconciliationJobAsync(string name, st::CancellationToken cancellationToken) =>
            GetEntityReconciliationJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a EntityReconciliationJob.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the EntityReconciliationJob resource.
        /// Format:
        /// `projects/{project}/locations/{location}/entityReconciliationJobs/{entity_reconciliation_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EntityReconciliationJob GetEntityReconciliationJob(EntityReconciliationJobName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEntityReconciliationJob(new GetEntityReconciliationJobRequest
            {
                EntityReconciliationJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a EntityReconciliationJob.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the EntityReconciliationJob resource.
        /// Format:
        /// `projects/{project}/locations/{location}/entityReconciliationJobs/{entity_reconciliation_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntityReconciliationJob> GetEntityReconciliationJobAsync(EntityReconciliationJobName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEntityReconciliationJobAsync(new GetEntityReconciliationJobRequest
            {
                EntityReconciliationJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a EntityReconciliationJob.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the EntityReconciliationJob resource.
        /// Format:
        /// `projects/{project}/locations/{location}/entityReconciliationJobs/{entity_reconciliation_job}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntityReconciliationJob> GetEntityReconciliationJobAsync(EntityReconciliationJobName name, st::CancellationToken cancellationToken) =>
            GetEntityReconciliationJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Entity Reconciliation Jobs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="EntityReconciliationJob"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEntityReconciliationJobsResponse, EntityReconciliationJob> ListEntityReconciliationJobs(ListEntityReconciliationJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Entity Reconciliation Jobs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="EntityReconciliationJob"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEntityReconciliationJobsResponse, EntityReconciliationJob> ListEntityReconciliationJobsAsync(ListEntityReconciliationJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Entity Reconciliation Jobs.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the EntityReconciliationJob's parent resource.
        /// Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="EntityReconciliationJob"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEntityReconciliationJobsResponse, EntityReconciliationJob> ListEntityReconciliationJobs(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListEntityReconciliationJobs(new ListEntityReconciliationJobsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists Entity Reconciliation Jobs.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the EntityReconciliationJob's parent resource.
        /// Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="EntityReconciliationJob"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEntityReconciliationJobsResponse, EntityReconciliationJob> ListEntityReconciliationJobsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListEntityReconciliationJobsAsync(new ListEntityReconciliationJobsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists Entity Reconciliation Jobs.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the EntityReconciliationJob's parent resource.
        /// Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="EntityReconciliationJob"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEntityReconciliationJobsResponse, EntityReconciliationJob> ListEntityReconciliationJobs(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListEntityReconciliationJobs(new ListEntityReconciliationJobsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists Entity Reconciliation Jobs.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the EntityReconciliationJob's parent resource.
        /// Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="EntityReconciliationJob"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEntityReconciliationJobsResponse, EntityReconciliationJob> ListEntityReconciliationJobsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListEntityReconciliationJobsAsync(new ListEntityReconciliationJobsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Cancels a EntityReconciliationJob. Success of cancellation is not
        /// guaranteed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void CancelEntityReconciliationJob(CancelEntityReconciliationJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Cancels a EntityReconciliationJob. Success of cancellation is not
        /// guaranteed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CancelEntityReconciliationJobAsync(CancelEntityReconciliationJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Cancels a EntityReconciliationJob. Success of cancellation is not
        /// guaranteed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CancelEntityReconciliationJobAsync(CancelEntityReconciliationJobRequest request, st::CancellationToken cancellationToken) =>
            CancelEntityReconciliationJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Cancels a EntityReconciliationJob. Success of cancellation is not
        /// guaranteed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the EntityReconciliationJob resource.
        /// Format:
        /// `projects/{project}/locations/{location}/entityReconciliationJobs/{entity_reconciliation_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void CancelEntityReconciliationJob(string name, gaxgrpc::CallSettings callSettings = null) =>
            CancelEntityReconciliationJob(new CancelEntityReconciliationJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Cancels a EntityReconciliationJob. Success of cancellation is not
        /// guaranteed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the EntityReconciliationJob resource.
        /// Format:
        /// `projects/{project}/locations/{location}/entityReconciliationJobs/{entity_reconciliation_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CancelEntityReconciliationJobAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            CancelEntityReconciliationJobAsync(new CancelEntityReconciliationJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Cancels a EntityReconciliationJob. Success of cancellation is not
        /// guaranteed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the EntityReconciliationJob resource.
        /// Format:
        /// `projects/{project}/locations/{location}/entityReconciliationJobs/{entity_reconciliation_job}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CancelEntityReconciliationJobAsync(string name, st::CancellationToken cancellationToken) =>
            CancelEntityReconciliationJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Cancels a EntityReconciliationJob. Success of cancellation is not
        /// guaranteed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the EntityReconciliationJob resource.
        /// Format:
        /// `projects/{project}/locations/{location}/entityReconciliationJobs/{entity_reconciliation_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void CancelEntityReconciliationJob(EntityReconciliationJobName name, gaxgrpc::CallSettings callSettings = null) =>
            CancelEntityReconciliationJob(new CancelEntityReconciliationJobRequest
            {
                EntityReconciliationJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Cancels a EntityReconciliationJob. Success of cancellation is not
        /// guaranteed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the EntityReconciliationJob resource.
        /// Format:
        /// `projects/{project}/locations/{location}/entityReconciliationJobs/{entity_reconciliation_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CancelEntityReconciliationJobAsync(EntityReconciliationJobName name, gaxgrpc::CallSettings callSettings = null) =>
            CancelEntityReconciliationJobAsync(new CancelEntityReconciliationJobRequest
            {
                EntityReconciliationJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Cancels a EntityReconciliationJob. Success of cancellation is not
        /// guaranteed.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the EntityReconciliationJob resource.
        /// Format:
        /// `projects/{project}/locations/{location}/entityReconciliationJobs/{entity_reconciliation_job}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CancelEntityReconciliationJobAsync(EntityReconciliationJobName name, st::CancellationToken cancellationToken) =>
            CancelEntityReconciliationJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a EntityReconciliationJob.
        /// It only deletes the job when the job state is in FAILED, SUCCEEDED, and
        /// CANCELLED.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteEntityReconciliationJob(DeleteEntityReconciliationJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a EntityReconciliationJob.
        /// It only deletes the job when the job state is in FAILED, SUCCEEDED, and
        /// CANCELLED.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEntityReconciliationJobAsync(DeleteEntityReconciliationJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a EntityReconciliationJob.
        /// It only deletes the job when the job state is in FAILED, SUCCEEDED, and
        /// CANCELLED.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEntityReconciliationJobAsync(DeleteEntityReconciliationJobRequest request, st::CancellationToken cancellationToken) =>
            DeleteEntityReconciliationJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a EntityReconciliationJob.
        /// It only deletes the job when the job state is in FAILED, SUCCEEDED, and
        /// CANCELLED.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the EntityReconciliationJob resource.
        /// Format:
        /// `projects/{project}/locations/{location}/entityReconciliationJobs/{entity_reconciliation_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteEntityReconciliationJob(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEntityReconciliationJob(new DeleteEntityReconciliationJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a EntityReconciliationJob.
        /// It only deletes the job when the job state is in FAILED, SUCCEEDED, and
        /// CANCELLED.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the EntityReconciliationJob resource.
        /// Format:
        /// `projects/{project}/locations/{location}/entityReconciliationJobs/{entity_reconciliation_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEntityReconciliationJobAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEntityReconciliationJobAsync(new DeleteEntityReconciliationJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a EntityReconciliationJob.
        /// It only deletes the job when the job state is in FAILED, SUCCEEDED, and
        /// CANCELLED.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the EntityReconciliationJob resource.
        /// Format:
        /// `projects/{project}/locations/{location}/entityReconciliationJobs/{entity_reconciliation_job}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEntityReconciliationJobAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteEntityReconciliationJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a EntityReconciliationJob.
        /// It only deletes the job when the job state is in FAILED, SUCCEEDED, and
        /// CANCELLED.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the EntityReconciliationJob resource.
        /// Format:
        /// `projects/{project}/locations/{location}/entityReconciliationJobs/{entity_reconciliation_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteEntityReconciliationJob(EntityReconciliationJobName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEntityReconciliationJob(new DeleteEntityReconciliationJobRequest
            {
                EntityReconciliationJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a EntityReconciliationJob.
        /// It only deletes the job when the job state is in FAILED, SUCCEEDED, and
        /// CANCELLED.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the EntityReconciliationJob resource.
        /// Format:
        /// `projects/{project}/locations/{location}/entityReconciliationJobs/{entity_reconciliation_job}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEntityReconciliationJobAsync(EntityReconciliationJobName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEntityReconciliationJobAsync(new DeleteEntityReconciliationJobRequest
            {
                EntityReconciliationJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a EntityReconciliationJob.
        /// It only deletes the job when the job state is in FAILED, SUCCEEDED, and
        /// CANCELLED.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the EntityReconciliationJob resource.
        /// Format:
        /// `projects/{project}/locations/{location}/entityReconciliationJobs/{entity_reconciliation_job}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEntityReconciliationJobAsync(EntityReconciliationJobName name, st::CancellationToken cancellationToken) =>
            DeleteEntityReconciliationJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>EnterpriseKnowledgeGraphService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// APIs for enterprise knowledge graph product.
    /// </remarks>
    public sealed partial class EnterpriseKnowledgeGraphServiceClientImpl : EnterpriseKnowledgeGraphServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateEntityReconciliationJobRequest, EntityReconciliationJob> _callCreateEntityReconciliationJob;

        private readonly gaxgrpc::ApiCall<GetEntityReconciliationJobRequest, EntityReconciliationJob> _callGetEntityReconciliationJob;

        private readonly gaxgrpc::ApiCall<ListEntityReconciliationJobsRequest, ListEntityReconciliationJobsResponse> _callListEntityReconciliationJobs;

        private readonly gaxgrpc::ApiCall<CancelEntityReconciliationJobRequest, wkt::Empty> _callCancelEntityReconciliationJob;

        private readonly gaxgrpc::ApiCall<DeleteEntityReconciliationJobRequest, wkt::Empty> _callDeleteEntityReconciliationJob;

        /// <summary>
        /// Constructs a client wrapper for the EnterpriseKnowledgeGraphService service, with the specified gRPC client
        /// and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="EnterpriseKnowledgeGraphServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public EnterpriseKnowledgeGraphServiceClientImpl(EnterpriseKnowledgeGraphService.EnterpriseKnowledgeGraphServiceClient grpcClient, EnterpriseKnowledgeGraphServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            EnterpriseKnowledgeGraphServiceSettings effectiveSettings = settings ?? EnterpriseKnowledgeGraphServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings, logger);
            _callCreateEntityReconciliationJob = clientHelper.BuildApiCall<CreateEntityReconciliationJobRequest, EntityReconciliationJob>("CreateEntityReconciliationJob", grpcClient.CreateEntityReconciliationJobAsync, grpcClient.CreateEntityReconciliationJob, effectiveSettings.CreateEntityReconciliationJobSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateEntityReconciliationJob);
            Modify_CreateEntityReconciliationJobApiCall(ref _callCreateEntityReconciliationJob);
            _callGetEntityReconciliationJob = clientHelper.BuildApiCall<GetEntityReconciliationJobRequest, EntityReconciliationJob>("GetEntityReconciliationJob", grpcClient.GetEntityReconciliationJobAsync, grpcClient.GetEntityReconciliationJob, effectiveSettings.GetEntityReconciliationJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetEntityReconciliationJob);
            Modify_GetEntityReconciliationJobApiCall(ref _callGetEntityReconciliationJob);
            _callListEntityReconciliationJobs = clientHelper.BuildApiCall<ListEntityReconciliationJobsRequest, ListEntityReconciliationJobsResponse>("ListEntityReconciliationJobs", grpcClient.ListEntityReconciliationJobsAsync, grpcClient.ListEntityReconciliationJobs, effectiveSettings.ListEntityReconciliationJobsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListEntityReconciliationJobs);
            Modify_ListEntityReconciliationJobsApiCall(ref _callListEntityReconciliationJobs);
            _callCancelEntityReconciliationJob = clientHelper.BuildApiCall<CancelEntityReconciliationJobRequest, wkt::Empty>("CancelEntityReconciliationJob", grpcClient.CancelEntityReconciliationJobAsync, grpcClient.CancelEntityReconciliationJob, effectiveSettings.CancelEntityReconciliationJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callCancelEntityReconciliationJob);
            Modify_CancelEntityReconciliationJobApiCall(ref _callCancelEntityReconciliationJob);
            _callDeleteEntityReconciliationJob = clientHelper.BuildApiCall<DeleteEntityReconciliationJobRequest, wkt::Empty>("DeleteEntityReconciliationJob", grpcClient.DeleteEntityReconciliationJobAsync, grpcClient.DeleteEntityReconciliationJob, effectiveSettings.DeleteEntityReconciliationJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteEntityReconciliationJob);
            Modify_DeleteEntityReconciliationJobApiCall(ref _callDeleteEntityReconciliationJob);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateEntityReconciliationJobApiCall(ref gaxgrpc::ApiCall<CreateEntityReconciliationJobRequest, EntityReconciliationJob> call);

        partial void Modify_GetEntityReconciliationJobApiCall(ref gaxgrpc::ApiCall<GetEntityReconciliationJobRequest, EntityReconciliationJob> call);

        partial void Modify_ListEntityReconciliationJobsApiCall(ref gaxgrpc::ApiCall<ListEntityReconciliationJobsRequest, ListEntityReconciliationJobsResponse> call);

        partial void Modify_CancelEntityReconciliationJobApiCall(ref gaxgrpc::ApiCall<CancelEntityReconciliationJobRequest, wkt::Empty> call);

        partial void Modify_DeleteEntityReconciliationJobApiCall(ref gaxgrpc::ApiCall<DeleteEntityReconciliationJobRequest, wkt::Empty> call);

        partial void OnConstruction(EnterpriseKnowledgeGraphService.EnterpriseKnowledgeGraphServiceClient grpcClient, EnterpriseKnowledgeGraphServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC EnterpriseKnowledgeGraphService client</summary>
        public override EnterpriseKnowledgeGraphService.EnterpriseKnowledgeGraphServiceClient GrpcClient { get; }

        partial void Modify_CreateEntityReconciliationJobRequest(ref CreateEntityReconciliationJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetEntityReconciliationJobRequest(ref GetEntityReconciliationJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListEntityReconciliationJobsRequest(ref ListEntityReconciliationJobsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CancelEntityReconciliationJobRequest(ref CancelEntityReconciliationJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteEntityReconciliationJobRequest(ref DeleteEntityReconciliationJobRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a EntityReconciliationJob. A EntityReconciliationJob once created
        /// will right away be attempted to start.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override EntityReconciliationJob CreateEntityReconciliationJob(CreateEntityReconciliationJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEntityReconciliationJobRequest(ref request, ref callSettings);
            return _callCreateEntityReconciliationJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a EntityReconciliationJob. A EntityReconciliationJob once created
        /// will right away be attempted to start.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<EntityReconciliationJob> CreateEntityReconciliationJobAsync(CreateEntityReconciliationJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEntityReconciliationJobRequest(ref request, ref callSettings);
            return _callCreateEntityReconciliationJob.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a EntityReconciliationJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override EntityReconciliationJob GetEntityReconciliationJob(GetEntityReconciliationJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEntityReconciliationJobRequest(ref request, ref callSettings);
            return _callGetEntityReconciliationJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a EntityReconciliationJob.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<EntityReconciliationJob> GetEntityReconciliationJobAsync(GetEntityReconciliationJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEntityReconciliationJobRequest(ref request, ref callSettings);
            return _callGetEntityReconciliationJob.Async(request, callSettings);
        }

        /// <summary>
        /// Lists Entity Reconciliation Jobs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="EntityReconciliationJob"/> resources.</returns>
        public override gax::PagedEnumerable<ListEntityReconciliationJobsResponse, EntityReconciliationJob> ListEntityReconciliationJobs(ListEntityReconciliationJobsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEntityReconciliationJobsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListEntityReconciliationJobsRequest, ListEntityReconciliationJobsResponse, EntityReconciliationJob>(_callListEntityReconciliationJobs, request, callSettings);
        }

        /// <summary>
        /// Lists Entity Reconciliation Jobs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="EntityReconciliationJob"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListEntityReconciliationJobsResponse, EntityReconciliationJob> ListEntityReconciliationJobsAsync(ListEntityReconciliationJobsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEntityReconciliationJobsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListEntityReconciliationJobsRequest, ListEntityReconciliationJobsResponse, EntityReconciliationJob>(_callListEntityReconciliationJobs, request, callSettings);
        }

        /// <summary>
        /// Cancels a EntityReconciliationJob. Success of cancellation is not
        /// guaranteed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void CancelEntityReconciliationJob(CancelEntityReconciliationJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelEntityReconciliationJobRequest(ref request, ref callSettings);
            _callCancelEntityReconciliationJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Cancels a EntityReconciliationJob. Success of cancellation is not
        /// guaranteed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task CancelEntityReconciliationJobAsync(CancelEntityReconciliationJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelEntityReconciliationJobRequest(ref request, ref callSettings);
            return _callCancelEntityReconciliationJob.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a EntityReconciliationJob.
        /// It only deletes the job when the job state is in FAILED, SUCCEEDED, and
        /// CANCELLED.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteEntityReconciliationJob(DeleteEntityReconciliationJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEntityReconciliationJobRequest(ref request, ref callSettings);
            _callDeleteEntityReconciliationJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a EntityReconciliationJob.
        /// It only deletes the job when the job state is in FAILED, SUCCEEDED, and
        /// CANCELLED.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteEntityReconciliationJobAsync(DeleteEntityReconciliationJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEntityReconciliationJobRequest(ref request, ref callSettings);
            return _callDeleteEntityReconciliationJob.Async(request, callSettings);
        }
    }

    public partial class ListEntityReconciliationJobsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListEntityReconciliationJobsResponse : gaxgrpc::IPageResponse<EntityReconciliationJob>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<EntityReconciliationJob> GetEnumerator() => EntityReconciliationJobs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}