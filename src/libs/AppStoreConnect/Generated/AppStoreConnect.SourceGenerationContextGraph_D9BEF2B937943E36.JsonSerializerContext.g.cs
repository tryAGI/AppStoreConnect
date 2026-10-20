
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_D9BEF2B937943E36 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_D9BEF2B937943E36 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_D9BEF2B937943E36(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem20JsonConverter());
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
                    typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationDocumentType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationDocumentType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationRelationshipsAppDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationRelationshipsAppDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationRelationshipsBuildsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationRelationshipsBuildsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationRelationshipsAppEncryptionDeclarationDocumentDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationRelationshipsAppEncryptionDeclarationDocumentDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationsResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationsResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAttributesContentRightsDeclaration)

                    || typeToConvert == typeof(global::AppStoreConnect.AppAttributesContentRightsDeclaration?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppEncryptionDeclarationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppEncryptionDeclarationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppStoreIconDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppStoreIconDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsCiProductDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsCiProductDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsBetaGroupsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsBetaGroupsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppStoreVersionsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppStoreVersionsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsPreReleaseVersionsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsPreReleaseVersionsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsBetaAppLocalizationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsBetaAppLocalizationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsBuildsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsBuildsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsBetaLicenseAgreementDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsBetaLicenseAgreementDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsBetaAppReviewDetailDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsBetaAppReviewDetailDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppInfosDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppInfosDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppClipsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppClipsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsEndUserLicenseAgreementDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsEndUserLicenseAgreementDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsInAppPurchasesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsInAppPurchasesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsSubscriptionGroupsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsSubscriptionGroupsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsGameCenterEnabledVersionsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsGameCenterEnabledVersionsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppCustomProductPagesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppCustomProductPagesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsInAppPurchasesV2DataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsInAppPurchasesV2DataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsPromotedPurchasesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsPromotedPurchasesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppEventsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppEventsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsReviewSubmissionsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsReviewSubmissionsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsSubscriptionGracePeriodDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsSubscriptionGracePeriodDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsGameCenterDetailDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsGameCenterDetailDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppStoreVersionExperimentsV2DataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppStoreVersionExperimentsV2DataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAndroidToIosAppMappingDetailsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAndroidToIosAppMappingDetailsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildAttributesProcessingState)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildAttributesProcessingState?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsPreReleaseVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsPreReleaseVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsIndividualTestersDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsIndividualTestersDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBetaGroupsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBetaGroupsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBetaBuildLocalizationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBetaBuildLocalizationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsAppEncryptionDeclarationDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsAppEncryptionDeclarationDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBetaAppReviewSubmissionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBetaAppReviewSubmissionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsAppDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsAppDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBuildBetaDetailDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBuildBetaDetailDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsAppStoreVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsAppStoreVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsIconsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsIconsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBuildBundlesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBuildBundlesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBuildUploadDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBuildUploadDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationState)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationState?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState)

                    || typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildAudienceType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildAudienceType?)

                    || typeToConvert == typeof(global::AppStoreConnect.Platform)

                    || typeToConvert == typeof(global::AppStoreConnect.Platform?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionStatusUrlVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionStatusUrlVersion?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationDocumentType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEncryptionDeclarationDocumentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationDocumentType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEncryptionDeclarationDocumentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEncryptionDeclarationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEncryptionDeclarationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationRelationshipsAppDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEncryptionDeclarationRelationshipsAppDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationRelationshipsAppDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEncryptionDeclarationRelationshipsAppDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationRelationshipsBuildsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEncryptionDeclarationRelationshipsBuildsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationRelationshipsBuildsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEncryptionDeclarationRelationshipsBuildsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationRelationshipsAppEncryptionDeclarationDocumentDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEncryptionDeclarationRelationshipsAppEncryptionDeclarationDocumentDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationRelationshipsAppEncryptionDeclarationDocumentDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEncryptionDeclarationRelationshipsAppEncryptionDeclarationDocumentDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationsResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEncryptionDeclarationsResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationsResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEncryptionDeclarationsResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAttributesContentRightsDeclaration))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAttributesContentRightsDeclarationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppAttributesContentRightsDeclaration?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppAttributesContentRightsDeclarationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppEncryptionDeclarationsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsAppEncryptionDeclarationsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppEncryptionDeclarationsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsAppEncryptionDeclarationsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppStoreIconDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsAppStoreIconDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppStoreIconDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsAppStoreIconDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsCiProductDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsCiProductDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsCiProductDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsCiProductDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsBetaGroupsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsBetaGroupsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsBetaGroupsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsBetaGroupsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppStoreVersionsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsAppStoreVersionsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppStoreVersionsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsAppStoreVersionsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsPreReleaseVersionsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsPreReleaseVersionsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsPreReleaseVersionsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsPreReleaseVersionsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsBetaAppLocalizationsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsBetaAppLocalizationsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsBetaAppLocalizationsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsBetaAppLocalizationsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsBuildsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsBuildsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsBuildsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsBuildsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsBetaLicenseAgreementDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsBetaLicenseAgreementDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsBetaLicenseAgreementDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsBetaLicenseAgreementDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsBetaAppReviewDetailDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsBetaAppReviewDetailDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsBetaAppReviewDetailDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsBetaAppReviewDetailDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppInfosDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsAppInfosDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppInfosDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsAppInfosDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppClipsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsAppClipsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppClipsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsAppClipsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsEndUserLicenseAgreementDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsEndUserLicenseAgreementDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsEndUserLicenseAgreementDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsEndUserLicenseAgreementDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsInAppPurchasesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsInAppPurchasesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsInAppPurchasesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsInAppPurchasesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsSubscriptionGroupsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsSubscriptionGroupsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsSubscriptionGroupsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsSubscriptionGroupsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsGameCenterEnabledVersionsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsGameCenterEnabledVersionsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsGameCenterEnabledVersionsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsGameCenterEnabledVersionsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppCustomProductPagesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsAppCustomProductPagesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppCustomProductPagesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsAppCustomProductPagesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsInAppPurchasesV2DataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsInAppPurchasesV2DataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsInAppPurchasesV2DataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsInAppPurchasesV2DataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsPromotedPurchasesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsPromotedPurchasesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsPromotedPurchasesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsPromotedPurchasesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppEventsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsAppEventsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppEventsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsAppEventsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsReviewSubmissionsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsReviewSubmissionsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsReviewSubmissionsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsReviewSubmissionsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsSubscriptionGracePeriodDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsSubscriptionGracePeriodDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsSubscriptionGracePeriodDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsSubscriptionGracePeriodDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsGameCenterDetailDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsGameCenterDetailDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsGameCenterDetailDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsGameCenterDetailDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppStoreVersionExperimentsV2DataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsAppStoreVersionExperimentsV2DataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAppStoreVersionExperimentsV2DataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsAppStoreVersionExperimentsV2DataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAndroidToIosAppMappingDetailsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsAndroidToIosAppMappingDetailsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppRelationshipsAndroidToIosAppMappingDetailsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppRelationshipsAndroidToIosAppMappingDetailsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildAttributesProcessingState))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildAttributesProcessingStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildAttributesProcessingState?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildAttributesProcessingStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsPreReleaseVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsPreReleaseVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsPreReleaseVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsPreReleaseVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsIndividualTestersDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsIndividualTestersDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsIndividualTestersDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsIndividualTestersDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBetaGroupsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsBetaGroupsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBetaGroupsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsBetaGroupsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBetaBuildLocalizationsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsBetaBuildLocalizationsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBetaBuildLocalizationsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsBetaBuildLocalizationsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsAppEncryptionDeclarationDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsAppEncryptionDeclarationDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsAppEncryptionDeclarationDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsAppEncryptionDeclarationDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBetaAppReviewSubmissionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsBetaAppReviewSubmissionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBetaAppReviewSubmissionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsBetaAppReviewSubmissionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsAppDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsAppDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsAppDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsAppDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBuildBetaDetailDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsBuildBetaDetailDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBuildBetaDetailDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsBuildBetaDetailDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsAppStoreVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsAppStoreVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsAppStoreVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsAppStoreVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsIconsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsIconsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsIconsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsIconsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBuildBundlesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsBuildBundlesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBuildBundlesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsBuildBundlesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBuildUploadDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsBuildUploadDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildRelationshipsBuildUploadDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildRelationshipsBuildUploadDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationState))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEncryptionDeclarationStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationState?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEncryptionDeclarationStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState))
                {
                    return new global::AppStoreConnect.JsonConverters.AppMediaAssetStateStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppMediaAssetStateState?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppMediaAssetStateStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildAudienceType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildAudienceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildAudienceType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildAudienceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.Platform))
                {
                    return new global::AppStoreConnect.JsonConverters.PlatformJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.Platform?))
                {
                    return new global::AppStoreConnect.JsonConverters.PlatformNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionStatusUrlVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionStatusUrlVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionStatusUrlVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionStatusUrlVersionNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.App))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_App(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAttributesContentRightsDeclaration))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppAttributesContentRightsDeclaration2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEncryptionDeclaration))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppEncryptionDeclaration(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEncryptionDeclarationAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppEncryptionDeclarationAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEncryptionDeclarationDocument))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppEncryptionDeclarationDocument(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEncryptionDeclarationDocumentAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppEncryptionDeclarationDocumentAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEncryptionDeclarationDocumentType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppEncryptionDeclarationDocumentType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEncryptionDeclarationRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppEncryptionDeclarationRelationships(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppEncryptionDeclarationRelationshipsApp))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppEncryptionDeclarationRelationshipsApp(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppEncryptionDeclarationRelationshipsAppData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppEncryptionDeclarationRelationshipsAppData(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppEncryptionDeclarationRelationshipsAppDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppEncryptionDeclarationRelationshipsAppDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppEncryptionDeclarationRelationshipsAppEncryptionDeclarationDocument))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppEncryptionDeclarationRelationshipsAppEncryptionDeclarationDocument(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppEncryptionDeclarationRelationshipsAppEncryptionDeclarationDocumentData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppEncryptionDeclarationRelationshipsAppEncryptionDeclarationDocumentData(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppEncryptionDeclarationRelationshipsAppEncryptionDeclarationDocumentDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppEncryptionDeclarationRelationshipsAppEncryptionDeclarationDocumentDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppEncryptionDeclarationRelationshipsBuilds))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppEncryptionDeclarationRelationshipsBuilds(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppEncryptionDeclarationRelationshipsBuildsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppEncryptionDeclarationRelationshipsBuildsDataItem(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppEncryptionDeclarationRelationshipsBuildsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppEncryptionDeclarationRelationshipsBuildsDataItemType2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::AppStoreConnect.AppEncryptionDeclarationState))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppEncryptionDeclarationState2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEncryptionDeclarationType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppEncryptionDeclarationType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEncryptionDeclarationsResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppEncryptionDeclarationsResponse(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEncryptionDeclarationsResponseIncludedItemDiscriminator))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppEncryptionDeclarationsResponseIncludedItemDiscriminator(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEncryptionDeclarationsResponseIncludedItemDiscriminatorType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppEncryptionDeclarationsResponseIncludedItemDiscriminatorType2(options);
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
                if (type == typeof(global::AppStoreConnect.AppRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAccessibilityDeclarations))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsAccessibilityDeclarations(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAlternativeDistributionKey))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsAlternativeDistributionKey(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAnalyticsReportRequests))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsAnalyticsReportRequests(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAndroidToIosAppMappingDetails))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsAndroidToIosAppMappingDetails(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAndroidToIosAppMappingDetailsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsAndroidToIosAppMappingDetailsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAndroidToIosAppMappingDetailsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsAndroidToIosAppMappingDetailsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppAvailabilityV2))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsAppAvailabilityV2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppClips))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsAppClips(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppClipsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsAppClipsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppClipsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsAppClipsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppCustomProductPages))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsAppCustomProductPages(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppCustomProductPagesDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsAppCustomProductPagesDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppCustomProductPagesDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsAppCustomProductPagesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppEncryptionDeclarations))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsAppEncryptionDeclarations(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppEncryptionDeclarationsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsAppEncryptionDeclarationsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppEncryptionDeclarationsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsAppEncryptionDeclarationsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppEvents))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsAppEvents(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppEventsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsAppEventsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppEventsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsAppEventsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppInfos))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsAppInfos(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppInfosDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsAppInfosDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppInfosDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsAppInfosDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppPricePoints))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsAppPricePoints(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppPriceSchedule))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsAppPriceSchedule(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppStoreIcon))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsAppStoreIcon(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppStoreIconData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsAppStoreIconData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppStoreIconDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsAppStoreIconDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppStoreVersionExperimentsV2))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsAppStoreVersionExperimentsV2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppStoreVersionExperimentsV2DataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsAppStoreVersionExperimentsV2DataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppStoreVersionExperimentsV2DataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsAppStoreVersionExperimentsV2DataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppStoreVersions))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsAppStoreVersions(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppStoreVersionsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsAppStoreVersionsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppStoreVersionsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsAppStoreVersionsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppTags))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsAppTags(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAssetLibrary))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsAssetLibrary(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsBackgroundAssets))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsBackgroundAssets(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsBetaAppLocalizations))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsBetaAppLocalizations(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsBetaAppLocalizationsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsBetaAppLocalizationsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsBetaAppLocalizationsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsBetaAppLocalizationsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsBetaAppReviewDetail))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsBetaAppReviewDetail(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsBetaAppReviewDetailData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsBetaAppReviewDetailData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsBetaAppReviewDetailDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsBetaAppReviewDetailDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsBetaFeedbackCrashSubmissions))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsBetaFeedbackCrashSubmissions(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsBetaFeedbackScreenshotSubmissions))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsBetaFeedbackScreenshotSubmissions(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsBetaGroups))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsBetaGroups(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsBetaGroupsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsBetaGroupsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsBetaGroupsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsBetaGroupsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsBetaLicenseAgreement))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsBetaLicenseAgreement(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsBetaLicenseAgreementData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsBetaLicenseAgreementData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsBetaLicenseAgreementDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsBetaLicenseAgreementDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsBetaTesters))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsBetaTesters(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsBuildUploads))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsBuildUploads(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsBuilds))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsBuilds(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsBuildsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsBuildsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsBuildsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsBuildsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsCiProduct))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsCiProduct(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsCiProductData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsCiProductData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsCiProductDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsCiProductDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsCustomerReviewSummarizations))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsCustomerReviewSummarizations(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsCustomerReviews))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsCustomerReviews(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsEndUserLicenseAgreement))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsEndUserLicenseAgreement(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsEndUserLicenseAgreementData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsEndUserLicenseAgreementData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsEndUserLicenseAgreementDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsEndUserLicenseAgreementDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsGameCenterDetail))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsGameCenterDetail(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsGameCenterDetailData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsGameCenterDetailData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsGameCenterDetailDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsGameCenterDetailDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsGameCenterEnabledVersions))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsGameCenterEnabledVersions(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsGameCenterEnabledVersionsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsGameCenterEnabledVersionsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsGameCenterEnabledVersionsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsGameCenterEnabledVersionsDataItemType2(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppRelationshipsInAppPurchases))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsInAppPurchases(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppRelationshipsInAppPurchasesDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsInAppPurchasesDataItem(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppRelationshipsInAppPurchasesDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsInAppPurchasesDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppRelationshipsInAppPurchasesV2))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsInAppPurchasesV2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppRelationshipsInAppPurchasesV2DataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsInAppPurchasesV2DataItem(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppRelationshipsInAppPurchasesV2DataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsInAppPurchasesV2DataItemType2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::AppStoreConnect.AppRelationshipsMarketplaceSearchDetail))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsMarketplaceSearchDetail(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsPerfPowerMetrics))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsPerfPowerMetrics(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsPerformanceOverviews))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsPerformanceOverviews(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsPreReleaseVersions))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsPreReleaseVersions(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsPreReleaseVersionsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsPreReleaseVersionsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsPreReleaseVersionsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsPreReleaseVersionsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsPromotedPurchases))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsPromotedPurchases(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsPromotedPurchasesDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsPromotedPurchasesDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsPromotedPurchasesDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsPromotedPurchasesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsReviewSubmissions))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsReviewSubmissions(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsReviewSubmissionsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsReviewSubmissionsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsReviewSubmissionsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsReviewSubmissionsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsSearchKeywords))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsSearchKeywords(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsSubscriptionGracePeriod))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsSubscriptionGracePeriod(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsSubscriptionGracePeriodData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsSubscriptionGracePeriodData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsSubscriptionGracePeriodDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsSubscriptionGracePeriodDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsSubscriptionGroups))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsSubscriptionGroups(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsSubscriptionGroupsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsSubscriptionGroupsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsSubscriptionGroupsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppRelationshipsSubscriptionGroupsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsWebhooks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppRelationshipsWebhooks(options);
                }
                if (type == typeof(global::AppStoreConnect.AppType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppType2(options);
                }
                if (type == typeof(global::AppStoreConnect.Build))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Build(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildAttributesProcessingState))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildAttributesProcessingState2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildAudienceType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildAudienceType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsApp))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsApp(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsAppData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsAppData(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsAppDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsAppDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsAppEncryptionDeclaration))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsAppEncryptionDeclaration(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsAppEncryptionDeclarationData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsAppEncryptionDeclarationData(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsAppEncryptionDeclarationDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsAppEncryptionDeclarationDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsAppStoreVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsAppStoreVersion(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsAppStoreVersionData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsAppStoreVersionData(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsAppStoreVersionDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsAppStoreVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBetaAppReviewSubmission))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsBetaAppReviewSubmission(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBetaAppReviewSubmissionData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsBetaAppReviewSubmissionData(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBetaAppReviewSubmissionDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsBetaAppReviewSubmissionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBetaBuildLocalizations))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsBetaBuildLocalizations(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBetaBuildLocalizationsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsBetaBuildLocalizationsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBetaBuildLocalizationsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsBetaBuildLocalizationsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBetaGroups))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsBetaGroups(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBetaGroupsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsBetaGroupsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBetaGroupsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsBetaGroupsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBuildBetaDetail))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsBuildBetaDetail(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBuildBetaDetailData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsBuildBetaDetailData(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBuildBetaDetailDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsBuildBetaDetailDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBuildBundles))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsBuildBundles(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBuildBundlesDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsBuildBundlesDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBuildBundlesDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsBuildBundlesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBuildUpload))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsBuildUpload(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBuildUploadData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsBuildUploadData(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBuildUploadDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsBuildUploadDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsDiagnosticSignatures))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsDiagnosticSignatures(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsIcons))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsIcons(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsIconsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsIconsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsIconsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsIconsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsIndividualTesters))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsIndividualTesters(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsIndividualTestersDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsIndividualTestersDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsIndividualTestersDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsIndividualTestersDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsPerfPowerMetrics))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsPerfPowerMetrics(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsPreReleaseVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsPreReleaseVersion(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsPreReleaseVersionData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsPreReleaseVersionData(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsPreReleaseVersionDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildRelationshipsPreReleaseVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildType2(options);
                }
                if (type == typeof(global::AppStoreConnect.HttpHeader))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_HttpHeader(options);
                }
                if (type == typeof(global::AppStoreConnect.ImageAsset))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_ImageAsset(options);
                }
                if (type == typeof(global::AppStoreConnect.IncludedItem20))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_IncludedItem202(options);
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
                if (type == typeof(global::AppStoreConnect.Platform))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Platform2(options);
                }
                if (type == typeof(global::AppStoreConnect.RelationshipLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_RelationshipLinks(options);
                }
                if (type == typeof(global::AppStoreConnect.ResourceLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_ResourceLinks(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionStatusUrlVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SubscriptionStatusUrlVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.UploadOperation))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_UploadOperation(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppEncryptionDeclaration>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_147C4164CEA25267(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppEncryptionDeclarationRelationshipsBuildsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_93598F68C07F5A78(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppMediaStateError>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_7E9D192989E995BF(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppRelationshipsAndroidToIosAppMappingDetailsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_A81096F4683775F8(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppRelationshipsAppClipsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_88D63AE29F447D68(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppRelationshipsAppCustomProductPagesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_52892132E482B394(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppRelationshipsAppEncryptionDeclarationsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_B7F74DF0AB69287B(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppRelationshipsAppEventsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_0711D4F322A14BA3(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppRelationshipsAppInfosDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_9922042AE28F3F85(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppRelationshipsAppStoreVersionExperimentsV2DataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_B0A695A50FDAE79E(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppRelationshipsAppStoreVersionsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_D2B95E9366D05F52(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppRelationshipsBetaAppLocalizationsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_E47C0345EF7AD78A(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppRelationshipsBetaGroupsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_A3E9AF35CD422B4E(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppRelationshipsBuildsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_BF4590F01D98A3B4(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppRelationshipsGameCenterEnabledVersionsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_3699403235399A4E(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppRelationshipsInAppPurchasesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_83101BFA8FE2BD3E(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppRelationshipsInAppPurchasesV2DataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_E916A4103D9A38AC(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppRelationshipsPreReleaseVersionsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_C8D42E423BE1C8DA(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppRelationshipsPromotedPurchasesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_C0B82376799DFE38(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppRelationshipsReviewSubmissionsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_13E761684A152621(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppRelationshipsSubscriptionGroupsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_D08F36F46AF2743A(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildRelationshipsBetaBuildLocalizationsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_2D7F817FEB3B058A(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildRelationshipsBetaGroupsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_8F872A0DF814C3EA(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildRelationshipsBuildBundlesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_5F90468B7885322A(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildRelationshipsIconsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_BCC6B5F9FDB89FA7(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildRelationshipsIndividualTestersDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_D1D39E952A7598F2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.HttpHeader>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_BCE13B3326F5CA8F(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem20>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_275FA1C04BAF6D9A(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.UploadOperation>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_A918B5AE31119789(options);
                }
                if (type == typeof(global::System.DateTime))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_DateTime(options);
                }
                if (type == typeof(int))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(bool?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBoolean(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAttributesContentRightsDeclaration?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAttributesContentRightsDeclaration2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEncryptionDeclarationDocumentType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppEncryptionDeclarationDocumentType2(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppEncryptionDeclarationRelationshipsAppDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppEncryptionDeclarationRelationshipsAppDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppEncryptionDeclarationRelationshipsAppEncryptionDeclarationDocumentDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppEncryptionDeclarationRelationshipsAppEncryptionDeclarationDocumentDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppEncryptionDeclarationRelationshipsBuildsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppEncryptionDeclarationRelationshipsBuildsDataItemType2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::AppStoreConnect.AppEncryptionDeclarationState?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppEncryptionDeclarationState2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEncryptionDeclarationType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppEncryptionDeclarationType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEncryptionDeclarationsResponseIncludedItemDiscriminatorType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppEncryptionDeclarationsResponseIncludedItemDiscriminatorType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppMediaAssetStateState?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppMediaAssetStateState2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAndroidToIosAppMappingDetailsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppRelationshipsAndroidToIosAppMappingDetailsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppClipsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppRelationshipsAppClipsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppCustomProductPagesDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppRelationshipsAppCustomProductPagesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppEncryptionDeclarationsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppRelationshipsAppEncryptionDeclarationsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppEventsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppRelationshipsAppEventsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppInfosDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppRelationshipsAppInfosDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppStoreIconDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppRelationshipsAppStoreIconDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppStoreVersionExperimentsV2DataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppRelationshipsAppStoreVersionExperimentsV2DataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsAppStoreVersionsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppRelationshipsAppStoreVersionsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsBetaAppLocalizationsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppRelationshipsBetaAppLocalizationsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsBetaAppReviewDetailDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppRelationshipsBetaAppReviewDetailDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsBetaGroupsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppRelationshipsBetaGroupsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsBetaLicenseAgreementDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppRelationshipsBetaLicenseAgreementDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsBuildsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppRelationshipsBuildsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsCiProductDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppRelationshipsCiProductDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsEndUserLicenseAgreementDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppRelationshipsEndUserLicenseAgreementDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsGameCenterDetailDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppRelationshipsGameCenterDetailDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsGameCenterEnabledVersionsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppRelationshipsGameCenterEnabledVersionsDataItemType2(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppRelationshipsInAppPurchasesDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppRelationshipsInAppPurchasesDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppRelationshipsInAppPurchasesV2DataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppRelationshipsInAppPurchasesV2DataItemType2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::AppStoreConnect.AppRelationshipsPreReleaseVersionsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppRelationshipsPreReleaseVersionsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsPromotedPurchasesDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppRelationshipsPromotedPurchasesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsReviewSubmissionsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppRelationshipsReviewSubmissionsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsSubscriptionGracePeriodDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppRelationshipsSubscriptionGracePeriodDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppRelationshipsSubscriptionGroupsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppRelationshipsSubscriptionGroupsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildAttributesProcessingState?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBuildAttributesProcessingState2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildAudienceType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBuildAudienceType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsAppDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBuildRelationshipsAppDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsAppEncryptionDeclarationDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBuildRelationshipsAppEncryptionDeclarationDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsAppStoreVersionDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBuildRelationshipsAppStoreVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBetaAppReviewSubmissionDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBuildRelationshipsBetaAppReviewSubmissionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBetaBuildLocalizationsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBuildRelationshipsBetaBuildLocalizationsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBetaGroupsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBuildRelationshipsBetaGroupsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBuildBetaDetailDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBuildRelationshipsBuildBetaDetailDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBuildBundlesDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBuildRelationshipsBuildBundlesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsBuildUploadDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBuildRelationshipsBuildUploadDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsIconsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBuildRelationshipsIconsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsIndividualTestersDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBuildRelationshipsIndividualTestersDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildRelationshipsPreReleaseVersionDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBuildRelationshipsPreReleaseVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBuildType2(options);
                }
                if (type == typeof(global::AppStoreConnect.IncludedItem20?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableIncludedItem202(options);
                }
                if (type == typeof(global::AppStoreConnect.Platform?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullablePlatform2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionStatusUrlVersion?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableSubscriptionStatusUrlVersion2(options);
                }
                if (type == typeof(global::System.DateTime?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableDateTime(options);
                }
                if (type == typeof(int?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppEncryptionDeclaration>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_5CEFA5DA33860605(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppEncryptionDeclarationRelationshipsBuildsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_3FC5F817D89A9A8F(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppMediaStateError>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_AE112F1FF3B11297(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppRelationshipsAndroidToIosAppMappingDetailsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_1E16040B1CA894C3(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppRelationshipsAppClipsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_AE3F859287B4D312(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppRelationshipsAppCustomProductPagesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_82A7FF975CBA14D5(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppRelationshipsAppEncryptionDeclarationsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_E6FB51AADF653540(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppRelationshipsAppEventsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_6CDEE18D2BD07DBE(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppRelationshipsAppInfosDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_36E3D7E06EE390D4(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppRelationshipsAppStoreVersionExperimentsV2DataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_029AF4ACCD26326D(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppRelationshipsAppStoreVersionsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_8CFE33DE85E6053A(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppRelationshipsBetaAppLocalizationsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_C7F4A6534F8EC787(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppRelationshipsBetaGroupsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_02E9BA0284CAEF52(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppRelationshipsBuildsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_BB616A8841A35472(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppRelationshipsGameCenterEnabledVersionsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_A4977263AB08005E(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppRelationshipsInAppPurchasesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_A90549EFC081CF12(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppRelationshipsInAppPurchasesV2DataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_DBBF058A40A57F80(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppRelationshipsPreReleaseVersionsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_5EC28E0686D24064(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppRelationshipsPromotedPurchasesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_20D83F20570515A6(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppRelationshipsReviewSubmissionsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_90454CB27F822DEF(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppRelationshipsSubscriptionGroupsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_D2758BDC4B77341B(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildRelationshipsBetaBuildLocalizationsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_BE1E6F918C082922(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildRelationshipsBetaGroupsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_DECEC7A4996A17B4(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildRelationshipsBuildBundlesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_B3F4C1C38020CC64(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildRelationshipsIconsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_7AD7BF85AB1EA6AB(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildRelationshipsIndividualTestersDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_5057449BFE60E32E(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.HttpHeader>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_1947F16F30F1622D(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem20>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_8B0DB8842DDA4478(options);
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