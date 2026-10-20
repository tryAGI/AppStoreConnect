
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_487B28EB5D2EBAE0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_487B28EB5D2EBAE0 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_487B28EB5D2EBAE0(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.OneOfJsonConverter<global::AppStoreConnect.AppCustomProductPageLocalizationInlineCreate, global::AppStoreConnect.AppCustomProductPageVersionInlineCreate>());
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
                    typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationInlineCreateType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationInlineCreateType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationInlineCreateRelationshipsAppCustomProductPageVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationInlineCreateRelationshipsAppCustomProductPageVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationInlineCreateRelationshipsPlacementsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationInlineCreateRelationshipsPlacementsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageVersionInlineCreateType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageVersionInlineCreateType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageVersionInlineCreateRelationshipsAppCustomProductPageDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageVersionInlineCreateRelationshipsAppCustomProductPageDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageVersionInlineCreateRelationshipsAppCustomProductPageLocalizationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageVersionInlineCreateRelationshipsAppCustomProductPageLocalizationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageCreateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageCreateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageCreateRequestDataRelationshipsAppDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageCreateRequestDataRelationshipsAppDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageCreateRequestDataRelationshipsAppCustomProductPageVersionsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageCreateRequestDataRelationshipsAppCustomProductPageVersionsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageCreateRequestDataRelationshipsAppStoreVersionTemplateDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageCreateRequestDataRelationshipsAppStoreVersionTemplateDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageCreateRequestDataRelationshipsCustomProductPageTemplateDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageCreateRequestDataRelationshipsCustomProductPageTemplateDataType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationInlineCreateType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageLocalizationInlineCreateTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationInlineCreateType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageLocalizationInlineCreateTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationInlineCreateRelationshipsAppCustomProductPageVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageLocalizationInlineCreateRelationshipsAppCustomProductPageVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationInlineCreateRelationshipsAppCustomProductPageVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageLocalizationInlineCreateRelationshipsAppCustomProductPageVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationInlineCreateRelationshipsPlacementsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageLocalizationInlineCreateRelationshipsPlacementsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationInlineCreateRelationshipsPlacementsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageLocalizationInlineCreateRelationshipsPlacementsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageVersionInlineCreateType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageVersionInlineCreateTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageVersionInlineCreateType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageVersionInlineCreateTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageVersionInlineCreateRelationshipsAppCustomProductPageDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageVersionInlineCreateRelationshipsAppCustomProductPageDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageVersionInlineCreateRelationshipsAppCustomProductPageDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageVersionInlineCreateRelationshipsAppCustomProductPageDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageVersionInlineCreateRelationshipsAppCustomProductPageLocalizationsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageVersionInlineCreateRelationshipsAppCustomProductPageLocalizationsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageVersionInlineCreateRelationshipsAppCustomProductPageLocalizationsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageVersionInlineCreateRelationshipsAppCustomProductPageLocalizationsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageCreateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageCreateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageCreateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageCreateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageCreateRequestDataRelationshipsAppDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageCreateRequestDataRelationshipsAppDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageCreateRequestDataRelationshipsAppDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageCreateRequestDataRelationshipsAppDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageCreateRequestDataRelationshipsAppCustomProductPageVersionsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageCreateRequestDataRelationshipsAppCustomProductPageVersionsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageCreateRequestDataRelationshipsAppCustomProductPageVersionsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageCreateRequestDataRelationshipsAppCustomProductPageVersionsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageCreateRequestDataRelationshipsAppStoreVersionTemplateDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageCreateRequestDataRelationshipsAppStoreVersionTemplateDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageCreateRequestDataRelationshipsAppStoreVersionTemplateDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageCreateRequestDataRelationshipsAppStoreVersionTemplateDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageCreateRequestDataRelationshipsCustomProductPageTemplateDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageCreateRequestDataRelationshipsCustomProductPageTemplateDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageCreateRequestDataRelationshipsCustomProductPageTemplateDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageCreateRequestDataRelationshipsCustomProductPageTemplateDataTypeNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageCreateRequest))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageCreateRequest(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageCreateRequestData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageCreateRequestData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageCreateRequestDataAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageCreateRequestDataAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageCreateRequestDataRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageCreateRequestDataRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageCreateRequestDataRelationshipsApp))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageCreateRequestDataRelationshipsApp(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageCreateRequestDataRelationshipsAppCustomProductPageVersions))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageCreateRequestDataRelationshipsAppCustomProductPageVersions(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageCreateRequestDataRelationshipsAppCustomProductPageVersionsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageCreateRequestDataRelationshipsAppCustomProductPageVersionsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageCreateRequestDataRelationshipsAppCustomProductPageVersionsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageCreateRequestDataRelationshipsAppCustomProductPageVersionsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageCreateRequestDataRelationshipsAppData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageCreateRequestDataRelationshipsAppData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageCreateRequestDataRelationshipsAppDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageCreateRequestDataRelationshipsAppDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageCreateRequestDataRelationshipsAppStoreVersionTemplate))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageCreateRequestDataRelationshipsAppStoreVersionTemplate(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageCreateRequestDataRelationshipsAppStoreVersionTemplateData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageCreateRequestDataRelationshipsAppStoreVersionTemplateData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageCreateRequestDataRelationshipsAppStoreVersionTemplateDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageCreateRequestDataRelationshipsAppStoreVersionTemplateDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageCreateRequestDataRelationshipsCustomProductPageTemplate))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageCreateRequestDataRelationshipsCustomProductPageTemplate(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageCreateRequestDataRelationshipsCustomProductPageTemplateData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageCreateRequestDataRelationshipsCustomProductPageTemplateData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageCreateRequestDataRelationshipsCustomProductPageTemplateDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageCreateRequestDataRelationshipsCustomProductPageTemplateDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageCreateRequestDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageCreateRequestDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationInlineCreate))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageLocalizationInlineCreate(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationInlineCreateAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageLocalizationInlineCreateAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationInlineCreateRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageLocalizationInlineCreateRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationInlineCreateRelationshipsAppCustomProductPageVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageLocalizationInlineCreateRelationshipsAppCustomProductPageVersion(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationInlineCreateRelationshipsAppCustomProductPageVersionData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageLocalizationInlineCreateRelationshipsAppCustomProductPageVersionData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationInlineCreateRelationshipsAppCustomProductPageVersionDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageLocalizationInlineCreateRelationshipsAppCustomProductPageVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationInlineCreateRelationshipsPlacements))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageLocalizationInlineCreateRelationshipsPlacements(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationInlineCreateRelationshipsPlacementsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageLocalizationInlineCreateRelationshipsPlacementsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationInlineCreateRelationshipsPlacementsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageLocalizationInlineCreateRelationshipsPlacementsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationInlineCreateType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageLocalizationInlineCreateType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageVersionInlineCreate))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageVersionInlineCreate(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageVersionInlineCreateAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageVersionInlineCreateAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageVersionInlineCreateRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageVersionInlineCreateRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageVersionInlineCreateRelationshipsAppCustomProductPage))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageVersionInlineCreateRelationshipsAppCustomProductPage(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageVersionInlineCreateRelationshipsAppCustomProductPageData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageVersionInlineCreateRelationshipsAppCustomProductPageData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageVersionInlineCreateRelationshipsAppCustomProductPageDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageVersionInlineCreateRelationshipsAppCustomProductPageDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageVersionInlineCreateRelationshipsAppCustomProductPageLocalizations))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageVersionInlineCreateRelationshipsAppCustomProductPageLocalizations(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageVersionInlineCreateRelationshipsAppCustomProductPageLocalizationsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageVersionInlineCreateRelationshipsAppCustomProductPageLocalizationsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageVersionInlineCreateRelationshipsAppCustomProductPageLocalizationsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageVersionInlineCreateRelationshipsAppCustomProductPageLocalizationsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageVersionInlineCreateType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageVersionInlineCreateType2(options);
                }
                if (type == typeof(global::AppStoreConnect.OneOf<global::AppStoreConnect.AppCustomProductPageLocalizationInlineCreate, global::AppStoreConnect.AppCustomProductPageVersionInlineCreate>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_FD25C7B8DF230A10(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageCreateRequestDataRelationshipsAppCustomProductPageVersionsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_3DCD5FC41E93E521(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageLocalizationInlineCreateRelationshipsPlacementsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_AB651F8673E7DC95(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageVersionInlineCreateRelationshipsAppCustomProductPageLocalizationsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_F5C7321204158DC2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.OneOf<global::AppStoreConnect.AppCustomProductPageLocalizationInlineCreate, global::AppStoreConnect.AppCustomProductPageVersionInlineCreate>>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_1B3845F0B2F658D0(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageCreateRequestDataRelationshipsAppCustomProductPageVersionsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppCustomProductPageCreateRequestDataRelationshipsAppCustomProductPageVersionsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageCreateRequestDataRelationshipsAppDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppCustomProductPageCreateRequestDataRelationshipsAppDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageCreateRequestDataRelationshipsAppStoreVersionTemplateDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppCustomProductPageCreateRequestDataRelationshipsAppStoreVersionTemplateDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageCreateRequestDataRelationshipsCustomProductPageTemplateDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppCustomProductPageCreateRequestDataRelationshipsCustomProductPageTemplateDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageCreateRequestDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppCustomProductPageCreateRequestDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationInlineCreateRelationshipsAppCustomProductPageVersionDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppCustomProductPageLocalizationInlineCreateRelationshipsAppCustomProductPageVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationInlineCreateRelationshipsPlacementsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppCustomProductPageLocalizationInlineCreateRelationshipsPlacementsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageLocalizationInlineCreateType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppCustomProductPageLocalizationInlineCreateType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageVersionInlineCreateRelationshipsAppCustomProductPageDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppCustomProductPageVersionInlineCreateRelationshipsAppCustomProductPageDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageVersionInlineCreateRelationshipsAppCustomProductPageLocalizationsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppCustomProductPageVersionInlineCreateRelationshipsAppCustomProductPageLocalizationsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageVersionInlineCreateType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppCustomProductPageVersionInlineCreateType2(options);
                }
                if (type == typeof(global::AppStoreConnect.OneOf<global::AppStoreConnect.AppCustomProductPageLocalizationInlineCreate, global::AppStoreConnect.AppCustomProductPageVersionInlineCreate>?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_A40983548D3754FF(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppCustomProductPageCreateRequestDataRelationshipsAppCustomProductPageVersionsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_86A8AF69BD61F4BF(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppCustomProductPageLocalizationInlineCreateRelationshipsPlacementsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_B6068C9D451819DC(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppCustomProductPageVersionInlineCreateRelationshipsAppCustomProductPageLocalizationsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_F68D0E2323F1D297(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.OneOf<global::AppStoreConnect.AppCustomProductPageLocalizationInlineCreate, global::AppStoreConnect.AppCustomProductPageVersionInlineCreate>>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_F36412E28AEBC875(options);
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