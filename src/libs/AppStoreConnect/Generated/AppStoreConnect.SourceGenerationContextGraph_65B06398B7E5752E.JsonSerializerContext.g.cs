
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_65B06398B7E5752E : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_65B06398B7E5752E Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_65B06398B7E5752E(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem26JsonConverter());
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

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppStoreVersionLocalizationDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppStoreVersionLocalizationDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppCustomProductPageLocalizationDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppCustomProductPageLocalizationDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppPreviewsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppPreviewsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetsResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetsResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewRelationshipsAppPreviewSetDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewRelationshipsAppPreviewSetDataType?)

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

                    || typeToConvert == typeof(global::AppStoreConnect.AppMediaPreviewFrameImageStateState)

                    || typeToConvert == typeof(global::AppStoreConnect.AppMediaPreviewFrameImageStateState?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppMediaVideoStateState)

                    || typeToConvert == typeof(global::AppStoreConnect.AppMediaVideoStateState?)

                    || typeToConvert == typeof(global::AppStoreConnect.PreviewType)

                    || typeToConvert == typeof(global::AppStoreConnect.PreviewType?);
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

                if (typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPreviewSetTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPreviewSetTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppStoreVersionLocalizationDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPreviewSetRelationshipsAppStoreVersionLocalizationDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppStoreVersionLocalizationDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPreviewSetRelationshipsAppStoreVersionLocalizationDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppCustomProductPageLocalizationDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPreviewSetRelationshipsAppCustomProductPageLocalizationDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppCustomProductPageLocalizationDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPreviewSetRelationshipsAppCustomProductPageLocalizationDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPreviewSetRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPreviewSetRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppPreviewsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPreviewSetRelationshipsAppPreviewsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppPreviewsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPreviewSetRelationshipsAppPreviewsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetsResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPreviewSetsResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetsResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPreviewSetsResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPreviewType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPreviewTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPreviewType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPreviewTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPreviewRelationshipsAppPreviewSetDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPreviewRelationshipsAppPreviewSetDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPreviewRelationshipsAppPreviewSetDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPreviewRelationshipsAppPreviewSetDataTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.AppMediaPreviewFrameImageStateState))
                {
                    return new global::AppStoreConnect.JsonConverters.AppMediaPreviewFrameImageStateStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppMediaPreviewFrameImageStateState?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppMediaPreviewFrameImageStateStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppMediaVideoStateState))
                {
                    return new global::AppStoreConnect.JsonConverters.AppMediaVideoStateStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppMediaVideoStateState?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppMediaVideoStateStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PreviewType))
                {
                    return new global::AppStoreConnect.JsonConverters.PreviewTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PreviewType?))
                {
                    return new global::AppStoreConnect.JsonConverters.PreviewTypeNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.AppMediaPreviewFrameImageState))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppMediaPreviewFrameImageState(options);
                }
                if (type == typeof(global::AppStoreConnect.AppMediaPreviewFrameImageStateState))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppMediaPreviewFrameImageStateState2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppMediaStateError))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppMediaStateError(options);
                }
                if (type == typeof(global::AppStoreConnect.AppMediaVideoState))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppMediaVideoState(options);
                }
                if (type == typeof(global::AppStoreConnect.AppMediaVideoStateState))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppMediaVideoStateState2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPreview))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppPreview(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPreviewAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppPreviewAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPreviewRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppPreviewRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPreviewRelationshipsAppPreviewSet))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppPreviewRelationshipsAppPreviewSet(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPreviewRelationshipsAppPreviewSetData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppPreviewRelationshipsAppPreviewSetData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPreviewRelationshipsAppPreviewSetDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppPreviewRelationshipsAppPreviewSetDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPreviewSet))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppPreviewSet(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPreviewSetAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppPreviewSetAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPreviewSetRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppPreviewSetRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppCustomProductPageLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppPreviewSetRelationshipsAppCustomProductPageLocalization(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppCustomProductPageLocalizationData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppPreviewSetRelationshipsAppCustomProductPageLocalizationData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppCustomProductPageLocalizationDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppPreviewSetRelationshipsAppCustomProductPageLocalizationDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppPreviews))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppPreviewSetRelationshipsAppPreviews(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppPreviewsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppPreviewSetRelationshipsAppPreviewsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppPreviewsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppPreviewSetRelationshipsAppPreviewsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppStoreVersionExperimentTreatmentLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppPreviewSetRelationshipsAppStoreVersionExperimentTreatmentLocalization(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppStoreVersionExperimentTreatmentLocalizationData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppPreviewSetRelationshipsAppStoreVersionExperimentTreatmentLocalizationData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppPreviewSetRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppStoreVersionLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppPreviewSetRelationshipsAppStoreVersionLocalization(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppStoreVersionLocalizationData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppPreviewSetRelationshipsAppStoreVersionLocalizationData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppStoreVersionLocalizationDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppPreviewSetRelationshipsAppStoreVersionLocalizationDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPreviewSetType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppPreviewSetType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPreviewSetsResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppPreviewSetsResponse(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPreviewSetsResponseIncludedItemDiscriminator))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppPreviewSetsResponseIncludedItemDiscriminator(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPreviewSetsResponseIncludedItemDiscriminatorType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppPreviewSetsResponseIncludedItemDiscriminatorType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPreviewType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppPreviewType2(options);
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
                if (type == typeof(global::AppStoreConnect.IncludedItem26))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_IncludedItem262(options);
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
                if (type == typeof(global::AppStoreConnect.PreviewFrameImage))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_PreviewFrameImage(options);
                }
                if (type == typeof(global::AppStoreConnect.PreviewType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_PreviewType2(options);
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
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppPreviewSet>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_AF34E744D35D7A4B(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppPreviewSetRelationshipsAppPreviewsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_4BB56D8B59D9CB0F(options);
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
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem26>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_1CB9CE8C5FD196F3(options);
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
                if (type == typeof(global::AppStoreConnect.AppMediaPreviewFrameImageStateState?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppMediaPreviewFrameImageStateState2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppMediaVideoStateState?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppMediaVideoStateState2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPreviewRelationshipsAppPreviewSetDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppPreviewRelationshipsAppPreviewSetDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppCustomProductPageLocalizationDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppPreviewSetRelationshipsAppCustomProductPageLocalizationDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppPreviewsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppPreviewSetRelationshipsAppPreviewsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppPreviewSetRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppStoreVersionLocalizationDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppPreviewSetRelationshipsAppStoreVersionLocalizationDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPreviewSetType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppPreviewSetType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPreviewSetsResponseIncludedItemDiscriminatorType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppPreviewSetsResponseIncludedItemDiscriminatorType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPreviewType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppPreviewType2(options);
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
                if (type == typeof(global::AppStoreConnect.IncludedItem26?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableIncludedItem262(options);
                }
                if (type == typeof(global::AppStoreConnect.PreviewType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullablePreviewType2(options);
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
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppPreviewSet>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_61AC7C01B5CA8F08(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppPreviewSetRelationshipsAppPreviewsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_3F2B28C49ACDDCD0(options);
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
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem26>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_0F802B1CD910E5C8(options);
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