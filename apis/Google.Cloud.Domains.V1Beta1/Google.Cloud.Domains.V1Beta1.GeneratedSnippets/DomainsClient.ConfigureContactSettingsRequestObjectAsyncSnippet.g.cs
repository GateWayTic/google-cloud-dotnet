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

namespace Google.Cloud.Domains.V1Beta1.Snippets
{
    // [START domains_v1beta1_generated_Domains_ConfigureContactSettings_async]
    using Google.Cloud.Domains.V1Beta1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    public sealed partial class GeneratedDomainsClientSnippets
    {
        /// <summary>Snippet for ConfigureContactSettingsAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task ConfigureContactSettingsRequestObjectAsync()
        {
            // Create client
            DomainsClient domainsClient = await DomainsClient.CreateAsync();
            // Initialize request argument(s)
            ConfigureContactSettingsRequest request = new ConfigureContactSettingsRequest
            {
                RegistrationAsRegistrationName = RegistrationName.FromProjectLocationRegistration("[PROJECT]", "[LOCATION]", "[REGISTRATION]"),
                ContactSettings = new ContactSettings(),
                UpdateMask = new FieldMask(),
                ContactNotices =
                {
                    ContactNotice.Unspecified,
                },
                ValidateOnly = false,
            };
            // Make the request
            Operation<Registration, OperationMetadata> response = await domainsClient.ConfigureContactSettingsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Registration, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Registration result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Registration, OperationMetadata> retrievedResponse = await domainsClient.PollOnceConfigureContactSettingsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Registration retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END domains_v1beta1_generated_Domains_ConfigureContactSettings_async]
}