
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_72D6B7EDF04B771A : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_72D6B7EDF04B771A Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_72D6B7EDF04B771A(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppStoreVersionLocalizationDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppStoreVersionLocalizationDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppCustomProductPageLocalizationDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppCustomProductPageLocalizationDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppPreviewsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetRelationshipsAppPreviewsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewRelationshipsAppPreviewSetDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewRelationshipsAppPreviewSetDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState)

                    || typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppMediaPreviewFrameImageStateState)

                    || typeToConvert == typeof(global::AppStoreConnect.AppMediaPreviewFrameImageStateState?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppMediaVideoStateState)

                    || typeToConvert == typeof(global::AppStoreConnect.AppMediaVideoStateState?)

                    || typeToConvert == typeof(global::AppStoreConnect.PreviewType)

                    || typeToConvert == typeof(global::AppStoreConnect.PreviewType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreview)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreview?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreviewSet)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreviewSet?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetsAppPreviewsGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetsAppPreviewsGetToManyRelatedIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
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

                if (typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreview))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreviewJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreview?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreviewNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreviewSet))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreviewSetJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreviewSet?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreviewSetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetsAppPreviewsGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPreviewSetsAppPreviewsGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPreviewSetsAppPreviewsGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPreviewSetsAppPreviewsGetToManyRelatedIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreview))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreview2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreviewSet))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreviewSet2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPreviewSetsAppPreviewsGetToManyRelatedIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppPreviewSetsAppPreviewsGetToManyRelatedIncludeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPreviewType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppPreviewType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPreviewsResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppPreviewsResponse(options);
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
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppMediaStateError>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_7E9D192989E995BF(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppPreview>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_DFF57424770CD489(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppPreviewSet>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_AF34E744D35D7A4B(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppPreviewSetRelationshipsAppPreviewsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_4BB56D8B59D9CB0F(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreview>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_091350810971AB24(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreviewSet>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_E00C5DFAADF42DB2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppPreviewSetsAppPreviewsGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_64DA5B0F48EB6B4B(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.HttpHeader>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_BCE13B3326F5CA8F(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.UploadOperation>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_A918B5AE31119789(options);
                }
                if (type == typeof(int))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Int32(options);
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
                if (type == typeof(global::AppStoreConnect.AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreview?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreview2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreviewSet?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreviewSet2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPreviewSetsAppPreviewsGetToManyRelatedIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppPreviewSetsAppPreviewsGetToManyRelatedIncludeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppPreviewType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppPreviewType2(options);
                }
                if (type == typeof(global::AppStoreConnect.PreviewType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullablePreviewType2(options);
                }
                if (type == typeof(int?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppMediaStateError>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_AE112F1FF3B11297(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppPreview>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_272DAC3F817C1DF1(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppPreviewSet>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_61AC7C01B5CA8F08(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppPreviewSetRelationshipsAppPreviewsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_3F2B28C49ACDDCD0(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreview>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_525681B31913AE7A(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreviewSet>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_6511B9EBAC54FE81(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppPreviewSetsAppPreviewsGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_139501B7B211395A(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.HttpHeader>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_1947F16F30F1622D(options);
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