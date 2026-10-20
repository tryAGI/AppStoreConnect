
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_1DFF855675800C8A : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_1DFF855675800C8A Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_1DFF855675800C8A(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.AppInfoLocalizationType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoLocalizationType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoLocalizationRelationshipsAppInfoDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoLocalizationRelationshipsAppInfoDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoAttributesState)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoAttributesState?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoAttributesAustraliaAgeRating)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoAttributesAustraliaAgeRating?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoAttributesBrazilAgeRatingV2)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoAttributesBrazilAgeRatingV2?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoAttributesFranceAgeRating)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoAttributesFranceAgeRating?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoAttributesKoreaAgeRating)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoAttributesKoreaAgeRating?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsAppDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsAppDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsAgeRatingDeclarationDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsAgeRatingDeclarationDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsAppInfoLocalizationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsAppInfoLocalizationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsPrimaryCategoryDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsPrimaryCategoryDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsPrimarySubcategoryOneDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsPrimarySubcategoryOneDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsPrimarySubcategoryTwoDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsPrimarySubcategoryTwoDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsSecondaryCategoryDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsSecondaryCategoryDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsSecondarySubcategoryOneDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsSecondarySubcategoryOneDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsSecondarySubcategoryTwoDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsSecondarySubcategoryTwoDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreAgeRating)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreAgeRating?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionState)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionState?)

                    || typeToConvert == typeof(global::AppStoreConnect.BrazilAgeRating)

                    || typeToConvert == typeof(global::AppStoreConnect.BrazilAgeRating?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfoLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfoLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfo)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfo?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfosAppInfoLocalizationsGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfosAppInfoLocalizationsGetToManyRelatedIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoLocalizationType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoLocalizationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoLocalizationType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoLocalizationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoLocalizationRelationshipsAppInfoDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoLocalizationRelationshipsAppInfoDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoLocalizationRelationshipsAppInfoDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoLocalizationRelationshipsAppInfoDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoAttributesState))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoAttributesStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoAttributesState?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoAttributesStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoAttributesAustraliaAgeRating))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoAttributesAustraliaAgeRatingJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoAttributesAustraliaAgeRating?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoAttributesAustraliaAgeRatingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoAttributesBrazilAgeRatingV2))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoAttributesBrazilAgeRatingV2JsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoAttributesBrazilAgeRatingV2?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoAttributesBrazilAgeRatingV2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoAttributesFranceAgeRating))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoAttributesFranceAgeRatingJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoAttributesFranceAgeRating?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoAttributesFranceAgeRatingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoAttributesKoreaAgeRating))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoAttributesKoreaAgeRatingJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoAttributesKoreaAgeRating?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoAttributesKoreaAgeRatingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsAppDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoRelationshipsAppDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsAppDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoRelationshipsAppDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsAgeRatingDeclarationDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoRelationshipsAgeRatingDeclarationDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsAgeRatingDeclarationDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoRelationshipsAgeRatingDeclarationDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsAppInfoLocalizationsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoRelationshipsAppInfoLocalizationsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsAppInfoLocalizationsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoRelationshipsAppInfoLocalizationsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsPrimaryCategoryDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoRelationshipsPrimaryCategoryDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsPrimaryCategoryDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoRelationshipsPrimaryCategoryDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsPrimarySubcategoryOneDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoRelationshipsPrimarySubcategoryOneDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsPrimarySubcategoryOneDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoRelationshipsPrimarySubcategoryOneDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsPrimarySubcategoryTwoDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoRelationshipsPrimarySubcategoryTwoDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsPrimarySubcategoryTwoDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoRelationshipsPrimarySubcategoryTwoDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsSecondaryCategoryDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoRelationshipsSecondaryCategoryDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsSecondaryCategoryDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoRelationshipsSecondaryCategoryDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsSecondarySubcategoryOneDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoRelationshipsSecondarySubcategoryOneDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsSecondarySubcategoryOneDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoRelationshipsSecondarySubcategoryOneDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsSecondarySubcategoryTwoDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoRelationshipsSecondarySubcategoryTwoDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsSecondarySubcategoryTwoDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoRelationshipsSecondarySubcategoryTwoDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreAgeRating))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreAgeRatingJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreAgeRating?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreAgeRatingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionState))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionState?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BrazilAgeRating))
                {
                    return new global::AppStoreConnect.JsonConverters.BrazilAgeRatingJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BrazilAgeRating?))
                {
                    return new global::AppStoreConnect.JsonConverters.BrazilAgeRatingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfoLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfoLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfoLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfoLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfo))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfoJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfo?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfoNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfosAppInfoLocalizationsGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfosAppInfoLocalizationsGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfosAppInfoLocalizationsGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfosAppInfoLocalizationsGetToManyRelatedIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.AppInfo))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfo(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoAttributes(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppInfoAttributesAustraliaAgeRating))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoAttributesAustraliaAgeRating2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppInfoAttributesBrazilAgeRatingV2))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoAttributesBrazilAgeRatingV22(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppInfoAttributesFranceAgeRating))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoAttributesFranceAgeRating2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppInfoAttributesKoreaAgeRating))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoAttributesKoreaAgeRating2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::AppStoreConnect.AppInfoAttributesState))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoAttributesState2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoLocalization(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoLocalizationAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoLocalizationAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoLocalizationRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoLocalizationRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoLocalizationRelationshipsAppInfo))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoLocalizationRelationshipsAppInfo(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoLocalizationRelationshipsAppInfoData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoLocalizationRelationshipsAppInfoData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoLocalizationRelationshipsAppInfoDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoLocalizationRelationshipsAppInfoDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoLocalizationType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoLocalizationType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoLocalizationsResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoLocalizationsResponse(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsAgeRatingDeclaration))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoRelationshipsAgeRatingDeclaration(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsAgeRatingDeclarationData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoRelationshipsAgeRatingDeclarationData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsAgeRatingDeclarationDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoRelationshipsAgeRatingDeclarationDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsApp))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoRelationshipsApp(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsAppData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoRelationshipsAppData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsAppDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoRelationshipsAppDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsAppInfoLocalizations))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoRelationshipsAppInfoLocalizations(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsAppInfoLocalizationsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoRelationshipsAppInfoLocalizationsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsAppInfoLocalizationsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoRelationshipsAppInfoLocalizationsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsPrimaryCategory))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoRelationshipsPrimaryCategory(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsPrimaryCategoryData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoRelationshipsPrimaryCategoryData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsPrimaryCategoryDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoRelationshipsPrimaryCategoryDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsPrimarySubcategoryOne))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoRelationshipsPrimarySubcategoryOne(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsPrimarySubcategoryOneData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoRelationshipsPrimarySubcategoryOneData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsPrimarySubcategoryOneDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoRelationshipsPrimarySubcategoryOneDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsPrimarySubcategoryTwo))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoRelationshipsPrimarySubcategoryTwo(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsPrimarySubcategoryTwoData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoRelationshipsPrimarySubcategoryTwoData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsPrimarySubcategoryTwoDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoRelationshipsPrimarySubcategoryTwoDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsSecondaryCategory))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoRelationshipsSecondaryCategory(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsSecondaryCategoryData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoRelationshipsSecondaryCategoryData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsSecondaryCategoryDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoRelationshipsSecondaryCategoryDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsSecondarySubcategoryOne))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoRelationshipsSecondarySubcategoryOne(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsSecondarySubcategoryOneData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoRelationshipsSecondarySubcategoryOneData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsSecondarySubcategoryOneDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoRelationshipsSecondarySubcategoryOneDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsSecondarySubcategoryTwo))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoRelationshipsSecondarySubcategoryTwo(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsSecondarySubcategoryTwoData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoRelationshipsSecondarySubcategoryTwoData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsSecondarySubcategoryTwoDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoRelationshipsSecondarySubcategoryTwoDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsTerritoryAgeRatings))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoRelationshipsTerritoryAgeRatings(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfo))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfo2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfoLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfoLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfosAppInfoLocalizationsGetToManyRelatedIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppInfosAppInfoLocalizationsGetToManyRelatedIncludeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreAgeRating))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreAgeRating2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionState))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionState2(options);
                }
                if (type == typeof(global::AppStoreConnect.BrazilAgeRating))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_BrazilAgeRating2(options);
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
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfo>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_8DAA1D0AE8D7E8A8(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfoLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_E136E1370F8A12A7(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfoRelationshipsAppInfoLocalizationsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_2CA8DA5C6FDCF956(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfo>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_47D7CE3B039FED27(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfoLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_A7E1682FFCF8B93A(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfosAppInfoLocalizationsGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_60DEE117C73895A9(options);
                }
                if (type == typeof(int))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppInfoAttributesAustraliaAgeRating?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppInfoAttributesAustraliaAgeRating2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppInfoAttributesBrazilAgeRatingV2?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppInfoAttributesBrazilAgeRatingV22(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppInfoAttributesFranceAgeRating?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppInfoAttributesFranceAgeRating2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppInfoAttributesKoreaAgeRating?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppInfoAttributesKoreaAgeRating2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::AppStoreConnect.AppInfoAttributesState?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppInfoAttributesState2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoLocalizationRelationshipsAppInfoDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppInfoLocalizationRelationshipsAppInfoDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoLocalizationType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppInfoLocalizationType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsAgeRatingDeclarationDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppInfoRelationshipsAgeRatingDeclarationDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsAppDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppInfoRelationshipsAppDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsAppInfoLocalizationsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppInfoRelationshipsAppInfoLocalizationsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsPrimaryCategoryDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppInfoRelationshipsPrimaryCategoryDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsPrimarySubcategoryOneDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppInfoRelationshipsPrimarySubcategoryOneDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsPrimarySubcategoryTwoDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppInfoRelationshipsPrimarySubcategoryTwoDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsSecondaryCategoryDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppInfoRelationshipsSecondaryCategoryDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsSecondarySubcategoryOneDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppInfoRelationshipsSecondarySubcategoryOneDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsSecondarySubcategoryTwoDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppInfoRelationshipsSecondarySubcategoryTwoDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppInfoType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfo?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfo2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfoLocalization?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfoLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfosAppInfoLocalizationsGetToManyRelatedIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppInfosAppInfoLocalizationsGetToManyRelatedIncludeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreAgeRating?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppStoreAgeRating2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionState?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppStoreVersionState2(options);
                }
                if (type == typeof(global::AppStoreConnect.BrazilAgeRating?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBrazilAgeRating2(options);
                }
                if (type == typeof(int?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppInfo>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_BE15F4CAB371B877(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppInfoLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_083CE5C1DDAA9E21(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppInfoRelationshipsAppInfoLocalizationsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_9A16AF18299559E8(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfo>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_3F872B30DEC9B103(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfoLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_F90F41D9369C6AF0(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppInfosAppInfoLocalizationsGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_86C7E78200BA3841(options);
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