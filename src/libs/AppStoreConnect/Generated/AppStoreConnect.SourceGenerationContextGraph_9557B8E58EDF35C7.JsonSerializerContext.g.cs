
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_9557B8E58EDF35C7 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_9557B8E58EDF35C7 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_9557B8E58EDF35C7(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem176JsonConverter());
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
                    typeToConvert == typeof(global::AppStoreConnect.SubscriptionImageV2Type)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionImageV2Type?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionLocalizationV2Type)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionLocalizationV2Type?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionLocalizationV2RelationshipsVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionLocalizationV2RelationshipsVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionAttributesState)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionAttributesState?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsSubscriptionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsSubscriptionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsImageDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsImageDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsImagesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsImagesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsLocalizationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsLocalizationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionsResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionsResponseIncludedItemDiscriminatorType?)

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

                    || typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState)

                    || typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFilterStateItem)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFilterStateItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFieldsSubscription)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFieldsSubscription?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionImage)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionImage?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionImageV2Type))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionImageV2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionImageV2Type?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionImageV2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionLocalizationV2Type))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionLocalizationV2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionLocalizationV2Type?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionLocalizationV2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionLocalizationV2RelationshipsVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionLocalizationV2RelationshipsVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionLocalizationV2RelationshipsVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionLocalizationV2RelationshipsVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionVersionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionVersionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionAttributesState))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionVersionAttributesStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionAttributesState?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionVersionAttributesStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsSubscriptionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionVersionRelationshipsSubscriptionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsSubscriptionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionVersionRelationshipsSubscriptionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsImageDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionVersionRelationshipsImageDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsImageDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionVersionRelationshipsImageDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsImagesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionVersionRelationshipsImagesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsImagesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionVersionRelationshipsImagesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsLocalizationsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionVersionRelationshipsLocalizationsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsLocalizationsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionVersionRelationshipsLocalizationsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionsResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionVersionsResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionVersionsResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionVersionsResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState))
                {
                    return new global::AppStoreConnect.JsonConverters.AppMediaAssetStateStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppMediaAssetStateStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFilterStateItem))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsVersionsGetToManyRelatedFilterStateItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFilterStateItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsVersionsGetToManyRelatedFilterStateItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFieldsSubscription))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFieldsSubscription?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionImage))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionImageJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionImage?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionImageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsVersionsGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsVersionsGetToManyRelatedIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.HttpHeader))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_HttpHeader(options);
                }
                if (type == typeof(global::AppStoreConnect.ImageAsset))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_ImageAsset(options);
                }
                if (type == typeof(global::AppStoreConnect.IncludedItem176))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_IncludedItem1762(options);
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
                if (type == typeof(global::AppStoreConnect.SubscriptionImageV2))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionImageV2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionImageV2Attributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionImageV2Attributes(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionImageV2Type))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionImageV2Type2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionLocalizationV2))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionLocalizationV2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionLocalizationV2Attributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionLocalizationV2Attributes(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionLocalizationV2Relationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionLocalizationV2Relationships(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionLocalizationV2RelationshipsVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionLocalizationV2RelationshipsVersion(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionLocalizationV2RelationshipsVersionData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionLocalizationV2RelationshipsVersionData(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionLocalizationV2RelationshipsVersionDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionLocalizationV2RelationshipsVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionLocalizationV2Type))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionLocalizationV2Type2(options);
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
                if (type == typeof(global::AppStoreConnect.SubscriptionVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SubscriptionVersion(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionVersionAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionVersionAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionVersionAttributesState))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionVersionAttributesState2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionVersionRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionVersionRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsImage))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionVersionRelationshipsImage(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsImageData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionVersionRelationshipsImageData(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsImageDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionVersionRelationshipsImageDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsImages))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionVersionRelationshipsImages(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsImagesDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionVersionRelationshipsImagesDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsImagesDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionVersionRelationshipsImagesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsLocalizations))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionVersionRelationshipsLocalizations(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsLocalizationsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionVersionRelationshipsLocalizationsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsLocalizationsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionVersionRelationshipsLocalizationsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsSubscription))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionVersionRelationshipsSubscription(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsSubscriptionData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionVersionRelationshipsSubscriptionData(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsSubscriptionDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionVersionRelationshipsSubscriptionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionVersionType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionVersionType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionVersionsResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionVersionsResponse(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionVersionsResponseIncludedItemDiscriminator))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionVersionsResponseIncludedItemDiscriminator(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionVersionsResponseIncludedItemDiscriminatorType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionVersionsResponseIncludedItemDiscriminatorType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFieldsSubscription))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SubscriptionsVersionsGetToManyRelatedFieldsSubscription2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionImage))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionImage2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFilterStateItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SubscriptionsVersionsGetToManyRelatedFilterStateItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SubscriptionsVersionsGetToManyRelatedIncludeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.UploadOperation))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_UploadOperation(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppMediaStateError>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_7E9D192989E995BF(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.HttpHeader>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_BCE13B3326F5CA8F(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem176>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_62E25919EE6D0733(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionAttributesMarketSetting>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_82ED2ED835D976B5(options);
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
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_9F3C8468FF8EA6E1(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionVersionRelationshipsImagesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_9AA8D4EBC4E19D97(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionVersionRelationshipsLocalizationsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_095F1D8B4C99840F(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFieldsSubscription>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_32CFD10F5D0D8C7B(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionImage>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_67DD52297BA8A628(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_2D79159F109D6D5E(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_D514CCE4D14B62CB(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFilterStateItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_87ECE5FFF6A6A1F7(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_BC2D25ABC80B2472(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.UploadOperation>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_A918B5AE31119789(options);
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
                if (type == typeof(global::AppStoreConnect.IncludedItem176?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableIncludedItem1762(options);
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
                if (type == typeof(global::AppStoreConnect.SubscriptionImageV2Type?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionImageV2Type2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionLocalizationV2RelationshipsVersionDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionLocalizationV2RelationshipsVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionLocalizationV2Type?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionLocalizationV2Type2(options);
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
                if (type == typeof(global::AppStoreConnect.SubscriptionVersionAttributesState?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionVersionAttributesState2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsImageDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionVersionRelationshipsImageDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsImagesDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionVersionRelationshipsImagesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsLocalizationsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionVersionRelationshipsLocalizationsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionVersionRelationshipsSubscriptionDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionVersionRelationshipsSubscriptionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionVersionType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionVersionType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionVersionsResponseIncludedItemDiscriminatorType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionVersionsResponseIncludedItemDiscriminatorType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFieldsSubscription?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableSubscriptionsVersionsGetToManyRelatedFieldsSubscription2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionImage?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableSubscriptionsVersionsGetToManyRelatedFieldsSubscriptionImage2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionLocalization?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableSubscriptionsVersionsGetToManyRelatedFieldsSubscriptionLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionVersion?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableSubscriptionsVersionsGetToManyRelatedFieldsSubscriptionVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFilterStateItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableSubscriptionsVersionsGetToManyRelatedFilterStateItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableSubscriptionsVersionsGetToManyRelatedIncludeItem2(options);
                }
                if (type == typeof(int?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppMediaStateError>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_AE112F1FF3B11297(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.HttpHeader>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_1947F16F30F1622D(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem176>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_03E1AE26E1690463(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionAttributesMarketSetting>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_20A07BEE5D3D360C(options);
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
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_37E6B0C23B6BE2AB(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionVersionRelationshipsImagesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_AC1F5374092661F4(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionVersionRelationshipsLocalizationsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_F8CB52D0517B87EF(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFieldsSubscription>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_5443977EAB66930B(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionImage>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_2AC7019E43BFF530(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_23C912C36FADE718(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_180635657C9343E8(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedFilterStateItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_C6775DA2305682F0(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsVersionsGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_7655DEB987CEB302(options);
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