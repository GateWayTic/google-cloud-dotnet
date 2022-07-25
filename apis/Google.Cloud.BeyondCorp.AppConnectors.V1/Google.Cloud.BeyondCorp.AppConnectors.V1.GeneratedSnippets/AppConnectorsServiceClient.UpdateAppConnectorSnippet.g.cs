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

namespace Google.Cloud.BeyondCorp.AppConnectors.V1.Snippets
{
    // [START beyondcorp_v1_generated_AppConnectorsService_UpdateAppConnector_sync_flattened]
    using Google.Cloud.BeyondCorp.AppConnectors.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;

    public sealed partial class GeneratedAppConnectorsServiceClientSnippets
    {
        /// <summary>Snippet for UpdateAppConnector</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void UpdateAppConnector()
        {
            // Create client
            AppConnectorsServiceClient appConnectorsServiceClient = AppConnectorsServiceClient.Create();
            // Initialize request argument(s)
            AppConnector appConnector = new AppConnector();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<AppConnector, AppConnectorOperationMetadata> response = appConnectorsServiceClient.UpdateAppConnector(appConnector, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<AppConnector, AppConnectorOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AppConnector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AppConnector, AppConnectorOperationMetadata> retrievedResponse = appConnectorsServiceClient.PollOnceUpdateAppConnector(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AppConnector retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END beyondcorp_v1_generated_AppConnectorsService_UpdateAppConnector_sync_flattened]
}