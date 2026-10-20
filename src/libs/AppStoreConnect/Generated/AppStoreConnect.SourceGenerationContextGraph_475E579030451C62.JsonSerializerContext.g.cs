
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_475E579030451C62 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_475E579030451C62 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_475E579030451C62(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsApp)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsApp?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsAppEncryptionDeclaration)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsAppEncryptionDeclaration?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsBuildIcon)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsBuildIcon?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsCiProduct)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsCiProduct?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsBetaGroup)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsBetaGroup?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsAppStoreVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsAppStoreVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsPreReleaseVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsPreReleaseVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsBetaAppLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsBetaAppLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsBuild)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsBuild?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsBetaLicenseAgreement)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsBetaLicenseAgreement?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsBetaAppReviewDetail)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsBetaAppReviewDetail?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsAppInfo)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsAppInfo?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsAppClip)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsAppClip?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsEndUserLicenseAgreement)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsEndUserLicenseAgreement?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsInAppPurchase)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsInAppPurchase?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsSubscriptionGroup)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsSubscriptionGroup?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsGameCenterEnabledVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsGameCenterEnabledVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsAppCustomProductPage)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsAppCustomProductPage?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsPromotedPurchase)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsPromotedPurchase?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsAppEvent)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsAppEvent?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsReviewSubmission)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsReviewSubmission?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsSubscriptionGracePeriod)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsSubscriptionGracePeriod?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsGameCenterDetail)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsGameCenterDetail?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsAppStoreVersionExperiment)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsAppStoreVersionExperiment?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsAndroidToIosAppMappingDetail)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsAndroidToIosAppMappingDetail?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsApp))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetInstanceFieldsAppJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsApp?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetInstanceFieldsAppNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsAppEncryptionDeclaration))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetInstanceFieldsAppEncryptionDeclarationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsAppEncryptionDeclaration?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetInstanceFieldsAppEncryptionDeclarationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsBuildIcon))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetInstanceFieldsBuildIconJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsBuildIcon?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetInstanceFieldsBuildIconNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsCiProduct))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetInstanceFieldsCiProductJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsCiProduct?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetInstanceFieldsCiProductNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsBetaGroup))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetInstanceFieldsBetaGroupJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsBetaGroup?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetInstanceFieldsBetaGroupNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsAppStoreVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetInstanceFieldsAppStoreVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsAppStoreVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetInstanceFieldsAppStoreVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsPreReleaseVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetInstanceFieldsPreReleaseVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsPreReleaseVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetInstanceFieldsPreReleaseVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsBetaAppLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetInstanceFieldsBetaAppLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsBetaAppLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetInstanceFieldsBetaAppLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsBuild))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetInstanceFieldsBuildJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsBuild?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetInstanceFieldsBuildNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsBetaLicenseAgreement))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetInstanceFieldsBetaLicenseAgreementJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsBetaLicenseAgreement?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetInstanceFieldsBetaLicenseAgreementNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsBetaAppReviewDetail))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetInstanceFieldsBetaAppReviewDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsBetaAppReviewDetail?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetInstanceFieldsBetaAppReviewDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsAppInfo))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetInstanceFieldsAppInfoJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsAppInfo?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetInstanceFieldsAppInfoNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsAppClip))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetInstanceFieldsAppClipJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsAppClip?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetInstanceFieldsAppClipNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsEndUserLicenseAgreement))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetInstanceFieldsEndUserLicenseAgreementJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsEndUserLicenseAgreement?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetInstanceFieldsEndUserLicenseAgreementNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsInAppPurchase))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetInstanceFieldsInAppPurchaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsInAppPurchase?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetInstanceFieldsInAppPurchaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsSubscriptionGroup))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetInstanceFieldsSubscriptionGroupJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsSubscriptionGroup?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetInstanceFieldsSubscriptionGroupNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsGameCenterEnabledVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetInstanceFieldsGameCenterEnabledVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsGameCenterEnabledVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetInstanceFieldsGameCenterEnabledVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsAppCustomProductPage))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetInstanceFieldsAppCustomProductPageJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsAppCustomProductPage?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetInstanceFieldsAppCustomProductPageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsPromotedPurchase))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetInstanceFieldsPromotedPurchaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsPromotedPurchase?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetInstanceFieldsPromotedPurchaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsAppEvent))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetInstanceFieldsAppEventJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsAppEvent?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetInstanceFieldsAppEventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsReviewSubmission))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetInstanceFieldsReviewSubmissionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsReviewSubmission?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetInstanceFieldsReviewSubmissionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsSubscriptionGracePeriod))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetInstanceFieldsSubscriptionGracePeriodJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsSubscriptionGracePeriod?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetInstanceFieldsSubscriptionGracePeriodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsGameCenterDetail))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetInstanceFieldsGameCenterDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsGameCenterDetail?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetInstanceFieldsGameCenterDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsAppStoreVersionExperiment))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetInstanceFieldsAppStoreVersionExperimentJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsAppStoreVersionExperiment?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetInstanceFieldsAppStoreVersionExperimentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsAndroidToIosAppMappingDetail))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetInstanceFieldsAndroidToIosAppMappingDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceFieldsAndroidToIosAppMappingDetail?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetInstanceFieldsAndroidToIosAppMappingDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetInstanceIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.AppsGetInstanceFieldsAndroidToIosAppMappingDetail))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppsGetInstanceFieldsAndroidToIosAppMappingDetail2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetInstanceFieldsApp))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppsGetInstanceFieldsApp2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetInstanceFieldsAppClip))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppsGetInstanceFieldsAppClip2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetInstanceFieldsAppCustomProductPage))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppsGetInstanceFieldsAppCustomProductPage2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetInstanceFieldsAppEncryptionDeclaration))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppsGetInstanceFieldsAppEncryptionDeclaration2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetInstanceFieldsAppEvent))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppsGetInstanceFieldsAppEvent2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetInstanceFieldsAppInfo))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppsGetInstanceFieldsAppInfo2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetInstanceFieldsAppStoreVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppsGetInstanceFieldsAppStoreVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetInstanceFieldsAppStoreVersionExperiment))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppsGetInstanceFieldsAppStoreVersionExperiment2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetInstanceFieldsBetaAppLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppsGetInstanceFieldsBetaAppLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetInstanceFieldsBetaAppReviewDetail))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppsGetInstanceFieldsBetaAppReviewDetail2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetInstanceFieldsBetaGroup))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppsGetInstanceFieldsBetaGroup2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetInstanceFieldsBetaLicenseAgreement))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppsGetInstanceFieldsBetaLicenseAgreement2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetInstanceFieldsBuild))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppsGetInstanceFieldsBuild2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetInstanceFieldsBuildIcon))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppsGetInstanceFieldsBuildIcon2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetInstanceFieldsCiProduct))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppsGetInstanceFieldsCiProduct2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetInstanceFieldsEndUserLicenseAgreement))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppsGetInstanceFieldsEndUserLicenseAgreement2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetInstanceFieldsGameCenterDetail))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppsGetInstanceFieldsGameCenterDetail2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetInstanceFieldsGameCenterEnabledVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppsGetInstanceFieldsGameCenterEnabledVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetInstanceFieldsInAppPurchase))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppsGetInstanceFieldsInAppPurchase2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetInstanceFieldsPreReleaseVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppsGetInstanceFieldsPreReleaseVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetInstanceFieldsPromotedPurchase))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppsGetInstanceFieldsPromotedPurchase2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetInstanceFieldsReviewSubmission))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppsGetInstanceFieldsReviewSubmission2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetInstanceFieldsSubscriptionGracePeriod))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppsGetInstanceFieldsSubscriptionGracePeriod2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetInstanceFieldsSubscriptionGroup))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppsGetInstanceFieldsSubscriptionGroup2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetInstanceIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppsGetInstanceIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetInstanceFieldsAndroidToIosAppMappingDetail>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_1477A1C43576A4D2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetInstanceFieldsApp>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_E92A1107AEEA5F3C(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetInstanceFieldsAppClip>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_4C1BD8F8872BC1DB(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetInstanceFieldsAppCustomProductPage>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_AB4336F1FE3EB719(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetInstanceFieldsAppEncryptionDeclaration>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_34CFEF437265FA56(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetInstanceFieldsAppEvent>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_1BD5F6961E3EDCCA(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetInstanceFieldsAppInfo>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_C23547ADF4A36162(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetInstanceFieldsAppStoreVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_BC92A2887453D099(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetInstanceFieldsAppStoreVersionExperiment>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_8548A00352560B63(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetInstanceFieldsBetaAppLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_0AE57A44743CFACC(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetInstanceFieldsBetaAppReviewDetail>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_37715081B23BD10C(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetInstanceFieldsBetaGroup>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_A1D233B458BF03E5(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetInstanceFieldsBetaLicenseAgreement>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_5744794763E01D77(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetInstanceFieldsBuild>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_AB9DE31AB0212639(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetInstanceFieldsBuildIcon>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_CD54950FE4B6FB23(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetInstanceFieldsCiProduct>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_7EB9C352E1210EB3(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetInstanceFieldsEndUserLicenseAgreement>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_090FE09093797277(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetInstanceFieldsGameCenterDetail>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_50194856AF8CD3D6(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetInstanceFieldsGameCenterEnabledVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_80F13FA4A16849E6(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetInstanceFieldsInAppPurchase>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_0CD986E2D4CC9F25(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetInstanceFieldsPreReleaseVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_67287147C6B23B26(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetInstanceFieldsPromotedPurchase>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_B47482578473ACEB(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetInstanceFieldsReviewSubmission>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_0EF60FB0768A8DC2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetInstanceFieldsSubscriptionGracePeriod>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_6E9238735C0E43F4(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetInstanceFieldsSubscriptionGroup>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_DF47964D214725BF(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_63C197062B1D667C(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetInstanceFieldsAndroidToIosAppMappingDetail?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppsGetInstanceFieldsAndroidToIosAppMappingDetail2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetInstanceFieldsApp?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppsGetInstanceFieldsApp2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetInstanceFieldsAppClip?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppsGetInstanceFieldsAppClip2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetInstanceFieldsAppCustomProductPage?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppsGetInstanceFieldsAppCustomProductPage2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetInstanceFieldsAppEncryptionDeclaration?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppsGetInstanceFieldsAppEncryptionDeclaration2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetInstanceFieldsAppEvent?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppsGetInstanceFieldsAppEvent2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetInstanceFieldsAppInfo?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppsGetInstanceFieldsAppInfo2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetInstanceFieldsAppStoreVersion?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppsGetInstanceFieldsAppStoreVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetInstanceFieldsAppStoreVersionExperiment?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppsGetInstanceFieldsAppStoreVersionExperiment2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetInstanceFieldsBetaAppLocalization?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppsGetInstanceFieldsBetaAppLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetInstanceFieldsBetaAppReviewDetail?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppsGetInstanceFieldsBetaAppReviewDetail2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetInstanceFieldsBetaGroup?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppsGetInstanceFieldsBetaGroup2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetInstanceFieldsBetaLicenseAgreement?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppsGetInstanceFieldsBetaLicenseAgreement2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetInstanceFieldsBuild?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppsGetInstanceFieldsBuild2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetInstanceFieldsBuildIcon?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppsGetInstanceFieldsBuildIcon2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetInstanceFieldsCiProduct?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppsGetInstanceFieldsCiProduct2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetInstanceFieldsEndUserLicenseAgreement?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppsGetInstanceFieldsEndUserLicenseAgreement2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetInstanceFieldsGameCenterDetail?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppsGetInstanceFieldsGameCenterDetail2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetInstanceFieldsGameCenterEnabledVersion?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppsGetInstanceFieldsGameCenterEnabledVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetInstanceFieldsInAppPurchase?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppsGetInstanceFieldsInAppPurchase2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetInstanceFieldsPreReleaseVersion?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppsGetInstanceFieldsPreReleaseVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetInstanceFieldsPromotedPurchase?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppsGetInstanceFieldsPromotedPurchase2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetInstanceFieldsReviewSubmission?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppsGetInstanceFieldsReviewSubmission2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetInstanceFieldsSubscriptionGracePeriod?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppsGetInstanceFieldsSubscriptionGracePeriod2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetInstanceFieldsSubscriptionGroup?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppsGetInstanceFieldsSubscriptionGroup2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetInstanceIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppsGetInstanceIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGetInstanceFieldsAndroidToIosAppMappingDetail>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_58D5397AFEB6BDFD(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGetInstanceFieldsApp>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_D4177A393B7C84D1(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGetInstanceFieldsAppClip>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_74EB88C1B1A37085(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGetInstanceFieldsAppCustomProductPage>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_CED88913CAE235D8(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGetInstanceFieldsAppEncryptionDeclaration>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_D8AB16E5B28FD90F(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGetInstanceFieldsAppEvent>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_57D2F4A90C428244(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGetInstanceFieldsAppInfo>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_0373731A51B1EE86(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGetInstanceFieldsAppStoreVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_8D9A7A0973C7C5EC(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGetInstanceFieldsAppStoreVersionExperiment>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_A804AC7FB5A81718(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGetInstanceFieldsBetaAppLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_F430BDAED6D5D610(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGetInstanceFieldsBetaAppReviewDetail>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_5ECF917C7E0D143F(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGetInstanceFieldsBetaGroup>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_06E8F2C531B32F43(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGetInstanceFieldsBetaLicenseAgreement>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_34EF0435542BE8C2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGetInstanceFieldsBuild>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_7D339E6A76D57A9E(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGetInstanceFieldsBuildIcon>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_C2777974F2679CB2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGetInstanceFieldsCiProduct>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_30060626EBE5C837(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGetInstanceFieldsEndUserLicenseAgreement>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_A905338B56DD1655(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGetInstanceFieldsGameCenterDetail>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_688321A546F7469F(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGetInstanceFieldsGameCenterEnabledVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_EE00ED80C530533A(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGetInstanceFieldsInAppPurchase>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_B5A99A62D773FB85(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGetInstanceFieldsPreReleaseVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_37103FB42F4C20BB(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGetInstanceFieldsPromotedPurchase>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_77D316102EAC72B6(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGetInstanceFieldsReviewSubmission>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_05C52022C20182F5(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGetInstanceFieldsSubscriptionGracePeriod>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_5C5B13EC08E5982A(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGetInstanceFieldsSubscriptionGroup>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_781C822455032DCC(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_0F3A5B97542D76C4(options);
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