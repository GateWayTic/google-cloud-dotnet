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

using Google.Api.Gax;
using Google.Api.Gax.Rest;
using Google.Apis.Bigquery.v2.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Google.Cloud.BigQuery.V2
{
    /// <summary>
    /// Class making it simple to create a <see cref="TableSchema"/>.
    /// </summary>
    /// <remarks>
    /// This class only implements <see cref="IEnumerable"/> in order to allow it to be used in
    /// collection initializers.
    /// </remarks>
    public sealed class TableSchemaBuilder : IEnumerable
    {
        private readonly List<TableFieldSchema> _fields = new List<TableFieldSchema>();

        /// <summary>
        /// Adds the given field to the schema being built.
        /// </summary>
        /// <param name="field">The field to add. Must not be null.</param>
        public void Add(TableFieldSchema field)
        {
            GaxPreconditions.CheckNotNull(field, nameof(field));
            _fields.Add(field);
        }

        /// <summary>
        /// Modifies the field with <paramref name="fieldName"/> by running the given action.
        /// </summary>
        /// <param name="fieldName">The name of the field to be modified. Must not be null.</param>
        /// <param name="fieldModifier">An action to be performed on the given field.</param>
        /// <returns>
        /// This <see cref="TableSchemaBuilder"/> after having applied the modification. For the purposes of method chaining.
        /// </returns>
        /// <exception cref="ArgumentException"><paramref name="fieldName"/> is not present within the schema being built.</exception>
        public TableSchemaBuilder ModifyField(string fieldName, Action<TableFieldSchema> fieldModifier)
        {
            GaxPreconditions.CheckNotNull(fieldName, nameof(fieldName));
            GaxPreconditions.CheckNotNull(fieldModifier, nameof(fieldModifier));
            var field = _fields.FirstOrDefault(field => field.Name == fieldName) ?? throw new ArgumentException($"Field '{fieldName}' not found in the schema.", nameof(fieldName));
            fieldModifier(field);
            return this;
        }

        /// <summary>
        /// Creates a field with the specified details, and adds it to the schema being built.
        /// </summary>
        /// <param name="name">The name of the field. Must be a valid field name.</param>
        /// <param name="type">The type of the field. Must be a defined member within <see cref="BigQueryDbType"/>, other than <c>Struct</c> or <c>Array</c>.</param>
        /// <param name="mode">The mode of the field. Must be a defined member within <see cref="BigQueryFieldMode"/>.</param>
        /// <param name="description">The description of the field. May be null.</param>
        public void Add(string name, BigQueryDbType type, BigQueryFieldMode mode = BigQueryFieldMode.Nullable, string description = null)
        {
            ValidateFieldName(name, nameof(name));
            GaxPreconditions.CheckArgument(type != BigQueryDbType.Struct, nameof(type),
                $"{nameof(BigQueryDbType.Struct)} fields must be specified with their schema");
            GaxPreconditions.CheckArgument(type != BigQueryDbType.Array, nameof(type),
                $"{nameof(BigQueryDbType.Array)} fields must be specified with by element type with a {nameof(BigQueryFieldMode)} of {nameof(BigQueryFieldMode.Repeated)}");

            Add(new TableFieldSchema
            {
                Name = name,
                Type = EnumMap.ToApiValue(type, nameof(type)),
                Mode = EnumMap.ToApiValue(mode, nameof(mode)),
                Description = description,
            });
        }

        internal static void ValidateFieldName(string name, string paramName)
        {
            GaxPreconditions.CheckNotNull(name, paramName);

            GaxPreconditions.CheckArgument(IsValidFieldName(name), paramName, "Invalid field name '{0}'", name);
        }

        // From BigQuery documentation:
        // The name must contain only letters (a-z, A-Z), numbers (0-9),
        // or underscores (_), and must start with a letter or underscore.
        // The maximum length is 128 characters.
        // This was originally a regular expression, but the manual code is very significantly faster.
        // (Roughly 10x faster with the benchmarks I've run.)
        private static bool IsValidFieldName(string name)
        {
            if (name.Length < 1 || name.Length > 128)
            {
                return false;
            }
            char first = name[0];
            bool validFirst = (first >= 'a' && first <= 'z') || (first >= 'A' && first <= 'Z') || first == '_';
            if (!validFirst)
            {
                return false;
            }
            for (int i = 1; i < name.Length; i++)
            {
                char c = name[i];
                bool valid = (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || (c >= '0' && c <= '9') || c == '_';
                if (!valid)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Creates a nested field with the specified schema, and adds it to the schema being built.
        /// </summary>
        /// <param name="name">The name of the field. Must be a valid field name.</param>
        /// <param name="nestedSchema">The schema for the nested field. Must not be null.</param>
        /// <param name="mode">The mode of the field. Must be a defined member within <see cref="BigQueryFieldMode"/>.</param>
        /// <param name="description">The description of the field. May be null.</param>
        public void Add(string name, TableSchema nestedSchema, BigQueryFieldMode mode = BigQueryFieldMode.Nullable, string description = null)
        {
            ValidateFieldName(name, nameof(name));
            GaxPreconditions.CheckNotNull(nestedSchema, nameof(nestedSchema));

            Add(new TableFieldSchema
            {
                Name = name,
                Fields = nestedSchema.Fields,
                Type = EnumMap.ToApiValue(BigQueryDbType.Struct),
                Mode = EnumMap.ToApiValue(mode, nameof(mode)),
                Description = description,
            });
        }

        /// <summary>
        /// Creates a nested field with the specified schema, and adds it to the schema being built.
        /// This method simply delegates to <see cref="Add(string, TableSchema, BigQueryFieldMode, string)"/> after calling <see cref="Build"/>
        /// on <paramref name="nestedSchema"/>.
        /// </summary>
        /// <param name="name">The name of the field. Must be a valid field name.</param>
        /// <param name="nestedSchema">The schema for the nested field, in the form of a <see cref="TableSchemaBuilder"/>. Must not be null.</param>
        /// <param name="mode">The mode of the field. Must be a defined member within <see cref="BigQueryFieldMode"/>.</param>
        /// <param name="description">The description of the field. May be null.</param>
        public void Add(string name, TableSchemaBuilder nestedSchema, BigQueryFieldMode mode = BigQueryFieldMode.Nullable, string description = null)
        {
            var builtSchema = GaxPreconditions.CheckNotNull(nestedSchema, nameof(nestedSchema)).Build();
            Add(name, builtSchema, mode, description);
        }

        /// <summary>
        /// Constructs a <see cref="TableSchema"/> from this builder.
        /// </summary>
        /// <returns>A <see cref="TableSchema"/> from the fields added to this builder.</returns>
        public TableSchema Build() => new TableSchema { Fields = _fields };


        /// <summary>
        /// Returns an iterator over the fields in this builder.
        /// </summary>
        /// <remarks>This method only exists to satisfy the C# language rules on collection initializers.</remarks>
        /// <returns>An iterator over the fields in this builder.</returns>
        IEnumerator IEnumerable.GetEnumerator() => _fields.GetEnumerator();
    }
}
