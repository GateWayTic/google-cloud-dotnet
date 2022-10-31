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

namespace Google.Cloud.Speech.V2.Snippets
{
    // [START speech_v2_generated_Speech_UpdatePhraseSet_sync]
    using Google.Cloud.Speech.V2;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;

    public sealed partial class GeneratedSpeechClientSnippets
    {
        /// <summary>Snippet for UpdatePhraseSet</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void UpdatePhraseSetRequestObject()
        {
            // Create client
            SpeechClient speechClient = SpeechClient.Create();
            // Initialize request argument(s)
            UpdatePhraseSetRequest request = new UpdatePhraseSetRequest
            {
                PhraseSet = new PhraseSet(),
                UpdateMask = new FieldMask(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<PhraseSet, OperationMetadata> response = speechClient.UpdatePhraseSet(request);

            // Poll until the returned long-running operation is complete
            Operation<PhraseSet, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PhraseSet result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PhraseSet, OperationMetadata> retrievedResponse = speechClient.PollOnceUpdatePhraseSet(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PhraseSet retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END speech_v2_generated_Speech_UpdatePhraseSet_sync]
}