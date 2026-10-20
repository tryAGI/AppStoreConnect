
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_56FBB911F4B0A2C0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_56FBB911F4B0A2C0 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_56FBB911F4B0A2C0(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppStoreVersionLocalizationDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppStoreVersionLocalizationDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppCustomProductPageLocalizationDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppCustomProductPageLocalizationDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppScreenshotsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetRelationshipsAppScreenshotsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppScreenshotType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppScreenshotType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppScreenshotRelationshipsAppScreenshotSetDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppScreenshotRelationshipsAppScreenshotSetDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState)

                    || typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState?)

                    || typeToConvert == typeof(global::AppStoreConnect.ScreenshotDisplayType)

                    || typeToConvert == typeof(global::AppStoreConnect.ScreenshotDisplayType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetsAppScreenshotsGetToManyRelatedFieldsAppScreenshot)

                    || typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetsAppScreenshotsGetToManyRelatedFieldsAppScreenshot?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetsAppScreenshotsGetToManyRelatedFieldsAppScreenshotSet)

                    || typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetsAppScreenshotsGetToManyRelatedFieldsAppScreenshotSet?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetsAppScreenshotsGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetsAppScreenshotsGetToManyRelatedIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
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

                if (typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetsAppScreenshotsGetToManyRelatedFieldsAppScreenshot))
                {
                    return new global::AppStoreConnect.JsonConverters.AppScreenshotSetsAppScreenshotsGetToManyRelatedFieldsAppScreenshotJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetsAppScreenshotsGetToManyRelatedFieldsAppScreenshot?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppScreenshotSetsAppScreenshotsGetToManyRelatedFieldsAppScreenshotNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetsAppScreenshotsGetToManyRelatedFieldsAppScreenshotSet))
                {
                    return new global::AppStoreConnect.JsonConverters.AppScreenshotSetsAppScreenshotsGetToManyRelatedFieldsAppScreenshotSetJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetsAppScreenshotsGetToManyRelatedFieldsAppScreenshotSet?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppScreenshotSetsAppScreenshotsGetToManyRelatedFieldsAppScreenshotSetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetsAppScreenshotsGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppScreenshotSetsAppScreenshotsGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppScreenshotSetsAppScreenshotsGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppScreenshotSetsAppScreenshotsGetToManyRelatedIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.AppScreenshotSetsAppScreenshotsGetToManyRelatedFieldsAppScreenshot))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppScreenshotSetsAppScreenshotsGetToManyRelatedFieldsAppScreenshot2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppScreenshotSetsAppScreenshotsGetToManyRelatedFieldsAppScreenshotSet))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppScreenshotSetsAppScreenshotsGetToManyRelatedFieldsAppScreenshotSet2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppScreenshotSetsAppScreenshotsGetToManyRelatedIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppScreenshotSetsAppScreenshotsGetToManyRelatedIncludeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppScreenshotType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppScreenshotType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppScreenshotsResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppScreenshotsResponse(options);
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
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppMediaStateError>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_7E9D192989E995BF(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppScreenshot>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_88DCEE612FF9EEDF(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppScreenshotSet>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_4E254350F8F86773(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppScreenshotSetRelationshipsAppScreenshotsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_B7B0A5ED1FD379A0(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppScreenshotSetsAppScreenshotsGetToManyRelatedFieldsAppScreenshot>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_D7D80AA8508F2C8D(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppScreenshotSetsAppScreenshotsGetToManyRelatedFieldsAppScreenshotSet>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_B1567002E2C155AA(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppScreenshotSetsAppScreenshotsGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_5EF4726EA80B6B34(options);
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
                if (type == typeof(global::AppStoreConnect.AppScreenshotSetsAppScreenshotsGetToManyRelatedFieldsAppScreenshot?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppScreenshotSetsAppScreenshotsGetToManyRelatedFieldsAppScreenshot2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppScreenshotSetsAppScreenshotsGetToManyRelatedFieldsAppScreenshotSet?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppScreenshotSetsAppScreenshotsGetToManyRelatedFieldsAppScreenshotSet2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppScreenshotSetsAppScreenshotsGetToManyRelatedIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppScreenshotSetsAppScreenshotsGetToManyRelatedIncludeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppScreenshotType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppScreenshotType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ScreenshotDisplayType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableScreenshotDisplayType2(options);
                }
                if (type == typeof(int?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppMediaStateError>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_AE112F1FF3B11297(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppScreenshot>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_639F0661A74EA505(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppScreenshotSet>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_D37A099C2A5881E6(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppScreenshotSetRelationshipsAppScreenshotsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_A227BCD6CED5CE38(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppScreenshotSetsAppScreenshotsGetToManyRelatedFieldsAppScreenshot>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_E6ED8ADC5725B90F(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppScreenshotSetsAppScreenshotsGetToManyRelatedFieldsAppScreenshotSet>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_40444FFCA0C153BF(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppScreenshotSetsAppScreenshotsGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_EB64A7D4E68B70B8(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.HttpHeader>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_1947F16F30F1622D(options);
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