
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_F3E933F386B86A80 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_F3E933F386B86A80 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_F3E933F386B86A80(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.WinBackOfferPriceType)

                    || typeToConvert == typeof(global::AppStoreConnect.WinBackOfferPriceType?)

                    || typeToConvert == typeof(global::AppStoreConnect.WinBackOfferPriceRelationshipsTerritoryDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.WinBackOfferPriceRelationshipsTerritoryDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.WinBackOfferPriceRelationshipsSubscriptionPricePointDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.WinBackOfferPriceRelationshipsSubscriptionPricePointDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.WinBackOfferType)

                    || typeToConvert == typeof(global::AppStoreConnect.WinBackOfferType?)

                    || typeToConvert == typeof(global::AppStoreConnect.WinBackOfferAttributesPriority)

                    || typeToConvert == typeof(global::AppStoreConnect.WinBackOfferAttributesPriority?)

                    || typeToConvert == typeof(global::AppStoreConnect.WinBackOfferAttributesPromotionIntent)

                    || typeToConvert == typeof(global::AppStoreConnect.WinBackOfferAttributesPromotionIntent?)

                    || typeToConvert == typeof(global::AppStoreConnect.WinBackOfferRelationshipsPricesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.WinBackOfferRelationshipsPricesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferDuration)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferDuration?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferMode)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferMode?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPlanType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPlanType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOffer)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOffer?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOfferPrice)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOfferPrice?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsWinBackOffersGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsWinBackOffersGetToManyRelatedIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
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

                if (typeToConvert == typeof(global::AppStoreConnect.WinBackOfferType))
                {
                    return new global::AppStoreConnect.JsonConverters.WinBackOfferTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.WinBackOfferType?))
                {
                    return new global::AppStoreConnect.JsonConverters.WinBackOfferTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.WinBackOfferAttributesPriority))
                {
                    return new global::AppStoreConnect.JsonConverters.WinBackOfferAttributesPriorityJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.WinBackOfferAttributesPriority?))
                {
                    return new global::AppStoreConnect.JsonConverters.WinBackOfferAttributesPriorityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.WinBackOfferAttributesPromotionIntent))
                {
                    return new global::AppStoreConnect.JsonConverters.WinBackOfferAttributesPromotionIntentJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.WinBackOfferAttributesPromotionIntent?))
                {
                    return new global::AppStoreConnect.JsonConverters.WinBackOfferAttributesPromotionIntentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.WinBackOfferRelationshipsPricesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.WinBackOfferRelationshipsPricesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.WinBackOfferRelationshipsPricesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.WinBackOfferRelationshipsPricesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferDuration))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferDurationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferDuration?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferDurationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferMode))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferModeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferMode?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPlanType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPlanTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionPlanType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionPlanTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOffer))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOfferJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOffer?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOfferNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOfferPrice))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOfferPriceJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOfferPrice?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOfferPriceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsWinBackOffersGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsWinBackOffersGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsWinBackOffersGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsWinBackOffersGetToManyRelatedIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.IntegerRange))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_IntegerRange(options);
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
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferDuration))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionOfferDuration2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferMode))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionOfferMode2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPlanType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionPlanType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOffer))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOffer2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOfferPrice))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOfferPrice2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsWinBackOffersGetToManyRelatedIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SubscriptionsWinBackOffersGetToManyRelatedIncludeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.WinBackOffer))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_WinBackOffer(options);
                }
                if (type == typeof(global::AppStoreConnect.WinBackOfferAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_WinBackOfferAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.WinBackOfferAttributesPriority))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_WinBackOfferAttributesPriority2(options);
                }
                if (type == typeof(global::AppStoreConnect.WinBackOfferAttributesPromotionIntent))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_WinBackOfferAttributesPromotionIntent2(options);
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
                if (type == typeof(global::AppStoreConnect.WinBackOfferRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_WinBackOfferRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.WinBackOfferRelationshipsPrices))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_WinBackOfferRelationshipsPrices(options);
                }
                if (type == typeof(global::AppStoreConnect.WinBackOfferRelationshipsPricesDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_WinBackOfferRelationshipsPricesDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.WinBackOfferRelationshipsPricesDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_WinBackOfferRelationshipsPricesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.WinBackOfferType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_WinBackOfferType2(options);
                }
                if (type == typeof(global::AppStoreConnect.WinBackOffersResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_WinBackOffersResponse(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOffer>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_92306F31B823D007(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOfferPrice>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_2F95C9471AFFE4ED(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsWinBackOffersGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_444D0991C6FD00EB(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.WinBackOffer>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_59CF9891CB72D3BD(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.WinBackOfferPrice>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_33BA43D524E823EA(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.WinBackOfferRelationshipsPricesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_31AC0511C4F71890(options);
                }
                if (type == typeof(global::System.DateTime))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_DateTime(options);
                }
                if (type == typeof(int))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferDuration?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionOfferDuration2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferMode?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionOfferMode2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPlanType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionPlanType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOffer?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableSubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOffer2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOfferPrice?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableSubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOfferPrice2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsWinBackOffersGetToManyRelatedIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableSubscriptionsWinBackOffersGetToManyRelatedIncludeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.WinBackOfferAttributesPriority?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableWinBackOfferAttributesPriority2(options);
                }
                if (type == typeof(global::AppStoreConnect.WinBackOfferAttributesPromotionIntent?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableWinBackOfferAttributesPromotionIntent2(options);
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
                if (type == typeof(global::AppStoreConnect.WinBackOfferRelationshipsPricesDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableWinBackOfferRelationshipsPricesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.WinBackOfferType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableWinBackOfferType2(options);
                }
                if (type == typeof(global::System.DateTime?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableDateTime(options);
                }
                if (type == typeof(int?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOffer>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_A434EF966BCAC128(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOfferPrice>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_2AF4F98A11634925(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsWinBackOffersGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_E25BCEE638EFC999(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.WinBackOffer>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_0AE32625A937F40D(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.WinBackOfferPrice>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_F45C1043424D84E1(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.WinBackOfferRelationshipsPricesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_EC88173463B67F54(options);
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