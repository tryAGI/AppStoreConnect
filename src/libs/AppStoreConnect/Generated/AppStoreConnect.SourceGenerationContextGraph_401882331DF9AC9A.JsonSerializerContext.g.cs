
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_401882331DF9AC9A : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_401882331DF9AC9A Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_401882331DF9AC9A(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBuild)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBuild?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsPreReleaseVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsPreReleaseVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBetaTester)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBetaTester?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBetaGroup)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBetaGroup?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBetaBuildLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBetaBuildLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsAppEncryptionDeclaration)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsAppEncryptionDeclaration?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBetaAppReviewSubmission)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBetaAppReviewSubmission?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsApp)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsApp?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBuildBetaDetail)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBuildBetaDetail?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsAppStoreVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsAppStoreVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBuildIcon)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBuildIcon?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBuildBundle)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBuildBundle?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBuildUpload)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBuildUpload?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBuild))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetInstanceFieldsBuildJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBuild?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetInstanceFieldsBuildNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsPreReleaseVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetInstanceFieldsPreReleaseVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsPreReleaseVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetInstanceFieldsPreReleaseVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBetaTester))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetInstanceFieldsBetaTesterJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBetaTester?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetInstanceFieldsBetaTesterNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBetaGroup))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetInstanceFieldsBetaGroupJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBetaGroup?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetInstanceFieldsBetaGroupNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBetaBuildLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetInstanceFieldsBetaBuildLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBetaBuildLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetInstanceFieldsBetaBuildLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsAppEncryptionDeclaration))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetInstanceFieldsAppEncryptionDeclarationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsAppEncryptionDeclaration?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetInstanceFieldsAppEncryptionDeclarationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBetaAppReviewSubmission))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetInstanceFieldsBetaAppReviewSubmissionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBetaAppReviewSubmission?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetInstanceFieldsBetaAppReviewSubmissionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsApp))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetInstanceFieldsAppJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsApp?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetInstanceFieldsAppNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBuildBetaDetail))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetInstanceFieldsBuildBetaDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBuildBetaDetail?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetInstanceFieldsBuildBetaDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsAppStoreVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetInstanceFieldsAppStoreVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsAppStoreVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetInstanceFieldsAppStoreVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBuildIcon))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetInstanceFieldsBuildIconJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBuildIcon?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetInstanceFieldsBuildIconNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBuildBundle))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetInstanceFieldsBuildBundleJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBuildBundle?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetInstanceFieldsBuildBundleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBuildUpload))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetInstanceFieldsBuildUploadJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBuildUpload?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetInstanceFieldsBuildUploadNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildsGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildsGetInstanceIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsApp))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_BuildsGetInstanceFieldsApp2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsAppEncryptionDeclaration))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_BuildsGetInstanceFieldsAppEncryptionDeclaration2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsAppStoreVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_BuildsGetInstanceFieldsAppStoreVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBetaAppReviewSubmission))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_BuildsGetInstanceFieldsBetaAppReviewSubmission2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBetaBuildLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_BuildsGetInstanceFieldsBetaBuildLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBetaGroup))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_BuildsGetInstanceFieldsBetaGroup2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBetaTester))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_BuildsGetInstanceFieldsBetaTester2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBuild))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_BuildsGetInstanceFieldsBuild2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBuildBetaDetail))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_BuildsGetInstanceFieldsBuildBetaDetail2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBuildBundle))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_BuildsGetInstanceFieldsBuildBundle2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBuildIcon))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_BuildsGetInstanceFieldsBuildIcon2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBuildUpload))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_BuildsGetInstanceFieldsBuildUpload2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsPreReleaseVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_BuildsGetInstanceFieldsPreReleaseVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsGetInstanceIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_BuildsGetInstanceIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetInstanceFieldsApp>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_6A5EA98EE33C6396(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetInstanceFieldsAppEncryptionDeclaration>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_3435B5B4AAAD5C7D(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetInstanceFieldsAppStoreVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_384164B6B9276F9C(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetInstanceFieldsBetaAppReviewSubmission>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_6AF42AC7B92F39F6(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetInstanceFieldsBetaBuildLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_AE8366E577452077(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetInstanceFieldsBetaGroup>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_B0DA52CFC9BF9618(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetInstanceFieldsBetaTester>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_930E2B28FE5160A5(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetInstanceFieldsBuild>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_49F51AC1EBAD400C(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetInstanceFieldsBuildBetaDetail>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_DCE9771F3D4209B7(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetInstanceFieldsBuildBundle>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_B1D6D647A0ED81F5(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetInstanceFieldsBuildIcon>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_4F9A6A935740592C(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetInstanceFieldsBuildUpload>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_ECAFE55C5636F9AB(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetInstanceFieldsPreReleaseVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_8C34FBED8840BA16(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_CD58BB8979A6A567(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsApp?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableBuildsGetInstanceFieldsApp2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsAppEncryptionDeclaration?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableBuildsGetInstanceFieldsAppEncryptionDeclaration2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsAppStoreVersion?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableBuildsGetInstanceFieldsAppStoreVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBetaAppReviewSubmission?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableBuildsGetInstanceFieldsBetaAppReviewSubmission2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBetaBuildLocalization?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableBuildsGetInstanceFieldsBetaBuildLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBetaGroup?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableBuildsGetInstanceFieldsBetaGroup2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBetaTester?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableBuildsGetInstanceFieldsBetaTester2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBuild?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableBuildsGetInstanceFieldsBuild2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBuildBetaDetail?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableBuildsGetInstanceFieldsBuildBetaDetail2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBuildBundle?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableBuildsGetInstanceFieldsBuildBundle2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBuildIcon?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableBuildsGetInstanceFieldsBuildIcon2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsBuildUpload?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableBuildsGetInstanceFieldsBuildUpload2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsGetInstanceFieldsPreReleaseVersion?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableBuildsGetInstanceFieldsPreReleaseVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildsGetInstanceIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableBuildsGetInstanceIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsGetInstanceFieldsApp>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_B018298AB932DB99(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsGetInstanceFieldsAppEncryptionDeclaration>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_BDC8C74D3714DAEF(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsGetInstanceFieldsAppStoreVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_5342FA2A1975F941(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsGetInstanceFieldsBetaAppReviewSubmission>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_C80960B25BD8971B(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsGetInstanceFieldsBetaBuildLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_75E94F2B08F90C7C(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsGetInstanceFieldsBetaGroup>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_F691C48F64DAF668(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsGetInstanceFieldsBetaTester>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_C79A574DA2D35279(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsGetInstanceFieldsBuild>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_2724F184F4D110BA(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsGetInstanceFieldsBuildBetaDetail>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_A3F4FDF1B00DBD24(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsGetInstanceFieldsBuildBundle>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_F846C24EF9E2F6C9(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsGetInstanceFieldsBuildIcon>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_D874E4A856B09D45(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsGetInstanceFieldsBuildUpload>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_15CEA1656FFDEFF6(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsGetInstanceFieldsPreReleaseVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_FDEB4E2428768386(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildsGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_C9F027652E21EF07(options);
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