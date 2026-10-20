
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_149B8B9DD7106003 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_149B8B9DD7106003 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_149B8B9DD7106003(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem33JsonConverter());
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
                    typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationRelationshipsAppCustomProductPageVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationRelationshipsAppCustomProductPageVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationRelationshipsAppScreenshotSetsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationRelationshipsAppScreenshotSetsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationRelationshipsAppPreviewSetsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationRelationshipsAppPreviewSetsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationRelationshipsSearchKeywordsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationRelationshipsSearchKeywordsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationRelationshipsPlacementsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationRelationshipsPlacementsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppStoreVersionLocalizationDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppStoreVersionLocalizationDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppCustomProductPageLocalizationDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppCustomProductPageLocalizationDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppScreenshotsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppScreenshotsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetsResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetsResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppScreenshotType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppScreenshotType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppScreenshotRelationshipsAppScreenshotSetDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppScreenshotRelationshipsAppScreenshotSetDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppStoreVersionExperimentTreatmentDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppStoreVersionExperimentTreatmentDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppScreenshotSetsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppScreenshotSetsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppPreviewSetsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppPreviewSetsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsPlacementsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsPlacementsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsAppStoreVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsAppStoreVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsAppScreenshotSetsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsAppScreenshotSetsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsAppPreviewSetsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsAppPreviewSetsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsSearchKeywordsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsSearchKeywordsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsPlacementsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsPlacementsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState)

                    || typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState?)

                    || typeToConvert == typeof(global::AppStoreConnect.ScreenshotDisplayType)

                    || typeToConvert == typeof(global::AppStoreConnect.ScreenshotDisplayType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageLocalizationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageLocalizationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationRelationshipsAppCustomProductPageVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageLocalizationRelationshipsAppCustomProductPageVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationRelationshipsAppCustomProductPageVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageLocalizationRelationshipsAppCustomProductPageVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationRelationshipsAppScreenshotSetsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageLocalizationRelationshipsAppScreenshotSetsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationRelationshipsAppScreenshotSetsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageLocalizationRelationshipsAppScreenshotSetsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationRelationshipsAppPreviewSetsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageLocalizationRelationshipsAppPreviewSetsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationRelationshipsAppPreviewSetsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageLocalizationRelationshipsAppPreviewSetsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationRelationshipsSearchKeywordsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageLocalizationRelationshipsSearchKeywordsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationRelationshipsSearchKeywordsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageLocalizationRelationshipsSearchKeywordsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationRelationshipsPlacementsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageLocalizationRelationshipsPlacementsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationRelationshipsPlacementsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageLocalizationRelationshipsPlacementsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppScreenshotSetTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppScreenshotSetTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppStoreVersionLocalizationDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppScreenshotSetRelationshipsAppStoreVersionLocalizationDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppStoreVersionLocalizationDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppScreenshotSetRelationshipsAppStoreVersionLocalizationDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppCustomProductPageLocalizationDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppScreenshotSetRelationshipsAppCustomProductPageLocalizationDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppCustomProductPageLocalizationDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppScreenshotSetRelationshipsAppCustomProductPageLocalizationDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppScreenshotSetRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppScreenshotSetRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppScreenshotsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppScreenshotSetRelationshipsAppScreenshotsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppScreenshotsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppScreenshotSetRelationshipsAppScreenshotsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetsResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppScreenshotSetsResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetsResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppScreenshotSetsResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppScreenshotType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppScreenshotTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppScreenshotType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppScreenshotTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppScreenshotRelationshipsAppScreenshotSetDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppScreenshotRelationshipsAppScreenshotSetDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppScreenshotRelationshipsAppScreenshotSetDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppScreenshotRelationshipsAppScreenshotSetDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentLocalizationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentLocalizationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppStoreVersionExperimentTreatmentDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppStoreVersionExperimentTreatmentDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppStoreVersionExperimentTreatmentDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppStoreVersionExperimentTreatmentDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppScreenshotSetsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppScreenshotSetsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppScreenshotSetsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppScreenshotSetsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppPreviewSetsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppPreviewSetsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppPreviewSetsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppPreviewSetsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsPlacementsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentLocalizationRelationshipsPlacementsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsPlacementsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentLocalizationRelationshipsPlacementsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionLocalizationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionLocalizationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsAppStoreVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionLocalizationRelationshipsAppStoreVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsAppStoreVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionLocalizationRelationshipsAppStoreVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsAppScreenshotSetsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionLocalizationRelationshipsAppScreenshotSetsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsAppScreenshotSetsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionLocalizationRelationshipsAppScreenshotSetsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsAppPreviewSetsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionLocalizationRelationshipsAppPreviewSetsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsAppPreviewSetsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionLocalizationRelationshipsAppPreviewSetsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsSearchKeywordsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionLocalizationRelationshipsSearchKeywordsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsSearchKeywordsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionLocalizationRelationshipsSearchKeywordsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsPlacementsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionLocalizationRelationshipsPlacementsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsPlacementsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionLocalizationRelationshipsPlacementsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState))
                {
                    return new global::AppStoreConnect.JsonConverters.AppMediaAssetStateStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppMediaAssetStateStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ScreenshotDisplayType))
                {
                    return new global::AppStoreConnect.JsonConverters.ScreenshotDisplayTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ScreenshotDisplayType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ScreenshotDisplayTypeNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageLocalization(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageLocalizationAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageLocalizationRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationRelationshipsAppCustomProductPageVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageLocalizationRelationshipsAppCustomProductPageVersion(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationRelationshipsAppCustomProductPageVersionData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageLocalizationRelationshipsAppCustomProductPageVersionData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationRelationshipsAppCustomProductPageVersionDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageLocalizationRelationshipsAppCustomProductPageVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationRelationshipsAppPreviewSets))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageLocalizationRelationshipsAppPreviewSets(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationRelationshipsAppPreviewSetsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageLocalizationRelationshipsAppPreviewSetsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationRelationshipsAppPreviewSetsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageLocalizationRelationshipsAppPreviewSetsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationRelationshipsAppScreenshotSets))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageLocalizationRelationshipsAppScreenshotSets(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationRelationshipsAppScreenshotSetsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageLocalizationRelationshipsAppScreenshotSetsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationRelationshipsAppScreenshotSetsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageLocalizationRelationshipsAppScreenshotSetsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationRelationshipsPlacements))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageLocalizationRelationshipsPlacements(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationRelationshipsPlacementsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageLocalizationRelationshipsPlacementsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationRelationshipsPlacementsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageLocalizationRelationshipsPlacementsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationRelationshipsSearchKeywords))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageLocalizationRelationshipsSearchKeywords(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationRelationshipsSearchKeywordsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageLocalizationRelationshipsSearchKeywordsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationRelationshipsSearchKeywordsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageLocalizationRelationshipsSearchKeywordsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageLocalizationType2(options);
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
                if (type == typeof(global::AppStoreConnect.AppScreenshot))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppScreenshot(options);
                }
                if (type == typeof(global::AppStoreConnect.AppScreenshotAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppScreenshotAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.AppScreenshotRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppScreenshotRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.AppScreenshotRelationshipsAppScreenshotSet))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppScreenshotRelationshipsAppScreenshotSet(options);
                }
                if (type == typeof(global::AppStoreConnect.AppScreenshotRelationshipsAppScreenshotSetData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppScreenshotRelationshipsAppScreenshotSetData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppScreenshotRelationshipsAppScreenshotSetDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppScreenshotRelationshipsAppScreenshotSetDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppScreenshotSet))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppScreenshotSet(options);
                }
                if (type == typeof(global::AppStoreConnect.AppScreenshotSetAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppScreenshotSetAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.AppScreenshotSetRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppScreenshotSetRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppCustomProductPageLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppScreenshotSetRelationshipsAppCustomProductPageLocalization(options);
                }
                if (type == typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppCustomProductPageLocalizationData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppScreenshotSetRelationshipsAppCustomProductPageLocalizationData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppCustomProductPageLocalizationDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppScreenshotSetRelationshipsAppCustomProductPageLocalizationDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppScreenshots))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppScreenshotSetRelationshipsAppScreenshots(options);
                }
                if (type == typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppScreenshotsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppScreenshotSetRelationshipsAppScreenshotsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppScreenshotsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppScreenshotSetRelationshipsAppScreenshotsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppStoreVersionExperimentTreatmentLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppScreenshotSetRelationshipsAppStoreVersionExperimentTreatmentLocalization(options);
                }
                if (type == typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppStoreVersionExperimentTreatmentLocalizationData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppScreenshotSetRelationshipsAppStoreVersionExperimentTreatmentLocalizationData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppScreenshotSetRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppStoreVersionLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppScreenshotSetRelationshipsAppStoreVersionLocalization(options);
                }
                if (type == typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppStoreVersionLocalizationData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppScreenshotSetRelationshipsAppStoreVersionLocalizationData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppStoreVersionLocalizationDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppScreenshotSetRelationshipsAppStoreVersionLocalizationDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppScreenshotSetType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppScreenshotSetType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppScreenshotSetsResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppScreenshotSetsResponse(options);
                }
                if (type == typeof(global::AppStoreConnect.AppScreenshotSetsResponseIncludedItemDiscriminator))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppScreenshotSetsResponseIncludedItemDiscriminator(options);
                }
                if (type == typeof(global::AppStoreConnect.AppScreenshotSetsResponseIncludedItemDiscriminatorType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppScreenshotSetsResponseIncludedItemDiscriminatorType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppScreenshotType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppScreenshotType2(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentTreatmentLocalization(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentTreatmentLocalizationAttributes(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentTreatmentLocalizationRelationships(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppPreviewSets))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppPreviewSets(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppPreviewSetsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppPreviewSetsDataItem(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppPreviewSetsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppPreviewSetsDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppScreenshotSets))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppScreenshotSets(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppScreenshotSetsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppScreenshotSetsDataItem(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppScreenshotSetsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppScreenshotSetsDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppStoreVersionExperimentTreatment))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppStoreVersionExperimentTreatment(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppStoreVersionExperimentTreatmentData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppStoreVersionExperimentTreatmentData(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppStoreVersionExperimentTreatmentDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppStoreVersionExperimentTreatmentDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsPlacements))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentTreatmentLocalizationRelationshipsPlacements(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsPlacementsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentTreatmentLocalizationRelationshipsPlacementsDataItem(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsPlacementsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentTreatmentLocalizationRelationshipsPlacementsDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentTreatmentLocalizationType2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::AppStoreConnect.AppStoreVersionLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionLocalization(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionLocalizationAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionLocalizationAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionLocalizationRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsAppPreviewSets))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionLocalizationRelationshipsAppPreviewSets(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsAppPreviewSetsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionLocalizationRelationshipsAppPreviewSetsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsAppPreviewSetsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionLocalizationRelationshipsAppPreviewSetsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsAppScreenshotSets))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionLocalizationRelationshipsAppScreenshotSets(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsAppScreenshotSetsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionLocalizationRelationshipsAppScreenshotSetsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsAppScreenshotSetsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionLocalizationRelationshipsAppScreenshotSetsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsAppStoreVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionLocalizationRelationshipsAppStoreVersion(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsAppStoreVersionData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionLocalizationRelationshipsAppStoreVersionData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsAppStoreVersionDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionLocalizationRelationshipsAppStoreVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsPlacements))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionLocalizationRelationshipsPlacements(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsPlacementsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionLocalizationRelationshipsPlacementsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsPlacementsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionLocalizationRelationshipsPlacementsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsSearchKeywords))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionLocalizationRelationshipsSearchKeywords(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsSearchKeywordsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionLocalizationRelationshipsSearchKeywordsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsSearchKeywordsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionLocalizationRelationshipsSearchKeywordsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionLocalizationType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionLocalizationType2(options);
                }
                if (type == typeof(global::AppStoreConnect.HttpHeader))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_HttpHeader(options);
                }
                if (type == typeof(global::AppStoreConnect.ImageAsset))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_ImageAsset(options);
                }
                if (type == typeof(global::AppStoreConnect.IncludedItem33))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_IncludedItem332(options);
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
                if (type == typeof(global::AppStoreConnect.ScreenshotDisplayType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_ScreenshotDisplayType2(options);
                }
                if (type == typeof(global::AppStoreConnect.UploadOperation))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_UploadOperation(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageLocalizationRelationshipsAppPreviewSetsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_3F7D7A8286BF2156(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageLocalizationRelationshipsAppScreenshotSetsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_D33642CD17DCF2DF(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageLocalizationRelationshipsPlacementsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_7A1F9B46410C5414(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageLocalizationRelationshipsSearchKeywordsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_1B26AC84018AB786(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppMediaStateError>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_7E9D192989E995BF(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppScreenshotSet>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_4E254350F8F86773(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppScreenshotSetRelationshipsAppScreenshotsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_B7B0A5ED1FD379A0(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppPreviewSetsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_4500CDA7623C24B7(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppScreenshotSetsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_062049DB262F22F0(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsPlacementsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_052B25D6EAAD6B0B(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsAppPreviewSetsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_CBEA1F46184EFBBE(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsAppScreenshotSetsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_F062F56236D23454(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsPlacementsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_36278FA830998EC7(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsSearchKeywordsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_78682B6F40D5D91F(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.HttpHeader>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_BCE13B3326F5CA8F(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem33>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_EA298542A41C07E6(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.UploadOperation>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_A918B5AE31119789(options);
                }
                if (type == typeof(int))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationRelationshipsAppCustomProductPageVersionDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppCustomProductPageLocalizationRelationshipsAppCustomProductPageVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationRelationshipsAppPreviewSetsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppCustomProductPageLocalizationRelationshipsAppPreviewSetsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationRelationshipsAppScreenshotSetsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppCustomProductPageLocalizationRelationshipsAppScreenshotSetsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationRelationshipsPlacementsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppCustomProductPageLocalizationRelationshipsPlacementsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationRelationshipsSearchKeywordsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppCustomProductPageLocalizationRelationshipsSearchKeywordsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppCustomProductPageLocalizationType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppMediaAssetStateState?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppMediaAssetStateState2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppScreenshotRelationshipsAppScreenshotSetDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppScreenshotRelationshipsAppScreenshotSetDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppCustomProductPageLocalizationDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppScreenshotSetRelationshipsAppCustomProductPageLocalizationDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppScreenshotsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppScreenshotSetRelationshipsAppScreenshotsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppScreenshotSetRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppStoreVersionLocalizationDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppScreenshotSetRelationshipsAppStoreVersionLocalizationDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppScreenshotSetType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppScreenshotSetType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppScreenshotSetsResponseIncludedItemDiscriminatorType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppScreenshotSetsResponseIncludedItemDiscriminatorType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppScreenshotType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppScreenshotType2(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppPreviewSetsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppStoreVersionExperimentTreatmentLocalizationRelationshipsAppPreviewSetsDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppScreenshotSetsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppStoreVersionExperimentTreatmentLocalizationRelationshipsAppScreenshotSetsDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppStoreVersionExperimentTreatmentDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppStoreVersionExperimentTreatmentLocalizationRelationshipsAppStoreVersionExperimentTreatmentDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsPlacementsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppStoreVersionExperimentTreatmentLocalizationRelationshipsPlacementsDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppStoreVersionExperimentTreatmentLocalizationType2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsAppPreviewSetsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppStoreVersionLocalizationRelationshipsAppPreviewSetsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsAppScreenshotSetsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppStoreVersionLocalizationRelationshipsAppScreenshotSetsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsAppStoreVersionDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppStoreVersionLocalizationRelationshipsAppStoreVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsPlacementsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppStoreVersionLocalizationRelationshipsPlacementsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsSearchKeywordsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppStoreVersionLocalizationRelationshipsSearchKeywordsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionLocalizationType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppStoreVersionLocalizationType2(options);
                }
                if (type == typeof(global::AppStoreConnect.IncludedItem33?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableIncludedItem332(options);
                }
                if (type == typeof(global::AppStoreConnect.ScreenshotDisplayType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableScreenshotDisplayType2(options);
                }
                if (type == typeof(int?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppCustomProductPageLocalizationRelationshipsAppPreviewSetsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_3CC3B796D8778378(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppCustomProductPageLocalizationRelationshipsAppScreenshotSetsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_872BBE80F72D5E31(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppCustomProductPageLocalizationRelationshipsPlacementsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_48855F9CE8987626(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppCustomProductPageLocalizationRelationshipsSearchKeywordsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_8E2E2643A36C3505(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppMediaStateError>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_AE112F1FF3B11297(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppScreenshotSet>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_D37A099C2A5881E6(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppScreenshotSetRelationshipsAppScreenshotsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_A227BCD6CED5CE38(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppPreviewSetsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_344F5A10F3688504(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppScreenshotSetsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_566C33F02254E929(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationRelationshipsPlacementsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_ED9C675E384A1CF2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsAppPreviewSetsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_9FAB9560E47CCDDC(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsAppScreenshotSetsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_49596DD2B68426A4(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsPlacementsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_A42E3B7EF3CB86D0(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsSearchKeywordsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_71CDE65135155988(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.HttpHeader>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_1947F16F30F1622D(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem33>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_4014E59C175CA001(options);
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