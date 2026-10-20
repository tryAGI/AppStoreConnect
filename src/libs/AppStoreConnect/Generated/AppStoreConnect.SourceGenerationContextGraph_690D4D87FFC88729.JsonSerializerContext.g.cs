
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_690D4D87FFC88729 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_690D4D87FFC88729 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_690D4D87FFC88729(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem146JsonConverter());
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
                    typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseAppStoreReviewScreenshotType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseAppStoreReviewScreenshotType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseAppStoreReviewScreenshotRelationshipsInAppPurchaseV2DataType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseAppStoreReviewScreenshotRelationshipsInAppPurchaseV2DataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseAvailabilityType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseAvailabilityType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseAvailabilityRelationshipsAvailableTerritoriesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseAvailabilityRelationshipsAvailableTerritoriesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseContentType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseContentType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseContentRelationshipsInAppPurchaseV2DataType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseContentRelationshipsInAppPurchaseV2DataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseImageType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseImageType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseImageAttributesState)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseImageAttributesState?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseImageRelationshipsInAppPurchaseDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseImageRelationshipsInAppPurchaseDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseLocalizationType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseLocalizationType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseLocalizationAttributesState)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseLocalizationAttributesState?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseLocalizationRelationshipsInAppPurchaseV2DataType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseLocalizationRelationshipsInAppPurchaseV2DataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferCodeType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferCodeType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferCodeAttributesCustomerEligibilitie)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferCodeAttributesCustomerEligibilitie?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferCodeRelationshipsOneTimeUseCodesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferCodeRelationshipsOneTimeUseCodesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferCodeRelationshipsCustomCodesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferCodeRelationshipsCustomCodesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferCodeRelationshipsPricesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferCodeRelationshipsPricesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePricePointType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePricePointType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePricePointRelationshipsTerritoryDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePricePointRelationshipsTerritoryDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePriceScheduleType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePriceScheduleType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePriceScheduleRelationshipsBaseTerritoryDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePriceScheduleRelationshipsBaseTerritoryDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePriceScheduleRelationshipsManualPricesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePriceScheduleRelationshipsManualPricesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePriceScheduleRelationshipsAutomaticPricesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePriceScheduleRelationshipsAutomaticPricesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionAttributesState)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionAttributesState?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsInAppPurchaseDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsInAppPurchaseDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsImageDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsImageDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsImagesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsImagesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsLocalizationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsLocalizationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2Type)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2Type?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsInAppPurchaseLocalizationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsInAppPurchaseLocalizationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsPricePointsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsPricePointsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsContentDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsContentDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsAppStoreReviewScreenshotDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsAppStoreReviewScreenshotDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsPromotedPurchaseDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsPromotedPurchaseDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsIapPriceScheduleDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsIapPriceScheduleDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsInAppPurchaseAvailabilityDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsInAppPurchaseAvailabilityDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsImagesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsImagesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsOfferCodesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsOfferCodesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsVersionsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsVersionsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchasesV2ResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchasesV2ResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseType)

                    || typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseType?)

                    || typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseAttributesState)

                    || typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseAttributesState?)

                    || typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseRelationshipsInAppPurchaseV2DataType)

                    || typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseRelationshipsInAppPurchaseV2DataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseRelationshipsSubscriptionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseRelationshipsSubscriptionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState)

                    || typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseState)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseState?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseType2)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseType2?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFilterStateItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFilterStateItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFilterInAppPurchaseTypeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFilterInAppPurchaseTypeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedSortItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedSortItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchase)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchase?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseContent)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseContent?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseAppStoreReviewScreenshot)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseAppStoreReviewScreenshot?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsPromotedPurchase)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsPromotedPurchase?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchasePriceSchedule)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchasePriceSchedule?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseAvailabilitie)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseAvailabilitie?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseImage)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseImage?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseOfferCode)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseOfferCode?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseAppStoreReviewScreenshotType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseAppStoreReviewScreenshotTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseAppStoreReviewScreenshotType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseAppStoreReviewScreenshotTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseAppStoreReviewScreenshotRelationshipsInAppPurchaseV2DataType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseAppStoreReviewScreenshotRelationshipsInAppPurchaseV2DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseAppStoreReviewScreenshotRelationshipsInAppPurchaseV2DataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseAppStoreReviewScreenshotRelationshipsInAppPurchaseV2DataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseAvailabilityType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseAvailabilityTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseAvailabilityType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseAvailabilityTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseAvailabilityRelationshipsAvailableTerritoriesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseAvailabilityRelationshipsAvailableTerritoriesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseAvailabilityRelationshipsAvailableTerritoriesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseAvailabilityRelationshipsAvailableTerritoriesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseContentType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseContentType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseContentRelationshipsInAppPurchaseV2DataType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseContentRelationshipsInAppPurchaseV2DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseContentRelationshipsInAppPurchaseV2DataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseContentRelationshipsInAppPurchaseV2DataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseImageType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseImageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseImageType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseImageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseImageAttributesState))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseImageAttributesStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseImageAttributesState?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseImageAttributesStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseImageRelationshipsInAppPurchaseDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseImageRelationshipsInAppPurchaseDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseImageRelationshipsInAppPurchaseDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseImageRelationshipsInAppPurchaseDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseLocalizationType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseLocalizationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseLocalizationType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseLocalizationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseLocalizationAttributesState))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseLocalizationAttributesStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseLocalizationAttributesState?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseLocalizationAttributesStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseLocalizationRelationshipsInAppPurchaseV2DataType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseLocalizationRelationshipsInAppPurchaseV2DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseLocalizationRelationshipsInAppPurchaseV2DataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseLocalizationRelationshipsInAppPurchaseV2DataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferCodeType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseOfferCodeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferCodeType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseOfferCodeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferCodeAttributesCustomerEligibilitie))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseOfferCodeAttributesCustomerEligibilitieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferCodeAttributesCustomerEligibilitie?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseOfferCodeAttributesCustomerEligibilitieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferCodeRelationshipsOneTimeUseCodesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseOfferCodeRelationshipsOneTimeUseCodesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferCodeRelationshipsOneTimeUseCodesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseOfferCodeRelationshipsOneTimeUseCodesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferCodeRelationshipsCustomCodesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseOfferCodeRelationshipsCustomCodesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferCodeRelationshipsCustomCodesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseOfferCodeRelationshipsCustomCodesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferCodeRelationshipsPricesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseOfferCodeRelationshipsPricesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferCodeRelationshipsPricesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseOfferCodeRelationshipsPricesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePricePointType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchasePricePointTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePricePointType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchasePricePointTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePricePointRelationshipsTerritoryDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchasePricePointRelationshipsTerritoryDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePricePointRelationshipsTerritoryDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchasePricePointRelationshipsTerritoryDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePriceScheduleType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchasePriceScheduleTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePriceScheduleType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchasePriceScheduleTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePriceScheduleRelationshipsBaseTerritoryDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchasePriceScheduleRelationshipsBaseTerritoryDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePriceScheduleRelationshipsBaseTerritoryDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchasePriceScheduleRelationshipsBaseTerritoryDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePriceScheduleRelationshipsManualPricesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchasePriceScheduleRelationshipsManualPricesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePriceScheduleRelationshipsManualPricesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchasePriceScheduleRelationshipsManualPricesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePriceScheduleRelationshipsAutomaticPricesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchasePriceScheduleRelationshipsAutomaticPricesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchasePriceScheduleRelationshipsAutomaticPricesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchasePriceScheduleRelationshipsAutomaticPricesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseVersionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseVersionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionAttributesState))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseVersionAttributesStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionAttributesState?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseVersionAttributesStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsInAppPurchaseDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseVersionRelationshipsInAppPurchaseDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsInAppPurchaseDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseVersionRelationshipsInAppPurchaseDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsImageDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseVersionRelationshipsImageDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsImageDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseVersionRelationshipsImageDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsImagesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseVersionRelationshipsImagesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsImagesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseVersionRelationshipsImagesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsLocalizationsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseVersionRelationshipsLocalizationsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsLocalizationsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseVersionRelationshipsLocalizationsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2Type))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseV2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2Type?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseV2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsInAppPurchaseLocalizationsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseV2RelationshipsInAppPurchaseLocalizationsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsInAppPurchaseLocalizationsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseV2RelationshipsInAppPurchaseLocalizationsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsPricePointsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseV2RelationshipsPricePointsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsPricePointsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseV2RelationshipsPricePointsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsContentDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseV2RelationshipsContentDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsContentDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseV2RelationshipsContentDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsAppStoreReviewScreenshotDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseV2RelationshipsAppStoreReviewScreenshotDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsAppStoreReviewScreenshotDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseV2RelationshipsAppStoreReviewScreenshotDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsPromotedPurchaseDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseV2RelationshipsPromotedPurchaseDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsPromotedPurchaseDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseV2RelationshipsPromotedPurchaseDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsIapPriceScheduleDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseV2RelationshipsIapPriceScheduleDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsIapPriceScheduleDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseV2RelationshipsIapPriceScheduleDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsInAppPurchaseAvailabilityDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseV2RelationshipsInAppPurchaseAvailabilityDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsInAppPurchaseAvailabilityDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseV2RelationshipsInAppPurchaseAvailabilityDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsImagesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseV2RelationshipsImagesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsImagesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseV2RelationshipsImagesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsOfferCodesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseV2RelationshipsOfferCodesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsOfferCodesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseV2RelationshipsOfferCodesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsVersionsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseV2RelationshipsVersionsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsVersionsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseV2RelationshipsVersionsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchasesV2ResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchasesV2ResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchasesV2ResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchasesV2ResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseType))
                {
                    return new global::AppStoreConnect.JsonConverters.PromotedPurchaseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseType?))
                {
                    return new global::AppStoreConnect.JsonConverters.PromotedPurchaseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseAttributesState))
                {
                    return new global::AppStoreConnect.JsonConverters.PromotedPurchaseAttributesStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseAttributesState?))
                {
                    return new global::AppStoreConnect.JsonConverters.PromotedPurchaseAttributesStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseRelationshipsInAppPurchaseV2DataType))
                {
                    return new global::AppStoreConnect.JsonConverters.PromotedPurchaseRelationshipsInAppPurchaseV2DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseRelationshipsInAppPurchaseV2DataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.PromotedPurchaseRelationshipsInAppPurchaseV2DataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseRelationshipsSubscriptionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.PromotedPurchaseRelationshipsSubscriptionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseRelationshipsSubscriptionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.PromotedPurchaseRelationshipsSubscriptionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState))
                {
                    return new global::AppStoreConnect.JsonConverters.AppMediaAssetStateStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppMediaAssetStateStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseState))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseState?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseType2))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseType2JsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseType2?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFilterStateItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsInAppPurchasesV2GetToManyRelatedFilterStateItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFilterStateItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsInAppPurchasesV2GetToManyRelatedFilterStateItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFilterInAppPurchaseTypeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsInAppPurchasesV2GetToManyRelatedFilterInAppPurchaseTypeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFilterInAppPurchaseTypeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsInAppPurchasesV2GetToManyRelatedFilterInAppPurchaseTypeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedSortItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsInAppPurchasesV2GetToManyRelatedSortItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedSortItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsInAppPurchasesV2GetToManyRelatedSortItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchase))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchase?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseContent))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseContentJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseContent?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseContentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseAppStoreReviewScreenshot))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseAppStoreReviewScreenshotJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseAppStoreReviewScreenshot?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseAppStoreReviewScreenshotNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsPromotedPurchase))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsInAppPurchasesV2GetToManyRelatedFieldsPromotedPurchaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsPromotedPurchase?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsInAppPurchasesV2GetToManyRelatedFieldsPromotedPurchaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchasePriceSchedule))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchasePriceScheduleJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchasePriceSchedule?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchasePriceScheduleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseAvailabilitie))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseAvailabilitieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseAvailabilitie?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseAvailabilitieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseImage))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseImageJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseImage?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseImageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseOfferCode))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseOfferCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseOfferCode?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseOfferCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsInAppPurchasesV2GetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsInAppPurchasesV2GetToManyRelatedIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.AppMediaAssetState))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppMediaAssetState(options);
                }
                if (type == typeof(global::AppStoreConnect.AppMediaAssetStateState))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppMediaAssetStateState2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppMediaStateError))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppMediaStateError(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchase))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchase2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseAppStoreReviewScreenshot))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseAppStoreReviewScreenshot2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseAvailabilitie))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseAvailabilitie2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseContent))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseContent2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseImage))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseImage2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseOfferCode))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseOfferCode2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchasePriceSchedule))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchasePriceSchedule2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsPromotedPurchase))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsInAppPurchasesV2GetToManyRelatedFieldsPromotedPurchase2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFilterInAppPurchaseTypeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsInAppPurchasesV2GetToManyRelatedFilterInAppPurchaseTypeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFilterStateItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsInAppPurchasesV2GetToManyRelatedFilterStateItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsInAppPurchasesV2GetToManyRelatedIncludeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedSortItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsInAppPurchasesV2GetToManyRelatedSortItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.HttpHeader))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_HttpHeader(options);
                }
                if (type == typeof(global::AppStoreConnect.ImageAsset))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_ImageAsset(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseAppStoreReviewScreenshot))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseAppStoreReviewScreenshot(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseAppStoreReviewScreenshotAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseAppStoreReviewScreenshotAttributes(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseAppStoreReviewScreenshotRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseAppStoreReviewScreenshotRelationships(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseAppStoreReviewScreenshotRelationshipsInAppPurchaseV2))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseAppStoreReviewScreenshotRelationshipsInAppPurchaseV2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseAppStoreReviewScreenshotRelationshipsInAppPurchaseV2Data))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseAppStoreReviewScreenshotRelationshipsInAppPurchaseV2Data(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseAppStoreReviewScreenshotRelationshipsInAppPurchaseV2DataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseAppStoreReviewScreenshotRelationshipsInAppPurchaseV2DataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseAppStoreReviewScreenshotType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseAppStoreReviewScreenshotType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseAvailability))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseAvailability(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseAvailabilityAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseAvailabilityAttributes(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseAvailabilityRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseAvailabilityRelationships(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseAvailabilityRelationshipsAvailableTerritories))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseAvailabilityRelationshipsAvailableTerritories(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseAvailabilityRelationshipsAvailableTerritoriesDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseAvailabilityRelationshipsAvailableTerritoriesDataItem(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseAvailabilityRelationshipsAvailableTerritoriesDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseAvailabilityRelationshipsAvailableTerritoriesDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseAvailabilityType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseAvailabilityType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseContent))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseContent(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseContentAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseContentAttributes(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseContentRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseContentRelationships(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseContentRelationshipsInAppPurchaseV2))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseContentRelationshipsInAppPurchaseV2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseContentRelationshipsInAppPurchaseV2Data))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseContentRelationshipsInAppPurchaseV2Data(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseContentRelationshipsInAppPurchaseV2DataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseContentRelationshipsInAppPurchaseV2DataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseContentType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseContentType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseImage))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseImage(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseImageAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseImageAttributes(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseImageAttributesState))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseImageAttributesState2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseImageRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseImageRelationships(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseImageRelationshipsInAppPurchase))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseImageRelationshipsInAppPurchase(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseImageRelationshipsInAppPurchaseData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseImageRelationshipsInAppPurchaseData(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseImageRelationshipsInAppPurchaseDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseImageRelationshipsInAppPurchaseDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseImageType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseImageType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseLocalization(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseLocalizationAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseLocalizationAttributes(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseLocalizationAttributesState))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseLocalizationAttributesState2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseLocalizationRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseLocalizationRelationships(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseLocalizationRelationshipsInAppPurchaseV2))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseLocalizationRelationshipsInAppPurchaseV2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseLocalizationRelationshipsInAppPurchaseV2Data))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseLocalizationRelationshipsInAppPurchaseV2Data(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseLocalizationRelationshipsInAppPurchaseV2DataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseLocalizationRelationshipsInAppPurchaseV2DataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseLocalizationType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseLocalizationType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseOfferCode))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseOfferCode(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseOfferCodeAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseOfferCodeAttributes(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseOfferCodeAttributesCustomerEligibilitie))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseOfferCodeAttributesCustomerEligibilitie2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseOfferCodeRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseOfferCodeRelationships(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseOfferCodeRelationshipsCustomCodes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseOfferCodeRelationshipsCustomCodes(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseOfferCodeRelationshipsCustomCodesDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseOfferCodeRelationshipsCustomCodesDataItem(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseOfferCodeRelationshipsCustomCodesDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseOfferCodeRelationshipsCustomCodesDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseOfferCodeRelationshipsOneTimeUseCodes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseOfferCodeRelationshipsOneTimeUseCodes(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseOfferCodeRelationshipsOneTimeUseCodesDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseOfferCodeRelationshipsOneTimeUseCodesDataItem(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseOfferCodeRelationshipsOneTimeUseCodesDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseOfferCodeRelationshipsOneTimeUseCodesDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseOfferCodeRelationshipsPrices))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseOfferCodeRelationshipsPrices(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseOfferCodeRelationshipsPricesDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseOfferCodeRelationshipsPricesDataItem(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseOfferCodeRelationshipsPricesDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseOfferCodeRelationshipsPricesDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseOfferCodeType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseOfferCodeType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePricePoint))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePricePoint(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePricePointAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePricePointAttributes(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePricePointRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePricePointRelationships(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePricePointRelationshipsEqualizations))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePricePointRelationshipsEqualizations(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePricePointRelationshipsTerritory))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePricePointRelationshipsTerritory(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePricePointRelationshipsTerritoryData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePricePointRelationshipsTerritoryData(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePricePointRelationshipsTerritoryDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePricePointRelationshipsTerritoryDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePricePointType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePricePointType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePriceSchedule))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePriceSchedule(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePriceScheduleRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePriceScheduleRelationships(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePriceScheduleRelationshipsAutomaticPrices))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePriceScheduleRelationshipsAutomaticPrices(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePriceScheduleRelationshipsAutomaticPricesDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePriceScheduleRelationshipsAutomaticPricesDataItem(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePriceScheduleRelationshipsAutomaticPricesDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePriceScheduleRelationshipsAutomaticPricesDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePriceScheduleRelationshipsBaseTerritory))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePriceScheduleRelationshipsBaseTerritory(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePriceScheduleRelationshipsBaseTerritoryData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePriceScheduleRelationshipsBaseTerritoryData(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePriceScheduleRelationshipsBaseTerritoryDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePriceScheduleRelationshipsBaseTerritoryDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePriceScheduleRelationshipsManualPrices))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePriceScheduleRelationshipsManualPrices(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePriceScheduleRelationshipsManualPricesDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePriceScheduleRelationshipsManualPricesDataItem(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePriceScheduleRelationshipsManualPricesDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePriceScheduleRelationshipsManualPricesDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePriceScheduleType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasePriceScheduleType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseState))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseState2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseType2))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseType22(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseV2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2Attributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseV2Attributes(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2Relationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseV2Relationships(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsAppStoreReviewScreenshot))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseV2RelationshipsAppStoreReviewScreenshot(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsAppStoreReviewScreenshotData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseV2RelationshipsAppStoreReviewScreenshotData(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsAppStoreReviewScreenshotDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseV2RelationshipsAppStoreReviewScreenshotDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsContent))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseV2RelationshipsContent(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsContentData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseV2RelationshipsContentData(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsContentDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseV2RelationshipsContentDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsIapPriceSchedule))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseV2RelationshipsIapPriceSchedule(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsIapPriceScheduleData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseV2RelationshipsIapPriceScheduleData(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsIapPriceScheduleDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseV2RelationshipsIapPriceScheduleDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsImages))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseV2RelationshipsImages(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsImagesDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseV2RelationshipsImagesDataItem(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsImagesDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseV2RelationshipsImagesDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsInAppPurchaseAvailability))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseV2RelationshipsInAppPurchaseAvailability(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsInAppPurchaseAvailabilityData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseV2RelationshipsInAppPurchaseAvailabilityData(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsInAppPurchaseAvailabilityDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseV2RelationshipsInAppPurchaseAvailabilityDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsInAppPurchaseLocalizations))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseV2RelationshipsInAppPurchaseLocalizations(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsInAppPurchaseLocalizationsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseV2RelationshipsInAppPurchaseLocalizationsDataItem(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsInAppPurchaseLocalizationsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseV2RelationshipsInAppPurchaseLocalizationsDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsOfferCodes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseV2RelationshipsOfferCodes(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsOfferCodesDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseV2RelationshipsOfferCodesDataItem(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsOfferCodesDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseV2RelationshipsOfferCodesDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsPricePoints))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseV2RelationshipsPricePoints(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsPricePointsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseV2RelationshipsPricePointsDataItem(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsPricePointsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseV2RelationshipsPricePointsDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsPromotedPurchase))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseV2RelationshipsPromotedPurchase(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsPromotedPurchaseData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseV2RelationshipsPromotedPurchaseData(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsPromotedPurchaseDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseV2RelationshipsPromotedPurchaseDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsVersions))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseV2RelationshipsVersions(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsVersionsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseV2RelationshipsVersionsDataItem(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsVersionsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseV2RelationshipsVersionsDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2Type))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseV2Type2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseVersion(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseVersionAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseVersionAttributes(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseVersionAttributesState))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseVersionAttributesState2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseVersionRelationships(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsImage))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseVersionRelationshipsImage(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsImageData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseVersionRelationshipsImageData(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsImageDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseVersionRelationshipsImageDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsImages))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseVersionRelationshipsImages(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsImagesDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseVersionRelationshipsImagesDataItem(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsImagesDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseVersionRelationshipsImagesDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsInAppPurchase))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseVersionRelationshipsInAppPurchase(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsInAppPurchaseData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseVersionRelationshipsInAppPurchaseData(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsInAppPurchaseDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseVersionRelationshipsInAppPurchaseDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsLocalizations))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseVersionRelationshipsLocalizations(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsLocalizationsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseVersionRelationshipsLocalizationsDataItem(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsLocalizationsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseVersionRelationshipsLocalizationsDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseVersionType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseVersionType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasesV2Response))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasesV2Response(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasesV2ResponseIncludedItemDiscriminator))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasesV2ResponseIncludedItemDiscriminator(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasesV2ResponseIncludedItemDiscriminatorType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchasesV2ResponseIncludedItemDiscriminatorType2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::AppStoreConnect.IncludedItem146))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_IncludedItem1462(options);
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
                if (type == typeof(global::AppStoreConnect.PromotedPurchase))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_PromotedPurchase(options);
                }
                if (type == typeof(global::AppStoreConnect.PromotedPurchaseAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_PromotedPurchaseAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.PromotedPurchaseAttributesState))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_PromotedPurchaseAttributesState2(options);
                }
                if (type == typeof(global::AppStoreConnect.PromotedPurchaseRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_PromotedPurchaseRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.PromotedPurchaseRelationshipsInAppPurchaseV2))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_PromotedPurchaseRelationshipsInAppPurchaseV2(options);
                }
                if (type == typeof(global::AppStoreConnect.PromotedPurchaseRelationshipsInAppPurchaseV2Data))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_PromotedPurchaseRelationshipsInAppPurchaseV2Data(options);
                }
                if (type == typeof(global::AppStoreConnect.PromotedPurchaseRelationshipsInAppPurchaseV2DataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_PromotedPurchaseRelationshipsInAppPurchaseV2DataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.PromotedPurchaseRelationshipsSubscription))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_PromotedPurchaseRelationshipsSubscription(options);
                }
                if (type == typeof(global::AppStoreConnect.PromotedPurchaseRelationshipsSubscriptionData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_PromotedPurchaseRelationshipsSubscriptionData(options);
                }
                if (type == typeof(global::AppStoreConnect.PromotedPurchaseRelationshipsSubscriptionDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_PromotedPurchaseRelationshipsSubscriptionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.PromotedPurchaseType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_PromotedPurchaseType2(options);
                }
                if (type == typeof(global::AppStoreConnect.RelationshipLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_RelationshipLinks(options);
                }
                if (type == typeof(global::AppStoreConnect.ResourceLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_ResourceLinks(options);
                }
                if (type == typeof(global::AppStoreConnect.UploadOperation))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_UploadOperation(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppMediaStateError>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_7E9D192989E995BF(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchase>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_060D6AA920C55851(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseAppStoreReviewScreenshot>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_D1D6948C73D3DA46(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseAvailabilitie>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_E190D15F3937D3F3(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseContent>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_A64197AE83701D2B(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseImage>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_4941ECB67D6ED11D(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_5AB6374165096432(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseOfferCode>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_9B6EF82E6A2184A6(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchasePriceSchedule>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_297C4D1AE7B6B685(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_CD6FC78186A3D8F2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsPromotedPurchase>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_5F02210754334C3D(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFilterInAppPurchaseTypeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_928570160452FB72(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFilterStateItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_14712D9981EC7F49(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_B5A0B5271481EC4A(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedSortItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_CFD7ADF5BAFE0893(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.HttpHeader>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_BCE13B3326F5CA8F(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseAvailabilityRelationshipsAvailableTerritoriesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_5660D59A75C25A4C(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseOfferCodeAttributesCustomerEligibilitie>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_69B350476FD8EF5A(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseOfferCodeRelationshipsCustomCodesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_8BCE1A04BEB1F133(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseOfferCodeRelationshipsOneTimeUseCodesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_782D2930CEA7988E(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseOfferCodeRelationshipsPricesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_15012B5FAC81082A(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasePriceScheduleRelationshipsAutomaticPricesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_1EC9DA74B13ED4BB(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasePriceScheduleRelationshipsManualPricesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_62BC52CD482B6170(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseV2>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_18612FC2D0B60CB9(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseV2RelationshipsImagesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_3E6DC4926168F9AC(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseV2RelationshipsInAppPurchaseLocalizationsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_1A183C6D5A2F41E3(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseV2RelationshipsOfferCodesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_B25A8A1E8ACC60A5(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseV2RelationshipsPricePointsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_286F7E5AD57807A4(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseV2RelationshipsVersionsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_426B2661E4AC7F9F(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseVersionRelationshipsImagesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_E06D35CA4C51590E(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseVersionRelationshipsLocalizationsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_2178BF6184E53908(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem146>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_EA3F98674235F457(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.UploadOperation>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_A918B5AE31119789(options);
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
                if (type == typeof(global::AppStoreConnect.AppMediaAssetStateState?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppMediaAssetStateState2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchase?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchase2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseAppStoreReviewScreenshot?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseAppStoreReviewScreenshot2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseAvailabilitie?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseAvailabilitie2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseContent?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseContent2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseImage?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseImage2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseLocalization?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseOfferCode?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseOfferCode2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchasePriceSchedule?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchasePriceSchedule2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseVersion?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsPromotedPurchase?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsInAppPurchasesV2GetToManyRelatedFieldsPromotedPurchase2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFilterInAppPurchaseTypeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsInAppPurchasesV2GetToManyRelatedFilterInAppPurchaseTypeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFilterStateItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsInAppPurchasesV2GetToManyRelatedFilterStateItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsInAppPurchasesV2GetToManyRelatedIncludeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedSortItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsInAppPurchasesV2GetToManyRelatedSortItem2(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseAppStoreReviewScreenshotRelationshipsInAppPurchaseV2DataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseAppStoreReviewScreenshotRelationshipsInAppPurchaseV2DataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseAppStoreReviewScreenshotType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseAppStoreReviewScreenshotType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseAvailabilityRelationshipsAvailableTerritoriesDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseAvailabilityRelationshipsAvailableTerritoriesDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseAvailabilityType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseAvailabilityType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseContentRelationshipsInAppPurchaseV2DataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseContentRelationshipsInAppPurchaseV2DataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseContentType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseContentType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseImageAttributesState?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseImageAttributesState2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseImageRelationshipsInAppPurchaseDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseImageRelationshipsInAppPurchaseDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseImageType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseImageType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseLocalizationAttributesState?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseLocalizationAttributesState2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseLocalizationRelationshipsInAppPurchaseV2DataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseLocalizationRelationshipsInAppPurchaseV2DataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseLocalizationType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseLocalizationType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseOfferCodeAttributesCustomerEligibilitie?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseOfferCodeAttributesCustomerEligibilitie2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseOfferCodeRelationshipsCustomCodesDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseOfferCodeRelationshipsCustomCodesDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseOfferCodeRelationshipsOneTimeUseCodesDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseOfferCodeRelationshipsOneTimeUseCodesDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseOfferCodeRelationshipsPricesDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseOfferCodeRelationshipsPricesDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseOfferCodeType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseOfferCodeType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePricePointRelationshipsTerritoryDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchasePricePointRelationshipsTerritoryDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePricePointType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchasePricePointType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePriceScheduleRelationshipsAutomaticPricesDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchasePriceScheduleRelationshipsAutomaticPricesDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePriceScheduleRelationshipsBaseTerritoryDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchasePriceScheduleRelationshipsBaseTerritoryDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePriceScheduleRelationshipsManualPricesDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchasePriceScheduleRelationshipsManualPricesDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasePriceScheduleType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchasePriceScheduleType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseState?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseState2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseType2?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseType22(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsAppStoreReviewScreenshotDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseV2RelationshipsAppStoreReviewScreenshotDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsContentDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseV2RelationshipsContentDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsIapPriceScheduleDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseV2RelationshipsIapPriceScheduleDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsImagesDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseV2RelationshipsImagesDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsInAppPurchaseAvailabilityDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseV2RelationshipsInAppPurchaseAvailabilityDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsInAppPurchaseLocalizationsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseV2RelationshipsInAppPurchaseLocalizationsDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsOfferCodesDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseV2RelationshipsOfferCodesDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsPricePointsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseV2RelationshipsPricePointsDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsPromotedPurchaseDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseV2RelationshipsPromotedPurchaseDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2RelationshipsVersionsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseV2RelationshipsVersionsDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseV2Type?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseV2Type2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseVersionAttributesState?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseVersionAttributesState2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsImageDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseVersionRelationshipsImageDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsImagesDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseVersionRelationshipsImagesDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsInAppPurchaseDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseVersionRelationshipsInAppPurchaseDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseVersionRelationshipsLocalizationsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseVersionRelationshipsLocalizationsDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseVersionType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseVersionType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasesV2ResponseIncludedItemDiscriminatorType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchasesV2ResponseIncludedItemDiscriminatorType2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::AppStoreConnect.IncludedItem146?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableIncludedItem1462(options);
                }
                if (type == typeof(global::AppStoreConnect.PromotedPurchaseAttributesState?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullablePromotedPurchaseAttributesState2(options);
                }
                if (type == typeof(global::AppStoreConnect.PromotedPurchaseRelationshipsInAppPurchaseV2DataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullablePromotedPurchaseRelationshipsInAppPurchaseV2DataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.PromotedPurchaseRelationshipsSubscriptionDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullablePromotedPurchaseRelationshipsSubscriptionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.PromotedPurchaseType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullablePromotedPurchaseType2(options);
                }
                if (type == typeof(global::System.DateTime?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableDateTime(options);
                }
                if (type == typeof(int?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppMediaStateError>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_AE112F1FF3B11297(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchase>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_3B0AF98D5360FE3D(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseAppStoreReviewScreenshot>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_F73806F6E6BEA80B(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseAvailabilitie>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_96BA18B9E36B94E4(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseContent>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_7311E3E17F8D0438(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseImage>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_B57F055E0D563DB2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_67F73CC0917B155C(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseOfferCode>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_49EEB26B2583ADBC(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchasePriceSchedule>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_CFF40B3DF17B727E(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_DEEC4809A7B181A1(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsPromotedPurchase>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_BCB4E886AD6D0CCB(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFilterInAppPurchaseTypeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_4AED9D68E9296BB1(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFilterStateItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_6F5513BDFF1495EA(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_97DED485F89AA3EB(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedSortItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_7EF303A31073AF74(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.HttpHeader>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_1947F16F30F1622D(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.InAppPurchaseAvailabilityRelationshipsAvailableTerritoriesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_E692A0001C142A0A(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.InAppPurchaseOfferCodeAttributesCustomerEligibilitie>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_4F01BF5FF566F555(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.InAppPurchaseOfferCodeRelationshipsCustomCodesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_839309984D4D5679(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.InAppPurchaseOfferCodeRelationshipsOneTimeUseCodesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_95320B64B8CBF4E2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.InAppPurchaseOfferCodeRelationshipsPricesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_3903012F30159693(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.InAppPurchasePriceScheduleRelationshipsAutomaticPricesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_E63A10DD858ACE1D(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.InAppPurchasePriceScheduleRelationshipsManualPricesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_255657A7B7E3572F(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.InAppPurchaseV2>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_86B7A6ABFA8C3C5F(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.InAppPurchaseV2RelationshipsImagesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_BB080C51C5965C56(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.InAppPurchaseV2RelationshipsInAppPurchaseLocalizationsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_AC3A4EA9918FCDC8(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.InAppPurchaseV2RelationshipsOfferCodesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_8F2C88A7D72EF3C5(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.InAppPurchaseV2RelationshipsPricePointsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_E6969942D5F71CFE(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.InAppPurchaseV2RelationshipsVersionsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_35A37E22C117E90D(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.InAppPurchaseVersionRelationshipsImagesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_DA75E0250B4A4C8A(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.InAppPurchaseVersionRelationshipsLocalizationsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_772F5A94FB3A84B2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem146>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_2ACF5CD4AEB10727(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.UploadOperation>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_4C40FFC5269982A1(options);
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