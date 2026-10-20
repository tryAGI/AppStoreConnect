
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_3A898D6D3462766D : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_3A898D6D3462766D Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_3A898D6D3462766D(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.AttributesJsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.AppAssetLibraryImageAcceptedAttributesJsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.AppAssetLibraryImageApprovedAttributesJsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.AppAssetLibraryImageArchivedAttributesJsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.AppAssetLibraryImageAwaitingUploadAttributesJsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.AppAssetLibraryImageFailedAttributesJsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.AppAssetLibraryImageInReviewAttributesJsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.AppAssetLibraryImageReadyForReviewAttributesJsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.AppAssetLibraryImageRejectedAttributesJsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.AppAssetLibraryImageUploadCompleteAttributesJsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.AppAssetLibraryImageWaitingForReviewAttributesJsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.RelationshipsJsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementImageRelationshipsJsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementVideoRelationshipsJsonConverter());
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
                    typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryImageType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryImageType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryImageAttributesDiscriminatorState)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryImageAttributesDiscriminatorState?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryImageRelationshipsPlacementsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryImageRelationshipsPlacementsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryPlacementType)

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

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibrariesImagesGetToManyRelatedFilterCategoryItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibrariesImagesGetToManyRelatedFilterCategoryItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibrariesImagesGetToManyRelatedFilterStateItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibrariesImagesGetToManyRelatedFilterStateItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibrariesImagesGetToManyRelatedSortItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibrariesImagesGetToManyRelatedSortItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryImage)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryImage?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryPlacement)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryPlacement?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibrariesImagesGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAssetLibrariesImagesGetToManyRelatedIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryImageType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryImageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryImageType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryImageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryImageAttributesDiscriminatorState))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryImageAttributesDiscriminatorStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryImageAttributesDiscriminatorState?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryImageAttributesDiscriminatorStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryImageRelationshipsPlacementsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryImageRelationshipsPlacementsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibraryImageRelationshipsPlacementsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibraryImageRelationshipsPlacementsDataItemTypeNullableJsonConverter();
                }

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

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibrariesImagesGetToManyRelatedFilterCategoryItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibrariesImagesGetToManyRelatedFilterCategoryItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibrariesImagesGetToManyRelatedFilterCategoryItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibrariesImagesGetToManyRelatedFilterCategoryItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibrariesImagesGetToManyRelatedFilterStateItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibrariesImagesGetToManyRelatedFilterStateItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibrariesImagesGetToManyRelatedFilterStateItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibrariesImagesGetToManyRelatedFilterStateItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibrariesImagesGetToManyRelatedSortItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibrariesImagesGetToManyRelatedSortItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibrariesImagesGetToManyRelatedSortItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibrariesImagesGetToManyRelatedSortItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryImage))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryImageJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryImage?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryImageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryPlacement))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryPlacementJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryPlacement?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryPlacementNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibrariesImagesGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibrariesImagesGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAssetLibrariesImagesGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAssetLibrariesImagesGetToManyRelatedIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryImage))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryImage2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryPlacement))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryPlacement2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibrariesImagesGetToManyRelatedFilterCategoryItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppAssetLibrariesImagesGetToManyRelatedFilterCategoryItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibrariesImagesGetToManyRelatedFilterStateItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppAssetLibrariesImagesGetToManyRelatedFilterStateItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibrariesImagesGetToManyRelatedIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppAssetLibrariesImagesGetToManyRelatedIncludeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibrariesImagesGetToManyRelatedSortItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppAssetLibrariesImagesGetToManyRelatedSortItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryAssetCategory))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryAssetCategory2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryAssetState))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryAssetState2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImage))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryImage(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImageAcceptedAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryImageAcceptedAttributes2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImageApprovedAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryImageApprovedAttributes2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImageArchivedAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryImageArchivedAttributes2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImageAttributesDiscriminator))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryImageAttributesDiscriminator(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImageAttributesDiscriminatorState))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryImageAttributesDiscriminatorState2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImageAwaitingUploadAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryImageAwaitingUploadAttributes2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImageAwaitingUploadAttributesVariant2))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryImageAwaitingUploadAttributesVariant2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImageCommonAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryImageCommonAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImageFailedAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryImageFailedAttributes2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImageFailedAttributesVariant2))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryImageFailedAttributesVariant2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImageInReviewAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryImageInReviewAttributes2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImageReadyForReviewAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryImageReadyForReviewAttributes2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImageRejectedAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryImageRejectedAttributes2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImageRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryImageRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImageRelationshipsPlacements))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryImageRelationshipsPlacements(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImageRelationshipsPlacementsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryImageRelationshipsPlacementsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImageRelationshipsPlacementsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryImageRelationshipsPlacementsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImageType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryImageType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImageUploadCompleteAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryImageUploadCompleteAttributes2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImageUploadCompleteAttributesVariant2))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryImageUploadCompleteAttributesVariant2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImageWaitingForReviewAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryImageWaitingForReviewAttributes2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImagesResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAssetLibraryImagesResponse(options);
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
                if (type == typeof(global::AppStoreConnect.Attributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Attributes2_3(options);
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
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryImage>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_013F228872482336(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryPlacement>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_6D9E523446B0798F(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibrariesImagesGetToManyRelatedFilterCategoryItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_D4FBE559330B2ABE(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibrariesImagesGetToManyRelatedFilterStateItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_B3D465AE2F4F85DF(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibrariesImagesGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_129BD9305A76B5C6(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibrariesImagesGetToManyRelatedSortItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_40E45E1D2661D92B(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryImage>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_08BE8E3B24B5C0D2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryImageRelationshipsPlacementsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_BD3FAD72EED6E789(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryPlacement>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_463F6F8D0614F6D0(options);
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
                if (type == typeof(global::AppStoreConnect.AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryImage?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryImage2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryPlacement?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryPlacement2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibrariesImagesGetToManyRelatedFilterCategoryItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppAssetLibrariesImagesGetToManyRelatedFilterCategoryItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibrariesImagesGetToManyRelatedFilterStateItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppAssetLibrariesImagesGetToManyRelatedFilterStateItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibrariesImagesGetToManyRelatedIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppAssetLibrariesImagesGetToManyRelatedIncludeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibrariesImagesGetToManyRelatedSortItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppAssetLibrariesImagesGetToManyRelatedSortItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryAssetCategory?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAssetLibraryAssetCategory2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryAssetState?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAssetLibraryAssetState2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImageAcceptedAttributes?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAssetLibraryImageAcceptedAttributes2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImageApprovedAttributes?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAssetLibraryImageApprovedAttributes2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImageArchivedAttributes?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAssetLibraryImageArchivedAttributes2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImageAttributesDiscriminatorState?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAssetLibraryImageAttributesDiscriminatorState2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImageAwaitingUploadAttributes?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAssetLibraryImageAwaitingUploadAttributes2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImageFailedAttributes?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAssetLibraryImageFailedAttributes2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImageInReviewAttributes?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAssetLibraryImageInReviewAttributes2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImageReadyForReviewAttributes?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAssetLibraryImageReadyForReviewAttributes2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImageRejectedAttributes?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAssetLibraryImageRejectedAttributes2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImageRelationshipsPlacementsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAssetLibraryImageRelationshipsPlacementsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImageType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAssetLibraryImageType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImageUploadCompleteAttributes?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAssetLibraryImageUploadCompleteAttributes2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAssetLibraryImageWaitingForReviewAttributes?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAssetLibraryImageWaitingForReviewAttributes2(options);
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
                if (type == typeof(global::AppStoreConnect.Attributes?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAttributes2_3(options);
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
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryImage>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_1F8B670948DE2ED6(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryPlacement>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_074F56760AF6CF1B(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppAssetLibrariesImagesGetToManyRelatedFilterCategoryItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_BC46C2907AB3506D(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppAssetLibrariesImagesGetToManyRelatedFilterStateItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_5950E17E777CFE7A(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppAssetLibrariesImagesGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_61804DE133C903CC(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppAssetLibrariesImagesGetToManyRelatedSortItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_2A353918AD7B9C50(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppAssetLibraryImage>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_394B794F20CBECE8(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppAssetLibraryImageRelationshipsPlacementsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_79DF8A28416EAA7A(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppAssetLibraryPlacement>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_8E7607241084AB92(options);
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