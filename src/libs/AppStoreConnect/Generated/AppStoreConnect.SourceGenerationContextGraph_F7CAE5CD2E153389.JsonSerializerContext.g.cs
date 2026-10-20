
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_F7CAE5CD2E153389 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_F7CAE5CD2E153389 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_F7CAE5CD2E153389(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsApp)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsApp?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersionLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersionLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsBuild)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsBuild?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersionPhasedRelease)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersionPhasedRelease?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsGameCenterAppVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsGameCenterAppVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsRoutingAppCoverage)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsRoutingAppCoverage?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreReviewDetail)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreReviewDetail?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersionSubmission)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersionSubmission?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppClipDefaultExperience)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppClipDefaultExperience?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersionExperiment)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersionExperiment?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAlternativeDistributionPackage)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAlternativeDistributionPackage?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsGetInstanceFieldsAppStoreVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsGetInstanceFieldsAppStoreVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsApp))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsGetInstanceFieldsAppJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsApp?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsGetInstanceFieldsAppNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersionLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsGetInstanceFieldsAppStoreVersionLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersionLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsGetInstanceFieldsAppStoreVersionLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsBuild))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsGetInstanceFieldsBuildJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsBuild?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsGetInstanceFieldsBuildNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersionPhasedRelease))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsGetInstanceFieldsAppStoreVersionPhasedReleaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersionPhasedRelease?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsGetInstanceFieldsAppStoreVersionPhasedReleaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsGameCenterAppVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsGetInstanceFieldsGameCenterAppVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsGameCenterAppVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsGetInstanceFieldsGameCenterAppVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsRoutingAppCoverage))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsGetInstanceFieldsRoutingAppCoverageJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsRoutingAppCoverage?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsGetInstanceFieldsRoutingAppCoverageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreReviewDetail))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsGetInstanceFieldsAppStoreReviewDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreReviewDetail?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsGetInstanceFieldsAppStoreReviewDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersionSubmission))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsGetInstanceFieldsAppStoreVersionSubmissionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersionSubmission?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsGetInstanceFieldsAppStoreVersionSubmissionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppClipDefaultExperience))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsGetInstanceFieldsAppClipDefaultExperienceJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppClipDefaultExperience?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsGetInstanceFieldsAppClipDefaultExperienceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersionExperiment))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsGetInstanceFieldsAppStoreVersionExperimentJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersionExperiment?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsGetInstanceFieldsAppStoreVersionExperimentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAlternativeDistributionPackage))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsGetInstanceFieldsAlternativeDistributionPackageJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAlternativeDistributionPackage?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsGetInstanceFieldsAlternativeDistributionPackageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionsGetInstanceIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAlternativeDistributionPackage))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppStoreVersionsGetInstanceFieldsAlternativeDistributionPackage2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsApp))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppStoreVersionsGetInstanceFieldsApp2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppClipDefaultExperience))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppStoreVersionsGetInstanceFieldsAppClipDefaultExperience2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreReviewDetail))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppStoreVersionsGetInstanceFieldsAppStoreReviewDetail2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppStoreVersionsGetInstanceFieldsAppStoreVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersionExperiment))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppStoreVersionsGetInstanceFieldsAppStoreVersionExperiment2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersionLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppStoreVersionsGetInstanceFieldsAppStoreVersionLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersionPhasedRelease))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppStoreVersionsGetInstanceFieldsAppStoreVersionPhasedRelease2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersionSubmission))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppStoreVersionsGetInstanceFieldsAppStoreVersionSubmission2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsBuild))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppStoreVersionsGetInstanceFieldsBuild2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsGameCenterAppVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppStoreVersionsGetInstanceFieldsGameCenterAppVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsRoutingAppCoverage))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppStoreVersionsGetInstanceFieldsRoutingAppCoverage2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppStoreVersionsGetInstanceIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAlternativeDistributionPackage>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_439D76D35F5CE444(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsApp>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_694C59D97F7062D2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppClipDefaultExperience>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_4F6FE52EC7371429(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreReviewDetail>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_3906F9613BF45A82(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_B687C790DC2BD060(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersionExperiment>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_417C361EC6B96080(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersionLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_9C34B9DF8DB77E11(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersionPhasedRelease>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_4F19602CA30D7990(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersionSubmission>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_145BCB7F3FF825A6(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsBuild>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_3CF2746DFA95A8DB(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsGameCenterAppVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_D2E812394A4B0D25(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsRoutingAppCoverage>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_E6DBD30BCB66DD08(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_5B356F6F88AF8BA3(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAlternativeDistributionPackage?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppStoreVersionsGetInstanceFieldsAlternativeDistributionPackage2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsApp?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppStoreVersionsGetInstanceFieldsApp2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppClipDefaultExperience?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppStoreVersionsGetInstanceFieldsAppClipDefaultExperience2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreReviewDetail?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppStoreVersionsGetInstanceFieldsAppStoreReviewDetail2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersion?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppStoreVersionsGetInstanceFieldsAppStoreVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersionExperiment?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppStoreVersionsGetInstanceFieldsAppStoreVersionExperiment2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersionLocalization?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppStoreVersionsGetInstanceFieldsAppStoreVersionLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersionPhasedRelease?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppStoreVersionsGetInstanceFieldsAppStoreVersionPhasedRelease2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersionSubmission?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppStoreVersionsGetInstanceFieldsAppStoreVersionSubmission2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsBuild?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppStoreVersionsGetInstanceFieldsBuild2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsGameCenterAppVersion?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppStoreVersionsGetInstanceFieldsGameCenterAppVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsRoutingAppCoverage?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppStoreVersionsGetInstanceFieldsRoutingAppCoverage2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionsGetInstanceIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppStoreVersionsGetInstanceIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAlternativeDistributionPackage>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_8CC7D2A6BBD0FB2D(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsApp>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_DFD7F97BEF23CDE6(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppClipDefaultExperience>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_B9307ECB28C7DA1E(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreReviewDetail>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_135A9BBDA8450BA2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_151EF7888909D836(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersionExperiment>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_1F2FC270A62FA9D9(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersionLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_C721D128D8554802(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersionPhasedRelease>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_905782517687AE58(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsAppStoreVersionSubmission>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_5C23E837587031ED(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsBuild>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_879B3093606FD23D(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsGameCenterAppVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_955557208EF74EF7(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsGetInstanceFieldsRoutingAppCoverage>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_BDB488858D4CD34A(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionsGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_95E21201B195EBD6(options);
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