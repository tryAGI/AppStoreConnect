
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_2BA68103F83BE0CA : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_2BA68103F83BE0CA Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_2BA68103F83BE0CA(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsApp)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsApp?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBuildIcon)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBuildIcon?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsCiProduct)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsCiProduct?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaGroup)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaGroup?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppStoreVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppStoreVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsPreReleaseVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsPreReleaseVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaAppLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaAppLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBuild)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBuild?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaLicenseAgreement)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaLicenseAgreement?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaAppReviewDetail)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaAppReviewDetail?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppInfo)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppInfo?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppClip)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppClip?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsEndUserLicenseAgreement)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsEndUserLicenseAgreement?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsInAppPurchase)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsInAppPurchase?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsSubscriptionGroup)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsSubscriptionGroup?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsGameCenterEnabledVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsGameCenterEnabledVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppCustomProductPage)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppCustomProductPage?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsPromotedPurchase)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsPromotedPurchase?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppEvent)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppEvent?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsReviewSubmission)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsReviewSubmission?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsSubscriptionGracePeriod)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsSubscriptionGracePeriod?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsGameCenterDetail)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsGameCenterDetail?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppStoreVersionExperiment)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppStoreVersionExperiment?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAndroidToIosAppMappingDetail)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAndroidToIosAppMappingDetail?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsApp))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsAppJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsApp?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsAppNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclarationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclarationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBuildIcon))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsBuildIconJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBuildIcon?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsBuildIconNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsCiProduct))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsCiProductJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsCiProduct?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsCiProductNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaGroup))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsBetaGroupJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaGroup?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsBetaGroupNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppStoreVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsAppStoreVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppStoreVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsAppStoreVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsPreReleaseVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsPreReleaseVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsPreReleaseVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsPreReleaseVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaAppLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsBetaAppLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaAppLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsBetaAppLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBuild))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsBuildJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBuild?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsBuildNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaLicenseAgreement))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsBetaLicenseAgreementJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaLicenseAgreement?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsBetaLicenseAgreementNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaAppReviewDetail))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsBetaAppReviewDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaAppReviewDetail?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsBetaAppReviewDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppInfo))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsAppInfoJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppInfo?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsAppInfoNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppClip))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsAppClipJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppClip?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsAppClipNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsEndUserLicenseAgreement))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsEndUserLicenseAgreementJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsEndUserLicenseAgreement?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsEndUserLicenseAgreementNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsInAppPurchase))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsInAppPurchaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsInAppPurchase?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsInAppPurchaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsSubscriptionGroup))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsSubscriptionGroupJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsSubscriptionGroup?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsSubscriptionGroupNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsGameCenterEnabledVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsGameCenterEnabledVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsGameCenterEnabledVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsGameCenterEnabledVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppCustomProductPage))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsAppCustomProductPageJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppCustomProductPage?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsAppCustomProductPageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsPromotedPurchase))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsPromotedPurchaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsPromotedPurchase?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsPromotedPurchaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppEvent))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsAppEventJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppEvent?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsAppEventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsReviewSubmission))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsReviewSubmissionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsReviewSubmission?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsReviewSubmissionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsSubscriptionGracePeriod))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsSubscriptionGracePeriodJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsSubscriptionGracePeriod?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsSubscriptionGracePeriodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsGameCenterDetail))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsGameCenterDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsGameCenterDetail?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsGameCenterDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppStoreVersionExperiment))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsAppStoreVersionExperimentJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppStoreVersionExperiment?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsAppStoreVersionExperimentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAndroidToIosAppMappingDetail))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsAndroidToIosAppMappingDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAndroidToIosAppMappingDetail?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedFieldsAndroidToIosAppMappingDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductsAppGetToOneRelatedIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAndroidToIosAppMappingDetail))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_CiProductsAppGetToOneRelatedFieldsAndroidToIosAppMappingDetail2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsApp))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_CiProductsAppGetToOneRelatedFieldsApp2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppClip))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_CiProductsAppGetToOneRelatedFieldsAppClip2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppCustomProductPage))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_CiProductsAppGetToOneRelatedFieldsAppCustomProductPage2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppEvent))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_CiProductsAppGetToOneRelatedFieldsAppEvent2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppInfo))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_CiProductsAppGetToOneRelatedFieldsAppInfo2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppStoreVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_CiProductsAppGetToOneRelatedFieldsAppStoreVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppStoreVersionExperiment))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_CiProductsAppGetToOneRelatedFieldsAppStoreVersionExperiment2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaAppLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_CiProductsAppGetToOneRelatedFieldsBetaAppLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaAppReviewDetail))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_CiProductsAppGetToOneRelatedFieldsBetaAppReviewDetail2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaGroup))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_CiProductsAppGetToOneRelatedFieldsBetaGroup2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaLicenseAgreement))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_CiProductsAppGetToOneRelatedFieldsBetaLicenseAgreement2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBuild))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_CiProductsAppGetToOneRelatedFieldsBuild2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBuildIcon))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_CiProductsAppGetToOneRelatedFieldsBuildIcon2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsCiProduct))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_CiProductsAppGetToOneRelatedFieldsCiProduct2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsEndUserLicenseAgreement))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_CiProductsAppGetToOneRelatedFieldsEndUserLicenseAgreement2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsGameCenterDetail))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_CiProductsAppGetToOneRelatedFieldsGameCenterDetail2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsGameCenterEnabledVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_CiProductsAppGetToOneRelatedFieldsGameCenterEnabledVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsInAppPurchase))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_CiProductsAppGetToOneRelatedFieldsInAppPurchase2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsPreReleaseVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_CiProductsAppGetToOneRelatedFieldsPreReleaseVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsPromotedPurchase))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_CiProductsAppGetToOneRelatedFieldsPromotedPurchase2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsReviewSubmission))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_CiProductsAppGetToOneRelatedFieldsReviewSubmission2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsSubscriptionGracePeriod))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_CiProductsAppGetToOneRelatedFieldsSubscriptionGracePeriod2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsSubscriptionGroup))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_CiProductsAppGetToOneRelatedFieldsSubscriptionGroup2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_CiProductsAppGetToOneRelatedIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAndroidToIosAppMappingDetail>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_C334E8A354B0A250(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsApp>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_CB1B8D0D6D980253(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppClip>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_3A035799EE4DD61B(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppCustomProductPage>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_F7C6B7BC723AFF0D(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_09BA25F81A27BCC6(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppEvent>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_480AC5E2F7BD456C(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppInfo>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_3059D2730D6B950B(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppStoreVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_ACB03D0F0B254BFF(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppStoreVersionExperiment>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_088395CEF22088D7(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaAppLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_D399652486B98A54(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaAppReviewDetail>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_BEAA12E4AF43A636(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaGroup>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_FFB7CA79BA84D115(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaLicenseAgreement>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_D7D85D2BC9B8A2DC(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBuild>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_D82A995B55598E92(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBuildIcon>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_5C460BF33DF5C19F(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsCiProduct>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_E28736FF7728C6BA(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsEndUserLicenseAgreement>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_A4E7B074A48CEE84(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsGameCenterDetail>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_9019F2BF5ADA7D0B(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsGameCenterEnabledVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_BEF97500316423E2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsInAppPurchase>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_7898F097FA579BC1(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsPreReleaseVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_F6D4649BD5A8383D(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsPromotedPurchase>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_B55B62FC3F327033(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsReviewSubmission>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_1C572F3A3A20646B(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsSubscriptionGracePeriod>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_64FC760EEA87943A(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsSubscriptionGroup>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_ED07AD8FFACEF78A(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsAppGetToOneRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_0AA6BF2358DA0440(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAndroidToIosAppMappingDetail?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiProductsAppGetToOneRelatedFieldsAndroidToIosAppMappingDetail2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsApp?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiProductsAppGetToOneRelatedFieldsApp2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppClip?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiProductsAppGetToOneRelatedFieldsAppClip2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppCustomProductPage?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiProductsAppGetToOneRelatedFieldsAppCustomProductPage2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppEvent?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiProductsAppGetToOneRelatedFieldsAppEvent2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppInfo?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiProductsAppGetToOneRelatedFieldsAppInfo2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppStoreVersion?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiProductsAppGetToOneRelatedFieldsAppStoreVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppStoreVersionExperiment?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiProductsAppGetToOneRelatedFieldsAppStoreVersionExperiment2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaAppLocalization?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiProductsAppGetToOneRelatedFieldsBetaAppLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaAppReviewDetail?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiProductsAppGetToOneRelatedFieldsBetaAppReviewDetail2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaGroup?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiProductsAppGetToOneRelatedFieldsBetaGroup2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaLicenseAgreement?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiProductsAppGetToOneRelatedFieldsBetaLicenseAgreement2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBuild?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiProductsAppGetToOneRelatedFieldsBuild2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBuildIcon?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiProductsAppGetToOneRelatedFieldsBuildIcon2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsCiProduct?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiProductsAppGetToOneRelatedFieldsCiProduct2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsEndUserLicenseAgreement?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiProductsAppGetToOneRelatedFieldsEndUserLicenseAgreement2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsGameCenterDetail?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiProductsAppGetToOneRelatedFieldsGameCenterDetail2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsGameCenterEnabledVersion?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiProductsAppGetToOneRelatedFieldsGameCenterEnabledVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsInAppPurchase?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiProductsAppGetToOneRelatedFieldsInAppPurchase2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsPreReleaseVersion?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiProductsAppGetToOneRelatedFieldsPreReleaseVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsPromotedPurchase?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiProductsAppGetToOneRelatedFieldsPromotedPurchase2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsReviewSubmission?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiProductsAppGetToOneRelatedFieldsReviewSubmission2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsSubscriptionGracePeriod?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiProductsAppGetToOneRelatedFieldsSubscriptionGracePeriod2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsSubscriptionGroup?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiProductsAppGetToOneRelatedFieldsSubscriptionGroup2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductsAppGetToOneRelatedIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableCiProductsAppGetToOneRelatedIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAndroidToIosAppMappingDetail>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_C21BDFBA703D2EDB(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsApp>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_A290DCB5A0045C8E(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppClip>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_F8E0AE8F92E2CE36(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppCustomProductPage>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_DC46728318B1F6AA(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppEncryptionDeclaration>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_2A0A0AA31F090BCB(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppEvent>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_3DA542541391A0CF(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppInfo>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_9028DA949D4ACFCF(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppStoreVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_6C10586401635580(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsAppStoreVersionExperiment>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_C7942167C06AE7E2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaAppLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_002B313B265F45A2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaAppReviewDetail>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_FC5577769525BE65(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaGroup>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_B817BD9636681F0C(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBetaLicenseAgreement>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_A1801A1152DC3476(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBuild>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_294007663535691B(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsBuildIcon>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_C295F8E17FB772E1(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsCiProduct>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_660633DD7F8CC9F6(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsEndUserLicenseAgreement>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_4E25E1D39D237C9C(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsGameCenterDetail>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_3C7DC257F143D67F(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsGameCenterEnabledVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_BFD54472860299A2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsInAppPurchase>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_282920E365FECBB1(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsPreReleaseVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_3123E39A45932D31(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsPromotedPurchase>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_49CAD57EB0BD4D73(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsReviewSubmission>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_117CC739FDE92A12(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsSubscriptionGracePeriod>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_5E48A0B71A776A50(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedFieldsSubscriptionGroup>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_F07BE42F22453002(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductsAppGetToOneRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_B83DCCA5F75563BE(options);
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