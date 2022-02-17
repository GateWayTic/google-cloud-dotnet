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

namespace Google.Cloud.AppEngine.V1.Snippets
{
    // [START appengine_v1_generated_DomainMappings_DeleteDomainMapping_sync]
    using Google.Cloud.AppEngine.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;

    public sealed partial class GeneratedDomainMappingsClientSnippets
    {
        /// <summary>Snippet for DeleteDomainMapping</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void DeleteDomainMappingRequestObject()
        {
            // Create client
            DomainMappingsClient domainMappingsClient = DomainMappingsClient.Create();
            // Initialize request argument(s)
            DeleteDomainMappingRequest request = new DeleteDomainMappingRequest { Name = "", };
            // Make the request
            Operation<Empty, OperationMetadataV1> response = domainMappingsClient.DeleteDomainMapping(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadataV1> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadataV1> retrievedResponse = domainMappingsClient.PollOnceDeleteDomainMapping(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END appengine_v1_generated_DomainMappings_DeleteDomainMapping_sync]
}