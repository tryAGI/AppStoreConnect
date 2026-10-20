
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_549B4B73EF1EC7FC : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_549B4B73EF1EC7FC Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_549B4B73EF1EC7FC(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem99JsonConverter());
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

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionReleaseType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionReleaseType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionReleaseRelationshipsVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionReleaseRelationshipsVersionDataType?)

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

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionsResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionsResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeAttributesChallengeType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeAttributesChallengeType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsGameCenterDetailDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsGameCenterDetailDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsGameCenterGroupDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsGameCenterGroupDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsVersionsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsVersionsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsLeaderboardDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsLeaderboardDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsLeaderboardV2DataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsLeaderboardV2DataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState)

                    || typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterVersionState)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterVersionState?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallenge)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallenge?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeVersionRelease)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeVersionRelease?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeImage)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeImage?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengesVersionsGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengesVersionsGetToManyRelatedIncludeItem?);
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

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionReleaseType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeVersionReleaseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionReleaseType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeVersionReleaseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionReleaseRelationshipsVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeVersionReleaseRelationshipsVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionReleaseRelationshipsVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeVersionReleaseRelationshipsVersionDataTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionsResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeVersionsResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeVersionsResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeVersionsResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeAttributesChallengeType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeAttributesChallengeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeAttributesChallengeType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeAttributesChallengeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsGameCenterDetailDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeRelationshipsGameCenterDetailDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsGameCenterDetailDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeRelationshipsGameCenterDetailDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsGameCenterGroupDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeRelationshipsGameCenterGroupDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsGameCenterGroupDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeRelationshipsGameCenterGroupDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsVersionsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeRelationshipsVersionsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsVersionsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeRelationshipsVersionsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsLeaderboardDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeRelationshipsLeaderboardDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsLeaderboardDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeRelationshipsLeaderboardDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsLeaderboardV2DataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeRelationshipsLeaderboardV2DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsLeaderboardV2DataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengeRelationshipsLeaderboardV2DataTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallenge))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallenge?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeVersionRelease))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeVersionReleaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeVersionRelease?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeVersionReleaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeImage))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeImageJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeImage?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeImageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengesVersionsGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengesVersionsGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterChallengesVersionsGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterChallengesVersionsGetToManyRelatedIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.GameCenterChallenge))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallenge(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeAttributesChallengeType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeAttributesChallengeType2(options);
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
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsGameCenterDetail))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeRelationshipsGameCenterDetail(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsGameCenterDetailData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeRelationshipsGameCenterDetailData(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsGameCenterDetailDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeRelationshipsGameCenterDetailDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsGameCenterGroup))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeRelationshipsGameCenterGroup(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsGameCenterGroupData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeRelationshipsGameCenterGroupData(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsGameCenterGroupDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeRelationshipsGameCenterGroupDataType2(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsLeaderboard))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeRelationshipsLeaderboard(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsLeaderboardData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeRelationshipsLeaderboardData(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsLeaderboardDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeRelationshipsLeaderboardDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsLeaderboardV2))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeRelationshipsLeaderboardV2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsLeaderboardV2Data))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeRelationshipsLeaderboardV2Data(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsLeaderboardV2DataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeRelationshipsLeaderboardV2DataType2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsVersions))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeRelationshipsVersions(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsVersionsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeRelationshipsVersionsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsVersionsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeRelationshipsVersionsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeType2(options);
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
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeVersionRelease))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeVersionRelease(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeVersionReleaseRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeVersionReleaseRelationships(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeVersionReleaseRelationshipsVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeVersionReleaseRelationshipsVersion(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeVersionReleaseRelationshipsVersionData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeVersionReleaseRelationshipsVersionData(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeVersionReleaseRelationshipsVersionDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeVersionReleaseRelationshipsVersionDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeVersionReleaseType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeVersionReleaseType2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeVersionType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeVersionType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeVersionsResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeVersionsResponse(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeVersionsResponseIncludedItemDiscriminator))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeVersionsResponseIncludedItemDiscriminator(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeVersionsResponseIncludedItemDiscriminatorType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterChallengeVersionsResponseIncludedItemDiscriminatorType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallenge))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallenge2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeImage))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeImage2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeVersionRelease))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeVersionRelease2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengesVersionsGetToManyRelatedIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_GameCenterChallengesVersionsGetToManyRelatedIncludeItem2(options);
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
                if (type == typeof(global::AppStoreConnect.IncludedItem99))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_IncludedItem992(options);
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
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterChallengeRelationshipsVersionsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_2BBE88FBE264A8EA(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterChallengeVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_9BCDC1282C7824DE(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterChallengeVersionRelationshipsLocalizationsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_77E5016E0C73D599(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterChallengeVersionRelationshipsReleasesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_8C25040FD80E4121(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallenge>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_B20D229A51E9A36F(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeImage>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_C600E21D7205DF99(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_54CA8DDC2DCD15B8(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_A20C459AC80EE3C0(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeVersionRelease>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_AE4D06A9940CC427(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterChallengesVersionsGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_1F04F6EEE4D93E96(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.HttpHeader>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_BCE13B3326F5CA8F(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem99>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_2EF836E4FA30108F(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.UploadOperation>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_A918B5AE31119789(options);
                }
                if (type == typeof(int))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(bool?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBoolean(options);
                }
                if (type == typeof(global::AppStoreConnect.AppMediaAssetStateState?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppMediaAssetStateState2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeAttributesChallengeType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterChallengeAttributesChallengeType2(options);
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
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsGameCenterDetailDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterChallengeRelationshipsGameCenterDetailDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsGameCenterGroupDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterChallengeRelationshipsGameCenterGroupDataType2(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsLeaderboardDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterChallengeRelationshipsLeaderboardDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsLeaderboardV2DataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterChallengeRelationshipsLeaderboardV2DataType2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeRelationshipsVersionsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterChallengeRelationshipsVersionsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterChallengeType2(options);
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
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeVersionReleaseRelationshipsVersionDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterChallengeVersionReleaseRelationshipsVersionDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeVersionReleaseType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterChallengeVersionReleaseType2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeVersionType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterChallengeVersionType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengeVersionsResponseIncludedItemDiscriminatorType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterChallengeVersionsResponseIncludedItemDiscriminatorType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallenge?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableGameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallenge2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeImage?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableGameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeImage2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeLocalization?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableGameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeVersion?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableGameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeVersionRelease?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableGameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeVersionRelease2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterChallengesVersionsGetToManyRelatedIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableGameCenterChallengesVersionsGetToManyRelatedIncludeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterVersionState?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterVersionState2(options);
                }
                if (type == typeof(global::AppStoreConnect.IncludedItem99?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableIncludedItem992(options);
                }
                if (type == typeof(int?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppMediaStateError>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_AE112F1FF3B11297(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterChallengeRelationshipsVersionsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_1CBD575A7DCD624F(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterChallengeVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_C8363EBF7AFF8AF3(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterChallengeVersionRelationshipsLocalizationsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_CAA1EF9318BE875D(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterChallengeVersionRelationshipsReleasesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_0B2EA2ED404614F7(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallenge>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_6AACAEA7A41D2BDA(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeImage>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_78B75FC456D75E81(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_289FDAD6003833E4(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_5840A26716A483F2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeVersionRelease>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_BAD96A6FF88D3CE8(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterChallengesVersionsGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_5C3BCBA47DA1986F(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.HttpHeader>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_1947F16F30F1622D(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem99>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_063B7598AC7EDA4B(options);
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