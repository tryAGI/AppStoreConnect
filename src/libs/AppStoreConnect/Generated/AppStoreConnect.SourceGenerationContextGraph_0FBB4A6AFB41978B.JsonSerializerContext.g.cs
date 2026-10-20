
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_0FBB4A6AFB41978B : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_0FBB4A6AFB41978B Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_0FBB4A6AFB41978B(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::AppStoreConnect.CustomerReviewSummarizationType)

                    || typeToConvert == typeof(global::AppStoreConnect.CustomerReviewSummarizationType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CustomerReviewSummarizationRelationshipsTerritoryDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CustomerReviewSummarizationRelationshipsTerritoryDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.TerritoryType)

                    || typeToConvert == typeof(global::AppStoreConnect.TerritoryType?)

                    || typeToConvert == typeof(global::AppStoreConnect.Platform)

                    || typeToConvert == typeof(global::AppStoreConnect.Platform?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsCustomerReviewSummarizationsGetToManyRelatedFilterPlatformItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsCustomerReviewSummarizationsGetToManyRelatedFilterPlatformItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsCustomerReviewSummarizationsGetToManyRelatedFieldsCustomerReviewSummarization)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsCustomerReviewSummarizationsGetToManyRelatedFieldsCustomerReviewSummarization?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsCustomerReviewSummarizationsGetToManyRelatedFieldsTerritorie)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsCustomerReviewSummarizationsGetToManyRelatedFieldsTerritorie?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsCustomerReviewSummarizationsGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsCustomerReviewSummarizationsGetToManyRelatedIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.CustomerReviewSummarizationType))
                {
                    return new global::AppStoreConnect.JsonConverters.CustomerReviewSummarizationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CustomerReviewSummarizationType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CustomerReviewSummarizationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CustomerReviewSummarizationRelationshipsTerritoryDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.CustomerReviewSummarizationRelationshipsTerritoryDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CustomerReviewSummarizationRelationshipsTerritoryDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CustomerReviewSummarizationRelationshipsTerritoryDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.TerritoryType))
                {
                    return new global::AppStoreConnect.JsonConverters.TerritoryTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.TerritoryType?))
                {
                    return new global::AppStoreConnect.JsonConverters.TerritoryTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.Platform))
                {
                    return new global::AppStoreConnect.JsonConverters.PlatformJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.Platform?))
                {
                    return new global::AppStoreConnect.JsonConverters.PlatformNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsCustomerReviewSummarizationsGetToManyRelatedFilterPlatformItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsCustomerReviewSummarizationsGetToManyRelatedFilterPlatformItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsCustomerReviewSummarizationsGetToManyRelatedFilterPlatformItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsCustomerReviewSummarizationsGetToManyRelatedFilterPlatformItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsCustomerReviewSummarizationsGetToManyRelatedFieldsCustomerReviewSummarization))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsCustomerReviewSummarizationsGetToManyRelatedFieldsCustomerReviewSummarizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsCustomerReviewSummarizationsGetToManyRelatedFieldsCustomerReviewSummarization?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsCustomerReviewSummarizationsGetToManyRelatedFieldsCustomerReviewSummarizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsCustomerReviewSummarizationsGetToManyRelatedFieldsTerritorie))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsCustomerReviewSummarizationsGetToManyRelatedFieldsTerritorieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsCustomerReviewSummarizationsGetToManyRelatedFieldsTerritorie?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsCustomerReviewSummarizationsGetToManyRelatedFieldsTerritorieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsCustomerReviewSummarizationsGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsCustomerReviewSummarizationsGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsCustomerReviewSummarizationsGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsCustomerReviewSummarizationsGetToManyRelatedIncludeItemNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }
        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::System.Collections.Generic.Dictionary<string, string>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_FC0ACBA26C044EC8(options);
                }
                if (type == typeof(global::System.Collections.Generic.Dictionary<string, object>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_8219E7AD6AEFA4B4(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<object>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_92E1ACA86984772C(options);
                }
                if (type == typeof(global::System.Text.Json.JsonElement?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_NullableJsonElement(options);
                }
                if (type == typeof(global::System.Collections.Generic.IDictionary<string, object>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_7024F6984ED20EB8(options);
                }
                if (type == typeof(string))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_String(options);
                }
                if (type == typeof(object))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Object(options);
                }
                if (type == typeof(global::System.Text.Json.JsonElement))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_JsonElement(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsCustomerReviewSummarizationsGetToManyRelatedFieldsCustomerReviewSummarization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsCustomerReviewSummarizationsGetToManyRelatedFieldsCustomerReviewSummarization2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsCustomerReviewSummarizationsGetToManyRelatedFieldsTerritorie))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsCustomerReviewSummarizationsGetToManyRelatedFieldsTerritorie2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsCustomerReviewSummarizationsGetToManyRelatedFilterPlatformItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsCustomerReviewSummarizationsGetToManyRelatedFilterPlatformItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsCustomerReviewSummarizationsGetToManyRelatedIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsCustomerReviewSummarizationsGetToManyRelatedIncludeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.CustomerReviewSummarization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CustomerReviewSummarization(options);
                }
                if (type == typeof(global::AppStoreConnect.CustomerReviewSummarizationAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CustomerReviewSummarizationAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.CustomerReviewSummarizationRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CustomerReviewSummarizationRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.CustomerReviewSummarizationRelationshipsTerritory))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CustomerReviewSummarizationRelationshipsTerritory(options);
                }
                if (type == typeof(global::AppStoreConnect.CustomerReviewSummarizationRelationshipsTerritoryData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CustomerReviewSummarizationRelationshipsTerritoryData(options);
                }
                if (type == typeof(global::AppStoreConnect.CustomerReviewSummarizationRelationshipsTerritoryDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CustomerReviewSummarizationRelationshipsTerritoryDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CustomerReviewSummarizationType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CustomerReviewSummarizationType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CustomerReviewSummarizationsResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CustomerReviewSummarizationsResponse(options);
                }
                if (type == typeof(global::AppStoreConnect.PagedDocumentLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_PagedDocumentLinks(options);
                }
                if (type == typeof(global::AppStoreConnect.PagingInformation))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_PagingInformation(options);
                }
                if (type == typeof(global::AppStoreConnect.PagingInformationPaging))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_PagingInformationPaging(options);
                }
                if (type == typeof(global::AppStoreConnect.Platform))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Platform2(options);
                }
                if (type == typeof(global::AppStoreConnect.ResourceLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_ResourceLinks(options);
                }
                if (type == typeof(global::AppStoreConnect.Territory))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Territory(options);
                }
                if (type == typeof(global::AppStoreConnect.TerritoryAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_TerritoryAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.TerritoryType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_TerritoryType2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsCustomerReviewSummarizationsGetToManyRelatedFieldsCustomerReviewSummarization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_A2651FB3C672E964(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsCustomerReviewSummarizationsGetToManyRelatedFieldsTerritorie>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_721BC805B7D1C7D0(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsCustomerReviewSummarizationsGetToManyRelatedFilterPlatformItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_4FC37759EF3FD7F8(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsCustomerReviewSummarizationsGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_D15D9249B0EE6DEE(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CustomerReviewSummarization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_39A39BEE7C87C027(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.Territory>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_9F4289B69AA2C0EC(options);
                }
                if (type == typeof(global::System.DateTime))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_DateTime(options);
                }
                if (type == typeof(int))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsCustomerReviewSummarizationsGetToManyRelatedFieldsCustomerReviewSummarization?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsCustomerReviewSummarizationsGetToManyRelatedFieldsCustomerReviewSummarization2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsCustomerReviewSummarizationsGetToManyRelatedFieldsTerritorie?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsCustomerReviewSummarizationsGetToManyRelatedFieldsTerritorie2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsCustomerReviewSummarizationsGetToManyRelatedFilterPlatformItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsCustomerReviewSummarizationsGetToManyRelatedFilterPlatformItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsCustomerReviewSummarizationsGetToManyRelatedIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsCustomerReviewSummarizationsGetToManyRelatedIncludeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.CustomerReviewSummarizationRelationshipsTerritoryDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableCustomerReviewSummarizationRelationshipsTerritoryDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CustomerReviewSummarizationType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableCustomerReviewSummarizationType2(options);
                }
                if (type == typeof(global::AppStoreConnect.Platform?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullablePlatform2(options);
                }
                if (type == typeof(global::AppStoreConnect.TerritoryType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableTerritoryType2(options);
                }
                if (type == typeof(global::System.DateTime?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableDateTime(options);
                }
                if (type == typeof(int?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsCustomerReviewSummarizationsGetToManyRelatedFieldsCustomerReviewSummarization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_0E5068A70B6FF739(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsCustomerReviewSummarizationsGetToManyRelatedFieldsTerritorie>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_EE19E37A832086A1(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsCustomerReviewSummarizationsGetToManyRelatedFilterPlatformItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_7799064E7FD52848(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsCustomerReviewSummarizationsGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_031ADEFA8B99E643(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CustomerReviewSummarization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_F48CD8A7A8DCE27F(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.Territory>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_F260B12DCFDBCB53(options);
                }
                global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? additional = null;
                ResolveAdditionalTypeInfo(type, options, ref additional);
                return additional;
            }

            static partial void ResolveAdditionalTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options,
                ref global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? result);
        }


        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new SharedMetadataResolver(),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}