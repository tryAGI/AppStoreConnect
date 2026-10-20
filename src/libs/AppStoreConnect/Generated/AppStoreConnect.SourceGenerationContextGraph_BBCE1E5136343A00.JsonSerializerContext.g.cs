
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_BBCE1E5136343A00 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_BBCE1E5136343A00 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_BBCE1E5136343A00(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsReviewSubmissionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsReviewSubmissionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsAppStoreVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsAppStoreVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsAppCustomProductPageVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsAppCustomProductPageVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsAppStoreVersionExperimentDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsAppStoreVersionExperimentDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsAppStoreVersionExperimentV2DataType)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsAppStoreVersionExperimentV2DataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsAppEventDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsAppEventDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsAppAssetLibraryImageDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsAppAssetLibraryImageDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsAppAssetLibraryVideoDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsAppAssetLibraryVideoDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsBackgroundAssetVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsBackgroundAssetVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterAchievementVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterAchievementVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterActivityVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterActivityVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterChallengeVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterChallengeVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterLeaderboardSetVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterLeaderboardSetVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterLeaderboardVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterLeaderboardVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsInAppPurchaseVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsInAppPurchaseVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsSubscriptionVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsSubscriptionVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsSubscriptionGroupVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsSubscriptionGroupVersionDataType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemCreateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemCreateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsReviewSubmissionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemCreateRequestDataRelationshipsReviewSubmissionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsReviewSubmissionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemCreateRequestDataRelationshipsReviewSubmissionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsAppStoreVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemCreateRequestDataRelationshipsAppStoreVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsAppStoreVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemCreateRequestDataRelationshipsAppStoreVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsAppCustomProductPageVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemCreateRequestDataRelationshipsAppCustomProductPageVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsAppCustomProductPageVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemCreateRequestDataRelationshipsAppCustomProductPageVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsAppStoreVersionExperimentDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemCreateRequestDataRelationshipsAppStoreVersionExperimentDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsAppStoreVersionExperimentDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemCreateRequestDataRelationshipsAppStoreVersionExperimentDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsAppStoreVersionExperimentV2DataType))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemCreateRequestDataRelationshipsAppStoreVersionExperimentV2DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsAppStoreVersionExperimentV2DataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemCreateRequestDataRelationshipsAppStoreVersionExperimentV2DataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsAppEventDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemCreateRequestDataRelationshipsAppEventDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsAppEventDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemCreateRequestDataRelationshipsAppEventDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsAppAssetLibraryImageDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemCreateRequestDataRelationshipsAppAssetLibraryImageDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsAppAssetLibraryImageDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemCreateRequestDataRelationshipsAppAssetLibraryImageDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsAppAssetLibraryVideoDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemCreateRequestDataRelationshipsAppAssetLibraryVideoDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsAppAssetLibraryVideoDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemCreateRequestDataRelationshipsAppAssetLibraryVideoDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsBackgroundAssetVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemCreateRequestDataRelationshipsBackgroundAssetVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsBackgroundAssetVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemCreateRequestDataRelationshipsBackgroundAssetVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterAchievementVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterAchievementVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterAchievementVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterAchievementVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterActivityVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterActivityVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterActivityVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterActivityVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterChallengeVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterChallengeVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterChallengeVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterChallengeVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterLeaderboardSetVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterLeaderboardSetVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterLeaderboardSetVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterLeaderboardSetVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterLeaderboardVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterLeaderboardVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterLeaderboardVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterLeaderboardVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsInAppPurchaseVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemCreateRequestDataRelationshipsInAppPurchaseVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsInAppPurchaseVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemCreateRequestDataRelationshipsInAppPurchaseVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsSubscriptionVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemCreateRequestDataRelationshipsSubscriptionVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsSubscriptionVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemCreateRequestDataRelationshipsSubscriptionVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsSubscriptionGroupVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemCreateRequestDataRelationshipsSubscriptionGroupVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsSubscriptionGroupVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionItemCreateRequestDataRelationshipsSubscriptionGroupVersionDataTypeNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequest))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionItemCreateRequest(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionItemCreateRequestData(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionItemCreateRequestDataRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsAppAssetLibraryImage))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionItemCreateRequestDataRelationshipsAppAssetLibraryImage(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsAppAssetLibraryImageData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionItemCreateRequestDataRelationshipsAppAssetLibraryImageData(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsAppAssetLibraryImageDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionItemCreateRequestDataRelationshipsAppAssetLibraryImageDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsAppAssetLibraryVideo))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionItemCreateRequestDataRelationshipsAppAssetLibraryVideo(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsAppAssetLibraryVideoData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionItemCreateRequestDataRelationshipsAppAssetLibraryVideoData(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsAppAssetLibraryVideoDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionItemCreateRequestDataRelationshipsAppAssetLibraryVideoDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsAppCustomProductPageVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionItemCreateRequestDataRelationshipsAppCustomProductPageVersion(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsAppCustomProductPageVersionData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionItemCreateRequestDataRelationshipsAppCustomProductPageVersionData(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsAppCustomProductPageVersionDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionItemCreateRequestDataRelationshipsAppCustomProductPageVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsAppEvent))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionItemCreateRequestDataRelationshipsAppEvent(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsAppEventData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionItemCreateRequestDataRelationshipsAppEventData(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsAppEventDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionItemCreateRequestDataRelationshipsAppEventDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsAppStoreVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionItemCreateRequestDataRelationshipsAppStoreVersion(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsAppStoreVersionData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionItemCreateRequestDataRelationshipsAppStoreVersionData(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsAppStoreVersionDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionItemCreateRequestDataRelationshipsAppStoreVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsAppStoreVersionExperiment))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionItemCreateRequestDataRelationshipsAppStoreVersionExperiment(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsAppStoreVersionExperimentData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionItemCreateRequestDataRelationshipsAppStoreVersionExperimentData(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsAppStoreVersionExperimentDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionItemCreateRequestDataRelationshipsAppStoreVersionExperimentDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsAppStoreVersionExperimentV2))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionItemCreateRequestDataRelationshipsAppStoreVersionExperimentV2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsAppStoreVersionExperimentV2Data))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionItemCreateRequestDataRelationshipsAppStoreVersionExperimentV2Data(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsAppStoreVersionExperimentV2DataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionItemCreateRequestDataRelationshipsAppStoreVersionExperimentV2DataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsBackgroundAssetVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionItemCreateRequestDataRelationshipsBackgroundAssetVersion(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsBackgroundAssetVersionData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionItemCreateRequestDataRelationshipsBackgroundAssetVersionData(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsBackgroundAssetVersionDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionItemCreateRequestDataRelationshipsBackgroundAssetVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterAchievementVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterAchievementVersion(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterAchievementVersionData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterAchievementVersionData(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterAchievementVersionDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterAchievementVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterActivityVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterActivityVersion(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterActivityVersionData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterActivityVersionData(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterActivityVersionDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterActivityVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterChallengeVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterChallengeVersion(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterChallengeVersionData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterChallengeVersionData(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterChallengeVersionDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterChallengeVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterLeaderboardSetVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterLeaderboardSetVersion(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterLeaderboardSetVersionData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterLeaderboardSetVersionData(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterLeaderboardSetVersionDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterLeaderboardSetVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterLeaderboardVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterLeaderboardVersion(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterLeaderboardVersionData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterLeaderboardVersionData(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterLeaderboardVersionDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterLeaderboardVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsInAppPurchaseVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionItemCreateRequestDataRelationshipsInAppPurchaseVersion(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsInAppPurchaseVersionData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionItemCreateRequestDataRelationshipsInAppPurchaseVersionData(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsInAppPurchaseVersionDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionItemCreateRequestDataRelationshipsInAppPurchaseVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsReviewSubmission))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionItemCreateRequestDataRelationshipsReviewSubmission(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsReviewSubmissionData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionItemCreateRequestDataRelationshipsReviewSubmissionData(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsReviewSubmissionDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionItemCreateRequestDataRelationshipsReviewSubmissionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsSubscriptionGroupVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionItemCreateRequestDataRelationshipsSubscriptionGroupVersion(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsSubscriptionGroupVersionData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionItemCreateRequestDataRelationshipsSubscriptionGroupVersionData(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsSubscriptionGroupVersionDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionItemCreateRequestDataRelationshipsSubscriptionGroupVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsSubscriptionVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionItemCreateRequestDataRelationshipsSubscriptionVersion(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsSubscriptionVersionData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionItemCreateRequestDataRelationshipsSubscriptionVersionData(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsSubscriptionVersionDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionItemCreateRequestDataRelationshipsSubscriptionVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionItemCreateRequestDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsAppAssetLibraryImageDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableReviewSubmissionItemCreateRequestDataRelationshipsAppAssetLibraryImageDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsAppAssetLibraryVideoDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableReviewSubmissionItemCreateRequestDataRelationshipsAppAssetLibraryVideoDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsAppCustomProductPageVersionDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableReviewSubmissionItemCreateRequestDataRelationshipsAppCustomProductPageVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsAppEventDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableReviewSubmissionItemCreateRequestDataRelationshipsAppEventDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsAppStoreVersionDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableReviewSubmissionItemCreateRequestDataRelationshipsAppStoreVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsAppStoreVersionExperimentDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableReviewSubmissionItemCreateRequestDataRelationshipsAppStoreVersionExperimentDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsAppStoreVersionExperimentV2DataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableReviewSubmissionItemCreateRequestDataRelationshipsAppStoreVersionExperimentV2DataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsBackgroundAssetVersionDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableReviewSubmissionItemCreateRequestDataRelationshipsBackgroundAssetVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterAchievementVersionDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableReviewSubmissionItemCreateRequestDataRelationshipsGameCenterAchievementVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterActivityVersionDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableReviewSubmissionItemCreateRequestDataRelationshipsGameCenterActivityVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterChallengeVersionDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableReviewSubmissionItemCreateRequestDataRelationshipsGameCenterChallengeVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterLeaderboardSetVersionDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableReviewSubmissionItemCreateRequestDataRelationshipsGameCenterLeaderboardSetVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterLeaderboardVersionDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableReviewSubmissionItemCreateRequestDataRelationshipsGameCenterLeaderboardVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsInAppPurchaseVersionDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableReviewSubmissionItemCreateRequestDataRelationshipsInAppPurchaseVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsReviewSubmissionDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableReviewSubmissionItemCreateRequestDataRelationshipsReviewSubmissionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsSubscriptionGroupVersionDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableReviewSubmissionItemCreateRequestDataRelationshipsSubscriptionGroupVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataRelationshipsSubscriptionVersionDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableReviewSubmissionItemCreateRequestDataRelationshipsSubscriptionVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemCreateRequestDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableReviewSubmissionItemCreateRequestDataType2(options);
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