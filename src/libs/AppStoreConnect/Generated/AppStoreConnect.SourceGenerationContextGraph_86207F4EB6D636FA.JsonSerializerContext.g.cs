
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_86207F4EB6D636FA : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_86207F4EB6D636FA Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_86207F4EB6D636FA(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem173JsonConverter());
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

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceRelationshipsTerritoryDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceRelationshipsTerritoryDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceRelationshipsSubscriptionPricePointDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceRelationshipsSubscriptionPricePointDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPricesResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPricesResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.TerritoryType)

                    || typeToConvert == typeof(global::AppStoreConnect.TerritoryType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOffersPricesGetToManyRelatedFieldsSubscriptionPromotionalOfferPrice)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOffersPricesGetToManyRelatedFieldsSubscriptionPromotionalOfferPrice?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOffersPricesGetToManyRelatedFieldsTerritorie)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOffersPricesGetToManyRelatedFieldsTerritorie?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOffersPricesGetToManyRelatedFieldsSubscriptionPricePoint)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOffersPricesGetToManyRelatedFieldsSubscriptionPricePoint?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOffersPricesGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOffersPricesGetToManyRelatedIncludeItem?);
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

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPromotionalOfferPriceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPromotionalOfferPriceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceRelationshipsTerritoryDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPromotionalOfferPriceRelationshipsTerritoryDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceRelationshipsTerritoryDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPromotionalOfferPriceRelationshipsTerritoryDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceRelationshipsSubscriptionPricePointDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPromotionalOfferPriceRelationshipsSubscriptionPricePointDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceRelationshipsSubscriptionPricePointDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPromotionalOfferPriceRelationshipsSubscriptionPricePointDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPricesResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPromotionalOfferPricesResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPricesResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPromotionalOfferPricesResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.TerritoryType))
                {
                    return new global::AppStoreConnect.JsonConverters.TerritoryTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.TerritoryType?))
                {
                    return new global::AppStoreConnect.JsonConverters.TerritoryTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOffersPricesGetToManyRelatedFieldsSubscriptionPromotionalOfferPrice))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPromotionalOffersPricesGetToManyRelatedFieldsSubscriptionPromotionalOfferPriceJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOffersPricesGetToManyRelatedFieldsSubscriptionPromotionalOfferPrice?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPromotionalOffersPricesGetToManyRelatedFieldsSubscriptionPromotionalOfferPriceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOffersPricesGetToManyRelatedFieldsTerritorie))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPromotionalOffersPricesGetToManyRelatedFieldsTerritorieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOffersPricesGetToManyRelatedFieldsTerritorie?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPromotionalOffersPricesGetToManyRelatedFieldsTerritorieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOffersPricesGetToManyRelatedFieldsSubscriptionPricePoint))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPromotionalOffersPricesGetToManyRelatedFieldsSubscriptionPricePointJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOffersPricesGetToManyRelatedFieldsSubscriptionPricePoint?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPromotionalOffersPricesGetToManyRelatedFieldsSubscriptionPricePointNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOffersPricesGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPromotionalOffersPricesGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPromotionalOffersPricesGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPromotionalOffersPricesGetToManyRelatedIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.IncludedItem173))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_IncludedItem1732(options);
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
                if (type == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPrice))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionPromotionalOfferPrice(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionPromotionalOfferPriceRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceRelationshipsSubscriptionPricePoint))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionPromotionalOfferPriceRelationshipsSubscriptionPricePoint(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceRelationshipsSubscriptionPricePointData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionPromotionalOfferPriceRelationshipsSubscriptionPricePointData(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceRelationshipsSubscriptionPricePointDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionPromotionalOfferPriceRelationshipsSubscriptionPricePointDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceRelationshipsTerritory))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionPromotionalOfferPriceRelationshipsTerritory(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceRelationshipsTerritoryData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionPromotionalOfferPriceRelationshipsTerritoryData(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceRelationshipsTerritoryDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionPromotionalOfferPriceRelationshipsTerritoryDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionPromotionalOfferPriceType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPricesResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionPromotionalOfferPricesResponse(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPricesResponseIncludedItemDiscriminator))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionPromotionalOfferPricesResponseIncludedItemDiscriminator(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPricesResponseIncludedItemDiscriminatorType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionPromotionalOfferPricesResponseIncludedItemDiscriminatorType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPromotionalOffersPricesGetToManyRelatedFieldsSubscriptionPricePoint))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SubscriptionPromotionalOffersPricesGetToManyRelatedFieldsSubscriptionPricePoint2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPromotionalOffersPricesGetToManyRelatedFieldsSubscriptionPromotionalOfferPrice))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SubscriptionPromotionalOffersPricesGetToManyRelatedFieldsSubscriptionPromotionalOfferPrice2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPromotionalOffersPricesGetToManyRelatedFieldsTerritorie))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SubscriptionPromotionalOffersPricesGetToManyRelatedFieldsTerritorie2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPromotionalOffersPricesGetToManyRelatedIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SubscriptionPromotionalOffersPricesGetToManyRelatedIncludeItem2(options);
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
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem173>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_FAEA02BE4985541E(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPromotionalOfferPrice>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_C06C83EE3A4C4A08(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPromotionalOffersPricesGetToManyRelatedFieldsSubscriptionPricePoint>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_1215154327C2753B(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPromotionalOffersPricesGetToManyRelatedFieldsSubscriptionPromotionalOfferPrice>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_3452C6356B99BEE9(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPromotionalOffersPricesGetToManyRelatedFieldsTerritorie>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_E84E57470616BEF2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPromotionalOffersPricesGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_C8F7DBAB4FF7DC50(options);
                }
                if (type == typeof(int))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(global::AppStoreConnect.IncludedItem173?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableIncludedItem1732(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPricePointRelationshipsTerritoryDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionPricePointRelationshipsTerritoryDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPricePointType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionPricePointType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceRelationshipsSubscriptionPricePointDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionPromotionalOfferPriceRelationshipsSubscriptionPricePointDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceRelationshipsTerritoryDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionPromotionalOfferPriceRelationshipsTerritoryDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPriceType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionPromotionalOfferPriceType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPricesResponseIncludedItemDiscriminatorType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionPromotionalOfferPricesResponseIncludedItemDiscriminatorType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPromotionalOffersPricesGetToManyRelatedFieldsSubscriptionPricePoint?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableSubscriptionPromotionalOffersPricesGetToManyRelatedFieldsSubscriptionPricePoint2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPromotionalOffersPricesGetToManyRelatedFieldsSubscriptionPromotionalOfferPrice?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableSubscriptionPromotionalOffersPricesGetToManyRelatedFieldsSubscriptionPromotionalOfferPrice2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPromotionalOffersPricesGetToManyRelatedFieldsTerritorie?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableSubscriptionPromotionalOffersPricesGetToManyRelatedFieldsTerritorie2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPromotionalOffersPricesGetToManyRelatedIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableSubscriptionPromotionalOffersPricesGetToManyRelatedIncludeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.TerritoryType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableTerritoryType2(options);
                }
                if (type == typeof(int?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem173>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_A9C7372D1B7D7FB7(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionPromotionalOfferPrice>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_B9B85A1FF68681B8(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionPromotionalOffersPricesGetToManyRelatedFieldsSubscriptionPricePoint>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_1026977B92471C1E(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionPromotionalOffersPricesGetToManyRelatedFieldsSubscriptionPromotionalOfferPrice>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_0E6154AAA1DF05C1(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionPromotionalOffersPricesGetToManyRelatedFieldsTerritorie>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_2D2D8708A61ADDB5(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionPromotionalOffersPricesGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_A8D8292CBBD0158E(options);
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