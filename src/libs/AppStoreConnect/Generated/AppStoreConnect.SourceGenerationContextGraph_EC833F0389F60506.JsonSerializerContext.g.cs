
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_EC833F0389F60506 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_EC833F0389F60506 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_EC833F0389F60506(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterProcessingStateItem)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterProcessingStateItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterBetaAppReviewSubmissionBetaReviewStateItem)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterBetaAppReviewSubmissionBetaReviewStateItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterPreReleaseVersionPlatformItem)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterPreReleaseVersionPlatformItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterBuildAudienceTypeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterBuildAudienceTypeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedSortItem)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedSortItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuild)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuild?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsPreReleaseVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsPreReleaseVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaTester)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaTester?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaGroup)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaGroup?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaBuildLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaBuildLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsAppEncryptionDeclaration)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsAppEncryptionDeclaration?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaAppReviewSubmission)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaAppReviewSubmission?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsApp)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsApp?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildBetaDetail)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildBetaDetail?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildIcon)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildIcon?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildUpload)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildUpload?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterProcessingStateItem))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedFilterProcessingStateItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterProcessingStateItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedFilterProcessingStateItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterBetaAppReviewSubmissionBetaReviewStateItem))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedFilterBetaAppReviewSubmissionBetaReviewStateItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterBetaAppReviewSubmissionBetaReviewStateItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedFilterBetaAppReviewSubmissionBetaReviewStateItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterPreReleaseVersionPlatformItem))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedFilterPreReleaseVersionPlatformItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterPreReleaseVersionPlatformItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedFilterPreReleaseVersionPlatformItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterBuildAudienceTypeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedFilterBuildAudienceTypeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterBuildAudienceTypeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedFilterBuildAudienceTypeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedSortItem))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedSortItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedSortItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedSortItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuild))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedFieldsBuildJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuild?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedFieldsBuildNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsPreReleaseVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedFieldsPreReleaseVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsPreReleaseVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedFieldsPreReleaseVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaTester))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedFieldsBetaTesterJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaTester?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedFieldsBetaTesterNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaGroup))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedFieldsBetaGroupJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaGroup?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedFieldsBetaGroupNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaBuildLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedFieldsBetaBuildLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaBuildLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedFieldsBetaBuildLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsAppEncryptionDeclaration))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedFieldsAppEncryptionDeclarationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsAppEncryptionDeclaration?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedFieldsAppEncryptionDeclarationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaAppReviewSubmission))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedFieldsBetaAppReviewSubmissionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaAppReviewSubmission?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedFieldsBetaAppReviewSubmissionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsApp))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedFieldsAppJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsApp?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedFieldsAppNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildBetaDetail))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedFieldsBuildBetaDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildBetaDetail?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedFieldsBuildBetaDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildIcon))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedFieldsBuildIconJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildIcon?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedFieldsBuildIconNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundleJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildUpload))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedFieldsBuildUploadJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildUpload?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedFieldsBuildUploadNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildRunsBuildsGetToManyRelatedIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsApp))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_CiBuildRunsBuildsGetToManyRelatedFieldsApp2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsAppEncryptionDeclaration))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_CiBuildRunsBuildsGetToManyRelatedFieldsAppEncryptionDeclaration2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaAppReviewSubmission))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_CiBuildRunsBuildsGetToManyRelatedFieldsBetaAppReviewSubmission2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaBuildLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_CiBuildRunsBuildsGetToManyRelatedFieldsBetaBuildLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaGroup))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_CiBuildRunsBuildsGetToManyRelatedFieldsBetaGroup2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaTester))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_CiBuildRunsBuildsGetToManyRelatedFieldsBetaTester2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuild))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_CiBuildRunsBuildsGetToManyRelatedFieldsBuild2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildBetaDetail))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_CiBuildRunsBuildsGetToManyRelatedFieldsBuildBetaDetail2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildIcon))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_CiBuildRunsBuildsGetToManyRelatedFieldsBuildIcon2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildUpload))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_CiBuildRunsBuildsGetToManyRelatedFieldsBuildUpload2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsPreReleaseVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_CiBuildRunsBuildsGetToManyRelatedFieldsPreReleaseVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterBetaAppReviewSubmissionBetaReviewStateItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_CiBuildRunsBuildsGetToManyRelatedFilterBetaAppReviewSubmissionBetaReviewStateItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterBuildAudienceTypeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_CiBuildRunsBuildsGetToManyRelatedFilterBuildAudienceTypeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterPreReleaseVersionPlatformItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_CiBuildRunsBuildsGetToManyRelatedFilterPreReleaseVersionPlatformItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterProcessingStateItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_CiBuildRunsBuildsGetToManyRelatedFilterProcessingStateItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_CiBuildRunsBuildsGetToManyRelatedIncludeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedSortItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_CiBuildRunsBuildsGetToManyRelatedSortItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsApp>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_F0FA27D3843C255B(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsAppEncryptionDeclaration>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_11590775787E6845(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_D5A2C79937674133(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaAppReviewSubmission>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_04601AAC4B50E785(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaBuildLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_37B817AB98AE0330(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaGroup>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_442EDE3993E4DB0F(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaTester>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_5BB9C84B97573C3F(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuild>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_451F999DDE69B3BB(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildBetaDetail>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_062725E42A7995AA(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_BDDB7EAFBC5182B6(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildIcon>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_9D8AA83C552E0DB9(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildUpload>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_FAC69ACA4C9846CF(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsPreReleaseVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_7754CE19832BF62D(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterBetaAppReviewSubmissionBetaReviewStateItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_6BC3F6A7F445A280(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterBuildAudienceTypeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_289370B56FBC4D95(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterPreReleaseVersionPlatformItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_B33485954D19CBFC(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterProcessingStateItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_85101A3D6483CECE(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_B37D206910DF3E92(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedSortItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_DC40205279A8436B(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsApp?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiBuildRunsBuildsGetToManyRelatedFieldsApp2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsAppEncryptionDeclaration?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiBuildRunsBuildsGetToManyRelatedFieldsAppEncryptionDeclaration2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaAppReviewSubmission?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiBuildRunsBuildsGetToManyRelatedFieldsBetaAppReviewSubmission2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaBuildLocalization?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiBuildRunsBuildsGetToManyRelatedFieldsBetaBuildLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaGroup?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiBuildRunsBuildsGetToManyRelatedFieldsBetaGroup2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaTester?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiBuildRunsBuildsGetToManyRelatedFieldsBetaTester2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuild?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiBuildRunsBuildsGetToManyRelatedFieldsBuild2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildBetaDetail?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiBuildRunsBuildsGetToManyRelatedFieldsBuildBetaDetail2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildIcon?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiBuildRunsBuildsGetToManyRelatedFieldsBuildIcon2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildUpload?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiBuildRunsBuildsGetToManyRelatedFieldsBuildUpload2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsPreReleaseVersion?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiBuildRunsBuildsGetToManyRelatedFieldsPreReleaseVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterBetaAppReviewSubmissionBetaReviewStateItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiBuildRunsBuildsGetToManyRelatedFilterBetaAppReviewSubmissionBetaReviewStateItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterBuildAudienceTypeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiBuildRunsBuildsGetToManyRelatedFilterBuildAudienceTypeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterPreReleaseVersionPlatformItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiBuildRunsBuildsGetToManyRelatedFilterPreReleaseVersionPlatformItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterProcessingStateItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiBuildRunsBuildsGetToManyRelatedFilterProcessingStateItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiBuildRunsBuildsGetToManyRelatedIncludeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedSortItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiBuildRunsBuildsGetToManyRelatedSortItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsApp>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_DDC5E0E2B1FC15AA(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsAppEncryptionDeclaration>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_505EDECDD0F123B1(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_EB691ED08F71BEE1(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaAppReviewSubmission>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_EADA6AEC0DE5B121(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaBuildLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_35BF8E3DEBD64C89(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaGroup>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_67A0D965CE3E83D9(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBetaTester>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_FACA24FF983815FC(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuild>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_69BBC9365648243D(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildBetaDetail>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_7065037529A4C773(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_AEF1C3D22A5F80C9(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildIcon>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_C642A5E71195EE11(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsBuildUpload>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_1C6CD0B16F16472F(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFieldsPreReleaseVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_4A9D911F609BD7B3(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterBetaAppReviewSubmissionBetaReviewStateItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_45FFC8BDF0EB5DCE(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterBuildAudienceTypeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_2CD7F85D055C13D0(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterPreReleaseVersionPlatformItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_0C899A2323423B1D(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedFilterProcessingStateItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_3B16071467C5FD05(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_13B961C7CABE0F0B(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildRunsBuildsGetToManyRelatedSortItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_51855980FF3DAD5F(options);
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