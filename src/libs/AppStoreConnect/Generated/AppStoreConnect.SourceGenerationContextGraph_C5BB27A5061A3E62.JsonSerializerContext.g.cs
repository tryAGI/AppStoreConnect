
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_C5BB27A5061A3E62 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_C5BB27A5061A3E62 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_C5BB27A5061A3E62(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.Attributes2JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.AppAssetLibraryVideoAcceptedAttributesJsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.AppAssetLibraryVideoApprovedAttributesJsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.AppAssetLibraryVideoArchivedAttributesJsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.AppAssetLibraryVideoAwaitingUploadAttributesJsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.AppAssetLibraryVideoFailedAttributesJsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.AppAssetLibraryVideoInReviewAttributesJsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.AppAssetLibraryVideoReadyForReviewAttributesJsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.AppAssetLibraryVideoRejectedAttributesJsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.AppAssetLibraryVideoUploadCompleteAttributesJsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.AppAssetLibraryVideoWaitingForReviewAttributesJsonConverter());
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

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryVideoType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryVideoType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryVideoAttributesDiscriminatorState)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryVideoAttributesDiscriminatorState?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryVideoRelationshipsPlacementsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryVideoRelationshipsPlacementsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryAssetCategory)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryAssetCategory?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryAssetState)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryAssetState?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryMediaType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryMediaType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementState)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementState?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementType2)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementType2?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppMediaPreviewFrameImageStateState)

                    || typeToConvert == typeof(global::AppStoreConnect.AppMediaPreviewFrameImageStateState?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibrariesVideosGetToManyRelatedFilterCategoryItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibrariesVideosGetToManyRelatedFilterCategoryItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibrariesVideosGetToManyRelatedFilterStateItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibrariesVideosGetToManyRelatedFilterStateItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibrariesVideosGetToManyRelatedSortItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibrariesVideosGetToManyRelatedSortItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryVideo)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryVideo?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryPlacement)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryPlacement?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibrariesVideosGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibrariesVideosGetToManyRelatedIncludeItem?);
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

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryVideoType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryVideoTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryVideoType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryVideoTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryVideoAttributesDiscriminatorState))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryVideoAttributesDiscriminatorStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryVideoAttributesDiscriminatorState?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryVideoAttributesDiscriminatorStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryVideoRelationshipsPlacementsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryVideoRelationshipsPlacementsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryVideoRelationshipsPlacementsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryVideoRelationshipsPlacementsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryAssetCategory))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryAssetCategoryJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryAssetCategory?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryAssetCategoryNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryAssetState))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryAssetStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryAssetState?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryAssetStateNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.AppMediaPreviewFrameImageStateState))
                {
                    return new global::AppStoreConnect.JsonConverters.AppMediaPreviewFrameImageStateStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppMediaPreviewFrameImageStateState?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppMediaPreviewFrameImageStateStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibrariesVideosGetToManyRelatedFilterCategoryItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibrariesVideosGetToManyRelatedFilterCategoryItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibrariesVideosGetToManyRelatedFilterCategoryItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibrariesVideosGetToManyRelatedFilterCategoryItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibrariesVideosGetToManyRelatedFilterStateItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibrariesVideosGetToManyRelatedFilterStateItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibrariesVideosGetToManyRelatedFilterStateItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibrariesVideosGetToManyRelatedFilterStateItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibrariesVideosGetToManyRelatedSortItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibrariesVideosGetToManyRelatedSortItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibrariesVideosGetToManyRelatedSortItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibrariesVideosGetToManyRelatedSortItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryVideo))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryVideoJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryVideo?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryVideoNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryPlacement))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryPlacementJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryPlacement?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryPlacementNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibrariesVideosGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibrariesVideosGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibrariesVideosGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibrariesVideosGetToManyRelatedIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryPlacement))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryPlacement2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryVideo))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryVideo2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibrariesVideosGetToManyRelatedFilterCategoryItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppAssetLibrariesVideosGetToManyRelatedFilterCategoryItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibrariesVideosGetToManyRelatedFilterStateItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppAssetLibrariesVideosGetToManyRelatedFilterStateItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibrariesVideosGetToManyRelatedIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppAssetLibrariesVideosGetToManyRelatedIncludeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibrariesVideosGetToManyRelatedSortItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppAssetLibrariesVideosGetToManyRelatedSortItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryAssetCategory))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryAssetCategory2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryAssetState))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryAssetState2(options);
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
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryVideo))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryVideo(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryVideoAcceptedAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryVideoAcceptedAttributes2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryVideoApprovedAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryVideoApprovedAttributes2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryVideoArchivedAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryVideoArchivedAttributes2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryVideoAttributesDiscriminator))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryVideoAttributesDiscriminator(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryVideoAttributesDiscriminatorState))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryVideoAttributesDiscriminatorState2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryVideoAwaitingUploadAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryVideoAwaitingUploadAttributes2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryVideoAwaitingUploadAttributesVariant2))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryVideoAwaitingUploadAttributesVariant2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryVideoCommonAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryVideoFailedAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryVideoFailedAttributes2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryVideoFailedAttributesVariant2))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryVideoFailedAttributesVariant2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryVideoInReviewAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryVideoInReviewAttributes2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryVideoReadyForReviewAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryVideoReadyForReviewAttributes2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryVideoRejectedAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryVideoRejectedAttributes2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryVideoRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryVideoRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryVideoRelationshipsPlacements))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryVideoRelationshipsPlacements(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryVideoRelationshipsPlacementsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryVideoRelationshipsPlacementsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryVideoRelationshipsPlacementsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryVideoRelationshipsPlacementsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryVideoType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryVideoType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryVideoUploadCompleteAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryVideoUploadCompleteAttributes2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryVideoUploadCompleteAttributesVariant2))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryVideoUploadCompleteAttributesVariant2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryVideoWaitingForReviewAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryVideoWaitingForReviewAttributes2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryVideosResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryVideosResponse(options);
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
                if (type == typeof(global::AppStoreConnect.Attributes2))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Attributes22(options);
                }
                if (type == typeof(global::AppStoreConnect.HttpHeader))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_HttpHeader(options);
                }
                if (type == typeof(global::AppStoreConnect.ImageAsset))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_ImageAsset(options);
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
                if (type == typeof(global::AppStoreConnect.StateDetail))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_StateDetail(options);
                }
                if (type == typeof(global::AppStoreConnect.UploadOperation))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_UploadOperation(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryPlacement>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_9839A25C328DA1DE(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryVideo>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_FDAA73A5CF4722B9(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibrariesVideosGetToManyRelatedFilterCategoryItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_C2C1672E6AFA993D(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibrariesVideosGetToManyRelatedFilterStateItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_37AF82CCD830EF19(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibrariesVideosGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_FCE047B4EE8CC591(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibrariesVideosGetToManyRelatedSortItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_352B442CE213870A(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryPlacement>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_463F6F8D0614F6D0(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryVideo>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_0F8C4068BA07093E(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryVideoRelationshipsPlacementsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_254A67E9A407C6E1(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppMediaStateError>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_7E9D192989E995BF(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.HttpHeader>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_BCE13B3326F5CA8F(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.StateDetail>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_E0931479E69985D5(options);
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
                if (type == typeof(long))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Int64(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryPlacement?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryPlacement2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryVideo?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryVideo2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibrariesVideosGetToManyRelatedFilterCategoryItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppAssetLibrariesVideosGetToManyRelatedFilterCategoryItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibrariesVideosGetToManyRelatedFilterStateItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppAssetLibrariesVideosGetToManyRelatedFilterStateItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibrariesVideosGetToManyRelatedIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppAssetLibrariesVideosGetToManyRelatedIncludeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibrariesVideosGetToManyRelatedSortItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppAssetLibrariesVideosGetToManyRelatedSortItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryAssetCategory?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAssetLibraryAssetCategory2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryAssetState?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAssetLibraryAssetState2(options);
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
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryVideoAcceptedAttributes?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAssetLibraryVideoAcceptedAttributes2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryVideoApprovedAttributes?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAssetLibraryVideoApprovedAttributes2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryVideoArchivedAttributes?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAssetLibraryVideoArchivedAttributes2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryVideoAttributesDiscriminatorState?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAssetLibraryVideoAttributesDiscriminatorState2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryVideoAwaitingUploadAttributes?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAssetLibraryVideoAwaitingUploadAttributes2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryVideoFailedAttributes?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAssetLibraryVideoFailedAttributes2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryVideoInReviewAttributes?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAssetLibraryVideoInReviewAttributes2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryVideoReadyForReviewAttributes?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAssetLibraryVideoReadyForReviewAttributes2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryVideoRejectedAttributes?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAssetLibraryVideoRejectedAttributes2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryVideoRelationshipsPlacementsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAssetLibraryVideoRelationshipsPlacementsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryVideoType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAssetLibraryVideoType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryVideoUploadCompleteAttributes?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAssetLibraryVideoUploadCompleteAttributes2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryVideoWaitingForReviewAttributes?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAssetLibraryVideoWaitingForReviewAttributes2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppMediaPreviewFrameImageStateState?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppMediaPreviewFrameImageStateState2(options);
                }
                if (type == typeof(global::AppStoreConnect.Attributes2?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAttributes22(options);
                }
                if (type == typeof(global::AppStoreConnect.Relationships?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableRelationships2(options);
                }
                if (type == typeof(global::System.DateTime?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableDateTime(options);
                }
                if (type == typeof(int?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt32(options);
                }
                if (type == typeof(long?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt64(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryPlacement>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_B3E151B73D167447(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryVideo>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_54ECF0A8520F4203(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppAssetLibrariesVideosGetToManyRelatedFilterCategoryItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_BE979B329F77961D(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppAssetLibrariesVideosGetToManyRelatedFilterStateItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_189E13C5A9311DE8(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppAssetLibrariesVideosGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_4660C63ED0FF9E7A(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppAssetLibrariesVideosGetToManyRelatedSortItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_8AED5F645A1E9F3A(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppAssetLibraryPlacement>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_8E7607241084AB92(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppAssetLibraryVideo>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_90A10B9A308A4DC2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppAssetLibraryVideoRelationshipsPlacementsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_D6BDD2CE6B8C842E(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppMediaStateError>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_AE112F1FF3B11297(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.HttpHeader>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_1947F16F30F1622D(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.StateDetail>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_7D7569F841DF8E53(options);
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