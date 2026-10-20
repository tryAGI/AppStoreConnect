
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_72925F76BE6EB50F : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_72925F76BE6EB50F Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_72925F76BE6EB50F(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem169JsonConverter());
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
                    typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeCustomCodeType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeCustomCodeType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeCustomCodeRelationshipsOfferCodeDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeCustomCodeRelationshipsOfferCodeDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCodeType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCodeType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCodeRelationshipsOfferCodeDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCodeRelationshipsOfferCodeDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodePriceType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodePriceType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodePriceRelationshipsTerritoryDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodePriceRelationshipsTerritoryDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodePriceRelationshipsSubscriptionPricePointDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodePriceRelationshipsSubscriptionPricePointDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsSubscriptionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsSubscriptionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsOneTimeUseCodesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsOneTimeUseCodesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsCustomCodesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsCustomCodesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsPricesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsPricesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodesResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodesResponseIncludedItemDiscriminatorType?)

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

                    || typeToConvert == typeof(global::AppStoreConnect.OfferCodeEnvironment)

                    || typeToConvert == typeof(global::AppStoreConnect.OfferCodeEnvironment?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionCustomerEligibility)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionCustomerEligibility?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferDuration)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferDuration?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferEligibility)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferEligibility?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferMode)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferMode?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPlanType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionPlanType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCode)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCode?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscription)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscription?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeOneTimeUseCode)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeOneTimeUseCode?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeCustomCode)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeCustomCode?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodePrice)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodePrice?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeCustomCodeType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferCodeCustomCodeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeCustomCodeType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferCodeCustomCodeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeCustomCodeRelationshipsOfferCodeDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferCodeCustomCodeRelationshipsOfferCodeDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeCustomCodeRelationshipsOfferCodeDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferCodeCustomCodeRelationshipsOfferCodeDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCodeType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferCodeOneTimeUseCodeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCodeType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferCodeOneTimeUseCodeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCodeRelationshipsOfferCodeDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferCodeOneTimeUseCodeRelationshipsOfferCodeDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCodeRelationshipsOfferCodeDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferCodeOneTimeUseCodeRelationshipsOfferCodeDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodePriceType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferCodePriceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodePriceType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferCodePriceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodePriceRelationshipsTerritoryDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferCodePriceRelationshipsTerritoryDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodePriceRelationshipsTerritoryDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferCodePriceRelationshipsTerritoryDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodePriceRelationshipsSubscriptionPricePointDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferCodePriceRelationshipsSubscriptionPricePointDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodePriceRelationshipsSubscriptionPricePointDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferCodePriceRelationshipsSubscriptionPricePointDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferCodeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferCodeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsSubscriptionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferCodeRelationshipsSubscriptionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsSubscriptionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferCodeRelationshipsSubscriptionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsOneTimeUseCodesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferCodeRelationshipsOneTimeUseCodesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsOneTimeUseCodesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferCodeRelationshipsOneTimeUseCodesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsCustomCodesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferCodeRelationshipsCustomCodesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsCustomCodesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferCodeRelationshipsCustomCodesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsPricesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferCodeRelationshipsPricesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsPricesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferCodeRelationshipsPricesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodesResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferCodesResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferCodesResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferCodesResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.OfferCodeEnvironment))
                {
                    return new global::AppStoreConnect.JsonConverters.OfferCodeEnvironmentJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.OfferCodeEnvironment?))
                {
                    return new global::AppStoreConnect.JsonConverters.OfferCodeEnvironmentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionCustomerEligibility))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionCustomerEligibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionCustomerEligibility?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionCustomerEligibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferDuration))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferDurationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferDuration?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferDurationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferEligibility))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferEligibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionOfferEligibility?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionOfferEligibilityNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCode))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCode?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscription))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscription?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeOneTimeUseCode))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeOneTimeUseCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeOneTimeUseCode?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeOneTimeUseCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeCustomCode))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeCustomCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeCustomCode?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeCustomCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodePrice))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodePriceJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodePrice?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodePriceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsOfferCodesGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsOfferCodesGetToManyRelatedIncludeItemNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }
        private sealed class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
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
                if (type == typeof(global::AppStoreConnect.IncludedItem169))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_IncludedItem1692(options);
                }
                if (type == typeof(global::AppStoreConnect.OfferCodeEnvironment))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_OfferCodeEnvironment2(options);
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
                if (type == typeof(global::AppStoreConnect.SubscriptionCustomerEligibility))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionCustomerEligibility2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCode))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionOfferCode(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCodeAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionOfferCodeAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCodeCustomCode))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionOfferCodeCustomCode(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCodeCustomCodeAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionOfferCodeCustomCodeAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCodeCustomCodeRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionOfferCodeCustomCodeRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCodeCustomCodeRelationshipsOfferCode))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionOfferCodeCustomCodeRelationshipsOfferCode(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCodeCustomCodeRelationshipsOfferCodeData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionOfferCodeCustomCodeRelationshipsOfferCodeData(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCodeCustomCodeRelationshipsOfferCodeDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionOfferCodeCustomCodeRelationshipsOfferCodeDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCodeCustomCodeType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionOfferCodeCustomCodeType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCode))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionOfferCodeOneTimeUseCode(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCodeAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionOfferCodeOneTimeUseCodeAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCodeRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionOfferCodeOneTimeUseCodeRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCodeRelationshipsOfferCode))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionOfferCodeOneTimeUseCodeRelationshipsOfferCode(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCodeRelationshipsOfferCodeData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionOfferCodeOneTimeUseCodeRelationshipsOfferCodeData(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCodeRelationshipsOfferCodeDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionOfferCodeOneTimeUseCodeRelationshipsOfferCodeDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCodeRelationshipsValues))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionOfferCodeOneTimeUseCodeRelationshipsValues(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCodeType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionOfferCodeOneTimeUseCodeType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCodePrice))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionOfferCodePrice(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCodePriceRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionOfferCodePriceRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCodePriceRelationshipsSubscriptionPricePoint))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionOfferCodePriceRelationshipsSubscriptionPricePoint(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCodePriceRelationshipsSubscriptionPricePointData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionOfferCodePriceRelationshipsSubscriptionPricePointData(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCodePriceRelationshipsSubscriptionPricePointDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionOfferCodePriceRelationshipsSubscriptionPricePointDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCodePriceRelationshipsTerritory))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionOfferCodePriceRelationshipsTerritory(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCodePriceRelationshipsTerritoryData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionOfferCodePriceRelationshipsTerritoryData(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCodePriceRelationshipsTerritoryDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionOfferCodePriceRelationshipsTerritoryDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCodePriceType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionOfferCodePriceType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionOfferCodeRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsCustomCodes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionOfferCodeRelationshipsCustomCodes(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsCustomCodesDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionOfferCodeRelationshipsCustomCodesDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsCustomCodesDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionOfferCodeRelationshipsCustomCodesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsOneTimeUseCodes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionOfferCodeRelationshipsOneTimeUseCodes(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsOneTimeUseCodesDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionOfferCodeRelationshipsOneTimeUseCodesDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsOneTimeUseCodesDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionOfferCodeRelationshipsOneTimeUseCodesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsPrices))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionOfferCodeRelationshipsPrices(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsPricesDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionOfferCodeRelationshipsPricesDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsPricesDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionOfferCodeRelationshipsPricesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsSubscription))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionOfferCodeRelationshipsSubscription(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsSubscriptionData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionOfferCodeRelationshipsSubscriptionData(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsSubscriptionDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionOfferCodeRelationshipsSubscriptionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCodeType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionOfferCodeType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCodesResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionOfferCodesResponse(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCodesResponseIncludedItemDiscriminator))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionOfferCodesResponseIncludedItemDiscriminator(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCodesResponseIncludedItemDiscriminatorType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionOfferCodesResponseIncludedItemDiscriminatorType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferDuration))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionOfferDuration2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferEligibility))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionOfferEligibility2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferMode))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionOfferMode2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPlanType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionPlanType2(options);
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
                if (type == typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscription))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SubscriptionsOfferCodesGetToManyRelatedFieldsSubscription2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCode))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCode2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeCustomCode))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeCustomCode2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeOneTimeUseCode))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeOneTimeUseCode2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodePrice))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodePrice2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SubscriptionsOfferCodesGetToManyRelatedIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem169>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_E1847F29FA1CC4DC(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionAttributesMarketSetting>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_82ED2ED835D976B5(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionCustomerEligibility>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_E4502A0795FAF346(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionOfferCode>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_EA83F0BD42881A73(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionOfferCodeRelationshipsCustomCodesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_98EE03EC34608F2B(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionOfferCodeRelationshipsOneTimeUseCodesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_D0CDF828FADF1503(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionOfferCodeRelationshipsPricesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_4A10EFCD329A1651(options);
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
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscription>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_4A54FDA7F30EB435(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCode>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_6C6C8386BE51500B(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeCustomCode>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_3120CA36DE38E87F(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeOneTimeUseCode>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_8919ADAABA8242A6(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodePrice>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_FA121934F1B09815(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_F49E6776E03D4B45(options);
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
                if (type == typeof(global::AppStoreConnect.IncludedItem169?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableIncludedItem1692(options);
                }
                if (type == typeof(global::AppStoreConnect.OfferCodeEnvironment?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableOfferCodeEnvironment2(options);
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
                if (type == typeof(global::AppStoreConnect.SubscriptionCustomerEligibility?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionCustomerEligibility2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCodeCustomCodeRelationshipsOfferCodeDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionOfferCodeCustomCodeRelationshipsOfferCodeDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCodeCustomCodeType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionOfferCodeCustomCodeType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCodeRelationshipsOfferCodeDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionOfferCodeOneTimeUseCodeRelationshipsOfferCodeDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCodeType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionOfferCodeOneTimeUseCodeType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCodePriceRelationshipsSubscriptionPricePointDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionOfferCodePriceRelationshipsSubscriptionPricePointDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCodePriceRelationshipsTerritoryDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionOfferCodePriceRelationshipsTerritoryDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCodePriceType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionOfferCodePriceType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsCustomCodesDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionOfferCodeRelationshipsCustomCodesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsOneTimeUseCodesDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionOfferCodeRelationshipsOneTimeUseCodesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsPricesDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionOfferCodeRelationshipsPricesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCodeRelationshipsSubscriptionDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionOfferCodeRelationshipsSubscriptionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCodeType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionOfferCodeType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferCodesResponseIncludedItemDiscriminatorType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionOfferCodesResponseIncludedItemDiscriminatorType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferDuration?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionOfferDuration2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferEligibility?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionOfferEligibility2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionOfferMode?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionOfferMode2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionPlanType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionPlanType2(options);
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
                if (type == typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscription?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableSubscriptionsOfferCodesGetToManyRelatedFieldsSubscription2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCode?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableSubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCode2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeCustomCode?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableSubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeCustomCode2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeOneTimeUseCode?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableSubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeOneTimeUseCode2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodePrice?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableSubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodePrice2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableSubscriptionsOfferCodesGetToManyRelatedIncludeItem2(options);
                }
                if (type == typeof(global::System.DateTime?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableDateTime(options);
                }
                if (type == typeof(int?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem169>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_C87FABDEF63364E5(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionAttributesMarketSetting>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_20A07BEE5D3D360C(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionCustomerEligibility>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_E759A79512ABD4B2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionOfferCode>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_559F3FBE80CE6647(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionOfferCodeRelationshipsCustomCodesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_F53DD1C85DD8BE13(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionOfferCodeRelationshipsOneTimeUseCodesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_6130257F0ADF4F11(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionOfferCodeRelationshipsPricesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_BB495D21D3D668A7(options);
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
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscription>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_BB1972E9FCE99807(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCode>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_251D1E6A0370D58C(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeCustomCode>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_4F6B4BDC094838DC(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeOneTimeUseCode>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_2172A56B98381D68(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodePrice>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_4926A46EF9DB0206(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_03C4BEE7877E88A0(options);
                }
                return null;
            }
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