
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_BB415F796A7DAB53 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_BB415F796A7DAB53 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_BB415F796A7DAB53(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem166JsonConverter());
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
                    typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferRelationshipsSubscriptionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferRelationshipsSubscriptionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferRelationshipsTerritoryDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferRelationshipsTerritoryDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferRelationshipsSubscriptionPricePointDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferRelationshipsSubscriptionPricePointDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOffersResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOffersResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPricePointType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPricePointType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPricePointRelationshipsTerritoryDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPricePointRelationshipsTerritoryDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionAttributesState)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionAttributesState?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionAttributesSubscriptionPeriod)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionAttributesSubscriptionPeriod?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionAttributesMultiSeatStatus)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionAttributesMultiSeatStatus?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionAttributesMarketSetting)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionAttributesMarketSetting?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsSubscriptionLocalizationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsSubscriptionLocalizationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsAppStoreReviewScreenshotDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsAppStoreReviewScreenshotDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsGroupDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsGroupDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsIntroductoryOffersDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsIntroductoryOffersDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsPromotionalOffersDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsPromotionalOffersDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsOfferCodesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsOfferCodesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsPricesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsPricesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsPromotedPurchaseDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsPromotedPurchaseDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsSubscriptionAvailabilityDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsSubscriptionAvailabilityDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsWinBackOffersDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsWinBackOffersDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsImagesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsImagesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsPlanAvailabilitiesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsPlanAvailabilitiesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsVersionsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsVersionsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.TerritoryType)

                    || typeToConvert == typeof(global::AppStoreConnect.TerritoryType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferDuration)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferDuration?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferMode)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferMode?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPlanType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPlanType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionIntroductoryOffer)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionIntroductoryOffer?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscription)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscription?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsTerritorie)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsTerritorie?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionPricePoint)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionPricePoint?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionIntroductoryOfferTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionIntroductoryOfferTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferRelationshipsSubscriptionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionIntroductoryOfferRelationshipsSubscriptionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferRelationshipsSubscriptionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionIntroductoryOfferRelationshipsSubscriptionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferRelationshipsTerritoryDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionIntroductoryOfferRelationshipsTerritoryDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferRelationshipsTerritoryDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionIntroductoryOfferRelationshipsTerritoryDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferRelationshipsSubscriptionPricePointDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionIntroductoryOfferRelationshipsSubscriptionPricePointDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferRelationshipsSubscriptionPricePointDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionIntroductoryOfferRelationshipsSubscriptionPricePointDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOffersResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionIntroductoryOffersResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionIntroductoryOffersResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionIntroductoryOffersResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

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

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionAttributesState))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionAttributesStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionAttributesState?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionAttributesStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionAttributesSubscriptionPeriod))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionAttributesSubscriptionPeriodJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionAttributesSubscriptionPeriod?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionAttributesSubscriptionPeriodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionAttributesMultiSeatStatus))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionAttributesMultiSeatStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionAttributesMultiSeatStatus?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionAttributesMultiSeatStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionAttributesMarketSetting))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionAttributesMarketSettingJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionAttributesMarketSetting?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionAttributesMarketSettingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsSubscriptionLocalizationsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionRelationshipsSubscriptionLocalizationsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsSubscriptionLocalizationsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionRelationshipsSubscriptionLocalizationsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsAppStoreReviewScreenshotDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionRelationshipsAppStoreReviewScreenshotDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsAppStoreReviewScreenshotDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionRelationshipsAppStoreReviewScreenshotDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsGroupDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionRelationshipsGroupDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsGroupDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionRelationshipsGroupDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsIntroductoryOffersDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionRelationshipsIntroductoryOffersDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsIntroductoryOffersDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionRelationshipsIntroductoryOffersDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsPromotionalOffersDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionRelationshipsPromotionalOffersDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsPromotionalOffersDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionRelationshipsPromotionalOffersDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsOfferCodesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionRelationshipsOfferCodesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsOfferCodesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionRelationshipsOfferCodesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsPricesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionRelationshipsPricesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsPricesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionRelationshipsPricesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsPromotedPurchaseDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionRelationshipsPromotedPurchaseDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsPromotedPurchaseDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionRelationshipsPromotedPurchaseDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsSubscriptionAvailabilityDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionRelationshipsSubscriptionAvailabilityDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsSubscriptionAvailabilityDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionRelationshipsSubscriptionAvailabilityDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsWinBackOffersDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionRelationshipsWinBackOffersDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsWinBackOffersDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionRelationshipsWinBackOffersDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsImagesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionRelationshipsImagesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsImagesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionRelationshipsImagesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsPlanAvailabilitiesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionRelationshipsPlanAvailabilitiesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsPlanAvailabilitiesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionRelationshipsPlanAvailabilitiesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsVersionsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionRelationshipsVersionsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsVersionsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionRelationshipsVersionsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.TerritoryType))
                {
                    return new global::AppStoreConnect.JsonConverters.TerritoryTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.TerritoryType?))
                {
                    return new global::AppStoreConnect.JsonConverters.TerritoryTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionIntroductoryOffer))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionIntroductoryOfferJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionIntroductoryOffer?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionIntroductoryOfferNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscription))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscription?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsTerritorie))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsTerritorieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsTerritorie?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsTerritorieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionPricePoint))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionPricePointJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionPricePoint?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionPricePointNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsIntroductoryOffersGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsIntroductoryOffersGetToManyRelatedIncludeItemNullableJsonConverter();
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
                if (type == typeof(bool))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Boolean(options);
                }
                if (type == typeof(global::AppStoreConnect.IncludedItem166))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_IncludedItem1662(options);
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
                if (type == typeof(global::AppStoreConnect.Subscription))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_Subscription(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionAttributesMarketSetting))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionAttributesMarketSetting2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionAttributesMultiSeatStatus))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionAttributesMultiSeatStatus2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionAttributesState))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionAttributesState2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionAttributesSubscriptionPeriod))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionAttributesSubscriptionPeriod2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionIntroductoryOffer))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionIntroductoryOffer(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionIntroductoryOfferAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionIntroductoryOfferRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferRelationshipsSubscription))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionIntroductoryOfferRelationshipsSubscription(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferRelationshipsSubscriptionData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionIntroductoryOfferRelationshipsSubscriptionData(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferRelationshipsSubscriptionDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionIntroductoryOfferRelationshipsSubscriptionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferRelationshipsSubscriptionPricePoint))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionIntroductoryOfferRelationshipsSubscriptionPricePoint(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferRelationshipsSubscriptionPricePointData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionIntroductoryOfferRelationshipsSubscriptionPricePointData(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferRelationshipsSubscriptionPricePointDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionIntroductoryOfferRelationshipsSubscriptionPricePointDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferRelationshipsTerritory))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionIntroductoryOfferRelationshipsTerritory(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferRelationshipsTerritoryData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionIntroductoryOfferRelationshipsTerritoryData(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferRelationshipsTerritoryDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionIntroductoryOfferRelationshipsTerritoryDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionIntroductoryOfferType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionIntroductoryOffersResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionIntroductoryOffersResponse(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionIntroductoryOffersResponseIncludedItemDiscriminator))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionIntroductoryOffersResponseIncludedItemDiscriminator(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionIntroductoryOffersResponseIncludedItemDiscriminatorType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionIntroductoryOffersResponseIncludedItemDiscriminatorType2(options);
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
                if (type == typeof(global::AppStoreConnect.SubscriptionRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionRelationshipsAppStoreReviewScreenshot))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionRelationshipsAppStoreReviewScreenshot(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionRelationshipsAppStoreReviewScreenshotData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionRelationshipsAppStoreReviewScreenshotData(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionRelationshipsAppStoreReviewScreenshotDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionRelationshipsAppStoreReviewScreenshotDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionRelationshipsGroup))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionRelationshipsGroup(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionRelationshipsGroupData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionRelationshipsGroupData(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionRelationshipsGroupDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionRelationshipsGroupDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionRelationshipsImages))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionRelationshipsImages(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionRelationshipsImagesDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionRelationshipsImagesDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionRelationshipsImagesDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionRelationshipsImagesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionRelationshipsIntroductoryOffers))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionRelationshipsIntroductoryOffers(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionRelationshipsIntroductoryOffersDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionRelationshipsIntroductoryOffersDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionRelationshipsIntroductoryOffersDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionRelationshipsIntroductoryOffersDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionRelationshipsOfferCodes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionRelationshipsOfferCodes(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionRelationshipsOfferCodesDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionRelationshipsOfferCodesDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionRelationshipsOfferCodesDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionRelationshipsOfferCodesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionRelationshipsPlanAvailabilities))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionRelationshipsPlanAvailabilities(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionRelationshipsPlanAvailabilitiesDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionRelationshipsPlanAvailabilitiesDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionRelationshipsPlanAvailabilitiesDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionRelationshipsPlanAvailabilitiesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionRelationshipsPricePoints))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionRelationshipsPricePoints(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionRelationshipsPrices))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionRelationshipsPrices(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionRelationshipsPricesDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionRelationshipsPricesDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionRelationshipsPricesDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionRelationshipsPricesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionRelationshipsPromotedPurchase))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionRelationshipsPromotedPurchase(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionRelationshipsPromotedPurchaseData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionRelationshipsPromotedPurchaseData(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionRelationshipsPromotedPurchaseDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionRelationshipsPromotedPurchaseDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionRelationshipsPromotionalOffers))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionRelationshipsPromotionalOffers(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionRelationshipsPromotionalOffersDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionRelationshipsPromotionalOffersDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionRelationshipsPromotionalOffersDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionRelationshipsPromotionalOffersDataItemType2(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.SubscriptionRelationshipsSubscriptionAvailability))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionRelationshipsSubscriptionAvailability(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.SubscriptionRelationshipsSubscriptionAvailabilityData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionRelationshipsSubscriptionAvailabilityData(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.SubscriptionRelationshipsSubscriptionAvailabilityDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionRelationshipsSubscriptionAvailabilityDataType2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::AppStoreConnect.SubscriptionRelationshipsSubscriptionLocalizations))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionRelationshipsSubscriptionLocalizations(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionRelationshipsSubscriptionLocalizationsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionRelationshipsSubscriptionLocalizationsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionRelationshipsSubscriptionLocalizationsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionRelationshipsSubscriptionLocalizationsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionRelationshipsVersions))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionRelationshipsVersions(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionRelationshipsVersionsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionRelationshipsVersionsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionRelationshipsVersionsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionRelationshipsVersionsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionRelationshipsWinBackOffers))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionRelationshipsWinBackOffers(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionRelationshipsWinBackOffersDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionRelationshipsWinBackOffersDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionRelationshipsWinBackOffersDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionRelationshipsWinBackOffersDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscription))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscription2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionIntroductoryOffer))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionIntroductoryOffer2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionPricePoint))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionPricePoint2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsTerritorie))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SubscriptionsIntroductoryOffersGetToManyRelatedFieldsTerritorie2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SubscriptionsIntroductoryOffersGetToManyRelatedIncludeItem2(options);
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
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem166>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_19347AE87433B5FD(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionAttributesMarketSetting>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_82ED2ED835D976B5(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionIntroductoryOffer>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_7801B6C4BAC43B28(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionRelationshipsImagesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_96CCBB14B9356B94(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionRelationshipsIntroductoryOffersDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_232E5C71980EF7C3(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionRelationshipsOfferCodesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_3F340E3F80558F34(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionRelationshipsPlanAvailabilitiesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_B32EC0848ED5C9C3(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionRelationshipsPricesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_95D76F74B7758855(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionRelationshipsPromotionalOffersDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_D634F19C27546DD2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionRelationshipsSubscriptionLocalizationsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_3E191E1C1DA2247C(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionRelationshipsVersionsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_68E47F0FF29DB9B3(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionRelationshipsWinBackOffersDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_6150BFAB5AC17FDC(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscription>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_96AD6C32369B3C62(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionIntroductoryOffer>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_888D833CFF89A32C(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionPricePoint>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_76BDD270D9A3E4FE(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsTerritorie>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_BF029DA54EC17F63(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_F00F6E6CCDA1563A(options);
                }
                if (type == typeof(global::System.DateTime))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_DateTime(options);
                }
                if (type == typeof(int))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(bool?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBoolean(options);
                }
                if (type == typeof(global::AppStoreConnect.IncludedItem166?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableIncludedItem1662(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionAttributesMarketSetting?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionAttributesMarketSetting2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionAttributesMultiSeatStatus?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionAttributesMultiSeatStatus2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionAttributesState?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionAttributesState2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionAttributesSubscriptionPeriod?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionAttributesSubscriptionPeriod2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferRelationshipsSubscriptionDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionIntroductoryOfferRelationshipsSubscriptionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferRelationshipsSubscriptionPricePointDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionIntroductoryOfferRelationshipsSubscriptionPricePointDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferRelationshipsTerritoryDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionIntroductoryOfferRelationshipsTerritoryDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionIntroductoryOfferType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionIntroductoryOfferType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionIntroductoryOffersResponseIncludedItemDiscriminatorType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionIntroductoryOffersResponseIncludedItemDiscriminatorType2(options);
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
                if (type == typeof(global::AppStoreConnect.SubscriptionPricePointRelationshipsTerritoryDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionPricePointRelationshipsTerritoryDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPricePointType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionPricePointType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionRelationshipsAppStoreReviewScreenshotDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionRelationshipsAppStoreReviewScreenshotDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionRelationshipsGroupDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionRelationshipsGroupDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionRelationshipsImagesDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionRelationshipsImagesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionRelationshipsIntroductoryOffersDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionRelationshipsIntroductoryOffersDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionRelationshipsOfferCodesDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionRelationshipsOfferCodesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionRelationshipsPlanAvailabilitiesDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionRelationshipsPlanAvailabilitiesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionRelationshipsPricesDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionRelationshipsPricesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionRelationshipsPromotedPurchaseDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionRelationshipsPromotedPurchaseDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionRelationshipsPromotionalOffersDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionRelationshipsPromotionalOffersDataItemType2(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.SubscriptionRelationshipsSubscriptionAvailabilityDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionRelationshipsSubscriptionAvailabilityDataType2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::AppStoreConnect.SubscriptionRelationshipsSubscriptionLocalizationsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionRelationshipsSubscriptionLocalizationsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionRelationshipsVersionsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionRelationshipsVersionsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionRelationshipsWinBackOffersDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionRelationshipsWinBackOffersDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscription?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableSubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscription2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionIntroductoryOffer?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableSubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionIntroductoryOffer2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionPricePoint?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableSubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionPricePoint2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsTerritorie?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableSubscriptionsIntroductoryOffersGetToManyRelatedFieldsTerritorie2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableSubscriptionsIntroductoryOffersGetToManyRelatedIncludeItem2(options);
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
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem166>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_E7B217D916B2D425(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionAttributesMarketSetting>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_20A07BEE5D3D360C(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionIntroductoryOffer>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_C765811E46902C91(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionRelationshipsImagesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_744568852F472C72(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionRelationshipsIntroductoryOffersDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_30A433270171DDBA(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionRelationshipsOfferCodesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_167D9E5F26141ACD(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionRelationshipsPlanAvailabilitiesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_3F74C7A9090E174A(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionRelationshipsPricesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_4A062EAFE7016653(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionRelationshipsPromotionalOffersDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_6E9A49F48E0216AB(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionRelationshipsSubscriptionLocalizationsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_16726BB7D21742DB(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionRelationshipsVersionsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_F0F6F711D941286C(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionRelationshipsWinBackOffersDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_8C7060672B45656A(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscription>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_AA489ACFA5E175F5(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionIntroductoryOffer>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_376C0DA16C2070DD(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionPricePoint>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_A50FCE7F805CB24F(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedFieldsTerritorie>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_38FA2037D711C1D8(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsIntroductoryOffersGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_2C3363A578F0EF28(options);
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