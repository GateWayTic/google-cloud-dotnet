// Copyright 2017 Google Inc. All Rights Reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Apis.Bigquery.v2.Data;
using NSubstitute;
using Xunit;

namespace Google.Cloud.BigQuery.V2.Tests
{
    public class BigQueryDatasetTest
    {
        // Most aspects are tested via equivalent in BigQueryClientTest

        [Fact]
        public void FullyQualifiedId()
        {
            var reference = new DatasetReference { ProjectId = "my-project", DatasetId = "my-dataset" };
            var dataset = new BigQueryDataset(Substitute.For<BigQueryClient>(), new Dataset { DatasetReference = reference });
            Assert.Equal("my-project:my-dataset", dataset.FullyQualifiedId);
        }
    }
}
