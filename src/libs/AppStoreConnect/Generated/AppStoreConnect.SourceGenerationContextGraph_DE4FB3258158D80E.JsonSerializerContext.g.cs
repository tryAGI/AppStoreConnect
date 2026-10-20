
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_DE4FB3258158D80E : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_DE4FB3258158D80E Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_DE4FB3258158D80E(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFilterProcessingStateItem)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFilterProcessingStateItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFilterBetaAppReviewSubmissionBetaReviewStateItem)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFilterBetaAppReviewSubmissionBetaReviewStateItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFilterPreReleaseVersionPlatformItem)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFilterPreReleaseVersionPlatformItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFilterBuildAudienceTypeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFilterBuildAudienceTypeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionSortItem)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionSortItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBuild)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBuild?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsPreReleaseVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsPreReleaseVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBetaTester)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBetaTester?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBetaGroup)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBetaGroup?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBetaBuildLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBetaBuildLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsAppEncryptionDeclaration)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsAppEncryptionDeclaration?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBetaAppReviewSubmission)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBetaAppReviewSubmission?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsApp)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsApp?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBuildBetaDetail)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBuildBetaDetail?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsAppStoreVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsAppStoreVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBuildIcon)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBuildIcon?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBuildBundle)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBuildBundle?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBuildUpload)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBuildUpload?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFilterProcessingStateItem))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionFilterProcessingStateItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFilterProcessingStateItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionFilterProcessingStateItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFilterBetaAppReviewSubmissionBetaReviewStateItem))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionFilterBetaAppReviewSubmissionBetaReviewStateItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFilterBetaAppReviewSubmissionBetaReviewStateItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionFilterBetaAppReviewSubmissionBetaReviewStateItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFilterPreReleaseVersionPlatformItem))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionFilterPreReleaseVersionPlatformItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFilterPreReleaseVersionPlatformItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionFilterPreReleaseVersionPlatformItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFilterBuildAudienceTypeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionFilterBuildAudienceTypeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFilterBuildAudienceTypeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionFilterBuildAudienceTypeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionSortItem))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionSortItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionSortItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionSortItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBuild))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionFieldsBuildJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBuild?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionFieldsBuildNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsPreReleaseVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionFieldsPreReleaseVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsPreReleaseVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionFieldsPreReleaseVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBetaTester))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionFieldsBetaTesterJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBetaTester?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionFieldsBetaTesterNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBetaGroup))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionFieldsBetaGroupJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBetaGroup?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionFieldsBetaGroupNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBetaBuildLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionFieldsBetaBuildLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBetaBuildLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionFieldsBetaBuildLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsAppEncryptionDeclaration))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionFieldsAppEncryptionDeclarationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsAppEncryptionDeclaration?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionFieldsAppEncryptionDeclarationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBetaAppReviewSubmission))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionFieldsBetaAppReviewSubmissionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBetaAppReviewSubmission?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionFieldsBetaAppReviewSubmissionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsApp))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionFieldsAppJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsApp?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionFieldsAppNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBuildBetaDetail))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionFieldsBuildBetaDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBuildBetaDetail?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionFieldsBuildBetaDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsAppStoreVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionFieldsAppStoreVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsAppStoreVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionFieldsAppStoreVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBuildIcon))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionFieldsBuildIconJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBuildIcon?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionFieldsBuildIconNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBuildBundle))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionFieldsBuildBundleJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBuildBundle?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionFieldsBuildBundleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBuildUpload))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionFieldsBuildUploadJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBuildUpload?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionFieldsBuildUploadNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetCollectionIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetCollectionIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsApp))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_BuildsGetCollectionFieldsApp2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsAppEncryptionDeclaration))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_BuildsGetCollectionFieldsAppEncryptionDeclaration2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsAppStoreVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_BuildsGetCollectionFieldsAppStoreVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBetaAppReviewSubmission))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_BuildsGetCollectionFieldsBetaAppReviewSubmission2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBetaBuildLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_BuildsGetCollectionFieldsBetaBuildLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBetaGroup))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_BuildsGetCollectionFieldsBetaGroup2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBetaTester))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_BuildsGetCollectionFieldsBetaTester2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBuild))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_BuildsGetCollectionFieldsBuild2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBuildBetaDetail))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_BuildsGetCollectionFieldsBuildBetaDetail2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBuildBundle))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_BuildsGetCollectionFieldsBuildBundle2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBuildIcon))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_BuildsGetCollectionFieldsBuildIcon2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBuildUpload))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_BuildsGetCollectionFieldsBuildUpload2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsPreReleaseVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_BuildsGetCollectionFieldsPreReleaseVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsGetCollectionFilterBetaAppReviewSubmissionBetaReviewStateItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_BuildsGetCollectionFilterBetaAppReviewSubmissionBetaReviewStateItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsGetCollectionFilterBuildAudienceTypeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_BuildsGetCollectionFilterBuildAudienceTypeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsGetCollectionFilterPreReleaseVersionPlatformItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_BuildsGetCollectionFilterPreReleaseVersionPlatformItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsGetCollectionFilterProcessingStateItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_BuildsGetCollectionFilterProcessingStateItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsGetCollectionIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_BuildsGetCollectionIncludeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsGetCollectionSortItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_BuildsGetCollectionSortItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionFieldsApp>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_F368EACF67B347A5(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionFieldsAppEncryptionDeclaration>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_99312C6FAA30BBE1(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionFieldsAppStoreVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_F9A5AB1E79195FDA(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionFieldsBetaAppReviewSubmission>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_56954AC6E33E3CC1(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionFieldsBetaBuildLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_09660857ECDE51C3(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionFieldsBetaGroup>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_CB457D971AE6B2DA(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionFieldsBetaTester>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_D77200E67E4EC7B8(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionFieldsBuild>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_3142F60115BA1BC5(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionFieldsBuildBetaDetail>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_5B541003A3E9B3FD(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionFieldsBuildBundle>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_17025D2D79DEA41C(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionFieldsBuildIcon>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_48973EFA259648B5(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionFieldsBuildUpload>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_7C7C2FF008556A48(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionFieldsPreReleaseVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_1BFB684EF57CF15A(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionFilterBetaAppReviewSubmissionBetaReviewStateItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_401089F046426E7A(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionFilterBuildAudienceTypeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_959FA0C35DEFFAB6(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionFilterPreReleaseVersionPlatformItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_7299D6BE4319484D(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionFilterProcessingStateItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_F7D463680307A6D9(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_0A4AE305F080FA32(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetCollectionSortItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_405224328DD2AAA7(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsApp?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableBuildsGetCollectionFieldsApp2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsAppEncryptionDeclaration?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableBuildsGetCollectionFieldsAppEncryptionDeclaration2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsAppStoreVersion?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableBuildsGetCollectionFieldsAppStoreVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBetaAppReviewSubmission?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableBuildsGetCollectionFieldsBetaAppReviewSubmission2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBetaBuildLocalization?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableBuildsGetCollectionFieldsBetaBuildLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBetaGroup?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableBuildsGetCollectionFieldsBetaGroup2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBetaTester?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableBuildsGetCollectionFieldsBetaTester2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBuild?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableBuildsGetCollectionFieldsBuild2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBuildBetaDetail?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableBuildsGetCollectionFieldsBuildBetaDetail2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBuildBundle?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableBuildsGetCollectionFieldsBuildBundle2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBuildIcon?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableBuildsGetCollectionFieldsBuildIcon2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsBuildUpload?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableBuildsGetCollectionFieldsBuildUpload2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsGetCollectionFieldsPreReleaseVersion?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableBuildsGetCollectionFieldsPreReleaseVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsGetCollectionFilterBetaAppReviewSubmissionBetaReviewStateItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableBuildsGetCollectionFilterBetaAppReviewSubmissionBetaReviewStateItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsGetCollectionFilterBuildAudienceTypeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableBuildsGetCollectionFilterBuildAudienceTypeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsGetCollectionFilterPreReleaseVersionPlatformItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableBuildsGetCollectionFilterPreReleaseVersionPlatformItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsGetCollectionFilterProcessingStateItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableBuildsGetCollectionFilterProcessingStateItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsGetCollectionIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableBuildsGetCollectionIncludeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsGetCollectionSortItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableBuildsGetCollectionSortItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsGetCollectionFieldsApp>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_34D2E86839A7935C(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsGetCollectionFieldsAppEncryptionDeclaration>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_938A181908C17C82(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsGetCollectionFieldsAppStoreVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_9CC0653E6FA68AE4(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsGetCollectionFieldsBetaAppReviewSubmission>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_EF16B73CAA76931C(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsGetCollectionFieldsBetaBuildLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_16170D24EE5CC8EF(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsGetCollectionFieldsBetaGroup>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_E7F570038BEE6427(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsGetCollectionFieldsBetaTester>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_9A04C74CD9C80998(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsGetCollectionFieldsBuild>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_C095F4ACB4F5F4AD(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsGetCollectionFieldsBuildBetaDetail>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_B230F41246F5C028(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsGetCollectionFieldsBuildBundle>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_023FE8024D8E9FE7(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsGetCollectionFieldsBuildIcon>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_34A69DF171F39F53(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsGetCollectionFieldsBuildUpload>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_4BFA3B18A1F2C3AA(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsGetCollectionFieldsPreReleaseVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_936C33ADAF7F8B01(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsGetCollectionFilterBetaAppReviewSubmissionBetaReviewStateItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_BF8F47CCC093CA38(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsGetCollectionFilterBuildAudienceTypeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_E531DC64CFAF01CF(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsGetCollectionFilterPreReleaseVersionPlatformItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_717AFEA6FB4AE290(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsGetCollectionFilterProcessingStateItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_6B4FB7539C8762F5(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsGetCollectionIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_E1770716D26A33F3(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsGetCollectionSortItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_744A2CF60107F0E4(options);
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