
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_2EE5E96D7D79B92E : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_2EE5E96D7D79B92E Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_2EE5E96D7D79B92E(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem15JsonConverter());
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

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageVersionType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageVersionType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageVersionAttributesState)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageVersionAttributesState?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageVersionRelationshipsAppCustomProductPageDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageVersionRelationshipsAppCustomProductPageDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageVersionRelationshipsAppCustomProductPageLocalizationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageVersionRelationshipsAppCustomProductPageLocalizationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageVersionsResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageVersionsResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageRelationshipsAppDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageRelationshipsAppDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageRelationshipsAppCustomProductPageVersionsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageRelationshipsAppCustomProductPageVersionsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFilterStateItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFilterStateItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPageVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPageVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPage)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPage?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPageLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPageLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedIncludeItem?);
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

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageVersionsResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageVersionsResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageVersionsResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageVersionsResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageRelationshipsAppDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageRelationshipsAppDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageRelationshipsAppDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageRelationshipsAppDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageRelationshipsAppCustomProductPageVersionsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageRelationshipsAppCustomProductPageVersionsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageRelationshipsAppCustomProductPageVersionsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageRelationshipsAppCustomProductPageVersionsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFilterStateItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFilterStateItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFilterStateItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFilterStateItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPageVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPageVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPageVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPageVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPage))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPageJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPage?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPageLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPageLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPageLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPageLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.AppCustomProductPage))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPage(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageAttributes(options);
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
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageRelationshipsApp))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageRelationshipsApp(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageRelationshipsAppCustomProductPageVersions))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageRelationshipsAppCustomProductPageVersions(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageRelationshipsAppCustomProductPageVersionsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageRelationshipsAppCustomProductPageVersionsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageRelationshipsAppCustomProductPageVersionsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageRelationshipsAppCustomProductPageVersionsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageRelationshipsAppData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageRelationshipsAppData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageRelationshipsAppDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageRelationshipsAppDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageType2(options);
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
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageVersionsResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageVersionsResponse(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageVersionsResponseIncludedItemDiscriminator))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageVersionsResponseIncludedItemDiscriminator(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageVersionsResponseIncludedItemDiscriminatorType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageVersionsResponseIncludedItemDiscriminatorType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPage))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPage2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPageLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPageLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPageVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPageVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFilterStateItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFilterStateItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedIncludeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.IncludedItem15))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_IncludedItem152_3(options);
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
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageRelationshipsAppCustomProductPageVersionsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_68A12E035EEC3B13(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_BF146ED18B20441B(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageVersionRelationshipsAppCustomProductPageLocalizationsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_8B3055F378C780EF(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPage>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_6BF4CDC47AC36DC2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPageLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_6CF10CE5A41F18BA(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPageVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_95A091DE57FEB4AE(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFilterStateItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_7BBE5D494506F8D4(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_35A8383E6F103A90(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem15>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_B6C92BFA4A59B289(options);
                }
                if (type == typeof(int))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(bool?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBoolean(options);
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
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageRelationshipsAppCustomProductPageVersionsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppCustomProductPageRelationshipsAppCustomProductPageVersionsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageRelationshipsAppDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppCustomProductPageRelationshipsAppDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppCustomProductPageType2(options);
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
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageVersionsResponseIncludedItemDiscriminatorType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppCustomProductPageVersionsResponseIncludedItemDiscriminatorType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPage?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPage2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPageLocalization?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPageLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPageVersion?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPageVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFilterStateItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFilterStateItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedIncludeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.IncludedItem15?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableIncludedItem152_3(options);
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
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppCustomProductPageRelationshipsAppCustomProductPageVersionsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_B1EA4F3920D398CE(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppCustomProductPageVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_CEAA3C45D52C874E(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppCustomProductPageVersionRelationshipsAppCustomProductPageLocalizationsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_B4406330A2D7E596(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPage>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_C877D73F2FC9236E(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPageLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_E4EB93F8AE981928(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPageVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_3784DBD23874D4F2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFilterStateItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_B07B65341BC4A952(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_B16D37C3E66C0463(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem15>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_CC79DCE292B44F5E(options);
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