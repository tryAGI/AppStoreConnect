
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_52331B27D3CD1A47 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_52331B27D3CD1A47 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_52331B27D3CD1A47(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem7JsonConverter());
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
                    typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceLocalizationType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceLocalizationType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceLocalizationRelationshipsAppClipDefaultExperienceDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceLocalizationRelationshipsAppClipDefaultExperienceDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceLocalizationRelationshipsAppClipHeaderImageDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceLocalizationRelationshipsAppClipHeaderImageDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceLocalizationsResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceLocalizationsResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsReleaseWithAppStoreVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsReleaseWithAppStoreVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipDefaultExperienceLocalizationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipDefaultExperienceLocalizationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipAppStoreReviewDetailDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipAppStoreReviewDetailDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipHeaderImageType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipHeaderImageType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipHeaderImageRelationshipsAppClipDefaultExperienceLocalizationDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipHeaderImageRelationshipsAppClipDefaultExperienceLocalizationDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAction)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipAction?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState)

                    || typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipDefaultExperienceLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipDefaultExperienceLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipDefaultExperience)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipDefaultExperience?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipHeaderImage)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipHeaderImage?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceLocalizationType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDefaultExperienceLocalizationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceLocalizationType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDefaultExperienceLocalizationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceLocalizationRelationshipsAppClipDefaultExperienceDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDefaultExperienceLocalizationRelationshipsAppClipDefaultExperienceDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceLocalizationRelationshipsAppClipDefaultExperienceDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDefaultExperienceLocalizationRelationshipsAppClipDefaultExperienceDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceLocalizationRelationshipsAppClipHeaderImageDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDefaultExperienceLocalizationRelationshipsAppClipHeaderImageDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceLocalizationRelationshipsAppClipHeaderImageDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDefaultExperienceLocalizationRelationshipsAppClipHeaderImageDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceLocalizationsResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDefaultExperienceLocalizationsResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceLocalizationsResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDefaultExperienceLocalizationsResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDefaultExperienceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDefaultExperienceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDefaultExperienceRelationshipsAppClipDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDefaultExperienceRelationshipsAppClipDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsReleaseWithAppStoreVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDefaultExperienceRelationshipsReleaseWithAppStoreVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsReleaseWithAppStoreVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDefaultExperienceRelationshipsReleaseWithAppStoreVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipDefaultExperienceLocalizationsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDefaultExperienceRelationshipsAppClipDefaultExperienceLocalizationsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipDefaultExperienceLocalizationsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDefaultExperienceRelationshipsAppClipDefaultExperienceLocalizationsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipAppStoreReviewDetailDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDefaultExperienceRelationshipsAppClipAppStoreReviewDetailDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipAppStoreReviewDetailDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDefaultExperienceRelationshipsAppClipAppStoreReviewDetailDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipHeaderImageType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipHeaderImageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipHeaderImageType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipHeaderImageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipHeaderImageRelationshipsAppClipDefaultExperienceLocalizationDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipHeaderImageRelationshipsAppClipDefaultExperienceLocalizationDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipHeaderImageRelationshipsAppClipDefaultExperienceLocalizationDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipHeaderImageRelationshipsAppClipDefaultExperienceLocalizationDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAction))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipActionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipAction?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState))
                {
                    return new global::AppStoreConnect.JsonConverters.AppMediaAssetStateStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppMediaAssetStateStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipDefaultExperienceLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipDefaultExperienceLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipDefaultExperienceLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipDefaultExperienceLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipDefaultExperience))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipDefaultExperienceJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipDefaultExperience?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipDefaultExperienceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipHeaderImage))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipHeaderImageJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipHeaderImage?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipHeaderImageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.AppClipAction))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAction2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperience))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipDefaultExperience(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipDefaultExperienceAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipDefaultExperienceLocalization(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceLocalizationAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipDefaultExperienceLocalizationAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceLocalizationRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipDefaultExperienceLocalizationRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceLocalizationRelationshipsAppClipDefaultExperience))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipDefaultExperienceLocalizationRelationshipsAppClipDefaultExperience(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceLocalizationRelationshipsAppClipDefaultExperienceData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipDefaultExperienceLocalizationRelationshipsAppClipDefaultExperienceData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceLocalizationRelationshipsAppClipDefaultExperienceDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipDefaultExperienceLocalizationRelationshipsAppClipDefaultExperienceDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceLocalizationRelationshipsAppClipHeaderImage))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipDefaultExperienceLocalizationRelationshipsAppClipHeaderImage(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceLocalizationRelationshipsAppClipHeaderImageData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipDefaultExperienceLocalizationRelationshipsAppClipHeaderImageData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceLocalizationRelationshipsAppClipHeaderImageDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipDefaultExperienceLocalizationRelationshipsAppClipHeaderImageDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceLocalizationType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipDefaultExperienceLocalizationType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceLocalizationsResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipDefaultExperienceLocalizationsResponse(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceLocalizationsResponseIncludedItemDiscriminator))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipDefaultExperienceLocalizationsResponseIncludedItemDiscriminator(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceLocalizationsResponseIncludedItemDiscriminatorType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipDefaultExperienceLocalizationsResponseIncludedItemDiscriminatorType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipDefaultExperienceRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClip))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipDefaultExperienceRelationshipsAppClip(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipAppStoreReviewDetail))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipDefaultExperienceRelationshipsAppClipAppStoreReviewDetail(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipAppStoreReviewDetailData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipDefaultExperienceRelationshipsAppClipAppStoreReviewDetailData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipAppStoreReviewDetailDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipDefaultExperienceRelationshipsAppClipAppStoreReviewDetailDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipDefaultExperienceRelationshipsAppClipData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipDefaultExperienceRelationshipsAppClipDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipDefaultExperienceLocalizations))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipDefaultExperienceRelationshipsAppClipDefaultExperienceLocalizations(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipDefaultExperienceLocalizationsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipDefaultExperienceRelationshipsAppClipDefaultExperienceLocalizationsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipDefaultExperienceLocalizationsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipDefaultExperienceRelationshipsAppClipDefaultExperienceLocalizationsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsReleaseWithAppStoreVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipDefaultExperienceRelationshipsReleaseWithAppStoreVersion(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsReleaseWithAppStoreVersionData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipDefaultExperienceRelationshipsReleaseWithAppStoreVersionData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsReleaseWithAppStoreVersionDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipDefaultExperienceRelationshipsReleaseWithAppStoreVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipDefaultExperienceType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipDefaultExperience))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipDefaultExperience2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipDefaultExperienceLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipDefaultExper_cf75596fc7fbe1a6(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipHeaderImage))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipHeaderImage2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedIncludeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipHeaderImage))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipHeaderImage(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipHeaderImageAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipHeaderImageAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipHeaderImageRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipHeaderImageRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipHeaderImageRelationshipsAppClipDefaultExperienceLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipHeaderImageRelationshipsAppClipDefaultExperienceLocalization(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipHeaderImageRelationshipsAppClipDefaultExperienceLocalizationData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipHeaderImageRelationshipsAppClipDefaultExperienceLocalizationData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipHeaderImageRelationshipsAppClipDefaultExperienceLocalizationDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipHeaderImageRelationshipsAppClipDefaultExperienceLocalizationDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipHeaderImageType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipHeaderImageType2(options);
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
                if (type == typeof(global::AppStoreConnect.HttpHeader))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_HttpHeader(options);
                }
                if (type == typeof(global::AppStoreConnect.ImageAsset))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_ImageAsset(options);
                }
                if (type == typeof(global::AppStoreConnect.IncludedItem7))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_IncludedItem72_3(options);
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
                if (type == typeof(global::AppStoreConnect.UploadOperation))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_UploadOperation(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipDefaultExperienceLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_ECDC0671CE7AA658(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipDefaultExperienceLocalizationsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_5784DD7FAB1BF571(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipDefaultExperience>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_C6AA191FD12C7B52(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipDefaultExperienceLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_BE89FCC4C03C79EB(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipHeaderImage>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_9F854B8B074493CA(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_61BBC7846921CE28(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppMediaStateError>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_7E9D192989E995BF(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.HttpHeader>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_BCE13B3326F5CA8F(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem7>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_788E6161B7EA9500(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.UploadOperation>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_A918B5AE31119789(options);
                }
                if (type == typeof(int))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAction?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppClipAction2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceLocalizationRelationshipsAppClipDefaultExperienceDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppClipDefaultExperienceLocalizationRelationshipsAppClipDefaultExperienceDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceLocalizationRelationshipsAppClipHeaderImageDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppClipDefaultExperienceLocalizationRelationshipsAppClipHeaderImageDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceLocalizationType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppClipDefaultExperienceLocalizationType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceLocalizationsResponseIncludedItemDiscriminatorType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppClipDefaultExperienceLocalizationsResponseIncludedItemDiscriminatorType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipAppStoreReviewDetailDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppClipDefaultExperienceRelationshipsAppClipAppStoreReviewDetailDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppClipDefaultExperienceRelationshipsAppClipDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipDefaultExperienceLocalizationsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppClipDefaultExperienceRelationshipsAppClipDefaultExperienceLocalizationsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceRelationshipsReleaseWithAppStoreVersionDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppClipDefaultExperienceRelationshipsReleaseWithAppStoreVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperienceType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppClipDefaultExperienceType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipDefaultExperience?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipDefaultExperience2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipDefaultExperienceLocalization?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipDefaultExper_22e167d138d532cf(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipHeaderImage?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipHeaderImage2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedIncludeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipHeaderImageRelationshipsAppClipDefaultExperienceLocalizationDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppClipHeaderImageRelationshipsAppClipDefaultExperienceLocalizationDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipHeaderImageType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppClipHeaderImageType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppMediaAssetStateState?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppMediaAssetStateState2(options);
                }
                if (type == typeof(global::AppStoreConnect.IncludedItem7?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableIncludedItem72_3(options);
                }
                if (type == typeof(int?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppClipDefaultExperienceLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_AD48FC9C531373DF(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipDefaultExperienceLocalizationsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_CB5A950731389BB1(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipDefaultExperience>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_CDFA447B4E9B5ACE(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipDefaultExperienceLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_F62042EF6DFC0ED0(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedFieldsAppClipHeaderImage>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_692322A24A044931(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppClipDefaultExperiencesAppClipDefaultExperienceLocalizationsGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_209C564F16EB0784(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppMediaStateError>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_AE112F1FF3B11297(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.HttpHeader>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_1947F16F30F1622D(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem7>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_81646419CE644F7C(options);
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