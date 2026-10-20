
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_853F162AF3BFB520 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_853F162AF3BFB520 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_853F162AF3BFB520(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsApp)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsApp?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsBuild)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsBuild?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionPhasedRelease)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionPhasedRelease?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsGameCenterAppVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsGameCenterAppVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionSubmission)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionSubmission?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppClipDefaultExperience)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppClipDefaultExperience?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAlternativeDistributionPackage)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAlternativeDistributionPackage?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsApp))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsAppStoreVersionGetToOneRelatedFieldsAppJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsApp?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsAppStoreVersionGetToOneRelatedFieldsAppNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsBuild))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsAppStoreVersionGetToOneRelatedFieldsBuildJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsBuild?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsAppStoreVersionGetToOneRelatedFieldsBuildNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionPhasedRelease))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionPhasedReleaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionPhasedRelease?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionPhasedReleaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsGameCenterAppVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsAppStoreVersionGetToOneRelatedFieldsGameCenterAppVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsGameCenterAppVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsAppStoreVersionGetToOneRelatedFieldsGameCenterAppVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverageJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionSubmission))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionSubmissionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionSubmission?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionSubmissionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppClipDefaultExperience))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsAppStoreVersionGetToOneRelatedFieldsAppClipDefaultExperienceJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppClipDefaultExperience?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsAppStoreVersionGetToOneRelatedFieldsAppClipDefaultExperienceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperimentJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperimentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAlternativeDistributionPackage))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsAppStoreVersionGetToOneRelatedFieldsAlternativeDistributionPackageJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAlternativeDistributionPackage?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsAppStoreVersionGetToOneRelatedFieldsAlternativeDistributionPackageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsAppStoreVersionGetToOneRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsAppStoreVersionGetToOneRelatedIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAlternativeDistributionPackage))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_BuildsAppStoreVersionGetToOneRelatedFieldsAlternativeDistributionPackage2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsApp))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_BuildsAppStoreVersionGetToOneRelatedFieldsApp2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppClipDefaultExperience))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_BuildsAppStoreVersionGetToOneRelatedFieldsAppClipDefaultExperience2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionPhasedRelease))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionPhasedRelease2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionSubmission))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionSubmission2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsBuild))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_BuildsAppStoreVersionGetToOneRelatedFieldsBuild2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsGameCenterAppVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_BuildsAppStoreVersionGetToOneRelatedFieldsGameCenterAppVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_BuildsAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_BuildsAppStoreVersionGetToOneRelatedIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAlternativeDistributionPackage>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_B2B50DCA82123685(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsApp>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_33C51F45C7A6C8B9(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppClipDefaultExperience>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_9637CDBA3EE5C8E8(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_A49DBEEA91C3E6F6(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_FBE243F2BDD0CC29(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_2AE0FA399D6E083D(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_852CD8130CB3BF8F(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionPhasedRelease>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_D5379C5981355230(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionSubmission>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_9C2DBDCE2FFAAAC5(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsBuild>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_CCE2043442A40D6C(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsGameCenterAppVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_76482F5932E4AB5D(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_DA042AA21E394A21(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_4F7C9B5471100E26(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAlternativeDistributionPackage?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableBuildsAppStoreVersionGetToOneRelatedFieldsAlternativeDistributionPackage2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsApp?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableBuildsAppStoreVersionGetToOneRelatedFieldsApp2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppClipDefaultExperience?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableBuildsAppStoreVersionGetToOneRelatedFieldsAppClipDefaultExperience2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableBuildsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableBuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableBuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableBuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionPhasedRelease?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableBuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionPhasedRelease2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionSubmission?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableBuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionSubmission2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsBuild?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableBuildsAppStoreVersionGetToOneRelatedFieldsBuild2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsGameCenterAppVersion?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableBuildsAppStoreVersionGetToOneRelatedFieldsGameCenterAppVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableBuildsAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableBuildsAppStoreVersionGetToOneRelatedIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAlternativeDistributionPackage>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_5686B636FA26204B(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsApp>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_BC6D5D4551628A91(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppClipDefaultExperience>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_FCD37F032A120724(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreReviewDetail>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_9BAACD480CCCF06E(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_577745F6E644919F(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_23E4726F5057CF13(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_1295CFF09C02DC53(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionPhasedRelease>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_003E7C4E2D2B55DC(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionSubmission>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_8334426840D95E65(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsBuild>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_147865BC14C85FBB(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsGameCenterAppVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_5AF8A309B28FB076(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsRoutingAppCoverage>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_77E25C977BE79872(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_7834CE2D31F4D4DA(options);
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