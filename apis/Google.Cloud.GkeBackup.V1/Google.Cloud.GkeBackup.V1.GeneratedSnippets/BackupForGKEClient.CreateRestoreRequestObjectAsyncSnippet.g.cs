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

namespace Google.Cloud.GkeBackup.V1.Snippets
{
    // [START gkebackup_v1_generated_BackupForGKE_CreateRestore_async]
    using Google.Cloud.GkeBackup.V1;
    using Google.LongRunning;
    using System.Threading.Tasks;

    public sealed partial class GeneratedBackupForGKEClientSnippets
    {
        /// <summary>Snippet for CreateRestoreAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task CreateRestoreRequestObjectAsync()
        {
            // Create client
            BackupForGKEClient backupForGKEClient = await BackupForGKEClient.CreateAsync();
            // Initialize request argument(s)
            CreateRestoreRequest request = new CreateRestoreRequest
            {
                ParentAsRestorePlanName = RestorePlanName.FromProjectLocationRestorePlan("[PROJECT]", "[LOCATION]", "[RESTORE_PLAN]"),
                Restore = new Restore(),
                RestoreId = "",
            };
            // Make the request
            Operation<Restore, OperationMetadata> response = await backupForGKEClient.CreateRestoreAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Restore, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Restore result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Restore, OperationMetadata> retrievedResponse = await backupForGKEClient.PollOnceCreateRestoreAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Restore retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END gkebackup_v1_generated_BackupForGKE_CreateRestore_async]
}