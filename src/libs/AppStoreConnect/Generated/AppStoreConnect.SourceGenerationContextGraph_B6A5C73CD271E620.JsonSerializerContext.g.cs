
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_B6A5C73CD271E620 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_B6A5C73CD271E620 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_B6A5C73CD271E620(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem97JsonConverter());
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
                    typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeImageType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeImageType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeLocalizationType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeLocalizationType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeLocalizationRelationshipsVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeLocalizationRelationshipsVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeLocalizationRelationshipsImageDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeLocalizationRelationshipsImageDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeLocalizationsResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeLocalizationsResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationshipsChallengeDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationshipsChallengeDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationshipsLocalizationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationshipsLocalizationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationshipsReleasesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationshipsReleasesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationshipsDefaultImageDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationshipsDefaultImageDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState)

                    || typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterVersionState)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterVersionState?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeImage)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeImage?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionsLocalizationsGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionsLocalizationsGetToManyRelatedIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeImageType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeImageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeImageType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeImageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeLocalizationType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeLocalizationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeLocalizationType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeLocalizationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeLocalizationRelationshipsVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeLocalizationRelationshipsVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeLocalizationRelationshipsVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeLocalizationRelationshipsVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeLocalizationRelationshipsImageDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeLocalizationRelationshipsImageDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeLocalizationRelationshipsImageDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeLocalizationRelationshipsImageDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeLocalizationsResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeLocalizationsResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeLocalizationsResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeLocalizationsResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeVersionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeVersionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationshipsChallengeDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeVersionRelationshipsChallengeDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationshipsChallengeDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeVersionRelationshipsChallengeDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationshipsLocalizationsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeVersionRelationshipsLocalizationsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationshipsLocalizationsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeVersionRelationshipsLocalizationsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationshipsReleasesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeVersionRelationshipsReleasesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationshipsReleasesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeVersionRelationshipsReleasesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationshipsDefaultImageDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeVersionRelationshipsDefaultImageDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationshipsDefaultImageDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeVersionRelationshipsDefaultImageDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState))
                {
                    return new global::AppStoreConnect.JsonConverters.AppMediaAssetStateStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppMediaAssetStateStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterVersionState))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterVersionStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterVersionState?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterVersionStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeImage))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeImageJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeImage?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeImageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionsLocalizationsGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeVersionsLocalizationsGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionsLocalizationsGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeVersionsLocalizationsGetToManyRelatedIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeImage))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeImage(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeImageAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeImageAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeImageType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeImageType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeLocalization(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeLocalizationAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeLocalizationAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeLocalizationRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeLocalizationRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeLocalizationRelationshipsImage))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeLocalizationRelationshipsImage(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeLocalizationRelationshipsImageData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeLocalizationRelationshipsImageData(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeLocalizationRelationshipsImageDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeLocalizationRelationshipsImageDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeLocalizationRelationshipsVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeLocalizationRelationshipsVersion(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeLocalizationRelationshipsVersionData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeLocalizationRelationshipsVersionData(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeLocalizationRelationshipsVersionDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeLocalizationRelationshipsVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeLocalizationType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeLocalizationType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeLocalizationsResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeLocalizationsResponse(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeLocalizationsResponseIncludedItemDiscriminator))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeLocalizationsResponseIncludedItemDiscriminator(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeLocalizationsResponseIncludedItemDiscriminatorType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeLocalizationsResponseIncludedItemDiscriminatorType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeVersion(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeVersionAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeVersionAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeVersionRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationshipsChallenge))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeVersionRelationshipsChallenge(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationshipsChallengeData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeVersionRelationshipsChallengeData(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationshipsChallengeDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeVersionRelationshipsChallengeDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationshipsDefaultImage))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeVersionRelationshipsDefaultImage(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationshipsDefaultImageData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeVersionRelationshipsDefaultImageData(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationshipsDefaultImageDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeVersionRelationshipsDefaultImageDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationshipsLocalizations))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeVersionRelationshipsLocalizations(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationshipsLocalizationsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeVersionRelationshipsLocalizationsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationshipsLocalizationsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeVersionRelationshipsLocalizationsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationshipsReleases))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeVersionRelationshipsReleases(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationshipsReleasesDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeVersionRelationshipsReleasesDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationshipsReleasesDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeVersionRelationshipsReleasesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeVersionType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeVersionType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeImage))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeImage2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeVersionsLocalizationsGetToManyRelatedIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_GameCenterChallengeVersionsLocalizationsGetToManyRelatedIncludeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterVersionState))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterVersionState2(options);
                }
                if (type == typeof(global::AppStoreConnect.HttpHeader))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_HttpHeader(options);
                }
                if (type == typeof(global::AppStoreConnect.ImageAsset))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_ImageAsset(options);
                }
                if (type == typeof(global::AppStoreConnect.IncludedItem97))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_IncludedItem972(options);
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
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppMediaStateError>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_7E9D192989E995BF(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterChallengeLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_3F15A1AE5273D78C(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterChallengeVersionRelationshipsLocalizationsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_77E5016E0C73D599(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterChallengeVersionRelationshipsReleasesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_8C25040FD80E4121(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeImage>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_A90557EE987D9623(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_8D94F993FBEE212E(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_958458FBBD4E3344(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterChallengeVersionsLocalizationsGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_9DC359290126DF32(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.HttpHeader>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_BCE13B3326F5CA8F(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem97>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_ADBDE0CC221291B0(options);
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
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeImageType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterChallengeImageType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeLocalizationRelationshipsImageDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterChallengeLocalizationRelationshipsImageDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeLocalizationRelationshipsVersionDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterChallengeLocalizationRelationshipsVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeLocalizationType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterChallengeLocalizationType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeLocalizationsResponseIncludedItemDiscriminatorType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterChallengeLocalizationsResponseIncludedItemDiscriminatorType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationshipsChallengeDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterChallengeVersionRelationshipsChallengeDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationshipsDefaultImageDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterChallengeVersionRelationshipsDefaultImageDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationshipsLocalizationsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterChallengeVersionRelationshipsLocalizationsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeVersionRelationshipsReleasesDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterChallengeVersionRelationshipsReleasesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeVersionType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterChallengeVersionType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeImage?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableGameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeImage2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeLocalization?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableGameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeVersion?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableGameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeVersionsLocalizationsGetToManyRelatedIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableGameCenterChallengeVersionsLocalizationsGetToManyRelatedIncludeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterVersionState?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterVersionState2(options);
                }
                if (type == typeof(global::AppStoreConnect.IncludedItem97?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableIncludedItem972(options);
                }
                if (type == typeof(int?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppMediaStateError>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_AE112F1FF3B11297(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterChallengeLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_48D5F778D1C6928E(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterChallengeVersionRelationshipsLocalizationsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_CAA1EF9318BE875D(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterChallengeVersionRelationshipsReleasesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_0B2EA2ED404614F7(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeImage>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_3BA97F99844D59A3(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_00952A0B21BFD306(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_94B10A465703ABF7(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterChallengeVersionsLocalizationsGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_1683B7AE779148DD(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.HttpHeader>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_1947F16F30F1622D(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem97>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_064CE16A1CF9691A(options);
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