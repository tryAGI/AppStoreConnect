
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_B8CB40982F0738DC : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_B8CB40982F0738DC Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_B8CB40982F0738DC(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.SubscriptionPricePointType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPricePointType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPricePointRelationshipsTerritoryDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPricePointRelationshipsTerritoryDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.TerritoryType)

                    || typeToConvert == typeof(global::AppStoreConnect.TerritoryType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPricePointsGetInstanceFieldsSubscriptionPricePoint)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPricePointsGetInstanceFieldsSubscriptionPricePoint?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPricePointsGetInstanceFieldsTerritorie)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPricePointsGetInstanceFieldsTerritorie?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPricePointsGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPricePointsGetInstanceIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPricePointType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPricePointTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPricePointType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPricePointTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPricePointRelationshipsTerritoryDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPricePointRelationshipsTerritoryDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPricePointRelationshipsTerritoryDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPricePointRelationshipsTerritoryDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.TerritoryType))
                {
                    return new global::AppStoreConnect.JsonConverters.TerritoryTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.TerritoryType?))
                {
                    return new global::AppStoreConnect.JsonConverters.TerritoryTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPricePointsGetInstanceFieldsSubscriptionPricePoint))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPricePointsGetInstanceFieldsSubscriptionPricePointJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPricePointsGetInstanceFieldsSubscriptionPricePoint?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPricePointsGetInstanceFieldsSubscriptionPricePointNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPricePointsGetInstanceFieldsTerritorie))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPricePointsGetInstanceFieldsTerritorieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPricePointsGetInstanceFieldsTerritorie?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPricePointsGetInstanceFieldsTerritorieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPricePointsGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPricePointsGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPricePointsGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPricePointsGetInstanceIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.DocumentLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_DocumentLinks(options);
                }
                if (type == typeof(global::AppStoreConnect.RelationshipLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_RelationshipLinks(options);
                }
                if (type == typeof(global::AppStoreConnect.ResourceLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_ResourceLinks(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPricePoint))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionPricePoint(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPricePointAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionPricePointAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPricePointRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionPricePointRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPricePointRelationshipsAdjustedEqualizations))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionPricePointRelationshipsAdjustedEqualizations(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPricePointRelationshipsEqualizations))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionPricePointRelationshipsEqualizations(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPricePointRelationshipsTerritory))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionPricePointRelationshipsTerritory(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPricePointRelationshipsTerritoryData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionPricePointRelationshipsTerritoryData(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPricePointRelationshipsTerritoryDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionPricePointRelationshipsTerritoryDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPricePointResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionPricePointResponse(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPricePointType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionPricePointType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPricePointsGetInstanceFieldsSubscriptionPricePoint))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SubscriptionPricePointsGetInstanceFieldsSubscriptionPricePoint2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPricePointsGetInstanceFieldsTerritorie))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SubscriptionPricePointsGetInstanceFieldsTerritorie2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPricePointsGetInstanceIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SubscriptionPricePointsGetInstanceIncludeItem2(options);
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
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPricePointsGetInstanceFieldsSubscriptionPricePoint>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_BB5D18808B8F36B7(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPricePointsGetInstanceFieldsTerritorie>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_808D192D1272CCF6(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPricePointsGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_BD73DD6D537B73AB(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.Territory>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_9F4289B69AA2C0EC(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPricePointRelationshipsTerritoryDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionPricePointRelationshipsTerritoryDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPricePointType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionPricePointType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPricePointsGetInstanceFieldsSubscriptionPricePoint?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableSubscriptionPricePointsGetInstanceFieldsSubscriptionPricePoint2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPricePointsGetInstanceFieldsTerritorie?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableSubscriptionPricePointsGetInstanceFieldsTerritorie2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPricePointsGetInstanceIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableSubscriptionPricePointsGetInstanceIncludeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.TerritoryType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableTerritoryType2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionPricePointsGetInstanceFieldsSubscriptionPricePoint>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_F75618A3E3760196(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionPricePointsGetInstanceFieldsTerritorie>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_0D9C26A447D59491(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionPricePointsGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_CAB637E325BD6B4F(options);
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