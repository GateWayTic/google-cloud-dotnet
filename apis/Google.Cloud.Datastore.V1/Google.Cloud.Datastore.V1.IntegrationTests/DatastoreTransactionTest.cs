// Copyright 2016 Google Inc. All Rights Reserved.
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

using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using static Google.Cloud.Datastore.V1.Aggregations;
using static Google.Cloud.Datastore.V1.Key.Types;

namespace Google.Cloud.Datastore.V1.IntegrationTests
{
    [Collection(nameof(DatastoreFixture))]
    public class DatastoreTransactionTest
    {
        private readonly DatastoreFixture _fixture;

        public DatastoreTransactionTest(DatastoreFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void SyncQueries_ImplicityUsePartition()
        {
            var db = _fixture.CreateDatastoreDb();
            var parentKey = PrepareQueryTest(db);
            using (var transaction = db.BeginTransaction())
            {
                var query = new Query("childKind") { Filter = Filter.HasAncestor(parentKey) };
                var gql = new GqlQuery
                {
                    QueryString = "SELECT * FROM childKind WHERE __key__ HAS ANCESTOR @1",
                    PositionalBindings = { parentKey }
                };
                var lazyResults = transaction.RunQueryLazily(query);
                Assert.Equal(1, lazyResults.Count());
                lazyResults = transaction.RunQueryLazily(gql);
                Assert.Equal(1, lazyResults.Count());

                var eagerResults = transaction.RunQuery(query);
                Assert.Equal(1, eagerResults.Entities.Count);
                eagerResults = transaction.RunQuery(gql);
                Assert.Equal(1, eagerResults.Entities.Count);
            }
        }

        [Fact]
        public async Task AsyncQueries_ImplicityUsePartition()
        {
            var db = _fixture.CreateDatastoreDb();
            var parentKey = PrepareQueryTest(db);
            using (var transaction = db.BeginTransaction())
            {
                var query = new Query("childKind") { Filter = Filter.HasAncestor(parentKey) };
                var gql = new GqlQuery
                {
                    QueryString = "SELECT * FROM childKind WHERE __key__ HAS ANCESTOR @1",
                    PositionalBindings = { parentKey }
                };
                var lazyResults = transaction.RunQueryLazilyAsync(query);
                Assert.Equal(1, await lazyResults.CountAsync());
                lazyResults = transaction.RunQueryLazilyAsync(gql);
                Assert.Equal(1, await lazyResults.CountAsync());

                var eagerResults = await transaction.RunQueryAsync(query);
                Assert.Equal(1, eagerResults.Entities.Count);
                eagerResults = await transaction.RunQueryAsync(gql);
                Assert.Equal(1, eagerResults.Entities.Count);
            }
        }

        private Key PrepareQueryTest(DatastoreDb db)
        {
            var keyFactory = db.CreateKeyFactory("parent");
            var parent = new Entity
            {
                Key = keyFactory.CreateIncompleteKey()
            };
            var parentKey = db.Insert(parent);

            var child = new Entity
            {
                Key = parentKey.WithElement(new PathElement { Kind = "childKind" })
            };
            db.Insert(child);
            return parentKey;
        }

        [Fact]
        public void Delete()
        {
            var db = _fixture.CreateDatastoreDb();
            var keyFactory = db.CreateKeyFactory("book");
            var entity = new Entity { Key = keyFactory.CreateIncompleteKey(), ["title"] = "Programming F#" };

            using (var transaction = db.BeginTransaction())
            {
                transaction.Insert(entity);
                transaction.Commit();
            }

            Assert.NotNull(db.Lookup(entity.Key));

            using (var transaction = db.BeginTransaction())
            {
                transaction.Delete(entity.Key);
                transaction.Commit();
            }

            Assert.Null(db.Lookup(entity.Key));
        }

        [Fact]
        public Task CommitPropagatesKeys() => CommitTest(t => Task.FromResult(t.Commit()));

        [Fact]
        public Task CommitAsyncPropagatesKeys() => CommitTest(t => t.CommitAsync());

        private async Task CommitTest(Func<DatastoreTransaction, Task<CommitResponse>> commitCall)
        {
            var db = _fixture.CreateDatastoreDb();
            var keyFactory = db.CreateKeyFactory("book");
            var updatedEntity = new Entity { Key = keyFactory.CreateIncompleteKey(), ["description"] = "Inserted before transaction" };
            db.Insert(updatedEntity);

            Entity insertedEntity = new Entity { Key = keyFactory.CreateIncompleteKey(), ["description"] = "Inserted in transaction" };
            Entity upsertedEntity = new Entity { Key = keyFactory.CreateIncompleteKey(), ["description"] = "Upserted in transaction" };
            using (var transaction = db.BeginTransaction())
            {
                transaction.Insert(insertedEntity);
                transaction.Upsert(upsertedEntity);
                updatedEntity["description"] = "Updated in transaction";
                transaction.Update(updatedEntity);
                await commitCall(transaction);
            }

            // Check we can fetch with the newly allocated keys
            var entities = db.Lookup(insertedEntity.Key, upsertedEntity.Key, updatedEntity.Key);
            var descriptions = entities.Select(e => (string) e["description"]);
            Assert.Equal(new[] { "Inserted in transaction", "Upserted in transaction", "Updated in transaction" }, descriptions);
        }

        [Fact]
        public void Transaction_WithAggregation_StructuredQuery()
        {
            var db = _fixture.CreateDatastoreDb();
            var keyFactory = db.CreateKeyFactory("AggTestTransaction");
            var entities = new[]
            {
                new Entity { Key = keyFactory.CreateKey("11"), ["age"] = 12, ["height"] = 5  },
                new Entity { Key = keyFactory.CreateKey("21"), ["age"] = 12, ["height"] = 4.6  },
                new Entity { Key = keyFactory.CreateKey("31"), ["age"] = 14, ["height"] = 4  },
                new Entity { Key = keyFactory.CreateKey("41"), ["age"] = 11, ["height"] = 5.2  }
            };
            db.Insert(entities);
            using var transaction = db.BeginTransaction();
            var query = new Query("AggTestTransaction");
            AggregationQuery aggQuery = new AggregationQuery(query)
            {
                Aggregations = { Count("count"), Sum("age", "sum_age"), Average("age", "avg_age") }
            };
            AggregationQueryResults results = transaction.RunAggregationQuery(aggQuery);
            Assert.Equal(4, results["count"].IntegerValue);
            Assert.Equal(49, results["sum_age"].IntegerValue);
            Assert.Equal(12.25, results["avg_age"].DoubleValue);
        }

        [Fact]
        public void Transaction_WithAggregation_GQL()
        {
            var db = _fixture.CreateDatastoreDb();
            var keyFactory = db.CreateKeyFactory("GQLAggTestTransaction");
            var entities = new[]
            {
                new Entity { Key = keyFactory.CreateKey("11"), ["age"] = 12, ["height"] = 5  },
                new Entity { Key = keyFactory.CreateKey("21"), ["age"] = 12, ["height"] = 4.6  },
                new Entity { Key = keyFactory.CreateKey("31"), ["age"] = 14, ["height"] = 4  },
                new Entity { Key = keyFactory.CreateKey("41"), ["age"] = 11, ["height"] = 5.2  }
            };
            db.Insert(entities);
            using var transaction = db.BeginTransaction();

            var gqlQuery = new GqlQuery { QueryString = "SELECT count(*)  as `count`,sum(height) as `sum_height`, avg(height) as `avg_height` FROM GQLAggTestTransaction " };
            var query = new Query("GQLAggTestTransaction");            
            AggregationQueryResults results = transaction.RunAggregationQuery(gqlQuery);

            Assert.Equal(4, results["count"].IntegerValue);
            Assert.Equal(18.8, results["sum_height"].DoubleValue);
            Assert.Equal(4.7, results["avg_height"].DoubleValue);
        }
    }
}
