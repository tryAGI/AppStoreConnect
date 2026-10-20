
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_5772E201F89FA5CE : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_5772E201F89FA5CE Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_5772E201F89FA5CE(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuild)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuild?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsPreReleaseVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsPreReleaseVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBetaTester)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBetaTester?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBetaGroup)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBetaGroup?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBetaBuildLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBetaBuildLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsAppEncryptionDeclaration)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsAppEncryptionDeclaration?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBetaAppReviewSubmission)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBetaAppReviewSubmission?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsApp)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsApp?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBetaDetail)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBetaDetail?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuildIcon)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuildIcon?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundle)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundle?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuildUpload)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuildUpload?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuild))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBetaDetailsBuildGetToOneRelatedFieldsBuildJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuild?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBetaDetailsBuildGetToOneRelatedFieldsBuildNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsPreReleaseVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBetaDetailsBuildGetToOneRelatedFieldsPreReleaseVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsPreReleaseVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBetaDetailsBuildGetToOneRelatedFieldsPreReleaseVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBetaTester))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBetaDetailsBuildGetToOneRelatedFieldsBetaTesterJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBetaTester?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBetaDetailsBuildGetToOneRelatedFieldsBetaTesterNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBetaGroup))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBetaDetailsBuildGetToOneRelatedFieldsBetaGroupJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBetaGroup?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBetaDetailsBuildGetToOneRelatedFieldsBetaGroupNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBetaBuildLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBetaDetailsBuildGetToOneRelatedFieldsBetaBuildLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBetaBuildLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBetaDetailsBuildGetToOneRelatedFieldsBetaBuildLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsAppEncryptionDeclaration))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBetaDetailsBuildGetToOneRelatedFieldsAppEncryptionDeclarationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsAppEncryptionDeclaration?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBetaDetailsBuildGetToOneRelatedFieldsAppEncryptionDeclarationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBetaAppReviewSubmission))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBetaDetailsBuildGetToOneRelatedFieldsBetaAppReviewSubmissionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBetaAppReviewSubmission?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBetaDetailsBuildGetToOneRelatedFieldsBetaAppReviewSubmissionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsApp))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBetaDetailsBuildGetToOneRelatedFieldsAppJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsApp?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBetaDetailsBuildGetToOneRelatedFieldsAppNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBetaDetail))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBetaDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBetaDetail?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBetaDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuildIcon))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBetaDetailsBuildGetToOneRelatedFieldsBuildIconJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuildIcon?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBetaDetailsBuildGetToOneRelatedFieldsBuildIconNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundle))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundleJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundle?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuildUpload))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBetaDetailsBuildGetToOneRelatedFieldsBuildUploadJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuildUpload?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBetaDetailsBuildGetToOneRelatedFieldsBuildUploadNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBetaDetailsBuildGetToOneRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBetaDetailsBuildGetToOneRelatedIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsApp))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_BuildBetaDetailsBuildGetToOneRelatedFieldsApp2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsAppEncryptionDeclaration))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_BuildBetaDetailsBuildGetToOneRelatedFieldsAppEncryptionDeclaration2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_BuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBetaAppReviewSubmission))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_BuildBetaDetailsBuildGetToOneRelatedFieldsBetaAppReviewSubmission2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBetaBuildLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_BuildBetaDetailsBuildGetToOneRelatedFieldsBetaBuildLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBetaGroup))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_BuildBetaDetailsBuildGetToOneRelatedFieldsBetaGroup2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBetaTester))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_BuildBetaDetailsBuildGetToOneRelatedFieldsBetaTester2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuild))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_BuildBetaDetailsBuildGetToOneRelatedFieldsBuild2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBetaDetail))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBetaDetail2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundle))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundle2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuildIcon))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_BuildBetaDetailsBuildGetToOneRelatedFieldsBuildIcon2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuildUpload))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_BuildBetaDetailsBuildGetToOneRelatedFieldsBuildUpload2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsPreReleaseVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_BuildBetaDetailsBuildGetToOneRelatedFieldsPreReleaseVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_BuildBetaDetailsBuildGetToOneRelatedIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsApp>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_CECAD99B1A68F5D5(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsAppEncryptionDeclaration>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_F595AB876C6142CD(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_DFBCAD1056129008(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBetaAppReviewSubmission>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_D9FAB5FE10520A4C(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBetaBuildLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_2C540EEB27B72E82(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBetaGroup>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_3885C9BEC616FA35(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBetaTester>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_71F5CC447DD80E69(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuild>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_F217C4633094A382(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBetaDetail>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_ABE00945DDA1FE5E(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundle>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_01A0AC9EBAE19043(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuildIcon>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_B2944F87D637D7FE(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuildUpload>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_3AB9CC4461F4DDBC(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsPreReleaseVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_8C47BE6A7C67EF31(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_EFA9396552AA6EE9(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsApp?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableBuildBetaDetailsBuildGetToOneRelatedFieldsApp2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsAppEncryptionDeclaration?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableBuildBetaDetailsBuildGetToOneRelatedFieldsAppEncryptionDeclaration2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersion?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableBuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBetaAppReviewSubmission?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableBuildBetaDetailsBuildGetToOneRelatedFieldsBetaAppReviewSubmission2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBetaBuildLocalization?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableBuildBetaDetailsBuildGetToOneRelatedFieldsBetaBuildLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBetaGroup?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableBuildBetaDetailsBuildGetToOneRelatedFieldsBetaGroup2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBetaTester?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableBuildBetaDetailsBuildGetToOneRelatedFieldsBetaTester2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuild?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableBuildBetaDetailsBuildGetToOneRelatedFieldsBuild2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBetaDetail?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableBuildBetaDetailsBuildGetToOneRelatedFieldsBuildBetaDetail2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundle?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableBuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundle2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuildIcon?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableBuildBetaDetailsBuildGetToOneRelatedFieldsBuildIcon2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuildUpload?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableBuildBetaDetailsBuildGetToOneRelatedFieldsBuildUpload2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsPreReleaseVersion?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableBuildBetaDetailsBuildGetToOneRelatedFieldsPreReleaseVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableBuildBetaDetailsBuildGetToOneRelatedIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsApp>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_B6D1F290E6B4E5D3(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsAppEncryptionDeclaration>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_7A98B63B134D5B08(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_0AF9B2404354F6F6(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBetaAppReviewSubmission>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_E3A4759DC46EE646(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBetaBuildLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_D5F63CFAA8D4A2DC(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBetaGroup>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_B94DA6CE5618B7AC(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBetaTester>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_042300925B9B5209(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuild>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_33E5D2971C7B6B48(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBetaDetail>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_E683BBDA37DD5868(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundle>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_159B947F6ECA6471(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuildIcon>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_C859A0F0F1477FAF(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsBuildUpload>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_5236B301A0912887(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedFieldsPreReleaseVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_193EEBE6C2249B98(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildBetaDetailsBuildGetToOneRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_70163942A6DC0732(options);
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