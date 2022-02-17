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

namespace Google.Cloud.Tpu.V1.Snippets
{
    // [START tpu_v1_generated_Tpu_ListAcceleratorTypes_async]
    using Google.Api.Gax;
    using Google.Cloud.Tpu.V1;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    public sealed partial class GeneratedTpuClientSnippets
    {
        /// <summary>Snippet for ListAcceleratorTypesAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task ListAcceleratorTypesRequestObjectAsync()
        {
            // Create client
            TpuClient tpuClient = await TpuClient.CreateAsync();
            // Initialize request argument(s)
            ListAcceleratorTypesRequest request = new ListAcceleratorTypesRequest
            {
                ParentAsAcceleratorTypeName = AcceleratorTypeName.FromProjectLocationAcceleratorType("[PROJECT]", "[LOCATION]", "[ACCELERATOR_TYPE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListAcceleratorTypesResponse, AcceleratorType> response = tpuClient.ListAcceleratorTypesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AcceleratorType item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAcceleratorTypesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AcceleratorType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AcceleratorType> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AcceleratorType item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
        }
    }
    // [END tpu_v1_generated_Tpu_ListAcceleratorTypes_async]
}