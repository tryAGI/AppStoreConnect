
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_60606611F4DBA1F1 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_60606611F4DBA1F1 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_60606611F4DBA1F1(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem181JsonConverter());
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

                    || typeToConvert == typeof(global::AppStoreConnect.WinBackOfferPriceType)

                    || typeToConvert == typeof(global::AppStoreConnect.WinBackOfferPriceType?)

                    || typeToConvert == typeof(global::AppStoreConnect.WinBackOfferPriceRelationshipsTerritoryDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.WinBackOfferPriceRelationshipsTerritoryDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.WinBackOfferPriceRelationshipsSubscriptionPricePointDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.WinBackOfferPriceRelationshipsSubscriptionPricePointDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.WinBackOfferPricesResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.WinBackOfferPricesResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.WinBackOffersPricesGetToManyRelatedFieldsWinBackOfferPrice)

                    || typeToConvert == typeof(global::AppStoreConnect.WinBackOffersPricesGetToManyRelatedFieldsWinBackOfferPrice?)

                    || typeToConvert == typeof(global::AppStoreConnect.WinBackOffersPricesGetToManyRelatedFieldsTerritorie)

                    || typeToConvert == typeof(global::AppStoreConnect.WinBackOffersPricesGetToManyRelatedFieldsTerritorie?)

                    || typeToConvert == typeof(global::AppStoreConnect.WinBackOffersPricesGetToManyRelatedFieldsSubscriptionPricePoint)

                    || typeToConvert == typeof(global::AppStoreConnect.WinBackOffersPricesGetToManyRelatedFieldsSubscriptionPricePoint?)

                    || typeToConvert == typeof(global::AppStoreConnect.WinBackOffersPricesGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.WinBackOffersPricesGetToManyRelatedIncludeItem?);
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

                if (typeToConvert == typeof(global::AppStoreConnect.WinBackOfferPriceType))
                {
                    return new global::AppStoreConnect.JsonConverters.WinBackOfferPriceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.WinBackOfferPriceType?))
                {
                    return new global::AppStoreConnect.JsonConverters.WinBackOfferPriceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.WinBackOfferPriceRelationshipsTerritoryDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.WinBackOfferPriceRelationshipsTerritoryDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.WinBackOfferPriceRelationshipsTerritoryDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.WinBackOfferPriceRelationshipsTerritoryDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.WinBackOfferPriceRelationshipsSubscriptionPricePointDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.WinBackOfferPriceRelationshipsSubscriptionPricePointDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.WinBackOfferPriceRelationshipsSubscriptionPricePointDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.WinBackOfferPriceRelationshipsSubscriptionPricePointDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.WinBackOfferPricesResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.WinBackOfferPricesResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.WinBackOfferPricesResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.WinBackOfferPricesResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.WinBackOffersPricesGetToManyRelatedFieldsWinBackOfferPrice))
                {
                    return new global::AppStoreConnect.JsonConverters.WinBackOffersPricesGetToManyRelatedFieldsWinBackOfferPriceJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.WinBackOffersPricesGetToManyRelatedFieldsWinBackOfferPrice?))
                {
                    return new global::AppStoreConnect.JsonConverters.WinBackOffersPricesGetToManyRelatedFieldsWinBackOfferPriceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.WinBackOffersPricesGetToManyRelatedFieldsTerritorie))
                {
                    return new global::AppStoreConnect.JsonConverters.WinBackOffersPricesGetToManyRelatedFieldsTerritorieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.WinBackOffersPricesGetToManyRelatedFieldsTerritorie?))
                {
                    return new global::AppStoreConnect.JsonConverters.WinBackOffersPricesGetToManyRelatedFieldsTerritorieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.WinBackOffersPricesGetToManyRelatedFieldsSubscriptionPricePoint))
                {
                    return new global::AppStoreConnect.JsonConverters.WinBackOffersPricesGetToManyRelatedFieldsSubscriptionPricePointJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.WinBackOffersPricesGetToManyRelatedFieldsSubscriptionPricePoint?))
                {
                    return new global::AppStoreConnect.JsonConverters.WinBackOffersPricesGetToManyRelatedFieldsSubscriptionPricePointNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.WinBackOffersPricesGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.WinBackOffersPricesGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.WinBackOffersPricesGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.WinBackOffersPricesGetToManyRelatedIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.IncludedItem181))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_IncludedItem1812(options);
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
                if (type == typeof(global::AppStoreConnect.SubscriptionPricePointType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionPricePointType2(options);
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
                if (type == typeof(global::AppStoreConnect.WinBackOfferPrice))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_WinBackOfferPrice(options);
                }
                if (type == typeof(global::AppStoreConnect.WinBackOfferPriceRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_WinBackOfferPriceRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.WinBackOfferPriceRelationshipsSubscriptionPricePoint))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_WinBackOfferPriceRelationshipsSubscriptionPricePoint(options);
                }
                if (type == typeof(global::AppStoreConnect.WinBackOfferPriceRelationshipsSubscriptionPricePointData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_WinBackOfferPriceRelationshipsSubscriptionPricePointData(options);
                }
                if (type == typeof(global::AppStoreConnect.WinBackOfferPriceRelationshipsSubscriptionPricePointDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_WinBackOfferPriceRelationshipsSubscriptionPricePointDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.WinBackOfferPriceRelationshipsTerritory))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_WinBackOfferPriceRelationshipsTerritory(options);
                }
                if (type == typeof(global::AppStoreConnect.WinBackOfferPriceRelationshipsTerritoryData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_WinBackOfferPriceRelationshipsTerritoryData(options);
                }
                if (type == typeof(global::AppStoreConnect.WinBackOfferPriceRelationshipsTerritoryDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_WinBackOfferPriceRelationshipsTerritoryDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.WinBackOfferPriceType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_WinBackOfferPriceType2(options);
                }
                if (type == typeof(global::AppStoreConnect.WinBackOfferPricesResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_WinBackOfferPricesResponse(options);
                }
                if (type == typeof(global::AppStoreConnect.WinBackOfferPricesResponseIncludedItemDiscriminator))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_WinBackOfferPricesResponseIncludedItemDiscriminator(options);
                }
                if (type == typeof(global::AppStoreConnect.WinBackOfferPricesResponseIncludedItemDiscriminatorType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_WinBackOfferPricesResponseIncludedItemDiscriminatorType2(options);
                }
                if (type == typeof(global::AppStoreConnect.WinBackOffersPricesGetToManyRelatedFieldsSubscriptionPricePoint))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_WinBackOffersPricesGetToManyRelatedFieldsSubscriptionPricePoint2(options);
                }
                if (type == typeof(global::AppStoreConnect.WinBackOffersPricesGetToManyRelatedFieldsTerritorie))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_WinBackOffersPricesGetToManyRelatedFieldsTerritorie2(options);
                }
                if (type == typeof(global::AppStoreConnect.WinBackOffersPricesGetToManyRelatedFieldsWinBackOfferPrice))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_WinBackOffersPricesGetToManyRelatedFieldsWinBackOfferPrice2(options);
                }
                if (type == typeof(global::AppStoreConnect.WinBackOffersPricesGetToManyRelatedIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_WinBackOffersPricesGetToManyRelatedIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem181>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_17FDEAAC6F0A3F28(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.WinBackOfferPrice>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_33BA43D524E823EA(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.WinBackOffersPricesGetToManyRelatedFieldsSubscriptionPricePoint>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_875B67972A42BC2C(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.WinBackOffersPricesGetToManyRelatedFieldsTerritorie>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_9B60A7C90390AFC2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.WinBackOffersPricesGetToManyRelatedFieldsWinBackOfferPrice>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_FBDAEF50AE54D1D8(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.WinBackOffersPricesGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_FF6B67C68CF6A236(options);
                }
                if (type == typeof(int))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(global::AppStoreConnect.IncludedItem181?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableIncludedItem1812(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPricePointRelationshipsTerritoryDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionPricePointRelationshipsTerritoryDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPricePointType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionPricePointType2(options);
                }
                if (type == typeof(global::AppStoreConnect.TerritoryType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableTerritoryType2(options);
                }
                if (type == typeof(global::AppStoreConnect.WinBackOfferPriceRelationshipsSubscriptionPricePointDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableWinBackOfferPriceRelationshipsSubscriptionPricePointDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.WinBackOfferPriceRelationshipsTerritoryDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableWinBackOfferPriceRelationshipsTerritoryDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.WinBackOfferPriceType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableWinBackOfferPriceType2(options);
                }
                if (type == typeof(global::AppStoreConnect.WinBackOfferPricesResponseIncludedItemDiscriminatorType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableWinBackOfferPricesResponseIncludedItemDiscriminatorType2(options);
                }
                if (type == typeof(global::AppStoreConnect.WinBackOffersPricesGetToManyRelatedFieldsSubscriptionPricePoint?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableWinBackOffersPricesGetToManyRelatedFieldsSubscriptionPricePoint2(options);
                }
                if (type == typeof(global::AppStoreConnect.WinBackOffersPricesGetToManyRelatedFieldsTerritorie?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableWinBackOffersPricesGetToManyRelatedFieldsTerritorie2(options);
                }
                if (type == typeof(global::AppStoreConnect.WinBackOffersPricesGetToManyRelatedFieldsWinBackOfferPrice?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableWinBackOffersPricesGetToManyRelatedFieldsWinBackOfferPrice2(options);
                }
                if (type == typeof(global::AppStoreConnect.WinBackOffersPricesGetToManyRelatedIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableWinBackOffersPricesGetToManyRelatedIncludeItem2(options);
                }
                if (type == typeof(int?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem181>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_2D7052AFEBCBB23C(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.WinBackOfferPrice>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_F45C1043424D84E1(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.WinBackOffersPricesGetToManyRelatedFieldsSubscriptionPricePoint>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_1598C35977622BA2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.WinBackOffersPricesGetToManyRelatedFieldsTerritorie>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_EFB61E6C4F6D86D3(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.WinBackOffersPricesGetToManyRelatedFieldsWinBackOfferPrice>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_70E81E3460DC4E07(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.WinBackOffersPricesGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_4AFB8B920FB96E33(options);
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