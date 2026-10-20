
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_5990EE14EDFE54EA : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_5990EE14EDFE54EA Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_5990EE14EDFE54EA(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem145JsonConverter());
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
                    typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseImageV2Type)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseImageV2Type?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseLocalizationV2Type)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseLocalizationV2Type?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseLocalizationV2RelationshipsVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseLocalizationV2RelationshipsVersionDataType?)

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

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionResponseIncludedItemDiscriminatorType?)

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

                    || typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState)

                    || typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseState)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseState?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseType2)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseType2?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseImageV2Type))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseImageV2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseImageV2Type?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseImageV2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseLocalizationV2Type))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseLocalizationV2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseLocalizationV2Type?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseLocalizationV2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseLocalizationV2RelationshipsVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseLocalizationV2RelationshipsVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseLocalizationV2RelationshipsVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseLocalizationV2RelationshipsVersionDataTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseVersionResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseVersionResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseVersionResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
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
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseImageV2))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseImageV2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseImageV2Attributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseImageV2Attributes(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseImageV2Type))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseImageV2Type2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseLocalizationV2))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseLocalizationV2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseLocalizationV2Attributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseLocalizationV2Attributes(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseLocalizationV2Relationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseLocalizationV2Relationships(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseLocalizationV2RelationshipsVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseLocalizationV2RelationshipsVersion(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseLocalizationV2RelationshipsVersionData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseLocalizationV2RelationshipsVersionData(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseLocalizationV2RelationshipsVersionDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseLocalizationV2RelationshipsVersionDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseLocalizationV2Type))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseLocalizationV2Type2(options);
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
                if (type == typeof(global::AppStoreConnect.InAppPurchaseVersionResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseVersionResponse(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseVersionResponseIncludedItemDiscriminator))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseVersionResponseIncludedItemDiscriminator(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseVersionResponseIncludedItemDiscriminatorType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseVersionResponseIncludedItemDiscriminatorType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseVersionType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseVersionType2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::AppStoreConnect.IncludedItem145))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_IncludedItem1452(options);
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
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem145>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_0D80B2BDC313D53B(options);
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
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseImageV2Type?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseImageV2Type2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseLocalizationV2RelationshipsVersionDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseLocalizationV2RelationshipsVersionDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseLocalizationV2Type?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseLocalizationV2Type2(options);
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
                if (type == typeof(global::AppStoreConnect.InAppPurchaseVersionResponseIncludedItemDiscriminatorType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseVersionResponseIncludedItemDiscriminatorType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseVersionType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseVersionType2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::AppStoreConnect.IncludedItem145?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableIncludedItem1452(options);
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
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem145>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_0C8F072FDEDC074F(options);
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