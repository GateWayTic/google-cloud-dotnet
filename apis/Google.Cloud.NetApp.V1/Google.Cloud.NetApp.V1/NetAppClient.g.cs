// Copyright 2023 Google LLC
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
using gcl = Google.Cloud.Location;
using lro = Google.LongRunning;
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

namespace Google.Cloud.NetApp.V1
{
    /// <summary>Settings for <see cref="NetAppClient"/> instances.</summary>
    public sealed partial class NetAppSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="NetAppSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="NetAppSettings"/>.</returns>
        public static NetAppSettings GetDefault() => new NetAppSettings();

        /// <summary>Constructs a new <see cref="NetAppSettings"/> object with default settings.</summary>
        public NetAppSettings()
        {
        }

        private NetAppSettings(NetAppSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListStoragePoolsSettings = existing.ListStoragePoolsSettings;
            CreateStoragePoolSettings = existing.CreateStoragePoolSettings;
            CreateStoragePoolOperationsSettings = existing.CreateStoragePoolOperationsSettings.Clone();
            GetStoragePoolSettings = existing.GetStoragePoolSettings;
            UpdateStoragePoolSettings = existing.UpdateStoragePoolSettings;
            UpdateStoragePoolOperationsSettings = existing.UpdateStoragePoolOperationsSettings.Clone();
            DeleteStoragePoolSettings = existing.DeleteStoragePoolSettings;
            DeleteStoragePoolOperationsSettings = existing.DeleteStoragePoolOperationsSettings.Clone();
            ListVolumesSettings = existing.ListVolumesSettings;
            GetVolumeSettings = existing.GetVolumeSettings;
            CreateVolumeSettings = existing.CreateVolumeSettings;
            CreateVolumeOperationsSettings = existing.CreateVolumeOperationsSettings.Clone();
            UpdateVolumeSettings = existing.UpdateVolumeSettings;
            UpdateVolumeOperationsSettings = existing.UpdateVolumeOperationsSettings.Clone();
            DeleteVolumeSettings = existing.DeleteVolumeSettings;
            DeleteVolumeOperationsSettings = existing.DeleteVolumeOperationsSettings.Clone();
            RevertVolumeSettings = existing.RevertVolumeSettings;
            RevertVolumeOperationsSettings = existing.RevertVolumeOperationsSettings.Clone();
            ListSnapshotsSettings = existing.ListSnapshotsSettings;
            GetSnapshotSettings = existing.GetSnapshotSettings;
            CreateSnapshotSettings = existing.CreateSnapshotSettings;
            CreateSnapshotOperationsSettings = existing.CreateSnapshotOperationsSettings.Clone();
            DeleteSnapshotSettings = existing.DeleteSnapshotSettings;
            DeleteSnapshotOperationsSettings = existing.DeleteSnapshotOperationsSettings.Clone();
            UpdateSnapshotSettings = existing.UpdateSnapshotSettings;
            UpdateSnapshotOperationsSettings = existing.UpdateSnapshotOperationsSettings.Clone();
            ListActiveDirectoriesSettings = existing.ListActiveDirectoriesSettings;
            GetActiveDirectorySettings = existing.GetActiveDirectorySettings;
            CreateActiveDirectorySettings = existing.CreateActiveDirectorySettings;
            CreateActiveDirectoryOperationsSettings = existing.CreateActiveDirectoryOperationsSettings.Clone();
            UpdateActiveDirectorySettings = existing.UpdateActiveDirectorySettings;
            UpdateActiveDirectoryOperationsSettings = existing.UpdateActiveDirectoryOperationsSettings.Clone();
            DeleteActiveDirectorySettings = existing.DeleteActiveDirectorySettings;
            DeleteActiveDirectoryOperationsSettings = existing.DeleteActiveDirectoryOperationsSettings.Clone();
            ListKmsConfigsSettings = existing.ListKmsConfigsSettings;
            CreateKmsConfigSettings = existing.CreateKmsConfigSettings;
            CreateKmsConfigOperationsSettings = existing.CreateKmsConfigOperationsSettings.Clone();
            GetKmsConfigSettings = existing.GetKmsConfigSettings;
            UpdateKmsConfigSettings = existing.UpdateKmsConfigSettings;
            UpdateKmsConfigOperationsSettings = existing.UpdateKmsConfigOperationsSettings.Clone();
            EncryptVolumesSettings = existing.EncryptVolumesSettings;
            EncryptVolumesOperationsSettings = existing.EncryptVolumesOperationsSettings.Clone();
            VerifyKmsConfigSettings = existing.VerifyKmsConfigSettings;
            DeleteKmsConfigSettings = existing.DeleteKmsConfigSettings;
            DeleteKmsConfigOperationsSettings = existing.DeleteKmsConfigOperationsSettings.Clone();
            ListReplicationsSettings = existing.ListReplicationsSettings;
            GetReplicationSettings = existing.GetReplicationSettings;
            CreateReplicationSettings = existing.CreateReplicationSettings;
            CreateReplicationOperationsSettings = existing.CreateReplicationOperationsSettings.Clone();
            DeleteReplicationSettings = existing.DeleteReplicationSettings;
            DeleteReplicationOperationsSettings = existing.DeleteReplicationOperationsSettings.Clone();
            UpdateReplicationSettings = existing.UpdateReplicationSettings;
            UpdateReplicationOperationsSettings = existing.UpdateReplicationOperationsSettings.Clone();
            StopReplicationSettings = existing.StopReplicationSettings;
            StopReplicationOperationsSettings = existing.StopReplicationOperationsSettings.Clone();
            ResumeReplicationSettings = existing.ResumeReplicationSettings;
            ResumeReplicationOperationsSettings = existing.ResumeReplicationOperationsSettings.Clone();
            ReverseReplicationDirectionSettings = existing.ReverseReplicationDirectionSettings;
            ReverseReplicationDirectionOperationsSettings = existing.ReverseReplicationDirectionOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(NetAppSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetAppClient.ListStoragePools</c> and <c>NetAppClient.ListStoragePoolsAsync</c>.
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
        public gaxgrpc::CallSettings ListStoragePoolsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetAppClient.CreateStoragePool</c> and <c>NetAppClient.CreateStoragePoolAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateStoragePoolSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetAppClient.CreateStoragePool</c> and
        /// <c>NetAppClient.CreateStoragePoolAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings CreateStoragePoolOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>NetAppClient.GetStoragePool</c>
        ///  and <c>NetAppClient.GetStoragePoolAsync</c>.
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
        public gaxgrpc::CallSettings GetStoragePoolSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetAppClient.UpdateStoragePool</c> and <c>NetAppClient.UpdateStoragePoolAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateStoragePoolSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetAppClient.UpdateStoragePool</c> and
        /// <c>NetAppClient.UpdateStoragePoolAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings UpdateStoragePoolOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetAppClient.DeleteStoragePool</c> and <c>NetAppClient.DeleteStoragePoolAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteStoragePoolSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetAppClient.DeleteStoragePool</c> and
        /// <c>NetAppClient.DeleteStoragePoolAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings DeleteStoragePoolOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>NetAppClient.ListVolumes</c>
        ///  and <c>NetAppClient.ListVolumesAsync</c>.
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
        public gaxgrpc::CallSettings ListVolumesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>NetAppClient.GetVolume</c>
        /// and <c>NetAppClient.GetVolumeAsync</c>.
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
        public gaxgrpc::CallSettings GetVolumeSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>NetAppClient.CreateVolume</c>
        ///  and <c>NetAppClient.CreateVolumeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateVolumeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetAppClient.CreateVolume</c> and
        /// <c>NetAppClient.CreateVolumeAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings CreateVolumeOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>NetAppClient.UpdateVolume</c>
        ///  and <c>NetAppClient.UpdateVolumeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateVolumeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetAppClient.UpdateVolume</c> and
        /// <c>NetAppClient.UpdateVolumeAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings UpdateVolumeOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>NetAppClient.DeleteVolume</c>
        ///  and <c>NetAppClient.DeleteVolumeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteVolumeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetAppClient.DeleteVolume</c> and
        /// <c>NetAppClient.DeleteVolumeAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings DeleteVolumeOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>NetAppClient.RevertVolume</c>
        ///  and <c>NetAppClient.RevertVolumeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RevertVolumeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetAppClient.RevertVolume</c> and
        /// <c>NetAppClient.RevertVolumeAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings RevertVolumeOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>NetAppClient.ListSnapshots</c>
        ///  and <c>NetAppClient.ListSnapshotsAsync</c>.
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
        public gaxgrpc::CallSettings ListSnapshotsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>NetAppClient.GetSnapshot</c>
        ///  and <c>NetAppClient.GetSnapshotAsync</c>.
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
        public gaxgrpc::CallSettings GetSnapshotSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>NetAppClient.CreateSnapshot</c>
        ///  and <c>NetAppClient.CreateSnapshotAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateSnapshotSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetAppClient.CreateSnapshot</c> and
        /// <c>NetAppClient.CreateSnapshotAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings CreateSnapshotOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>NetAppClient.DeleteSnapshot</c>
        ///  and <c>NetAppClient.DeleteSnapshotAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSnapshotSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetAppClient.DeleteSnapshot</c> and
        /// <c>NetAppClient.DeleteSnapshotAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings DeleteSnapshotOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>NetAppClient.UpdateSnapshot</c>
        ///  and <c>NetAppClient.UpdateSnapshotAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateSnapshotSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetAppClient.UpdateSnapshot</c> and
        /// <c>NetAppClient.UpdateSnapshotAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings UpdateSnapshotOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetAppClient.ListActiveDirectories</c> and <c>NetAppClient.ListActiveDirectoriesAsync</c>.
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
        public gaxgrpc::CallSettings ListActiveDirectoriesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetAppClient.GetActiveDirectory</c> and <c>NetAppClient.GetActiveDirectoryAsync</c>.
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
        public gaxgrpc::CallSettings GetActiveDirectorySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetAppClient.CreateActiveDirectory</c> and <c>NetAppClient.CreateActiveDirectoryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateActiveDirectorySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetAppClient.CreateActiveDirectory</c> and
        /// <c>NetAppClient.CreateActiveDirectoryAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings CreateActiveDirectoryOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetAppClient.UpdateActiveDirectory</c> and <c>NetAppClient.UpdateActiveDirectoryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateActiveDirectorySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetAppClient.UpdateActiveDirectory</c> and
        /// <c>NetAppClient.UpdateActiveDirectoryAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings UpdateActiveDirectoryOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetAppClient.DeleteActiveDirectory</c> and <c>NetAppClient.DeleteActiveDirectoryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteActiveDirectorySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetAppClient.DeleteActiveDirectory</c> and
        /// <c>NetAppClient.DeleteActiveDirectoryAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings DeleteActiveDirectoryOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>NetAppClient.ListKmsConfigs</c>
        ///  and <c>NetAppClient.ListKmsConfigsAsync</c>.
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
        public gaxgrpc::CallSettings ListKmsConfigsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetAppClient.CreateKmsConfig</c> and <c>NetAppClient.CreateKmsConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateKmsConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetAppClient.CreateKmsConfig</c> and
        /// <c>NetAppClient.CreateKmsConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings CreateKmsConfigOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>NetAppClient.GetKmsConfig</c>
        ///  and <c>NetAppClient.GetKmsConfigAsync</c>.
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
        public gaxgrpc::CallSettings GetKmsConfigSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetAppClient.UpdateKmsConfig</c> and <c>NetAppClient.UpdateKmsConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateKmsConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetAppClient.UpdateKmsConfig</c> and
        /// <c>NetAppClient.UpdateKmsConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings UpdateKmsConfigOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>NetAppClient.EncryptVolumes</c>
        ///  and <c>NetAppClient.EncryptVolumesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings EncryptVolumesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetAppClient.EncryptVolumes</c> and
        /// <c>NetAppClient.EncryptVolumesAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings EncryptVolumesOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetAppClient.VerifyKmsConfig</c> and <c>NetAppClient.VerifyKmsConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings VerifyKmsConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetAppClient.DeleteKmsConfig</c> and <c>NetAppClient.DeleteKmsConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteKmsConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetAppClient.DeleteKmsConfig</c> and
        /// <c>NetAppClient.DeleteKmsConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings DeleteKmsConfigOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetAppClient.ListReplications</c> and <c>NetAppClient.ListReplicationsAsync</c>.
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
        public gaxgrpc::CallSettings ListReplicationsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>NetAppClient.GetReplication</c>
        ///  and <c>NetAppClient.GetReplicationAsync</c>.
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
        public gaxgrpc::CallSettings GetReplicationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetAppClient.CreateReplication</c> and <c>NetAppClient.CreateReplicationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateReplicationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetAppClient.CreateReplication</c> and
        /// <c>NetAppClient.CreateReplicationAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings CreateReplicationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetAppClient.DeleteReplication</c> and <c>NetAppClient.DeleteReplicationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteReplicationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetAppClient.DeleteReplication</c> and
        /// <c>NetAppClient.DeleteReplicationAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings DeleteReplicationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetAppClient.UpdateReplication</c> and <c>NetAppClient.UpdateReplicationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateReplicationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetAppClient.UpdateReplication</c> and
        /// <c>NetAppClient.UpdateReplicationAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings UpdateReplicationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetAppClient.StopReplication</c> and <c>NetAppClient.StopReplicationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StopReplicationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetAppClient.StopReplication</c> and
        /// <c>NetAppClient.StopReplicationAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings StopReplicationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetAppClient.ResumeReplication</c> and <c>NetAppClient.ResumeReplicationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ResumeReplicationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetAppClient.ResumeReplication</c> and
        /// <c>NetAppClient.ResumeReplicationAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings ResumeReplicationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetAppClient.ReverseReplicationDirection</c> and <c>NetAppClient.ReverseReplicationDirectionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ReverseReplicationDirectionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NetAppClient.ReverseReplicationDirection</c> and
        /// <c>NetAppClient.ReverseReplicationDirectionAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings ReverseReplicationDirectionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="NetAppSettings"/> object.</returns>
        public NetAppSettings Clone() => new NetAppSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="NetAppClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class NetAppClientBuilder : gaxgrpc::ClientBuilderBase<NetAppClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public NetAppSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public NetAppClientBuilder() : base(NetAppClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref NetAppClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<NetAppClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override NetAppClient Build()
        {
            NetAppClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<NetAppClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<NetAppClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private NetAppClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return NetAppClient.Create(callInvoker, Settings, Logger);
        }

        private async stt::Task<NetAppClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return NetAppClient.Create(callInvoker, Settings, Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => NetAppClient.ChannelPool;
    }

    /// <summary>NetApp client wrapper, for convenient use.</summary>
    /// <remarks>
    /// NetApp Files Google Cloud Service
    /// </remarks>
    public abstract partial class NetAppClient
    {
        /// <summary>
        /// The default endpoint for the NetApp service, which is a host of "netapp.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "netapp.googleapis.com:443";

        /// <summary>The default NetApp scopes.</summary>
        /// <remarks>
        /// The default NetApp scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(NetApp.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="NetAppClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="NetAppClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="NetAppClient"/>.</returns>
        public static stt::Task<NetAppClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new NetAppClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="NetAppClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="NetAppClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="NetAppClient"/>.</returns>
        public static NetAppClient Create() => new NetAppClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="NetAppClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="NetAppSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="NetAppClient"/>.</returns>
        internal static NetAppClient Create(grpccore::CallInvoker callInvoker, NetAppSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            NetApp.NetAppClient grpcClient = new NetApp.NetAppClient(callInvoker);
            return new NetAppClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC NetApp client</summary>
        public virtual NetApp.NetAppClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns descriptions of all storage pools owned by the caller.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="StoragePool"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListStoragePoolsResponse, StoragePool> ListStoragePools(ListStoragePoolsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns descriptions of all storage pools owned by the caller.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="StoragePool"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListStoragePoolsResponse, StoragePool> ListStoragePoolsAsync(ListStoragePoolsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns descriptions of all storage pools owned by the caller.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value
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
        /// <returns>A pageable sequence of <see cref="StoragePool"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListStoragePoolsResponse, StoragePool> ListStoragePools(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListStoragePools(new ListStoragePoolsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns descriptions of all storage pools owned by the caller.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value
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
        /// <returns>A pageable asynchronous sequence of <see cref="StoragePool"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListStoragePoolsResponse, StoragePool> ListStoragePoolsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListStoragePoolsAsync(new ListStoragePoolsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns descriptions of all storage pools owned by the caller.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value
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
        /// <returns>A pageable sequence of <see cref="StoragePool"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListStoragePoolsResponse, StoragePool> ListStoragePools(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListStoragePools(new ListStoragePoolsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns descriptions of all storage pools owned by the caller.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value
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
        /// <returns>A pageable asynchronous sequence of <see cref="StoragePool"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListStoragePoolsResponse, StoragePool> ListStoragePoolsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListStoragePoolsAsync(new ListStoragePoolsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Creates a new storage pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<StoragePool, OperationMetadata> CreateStoragePool(CreateStoragePoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new storage pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<StoragePool, OperationMetadata>> CreateStoragePoolAsync(CreateStoragePoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new storage pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<StoragePool, OperationMetadata>> CreateStoragePoolAsync(CreateStoragePoolRequest request, st::CancellationToken cancellationToken) =>
            CreateStoragePoolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateStoragePool</c>.</summary>
        public virtual lro::OperationsClient CreateStoragePoolOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateStoragePool</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<StoragePool, OperationMetadata> PollOnceCreateStoragePool(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<StoragePool, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateStoragePoolOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateStoragePool</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<StoragePool, OperationMetadata>> PollOnceCreateStoragePoolAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<StoragePool, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateStoragePoolOperationsClient, callSettings);

        /// <summary>
        /// Creates a new storage pool.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="storagePool">
        /// Required. The required parameters to create a new storage pool.
        /// </param>
        /// <param name="storagePoolId">
        /// Required. Id of the requesting storage pool
        /// If auto-generating Id server-side, remove this field and
        /// id from the method_signature of Create RPC
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<StoragePool, OperationMetadata> CreateStoragePool(string parent, StoragePool storagePool, string storagePoolId, gaxgrpc::CallSettings callSettings = null) =>
            CreateStoragePool(new CreateStoragePoolRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                StoragePoolId = gax::GaxPreconditions.CheckNotNullOrEmpty(storagePoolId, nameof(storagePoolId)),
                StoragePool = gax::GaxPreconditions.CheckNotNull(storagePool, nameof(storagePool)),
            }, callSettings);

        /// <summary>
        /// Creates a new storage pool.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="storagePool">
        /// Required. The required parameters to create a new storage pool.
        /// </param>
        /// <param name="storagePoolId">
        /// Required. Id of the requesting storage pool
        /// If auto-generating Id server-side, remove this field and
        /// id from the method_signature of Create RPC
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<StoragePool, OperationMetadata>> CreateStoragePoolAsync(string parent, StoragePool storagePool, string storagePoolId, gaxgrpc::CallSettings callSettings = null) =>
            CreateStoragePoolAsync(new CreateStoragePoolRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                StoragePoolId = gax::GaxPreconditions.CheckNotNullOrEmpty(storagePoolId, nameof(storagePoolId)),
                StoragePool = gax::GaxPreconditions.CheckNotNull(storagePool, nameof(storagePool)),
            }, callSettings);

        /// <summary>
        /// Creates a new storage pool.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="storagePool">
        /// Required. The required parameters to create a new storage pool.
        /// </param>
        /// <param name="storagePoolId">
        /// Required. Id of the requesting storage pool
        /// If auto-generating Id server-side, remove this field and
        /// id from the method_signature of Create RPC
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<StoragePool, OperationMetadata>> CreateStoragePoolAsync(string parent, StoragePool storagePool, string storagePoolId, st::CancellationToken cancellationToken) =>
            CreateStoragePoolAsync(parent, storagePool, storagePoolId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new storage pool.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="storagePool">
        /// Required. The required parameters to create a new storage pool.
        /// </param>
        /// <param name="storagePoolId">
        /// Required. Id of the requesting storage pool
        /// If auto-generating Id server-side, remove this field and
        /// id from the method_signature of Create RPC
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<StoragePool, OperationMetadata> CreateStoragePool(gagr::LocationName parent, StoragePool storagePool, string storagePoolId, gaxgrpc::CallSettings callSettings = null) =>
            CreateStoragePool(new CreateStoragePoolRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                StoragePoolId = gax::GaxPreconditions.CheckNotNullOrEmpty(storagePoolId, nameof(storagePoolId)),
                StoragePool = gax::GaxPreconditions.CheckNotNull(storagePool, nameof(storagePool)),
            }, callSettings);

        /// <summary>
        /// Creates a new storage pool.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="storagePool">
        /// Required. The required parameters to create a new storage pool.
        /// </param>
        /// <param name="storagePoolId">
        /// Required. Id of the requesting storage pool
        /// If auto-generating Id server-side, remove this field and
        /// id from the method_signature of Create RPC
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<StoragePool, OperationMetadata>> CreateStoragePoolAsync(gagr::LocationName parent, StoragePool storagePool, string storagePoolId, gaxgrpc::CallSettings callSettings = null) =>
            CreateStoragePoolAsync(new CreateStoragePoolRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                StoragePoolId = gax::GaxPreconditions.CheckNotNullOrEmpty(storagePoolId, nameof(storagePoolId)),
                StoragePool = gax::GaxPreconditions.CheckNotNull(storagePool, nameof(storagePool)),
            }, callSettings);

        /// <summary>
        /// Creates a new storage pool.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="storagePool">
        /// Required. The required parameters to create a new storage pool.
        /// </param>
        /// <param name="storagePoolId">
        /// Required. Id of the requesting storage pool
        /// If auto-generating Id server-side, remove this field and
        /// id from the method_signature of Create RPC
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<StoragePool, OperationMetadata>> CreateStoragePoolAsync(gagr::LocationName parent, StoragePool storagePool, string storagePoolId, st::CancellationToken cancellationToken) =>
            CreateStoragePoolAsync(parent, storagePool, storagePoolId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the description of the specified storage pool by poolId.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual StoragePool GetStoragePool(GetStoragePoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the description of the specified storage pool by poolId.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StoragePool> GetStoragePoolAsync(GetStoragePoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the description of the specified storage pool by poolId.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StoragePool> GetStoragePoolAsync(GetStoragePoolRequest request, st::CancellationToken cancellationToken) =>
            GetStoragePoolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the description of the specified storage pool by poolId.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the storage pool
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual StoragePool GetStoragePool(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetStoragePool(new GetStoragePoolRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the description of the specified storage pool by poolId.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the storage pool
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StoragePool> GetStoragePoolAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetStoragePoolAsync(new GetStoragePoolRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the description of the specified storage pool by poolId.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the storage pool
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StoragePool> GetStoragePoolAsync(string name, st::CancellationToken cancellationToken) =>
            GetStoragePoolAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the description of the specified storage pool by poolId.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the storage pool
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual StoragePool GetStoragePool(StoragePoolName name, gaxgrpc::CallSettings callSettings = null) =>
            GetStoragePool(new GetStoragePoolRequest
            {
                StoragePoolName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the description of the specified storage pool by poolId.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the storage pool
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StoragePool> GetStoragePoolAsync(StoragePoolName name, gaxgrpc::CallSettings callSettings = null) =>
            GetStoragePoolAsync(new GetStoragePoolRequest
            {
                StoragePoolName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the description of the specified storage pool by poolId.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the storage pool
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StoragePool> GetStoragePoolAsync(StoragePoolName name, st::CancellationToken cancellationToken) =>
            GetStoragePoolAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the storage pool properties with the full spec
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<StoragePool, OperationMetadata> UpdateStoragePool(UpdateStoragePoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the storage pool properties with the full spec
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<StoragePool, OperationMetadata>> UpdateStoragePoolAsync(UpdateStoragePoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the storage pool properties with the full spec
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<StoragePool, OperationMetadata>> UpdateStoragePoolAsync(UpdateStoragePoolRequest request, st::CancellationToken cancellationToken) =>
            UpdateStoragePoolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateStoragePool</c>.</summary>
        public virtual lro::OperationsClient UpdateStoragePoolOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateStoragePool</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<StoragePool, OperationMetadata> PollOnceUpdateStoragePool(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<StoragePool, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateStoragePoolOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateStoragePool</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<StoragePool, OperationMetadata>> PollOnceUpdateStoragePoolAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<StoragePool, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateStoragePoolOperationsClient, callSettings);

        /// <summary>
        /// Updates the storage pool properties with the full spec
        /// </summary>
        /// <param name="storagePool">
        /// Required. The pool being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// StoragePool resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<StoragePool, OperationMetadata> UpdateStoragePool(StoragePool storagePool, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateStoragePool(new UpdateStoragePoolRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                StoragePool = gax::GaxPreconditions.CheckNotNull(storagePool, nameof(storagePool)),
            }, callSettings);

        /// <summary>
        /// Updates the storage pool properties with the full spec
        /// </summary>
        /// <param name="storagePool">
        /// Required. The pool being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// StoragePool resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<StoragePool, OperationMetadata>> UpdateStoragePoolAsync(StoragePool storagePool, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateStoragePoolAsync(new UpdateStoragePoolRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                StoragePool = gax::GaxPreconditions.CheckNotNull(storagePool, nameof(storagePool)),
            }, callSettings);

        /// <summary>
        /// Updates the storage pool properties with the full spec
        /// </summary>
        /// <param name="storagePool">
        /// Required. The pool being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// StoragePool resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<StoragePool, OperationMetadata>> UpdateStoragePoolAsync(StoragePool storagePool, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateStoragePoolAsync(storagePool, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Warning! This operation will permanently delete the storage pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteStoragePool(DeleteStoragePoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Warning! This operation will permanently delete the storage pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteStoragePoolAsync(DeleteStoragePoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Warning! This operation will permanently delete the storage pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteStoragePoolAsync(DeleteStoragePoolRequest request, st::CancellationToken cancellationToken) =>
            DeleteStoragePoolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteStoragePool</c>.</summary>
        public virtual lro::OperationsClient DeleteStoragePoolOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteStoragePool</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteStoragePool(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteStoragePoolOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteStoragePool</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteStoragePoolAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteStoragePoolOperationsClient, callSettings);

        /// <summary>
        /// Warning! This operation will permanently delete the storage pool.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the storage pool
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteStoragePool(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteStoragePool(new DeleteStoragePoolRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Warning! This operation will permanently delete the storage pool.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the storage pool
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteStoragePoolAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteStoragePoolAsync(new DeleteStoragePoolRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Warning! This operation will permanently delete the storage pool.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the storage pool
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteStoragePoolAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteStoragePoolAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Warning! This operation will permanently delete the storage pool.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the storage pool
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteStoragePool(StoragePoolName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteStoragePool(new DeleteStoragePoolRequest
            {
                StoragePoolName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Warning! This operation will permanently delete the storage pool.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the storage pool
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteStoragePoolAsync(StoragePoolName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteStoragePoolAsync(new DeleteStoragePoolRequest
            {
                StoragePoolName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Warning! This operation will permanently delete the storage pool.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the storage pool
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteStoragePoolAsync(StoragePoolName name, st::CancellationToken cancellationToken) =>
            DeleteStoragePoolAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Volumes in a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Volume"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListVolumesResponse, Volume> ListVolumes(ListVolumesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Volumes in a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Volume"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListVolumesResponse, Volume> ListVolumesAsync(ListVolumesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Volumes in a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListVolumesRequest
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
        /// <returns>A pageable sequence of <see cref="Volume"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListVolumesResponse, Volume> ListVolumes(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListVolumes(new ListVolumesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists Volumes in a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListVolumesRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="Volume"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListVolumesResponse, Volume> ListVolumesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListVolumesAsync(new ListVolumesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists Volumes in a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListVolumesRequest
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
        /// <returns>A pageable sequence of <see cref="Volume"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListVolumesResponse, Volume> ListVolumes(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListVolumes(new ListVolumesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists Volumes in a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListVolumesRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="Volume"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListVolumesResponse, Volume> ListVolumesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListVolumesAsync(new ListVolumesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Gets details of a single Volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Volume GetVolume(GetVolumeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Volume> GetVolumeAsync(GetVolumeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Volume> GetVolumeAsync(GetVolumeRequest request, st::CancellationToken cancellationToken) =>
            GetVolumeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Volume.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the volume
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Volume GetVolume(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetVolume(new GetVolumeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Volume.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the volume
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Volume> GetVolumeAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetVolumeAsync(new GetVolumeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Volume.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the volume
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Volume> GetVolumeAsync(string name, st::CancellationToken cancellationToken) =>
            GetVolumeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Volume.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the volume
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Volume GetVolume(VolumeName name, gaxgrpc::CallSettings callSettings = null) =>
            GetVolume(new GetVolumeRequest
            {
                VolumeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Volume.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the volume
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Volume> GetVolumeAsync(VolumeName name, gaxgrpc::CallSettings callSettings = null) =>
            GetVolumeAsync(new GetVolumeRequest
            {
                VolumeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Volume.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the volume
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Volume> GetVolumeAsync(VolumeName name, st::CancellationToken cancellationToken) =>
            GetVolumeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Volume in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Volume, OperationMetadata> CreateVolume(CreateVolumeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Volume in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Volume, OperationMetadata>> CreateVolumeAsync(CreateVolumeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Volume in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Volume, OperationMetadata>> CreateVolumeAsync(CreateVolumeRequest request, st::CancellationToken cancellationToken) =>
            CreateVolumeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateVolume</c>.</summary>
        public virtual lro::OperationsClient CreateVolumeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateVolume</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Volume, OperationMetadata> PollOnceCreateVolume(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Volume, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateVolumeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateVolume</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Volume, OperationMetadata>> PollOnceCreateVolumeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Volume, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateVolumeOperationsClient, callSettings);

        /// <summary>
        /// Creates a new Volume in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="volume">
        /// Required. The volume being created.
        /// </param>
        /// <param name="volumeId">
        /// Required. Id of the requesting volume
        /// If auto-generating Id server-side, remove this field and
        /// Id from the method_signature of Create RPC
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Volume, OperationMetadata> CreateVolume(string parent, Volume volume, string volumeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateVolume(new CreateVolumeRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                VolumeId = gax::GaxPreconditions.CheckNotNullOrEmpty(volumeId, nameof(volumeId)),
                Volume = gax::GaxPreconditions.CheckNotNull(volume, nameof(volume)),
            }, callSettings);

        /// <summary>
        /// Creates a new Volume in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="volume">
        /// Required. The volume being created.
        /// </param>
        /// <param name="volumeId">
        /// Required. Id of the requesting volume
        /// If auto-generating Id server-side, remove this field and
        /// Id from the method_signature of Create RPC
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Volume, OperationMetadata>> CreateVolumeAsync(string parent, Volume volume, string volumeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateVolumeAsync(new CreateVolumeRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                VolumeId = gax::GaxPreconditions.CheckNotNullOrEmpty(volumeId, nameof(volumeId)),
                Volume = gax::GaxPreconditions.CheckNotNull(volume, nameof(volume)),
            }, callSettings);

        /// <summary>
        /// Creates a new Volume in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="volume">
        /// Required. The volume being created.
        /// </param>
        /// <param name="volumeId">
        /// Required. Id of the requesting volume
        /// If auto-generating Id server-side, remove this field and
        /// Id from the method_signature of Create RPC
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Volume, OperationMetadata>> CreateVolumeAsync(string parent, Volume volume, string volumeId, st::CancellationToken cancellationToken) =>
            CreateVolumeAsync(parent, volume, volumeId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Volume in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="volume">
        /// Required. The volume being created.
        /// </param>
        /// <param name="volumeId">
        /// Required. Id of the requesting volume
        /// If auto-generating Id server-side, remove this field and
        /// Id from the method_signature of Create RPC
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Volume, OperationMetadata> CreateVolume(gagr::LocationName parent, Volume volume, string volumeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateVolume(new CreateVolumeRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                VolumeId = gax::GaxPreconditions.CheckNotNullOrEmpty(volumeId, nameof(volumeId)),
                Volume = gax::GaxPreconditions.CheckNotNull(volume, nameof(volume)),
            }, callSettings);

        /// <summary>
        /// Creates a new Volume in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="volume">
        /// Required. The volume being created.
        /// </param>
        /// <param name="volumeId">
        /// Required. Id of the requesting volume
        /// If auto-generating Id server-side, remove this field and
        /// Id from the method_signature of Create RPC
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Volume, OperationMetadata>> CreateVolumeAsync(gagr::LocationName parent, Volume volume, string volumeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateVolumeAsync(new CreateVolumeRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                VolumeId = gax::GaxPreconditions.CheckNotNullOrEmpty(volumeId, nameof(volumeId)),
                Volume = gax::GaxPreconditions.CheckNotNull(volume, nameof(volume)),
            }, callSettings);

        /// <summary>
        /// Creates a new Volume in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="volume">
        /// Required. The volume being created.
        /// </param>
        /// <param name="volumeId">
        /// Required. Id of the requesting volume
        /// If auto-generating Id server-side, remove this field and
        /// Id from the method_signature of Create RPC
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Volume, OperationMetadata>> CreateVolumeAsync(gagr::LocationName parent, Volume volume, string volumeId, st::CancellationToken cancellationToken) =>
            CreateVolumeAsync(parent, volume, volumeId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single Volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Volume, OperationMetadata> UpdateVolume(UpdateVolumeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Volume, OperationMetadata>> UpdateVolumeAsync(UpdateVolumeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Volume, OperationMetadata>> UpdateVolumeAsync(UpdateVolumeRequest request, st::CancellationToken cancellationToken) =>
            UpdateVolumeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateVolume</c>.</summary>
        public virtual lro::OperationsClient UpdateVolumeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateVolume</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Volume, OperationMetadata> PollOnceUpdateVolume(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Volume, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateVolumeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateVolume</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Volume, OperationMetadata>> PollOnceUpdateVolumeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Volume, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateVolumeOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single Volume.
        /// </summary>
        /// <param name="volume">
        /// Required. The volume being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Volume resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Volume, OperationMetadata> UpdateVolume(Volume volume, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateVolume(new UpdateVolumeRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Volume = gax::GaxPreconditions.CheckNotNull(volume, nameof(volume)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Volume.
        /// </summary>
        /// <param name="volume">
        /// Required. The volume being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Volume resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Volume, OperationMetadata>> UpdateVolumeAsync(Volume volume, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateVolumeAsync(new UpdateVolumeRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Volume = gax::GaxPreconditions.CheckNotNull(volume, nameof(volume)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Volume.
        /// </summary>
        /// <param name="volume">
        /// Required. The volume being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Volume resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Volume, OperationMetadata>> UpdateVolumeAsync(Volume volume, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateVolumeAsync(volume, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteVolume(DeleteVolumeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteVolumeAsync(DeleteVolumeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteVolumeAsync(DeleteVolumeRequest request, st::CancellationToken cancellationToken) =>
            DeleteVolumeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteVolume</c>.</summary>
        public virtual lro::OperationsClient DeleteVolumeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteVolume</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteVolume(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteVolumeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteVolume</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteVolumeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteVolumeOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single Volume.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the volume
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteVolume(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteVolume(new DeleteVolumeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Volume.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the volume
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteVolumeAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteVolumeAsync(new DeleteVolumeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Volume.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the volume
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteVolumeAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteVolumeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Volume.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the volume
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteVolume(VolumeName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteVolume(new DeleteVolumeRequest
            {
                VolumeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Volume.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the volume
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteVolumeAsync(VolumeName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteVolumeAsync(new DeleteVolumeRequest
            {
                VolumeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Volume.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the volume
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteVolumeAsync(VolumeName name, st::CancellationToken cancellationToken) =>
            DeleteVolumeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Revert an existing volume to a specified snapshot.
        /// Warning! This operation will permanently revert all changes made after the
        /// snapshot was created.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Volume, OperationMetadata> RevertVolume(RevertVolumeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Revert an existing volume to a specified snapshot.
        /// Warning! This operation will permanently revert all changes made after the
        /// snapshot was created.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Volume, OperationMetadata>> RevertVolumeAsync(RevertVolumeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Revert an existing volume to a specified snapshot.
        /// Warning! This operation will permanently revert all changes made after the
        /// snapshot was created.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Volume, OperationMetadata>> RevertVolumeAsync(RevertVolumeRequest request, st::CancellationToken cancellationToken) =>
            RevertVolumeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RevertVolume</c>.</summary>
        public virtual lro::OperationsClient RevertVolumeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>RevertVolume</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Volume, OperationMetadata> PollOnceRevertVolume(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Volume, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RevertVolumeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RevertVolume</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Volume, OperationMetadata>> PollOnceRevertVolumeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Volume, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RevertVolumeOperationsClient, callSettings);

        /// <summary>
        /// Returns descriptions of all snapshots for a volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Snapshot"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSnapshotsResponse, Snapshot> ListSnapshots(ListSnapshotsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns descriptions of all snapshots for a volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Snapshot"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSnapshotsResponse, Snapshot> ListSnapshotsAsync(ListSnapshotsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns descriptions of all snapshots for a volume.
        /// </summary>
        /// <param name="parent">
        /// Required. The volume for which to retrieve snapshot information,
        /// in the format
        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}`.
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
        /// <returns>A pageable sequence of <see cref="Snapshot"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSnapshotsResponse, Snapshot> ListSnapshots(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListSnapshots(new ListSnapshotsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns descriptions of all snapshots for a volume.
        /// </summary>
        /// <param name="parent">
        /// Required. The volume for which to retrieve snapshot information,
        /// in the format
        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Snapshot"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSnapshotsResponse, Snapshot> ListSnapshotsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListSnapshotsAsync(new ListSnapshotsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns descriptions of all snapshots for a volume.
        /// </summary>
        /// <param name="parent">
        /// Required. The volume for which to retrieve snapshot information,
        /// in the format
        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}`.
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
        /// <returns>A pageable sequence of <see cref="Snapshot"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSnapshotsResponse, Snapshot> ListSnapshots(VolumeName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListSnapshots(new ListSnapshotsRequest
            {
                ParentAsVolumeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns descriptions of all snapshots for a volume.
        /// </summary>
        /// <param name="parent">
        /// Required. The volume for which to retrieve snapshot information,
        /// in the format
        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Snapshot"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSnapshotsResponse, Snapshot> ListSnapshotsAsync(VolumeName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListSnapshotsAsync(new ListSnapshotsRequest
            {
                ParentAsVolumeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Describe a snapshot for a volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Snapshot GetSnapshot(GetSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Describe a snapshot for a volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Snapshot> GetSnapshotAsync(GetSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Describe a snapshot for a volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Snapshot> GetSnapshotAsync(GetSnapshotRequest request, st::CancellationToken cancellationToken) =>
            GetSnapshotAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Describe a snapshot for a volume.
        /// </summary>
        /// <param name="name">
        /// Required. The snapshot resource name, in the format
        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}/snapshots/{snapshot_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Snapshot GetSnapshot(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSnapshot(new GetSnapshotRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Describe a snapshot for a volume.
        /// </summary>
        /// <param name="name">
        /// Required. The snapshot resource name, in the format
        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}/snapshots/{snapshot_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Snapshot> GetSnapshotAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSnapshotAsync(new GetSnapshotRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Describe a snapshot for a volume.
        /// </summary>
        /// <param name="name">
        /// Required. The snapshot resource name, in the format
        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}/snapshots/{snapshot_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Snapshot> GetSnapshotAsync(string name, st::CancellationToken cancellationToken) =>
            GetSnapshotAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Describe a snapshot for a volume.
        /// </summary>
        /// <param name="name">
        /// Required. The snapshot resource name, in the format
        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}/snapshots/{snapshot_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Snapshot GetSnapshot(SnapshotName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSnapshot(new GetSnapshotRequest
            {
                SnapshotName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Describe a snapshot for a volume.
        /// </summary>
        /// <param name="name">
        /// Required. The snapshot resource name, in the format
        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}/snapshots/{snapshot_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Snapshot> GetSnapshotAsync(SnapshotName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSnapshotAsync(new GetSnapshotRequest
            {
                SnapshotName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Describe a snapshot for a volume.
        /// </summary>
        /// <param name="name">
        /// Required. The snapshot resource name, in the format
        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}/snapshots/{snapshot_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Snapshot> GetSnapshotAsync(SnapshotName name, st::CancellationToken cancellationToken) =>
            GetSnapshotAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a new snapshot for a volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Snapshot, OperationMetadata> CreateSnapshot(CreateSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new snapshot for a volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Snapshot, OperationMetadata>> CreateSnapshotAsync(CreateSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new snapshot for a volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Snapshot, OperationMetadata>> CreateSnapshotAsync(CreateSnapshotRequest request, st::CancellationToken cancellationToken) =>
            CreateSnapshotAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateSnapshot</c>.</summary>
        public virtual lro::OperationsClient CreateSnapshotOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateSnapshot</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Snapshot, OperationMetadata> PollOnceCreateSnapshot(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Snapshot, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateSnapshotOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateSnapshot</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Snapshot, OperationMetadata>> PollOnceCreateSnapshotAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Snapshot, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateSnapshotOperationsClient, callSettings);

        /// <summary>
        /// Create a new snapshot for a volume.
        /// </summary>
        /// <param name="parent">
        /// Required. The NetApp volume to create the snapshots of, in the format
        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}`
        /// </param>
        /// <param name="snapshot">
        /// Required. A snapshot resource
        /// </param>
        /// <param name="snapshotId">
        /// Required. ID of the snapshot to create.
        /// This value must start with a lowercase letter followed by up to 62
        /// lowercase letters, numbers, or hyphens, and cannot end with a hyphen.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Snapshot, OperationMetadata> CreateSnapshot(string parent, Snapshot snapshot, string snapshotId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSnapshot(new CreateSnapshotRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Snapshot = gax::GaxPreconditions.CheckNotNull(snapshot, nameof(snapshot)),
                SnapshotId = gax::GaxPreconditions.CheckNotNullOrEmpty(snapshotId, nameof(snapshotId)),
            }, callSettings);

        /// <summary>
        /// Create a new snapshot for a volume.
        /// </summary>
        /// <param name="parent">
        /// Required. The NetApp volume to create the snapshots of, in the format
        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}`
        /// </param>
        /// <param name="snapshot">
        /// Required. A snapshot resource
        /// </param>
        /// <param name="snapshotId">
        /// Required. ID of the snapshot to create.
        /// This value must start with a lowercase letter followed by up to 62
        /// lowercase letters, numbers, or hyphens, and cannot end with a hyphen.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Snapshot, OperationMetadata>> CreateSnapshotAsync(string parent, Snapshot snapshot, string snapshotId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSnapshotAsync(new CreateSnapshotRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Snapshot = gax::GaxPreconditions.CheckNotNull(snapshot, nameof(snapshot)),
                SnapshotId = gax::GaxPreconditions.CheckNotNullOrEmpty(snapshotId, nameof(snapshotId)),
            }, callSettings);

        /// <summary>
        /// Create a new snapshot for a volume.
        /// </summary>
        /// <param name="parent">
        /// Required. The NetApp volume to create the snapshots of, in the format
        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}`
        /// </param>
        /// <param name="snapshot">
        /// Required. A snapshot resource
        /// </param>
        /// <param name="snapshotId">
        /// Required. ID of the snapshot to create.
        /// This value must start with a lowercase letter followed by up to 62
        /// lowercase letters, numbers, or hyphens, and cannot end with a hyphen.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Snapshot, OperationMetadata>> CreateSnapshotAsync(string parent, Snapshot snapshot, string snapshotId, st::CancellationToken cancellationToken) =>
            CreateSnapshotAsync(parent, snapshot, snapshotId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a new snapshot for a volume.
        /// </summary>
        /// <param name="parent">
        /// Required. The NetApp volume to create the snapshots of, in the format
        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}`
        /// </param>
        /// <param name="snapshot">
        /// Required. A snapshot resource
        /// </param>
        /// <param name="snapshotId">
        /// Required. ID of the snapshot to create.
        /// This value must start with a lowercase letter followed by up to 62
        /// lowercase letters, numbers, or hyphens, and cannot end with a hyphen.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Snapshot, OperationMetadata> CreateSnapshot(VolumeName parent, Snapshot snapshot, string snapshotId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSnapshot(new CreateSnapshotRequest
            {
                ParentAsVolumeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Snapshot = gax::GaxPreconditions.CheckNotNull(snapshot, nameof(snapshot)),
                SnapshotId = gax::GaxPreconditions.CheckNotNullOrEmpty(snapshotId, nameof(snapshotId)),
            }, callSettings);

        /// <summary>
        /// Create a new snapshot for a volume.
        /// </summary>
        /// <param name="parent">
        /// Required. The NetApp volume to create the snapshots of, in the format
        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}`
        /// </param>
        /// <param name="snapshot">
        /// Required. A snapshot resource
        /// </param>
        /// <param name="snapshotId">
        /// Required. ID of the snapshot to create.
        /// This value must start with a lowercase letter followed by up to 62
        /// lowercase letters, numbers, or hyphens, and cannot end with a hyphen.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Snapshot, OperationMetadata>> CreateSnapshotAsync(VolumeName parent, Snapshot snapshot, string snapshotId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSnapshotAsync(new CreateSnapshotRequest
            {
                ParentAsVolumeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Snapshot = gax::GaxPreconditions.CheckNotNull(snapshot, nameof(snapshot)),
                SnapshotId = gax::GaxPreconditions.CheckNotNullOrEmpty(snapshotId, nameof(snapshotId)),
            }, callSettings);

        /// <summary>
        /// Create a new snapshot for a volume.
        /// </summary>
        /// <param name="parent">
        /// Required. The NetApp volume to create the snapshots of, in the format
        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}`
        /// </param>
        /// <param name="snapshot">
        /// Required. A snapshot resource
        /// </param>
        /// <param name="snapshotId">
        /// Required. ID of the snapshot to create.
        /// This value must start with a lowercase letter followed by up to 62
        /// lowercase letters, numbers, or hyphens, and cannot end with a hyphen.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Snapshot, OperationMetadata>> CreateSnapshotAsync(VolumeName parent, Snapshot snapshot, string snapshotId, st::CancellationToken cancellationToken) =>
            CreateSnapshotAsync(parent, snapshot, snapshotId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteSnapshot(DeleteSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSnapshotAsync(DeleteSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSnapshotAsync(DeleteSnapshotRequest request, st::CancellationToken cancellationToken) =>
            DeleteSnapshotAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteSnapshot</c>.</summary>
        public virtual lro::OperationsClient DeleteSnapshotOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteSnapshot</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteSnapshot(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteSnapshotOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteSnapshot</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteSnapshotAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteSnapshotOperationsClient, callSettings);

        /// <summary>
        /// Deletes a snapshot.
        /// </summary>
        /// <param name="name">
        /// Required. The snapshot resource name, in the format
        /// `projects/*/locations/*/volumes/*/snapshots/{snapshot_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteSnapshot(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSnapshot(new DeleteSnapshotRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a snapshot.
        /// </summary>
        /// <param name="name">
        /// Required. The snapshot resource name, in the format
        /// `projects/*/locations/*/volumes/*/snapshots/{snapshot_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSnapshotAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSnapshotAsync(new DeleteSnapshotRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a snapshot.
        /// </summary>
        /// <param name="name">
        /// Required. The snapshot resource name, in the format
        /// `projects/*/locations/*/volumes/*/snapshots/{snapshot_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSnapshotAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteSnapshotAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a snapshot.
        /// </summary>
        /// <param name="name">
        /// Required. The snapshot resource name, in the format
        /// `projects/*/locations/*/volumes/*/snapshots/{snapshot_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteSnapshot(SnapshotName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSnapshot(new DeleteSnapshotRequest
            {
                SnapshotName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a snapshot.
        /// </summary>
        /// <param name="name">
        /// Required. The snapshot resource name, in the format
        /// `projects/*/locations/*/volumes/*/snapshots/{snapshot_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSnapshotAsync(SnapshotName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSnapshotAsync(new DeleteSnapshotRequest
            {
                SnapshotName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a snapshot.
        /// </summary>
        /// <param name="name">
        /// Required. The snapshot resource name, in the format
        /// `projects/*/locations/*/volumes/*/snapshots/{snapshot_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSnapshotAsync(SnapshotName name, st::CancellationToken cancellationToken) =>
            DeleteSnapshotAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the settings of a specific snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Snapshot, OperationMetadata> UpdateSnapshot(UpdateSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the settings of a specific snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Snapshot, OperationMetadata>> UpdateSnapshotAsync(UpdateSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the settings of a specific snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Snapshot, OperationMetadata>> UpdateSnapshotAsync(UpdateSnapshotRequest request, st::CancellationToken cancellationToken) =>
            UpdateSnapshotAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateSnapshot</c>.</summary>
        public virtual lro::OperationsClient UpdateSnapshotOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateSnapshot</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Snapshot, OperationMetadata> PollOnceUpdateSnapshot(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Snapshot, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateSnapshotOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateSnapshot</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Snapshot, OperationMetadata>> PollOnceUpdateSnapshotAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Snapshot, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateSnapshotOperationsClient, callSettings);

        /// <summary>
        /// Updates the settings of a specific snapshot.
        /// </summary>
        /// <param name="snapshot">
        /// Required. A snapshot resource
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.  At least one path must be supplied in
        /// this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Snapshot, OperationMetadata> UpdateSnapshot(Snapshot snapshot, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSnapshot(new UpdateSnapshotRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Snapshot = gax::GaxPreconditions.CheckNotNull(snapshot, nameof(snapshot)),
            }, callSettings);

        /// <summary>
        /// Updates the settings of a specific snapshot.
        /// </summary>
        /// <param name="snapshot">
        /// Required. A snapshot resource
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.  At least one path must be supplied in
        /// this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Snapshot, OperationMetadata>> UpdateSnapshotAsync(Snapshot snapshot, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSnapshotAsync(new UpdateSnapshotRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Snapshot = gax::GaxPreconditions.CheckNotNull(snapshot, nameof(snapshot)),
            }, callSettings);

        /// <summary>
        /// Updates the settings of a specific snapshot.
        /// </summary>
        /// <param name="snapshot">
        /// Required. A snapshot resource
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.  At least one path must be supplied in
        /// this field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Snapshot, OperationMetadata>> UpdateSnapshotAsync(Snapshot snapshot, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateSnapshotAsync(snapshot, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists active directories.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ActiveDirectory"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListActiveDirectoriesResponse, ActiveDirectory> ListActiveDirectories(ListActiveDirectoriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists active directories.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ActiveDirectory"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListActiveDirectoriesResponse, ActiveDirectory> ListActiveDirectoriesAsync(ListActiveDirectoriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists active directories.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListActiveDirectoriesRequest
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
        /// <returns>A pageable sequence of <see cref="ActiveDirectory"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListActiveDirectoriesResponse, ActiveDirectory> ListActiveDirectories(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListActiveDirectories(new ListActiveDirectoriesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists active directories.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListActiveDirectoriesRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="ActiveDirectory"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListActiveDirectoriesResponse, ActiveDirectory> ListActiveDirectoriesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListActiveDirectoriesAsync(new ListActiveDirectoriesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists active directories.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListActiveDirectoriesRequest
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
        /// <returns>A pageable sequence of <see cref="ActiveDirectory"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListActiveDirectoriesResponse, ActiveDirectory> ListActiveDirectories(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListActiveDirectories(new ListActiveDirectoriesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists active directories.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListActiveDirectoriesRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="ActiveDirectory"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListActiveDirectoriesResponse, ActiveDirectory> ListActiveDirectoriesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListActiveDirectoriesAsync(new ListActiveDirectoriesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Describes a specified active directory.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ActiveDirectory GetActiveDirectory(GetActiveDirectoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Describes a specified active directory.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ActiveDirectory> GetActiveDirectoryAsync(GetActiveDirectoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Describes a specified active directory.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ActiveDirectory> GetActiveDirectoryAsync(GetActiveDirectoryRequest request, st::CancellationToken cancellationToken) =>
            GetActiveDirectoryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Describes a specified active directory.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the active directory.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ActiveDirectory GetActiveDirectory(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetActiveDirectory(new GetActiveDirectoryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Describes a specified active directory.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the active directory.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ActiveDirectory> GetActiveDirectoryAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetActiveDirectoryAsync(new GetActiveDirectoryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Describes a specified active directory.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the active directory.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ActiveDirectory> GetActiveDirectoryAsync(string name, st::CancellationToken cancellationToken) =>
            GetActiveDirectoryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Describes a specified active directory.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the active directory.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ActiveDirectory GetActiveDirectory(ActiveDirectoryName name, gaxgrpc::CallSettings callSettings = null) =>
            GetActiveDirectory(new GetActiveDirectoryRequest
            {
                ActiveDirectoryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Describes a specified active directory.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the active directory.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ActiveDirectory> GetActiveDirectoryAsync(ActiveDirectoryName name, gaxgrpc::CallSettings callSettings = null) =>
            GetActiveDirectoryAsync(new GetActiveDirectoryRequest
            {
                ActiveDirectoryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Describes a specified active directory.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the active directory.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ActiveDirectory> GetActiveDirectoryAsync(ActiveDirectoryName name, st::CancellationToken cancellationToken) =>
            GetActiveDirectoryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// CreateActiveDirectory
        /// Creates the active directory specified in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ActiveDirectory, OperationMetadata> CreateActiveDirectory(CreateActiveDirectoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// CreateActiveDirectory
        /// Creates the active directory specified in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ActiveDirectory, OperationMetadata>> CreateActiveDirectoryAsync(CreateActiveDirectoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// CreateActiveDirectory
        /// Creates the active directory specified in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ActiveDirectory, OperationMetadata>> CreateActiveDirectoryAsync(CreateActiveDirectoryRequest request, st::CancellationToken cancellationToken) =>
            CreateActiveDirectoryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateActiveDirectory</c>.</summary>
        public virtual lro::OperationsClient CreateActiveDirectoryOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateActiveDirectory</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ActiveDirectory, OperationMetadata> PollOnceCreateActiveDirectory(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ActiveDirectory, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateActiveDirectoryOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateActiveDirectory</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ActiveDirectory, OperationMetadata>> PollOnceCreateActiveDirectoryAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ActiveDirectory, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateActiveDirectoryOperationsClient, callSettings);

        /// <summary>
        /// CreateActiveDirectory
        /// Creates the active directory specified in the request.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="activeDirectory">
        /// Required. Fields of the to be created active directory.
        /// </param>
        /// <param name="activeDirectoryId">
        /// Required. ID of the active directory to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ActiveDirectory, OperationMetadata> CreateActiveDirectory(string parent, ActiveDirectory activeDirectory, string activeDirectoryId, gaxgrpc::CallSettings callSettings = null) =>
            CreateActiveDirectory(new CreateActiveDirectoryRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ActiveDirectory = gax::GaxPreconditions.CheckNotNull(activeDirectory, nameof(activeDirectory)),
                ActiveDirectoryId = gax::GaxPreconditions.CheckNotNullOrEmpty(activeDirectoryId, nameof(activeDirectoryId)),
            }, callSettings);

        /// <summary>
        /// CreateActiveDirectory
        /// Creates the active directory specified in the request.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="activeDirectory">
        /// Required. Fields of the to be created active directory.
        /// </param>
        /// <param name="activeDirectoryId">
        /// Required. ID of the active directory to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ActiveDirectory, OperationMetadata>> CreateActiveDirectoryAsync(string parent, ActiveDirectory activeDirectory, string activeDirectoryId, gaxgrpc::CallSettings callSettings = null) =>
            CreateActiveDirectoryAsync(new CreateActiveDirectoryRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ActiveDirectory = gax::GaxPreconditions.CheckNotNull(activeDirectory, nameof(activeDirectory)),
                ActiveDirectoryId = gax::GaxPreconditions.CheckNotNullOrEmpty(activeDirectoryId, nameof(activeDirectoryId)),
            }, callSettings);

        /// <summary>
        /// CreateActiveDirectory
        /// Creates the active directory specified in the request.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="activeDirectory">
        /// Required. Fields of the to be created active directory.
        /// </param>
        /// <param name="activeDirectoryId">
        /// Required. ID of the active directory to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ActiveDirectory, OperationMetadata>> CreateActiveDirectoryAsync(string parent, ActiveDirectory activeDirectory, string activeDirectoryId, st::CancellationToken cancellationToken) =>
            CreateActiveDirectoryAsync(parent, activeDirectory, activeDirectoryId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// CreateActiveDirectory
        /// Creates the active directory specified in the request.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="activeDirectory">
        /// Required. Fields of the to be created active directory.
        /// </param>
        /// <param name="activeDirectoryId">
        /// Required. ID of the active directory to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ActiveDirectory, OperationMetadata> CreateActiveDirectory(gagr::LocationName parent, ActiveDirectory activeDirectory, string activeDirectoryId, gaxgrpc::CallSettings callSettings = null) =>
            CreateActiveDirectory(new CreateActiveDirectoryRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ActiveDirectory = gax::GaxPreconditions.CheckNotNull(activeDirectory, nameof(activeDirectory)),
                ActiveDirectoryId = gax::GaxPreconditions.CheckNotNullOrEmpty(activeDirectoryId, nameof(activeDirectoryId)),
            }, callSettings);

        /// <summary>
        /// CreateActiveDirectory
        /// Creates the active directory specified in the request.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="activeDirectory">
        /// Required. Fields of the to be created active directory.
        /// </param>
        /// <param name="activeDirectoryId">
        /// Required. ID of the active directory to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ActiveDirectory, OperationMetadata>> CreateActiveDirectoryAsync(gagr::LocationName parent, ActiveDirectory activeDirectory, string activeDirectoryId, gaxgrpc::CallSettings callSettings = null) =>
            CreateActiveDirectoryAsync(new CreateActiveDirectoryRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ActiveDirectory = gax::GaxPreconditions.CheckNotNull(activeDirectory, nameof(activeDirectory)),
                ActiveDirectoryId = gax::GaxPreconditions.CheckNotNullOrEmpty(activeDirectoryId, nameof(activeDirectoryId)),
            }, callSettings);

        /// <summary>
        /// CreateActiveDirectory
        /// Creates the active directory specified in the request.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="activeDirectory">
        /// Required. Fields of the to be created active directory.
        /// </param>
        /// <param name="activeDirectoryId">
        /// Required. ID of the active directory to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ActiveDirectory, OperationMetadata>> CreateActiveDirectoryAsync(gagr::LocationName parent, ActiveDirectory activeDirectory, string activeDirectoryId, st::CancellationToken cancellationToken) =>
            CreateActiveDirectoryAsync(parent, activeDirectory, activeDirectoryId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update the parameters of an active directories.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ActiveDirectory, OperationMetadata> UpdateActiveDirectory(UpdateActiveDirectoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update the parameters of an active directories.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ActiveDirectory, OperationMetadata>> UpdateActiveDirectoryAsync(UpdateActiveDirectoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update the parameters of an active directories.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ActiveDirectory, OperationMetadata>> UpdateActiveDirectoryAsync(UpdateActiveDirectoryRequest request, st::CancellationToken cancellationToken) =>
            UpdateActiveDirectoryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateActiveDirectory</c>.</summary>
        public virtual lro::OperationsClient UpdateActiveDirectoryOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateActiveDirectory</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ActiveDirectory, OperationMetadata> PollOnceUpdateActiveDirectory(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ActiveDirectory, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateActiveDirectoryOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateActiveDirectory</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ActiveDirectory, OperationMetadata>> PollOnceUpdateActiveDirectoryAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ActiveDirectory, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateActiveDirectoryOperationsClient, callSettings);

        /// <summary>
        /// Update the parameters of an active directories.
        /// </summary>
        /// <param name="activeDirectory">
        /// Required. The volume being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Active Directory resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ActiveDirectory, OperationMetadata> UpdateActiveDirectory(ActiveDirectory activeDirectory, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateActiveDirectory(new UpdateActiveDirectoryRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                ActiveDirectory = gax::GaxPreconditions.CheckNotNull(activeDirectory, nameof(activeDirectory)),
            }, callSettings);

        /// <summary>
        /// Update the parameters of an active directories.
        /// </summary>
        /// <param name="activeDirectory">
        /// Required. The volume being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Active Directory resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ActiveDirectory, OperationMetadata>> UpdateActiveDirectoryAsync(ActiveDirectory activeDirectory, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateActiveDirectoryAsync(new UpdateActiveDirectoryRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                ActiveDirectory = gax::GaxPreconditions.CheckNotNull(activeDirectory, nameof(activeDirectory)),
            }, callSettings);

        /// <summary>
        /// Update the parameters of an active directories.
        /// </summary>
        /// <param name="activeDirectory">
        /// Required. The volume being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Active Directory resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ActiveDirectory, OperationMetadata>> UpdateActiveDirectoryAsync(ActiveDirectory activeDirectory, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateActiveDirectoryAsync(activeDirectory, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete the active directory specified in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteActiveDirectory(DeleteActiveDirectoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete the active directory specified in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteActiveDirectoryAsync(DeleteActiveDirectoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete the active directory specified in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteActiveDirectoryAsync(DeleteActiveDirectoryRequest request, st::CancellationToken cancellationToken) =>
            DeleteActiveDirectoryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteActiveDirectory</c>.</summary>
        public virtual lro::OperationsClient DeleteActiveDirectoryOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteActiveDirectory</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteActiveDirectory(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteActiveDirectoryOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteActiveDirectory</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteActiveDirectoryAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteActiveDirectoryOperationsClient, callSettings);

        /// <summary>
        /// Delete the active directory specified in the request.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the active directory.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteActiveDirectory(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteActiveDirectory(new DeleteActiveDirectoryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete the active directory specified in the request.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the active directory.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteActiveDirectoryAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteActiveDirectoryAsync(new DeleteActiveDirectoryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete the active directory specified in the request.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the active directory.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteActiveDirectoryAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteActiveDirectoryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete the active directory specified in the request.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the active directory.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteActiveDirectory(ActiveDirectoryName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteActiveDirectory(new DeleteActiveDirectoryRequest
            {
                ActiveDirectoryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete the active directory specified in the request.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the active directory.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteActiveDirectoryAsync(ActiveDirectoryName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteActiveDirectoryAsync(new DeleteActiveDirectoryRequest
            {
                ActiveDirectoryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete the active directory specified in the request.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the active directory.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteActiveDirectoryAsync(ActiveDirectoryName name, st::CancellationToken cancellationToken) =>
            DeleteActiveDirectoryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns descriptions of all KMS configs owned by the caller.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="KmsConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListKmsConfigsResponse, KmsConfig> ListKmsConfigs(ListKmsConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns descriptions of all KMS configs owned by the caller.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="KmsConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListKmsConfigsResponse, KmsConfig> ListKmsConfigsAsync(ListKmsConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns descriptions of all KMS configs owned by the caller.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value
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
        /// <returns>A pageable sequence of <see cref="KmsConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListKmsConfigsResponse, KmsConfig> ListKmsConfigs(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListKmsConfigs(new ListKmsConfigsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns descriptions of all KMS configs owned by the caller.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value
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
        /// <returns>A pageable asynchronous sequence of <see cref="KmsConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListKmsConfigsResponse, KmsConfig> ListKmsConfigsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListKmsConfigsAsync(new ListKmsConfigsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns descriptions of all KMS configs owned by the caller.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value
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
        /// <returns>A pageable sequence of <see cref="KmsConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListKmsConfigsResponse, KmsConfig> ListKmsConfigs(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListKmsConfigs(new ListKmsConfigsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns descriptions of all KMS configs owned by the caller.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value
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
        /// <returns>A pageable asynchronous sequence of <see cref="KmsConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListKmsConfigsResponse, KmsConfig> ListKmsConfigsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListKmsConfigsAsync(new ListKmsConfigsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Creates a new KMS config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<KmsConfig, OperationMetadata> CreateKmsConfig(CreateKmsConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new KMS config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<KmsConfig, OperationMetadata>> CreateKmsConfigAsync(CreateKmsConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new KMS config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<KmsConfig, OperationMetadata>> CreateKmsConfigAsync(CreateKmsConfigRequest request, st::CancellationToken cancellationToken) =>
            CreateKmsConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateKmsConfig</c>.</summary>
        public virtual lro::OperationsClient CreateKmsConfigOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateKmsConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<KmsConfig, OperationMetadata> PollOnceCreateKmsConfig(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<KmsConfig, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateKmsConfigOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateKmsConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<KmsConfig, OperationMetadata>> PollOnceCreateKmsConfigAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<KmsConfig, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateKmsConfigOperationsClient, callSettings);

        /// <summary>
        /// Creates a new KMS config.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="kmsConfig">
        /// Required. The required parameters to create a new KmsConfig.
        /// </param>
        /// <param name="kmsConfigId">
        /// Required. Id of the requesting KmsConfig
        /// If auto-generating Id server-side, remove this field and
        /// id from the method_signature of Create RPC
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<KmsConfig, OperationMetadata> CreateKmsConfig(string parent, KmsConfig kmsConfig, string kmsConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateKmsConfig(new CreateKmsConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                KmsConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(kmsConfigId, nameof(kmsConfigId)),
                KmsConfig = gax::GaxPreconditions.CheckNotNull(kmsConfig, nameof(kmsConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a new KMS config.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="kmsConfig">
        /// Required. The required parameters to create a new KmsConfig.
        /// </param>
        /// <param name="kmsConfigId">
        /// Required. Id of the requesting KmsConfig
        /// If auto-generating Id server-side, remove this field and
        /// id from the method_signature of Create RPC
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<KmsConfig, OperationMetadata>> CreateKmsConfigAsync(string parent, KmsConfig kmsConfig, string kmsConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateKmsConfigAsync(new CreateKmsConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                KmsConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(kmsConfigId, nameof(kmsConfigId)),
                KmsConfig = gax::GaxPreconditions.CheckNotNull(kmsConfig, nameof(kmsConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a new KMS config.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="kmsConfig">
        /// Required. The required parameters to create a new KmsConfig.
        /// </param>
        /// <param name="kmsConfigId">
        /// Required. Id of the requesting KmsConfig
        /// If auto-generating Id server-side, remove this field and
        /// id from the method_signature of Create RPC
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<KmsConfig, OperationMetadata>> CreateKmsConfigAsync(string parent, KmsConfig kmsConfig, string kmsConfigId, st::CancellationToken cancellationToken) =>
            CreateKmsConfigAsync(parent, kmsConfig, kmsConfigId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new KMS config.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="kmsConfig">
        /// Required. The required parameters to create a new KmsConfig.
        /// </param>
        /// <param name="kmsConfigId">
        /// Required. Id of the requesting KmsConfig
        /// If auto-generating Id server-side, remove this field and
        /// id from the method_signature of Create RPC
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<KmsConfig, OperationMetadata> CreateKmsConfig(gagr::LocationName parent, KmsConfig kmsConfig, string kmsConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateKmsConfig(new CreateKmsConfigRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                KmsConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(kmsConfigId, nameof(kmsConfigId)),
                KmsConfig = gax::GaxPreconditions.CheckNotNull(kmsConfig, nameof(kmsConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a new KMS config.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="kmsConfig">
        /// Required. The required parameters to create a new KmsConfig.
        /// </param>
        /// <param name="kmsConfigId">
        /// Required. Id of the requesting KmsConfig
        /// If auto-generating Id server-side, remove this field and
        /// id from the method_signature of Create RPC
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<KmsConfig, OperationMetadata>> CreateKmsConfigAsync(gagr::LocationName parent, KmsConfig kmsConfig, string kmsConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateKmsConfigAsync(new CreateKmsConfigRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                KmsConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(kmsConfigId, nameof(kmsConfigId)),
                KmsConfig = gax::GaxPreconditions.CheckNotNull(kmsConfig, nameof(kmsConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a new KMS config.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="kmsConfig">
        /// Required. The required parameters to create a new KmsConfig.
        /// </param>
        /// <param name="kmsConfigId">
        /// Required. Id of the requesting KmsConfig
        /// If auto-generating Id server-side, remove this field and
        /// id from the method_signature of Create RPC
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<KmsConfig, OperationMetadata>> CreateKmsConfigAsync(gagr::LocationName parent, KmsConfig kmsConfig, string kmsConfigId, st::CancellationToken cancellationToken) =>
            CreateKmsConfigAsync(parent, kmsConfig, kmsConfigId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the description of the specified KMS config by kms_config_id.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual KmsConfig GetKmsConfig(GetKmsConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the description of the specified KMS config by kms_config_id.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<KmsConfig> GetKmsConfigAsync(GetKmsConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the description of the specified KMS config by kms_config_id.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<KmsConfig> GetKmsConfigAsync(GetKmsConfigRequest request, st::CancellationToken cancellationToken) =>
            GetKmsConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the description of the specified KMS config by kms_config_id.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the KmsConfig
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual KmsConfig GetKmsConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetKmsConfig(new GetKmsConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the description of the specified KMS config by kms_config_id.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the KmsConfig
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<KmsConfig> GetKmsConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetKmsConfigAsync(new GetKmsConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the description of the specified KMS config by kms_config_id.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the KmsConfig
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<KmsConfig> GetKmsConfigAsync(string name, st::CancellationToken cancellationToken) =>
            GetKmsConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the description of the specified KMS config by kms_config_id.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the KmsConfig
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual KmsConfig GetKmsConfig(KmsConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetKmsConfig(new GetKmsConfigRequest
            {
                KmsConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the description of the specified KMS config by kms_config_id.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the KmsConfig
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<KmsConfig> GetKmsConfigAsync(KmsConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetKmsConfigAsync(new GetKmsConfigRequest
            {
                KmsConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the description of the specified KMS config by kms_config_id.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the KmsConfig
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<KmsConfig> GetKmsConfigAsync(KmsConfigName name, st::CancellationToken cancellationToken) =>
            GetKmsConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the Kms config properties with the full spec
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<KmsConfig, OperationMetadata> UpdateKmsConfig(UpdateKmsConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the Kms config properties with the full spec
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<KmsConfig, OperationMetadata>> UpdateKmsConfigAsync(UpdateKmsConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the Kms config properties with the full spec
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<KmsConfig, OperationMetadata>> UpdateKmsConfigAsync(UpdateKmsConfigRequest request, st::CancellationToken cancellationToken) =>
            UpdateKmsConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateKmsConfig</c>.</summary>
        public virtual lro::OperationsClient UpdateKmsConfigOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateKmsConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<KmsConfig, OperationMetadata> PollOnceUpdateKmsConfig(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<KmsConfig, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateKmsConfigOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateKmsConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<KmsConfig, OperationMetadata>> PollOnceUpdateKmsConfigAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<KmsConfig, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateKmsConfigOperationsClient, callSettings);

        /// <summary>
        /// Updates the Kms config properties with the full spec
        /// </summary>
        /// <param name="kmsConfig">
        /// Required. The KmsConfig being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// KmsConfig resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<KmsConfig, OperationMetadata> UpdateKmsConfig(KmsConfig kmsConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateKmsConfig(new UpdateKmsConfigRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                KmsConfig = gax::GaxPreconditions.CheckNotNull(kmsConfig, nameof(kmsConfig)),
            }, callSettings);

        /// <summary>
        /// Updates the Kms config properties with the full spec
        /// </summary>
        /// <param name="kmsConfig">
        /// Required. The KmsConfig being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// KmsConfig resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<KmsConfig, OperationMetadata>> UpdateKmsConfigAsync(KmsConfig kmsConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateKmsConfigAsync(new UpdateKmsConfigRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                KmsConfig = gax::GaxPreconditions.CheckNotNull(kmsConfig, nameof(kmsConfig)),
            }, callSettings);

        /// <summary>
        /// Updates the Kms config properties with the full spec
        /// </summary>
        /// <param name="kmsConfig">
        /// Required. The KmsConfig being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// KmsConfig resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<KmsConfig, OperationMetadata>> UpdateKmsConfigAsync(KmsConfig kmsConfig, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateKmsConfigAsync(kmsConfig, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Encrypt the existing volumes without CMEK encryption with the desired the
        /// KMS config for the whole region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<KmsConfig, OperationMetadata> EncryptVolumes(EncryptVolumesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Encrypt the existing volumes without CMEK encryption with the desired the
        /// KMS config for the whole region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<KmsConfig, OperationMetadata>> EncryptVolumesAsync(EncryptVolumesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Encrypt the existing volumes without CMEK encryption with the desired the
        /// KMS config for the whole region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<KmsConfig, OperationMetadata>> EncryptVolumesAsync(EncryptVolumesRequest request, st::CancellationToken cancellationToken) =>
            EncryptVolumesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>EncryptVolumes</c>.</summary>
        public virtual lro::OperationsClient EncryptVolumesOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>EncryptVolumes</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<KmsConfig, OperationMetadata> PollOnceEncryptVolumes(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<KmsConfig, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), EncryptVolumesOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>EncryptVolumes</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<KmsConfig, OperationMetadata>> PollOnceEncryptVolumesAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<KmsConfig, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), EncryptVolumesOperationsClient, callSettings);

        /// <summary>
        /// Verifies KMS config reachability.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual VerifyKmsConfigResponse VerifyKmsConfig(VerifyKmsConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Verifies KMS config reachability.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VerifyKmsConfigResponse> VerifyKmsConfigAsync(VerifyKmsConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Verifies KMS config reachability.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VerifyKmsConfigResponse> VerifyKmsConfigAsync(VerifyKmsConfigRequest request, st::CancellationToken cancellationToken) =>
            VerifyKmsConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Warning! This operation will permanently delete the Kms config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteKmsConfig(DeleteKmsConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Warning! This operation will permanently delete the Kms config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteKmsConfigAsync(DeleteKmsConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Warning! This operation will permanently delete the Kms config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteKmsConfigAsync(DeleteKmsConfigRequest request, st::CancellationToken cancellationToken) =>
            DeleteKmsConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteKmsConfig</c>.</summary>
        public virtual lro::OperationsClient DeleteKmsConfigOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteKmsConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteKmsConfig(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteKmsConfigOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteKmsConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteKmsConfigAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteKmsConfigOperationsClient, callSettings);

        /// <summary>
        /// Warning! This operation will permanently delete the Kms config.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the KmsConfig.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteKmsConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteKmsConfig(new DeleteKmsConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Warning! This operation will permanently delete the Kms config.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the KmsConfig.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteKmsConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteKmsConfigAsync(new DeleteKmsConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Warning! This operation will permanently delete the Kms config.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the KmsConfig.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteKmsConfigAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteKmsConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Warning! This operation will permanently delete the Kms config.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the KmsConfig.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteKmsConfig(KmsConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteKmsConfig(new DeleteKmsConfigRequest
            {
                KmsConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Warning! This operation will permanently delete the Kms config.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the KmsConfig.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteKmsConfigAsync(KmsConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteKmsConfigAsync(new DeleteKmsConfigRequest
            {
                KmsConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Warning! This operation will permanently delete the Kms config.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the KmsConfig.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteKmsConfigAsync(KmsConfigName name, st::CancellationToken cancellationToken) =>
            DeleteKmsConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns descriptions of all replications for a volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Replication"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReplicationsResponse, Replication> ListReplications(ListReplicationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns descriptions of all replications for a volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Replication"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReplicationsResponse, Replication> ListReplicationsAsync(ListReplicationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns descriptions of all replications for a volume.
        /// </summary>
        /// <param name="parent">
        /// Required. The volume for which to retrieve replication information,
        /// in the format
        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}`.
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
        /// <returns>A pageable sequence of <see cref="Replication"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReplicationsResponse, Replication> ListReplications(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListReplications(new ListReplicationsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns descriptions of all replications for a volume.
        /// </summary>
        /// <param name="parent">
        /// Required. The volume for which to retrieve replication information,
        /// in the format
        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Replication"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReplicationsResponse, Replication> ListReplicationsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListReplicationsAsync(new ListReplicationsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns descriptions of all replications for a volume.
        /// </summary>
        /// <param name="parent">
        /// Required. The volume for which to retrieve replication information,
        /// in the format
        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}`.
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
        /// <returns>A pageable sequence of <see cref="Replication"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReplicationsResponse, Replication> ListReplications(VolumeName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListReplications(new ListReplicationsRequest
            {
                ParentAsVolumeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns descriptions of all replications for a volume.
        /// </summary>
        /// <param name="parent">
        /// Required. The volume for which to retrieve replication information,
        /// in the format
        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Replication"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReplicationsResponse, Replication> ListReplicationsAsync(VolumeName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListReplicationsAsync(new ListReplicationsRequest
            {
                ParentAsVolumeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Describe a replication for a volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Replication GetReplication(GetReplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Describe a replication for a volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Replication> GetReplicationAsync(GetReplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Describe a replication for a volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Replication> GetReplicationAsync(GetReplicationRequest request, st::CancellationToken cancellationToken) =>
            GetReplicationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Describe a replication for a volume.
        /// </summary>
        /// <param name="name">
        /// Required. The replication resource name, in the format
        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}/replications/{replication_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Replication GetReplication(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetReplication(new GetReplicationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Describe a replication for a volume.
        /// </summary>
        /// <param name="name">
        /// Required. The replication resource name, in the format
        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}/replications/{replication_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Replication> GetReplicationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetReplicationAsync(new GetReplicationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Describe a replication for a volume.
        /// </summary>
        /// <param name="name">
        /// Required. The replication resource name, in the format
        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}/replications/{replication_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Replication> GetReplicationAsync(string name, st::CancellationToken cancellationToken) =>
            GetReplicationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Describe a replication for a volume.
        /// </summary>
        /// <param name="name">
        /// Required. The replication resource name, in the format
        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}/replications/{replication_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Replication GetReplication(ReplicationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetReplication(new GetReplicationRequest
            {
                ReplicationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Describe a replication for a volume.
        /// </summary>
        /// <param name="name">
        /// Required. The replication resource name, in the format
        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}/replications/{replication_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Replication> GetReplicationAsync(ReplicationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetReplicationAsync(new GetReplicationRequest
            {
                ReplicationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Describe a replication for a volume.
        /// </summary>
        /// <param name="name">
        /// Required. The replication resource name, in the format
        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}/replications/{replication_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Replication> GetReplicationAsync(ReplicationName name, st::CancellationToken cancellationToken) =>
            GetReplicationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a new replication for a volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Replication, OperationMetadata> CreateReplication(CreateReplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new replication for a volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Replication, OperationMetadata>> CreateReplicationAsync(CreateReplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new replication for a volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Replication, OperationMetadata>> CreateReplicationAsync(CreateReplicationRequest request, st::CancellationToken cancellationToken) =>
            CreateReplicationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateReplication</c>.</summary>
        public virtual lro::OperationsClient CreateReplicationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateReplication</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Replication, OperationMetadata> PollOnceCreateReplication(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Replication, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateReplicationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateReplication</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Replication, OperationMetadata>> PollOnceCreateReplicationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Replication, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateReplicationOperationsClient, callSettings);

        /// <summary>
        /// Create a new replication for a volume.
        /// </summary>
        /// <param name="parent">
        /// Required. The NetApp volume to create the replications of, in the format
        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}`
        /// </param>
        /// <param name="replication">
        /// Required. A replication resource
        /// </param>
        /// <param name="replicationId">
        /// Required. ID of the replication to create.
        /// This value must start with a lowercase letter followed by up to 62
        /// lowercase letters, numbers, or hyphens, and cannot end with a hyphen.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Replication, OperationMetadata> CreateReplication(string parent, Replication replication, string replicationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateReplication(new CreateReplicationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Replication = gax::GaxPreconditions.CheckNotNull(replication, nameof(replication)),
                ReplicationId = gax::GaxPreconditions.CheckNotNullOrEmpty(replicationId, nameof(replicationId)),
            }, callSettings);

        /// <summary>
        /// Create a new replication for a volume.
        /// </summary>
        /// <param name="parent">
        /// Required. The NetApp volume to create the replications of, in the format
        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}`
        /// </param>
        /// <param name="replication">
        /// Required. A replication resource
        /// </param>
        /// <param name="replicationId">
        /// Required. ID of the replication to create.
        /// This value must start with a lowercase letter followed by up to 62
        /// lowercase letters, numbers, or hyphens, and cannot end with a hyphen.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Replication, OperationMetadata>> CreateReplicationAsync(string parent, Replication replication, string replicationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateReplicationAsync(new CreateReplicationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Replication = gax::GaxPreconditions.CheckNotNull(replication, nameof(replication)),
                ReplicationId = gax::GaxPreconditions.CheckNotNullOrEmpty(replicationId, nameof(replicationId)),
            }, callSettings);

        /// <summary>
        /// Create a new replication for a volume.
        /// </summary>
        /// <param name="parent">
        /// Required. The NetApp volume to create the replications of, in the format
        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}`
        /// </param>
        /// <param name="replication">
        /// Required. A replication resource
        /// </param>
        /// <param name="replicationId">
        /// Required. ID of the replication to create.
        /// This value must start with a lowercase letter followed by up to 62
        /// lowercase letters, numbers, or hyphens, and cannot end with a hyphen.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Replication, OperationMetadata>> CreateReplicationAsync(string parent, Replication replication, string replicationId, st::CancellationToken cancellationToken) =>
            CreateReplicationAsync(parent, replication, replicationId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a new replication for a volume.
        /// </summary>
        /// <param name="parent">
        /// Required. The NetApp volume to create the replications of, in the format
        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}`
        /// </param>
        /// <param name="replication">
        /// Required. A replication resource
        /// </param>
        /// <param name="replicationId">
        /// Required. ID of the replication to create.
        /// This value must start with a lowercase letter followed by up to 62
        /// lowercase letters, numbers, or hyphens, and cannot end with a hyphen.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Replication, OperationMetadata> CreateReplication(VolumeName parent, Replication replication, string replicationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateReplication(new CreateReplicationRequest
            {
                ParentAsVolumeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Replication = gax::GaxPreconditions.CheckNotNull(replication, nameof(replication)),
                ReplicationId = gax::GaxPreconditions.CheckNotNullOrEmpty(replicationId, nameof(replicationId)),
            }, callSettings);

        /// <summary>
        /// Create a new replication for a volume.
        /// </summary>
        /// <param name="parent">
        /// Required. The NetApp volume to create the replications of, in the format
        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}`
        /// </param>
        /// <param name="replication">
        /// Required. A replication resource
        /// </param>
        /// <param name="replicationId">
        /// Required. ID of the replication to create.
        /// This value must start with a lowercase letter followed by up to 62
        /// lowercase letters, numbers, or hyphens, and cannot end with a hyphen.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Replication, OperationMetadata>> CreateReplicationAsync(VolumeName parent, Replication replication, string replicationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateReplicationAsync(new CreateReplicationRequest
            {
                ParentAsVolumeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Replication = gax::GaxPreconditions.CheckNotNull(replication, nameof(replication)),
                ReplicationId = gax::GaxPreconditions.CheckNotNullOrEmpty(replicationId, nameof(replicationId)),
            }, callSettings);

        /// <summary>
        /// Create a new replication for a volume.
        /// </summary>
        /// <param name="parent">
        /// Required. The NetApp volume to create the replications of, in the format
        /// `projects/{project_id}/locations/{location}/volumes/{volume_id}`
        /// </param>
        /// <param name="replication">
        /// Required. A replication resource
        /// </param>
        /// <param name="replicationId">
        /// Required. ID of the replication to create.
        /// This value must start with a lowercase letter followed by up to 62
        /// lowercase letters, numbers, or hyphens, and cannot end with a hyphen.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Replication, OperationMetadata>> CreateReplicationAsync(VolumeName parent, Replication replication, string replicationId, st::CancellationToken cancellationToken) =>
            CreateReplicationAsync(parent, replication, replicationId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a replication.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteReplication(DeleteReplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a replication.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteReplicationAsync(DeleteReplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a replication.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteReplicationAsync(DeleteReplicationRequest request, st::CancellationToken cancellationToken) =>
            DeleteReplicationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteReplication</c>.</summary>
        public virtual lro::OperationsClient DeleteReplicationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteReplication</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteReplication(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteReplicationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteReplication</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteReplicationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteReplicationOperationsClient, callSettings);

        /// <summary>
        /// Deletes a replication.
        /// </summary>
        /// <param name="name">
        /// Required. The replication resource name, in the format
        /// `projects/*/locations/*/volumes/*/replications/{replication_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteReplication(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteReplication(new DeleteReplicationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a replication.
        /// </summary>
        /// <param name="name">
        /// Required. The replication resource name, in the format
        /// `projects/*/locations/*/volumes/*/replications/{replication_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteReplicationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteReplicationAsync(new DeleteReplicationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a replication.
        /// </summary>
        /// <param name="name">
        /// Required. The replication resource name, in the format
        /// `projects/*/locations/*/volumes/*/replications/{replication_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteReplicationAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteReplicationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a replication.
        /// </summary>
        /// <param name="name">
        /// Required. The replication resource name, in the format
        /// `projects/*/locations/*/volumes/*/replications/{replication_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteReplication(ReplicationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteReplication(new DeleteReplicationRequest
            {
                ReplicationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a replication.
        /// </summary>
        /// <param name="name">
        /// Required. The replication resource name, in the format
        /// `projects/*/locations/*/volumes/*/replications/{replication_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteReplicationAsync(ReplicationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteReplicationAsync(new DeleteReplicationRequest
            {
                ReplicationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a replication.
        /// </summary>
        /// <param name="name">
        /// Required. The replication resource name, in the format
        /// `projects/*/locations/*/volumes/*/replications/{replication_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteReplicationAsync(ReplicationName name, st::CancellationToken cancellationToken) =>
            DeleteReplicationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the settings of a specific replication.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Replication, OperationMetadata> UpdateReplication(UpdateReplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the settings of a specific replication.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Replication, OperationMetadata>> UpdateReplicationAsync(UpdateReplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the settings of a specific replication.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Replication, OperationMetadata>> UpdateReplicationAsync(UpdateReplicationRequest request, st::CancellationToken cancellationToken) =>
            UpdateReplicationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateReplication</c>.</summary>
        public virtual lro::OperationsClient UpdateReplicationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateReplication</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Replication, OperationMetadata> PollOnceUpdateReplication(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Replication, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateReplicationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateReplication</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Replication, OperationMetadata>> PollOnceUpdateReplicationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Replication, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateReplicationOperationsClient, callSettings);

        /// <summary>
        /// Updates the settings of a specific replication.
        /// </summary>
        /// <param name="replication">
        /// Required. A replication resource
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.  At least one path must be supplied in
        /// this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Replication, OperationMetadata> UpdateReplication(Replication replication, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateReplication(new UpdateReplicationRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Replication = gax::GaxPreconditions.CheckNotNull(replication, nameof(replication)),
            }, callSettings);

        /// <summary>
        /// Updates the settings of a specific replication.
        /// </summary>
        /// <param name="replication">
        /// Required. A replication resource
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.  At least one path must be supplied in
        /// this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Replication, OperationMetadata>> UpdateReplicationAsync(Replication replication, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateReplicationAsync(new UpdateReplicationRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Replication = gax::GaxPreconditions.CheckNotNull(replication, nameof(replication)),
            }, callSettings);

        /// <summary>
        /// Updates the settings of a specific replication.
        /// </summary>
        /// <param name="replication">
        /// Required. A replication resource
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.  At least one path must be supplied in
        /// this field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Replication, OperationMetadata>> UpdateReplicationAsync(Replication replication, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateReplicationAsync(replication, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Stop Cross Region Replication.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Replication, OperationMetadata> StopReplication(StopReplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Stop Cross Region Replication.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Replication, OperationMetadata>> StopReplicationAsync(StopReplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Stop Cross Region Replication.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Replication, OperationMetadata>> StopReplicationAsync(StopReplicationRequest request, st::CancellationToken cancellationToken) =>
            StopReplicationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>StopReplication</c>.</summary>
        public virtual lro::OperationsClient StopReplicationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>StopReplication</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Replication, OperationMetadata> PollOnceStopReplication(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Replication, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StopReplicationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>StopReplication</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Replication, OperationMetadata>> PollOnceStopReplicationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Replication, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StopReplicationOperationsClient, callSettings);

        /// <summary>
        /// Resume Cross Region Replication.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Replication, OperationMetadata> ResumeReplication(ResumeReplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Resume Cross Region Replication.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Replication, OperationMetadata>> ResumeReplicationAsync(ResumeReplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Resume Cross Region Replication.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Replication, OperationMetadata>> ResumeReplicationAsync(ResumeReplicationRequest request, st::CancellationToken cancellationToken) =>
            ResumeReplicationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ResumeReplication</c>.</summary>
        public virtual lro::OperationsClient ResumeReplicationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ResumeReplication</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Replication, OperationMetadata> PollOnceResumeReplication(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Replication, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ResumeReplicationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ResumeReplication</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Replication, OperationMetadata>> PollOnceResumeReplicationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Replication, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ResumeReplicationOperationsClient, callSettings);

        /// <summary>
        /// Reverses direction of replication. Source becomes destination and
        /// destination becomes source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Replication, OperationMetadata> ReverseReplicationDirection(ReverseReplicationDirectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Reverses direction of replication. Source becomes destination and
        /// destination becomes source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Replication, OperationMetadata>> ReverseReplicationDirectionAsync(ReverseReplicationDirectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Reverses direction of replication. Source becomes destination and
        /// destination becomes source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Replication, OperationMetadata>> ReverseReplicationDirectionAsync(ReverseReplicationDirectionRequest request, st::CancellationToken cancellationToken) =>
            ReverseReplicationDirectionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ReverseReplicationDirection</c>.</summary>
        public virtual lro::OperationsClient ReverseReplicationDirectionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ReverseReplicationDirection</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Replication, OperationMetadata> PollOnceReverseReplicationDirection(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Replication, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ReverseReplicationDirectionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ReverseReplicationDirection</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Replication, OperationMetadata>> PollOnceReverseReplicationDirectionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Replication, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ReverseReplicationDirectionOperationsClient, callSettings);
    }

    /// <summary>NetApp client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// NetApp Files Google Cloud Service
    /// </remarks>
    public sealed partial class NetAppClientImpl : NetAppClient
    {
        private readonly gaxgrpc::ApiCall<ListStoragePoolsRequest, ListStoragePoolsResponse> _callListStoragePools;

        private readonly gaxgrpc::ApiCall<CreateStoragePoolRequest, lro::Operation> _callCreateStoragePool;

        private readonly gaxgrpc::ApiCall<GetStoragePoolRequest, StoragePool> _callGetStoragePool;

        private readonly gaxgrpc::ApiCall<UpdateStoragePoolRequest, lro::Operation> _callUpdateStoragePool;

        private readonly gaxgrpc::ApiCall<DeleteStoragePoolRequest, lro::Operation> _callDeleteStoragePool;

        private readonly gaxgrpc::ApiCall<ListVolumesRequest, ListVolumesResponse> _callListVolumes;

        private readonly gaxgrpc::ApiCall<GetVolumeRequest, Volume> _callGetVolume;

        private readonly gaxgrpc::ApiCall<CreateVolumeRequest, lro::Operation> _callCreateVolume;

        private readonly gaxgrpc::ApiCall<UpdateVolumeRequest, lro::Operation> _callUpdateVolume;

        private readonly gaxgrpc::ApiCall<DeleteVolumeRequest, lro::Operation> _callDeleteVolume;

        private readonly gaxgrpc::ApiCall<RevertVolumeRequest, lro::Operation> _callRevertVolume;

        private readonly gaxgrpc::ApiCall<ListSnapshotsRequest, ListSnapshotsResponse> _callListSnapshots;

        private readonly gaxgrpc::ApiCall<GetSnapshotRequest, Snapshot> _callGetSnapshot;

        private readonly gaxgrpc::ApiCall<CreateSnapshotRequest, lro::Operation> _callCreateSnapshot;

        private readonly gaxgrpc::ApiCall<DeleteSnapshotRequest, lro::Operation> _callDeleteSnapshot;

        private readonly gaxgrpc::ApiCall<UpdateSnapshotRequest, lro::Operation> _callUpdateSnapshot;

        private readonly gaxgrpc::ApiCall<ListActiveDirectoriesRequest, ListActiveDirectoriesResponse> _callListActiveDirectories;

        private readonly gaxgrpc::ApiCall<GetActiveDirectoryRequest, ActiveDirectory> _callGetActiveDirectory;

        private readonly gaxgrpc::ApiCall<CreateActiveDirectoryRequest, lro::Operation> _callCreateActiveDirectory;

        private readonly gaxgrpc::ApiCall<UpdateActiveDirectoryRequest, lro::Operation> _callUpdateActiveDirectory;

        private readonly gaxgrpc::ApiCall<DeleteActiveDirectoryRequest, lro::Operation> _callDeleteActiveDirectory;

        private readonly gaxgrpc::ApiCall<ListKmsConfigsRequest, ListKmsConfigsResponse> _callListKmsConfigs;

        private readonly gaxgrpc::ApiCall<CreateKmsConfigRequest, lro::Operation> _callCreateKmsConfig;

        private readonly gaxgrpc::ApiCall<GetKmsConfigRequest, KmsConfig> _callGetKmsConfig;

        private readonly gaxgrpc::ApiCall<UpdateKmsConfigRequest, lro::Operation> _callUpdateKmsConfig;

        private readonly gaxgrpc::ApiCall<EncryptVolumesRequest, lro::Operation> _callEncryptVolumes;

        private readonly gaxgrpc::ApiCall<VerifyKmsConfigRequest, VerifyKmsConfigResponse> _callVerifyKmsConfig;

        private readonly gaxgrpc::ApiCall<DeleteKmsConfigRequest, lro::Operation> _callDeleteKmsConfig;

        private readonly gaxgrpc::ApiCall<ListReplicationsRequest, ListReplicationsResponse> _callListReplications;

        private readonly gaxgrpc::ApiCall<GetReplicationRequest, Replication> _callGetReplication;

        private readonly gaxgrpc::ApiCall<CreateReplicationRequest, lro::Operation> _callCreateReplication;

        private readonly gaxgrpc::ApiCall<DeleteReplicationRequest, lro::Operation> _callDeleteReplication;

        private readonly gaxgrpc::ApiCall<UpdateReplicationRequest, lro::Operation> _callUpdateReplication;

        private readonly gaxgrpc::ApiCall<StopReplicationRequest, lro::Operation> _callStopReplication;

        private readonly gaxgrpc::ApiCall<ResumeReplicationRequest, lro::Operation> _callResumeReplication;

        private readonly gaxgrpc::ApiCall<ReverseReplicationDirectionRequest, lro::Operation> _callReverseReplicationDirection;

        /// <summary>
        /// Constructs a client wrapper for the NetApp service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="NetAppSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public NetAppClientImpl(NetApp.NetAppClient grpcClient, NetAppSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            NetAppSettings effectiveSettings = settings ?? NetAppSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings, logger);
            CreateStoragePoolOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateStoragePoolOperationsSettings, logger);
            UpdateStoragePoolOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateStoragePoolOperationsSettings, logger);
            DeleteStoragePoolOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteStoragePoolOperationsSettings, logger);
            CreateVolumeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateVolumeOperationsSettings, logger);
            UpdateVolumeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateVolumeOperationsSettings, logger);
            DeleteVolumeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteVolumeOperationsSettings, logger);
            RevertVolumeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RevertVolumeOperationsSettings, logger);
            CreateSnapshotOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateSnapshotOperationsSettings, logger);
            DeleteSnapshotOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteSnapshotOperationsSettings, logger);
            UpdateSnapshotOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateSnapshotOperationsSettings, logger);
            CreateActiveDirectoryOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateActiveDirectoryOperationsSettings, logger);
            UpdateActiveDirectoryOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateActiveDirectoryOperationsSettings, logger);
            DeleteActiveDirectoryOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteActiveDirectoryOperationsSettings, logger);
            CreateKmsConfigOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateKmsConfigOperationsSettings, logger);
            UpdateKmsConfigOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateKmsConfigOperationsSettings, logger);
            EncryptVolumesOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.EncryptVolumesOperationsSettings, logger);
            DeleteKmsConfigOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteKmsConfigOperationsSettings, logger);
            CreateReplicationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateReplicationOperationsSettings, logger);
            DeleteReplicationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteReplicationOperationsSettings, logger);
            UpdateReplicationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateReplicationOperationsSettings, logger);
            StopReplicationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.StopReplicationOperationsSettings, logger);
            ResumeReplicationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ResumeReplicationOperationsSettings, logger);
            ReverseReplicationDirectionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ReverseReplicationDirectionOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callListStoragePools = clientHelper.BuildApiCall<ListStoragePoolsRequest, ListStoragePoolsResponse>("ListStoragePools", grpcClient.ListStoragePoolsAsync, grpcClient.ListStoragePools, effectiveSettings.ListStoragePoolsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListStoragePools);
            Modify_ListStoragePoolsApiCall(ref _callListStoragePools);
            _callCreateStoragePool = clientHelper.BuildApiCall<CreateStoragePoolRequest, lro::Operation>("CreateStoragePool", grpcClient.CreateStoragePoolAsync, grpcClient.CreateStoragePool, effectiveSettings.CreateStoragePoolSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateStoragePool);
            Modify_CreateStoragePoolApiCall(ref _callCreateStoragePool);
            _callGetStoragePool = clientHelper.BuildApiCall<GetStoragePoolRequest, StoragePool>("GetStoragePool", grpcClient.GetStoragePoolAsync, grpcClient.GetStoragePool, effectiveSettings.GetStoragePoolSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetStoragePool);
            Modify_GetStoragePoolApiCall(ref _callGetStoragePool);
            _callUpdateStoragePool = clientHelper.BuildApiCall<UpdateStoragePoolRequest, lro::Operation>("UpdateStoragePool", grpcClient.UpdateStoragePoolAsync, grpcClient.UpdateStoragePool, effectiveSettings.UpdateStoragePoolSettings).WithGoogleRequestParam("storage_pool.name", request => request.StoragePool?.Name);
            Modify_ApiCall(ref _callUpdateStoragePool);
            Modify_UpdateStoragePoolApiCall(ref _callUpdateStoragePool);
            _callDeleteStoragePool = clientHelper.BuildApiCall<DeleteStoragePoolRequest, lro::Operation>("DeleteStoragePool", grpcClient.DeleteStoragePoolAsync, grpcClient.DeleteStoragePool, effectiveSettings.DeleteStoragePoolSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteStoragePool);
            Modify_DeleteStoragePoolApiCall(ref _callDeleteStoragePool);
            _callListVolumes = clientHelper.BuildApiCall<ListVolumesRequest, ListVolumesResponse>("ListVolumes", grpcClient.ListVolumesAsync, grpcClient.ListVolumes, effectiveSettings.ListVolumesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListVolumes);
            Modify_ListVolumesApiCall(ref _callListVolumes);
            _callGetVolume = clientHelper.BuildApiCall<GetVolumeRequest, Volume>("GetVolume", grpcClient.GetVolumeAsync, grpcClient.GetVolume, effectiveSettings.GetVolumeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetVolume);
            Modify_GetVolumeApiCall(ref _callGetVolume);
            _callCreateVolume = clientHelper.BuildApiCall<CreateVolumeRequest, lro::Operation>("CreateVolume", grpcClient.CreateVolumeAsync, grpcClient.CreateVolume, effectiveSettings.CreateVolumeSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateVolume);
            Modify_CreateVolumeApiCall(ref _callCreateVolume);
            _callUpdateVolume = clientHelper.BuildApiCall<UpdateVolumeRequest, lro::Operation>("UpdateVolume", grpcClient.UpdateVolumeAsync, grpcClient.UpdateVolume, effectiveSettings.UpdateVolumeSettings).WithGoogleRequestParam("volume.name", request => request.Volume?.Name);
            Modify_ApiCall(ref _callUpdateVolume);
            Modify_UpdateVolumeApiCall(ref _callUpdateVolume);
            _callDeleteVolume = clientHelper.BuildApiCall<DeleteVolumeRequest, lro::Operation>("DeleteVolume", grpcClient.DeleteVolumeAsync, grpcClient.DeleteVolume, effectiveSettings.DeleteVolumeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteVolume);
            Modify_DeleteVolumeApiCall(ref _callDeleteVolume);
            _callRevertVolume = clientHelper.BuildApiCall<RevertVolumeRequest, lro::Operation>("RevertVolume", grpcClient.RevertVolumeAsync, grpcClient.RevertVolume, effectiveSettings.RevertVolumeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRevertVolume);
            Modify_RevertVolumeApiCall(ref _callRevertVolume);
            _callListSnapshots = clientHelper.BuildApiCall<ListSnapshotsRequest, ListSnapshotsResponse>("ListSnapshots", grpcClient.ListSnapshotsAsync, grpcClient.ListSnapshots, effectiveSettings.ListSnapshotsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListSnapshots);
            Modify_ListSnapshotsApiCall(ref _callListSnapshots);
            _callGetSnapshot = clientHelper.BuildApiCall<GetSnapshotRequest, Snapshot>("GetSnapshot", grpcClient.GetSnapshotAsync, grpcClient.GetSnapshot, effectiveSettings.GetSnapshotSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSnapshot);
            Modify_GetSnapshotApiCall(ref _callGetSnapshot);
            _callCreateSnapshot = clientHelper.BuildApiCall<CreateSnapshotRequest, lro::Operation>("CreateSnapshot", grpcClient.CreateSnapshotAsync, grpcClient.CreateSnapshot, effectiveSettings.CreateSnapshotSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateSnapshot);
            Modify_CreateSnapshotApiCall(ref _callCreateSnapshot);
            _callDeleteSnapshot = clientHelper.BuildApiCall<DeleteSnapshotRequest, lro::Operation>("DeleteSnapshot", grpcClient.DeleteSnapshotAsync, grpcClient.DeleteSnapshot, effectiveSettings.DeleteSnapshotSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteSnapshot);
            Modify_DeleteSnapshotApiCall(ref _callDeleteSnapshot);
            _callUpdateSnapshot = clientHelper.BuildApiCall<UpdateSnapshotRequest, lro::Operation>("UpdateSnapshot", grpcClient.UpdateSnapshotAsync, grpcClient.UpdateSnapshot, effectiveSettings.UpdateSnapshotSettings).WithGoogleRequestParam("snapshot.name", request => request.Snapshot?.Name);
            Modify_ApiCall(ref _callUpdateSnapshot);
            Modify_UpdateSnapshotApiCall(ref _callUpdateSnapshot);
            _callListActiveDirectories = clientHelper.BuildApiCall<ListActiveDirectoriesRequest, ListActiveDirectoriesResponse>("ListActiveDirectories", grpcClient.ListActiveDirectoriesAsync, grpcClient.ListActiveDirectories, effectiveSettings.ListActiveDirectoriesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListActiveDirectories);
            Modify_ListActiveDirectoriesApiCall(ref _callListActiveDirectories);
            _callGetActiveDirectory = clientHelper.BuildApiCall<GetActiveDirectoryRequest, ActiveDirectory>("GetActiveDirectory", grpcClient.GetActiveDirectoryAsync, grpcClient.GetActiveDirectory, effectiveSettings.GetActiveDirectorySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetActiveDirectory);
            Modify_GetActiveDirectoryApiCall(ref _callGetActiveDirectory);
            _callCreateActiveDirectory = clientHelper.BuildApiCall<CreateActiveDirectoryRequest, lro::Operation>("CreateActiveDirectory", grpcClient.CreateActiveDirectoryAsync, grpcClient.CreateActiveDirectory, effectiveSettings.CreateActiveDirectorySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateActiveDirectory);
            Modify_CreateActiveDirectoryApiCall(ref _callCreateActiveDirectory);
            _callUpdateActiveDirectory = clientHelper.BuildApiCall<UpdateActiveDirectoryRequest, lro::Operation>("UpdateActiveDirectory", grpcClient.UpdateActiveDirectoryAsync, grpcClient.UpdateActiveDirectory, effectiveSettings.UpdateActiveDirectorySettings).WithGoogleRequestParam("active_directory.name", request => request.ActiveDirectory?.Name);
            Modify_ApiCall(ref _callUpdateActiveDirectory);
            Modify_UpdateActiveDirectoryApiCall(ref _callUpdateActiveDirectory);
            _callDeleteActiveDirectory = clientHelper.BuildApiCall<DeleteActiveDirectoryRequest, lro::Operation>("DeleteActiveDirectory", grpcClient.DeleteActiveDirectoryAsync, grpcClient.DeleteActiveDirectory, effectiveSettings.DeleteActiveDirectorySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteActiveDirectory);
            Modify_DeleteActiveDirectoryApiCall(ref _callDeleteActiveDirectory);
            _callListKmsConfigs = clientHelper.BuildApiCall<ListKmsConfigsRequest, ListKmsConfigsResponse>("ListKmsConfigs", grpcClient.ListKmsConfigsAsync, grpcClient.ListKmsConfigs, effectiveSettings.ListKmsConfigsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListKmsConfigs);
            Modify_ListKmsConfigsApiCall(ref _callListKmsConfigs);
            _callCreateKmsConfig = clientHelper.BuildApiCall<CreateKmsConfigRequest, lro::Operation>("CreateKmsConfig", grpcClient.CreateKmsConfigAsync, grpcClient.CreateKmsConfig, effectiveSettings.CreateKmsConfigSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateKmsConfig);
            Modify_CreateKmsConfigApiCall(ref _callCreateKmsConfig);
            _callGetKmsConfig = clientHelper.BuildApiCall<GetKmsConfigRequest, KmsConfig>("GetKmsConfig", grpcClient.GetKmsConfigAsync, grpcClient.GetKmsConfig, effectiveSettings.GetKmsConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetKmsConfig);
            Modify_GetKmsConfigApiCall(ref _callGetKmsConfig);
            _callUpdateKmsConfig = clientHelper.BuildApiCall<UpdateKmsConfigRequest, lro::Operation>("UpdateKmsConfig", grpcClient.UpdateKmsConfigAsync, grpcClient.UpdateKmsConfig, effectiveSettings.UpdateKmsConfigSettings).WithGoogleRequestParam("kms_config.name", request => request.KmsConfig?.Name);
            Modify_ApiCall(ref _callUpdateKmsConfig);
            Modify_UpdateKmsConfigApiCall(ref _callUpdateKmsConfig);
            _callEncryptVolumes = clientHelper.BuildApiCall<EncryptVolumesRequest, lro::Operation>("EncryptVolumes", grpcClient.EncryptVolumesAsync, grpcClient.EncryptVolumes, effectiveSettings.EncryptVolumesSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callEncryptVolumes);
            Modify_EncryptVolumesApiCall(ref _callEncryptVolumes);
            _callVerifyKmsConfig = clientHelper.BuildApiCall<VerifyKmsConfigRequest, VerifyKmsConfigResponse>("VerifyKmsConfig", grpcClient.VerifyKmsConfigAsync, grpcClient.VerifyKmsConfig, effectiveSettings.VerifyKmsConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callVerifyKmsConfig);
            Modify_VerifyKmsConfigApiCall(ref _callVerifyKmsConfig);
            _callDeleteKmsConfig = clientHelper.BuildApiCall<DeleteKmsConfigRequest, lro::Operation>("DeleteKmsConfig", grpcClient.DeleteKmsConfigAsync, grpcClient.DeleteKmsConfig, effectiveSettings.DeleteKmsConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteKmsConfig);
            Modify_DeleteKmsConfigApiCall(ref _callDeleteKmsConfig);
            _callListReplications = clientHelper.BuildApiCall<ListReplicationsRequest, ListReplicationsResponse>("ListReplications", grpcClient.ListReplicationsAsync, grpcClient.ListReplications, effectiveSettings.ListReplicationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListReplications);
            Modify_ListReplicationsApiCall(ref _callListReplications);
            _callGetReplication = clientHelper.BuildApiCall<GetReplicationRequest, Replication>("GetReplication", grpcClient.GetReplicationAsync, grpcClient.GetReplication, effectiveSettings.GetReplicationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetReplication);
            Modify_GetReplicationApiCall(ref _callGetReplication);
            _callCreateReplication = clientHelper.BuildApiCall<CreateReplicationRequest, lro::Operation>("CreateReplication", grpcClient.CreateReplicationAsync, grpcClient.CreateReplication, effectiveSettings.CreateReplicationSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateReplication);
            Modify_CreateReplicationApiCall(ref _callCreateReplication);
            _callDeleteReplication = clientHelper.BuildApiCall<DeleteReplicationRequest, lro::Operation>("DeleteReplication", grpcClient.DeleteReplicationAsync, grpcClient.DeleteReplication, effectiveSettings.DeleteReplicationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteReplication);
            Modify_DeleteReplicationApiCall(ref _callDeleteReplication);
            _callUpdateReplication = clientHelper.BuildApiCall<UpdateReplicationRequest, lro::Operation>("UpdateReplication", grpcClient.UpdateReplicationAsync, grpcClient.UpdateReplication, effectiveSettings.UpdateReplicationSettings).WithGoogleRequestParam("replication.name", request => request.Replication?.Name);
            Modify_ApiCall(ref _callUpdateReplication);
            Modify_UpdateReplicationApiCall(ref _callUpdateReplication);
            _callStopReplication = clientHelper.BuildApiCall<StopReplicationRequest, lro::Operation>("StopReplication", grpcClient.StopReplicationAsync, grpcClient.StopReplication, effectiveSettings.StopReplicationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callStopReplication);
            Modify_StopReplicationApiCall(ref _callStopReplication);
            _callResumeReplication = clientHelper.BuildApiCall<ResumeReplicationRequest, lro::Operation>("ResumeReplication", grpcClient.ResumeReplicationAsync, grpcClient.ResumeReplication, effectiveSettings.ResumeReplicationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callResumeReplication);
            Modify_ResumeReplicationApiCall(ref _callResumeReplication);
            _callReverseReplicationDirection = clientHelper.BuildApiCall<ReverseReplicationDirectionRequest, lro::Operation>("ReverseReplicationDirection", grpcClient.ReverseReplicationDirectionAsync, grpcClient.ReverseReplicationDirection, effectiveSettings.ReverseReplicationDirectionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callReverseReplicationDirection);
            Modify_ReverseReplicationDirectionApiCall(ref _callReverseReplicationDirection);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListStoragePoolsApiCall(ref gaxgrpc::ApiCall<ListStoragePoolsRequest, ListStoragePoolsResponse> call);

        partial void Modify_CreateStoragePoolApiCall(ref gaxgrpc::ApiCall<CreateStoragePoolRequest, lro::Operation> call);

        partial void Modify_GetStoragePoolApiCall(ref gaxgrpc::ApiCall<GetStoragePoolRequest, StoragePool> call);

        partial void Modify_UpdateStoragePoolApiCall(ref gaxgrpc::ApiCall<UpdateStoragePoolRequest, lro::Operation> call);

        partial void Modify_DeleteStoragePoolApiCall(ref gaxgrpc::ApiCall<DeleteStoragePoolRequest, lro::Operation> call);

        partial void Modify_ListVolumesApiCall(ref gaxgrpc::ApiCall<ListVolumesRequest, ListVolumesResponse> call);

        partial void Modify_GetVolumeApiCall(ref gaxgrpc::ApiCall<GetVolumeRequest, Volume> call);

        partial void Modify_CreateVolumeApiCall(ref gaxgrpc::ApiCall<CreateVolumeRequest, lro::Operation> call);

        partial void Modify_UpdateVolumeApiCall(ref gaxgrpc::ApiCall<UpdateVolumeRequest, lro::Operation> call);

        partial void Modify_DeleteVolumeApiCall(ref gaxgrpc::ApiCall<DeleteVolumeRequest, lro::Operation> call);

        partial void Modify_RevertVolumeApiCall(ref gaxgrpc::ApiCall<RevertVolumeRequest, lro::Operation> call);

        partial void Modify_ListSnapshotsApiCall(ref gaxgrpc::ApiCall<ListSnapshotsRequest, ListSnapshotsResponse> call);

        partial void Modify_GetSnapshotApiCall(ref gaxgrpc::ApiCall<GetSnapshotRequest, Snapshot> call);

        partial void Modify_CreateSnapshotApiCall(ref gaxgrpc::ApiCall<CreateSnapshotRequest, lro::Operation> call);

        partial void Modify_DeleteSnapshotApiCall(ref gaxgrpc::ApiCall<DeleteSnapshotRequest, lro::Operation> call);

        partial void Modify_UpdateSnapshotApiCall(ref gaxgrpc::ApiCall<UpdateSnapshotRequest, lro::Operation> call);

        partial void Modify_ListActiveDirectoriesApiCall(ref gaxgrpc::ApiCall<ListActiveDirectoriesRequest, ListActiveDirectoriesResponse> call);

        partial void Modify_GetActiveDirectoryApiCall(ref gaxgrpc::ApiCall<GetActiveDirectoryRequest, ActiveDirectory> call);

        partial void Modify_CreateActiveDirectoryApiCall(ref gaxgrpc::ApiCall<CreateActiveDirectoryRequest, lro::Operation> call);

        partial void Modify_UpdateActiveDirectoryApiCall(ref gaxgrpc::ApiCall<UpdateActiveDirectoryRequest, lro::Operation> call);

        partial void Modify_DeleteActiveDirectoryApiCall(ref gaxgrpc::ApiCall<DeleteActiveDirectoryRequest, lro::Operation> call);

        partial void Modify_ListKmsConfigsApiCall(ref gaxgrpc::ApiCall<ListKmsConfigsRequest, ListKmsConfigsResponse> call);

        partial void Modify_CreateKmsConfigApiCall(ref gaxgrpc::ApiCall<CreateKmsConfigRequest, lro::Operation> call);

        partial void Modify_GetKmsConfigApiCall(ref gaxgrpc::ApiCall<GetKmsConfigRequest, KmsConfig> call);

        partial void Modify_UpdateKmsConfigApiCall(ref gaxgrpc::ApiCall<UpdateKmsConfigRequest, lro::Operation> call);

        partial void Modify_EncryptVolumesApiCall(ref gaxgrpc::ApiCall<EncryptVolumesRequest, lro::Operation> call);

        partial void Modify_VerifyKmsConfigApiCall(ref gaxgrpc::ApiCall<VerifyKmsConfigRequest, VerifyKmsConfigResponse> call);

        partial void Modify_DeleteKmsConfigApiCall(ref gaxgrpc::ApiCall<DeleteKmsConfigRequest, lro::Operation> call);

        partial void Modify_ListReplicationsApiCall(ref gaxgrpc::ApiCall<ListReplicationsRequest, ListReplicationsResponse> call);

        partial void Modify_GetReplicationApiCall(ref gaxgrpc::ApiCall<GetReplicationRequest, Replication> call);

        partial void Modify_CreateReplicationApiCall(ref gaxgrpc::ApiCall<CreateReplicationRequest, lro::Operation> call);

        partial void Modify_DeleteReplicationApiCall(ref gaxgrpc::ApiCall<DeleteReplicationRequest, lro::Operation> call);

        partial void Modify_UpdateReplicationApiCall(ref gaxgrpc::ApiCall<UpdateReplicationRequest, lro::Operation> call);

        partial void Modify_StopReplicationApiCall(ref gaxgrpc::ApiCall<StopReplicationRequest, lro::Operation> call);

        partial void Modify_ResumeReplicationApiCall(ref gaxgrpc::ApiCall<ResumeReplicationRequest, lro::Operation> call);

        partial void Modify_ReverseReplicationDirectionApiCall(ref gaxgrpc::ApiCall<ReverseReplicationDirectionRequest, lro::Operation> call);

        partial void OnConstruction(NetApp.NetAppClient grpcClient, NetAppSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC NetApp client</summary>
        public override NetApp.NetAppClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_ListStoragePoolsRequest(ref ListStoragePoolsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateStoragePoolRequest(ref CreateStoragePoolRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetStoragePoolRequest(ref GetStoragePoolRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateStoragePoolRequest(ref UpdateStoragePoolRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteStoragePoolRequest(ref DeleteStoragePoolRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListVolumesRequest(ref ListVolumesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetVolumeRequest(ref GetVolumeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateVolumeRequest(ref CreateVolumeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateVolumeRequest(ref UpdateVolumeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteVolumeRequest(ref DeleteVolumeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RevertVolumeRequest(ref RevertVolumeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSnapshotsRequest(ref ListSnapshotsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSnapshotRequest(ref GetSnapshotRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateSnapshotRequest(ref CreateSnapshotRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteSnapshotRequest(ref DeleteSnapshotRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateSnapshotRequest(ref UpdateSnapshotRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListActiveDirectoriesRequest(ref ListActiveDirectoriesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetActiveDirectoryRequest(ref GetActiveDirectoryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateActiveDirectoryRequest(ref CreateActiveDirectoryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateActiveDirectoryRequest(ref UpdateActiveDirectoryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteActiveDirectoryRequest(ref DeleteActiveDirectoryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListKmsConfigsRequest(ref ListKmsConfigsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateKmsConfigRequest(ref CreateKmsConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetKmsConfigRequest(ref GetKmsConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateKmsConfigRequest(ref UpdateKmsConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_EncryptVolumesRequest(ref EncryptVolumesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_VerifyKmsConfigRequest(ref VerifyKmsConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteKmsConfigRequest(ref DeleteKmsConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListReplicationsRequest(ref ListReplicationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetReplicationRequest(ref GetReplicationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateReplicationRequest(ref CreateReplicationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteReplicationRequest(ref DeleteReplicationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateReplicationRequest(ref UpdateReplicationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StopReplicationRequest(ref StopReplicationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ResumeReplicationRequest(ref ResumeReplicationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ReverseReplicationDirectionRequest(ref ReverseReplicationDirectionRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns descriptions of all storage pools owned by the caller.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="StoragePool"/> resources.</returns>
        public override gax::PagedEnumerable<ListStoragePoolsResponse, StoragePool> ListStoragePools(ListStoragePoolsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListStoragePoolsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListStoragePoolsRequest, ListStoragePoolsResponse, StoragePool>(_callListStoragePools, request, callSettings);
        }

        /// <summary>
        /// Returns descriptions of all storage pools owned by the caller.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="StoragePool"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListStoragePoolsResponse, StoragePool> ListStoragePoolsAsync(ListStoragePoolsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListStoragePoolsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListStoragePoolsRequest, ListStoragePoolsResponse, StoragePool>(_callListStoragePools, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateStoragePool</c>.</summary>
        public override lro::OperationsClient CreateStoragePoolOperationsClient { get; }

        /// <summary>
        /// Creates a new storage pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<StoragePool, OperationMetadata> CreateStoragePool(CreateStoragePoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateStoragePoolRequest(ref request, ref callSettings);
            return new lro::Operation<StoragePool, OperationMetadata>(_callCreateStoragePool.Sync(request, callSettings), CreateStoragePoolOperationsClient);
        }

        /// <summary>
        /// Creates a new storage pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<StoragePool, OperationMetadata>> CreateStoragePoolAsync(CreateStoragePoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateStoragePoolRequest(ref request, ref callSettings);
            return new lro::Operation<StoragePool, OperationMetadata>(await _callCreateStoragePool.Async(request, callSettings).ConfigureAwait(false), CreateStoragePoolOperationsClient);
        }

        /// <summary>
        /// Returns the description of the specified storage pool by poolId.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override StoragePool GetStoragePool(GetStoragePoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetStoragePoolRequest(ref request, ref callSettings);
            return _callGetStoragePool.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the description of the specified storage pool by poolId.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<StoragePool> GetStoragePoolAsync(GetStoragePoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetStoragePoolRequest(ref request, ref callSettings);
            return _callGetStoragePool.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateStoragePool</c>.</summary>
        public override lro::OperationsClient UpdateStoragePoolOperationsClient { get; }

        /// <summary>
        /// Updates the storage pool properties with the full spec
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<StoragePool, OperationMetadata> UpdateStoragePool(UpdateStoragePoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateStoragePoolRequest(ref request, ref callSettings);
            return new lro::Operation<StoragePool, OperationMetadata>(_callUpdateStoragePool.Sync(request, callSettings), UpdateStoragePoolOperationsClient);
        }

        /// <summary>
        /// Updates the storage pool properties with the full spec
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<StoragePool, OperationMetadata>> UpdateStoragePoolAsync(UpdateStoragePoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateStoragePoolRequest(ref request, ref callSettings);
            return new lro::Operation<StoragePool, OperationMetadata>(await _callUpdateStoragePool.Async(request, callSettings).ConfigureAwait(false), UpdateStoragePoolOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteStoragePool</c>.</summary>
        public override lro::OperationsClient DeleteStoragePoolOperationsClient { get; }

        /// <summary>
        /// Warning! This operation will permanently delete the storage pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteStoragePool(DeleteStoragePoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteStoragePoolRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteStoragePool.Sync(request, callSettings), DeleteStoragePoolOperationsClient);
        }

        /// <summary>
        /// Warning! This operation will permanently delete the storage pool.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteStoragePoolAsync(DeleteStoragePoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteStoragePoolRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteStoragePool.Async(request, callSettings).ConfigureAwait(false), DeleteStoragePoolOperationsClient);
        }

        /// <summary>
        /// Lists Volumes in a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Volume"/> resources.</returns>
        public override gax::PagedEnumerable<ListVolumesResponse, Volume> ListVolumes(ListVolumesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListVolumesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListVolumesRequest, ListVolumesResponse, Volume>(_callListVolumes, request, callSettings);
        }

        /// <summary>
        /// Lists Volumes in a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Volume"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListVolumesResponse, Volume> ListVolumesAsync(ListVolumesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListVolumesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListVolumesRequest, ListVolumesResponse, Volume>(_callListVolumes, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Volume GetVolume(GetVolumeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetVolumeRequest(ref request, ref callSettings);
            return _callGetVolume.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Volume> GetVolumeAsync(GetVolumeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetVolumeRequest(ref request, ref callSettings);
            return _callGetVolume.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateVolume</c>.</summary>
        public override lro::OperationsClient CreateVolumeOperationsClient { get; }

        /// <summary>
        /// Creates a new Volume in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Volume, OperationMetadata> CreateVolume(CreateVolumeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateVolumeRequest(ref request, ref callSettings);
            return new lro::Operation<Volume, OperationMetadata>(_callCreateVolume.Sync(request, callSettings), CreateVolumeOperationsClient);
        }

        /// <summary>
        /// Creates a new Volume in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Volume, OperationMetadata>> CreateVolumeAsync(CreateVolumeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateVolumeRequest(ref request, ref callSettings);
            return new lro::Operation<Volume, OperationMetadata>(await _callCreateVolume.Async(request, callSettings).ConfigureAwait(false), CreateVolumeOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateVolume</c>.</summary>
        public override lro::OperationsClient UpdateVolumeOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single Volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Volume, OperationMetadata> UpdateVolume(UpdateVolumeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateVolumeRequest(ref request, ref callSettings);
            return new lro::Operation<Volume, OperationMetadata>(_callUpdateVolume.Sync(request, callSettings), UpdateVolumeOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single Volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Volume, OperationMetadata>> UpdateVolumeAsync(UpdateVolumeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateVolumeRequest(ref request, ref callSettings);
            return new lro::Operation<Volume, OperationMetadata>(await _callUpdateVolume.Async(request, callSettings).ConfigureAwait(false), UpdateVolumeOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteVolume</c>.</summary>
        public override lro::OperationsClient DeleteVolumeOperationsClient { get; }

        /// <summary>
        /// Deletes a single Volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteVolume(DeleteVolumeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteVolumeRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteVolume.Sync(request, callSettings), DeleteVolumeOperationsClient);
        }

        /// <summary>
        /// Deletes a single Volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteVolumeAsync(DeleteVolumeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteVolumeRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteVolume.Async(request, callSettings).ConfigureAwait(false), DeleteVolumeOperationsClient);
        }

        /// <summary>The long-running operations client for <c>RevertVolume</c>.</summary>
        public override lro::OperationsClient RevertVolumeOperationsClient { get; }

        /// <summary>
        /// Revert an existing volume to a specified snapshot.
        /// Warning! This operation will permanently revert all changes made after the
        /// snapshot was created.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Volume, OperationMetadata> RevertVolume(RevertVolumeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RevertVolumeRequest(ref request, ref callSettings);
            return new lro::Operation<Volume, OperationMetadata>(_callRevertVolume.Sync(request, callSettings), RevertVolumeOperationsClient);
        }

        /// <summary>
        /// Revert an existing volume to a specified snapshot.
        /// Warning! This operation will permanently revert all changes made after the
        /// snapshot was created.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Volume, OperationMetadata>> RevertVolumeAsync(RevertVolumeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RevertVolumeRequest(ref request, ref callSettings);
            return new lro::Operation<Volume, OperationMetadata>(await _callRevertVolume.Async(request, callSettings).ConfigureAwait(false), RevertVolumeOperationsClient);
        }

        /// <summary>
        /// Returns descriptions of all snapshots for a volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Snapshot"/> resources.</returns>
        public override gax::PagedEnumerable<ListSnapshotsResponse, Snapshot> ListSnapshots(ListSnapshotsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSnapshotsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSnapshotsRequest, ListSnapshotsResponse, Snapshot>(_callListSnapshots, request, callSettings);
        }

        /// <summary>
        /// Returns descriptions of all snapshots for a volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Snapshot"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListSnapshotsResponse, Snapshot> ListSnapshotsAsync(ListSnapshotsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSnapshotsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSnapshotsRequest, ListSnapshotsResponse, Snapshot>(_callListSnapshots, request, callSettings);
        }

        /// <summary>
        /// Describe a snapshot for a volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Snapshot GetSnapshot(GetSnapshotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSnapshotRequest(ref request, ref callSettings);
            return _callGetSnapshot.Sync(request, callSettings);
        }

        /// <summary>
        /// Describe a snapshot for a volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Snapshot> GetSnapshotAsync(GetSnapshotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSnapshotRequest(ref request, ref callSettings);
            return _callGetSnapshot.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateSnapshot</c>.</summary>
        public override lro::OperationsClient CreateSnapshotOperationsClient { get; }

        /// <summary>
        /// Create a new snapshot for a volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Snapshot, OperationMetadata> CreateSnapshot(CreateSnapshotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSnapshotRequest(ref request, ref callSettings);
            return new lro::Operation<Snapshot, OperationMetadata>(_callCreateSnapshot.Sync(request, callSettings), CreateSnapshotOperationsClient);
        }

        /// <summary>
        /// Create a new snapshot for a volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Snapshot, OperationMetadata>> CreateSnapshotAsync(CreateSnapshotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSnapshotRequest(ref request, ref callSettings);
            return new lro::Operation<Snapshot, OperationMetadata>(await _callCreateSnapshot.Async(request, callSettings).ConfigureAwait(false), CreateSnapshotOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteSnapshot</c>.</summary>
        public override lro::OperationsClient DeleteSnapshotOperationsClient { get; }

        /// <summary>
        /// Deletes a snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteSnapshot(DeleteSnapshotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSnapshotRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteSnapshot.Sync(request, callSettings), DeleteSnapshotOperationsClient);
        }

        /// <summary>
        /// Deletes a snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteSnapshotAsync(DeleteSnapshotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSnapshotRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteSnapshot.Async(request, callSettings).ConfigureAwait(false), DeleteSnapshotOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateSnapshot</c>.</summary>
        public override lro::OperationsClient UpdateSnapshotOperationsClient { get; }

        /// <summary>
        /// Updates the settings of a specific snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Snapshot, OperationMetadata> UpdateSnapshot(UpdateSnapshotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSnapshotRequest(ref request, ref callSettings);
            return new lro::Operation<Snapshot, OperationMetadata>(_callUpdateSnapshot.Sync(request, callSettings), UpdateSnapshotOperationsClient);
        }

        /// <summary>
        /// Updates the settings of a specific snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Snapshot, OperationMetadata>> UpdateSnapshotAsync(UpdateSnapshotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSnapshotRequest(ref request, ref callSettings);
            return new lro::Operation<Snapshot, OperationMetadata>(await _callUpdateSnapshot.Async(request, callSettings).ConfigureAwait(false), UpdateSnapshotOperationsClient);
        }

        /// <summary>
        /// Lists active directories.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ActiveDirectory"/> resources.</returns>
        public override gax::PagedEnumerable<ListActiveDirectoriesResponse, ActiveDirectory> ListActiveDirectories(ListActiveDirectoriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListActiveDirectoriesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListActiveDirectoriesRequest, ListActiveDirectoriesResponse, ActiveDirectory>(_callListActiveDirectories, request, callSettings);
        }

        /// <summary>
        /// Lists active directories.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ActiveDirectory"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListActiveDirectoriesResponse, ActiveDirectory> ListActiveDirectoriesAsync(ListActiveDirectoriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListActiveDirectoriesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListActiveDirectoriesRequest, ListActiveDirectoriesResponse, ActiveDirectory>(_callListActiveDirectories, request, callSettings);
        }

        /// <summary>
        /// Describes a specified active directory.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ActiveDirectory GetActiveDirectory(GetActiveDirectoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetActiveDirectoryRequest(ref request, ref callSettings);
            return _callGetActiveDirectory.Sync(request, callSettings);
        }

        /// <summary>
        /// Describes a specified active directory.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ActiveDirectory> GetActiveDirectoryAsync(GetActiveDirectoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetActiveDirectoryRequest(ref request, ref callSettings);
            return _callGetActiveDirectory.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateActiveDirectory</c>.</summary>
        public override lro::OperationsClient CreateActiveDirectoryOperationsClient { get; }

        /// <summary>
        /// CreateActiveDirectory
        /// Creates the active directory specified in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ActiveDirectory, OperationMetadata> CreateActiveDirectory(CreateActiveDirectoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateActiveDirectoryRequest(ref request, ref callSettings);
            return new lro::Operation<ActiveDirectory, OperationMetadata>(_callCreateActiveDirectory.Sync(request, callSettings), CreateActiveDirectoryOperationsClient);
        }

        /// <summary>
        /// CreateActiveDirectory
        /// Creates the active directory specified in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ActiveDirectory, OperationMetadata>> CreateActiveDirectoryAsync(CreateActiveDirectoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateActiveDirectoryRequest(ref request, ref callSettings);
            return new lro::Operation<ActiveDirectory, OperationMetadata>(await _callCreateActiveDirectory.Async(request, callSettings).ConfigureAwait(false), CreateActiveDirectoryOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateActiveDirectory</c>.</summary>
        public override lro::OperationsClient UpdateActiveDirectoryOperationsClient { get; }

        /// <summary>
        /// Update the parameters of an active directories.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ActiveDirectory, OperationMetadata> UpdateActiveDirectory(UpdateActiveDirectoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateActiveDirectoryRequest(ref request, ref callSettings);
            return new lro::Operation<ActiveDirectory, OperationMetadata>(_callUpdateActiveDirectory.Sync(request, callSettings), UpdateActiveDirectoryOperationsClient);
        }

        /// <summary>
        /// Update the parameters of an active directories.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ActiveDirectory, OperationMetadata>> UpdateActiveDirectoryAsync(UpdateActiveDirectoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateActiveDirectoryRequest(ref request, ref callSettings);
            return new lro::Operation<ActiveDirectory, OperationMetadata>(await _callUpdateActiveDirectory.Async(request, callSettings).ConfigureAwait(false), UpdateActiveDirectoryOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteActiveDirectory</c>.</summary>
        public override lro::OperationsClient DeleteActiveDirectoryOperationsClient { get; }

        /// <summary>
        /// Delete the active directory specified in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteActiveDirectory(DeleteActiveDirectoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteActiveDirectoryRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteActiveDirectory.Sync(request, callSettings), DeleteActiveDirectoryOperationsClient);
        }

        /// <summary>
        /// Delete the active directory specified in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteActiveDirectoryAsync(DeleteActiveDirectoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteActiveDirectoryRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteActiveDirectory.Async(request, callSettings).ConfigureAwait(false), DeleteActiveDirectoryOperationsClient);
        }

        /// <summary>
        /// Returns descriptions of all KMS configs owned by the caller.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="KmsConfig"/> resources.</returns>
        public override gax::PagedEnumerable<ListKmsConfigsResponse, KmsConfig> ListKmsConfigs(ListKmsConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListKmsConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListKmsConfigsRequest, ListKmsConfigsResponse, KmsConfig>(_callListKmsConfigs, request, callSettings);
        }

        /// <summary>
        /// Returns descriptions of all KMS configs owned by the caller.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="KmsConfig"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListKmsConfigsResponse, KmsConfig> ListKmsConfigsAsync(ListKmsConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListKmsConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListKmsConfigsRequest, ListKmsConfigsResponse, KmsConfig>(_callListKmsConfigs, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateKmsConfig</c>.</summary>
        public override lro::OperationsClient CreateKmsConfigOperationsClient { get; }

        /// <summary>
        /// Creates a new KMS config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<KmsConfig, OperationMetadata> CreateKmsConfig(CreateKmsConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateKmsConfigRequest(ref request, ref callSettings);
            return new lro::Operation<KmsConfig, OperationMetadata>(_callCreateKmsConfig.Sync(request, callSettings), CreateKmsConfigOperationsClient);
        }

        /// <summary>
        /// Creates a new KMS config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<KmsConfig, OperationMetadata>> CreateKmsConfigAsync(CreateKmsConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateKmsConfigRequest(ref request, ref callSettings);
            return new lro::Operation<KmsConfig, OperationMetadata>(await _callCreateKmsConfig.Async(request, callSettings).ConfigureAwait(false), CreateKmsConfigOperationsClient);
        }

        /// <summary>
        /// Returns the description of the specified KMS config by kms_config_id.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override KmsConfig GetKmsConfig(GetKmsConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetKmsConfigRequest(ref request, ref callSettings);
            return _callGetKmsConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the description of the specified KMS config by kms_config_id.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<KmsConfig> GetKmsConfigAsync(GetKmsConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetKmsConfigRequest(ref request, ref callSettings);
            return _callGetKmsConfig.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateKmsConfig</c>.</summary>
        public override lro::OperationsClient UpdateKmsConfigOperationsClient { get; }

        /// <summary>
        /// Updates the Kms config properties with the full spec
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<KmsConfig, OperationMetadata> UpdateKmsConfig(UpdateKmsConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateKmsConfigRequest(ref request, ref callSettings);
            return new lro::Operation<KmsConfig, OperationMetadata>(_callUpdateKmsConfig.Sync(request, callSettings), UpdateKmsConfigOperationsClient);
        }

        /// <summary>
        /// Updates the Kms config properties with the full spec
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<KmsConfig, OperationMetadata>> UpdateKmsConfigAsync(UpdateKmsConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateKmsConfigRequest(ref request, ref callSettings);
            return new lro::Operation<KmsConfig, OperationMetadata>(await _callUpdateKmsConfig.Async(request, callSettings).ConfigureAwait(false), UpdateKmsConfigOperationsClient);
        }

        /// <summary>The long-running operations client for <c>EncryptVolumes</c>.</summary>
        public override lro::OperationsClient EncryptVolumesOperationsClient { get; }

        /// <summary>
        /// Encrypt the existing volumes without CMEK encryption with the desired the
        /// KMS config for the whole region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<KmsConfig, OperationMetadata> EncryptVolumes(EncryptVolumesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EncryptVolumesRequest(ref request, ref callSettings);
            return new lro::Operation<KmsConfig, OperationMetadata>(_callEncryptVolumes.Sync(request, callSettings), EncryptVolumesOperationsClient);
        }

        /// <summary>
        /// Encrypt the existing volumes without CMEK encryption with the desired the
        /// KMS config for the whole region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<KmsConfig, OperationMetadata>> EncryptVolumesAsync(EncryptVolumesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EncryptVolumesRequest(ref request, ref callSettings);
            return new lro::Operation<KmsConfig, OperationMetadata>(await _callEncryptVolumes.Async(request, callSettings).ConfigureAwait(false), EncryptVolumesOperationsClient);
        }

        /// <summary>
        /// Verifies KMS config reachability.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override VerifyKmsConfigResponse VerifyKmsConfig(VerifyKmsConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_VerifyKmsConfigRequest(ref request, ref callSettings);
            return _callVerifyKmsConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Verifies KMS config reachability.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<VerifyKmsConfigResponse> VerifyKmsConfigAsync(VerifyKmsConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_VerifyKmsConfigRequest(ref request, ref callSettings);
            return _callVerifyKmsConfig.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteKmsConfig</c>.</summary>
        public override lro::OperationsClient DeleteKmsConfigOperationsClient { get; }

        /// <summary>
        /// Warning! This operation will permanently delete the Kms config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteKmsConfig(DeleteKmsConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteKmsConfigRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteKmsConfig.Sync(request, callSettings), DeleteKmsConfigOperationsClient);
        }

        /// <summary>
        /// Warning! This operation will permanently delete the Kms config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteKmsConfigAsync(DeleteKmsConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteKmsConfigRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteKmsConfig.Async(request, callSettings).ConfigureAwait(false), DeleteKmsConfigOperationsClient);
        }

        /// <summary>
        /// Returns descriptions of all replications for a volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Replication"/> resources.</returns>
        public override gax::PagedEnumerable<ListReplicationsResponse, Replication> ListReplications(ListReplicationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListReplicationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListReplicationsRequest, ListReplicationsResponse, Replication>(_callListReplications, request, callSettings);
        }

        /// <summary>
        /// Returns descriptions of all replications for a volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Replication"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListReplicationsResponse, Replication> ListReplicationsAsync(ListReplicationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListReplicationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListReplicationsRequest, ListReplicationsResponse, Replication>(_callListReplications, request, callSettings);
        }

        /// <summary>
        /// Describe a replication for a volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Replication GetReplication(GetReplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetReplicationRequest(ref request, ref callSettings);
            return _callGetReplication.Sync(request, callSettings);
        }

        /// <summary>
        /// Describe a replication for a volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Replication> GetReplicationAsync(GetReplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetReplicationRequest(ref request, ref callSettings);
            return _callGetReplication.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateReplication</c>.</summary>
        public override lro::OperationsClient CreateReplicationOperationsClient { get; }

        /// <summary>
        /// Create a new replication for a volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Replication, OperationMetadata> CreateReplication(CreateReplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateReplicationRequest(ref request, ref callSettings);
            return new lro::Operation<Replication, OperationMetadata>(_callCreateReplication.Sync(request, callSettings), CreateReplicationOperationsClient);
        }

        /// <summary>
        /// Create a new replication for a volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Replication, OperationMetadata>> CreateReplicationAsync(CreateReplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateReplicationRequest(ref request, ref callSettings);
            return new lro::Operation<Replication, OperationMetadata>(await _callCreateReplication.Async(request, callSettings).ConfigureAwait(false), CreateReplicationOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteReplication</c>.</summary>
        public override lro::OperationsClient DeleteReplicationOperationsClient { get; }

        /// <summary>
        /// Deletes a replication.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteReplication(DeleteReplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteReplicationRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteReplication.Sync(request, callSettings), DeleteReplicationOperationsClient);
        }

        /// <summary>
        /// Deletes a replication.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteReplicationAsync(DeleteReplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteReplicationRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteReplication.Async(request, callSettings).ConfigureAwait(false), DeleteReplicationOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateReplication</c>.</summary>
        public override lro::OperationsClient UpdateReplicationOperationsClient { get; }

        /// <summary>
        /// Updates the settings of a specific replication.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Replication, OperationMetadata> UpdateReplication(UpdateReplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateReplicationRequest(ref request, ref callSettings);
            return new lro::Operation<Replication, OperationMetadata>(_callUpdateReplication.Sync(request, callSettings), UpdateReplicationOperationsClient);
        }

        /// <summary>
        /// Updates the settings of a specific replication.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Replication, OperationMetadata>> UpdateReplicationAsync(UpdateReplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateReplicationRequest(ref request, ref callSettings);
            return new lro::Operation<Replication, OperationMetadata>(await _callUpdateReplication.Async(request, callSettings).ConfigureAwait(false), UpdateReplicationOperationsClient);
        }

        /// <summary>The long-running operations client for <c>StopReplication</c>.</summary>
        public override lro::OperationsClient StopReplicationOperationsClient { get; }

        /// <summary>
        /// Stop Cross Region Replication.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Replication, OperationMetadata> StopReplication(StopReplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StopReplicationRequest(ref request, ref callSettings);
            return new lro::Operation<Replication, OperationMetadata>(_callStopReplication.Sync(request, callSettings), StopReplicationOperationsClient);
        }

        /// <summary>
        /// Stop Cross Region Replication.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Replication, OperationMetadata>> StopReplicationAsync(StopReplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StopReplicationRequest(ref request, ref callSettings);
            return new lro::Operation<Replication, OperationMetadata>(await _callStopReplication.Async(request, callSettings).ConfigureAwait(false), StopReplicationOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ResumeReplication</c>.</summary>
        public override lro::OperationsClient ResumeReplicationOperationsClient { get; }

        /// <summary>
        /// Resume Cross Region Replication.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Replication, OperationMetadata> ResumeReplication(ResumeReplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResumeReplicationRequest(ref request, ref callSettings);
            return new lro::Operation<Replication, OperationMetadata>(_callResumeReplication.Sync(request, callSettings), ResumeReplicationOperationsClient);
        }

        /// <summary>
        /// Resume Cross Region Replication.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Replication, OperationMetadata>> ResumeReplicationAsync(ResumeReplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResumeReplicationRequest(ref request, ref callSettings);
            return new lro::Operation<Replication, OperationMetadata>(await _callResumeReplication.Async(request, callSettings).ConfigureAwait(false), ResumeReplicationOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ReverseReplicationDirection</c>.</summary>
        public override lro::OperationsClient ReverseReplicationDirectionOperationsClient { get; }

        /// <summary>
        /// Reverses direction of replication. Source becomes destination and
        /// destination becomes source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Replication, OperationMetadata> ReverseReplicationDirection(ReverseReplicationDirectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReverseReplicationDirectionRequest(ref request, ref callSettings);
            return new lro::Operation<Replication, OperationMetadata>(_callReverseReplicationDirection.Sync(request, callSettings), ReverseReplicationDirectionOperationsClient);
        }

        /// <summary>
        /// Reverses direction of replication. Source becomes destination and
        /// destination becomes source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Replication, OperationMetadata>> ReverseReplicationDirectionAsync(ReverseReplicationDirectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReverseReplicationDirectionRequest(ref request, ref callSettings);
            return new lro::Operation<Replication, OperationMetadata>(await _callReverseReplicationDirection.Async(request, callSettings).ConfigureAwait(false), ReverseReplicationDirectionOperationsClient);
        }
    }

    public partial class ListStoragePoolsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListVolumesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSnapshotsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListActiveDirectoriesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListKmsConfigsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListReplicationsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListStoragePoolsResponse : gaxgrpc::IPageResponse<StoragePool>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<StoragePool> GetEnumerator() => StoragePools.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListVolumesResponse : gaxgrpc::IPageResponse<Volume>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Volume> GetEnumerator() => Volumes.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListSnapshotsResponse : gaxgrpc::IPageResponse<Snapshot>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Snapshot> GetEnumerator() => Snapshots.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListActiveDirectoriesResponse : gaxgrpc::IPageResponse<ActiveDirectory>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ActiveDirectory> GetEnumerator() => ActiveDirectories.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListKmsConfigsResponse : gaxgrpc::IPageResponse<KmsConfig>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<KmsConfig> GetEnumerator() => KmsConfigs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListReplicationsResponse : gaxgrpc::IPageResponse<Replication>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Replication> GetEnumerator() => Replications.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class NetApp
    {
        public partial class NetAppClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClient() =>
                new lro::Operations.OperationsClient(CallInvoker);
        }
    }

    public static partial class NetApp
    {
        public partial class NetAppClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="gcl::Locations.LocationsClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>
            /// A new <see cref="gcl::Locations.LocationsClient"/> for the same target as this client.
            /// </returns>
            public virtual gcl::Locations.LocationsClient CreateLocationsClient() =>
                new gcl::Locations.LocationsClient(CallInvoker);
        }
    }
}
