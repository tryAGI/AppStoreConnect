
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_F54CFFB045F449DC : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_F54CFFB045F449DC Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_F54CFFB045F449DC(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.SubscriptionImageType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionImageType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionImageAttributesState)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionImageAttributesState?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionImageRelationshipsSubscriptionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionImageRelationshipsSubscriptionDataType?)

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

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionRelationshipsVersionsDataItemType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionImageType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionImageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionImageType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionImageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionImageAttributesState))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionImageAttributesStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionImageAttributesState?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionImageAttributesStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionImageRelationshipsSubscriptionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionImageRelationshipsSubscriptionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionImageRelationshipsSubscriptionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionImageRelationshipsSubscriptionDataTypeNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.DocumentLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_DocumentLinks(options);
                }
                if (type == typeof(global::AppStoreConnect.HttpHeader))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_HttpHeader(options);
                }
                if (type == typeof(global::AppStoreConnect.ImageAsset))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_ImageAsset(options);
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
                if (type == typeof(global::AppStoreConnect.SubscriptionImage))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionImage(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionImageAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionImageAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionImageAttributesState))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionImageAttributesState2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionImageRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionImageRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionImageRelationshipsSubscription))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionImageRelationshipsSubscription(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionImageRelationshipsSubscriptionData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionImageRelationshipsSubscriptionData(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionImageRelationshipsSubscriptionDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionImageRelationshipsSubscriptionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionImageResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionImageResponse(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionImageType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionImageType2(options);
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
                if (type == typeof(global::AppStoreConnect.UploadOperation))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_UploadOperation(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.HttpHeader>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_BCE13B3326F5CA8F(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.Subscription>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_CA9B161F939730C2(options);
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
                if (type == typeof(global::AppStoreConnect.SubscriptionImageAttributesState?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionImageAttributesState2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionImageRelationshipsSubscriptionDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionImageRelationshipsSubscriptionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionImageType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionImageType2(options);
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
                if (type == typeof(int?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.HttpHeader>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_1947F16F30F1622D(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.Subscription>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_D89FFA4BAD2FA2FD(options);
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