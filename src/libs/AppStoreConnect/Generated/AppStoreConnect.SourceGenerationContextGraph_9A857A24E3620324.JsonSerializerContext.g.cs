
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_9A857A24E3620324 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_9A857A24E3620324 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_9A857A24E3620324(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.RelationshipsJsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementImageRelationshipsJsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementVideoRelationshipsJsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem14JsonConverter());
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
                    typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementRelationshipsDiscriminatorMediaType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementRelationshipsDiscriminatorMediaType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationshipsAppEventLocalizationDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationshipsAppEventLocalizationDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationshipsAppStoreVersionLocalizationDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationshipsAppStoreVersionLocalizationDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationshipsAppCustomProductPageLocalizationDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationshipsAppCustomProductPageLocalizationDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementImageRelationshipsVariant2ImageDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementImageRelationshipsVariant2ImageDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementVideoRelationshipsVariant2VideoDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementVideoRelationshipsVariant2VideoDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationType)

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

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageVersionType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageVersionType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageVersionAttributesState)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageVersionAttributesState?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageVersionRelationshipsAppCustomProductPageDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageVersionRelationshipsAppCustomProductPageDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageVersionRelationshipsAppCustomProductPageLocalizationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageVersionRelationshipsAppCustomProductPageLocalizationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppKeywordType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppKeywordType?)

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

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryMediaType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryMediaType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementState)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementState?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementType2)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementType2?)

                    || typeToConvert == typeof(global::AppStoreConnect.PreviewType)

                    || typeToConvert == typeof(global::AppStoreConnect.PreviewType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ScreenshotDisplayType)

                    || typeToConvert == typeof(global::AppStoreConnect.ScreenshotDisplayType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementRelationshipsDiscriminatorMediaType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementRelationshipsDiscriminatorMediaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementRelationshipsDiscriminatorMediaType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementRelationshipsDiscriminatorMediaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationshipsAppEventLocalizationDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementCommonRelationshipsAppEventLocalizationDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationshipsAppEventLocalizationDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementCommonRelationshipsAppEventLocalizationDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationshipsAppStoreVersionLocalizationDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementCommonRelationshipsAppStoreVersionLocalizationDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationshipsAppStoreVersionLocalizationDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementCommonRelationshipsAppStoreVersionLocalizationDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationshipsAppCustomProductPageLocalizationDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementCommonRelationshipsAppCustomProductPageLocalizationDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationshipsAppCustomProductPageLocalizationDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementCommonRelationshipsAppCustomProductPageLocalizationDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementCommonRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementCommonRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementImageRelationshipsVariant2ImageDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementImageRelationshipsVariant2ImageDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementImageRelationshipsVariant2ImageDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementImageRelationshipsVariant2ImageDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementVideoRelationshipsVariant2VideoDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementVideoRelationshipsVariant2VideoDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementVideoRelationshipsVariant2VideoDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementVideoRelationshipsVariant2VideoDataTypeNullableJsonConverter();
                }

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

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageLocalizationResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageLocalizationResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageVersionType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageVersionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageVersionType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageVersionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageVersionAttributesState))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageVersionAttributesStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageVersionAttributesState?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageVersionAttributesStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageVersionRelationshipsAppCustomProductPageDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageVersionRelationshipsAppCustomProductPageDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageVersionRelationshipsAppCustomProductPageDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageVersionRelationshipsAppCustomProductPageDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageVersionRelationshipsAppCustomProductPageLocalizationsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageVersionRelationshipsAppCustomProductPageLocalizationsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageVersionRelationshipsAppCustomProductPageLocalizationsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageVersionRelationshipsAppCustomProductPageLocalizationsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppKeywordType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppKeywordTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppKeywordType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppKeywordTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryMediaType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryMediaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryMediaType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryMediaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementState))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementState?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementType2))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementType2JsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementType2?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PreviewType))
                {
                    return new global::AppStoreConnect.JsonConverters.PreviewTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PreviewType?))
                {
                    return new global::AppStoreConnect.JsonConverters.PreviewTypeNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryMediaType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryMediaType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacement))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacement(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementCommonRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationshipsAppCustomProductPageLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementCommonRelationshipsAppCustomProductPageLocalization(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationshipsAppCustomProductPageLocalizationData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementCommonRelationshipsAppCustomProductPageLocalizationData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationshipsAppCustomProductPageLocalizationDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementCommonRelationshipsAppCustomProductPageLocalizationDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationshipsAppEventLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementCommonRelationshipsAppEventLocalization(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationshipsAppEventLocalizationData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementCommonRelationshipsAppEventLocalizationData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationshipsAppEventLocalizationDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementCommonRelationshipsAppEventLocalizationDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationshipsAppStoreVersionExperimentTreatmentLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementCommonRelationshipsAppStoreVersionExperimentTreatmentLocalization(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationshipsAppStoreVersionExperimentTreatmentLocalizationData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementCommonRelationshipsAppStoreVersionExperimentTreatmentLocalizationData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementCommonRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationshipsAppStoreVersionLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementCommonRelationshipsAppStoreVersionLocalization(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationshipsAppStoreVersionLocalizationData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementCommonRelationshipsAppStoreVersionLocalizationData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationshipsAppStoreVersionLocalizationDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementCommonRelationshipsAppStoreVersionLocalizationDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementImageRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementImageRelationships2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementImageRelationshipsVariant2))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementImageRelationshipsVariant2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementImageRelationshipsVariant2Image))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementImageRelationshipsVariant2Image(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementImageRelationshipsVariant2ImageData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementImageRelationshipsVariant2ImageData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementImageRelationshipsVariant2ImageDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementImageRelationshipsVariant2ImageDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementRelationshipsDiscriminator))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementRelationshipsDiscriminator(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementRelationshipsDiscriminatorMediaType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementRelationshipsDiscriminatorMediaType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementState))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementState2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementType2_3(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementType2))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementType22(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementVideoRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementVideoRelationships2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementVideoRelationshipsVariant2))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementVideoRelationshipsVariant2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementVideoRelationshipsVariant2Video))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementVideoRelationshipsVariant2Video(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementVideoRelationshipsVariant2VideoData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementVideoRelationshipsVariant2VideoData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementVideoRelationshipsVariant2VideoDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryPlacementVideoRelationshipsVariant2VideoDataType2(options);
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
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageLocalizationResponse(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationResponseIncludedItemDiscriminator))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageLocalizationResponseIncludedItemDiscriminator(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationResponseIncludedItemDiscriminatorType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageLocalizationResponseIncludedItemDiscriminatorType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageLocalizationType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageVersion(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageVersionAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageVersionAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageVersionAttributesState))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageVersionAttributesState2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageVersionRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageVersionRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageVersionRelationshipsAppCustomProductPage))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageVersionRelationshipsAppCustomProductPage(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageVersionRelationshipsAppCustomProductPageData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageVersionRelationshipsAppCustomProductPageData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageVersionRelationshipsAppCustomProductPageDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageVersionRelationshipsAppCustomProductPageDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageVersionRelationshipsAppCustomProductPageLocalizations))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageVersionRelationshipsAppCustomProductPageLocalizations(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageVersionRelationshipsAppCustomProductPageLocalizationsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageVersionRelationshipsAppCustomProductPageLocalizationsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageVersionRelationshipsAppCustomProductPageLocalizationsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageVersionRelationshipsAppCustomProductPageLocalizationsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageVersionType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageVersionType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppKeyword))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppKeyword(options);
                }
                if (type == typeof(global::AppStoreConnect.AppKeywordType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppKeywordType2(options);
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
                if (type == typeof(global::AppStoreConnect.DocumentLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_DocumentLinks(options);
                }
                if (type == typeof(global::AppStoreConnect.IncludedItem14))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_IncludedItem142(options);
                }
                if (type == typeof(global::AppStoreConnect.PagingInformation))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_PagingInformation(options);
                }
                if (type == typeof(global::AppStoreConnect.PagingInformationPaging))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_PagingInformationPaging(options);
                }
                if (type == typeof(global::AppStoreConnect.PreviewType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_PreviewType2(options);
                }
                if (type == typeof(global::AppStoreConnect.RelationshipLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_RelationshipLinks(options);
                }
                if (type == typeof(global::AppStoreConnect.Relationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Relationships2(options);
                }
                if (type == typeof(global::AppStoreConnect.ResourceLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_ResourceLinks(options);
                }
                if (type == typeof(global::AppStoreConnect.ScreenshotDisplayType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_ScreenshotDisplayType2(options);
                }
                if (type == typeof(global::AppStoreConnect.StateDetail))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_StateDetail(options);
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
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageVersionRelationshipsAppCustomProductPageLocalizationsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_8B3055F378C780EF(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppPreviewSetRelationshipsAppPreviewsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_4BB56D8B59D9CB0F(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppScreenshotSetRelationshipsAppScreenshotsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_B7B0A5ED1FD379A0(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem14>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_B0AECD635B643685(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.StateDetail>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_E0931479E69985D5(options);
                }
                if (type == typeof(global::System.DateTime))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_DateTime(options);
                }
                if (type == typeof(int))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryMediaType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAssetLibraryMediaType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationshipsAppCustomProductPageLocalizationDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAssetLibraryPlacementCommonRelationshipsAppCustomProductPageLocalizationDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationshipsAppEventLocalizationDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAssetLibraryPlacementCommonRelationshipsAppEventLocalizationDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAssetLibraryPlacementCommonRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementCommonRelationshipsAppStoreVersionLocalizationDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAssetLibraryPlacementCommonRelationshipsAppStoreVersionLocalizationDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementImageRelationships?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAssetLibraryPlacementImageRelationships2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementImageRelationshipsVariant2ImageDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAssetLibraryPlacementImageRelationshipsVariant2ImageDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementRelationshipsDiscriminatorMediaType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAssetLibraryPlacementRelationshipsDiscriminatorMediaType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementState?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAssetLibraryPlacementState2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAssetLibraryPlacementType2_3(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementType2?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAssetLibraryPlacementType22(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementVideoRelationships?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAssetLibraryPlacementVideoRelationships2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryPlacementVideoRelationshipsVariant2VideoDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAssetLibraryPlacementVideoRelationshipsVariant2VideoDataType2(options);
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
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationResponseIncludedItemDiscriminatorType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppCustomProductPageLocalizationResponseIncludedItemDiscriminatorType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppCustomProductPageLocalizationType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageVersionAttributesState?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppCustomProductPageVersionAttributesState2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageVersionRelationshipsAppCustomProductPageDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppCustomProductPageVersionRelationshipsAppCustomProductPageDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageVersionRelationshipsAppCustomProductPageLocalizationsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppCustomProductPageVersionRelationshipsAppCustomProductPageLocalizationsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageVersionType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppCustomProductPageVersionType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppKeywordType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppKeywordType2(options);
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
                if (type == typeof(global::AppStoreConnect.IncludedItem14?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableIncludedItem142(options);
                }
                if (type == typeof(global::AppStoreConnect.PreviewType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullablePreviewType2(options);
                }
                if (type == typeof(global::AppStoreConnect.Relationships?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableRelationships2(options);
                }
                if (type == typeof(global::AppStoreConnect.ScreenshotDisplayType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableScreenshotDisplayType2(options);
                }
                if (type == typeof(global::System.DateTime?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableDateTime(options);
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
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppCustomProductPageVersionRelationshipsAppCustomProductPageLocalizationsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_B4406330A2D7E596(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppPreviewSetRelationshipsAppPreviewsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_3F2B28C49ACDDCD0(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppScreenshotSetRelationshipsAppScreenshotsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_A227BCD6CED5CE38(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem14>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_CCCB788BD46C9C74(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.StateDetail>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_7D7569F841DF8E53(options);
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