
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_5E86A349D60E6852 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_5E86A349D60E6852 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_5E86A349D60E6852(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem48JsonConverter());
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
                    typeToConvert == typeof(global::AppStoreConnect.AndroidToIosAppMappingDetailType)

                    || typeToConvert == typeof(global::AppStoreConnect.AndroidToIosAppMappingDetailType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipRelationshipsAppDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipRelationshipsAppDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipRelationshipsAppClipDefaultExperiencesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipRelationshipsAppClipDefaultExperiencesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageRelationshipsAppDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageRelationshipsAppDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageRelationshipsAppCustomProductPageVersionsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageRelationshipsAppCustomProductPageVersionsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationRelationshipsAppDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationRelationshipsAppDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationRelationshipsBuildsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationRelationshipsBuildsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationRelationshipsAppEncryptionDeclarationDocumentDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationRelationshipsAppEncryptionDeclarationDocumentDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventAttributesBadge)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventAttributesBadge?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventAttributesEventState)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventAttributesEventState?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventAttributesPriority)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventAttributesPriority?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventAttributesPurpose)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventAttributesPurpose?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventRelationshipsLocalizationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEventRelationshipsLocalizationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoAttributesState)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoAttributesState?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoAttributesAustraliaAgeRating)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoAttributesAustraliaAgeRating?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoAttributesBrazilAgeRatingV2)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoAttributesBrazilAgeRatingV2?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoAttributesFranceAgeRating)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoAttributesFranceAgeRating?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoAttributesKoreaAgeRating)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoAttributesKoreaAgeRating?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsAppDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsAppDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsAgeRatingDeclarationDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsAgeRatingDeclarationDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsAppInfoLocalizationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsAppInfoLocalizationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsPrimaryCategoryDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsPrimaryCategoryDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsPrimarySubcategoryOneDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsPrimarySubcategoryOneDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsPrimarySubcategoryTwoDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsPrimarySubcategoryTwoDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsSecondaryCategoryDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsSecondaryCategoryDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsSecondarySubcategoryOneDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsSecondarySubcategoryOneDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsSecondarySubcategoryTwoDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsSecondarySubcategoryTwoDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2Type)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2Type?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2AttributesState)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2AttributesState?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsAppDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsAppDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsLatestControlVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsLatestControlVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsControlVersionsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsControlVersionsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsAppStoreVersionExperimentTreatmentsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsAppStoreVersionExperimentTreatmentsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionAttributesReviewType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionAttributesReviewType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionAttributesReleaseType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionAttributesReleaseType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionLocalizationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionLocalizationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsBuildDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsBuildDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionPhasedReleaseDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionPhasedReleaseDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsGameCenterAppVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsGameCenterAppVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsRoutingAppCoverageDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsRoutingAppCoverageDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreReviewDetailDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreReviewDetailDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionSubmissionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionSubmissionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppClipDefaultExperienceDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppClipDefaultExperienceDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionExperimentsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionExperimentsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionExperimentsV2DataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionExperimentsV2DataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAlternativeDistributionPackageDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAlternativeDistributionPackageDataType?)

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

                    || typeToConvert == typeof(global::AppStoreConnect.AppsResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppLocalizationType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppLocalizationType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppLocalizationRelationshipsAppDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppLocalizationRelationshipsAppDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppReviewDetailType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppReviewDetailType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppReviewDetailRelationshipsAppDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppReviewDetailRelationshipsAppDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaGroupType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaGroupType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaGroupRelationshipsAppDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaGroupRelationshipsAppDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaGroupRelationshipsBuildsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaGroupRelationshipsBuildsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaGroupRelationshipsBetaTestersDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaGroupRelationshipsBetaTestersDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaGroupRelationshipsBetaRecruitmentCriteriaDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaGroupRelationshipsBetaRecruitmentCriteriaDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaLicenseAgreementType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaLicenseAgreementType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaLicenseAgreementRelationshipsAppDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaLicenseAgreementRelationshipsAppDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildIconType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildIconType?)

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

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductAttributesProductType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductAttributesProductType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductRelationshipsAppDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductRelationshipsAppDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductRelationshipsBundleIdDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductRelationshipsBundleIdDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductRelationshipsPrimaryRepositoriesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiProductRelationshipsPrimaryRepositoriesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.EndUserLicenseAgreementType)

                    || typeToConvert == typeof(global::AppStoreConnect.EndUserLicenseAgreementType?)

                    || typeToConvert == typeof(global::AppStoreConnect.EndUserLicenseAgreementRelationshipsAppDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.EndUserLicenseAgreementRelationshipsAppDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.EndUserLicenseAgreementRelationshipsTerritoriesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.EndUserLicenseAgreementRelationshipsTerritoriesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsAppDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsAppDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAppVersionsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAppVersionsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterGroupDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterGroupDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardsV2DataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardsV2DataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardSetsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardSetsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardSetsV2DataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardSetsV2DataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAchievementsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAchievementsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAchievementsV2DataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAchievementsV2DataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterActivitiesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterActivitiesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterChallengesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterChallengesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultLeaderboardDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultLeaderboardDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultLeaderboardV2DataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultLeaderboardV2DataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultGroupLeaderboardDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultGroupLeaderboardDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultGroupLeaderboardV2DataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultGroupLeaderboardV2DataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsAchievementReleasesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsAchievementReleasesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsActivityReleasesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsActivityReleasesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsChallengeReleasesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsChallengeReleasesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsLeaderboardReleasesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsLeaderboardReleasesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsLeaderboardSetReleasesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsLeaderboardSetReleasesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsChallengesMinimumPlatformVersionsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsChallengesMinimumPlatformVersionsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterEnabledVersionType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterEnabledVersionType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterEnabledVersionRelationshipsCompatibleVersionsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterEnabledVersionRelationshipsCompatibleVersionsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterEnabledVersionRelationshipsAppDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterEnabledVersionRelationshipsAppDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseAttributesInAppPurchaseType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseAttributesInAppPurchaseType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseAttributesState)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseAttributesState?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseRelationshipsAppsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseRelationshipsAppsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.PrereleaseVersionType)

                    || typeToConvert == typeof(global::AppStoreConnect.PrereleaseVersionType?)

                    || typeToConvert == typeof(global::AppStoreConnect.PrereleaseVersionRelationshipsBuildsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.PrereleaseVersionRelationshipsBuildsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.PrereleaseVersionRelationshipsAppDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.PrereleaseVersionRelationshipsAppDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseType)

                    || typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseType?)

                    || typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseAttributesState)

                    || typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseAttributesState?)

                    || typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseRelationshipsInAppPurchaseV2DataType)

                    || typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseRelationshipsInAppPurchaseV2DataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseRelationshipsSubscriptionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseRelationshipsSubscriptionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionType)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionAttributesState)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionAttributesState?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsAppDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsAppDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsItemsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsItemsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsAppStoreVersionForReviewDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsAppStoreVersionForReviewDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsSubmittedByActorDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsSubmittedByActorDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsLastUpdatedByActorDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsLastUpdatedByActorDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGracePeriodType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGracePeriodType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGracePeriodAttributesRenewalType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGracePeriodAttributesRenewalType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptionsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptionsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptionGroupLocalizationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptionGroupLocalizationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsVersionsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsVersionsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationState)

                    || typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationState?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreAgeRating)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreAgeRating?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionState)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionState?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppVersionState)

                    || typeToConvert == typeof(global::AppStoreConnect.AppVersionState?)

                    || typeToConvert == typeof(global::AppStoreConnect.BrazilAgeRating)

                    || typeToConvert == typeof(global::AppStoreConnect.BrazilAgeRating?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildAudienceType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildAudienceType?)

                    || typeToConvert == typeof(global::AppStoreConnect.IconAssetType)

                    || typeToConvert == typeof(global::AppStoreConnect.IconAssetType?)

                    || typeToConvert == typeof(global::AppStoreConnect.Platform)

                    || typeToConvert == typeof(global::AppStoreConnect.Platform?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGracePeriodDuration)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionGracePeriodDuration?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionStatusUrlVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionStatusUrlVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFilterAppStoreVersionsAppStoreStateItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFilterAppStoreVersionsAppStoreStateItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFilterAppStoreVersionsPlatformItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFilterAppStoreVersionsPlatformItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFilterAppStoreVersionsAppVersionStateItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFilterAppStoreVersionsAppVersionStateItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFilterReviewSubmissionsStateItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFilterReviewSubmissionsStateItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFilterReviewSubmissionsPlatformItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFilterReviewSubmissionsPlatformItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionSortItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionSortItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsApp)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsApp?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsAppEncryptionDeclaration)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsAppEncryptionDeclaration?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsBuildIcon)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsBuildIcon?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsCiProduct)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsCiProduct?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsBetaGroup)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsBetaGroup?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsAppStoreVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsAppStoreVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsPreReleaseVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsPreReleaseVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsBetaAppLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsBetaAppLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsBuild)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsBuild?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsBetaLicenseAgreement)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsBetaLicenseAgreement?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsBetaAppReviewDetail)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsBetaAppReviewDetail?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsAppInfo)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsAppInfo?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsAppClip)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsAppClip?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsEndUserLicenseAgreement)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsEndUserLicenseAgreement?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsInAppPurchase)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsInAppPurchase?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsSubscriptionGroup)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsSubscriptionGroup?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsGameCenterEnabledVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsGameCenterEnabledVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsAppCustomProductPage)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsAppCustomProductPage?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsPromotedPurchase)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsPromotedPurchase?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsAppEvent)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsAppEvent?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsReviewSubmission)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsReviewSubmission?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsSubscriptionGracePeriod)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsSubscriptionGracePeriod?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsGameCenterDetail)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsGameCenterDetail?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsAppStoreVersionExperiment)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsAppStoreVersionExperiment?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsAndroidToIosAppMappingDetail)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsAndroidToIosAppMappingDetail?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.AndroidToIosAppMappingDetailType))
                {
                    return new global::AppStoreConnect.JsonConverters.AndroidToIosAppMappingDetailTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AndroidToIosAppMappingDetailType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AndroidToIosAppMappingDetailTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipRelationshipsAppDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipRelationshipsAppDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipRelationshipsAppDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipRelationshipsAppDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipRelationshipsAppClipDefaultExperiencesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipRelationshipsAppClipDefaultExperiencesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipRelationshipsAppClipDefaultExperiencesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipRelationshipsAppClipDefaultExperiencesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageRelationshipsAppDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageRelationshipsAppDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageRelationshipsAppDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageRelationshipsAppDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageRelationshipsAppCustomProductPageVersionsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageRelationshipsAppCustomProductPageVersionsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppCustomProductPageRelationshipsAppCustomProductPageVersionsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppCustomProductPageRelationshipsAppCustomProductPageVersionsDataItemTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventAttributesBadge))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventAttributesBadgeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventAttributesBadge?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventAttributesBadgeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventAttributesEventState))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventAttributesEventStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventAttributesEventState?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventAttributesEventStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventAttributesPriority))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventAttributesPriorityJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventAttributesPriority?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventAttributesPriorityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventAttributesPurpose))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventAttributesPurposeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventAttributesPurpose?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventAttributesPurposeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventRelationshipsLocalizationsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventRelationshipsLocalizationsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEventRelationshipsLocalizationsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEventRelationshipsLocalizationsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoAttributesState))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoAttributesStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoAttributesState?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoAttributesStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoAttributesAustraliaAgeRating))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoAttributesAustraliaAgeRatingJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoAttributesAustraliaAgeRating?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoAttributesAustraliaAgeRatingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoAttributesBrazilAgeRatingV2))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoAttributesBrazilAgeRatingV2JsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoAttributesBrazilAgeRatingV2?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoAttributesBrazilAgeRatingV2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoAttributesFranceAgeRating))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoAttributesFranceAgeRatingJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoAttributesFranceAgeRating?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoAttributesFranceAgeRatingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoAttributesKoreaAgeRating))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoAttributesKoreaAgeRatingJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoAttributesKoreaAgeRating?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoAttributesKoreaAgeRatingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsAppDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoRelationshipsAppDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsAppDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoRelationshipsAppDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsAgeRatingDeclarationDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoRelationshipsAgeRatingDeclarationDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsAgeRatingDeclarationDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoRelationshipsAgeRatingDeclarationDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsAppInfoLocalizationsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoRelationshipsAppInfoLocalizationsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsAppInfoLocalizationsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoRelationshipsAppInfoLocalizationsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsPrimaryCategoryDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoRelationshipsPrimaryCategoryDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsPrimaryCategoryDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoRelationshipsPrimaryCategoryDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsPrimarySubcategoryOneDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoRelationshipsPrimarySubcategoryOneDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsPrimarySubcategoryOneDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoRelationshipsPrimarySubcategoryOneDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsPrimarySubcategoryTwoDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoRelationshipsPrimarySubcategoryTwoDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsPrimarySubcategoryTwoDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoRelationshipsPrimarySubcategoryTwoDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsSecondaryCategoryDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoRelationshipsSecondaryCategoryDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsSecondaryCategoryDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoRelationshipsSecondaryCategoryDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsSecondarySubcategoryOneDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoRelationshipsSecondarySubcategoryOneDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsSecondarySubcategoryOneDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoRelationshipsSecondarySubcategoryOneDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsSecondarySubcategoryTwoDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoRelationshipsSecondarySubcategoryTwoDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppInfoRelationshipsSecondarySubcategoryTwoDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppInfoRelationshipsSecondarySubcategoryTwoDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2Type))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentV2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2Type?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentV2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2AttributesState))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentV2AttributesStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2AttributesState?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentV2AttributesStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsAppDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentV2RelationshipsAppDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsAppDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentV2RelationshipsAppDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsLatestControlVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentV2RelationshipsLatestControlVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsLatestControlVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentV2RelationshipsLatestControlVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsControlVersionsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentV2RelationshipsControlVersionsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsControlVersionsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentV2RelationshipsControlVersionsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsAppStoreVersionExperimentTreatmentsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentV2RelationshipsAppStoreVersionExperimentTreatmentsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsAppStoreVersionExperimentTreatmentsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentV2RelationshipsAppStoreVersionExperimentTreatmentsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionAttributesReviewType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionAttributesReviewTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionAttributesReviewType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionAttributesReviewTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionAttributesReleaseType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionAttributesReleaseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionAttributesReleaseType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionAttributesReleaseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionRelationshipsAppDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionRelationshipsAppDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionLocalizationsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionRelationshipsAppStoreVersionLocalizationsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionLocalizationsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionRelationshipsAppStoreVersionLocalizationsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsBuildDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionRelationshipsBuildDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsBuildDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionRelationshipsBuildDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionPhasedReleaseDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionRelationshipsAppStoreVersionPhasedReleaseDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionPhasedReleaseDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionRelationshipsAppStoreVersionPhasedReleaseDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsGameCenterAppVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionRelationshipsGameCenterAppVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsGameCenterAppVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionRelationshipsGameCenterAppVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsRoutingAppCoverageDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionRelationshipsRoutingAppCoverageDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsRoutingAppCoverageDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionRelationshipsRoutingAppCoverageDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreReviewDetailDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionRelationshipsAppStoreReviewDetailDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreReviewDetailDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionRelationshipsAppStoreReviewDetailDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionSubmissionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionRelationshipsAppStoreVersionSubmissionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionSubmissionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionRelationshipsAppStoreVersionSubmissionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppClipDefaultExperienceDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionRelationshipsAppClipDefaultExperienceDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppClipDefaultExperienceDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionRelationshipsAppClipDefaultExperienceDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionExperimentsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionRelationshipsAppStoreVersionExperimentsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionExperimentsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionRelationshipsAppStoreVersionExperimentsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionExperimentsV2DataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionRelationshipsAppStoreVersionExperimentsV2DataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionExperimentsV2DataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionRelationshipsAppStoreVersionExperimentsV2DataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAlternativeDistributionPackageDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionRelationshipsAlternativeDistributionPackageDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAlternativeDistributionPackageDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionRelationshipsAlternativeDistributionPackageDataTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.AppsResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppLocalizationType))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppLocalizationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppLocalizationType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppLocalizationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppLocalizationRelationshipsAppDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppLocalizationRelationshipsAppDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppLocalizationRelationshipsAppDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppLocalizationRelationshipsAppDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppReviewDetailType))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppReviewDetailTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppReviewDetailType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppReviewDetailTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppReviewDetailRelationshipsAppDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppReviewDetailRelationshipsAppDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppReviewDetailRelationshipsAppDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppReviewDetailRelationshipsAppDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaGroupType))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaGroupTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaGroupType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaGroupTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaGroupRelationshipsAppDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaGroupRelationshipsAppDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaGroupRelationshipsAppDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaGroupRelationshipsAppDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaGroupRelationshipsBuildsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaGroupRelationshipsBuildsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaGroupRelationshipsBuildsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaGroupRelationshipsBuildsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaGroupRelationshipsBetaTestersDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaGroupRelationshipsBetaTestersDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaGroupRelationshipsBetaTestersDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaGroupRelationshipsBetaTestersDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaGroupRelationshipsBetaRecruitmentCriteriaDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaGroupRelationshipsBetaRecruitmentCriteriaDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaGroupRelationshipsBetaRecruitmentCriteriaDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaGroupRelationshipsBetaRecruitmentCriteriaDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaLicenseAgreementType))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaLicenseAgreementTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaLicenseAgreementType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaLicenseAgreementTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaLicenseAgreementRelationshipsAppDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaLicenseAgreementRelationshipsAppDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaLicenseAgreementRelationshipsAppDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaLicenseAgreementRelationshipsAppDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildIconType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildIconTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildIconType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildIconTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductAttributesProductType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductAttributesProductTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductAttributesProductType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductAttributesProductTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductRelationshipsAppDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductRelationshipsAppDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductRelationshipsAppDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductRelationshipsAppDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductRelationshipsBundleIdDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductRelationshipsBundleIdDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductRelationshipsBundleIdDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductRelationshipsBundleIdDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductRelationshipsPrimaryRepositoriesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductRelationshipsPrimaryRepositoriesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiProductRelationshipsPrimaryRepositoriesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiProductRelationshipsPrimaryRepositoriesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.EndUserLicenseAgreementType))
                {
                    return new global::AppStoreConnect.JsonConverters.EndUserLicenseAgreementTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.EndUserLicenseAgreementType?))
                {
                    return new global::AppStoreConnect.JsonConverters.EndUserLicenseAgreementTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.EndUserLicenseAgreementRelationshipsAppDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.EndUserLicenseAgreementRelationshipsAppDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.EndUserLicenseAgreementRelationshipsAppDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.EndUserLicenseAgreementRelationshipsAppDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.EndUserLicenseAgreementRelationshipsTerritoriesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.EndUserLicenseAgreementRelationshipsTerritoriesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.EndUserLicenseAgreementRelationshipsTerritoriesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.EndUserLicenseAgreementRelationshipsTerritoriesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsAppDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsAppDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsAppDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsAppDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAppVersionsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsGameCenterAppVersionsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAppVersionsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsGameCenterAppVersionsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterGroupDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsGameCenterGroupDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterGroupDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsGameCenterGroupDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsGameCenterLeaderboardsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsGameCenterLeaderboardsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardsV2DataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsGameCenterLeaderboardsV2DataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardsV2DataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsGameCenterLeaderboardsV2DataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardSetsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsGameCenterLeaderboardSetsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardSetsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsGameCenterLeaderboardSetsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardSetsV2DataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsGameCenterLeaderboardSetsV2DataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardSetsV2DataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsGameCenterLeaderboardSetsV2DataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAchievementsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsGameCenterAchievementsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAchievementsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsGameCenterAchievementsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAchievementsV2DataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsGameCenterAchievementsV2DataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAchievementsV2DataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsGameCenterAchievementsV2DataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterActivitiesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsGameCenterActivitiesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterActivitiesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsGameCenterActivitiesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterChallengesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsGameCenterChallengesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterChallengesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsGameCenterChallengesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultLeaderboardDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsDefaultLeaderboardDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultLeaderboardDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsDefaultLeaderboardDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultLeaderboardV2DataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsDefaultLeaderboardV2DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultLeaderboardV2DataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsDefaultLeaderboardV2DataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultGroupLeaderboardDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsDefaultGroupLeaderboardDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultGroupLeaderboardDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsDefaultGroupLeaderboardDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultGroupLeaderboardV2DataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsDefaultGroupLeaderboardV2DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultGroupLeaderboardV2DataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsDefaultGroupLeaderboardV2DataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsAchievementReleasesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsAchievementReleasesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsAchievementReleasesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsAchievementReleasesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsActivityReleasesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsActivityReleasesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsActivityReleasesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsActivityReleasesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsChallengeReleasesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsChallengeReleasesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsChallengeReleasesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsChallengeReleasesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsLeaderboardReleasesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsLeaderboardReleasesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsLeaderboardReleasesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsLeaderboardReleasesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsLeaderboardSetReleasesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsLeaderboardSetReleasesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsLeaderboardSetReleasesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsLeaderboardSetReleasesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsChallengesMinimumPlatformVersionsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsChallengesMinimumPlatformVersionsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsChallengesMinimumPlatformVersionsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterDetailRelationshipsChallengesMinimumPlatformVersionsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterEnabledVersionType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterEnabledVersionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterEnabledVersionType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterEnabledVersionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterEnabledVersionRelationshipsCompatibleVersionsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterEnabledVersionRelationshipsCompatibleVersionsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterEnabledVersionRelationshipsCompatibleVersionsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterEnabledVersionRelationshipsCompatibleVersionsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterEnabledVersionRelationshipsAppDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterEnabledVersionRelationshipsAppDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterEnabledVersionRelationshipsAppDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterEnabledVersionRelationshipsAppDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseAttributesInAppPurchaseType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseAttributesInAppPurchaseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseAttributesInAppPurchaseType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseAttributesInAppPurchaseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseAttributesState))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseAttributesStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseAttributesState?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseAttributesStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseRelationshipsAppsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseRelationshipsAppsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseRelationshipsAppsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseRelationshipsAppsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PrereleaseVersionType))
                {
                    return new global::AppStoreConnect.JsonConverters.PrereleaseVersionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PrereleaseVersionType?))
                {
                    return new global::AppStoreConnect.JsonConverters.PrereleaseVersionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PrereleaseVersionRelationshipsBuildsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.PrereleaseVersionRelationshipsBuildsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PrereleaseVersionRelationshipsBuildsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.PrereleaseVersionRelationshipsBuildsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PrereleaseVersionRelationshipsAppDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.PrereleaseVersionRelationshipsAppDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PrereleaseVersionRelationshipsAppDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.PrereleaseVersionRelationshipsAppDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseType))
                {
                    return new global::AppStoreConnect.JsonConverters.PromotedPurchaseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseType?))
                {
                    return new global::AppStoreConnect.JsonConverters.PromotedPurchaseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseAttributesState))
                {
                    return new global::AppStoreConnect.JsonConverters.PromotedPurchaseAttributesStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseAttributesState?))
                {
                    return new global::AppStoreConnect.JsonConverters.PromotedPurchaseAttributesStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseRelationshipsInAppPurchaseV2DataType))
                {
                    return new global::AppStoreConnect.JsonConverters.PromotedPurchaseRelationshipsInAppPurchaseV2DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseRelationshipsInAppPurchaseV2DataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.PromotedPurchaseRelationshipsInAppPurchaseV2DataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseRelationshipsSubscriptionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.PromotedPurchaseRelationshipsSubscriptionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.PromotedPurchaseRelationshipsSubscriptionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.PromotedPurchaseRelationshipsSubscriptionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionType))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionAttributesState))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionAttributesStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionAttributesState?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionAttributesStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsAppDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionRelationshipsAppDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsAppDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionRelationshipsAppDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsItemsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionRelationshipsItemsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsItemsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionRelationshipsItemsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsAppStoreVersionForReviewDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionRelationshipsAppStoreVersionForReviewDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsAppStoreVersionForReviewDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionRelationshipsAppStoreVersionForReviewDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsSubmittedByActorDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionRelationshipsSubmittedByActorDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsSubmittedByActorDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionRelationshipsSubmittedByActorDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsLastUpdatedByActorDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionRelationshipsLastUpdatedByActorDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsLastUpdatedByActorDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ReviewSubmissionRelationshipsLastUpdatedByActorDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGracePeriodType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGracePeriodTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGracePeriodType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGracePeriodTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGracePeriodAttributesRenewalType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGracePeriodAttributesRenewalTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGracePeriodAttributesRenewalType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGracePeriodAttributesRenewalTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptionsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupRelationshipsSubscriptionsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptionsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupRelationshipsSubscriptionsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptionGroupLocalizationsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupRelationshipsSubscriptionGroupLocalizationsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptionGroupLocalizationsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupRelationshipsSubscriptionGroupLocalizationsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsVersionsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupRelationshipsVersionsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsVersionsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGroupRelationshipsVersionsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationState))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEncryptionDeclarationStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppEncryptionDeclarationState?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppEncryptionDeclarationStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreAgeRating))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreAgeRatingJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreAgeRating?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreAgeRatingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionState))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionState?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppVersionState))
                {
                    return new global::AppStoreConnect.JsonConverters.AppVersionStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppVersionState?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppVersionStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BrazilAgeRating))
                {
                    return new global::AppStoreConnect.JsonConverters.BrazilAgeRatingJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BrazilAgeRating?))
                {
                    return new global::AppStoreConnect.JsonConverters.BrazilAgeRatingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildAudienceType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildAudienceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildAudienceType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildAudienceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.IconAssetType))
                {
                    return new global::AppStoreConnect.JsonConverters.IconAssetTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.IconAssetType?))
                {
                    return new global::AppStoreConnect.JsonConverters.IconAssetTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.Platform))
                {
                    return new global::AppStoreConnect.JsonConverters.PlatformJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.Platform?))
                {
                    return new global::AppStoreConnect.JsonConverters.PlatformNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGracePeriodDuration))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGracePeriodDurationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionGracePeriodDuration?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionGracePeriodDurationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionStatusUrlVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionStatusUrlVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionStatusUrlVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionStatusUrlVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFilterAppStoreVersionsAppStoreStateItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetCollectionFilterAppStoreVersionsAppStoreStateItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFilterAppStoreVersionsAppStoreStateItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetCollectionFilterAppStoreVersionsAppStoreStateItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFilterAppStoreVersionsPlatformItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetCollectionFilterAppStoreVersionsPlatformItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFilterAppStoreVersionsPlatformItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetCollectionFilterAppStoreVersionsPlatformItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFilterAppStoreVersionsAppVersionStateItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetCollectionFilterAppStoreVersionsAppVersionStateItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFilterAppStoreVersionsAppVersionStateItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetCollectionFilterAppStoreVersionsAppVersionStateItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFilterReviewSubmissionsStateItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetCollectionFilterReviewSubmissionsStateItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFilterReviewSubmissionsStateItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetCollectionFilterReviewSubmissionsStateItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFilterReviewSubmissionsPlatformItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetCollectionFilterReviewSubmissionsPlatformItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFilterReviewSubmissionsPlatformItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetCollectionFilterReviewSubmissionsPlatformItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionSortItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetCollectionSortItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionSortItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetCollectionSortItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsApp))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetCollectionFieldsAppJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsApp?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetCollectionFieldsAppNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsAppEncryptionDeclaration))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetCollectionFieldsAppEncryptionDeclarationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsAppEncryptionDeclaration?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetCollectionFieldsAppEncryptionDeclarationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsBuildIcon))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetCollectionFieldsBuildIconJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsBuildIcon?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetCollectionFieldsBuildIconNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsCiProduct))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetCollectionFieldsCiProductJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsCiProduct?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetCollectionFieldsCiProductNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsBetaGroup))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetCollectionFieldsBetaGroupJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsBetaGroup?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetCollectionFieldsBetaGroupNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsAppStoreVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetCollectionFieldsAppStoreVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsAppStoreVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetCollectionFieldsAppStoreVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsPreReleaseVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetCollectionFieldsPreReleaseVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsPreReleaseVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetCollectionFieldsPreReleaseVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsBetaAppLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetCollectionFieldsBetaAppLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsBetaAppLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetCollectionFieldsBetaAppLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsBuild))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetCollectionFieldsBuildJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsBuild?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetCollectionFieldsBuildNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsBetaLicenseAgreement))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetCollectionFieldsBetaLicenseAgreementJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsBetaLicenseAgreement?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetCollectionFieldsBetaLicenseAgreementNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsBetaAppReviewDetail))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetCollectionFieldsBetaAppReviewDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsBetaAppReviewDetail?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetCollectionFieldsBetaAppReviewDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsAppInfo))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetCollectionFieldsAppInfoJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsAppInfo?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetCollectionFieldsAppInfoNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsAppClip))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetCollectionFieldsAppClipJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsAppClip?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetCollectionFieldsAppClipNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsEndUserLicenseAgreement))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetCollectionFieldsEndUserLicenseAgreementJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsEndUserLicenseAgreement?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetCollectionFieldsEndUserLicenseAgreementNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsInAppPurchase))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetCollectionFieldsInAppPurchaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsInAppPurchase?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetCollectionFieldsInAppPurchaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsSubscriptionGroup))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetCollectionFieldsSubscriptionGroupJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsSubscriptionGroup?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetCollectionFieldsSubscriptionGroupNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsGameCenterEnabledVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetCollectionFieldsGameCenterEnabledVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsGameCenterEnabledVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetCollectionFieldsGameCenterEnabledVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsAppCustomProductPage))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetCollectionFieldsAppCustomProductPageJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsAppCustomProductPage?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetCollectionFieldsAppCustomProductPageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsPromotedPurchase))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetCollectionFieldsPromotedPurchaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsPromotedPurchase?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetCollectionFieldsPromotedPurchaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsAppEvent))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetCollectionFieldsAppEventJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsAppEvent?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetCollectionFieldsAppEventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsReviewSubmission))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetCollectionFieldsReviewSubmissionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsReviewSubmission?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetCollectionFieldsReviewSubmissionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsSubscriptionGracePeriod))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetCollectionFieldsSubscriptionGracePeriodJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsSubscriptionGracePeriod?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetCollectionFieldsSubscriptionGracePeriodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsGameCenterDetail))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetCollectionFieldsGameCenterDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsGameCenterDetail?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetCollectionFieldsGameCenterDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsAppStoreVersionExperiment))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetCollectionFieldsAppStoreVersionExperimentJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsAppStoreVersionExperiment?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetCollectionFieldsAppStoreVersionExperimentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsAndroidToIosAppMappingDetail))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetCollectionFieldsAndroidToIosAppMappingDetailJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionFieldsAndroidToIosAppMappingDetail?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetCollectionFieldsAndroidToIosAppMappingDetailNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetCollectionIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsGetCollectionIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsGetCollectionIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.AndroidToIosAppMappingDetail))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AndroidToIosAppMappingDetail(options);
                }
                if (type == typeof(global::AppStoreConnect.AndroidToIosAppMappingDetailAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AndroidToIosAppMappingDetailAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.AndroidToIosAppMappingDetailType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AndroidToIosAppMappingDetailType2(options);
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
                if (type == typeof(global::AppStoreConnect.AppClip))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClip(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipRelationshipsApp))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipRelationshipsApp(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipRelationshipsAppClipAdvancedExperiences))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipRelationshipsAppClipAdvancedExperiences(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipRelationshipsAppClipDefaultExperiences))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipRelationshipsAppClipDefaultExperiences(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipRelationshipsAppClipDefaultExperiencesDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipRelationshipsAppClipDefaultExperiencesDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipRelationshipsAppClipDefaultExperiencesDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipRelationshipsAppClipDefaultExperiencesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipRelationshipsAppData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipRelationshipsAppData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipRelationshipsAppDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipRelationshipsAppDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppClipType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPage))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPage(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageRelationshipsApp))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageRelationshipsApp(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageRelationshipsAppCustomProductPageVersions))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageRelationshipsAppCustomProductPageVersions(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageRelationshipsAppCustomProductPageVersionsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageRelationshipsAppCustomProductPageVersionsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageRelationshipsAppCustomProductPageVersionsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageRelationshipsAppCustomProductPageVersionsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageRelationshipsAppData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageRelationshipsAppData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageRelationshipsAppDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageRelationshipsAppDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppCustomProductPageType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEncryptionDeclaration))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppEncryptionDeclaration(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEncryptionDeclarationAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppEncryptionDeclarationAttributes(options);
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
                if (type == typeof(global::AppStoreConnect.AppEvent))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppEvent(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEventAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppEventAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEventAttributesArchivedTerritorySchedule))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppEventAttributesArchivedTerritorySchedule(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEventAttributesBadge))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppEventAttributesBadge2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEventAttributesEventState))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppEventAttributesEventState2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEventAttributesPriority))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppEventAttributesPriority2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEventAttributesPurpose))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppEventAttributesPurpose2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEventAttributesTerritorySchedule))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppEventAttributesTerritorySchedule(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEventRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppEventRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEventRelationshipsLocalizations))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppEventRelationshipsLocalizations(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEventRelationshipsLocalizationsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppEventRelationshipsLocalizationsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEventRelationshipsLocalizationsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppEventRelationshipsLocalizationsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEventType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppEventType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfo))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfo(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoAttributes(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppInfoAttributesAustraliaAgeRating))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoAttributesAustraliaAgeRating2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppInfoAttributesBrazilAgeRatingV2))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoAttributesBrazilAgeRatingV22(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppInfoAttributesFranceAgeRating))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoAttributesFranceAgeRating2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppInfoAttributesKoreaAgeRating))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoAttributesKoreaAgeRating2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::AppStoreConnect.AppInfoAttributesState))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoAttributesState2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsAgeRatingDeclaration))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoRelationshipsAgeRatingDeclaration(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsAgeRatingDeclarationData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoRelationshipsAgeRatingDeclarationData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsAgeRatingDeclarationDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoRelationshipsAgeRatingDeclarationDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsApp))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoRelationshipsApp(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsAppData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoRelationshipsAppData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsAppDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoRelationshipsAppDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsAppInfoLocalizations))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoRelationshipsAppInfoLocalizations(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsAppInfoLocalizationsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoRelationshipsAppInfoLocalizationsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsAppInfoLocalizationsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoRelationshipsAppInfoLocalizationsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsPrimaryCategory))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoRelationshipsPrimaryCategory(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsPrimaryCategoryData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoRelationshipsPrimaryCategoryData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsPrimaryCategoryDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoRelationshipsPrimaryCategoryDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsPrimarySubcategoryOne))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoRelationshipsPrimarySubcategoryOne(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsPrimarySubcategoryOneData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoRelationshipsPrimarySubcategoryOneData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsPrimarySubcategoryOneDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoRelationshipsPrimarySubcategoryOneDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsPrimarySubcategoryTwo))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoRelationshipsPrimarySubcategoryTwo(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsPrimarySubcategoryTwoData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoRelationshipsPrimarySubcategoryTwoData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsPrimarySubcategoryTwoDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoRelationshipsPrimarySubcategoryTwoDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsSecondaryCategory))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoRelationshipsSecondaryCategory(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsSecondaryCategoryData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoRelationshipsSecondaryCategoryData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsSecondaryCategoryDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoRelationshipsSecondaryCategoryDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsSecondarySubcategoryOne))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoRelationshipsSecondarySubcategoryOne(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsSecondarySubcategoryOneData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoRelationshipsSecondarySubcategoryOneData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsSecondarySubcategoryOneDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoRelationshipsSecondarySubcategoryOneDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsSecondarySubcategoryTwo))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoRelationshipsSecondarySubcategoryTwo(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsSecondarySubcategoryTwoData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoRelationshipsSecondarySubcategoryTwoData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsSecondarySubcategoryTwoDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoRelationshipsSecondarySubcategoryTwoDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsTerritoryAgeRatings))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoRelationshipsTerritoryAgeRatings(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppInfoType2(options);
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
                if (type == typeof(global::AppStoreConnect.AppStoreAgeRating))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreAgeRating2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersion(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionAttributesReleaseType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionAttributesReleaseType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionAttributesReviewType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionAttributesReviewType2(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentV2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2Attributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentV2Attributes(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2AttributesState))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentV2AttributesState2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2Relationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentV2Relationships(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsApp))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentV2RelationshipsApp(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsAppData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentV2RelationshipsAppData(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsAppDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentV2RelationshipsAppDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsAppStoreVersionExperimentTreatments))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentV2RelationshipsAppStoreVersionExperimentTreatments(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsAppStoreVersionExperimentTreatmentsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentV2RelationshipsAppStoreVersionExperimentTreatmentsDataItem(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsAppStoreVersionExperimentTreatmentsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentV2RelationshipsAppStoreVersionExperimentTreatmentsDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsControlVersions))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentV2RelationshipsControlVersions(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsControlVersionsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentV2RelationshipsControlVersionsDataItem(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsControlVersionsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentV2RelationshipsControlVersionsDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsLatestControlVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentV2RelationshipsLatestControlVersion(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsLatestControlVersionData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentV2RelationshipsLatestControlVersionData(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsLatestControlVersionDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentV2RelationshipsLatestControlVersionDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2Type))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentV2Type2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::AppStoreConnect.AppStoreVersionRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAlternativeDistributionPackage))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionRelationshipsAlternativeDistributionPackage(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAlternativeDistributionPackageData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionRelationshipsAlternativeDistributionPackageData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAlternativeDistributionPackageDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionRelationshipsAlternativeDistributionPackageDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsApp))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionRelationshipsApp(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppClipDefaultExperience))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionRelationshipsAppClipDefaultExperience(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppClipDefaultExperienceData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionRelationshipsAppClipDefaultExperienceData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppClipDefaultExperienceDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionRelationshipsAppClipDefaultExperienceDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionRelationshipsAppData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionRelationshipsAppDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreReviewDetail))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionRelationshipsAppStoreReviewDetail(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreReviewDetailData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionRelationshipsAppStoreReviewDetailData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreReviewDetailDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionRelationshipsAppStoreReviewDetailDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionExperiments))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionRelationshipsAppStoreVersionExperiments(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionExperimentsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionRelationshipsAppStoreVersionExperimentsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionExperimentsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionRelationshipsAppStoreVersionExperimentsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionExperimentsV2))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionRelationshipsAppStoreVersionExperimentsV2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionExperimentsV2DataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionRelationshipsAppStoreVersionExperimentsV2DataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionExperimentsV2DataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionRelationshipsAppStoreVersionExperimentsV2DataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionLocalizations))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionRelationshipsAppStoreVersionLocalizations(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionLocalizationsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionRelationshipsAppStoreVersionLocalizationsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionLocalizationsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionRelationshipsAppStoreVersionLocalizationsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionPhasedRelease))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionRelationshipsAppStoreVersionPhasedRelease(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionPhasedReleaseData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionRelationshipsAppStoreVersionPhasedReleaseData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionPhasedReleaseDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionRelationshipsAppStoreVersionPhasedReleaseDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionSubmission))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionRelationshipsAppStoreVersionSubmission(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionSubmissionData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionRelationshipsAppStoreVersionSubmissionData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionSubmissionDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionRelationshipsAppStoreVersionSubmissionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsBuild))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionRelationshipsBuild(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsBuildData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionRelationshipsBuildData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsBuildDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionRelationshipsBuildDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsCustomerReviews))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionRelationshipsCustomerReviews(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsGameCenterAppVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionRelationshipsGameCenterAppVersion(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsGameCenterAppVersionData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionRelationshipsGameCenterAppVersionData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsGameCenterAppVersionDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionRelationshipsGameCenterAppVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsRoutingAppCoverage))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionRelationshipsRoutingAppCoverage(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsRoutingAppCoverageData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionRelationshipsRoutingAppCoverageData(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsRoutingAppCoverageDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionRelationshipsRoutingAppCoverageDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionState))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionState2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppVersionState))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppVersionState2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetCollectionFieldsAndroidToIosAppMappingDetail))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppsGetCollectionFieldsAndroidToIosAppMappingDetail2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetCollectionFieldsApp))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppsGetCollectionFieldsApp2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetCollectionFieldsAppClip))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppsGetCollectionFieldsAppClip2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetCollectionFieldsAppCustomProductPage))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppsGetCollectionFieldsAppCustomProductPage2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetCollectionFieldsAppEncryptionDeclaration))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppsGetCollectionFieldsAppEncryptionDeclaration2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetCollectionFieldsAppEvent))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppsGetCollectionFieldsAppEvent2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetCollectionFieldsAppInfo))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppsGetCollectionFieldsAppInfo2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetCollectionFieldsAppStoreVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppsGetCollectionFieldsAppStoreVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetCollectionFieldsAppStoreVersionExperiment))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppsGetCollectionFieldsAppStoreVersionExperiment2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetCollectionFieldsBetaAppLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppsGetCollectionFieldsBetaAppLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetCollectionFieldsBetaAppReviewDetail))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppsGetCollectionFieldsBetaAppReviewDetail2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetCollectionFieldsBetaGroup))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppsGetCollectionFieldsBetaGroup2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetCollectionFieldsBetaLicenseAgreement))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppsGetCollectionFieldsBetaLicenseAgreement2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetCollectionFieldsBuild))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppsGetCollectionFieldsBuild2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetCollectionFieldsBuildIcon))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppsGetCollectionFieldsBuildIcon2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetCollectionFieldsCiProduct))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppsGetCollectionFieldsCiProduct2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetCollectionFieldsEndUserLicenseAgreement))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppsGetCollectionFieldsEndUserLicenseAgreement2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetCollectionFieldsGameCenterDetail))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppsGetCollectionFieldsGameCenterDetail2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetCollectionFieldsGameCenterEnabledVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppsGetCollectionFieldsGameCenterEnabledVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetCollectionFieldsInAppPurchase))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppsGetCollectionFieldsInAppPurchase2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetCollectionFieldsPreReleaseVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppsGetCollectionFieldsPreReleaseVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetCollectionFieldsPromotedPurchase))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppsGetCollectionFieldsPromotedPurchase2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetCollectionFieldsReviewSubmission))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppsGetCollectionFieldsReviewSubmission2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetCollectionFieldsSubscriptionGracePeriod))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppsGetCollectionFieldsSubscriptionGracePeriod2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetCollectionFieldsSubscriptionGroup))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppsGetCollectionFieldsSubscriptionGroup2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetCollectionFilterAppStoreVersionsAppStoreStateItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppsGetCollectionFilterAppStoreVersionsAppStoreStateItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetCollectionFilterAppStoreVersionsAppVersionStateItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppsGetCollectionFilterAppStoreVersionsAppVersionStateItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetCollectionFilterAppStoreVersionsPlatformItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppsGetCollectionFilterAppStoreVersionsPlatformItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetCollectionFilterReviewSubmissionsPlatformItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppsGetCollectionFilterReviewSubmissionsPlatformItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetCollectionFilterReviewSubmissionsStateItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppsGetCollectionFilterReviewSubmissionsStateItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetCollectionIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppsGetCollectionIncludeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetCollectionSortItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_AppsGetCollectionSortItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppsResponse(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsResponseIncludedItemDiscriminator))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppsResponseIncludedItemDiscriminator(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsResponseIncludedItemDiscriminatorType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_AppsResponseIncludedItemDiscriminatorType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaAppLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaAppLocalization(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaAppLocalizationAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaAppLocalizationAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaAppLocalizationRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaAppLocalizationRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaAppLocalizationRelationshipsApp))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaAppLocalizationRelationshipsApp(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaAppLocalizationRelationshipsAppData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaAppLocalizationRelationshipsAppData(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaAppLocalizationRelationshipsAppDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaAppLocalizationRelationshipsAppDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaAppLocalizationType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaAppLocalizationType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaAppReviewDetail))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaAppReviewDetail(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaAppReviewDetailAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaAppReviewDetailAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaAppReviewDetailRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaAppReviewDetailRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaAppReviewDetailRelationshipsApp))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaAppReviewDetailRelationshipsApp(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaAppReviewDetailRelationshipsAppData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaAppReviewDetailRelationshipsAppData(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaAppReviewDetailRelationshipsAppDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaAppReviewDetailRelationshipsAppDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaAppReviewDetailType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaAppReviewDetailType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaGroup))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaGroup(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaGroupAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaGroupAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaGroupRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaGroupRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaGroupRelationshipsApp))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaGroupRelationshipsApp(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaGroupRelationshipsAppData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaGroupRelationshipsAppData(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaGroupRelationshipsAppDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaGroupRelationshipsAppDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaGroupRelationshipsBetaRecruitmentCriteria))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaGroupRelationshipsBetaRecruitmentCriteria(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaGroupRelationshipsBetaRecruitmentCriteriaData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaGroupRelationshipsBetaRecruitmentCriteriaData(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaGroupRelationshipsBetaRecruitmentCriteriaDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaGroupRelationshipsBetaRecruitmentCriteriaDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaGroupRelationshipsBetaRecruitmentCriterionCompatibleBuildCheck))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaGroupRelationshipsBetaRecruitmentCriterionCompatibleBuildCheck(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaGroupRelationshipsBetaTesters))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaGroupRelationshipsBetaTesters(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaGroupRelationshipsBetaTestersDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaGroupRelationshipsBetaTestersDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaGroupRelationshipsBetaTestersDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaGroupRelationshipsBetaTestersDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaGroupRelationshipsBuilds))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaGroupRelationshipsBuilds(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaGroupRelationshipsBuildsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaGroupRelationshipsBuildsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaGroupRelationshipsBuildsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaGroupRelationshipsBuildsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaGroupType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaGroupType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaLicenseAgreement))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaLicenseAgreement(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaLicenseAgreementAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaLicenseAgreementAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaLicenseAgreementRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaLicenseAgreementRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaLicenseAgreementRelationshipsApp))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaLicenseAgreementRelationshipsApp(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaLicenseAgreementRelationshipsAppData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaLicenseAgreementRelationshipsAppData(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaLicenseAgreementRelationshipsAppDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaLicenseAgreementRelationshipsAppDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaLicenseAgreementType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BetaLicenseAgreementType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BrazilAgeRating))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_BrazilAgeRating2(options);
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
                if (type == typeof(global::AppStoreConnect.BuildIcon))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildIcon(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildIconAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildIconAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildIconType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildIconType2(options);
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
                if (type == typeof(global::AppStoreConnect.CiProduct))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiProduct(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiProductAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductAttributesProductType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiProductAttributesProductType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiProductRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductRelationshipsAdditionalRepositories))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiProductRelationshipsAdditionalRepositories(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductRelationshipsApp))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiProductRelationshipsApp(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductRelationshipsAppData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiProductRelationshipsAppData(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductRelationshipsAppDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiProductRelationshipsAppDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductRelationshipsBuildRuns))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiProductRelationshipsBuildRuns(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductRelationshipsBundleId))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiProductRelationshipsBundleId(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductRelationshipsBundleIdData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiProductRelationshipsBundleIdData(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductRelationshipsBundleIdDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiProductRelationshipsBundleIdDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductRelationshipsPrimaryRepositories))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiProductRelationshipsPrimaryRepositories(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductRelationshipsPrimaryRepositoriesDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiProductRelationshipsPrimaryRepositoriesDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductRelationshipsPrimaryRepositoriesDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiProductRelationshipsPrimaryRepositoriesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductRelationshipsWorkflows))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiProductRelationshipsWorkflows(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiProductType2(options);
                }
                if (type == typeof(global::AppStoreConnect.EndUserLicenseAgreement))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_EndUserLicenseAgreement(options);
                }
                if (type == typeof(global::AppStoreConnect.EndUserLicenseAgreementAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_EndUserLicenseAgreementAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.EndUserLicenseAgreementRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_EndUserLicenseAgreementRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.EndUserLicenseAgreementRelationshipsApp))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_EndUserLicenseAgreementRelationshipsApp(options);
                }
                if (type == typeof(global::AppStoreConnect.EndUserLicenseAgreementRelationshipsAppData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_EndUserLicenseAgreementRelationshipsAppData(options);
                }
                if (type == typeof(global::AppStoreConnect.EndUserLicenseAgreementRelationshipsAppDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_EndUserLicenseAgreementRelationshipsAppDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.EndUserLicenseAgreementRelationshipsTerritories))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_EndUserLicenseAgreementRelationshipsTerritories(options);
                }
                if (type == typeof(global::AppStoreConnect.EndUserLicenseAgreementRelationshipsTerritoriesDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_EndUserLicenseAgreementRelationshipsTerritoriesDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.EndUserLicenseAgreementRelationshipsTerritoriesDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_EndUserLicenseAgreementRelationshipsTerritoriesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.EndUserLicenseAgreementType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_EndUserLicenseAgreementType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterDetail))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetail(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterDetailAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailRelationships(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsAchievementReleases))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailRelationshipsAchievementReleases(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsAchievementReleasesDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailRelationshipsAchievementReleasesDataItem(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsAchievementReleasesDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailRelationshipsAchievementReleasesDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsActivityReleases))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailRelationshipsActivityReleases(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsActivityReleasesDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailRelationshipsActivityReleasesDataItem(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsActivityReleasesDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailRelationshipsActivityReleasesDataItemType2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsApp))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailRelationshipsApp(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsAppData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailRelationshipsAppData(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsAppDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailRelationshipsAppDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsBlockedPlayers))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailRelationshipsBlockedPlayers(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsChallengeReleases))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailRelationshipsChallengeReleases(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsChallengeReleasesDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailRelationshipsChallengeReleasesDataItem(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsChallengeReleasesDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailRelationshipsChallengeReleasesDataItemType2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsChallengesMinimumPlatformVersions))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailRelationshipsChallengesMinimumPlatformVersions(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsChallengesMinimumPlatformVersionsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailRelationshipsChallengesMinimumPlatformVersionsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsChallengesMinimumPlatformVersionsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailRelationshipsChallengesMinimumPlatformVersionsDataItemType2(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultGroupLeaderboard))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailRelationshipsDefaultGroupLeaderboard(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultGroupLeaderboardData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailRelationshipsDefaultGroupLeaderboardData(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultGroupLeaderboardDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailRelationshipsDefaultGroupLeaderboardDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultGroupLeaderboardV2))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailRelationshipsDefaultGroupLeaderboardV2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultGroupLeaderboardV2Data))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailRelationshipsDefaultGroupLeaderboardV2Data(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultGroupLeaderboardV2DataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailRelationshipsDefaultGroupLeaderboardV2DataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultLeaderboard))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailRelationshipsDefaultLeaderboard(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultLeaderboardData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailRelationshipsDefaultLeaderboardData(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultLeaderboardDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailRelationshipsDefaultLeaderboardDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultLeaderboardV2))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailRelationshipsDefaultLeaderboardV2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultLeaderboardV2Data))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailRelationshipsDefaultLeaderboardV2Data(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultLeaderboardV2DataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailRelationshipsDefaultLeaderboardV2DataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAchievements))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailRelationshipsGameCenterAchievements(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAchievementsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailRelationshipsGameCenterAchievementsDataItem(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAchievementsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailRelationshipsGameCenterAchievementsDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAchievementsV2))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailRelationshipsGameCenterAchievementsV2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAchievementsV2DataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailRelationshipsGameCenterAchievementsV2DataItem(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAchievementsV2DataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailRelationshipsGameCenterAchievementsV2DataItemType2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterActivities))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailRelationshipsGameCenterActivities(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterActivitiesDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailRelationshipsGameCenterActivitiesDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterActivitiesDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailRelationshipsGameCenterActivitiesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAppVersions))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailRelationshipsGameCenterAppVersions(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAppVersionsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailRelationshipsGameCenterAppVersionsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAppVersionsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailRelationshipsGameCenterAppVersionsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterChallenges))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailRelationshipsGameCenterChallenges(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterChallengesDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailRelationshipsGameCenterChallengesDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterChallengesDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailRelationshipsGameCenterChallengesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterGroup))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailRelationshipsGameCenterGroup(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterGroupData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailRelationshipsGameCenterGroupData(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterGroupDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailRelationshipsGameCenterGroupDataType2(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardSets))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailRelationshipsGameCenterLeaderboardSets(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardSetsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailRelationshipsGameCenterLeaderboardSetsDataItem(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardSetsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailRelationshipsGameCenterLeaderboardSetsDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardSetsV2))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailRelationshipsGameCenterLeaderboardSetsV2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardSetsV2DataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailRelationshipsGameCenterLeaderboardSetsV2DataItem(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardSetsV2DataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailRelationshipsGameCenterLeaderboardSetsV2DataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboards))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailRelationshipsGameCenterLeaderboards(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailRelationshipsGameCenterLeaderboardsDataItem(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailRelationshipsGameCenterLeaderboardsDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardsV2))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailRelationshipsGameCenterLeaderboardsV2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardsV2DataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailRelationshipsGameCenterLeaderboardsV2DataItem(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardsV2DataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailRelationshipsGameCenterLeaderboardsV2DataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsLeaderboardReleases))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailRelationshipsLeaderboardReleases(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsLeaderboardReleasesDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailRelationshipsLeaderboardReleasesDataItem(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsLeaderboardReleasesDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailRelationshipsLeaderboardReleasesDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsLeaderboardSetReleases))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailRelationshipsLeaderboardSetReleases(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsLeaderboardSetReleasesDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailRelationshipsLeaderboardSetReleasesDataItem(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsLeaderboardSetReleasesDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailRelationshipsLeaderboardSetReleasesDataItemType2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::AppStoreConnect.GameCenterDetailType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterDetailType2(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterEnabledVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterEnabledVersion(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterEnabledVersionAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterEnabledVersionAttributes(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterEnabledVersionRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterEnabledVersionRelationships(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterEnabledVersionRelationshipsApp))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterEnabledVersionRelationshipsApp(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterEnabledVersionRelationshipsAppData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterEnabledVersionRelationshipsAppData(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterEnabledVersionRelationshipsAppDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterEnabledVersionRelationshipsAppDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterEnabledVersionRelationshipsCompatibleVersions))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterEnabledVersionRelationshipsCompatibleVersions(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterEnabledVersionRelationshipsCompatibleVersionsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterEnabledVersionRelationshipsCompatibleVersionsDataItem(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterEnabledVersionRelationshipsCompatibleVersionsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterEnabledVersionRelationshipsCompatibleVersionsDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterEnabledVersionType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterEnabledVersionType2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::AppStoreConnect.IconAssetType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_IconAssetType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ImageAsset))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_ImageAsset(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchase))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_InAppPurchase(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseAttributes(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseAttributesInAppPurchaseType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseAttributesInAppPurchaseType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseAttributesState))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseAttributesState2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseRelationships(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseRelationshipsApps))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseRelationshipsApps(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseRelationshipsAppsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseRelationshipsAppsDataItem(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseRelationshipsAppsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseRelationshipsAppsDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseType2_3(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::AppStoreConnect.IncludedItem48))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_IncludedItem482(options);
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
                if (type == typeof(global::AppStoreConnect.PrereleaseVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_PrereleaseVersion(options);
                }
                if (type == typeof(global::AppStoreConnect.PrereleaseVersionAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_PrereleaseVersionAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.PrereleaseVersionRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_PrereleaseVersionRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.PrereleaseVersionRelationshipsApp))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_PrereleaseVersionRelationshipsApp(options);
                }
                if (type == typeof(global::AppStoreConnect.PrereleaseVersionRelationshipsAppData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_PrereleaseVersionRelationshipsAppData(options);
                }
                if (type == typeof(global::AppStoreConnect.PrereleaseVersionRelationshipsAppDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_PrereleaseVersionRelationshipsAppDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.PrereleaseVersionRelationshipsBuilds))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_PrereleaseVersionRelationshipsBuilds(options);
                }
                if (type == typeof(global::AppStoreConnect.PrereleaseVersionRelationshipsBuildsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_PrereleaseVersionRelationshipsBuildsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.PrereleaseVersionRelationshipsBuildsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_PrereleaseVersionRelationshipsBuildsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.PrereleaseVersionType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_PrereleaseVersionType2(options);
                }
                if (type == typeof(global::AppStoreConnect.PromotedPurchase))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_PromotedPurchase(options);
                }
                if (type == typeof(global::AppStoreConnect.PromotedPurchaseAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_PromotedPurchaseAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.PromotedPurchaseAttributesState))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_PromotedPurchaseAttributesState2(options);
                }
                if (type == typeof(global::AppStoreConnect.PromotedPurchaseRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_PromotedPurchaseRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.PromotedPurchaseRelationshipsInAppPurchaseV2))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_PromotedPurchaseRelationshipsInAppPurchaseV2(options);
                }
                if (type == typeof(global::AppStoreConnect.PromotedPurchaseRelationshipsInAppPurchaseV2Data))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_PromotedPurchaseRelationshipsInAppPurchaseV2Data(options);
                }
                if (type == typeof(global::AppStoreConnect.PromotedPurchaseRelationshipsInAppPurchaseV2DataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_PromotedPurchaseRelationshipsInAppPurchaseV2DataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.PromotedPurchaseRelationshipsSubscription))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_PromotedPurchaseRelationshipsSubscription(options);
                }
                if (type == typeof(global::AppStoreConnect.PromotedPurchaseRelationshipsSubscriptionData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_PromotedPurchaseRelationshipsSubscriptionData(options);
                }
                if (type == typeof(global::AppStoreConnect.PromotedPurchaseRelationshipsSubscriptionDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_PromotedPurchaseRelationshipsSubscriptionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.PromotedPurchaseType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_PromotedPurchaseType2(options);
                }
                if (type == typeof(global::AppStoreConnect.RelationshipLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_RelationshipLinks(options);
                }
                if (type == typeof(global::AppStoreConnect.ResourceLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_ResourceLinks(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmission))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_ReviewSubmission(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionAttributesState))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionAttributesState2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsApp))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionRelationshipsApp(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsAppData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionRelationshipsAppData(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsAppDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionRelationshipsAppDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsAppStoreVersionForReview))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionRelationshipsAppStoreVersionForReview(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsAppStoreVersionForReviewData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionRelationshipsAppStoreVersionForReviewData(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsAppStoreVersionForReviewDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionRelationshipsAppStoreVersionForReviewDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsItems))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionRelationshipsItems(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsItemsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionRelationshipsItemsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsItemsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionRelationshipsItemsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsLastUpdatedByActor))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionRelationshipsLastUpdatedByActor(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsLastUpdatedByActorData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionRelationshipsLastUpdatedByActorData(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsLastUpdatedByActorDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionRelationshipsLastUpdatedByActorDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsSubmittedByActor))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionRelationshipsSubmittedByActor(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsSubmittedByActorData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionRelationshipsSubmittedByActorData(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsSubmittedByActorDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionRelationshipsSubmittedByActorDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_ReviewSubmissionType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionGracePeriod))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SubscriptionGracePeriod(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionGracePeriodAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionGracePeriodAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionGracePeriodAttributesRenewalType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionGracePeriodAttributesRenewalType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionGracePeriodDuration))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionGracePeriodDuration2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionGracePeriodType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionGracePeriodType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionGroup))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SubscriptionGroup(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionGroupAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionGroupAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionGroupRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionGroupRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptionGroupLocalizations))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionGroupRelationshipsSubscriptionGroupLocalizations(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptionGroupLocalizationsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionGroupRelationshipsSubscriptionGroupLocalizationsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptionGroupLocalizationsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionGroupRelationshipsSubscriptionGroupLocalizationsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptions))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionGroupRelationshipsSubscriptions(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptionsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionGroupRelationshipsSubscriptionsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptionsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionGroupRelationshipsSubscriptionsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsVersions))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionGroupRelationshipsVersions(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsVersionsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionGroupRelationshipsVersionsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsVersionsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionGroupRelationshipsVersionsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionGroupType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SubscriptionGroupType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionStatusUrlVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SubscriptionStatusUrlVersion2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.App>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_B3E6805DBD7C1E01(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipRelationshipsAppClipDefaultExperiencesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_26FEFEEC1B548F87(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageRelationshipsAppCustomProductPageVersionsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_68A12E035EEC3B13(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppEncryptionDeclarationRelationshipsBuildsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_93598F68C07F5A78(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppEventAttributesArchivedTerritorySchedule>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_22CDBA339F2D7CA4(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppEventAttributesTerritorySchedule>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_8F8C64169B2CC510(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppEventRelationshipsLocalizationsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_8C963298A67F96ED(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfoRelationshipsAppInfoLocalizationsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_2CA8DA5C6FDCF956(options);
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
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsAppStoreVersionExperimentTreatmentsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_F5CA2AE6467D14F8(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsControlVersionsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_1A4E50D4E2370A63(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionExperimentsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_BA38B4BCF0C43196(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionExperimentsV2DataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_FD7AE3AA63780EF7(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionLocalizationsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_DD18AFE2EDFA30C3(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsAndroidToIosAppMappingDetail>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_E37FC351F3DC25C4(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsApp>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_5D0DFDF4ECBE5357(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsAppClip>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_82378F3F98BB1DDA(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsAppCustomProductPage>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_1C89CC0A2502BA78(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsAppEncryptionDeclaration>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_94E3081437DB0E91(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsAppEvent>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_4518AA1F77ECDC96(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsAppInfo>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_E078977C2AFB8A4B(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsAppStoreVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_4433C335589C7E6E(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsAppStoreVersionExperiment>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_927C5D146EF48144(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsBetaAppLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_D19F8B2DCD0E9E74(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsBetaAppReviewDetail>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_3E611F93FD18EFD2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsBetaGroup>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_0C594CD785E5C7A3(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsBetaLicenseAgreement>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_743A2A382F4205FC(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsBuild>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_498AD3C0E39A3485(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsBuildIcon>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_366758843B6F752A(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsCiProduct>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_0640DA4CC7355A50(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsEndUserLicenseAgreement>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_8670E50C6081AB24(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsGameCenterDetail>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_D9F109559AE57C0C(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsGameCenterEnabledVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_62ABB1C093B6E921(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsInAppPurchase>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_90101369CA737374(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsPreReleaseVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_10ACDF334B12F08D(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsPromotedPurchase>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_AD70507FEE16636E(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsReviewSubmission>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_87BB0BE4E245C016(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsSubscriptionGracePeriod>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_CBD1CFA15A04729E(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFieldsSubscriptionGroup>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_279B49CB46F5A630(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFilterAppStoreVersionsAppStoreStateItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_1DFC0EE9C4E889D2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFilterAppStoreVersionsAppVersionStateItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_7FC6356D718AB5E0(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFilterAppStoreVersionsPlatformItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_200F9A3A51869BB6(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFilterReviewSubmissionsPlatformItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_3F8E5A159E6075D1(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionFilterReviewSubmissionsStateItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_78AB8011FB4F57D2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_9A641DFDC849E0E9(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsGetCollectionSortItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_8F7E0412A169F5CB(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BetaGroupRelationshipsBetaTestersDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_863BD87BE9315B59(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BetaGroupRelationshipsBuildsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_DCEAB27C8B4A193C(options);
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
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductRelationshipsPrimaryRepositoriesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_3D01A59400521D64(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.EndUserLicenseAgreementRelationshipsTerritoriesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_AFC0FEFDD5ECEBEE(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailRelationshipsAchievementReleasesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_163B9FBDD06E253E(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailRelationshipsActivityReleasesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_E4A79EC7971BDFF0(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailRelationshipsChallengeReleasesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_F0FCB6EA65112400(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailRelationshipsChallengesMinimumPlatformVersionsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_0654086FB92C9DDB(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAchievementsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_7AA012885851E229(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAchievementsV2DataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_B6068915F7C96CB3(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterActivitiesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_E9EDDB3ECD195334(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAppVersionsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_AE5A1B2D0C061F78(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterChallengesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_7A04A5998E5BB916(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardSetsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_B69BB8E934D2DB0C(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardSetsV2DataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_547EC3DE2A0631EE(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_D2583A7297011AF5(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardsV2DataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_C6F8BDDB0E971605(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailRelationshipsLeaderboardReleasesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_8890FD275B40B432(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailRelationshipsLeaderboardSetReleasesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_317CF6EEF5650AA0(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterEnabledVersionRelationshipsCompatibleVersionsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_7F44FF89E9C83A8D(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseRelationshipsAppsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_F769136ADD9F31F7(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem48>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_0D99742BC4E1BD95(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.PrereleaseVersionRelationshipsBuildsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_DA2E942F9A1779C6(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionRelationshipsItemsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_C95931C6158BAB9B(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptionGroupLocalizationsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_D1D1B0076D5BCAEA(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptionsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_DF3A5C9111A7F924(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupRelationshipsVersionsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata3.Create_SourceGenerationContextMetadataType_4F61CD43D7867E52(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<string>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_05BF36C073875770(options);
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
                if (type == typeof(global::AppStoreConnect.AndroidToIosAppMappingDetailType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAndroidToIosAppMappingDetailType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppAttributesContentRightsDeclaration?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppAttributesContentRightsDeclaration2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipRelationshipsAppClipDefaultExperiencesDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppClipRelationshipsAppClipDefaultExperiencesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipRelationshipsAppDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppClipRelationshipsAppDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppClipType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppClipType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageRelationshipsAppCustomProductPageVersionsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppCustomProductPageRelationshipsAppCustomProductPageVersionsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageRelationshipsAppDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppCustomProductPageRelationshipsAppDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppCustomProductPageType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppCustomProductPageType2(options);
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
                if (type == typeof(global::AppStoreConnect.AppEventAttributesBadge?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppEventAttributesBadge2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEventAttributesEventState?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppEventAttributesEventState2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEventAttributesPriority?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppEventAttributesPriority2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEventAttributesPurpose?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppEventAttributesPurpose2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEventRelationshipsLocalizationsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppEventRelationshipsLocalizationsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppEventType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppEventType2(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppInfoAttributesAustraliaAgeRating?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppInfoAttributesAustraliaAgeRating2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppInfoAttributesBrazilAgeRatingV2?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppInfoAttributesBrazilAgeRatingV22(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppInfoAttributesFranceAgeRating?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppInfoAttributesFranceAgeRating2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppInfoAttributesKoreaAgeRating?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppInfoAttributesKoreaAgeRating2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::AppStoreConnect.AppInfoAttributesState?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppInfoAttributesState2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsAgeRatingDeclarationDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppInfoRelationshipsAgeRatingDeclarationDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsAppDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppInfoRelationshipsAppDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsAppInfoLocalizationsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppInfoRelationshipsAppInfoLocalizationsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsPrimaryCategoryDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppInfoRelationshipsPrimaryCategoryDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsPrimarySubcategoryOneDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppInfoRelationshipsPrimarySubcategoryOneDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsPrimarySubcategoryTwoDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppInfoRelationshipsPrimarySubcategoryTwoDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsSecondaryCategoryDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppInfoRelationshipsSecondaryCategoryDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsSecondarySubcategoryOneDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppInfoRelationshipsSecondarySubcategoryOneDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoRelationshipsSecondarySubcategoryTwoDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppInfoRelationshipsSecondarySubcategoryTwoDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppInfoType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppInfoType2(options);
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
                if (type == typeof(global::AppStoreConnect.AppStoreAgeRating?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppStoreAgeRating2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionAttributesReleaseType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppStoreVersionAttributesReleaseType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionAttributesReviewType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppStoreVersionAttributesReviewType2(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2AttributesState?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppStoreVersionExperimentV2AttributesState2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsAppDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppStoreVersionExperimentV2RelationshipsAppDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsAppStoreVersionExperimentTreatmentsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppStoreVersionExperimentV2RelationshipsAppStoreVersionExperimentTreatmentsDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsControlVersionsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppStoreVersionExperimentV2RelationshipsControlVersionsDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsLatestControlVersionDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppStoreVersionExperimentV2RelationshipsLatestControlVersionDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentV2Type?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppStoreVersionExperimentV2Type2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAlternativeDistributionPackageDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppStoreVersionRelationshipsAlternativeDistributionPackageDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppClipDefaultExperienceDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppStoreVersionRelationshipsAppClipDefaultExperienceDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppStoreVersionRelationshipsAppDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreReviewDetailDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppStoreVersionRelationshipsAppStoreReviewDetailDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionExperimentsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppStoreVersionRelationshipsAppStoreVersionExperimentsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionExperimentsV2DataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppStoreVersionRelationshipsAppStoreVersionExperimentsV2DataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionLocalizationsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppStoreVersionRelationshipsAppStoreVersionLocalizationsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionPhasedReleaseDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppStoreVersionRelationshipsAppStoreVersionPhasedReleaseDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionSubmissionDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppStoreVersionRelationshipsAppStoreVersionSubmissionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsBuildDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppStoreVersionRelationshipsBuildDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsGameCenterAppVersionDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppStoreVersionRelationshipsGameCenterAppVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionRelationshipsRoutingAppCoverageDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppStoreVersionRelationshipsRoutingAppCoverageDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionState?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppStoreVersionState2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppStoreVersionType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppStoreVersionType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppType2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppVersionState?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppVersionState2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetCollectionFieldsAndroidToIosAppMappingDetail?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppsGetCollectionFieldsAndroidToIosAppMappingDetail2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetCollectionFieldsApp?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppsGetCollectionFieldsApp2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetCollectionFieldsAppClip?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppsGetCollectionFieldsAppClip2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetCollectionFieldsAppCustomProductPage?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppsGetCollectionFieldsAppCustomProductPage2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetCollectionFieldsAppEncryptionDeclaration?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppsGetCollectionFieldsAppEncryptionDeclaration2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetCollectionFieldsAppEvent?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppsGetCollectionFieldsAppEvent2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetCollectionFieldsAppInfo?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppsGetCollectionFieldsAppInfo2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetCollectionFieldsAppStoreVersion?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppsGetCollectionFieldsAppStoreVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetCollectionFieldsAppStoreVersionExperiment?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppsGetCollectionFieldsAppStoreVersionExperiment2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetCollectionFieldsBetaAppLocalization?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppsGetCollectionFieldsBetaAppLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetCollectionFieldsBetaAppReviewDetail?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppsGetCollectionFieldsBetaAppReviewDetail2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetCollectionFieldsBetaGroup?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppsGetCollectionFieldsBetaGroup2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetCollectionFieldsBetaLicenseAgreement?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppsGetCollectionFieldsBetaLicenseAgreement2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetCollectionFieldsBuild?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppsGetCollectionFieldsBuild2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetCollectionFieldsBuildIcon?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppsGetCollectionFieldsBuildIcon2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetCollectionFieldsCiProduct?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppsGetCollectionFieldsCiProduct2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetCollectionFieldsEndUserLicenseAgreement?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppsGetCollectionFieldsEndUserLicenseAgreement2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetCollectionFieldsGameCenterDetail?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppsGetCollectionFieldsGameCenterDetail2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetCollectionFieldsGameCenterEnabledVersion?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppsGetCollectionFieldsGameCenterEnabledVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetCollectionFieldsInAppPurchase?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppsGetCollectionFieldsInAppPurchase2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetCollectionFieldsPreReleaseVersion?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppsGetCollectionFieldsPreReleaseVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetCollectionFieldsPromotedPurchase?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppsGetCollectionFieldsPromotedPurchase2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetCollectionFieldsReviewSubmission?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppsGetCollectionFieldsReviewSubmission2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetCollectionFieldsSubscriptionGracePeriod?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppsGetCollectionFieldsSubscriptionGracePeriod2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetCollectionFieldsSubscriptionGroup?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppsGetCollectionFieldsSubscriptionGroup2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetCollectionFilterAppStoreVersionsAppStoreStateItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppsGetCollectionFilterAppStoreVersionsAppStoreStateItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetCollectionFilterAppStoreVersionsAppVersionStateItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppsGetCollectionFilterAppStoreVersionsAppVersionStateItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetCollectionFilterAppStoreVersionsPlatformItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppsGetCollectionFilterAppStoreVersionsPlatformItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetCollectionFilterReviewSubmissionsPlatformItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppsGetCollectionFilterReviewSubmissionsPlatformItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetCollectionFilterReviewSubmissionsStateItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppsGetCollectionFilterReviewSubmissionsStateItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetCollectionIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppsGetCollectionIncludeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsGetCollectionSortItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableAppsGetCollectionSortItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsResponseIncludedItemDiscriminatorType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppsResponseIncludedItemDiscriminatorType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaAppLocalizationRelationshipsAppDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBetaAppLocalizationRelationshipsAppDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaAppLocalizationType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBetaAppLocalizationType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaAppReviewDetailRelationshipsAppDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBetaAppReviewDetailRelationshipsAppDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaAppReviewDetailType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBetaAppReviewDetailType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaGroupRelationshipsAppDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBetaGroupRelationshipsAppDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaGroupRelationshipsBetaRecruitmentCriteriaDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBetaGroupRelationshipsBetaRecruitmentCriteriaDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaGroupRelationshipsBetaTestersDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBetaGroupRelationshipsBetaTestersDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaGroupRelationshipsBuildsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBetaGroupRelationshipsBuildsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaGroupType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBetaGroupType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaLicenseAgreementRelationshipsAppDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBetaLicenseAgreementRelationshipsAppDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BetaLicenseAgreementType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBetaLicenseAgreementType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BrazilAgeRating?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBrazilAgeRating2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildAttributesProcessingState?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBuildAttributesProcessingState2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildAudienceType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBuildAudienceType2(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildIconType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBuildIconType2(options);
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
                if (type == typeof(global::AppStoreConnect.CiProductAttributesProductType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableCiProductAttributesProductType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductRelationshipsAppDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableCiProductRelationshipsAppDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductRelationshipsBundleIdDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableCiProductRelationshipsBundleIdDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductRelationshipsPrimaryRepositoriesDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableCiProductRelationshipsPrimaryRepositoriesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiProductType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableCiProductType2(options);
                }
                if (type == typeof(global::AppStoreConnect.EndUserLicenseAgreementRelationshipsAppDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableEndUserLicenseAgreementRelationshipsAppDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.EndUserLicenseAgreementRelationshipsTerritoriesDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableEndUserLicenseAgreementRelationshipsTerritoriesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.EndUserLicenseAgreementType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableEndUserLicenseAgreementType2(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsAchievementReleasesDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterDetailRelationshipsAchievementReleasesDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsActivityReleasesDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterDetailRelationshipsActivityReleasesDataItemType2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsAppDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterDetailRelationshipsAppDataType2(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsChallengeReleasesDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterDetailRelationshipsChallengeReleasesDataItemType2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsChallengesMinimumPlatformVersionsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterDetailRelationshipsChallengesMinimumPlatformVersionsDataItemType2(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultGroupLeaderboardDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterDetailRelationshipsDefaultGroupLeaderboardDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultGroupLeaderboardV2DataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterDetailRelationshipsDefaultGroupLeaderboardV2DataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultLeaderboardDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterDetailRelationshipsDefaultLeaderboardDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsDefaultLeaderboardV2DataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterDetailRelationshipsDefaultLeaderboardV2DataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAchievementsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterDetailRelationshipsGameCenterAchievementsDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAchievementsV2DataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterDetailRelationshipsGameCenterAchievementsV2DataItemType2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterActivitiesDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterDetailRelationshipsGameCenterActivitiesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAppVersionsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterDetailRelationshipsGameCenterAppVersionsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterChallengesDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterDetailRelationshipsGameCenterChallengesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterGroupDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterDetailRelationshipsGameCenterGroupDataType2(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardSetsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterDetailRelationshipsGameCenterLeaderboardSetsDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardSetsV2DataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterDetailRelationshipsGameCenterLeaderboardSetsV2DataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterDetailRelationshipsGameCenterLeaderboardsDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardsV2DataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterDetailRelationshipsGameCenterLeaderboardsV2DataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsLeaderboardReleasesDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterDetailRelationshipsLeaderboardReleasesDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationshipsLeaderboardSetReleasesDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterDetailRelationshipsLeaderboardSetReleasesDataItemType2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::AppStoreConnect.GameCenterDetailType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterDetailType2(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterEnabledVersionRelationshipsAppDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterEnabledVersionRelationshipsAppDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterEnabledVersionRelationshipsCompatibleVersionsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterEnabledVersionRelationshipsCompatibleVersionsDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterEnabledVersionType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterEnabledVersionType2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::AppStoreConnect.IconAssetType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableIconAssetType2(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseAttributesInAppPurchaseType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseAttributesInAppPurchaseType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseAttributesState?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseAttributesState2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseRelationshipsAppsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseRelationshipsAppsDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseType2_3(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::AppStoreConnect.IncludedItem48?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableIncludedItem482(options);
                }
                if (type == typeof(global::AppStoreConnect.Platform?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullablePlatform2(options);
                }
                if (type == typeof(global::AppStoreConnect.PrereleaseVersionRelationshipsAppDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullablePrereleaseVersionRelationshipsAppDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.PrereleaseVersionRelationshipsBuildsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullablePrereleaseVersionRelationshipsBuildsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.PrereleaseVersionType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullablePrereleaseVersionType2(options);
                }
                if (type == typeof(global::AppStoreConnect.PromotedPurchaseAttributesState?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullablePromotedPurchaseAttributesState2(options);
                }
                if (type == typeof(global::AppStoreConnect.PromotedPurchaseRelationshipsInAppPurchaseV2DataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullablePromotedPurchaseRelationshipsInAppPurchaseV2DataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.PromotedPurchaseRelationshipsSubscriptionDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullablePromotedPurchaseRelationshipsSubscriptionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.PromotedPurchaseType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullablePromotedPurchaseType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionAttributesState?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableReviewSubmissionAttributesState2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsAppDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableReviewSubmissionRelationshipsAppDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsAppStoreVersionForReviewDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableReviewSubmissionRelationshipsAppStoreVersionForReviewDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsItemsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableReviewSubmissionRelationshipsItemsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsLastUpdatedByActorDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableReviewSubmissionRelationshipsLastUpdatedByActorDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionRelationshipsSubmittedByActorDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableReviewSubmissionRelationshipsSubmittedByActorDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableReviewSubmissionType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionGracePeriodAttributesRenewalType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionGracePeriodAttributesRenewalType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionGracePeriodDuration?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionGracePeriodDuration2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionGracePeriodType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionGracePeriodType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptionGroupLocalizationsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionGroupRelationshipsSubscriptionGroupLocalizationsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptionsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionGroupRelationshipsSubscriptionsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionGroupRelationshipsVersionsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionGroupRelationshipsVersionsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionGroupType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableSubscriptionGroupType2(options);
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
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.App>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_C477E7ABF9210BAC(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppClipRelationshipsAppClipDefaultExperiencesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_F2852253E013C217(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppCustomProductPageRelationshipsAppCustomProductPageVersionsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_B1EA4F3920D398CE(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppEncryptionDeclarationRelationshipsBuildsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_3FC5F817D89A9A8F(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppEventAttributesArchivedTerritorySchedule>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_0FA4FCB8B324E823(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppEventAttributesTerritorySchedule>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_2214838658DE42A2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppEventRelationshipsLocalizationsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_3AE0303F8FAC920A(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppInfoRelationshipsAppInfoLocalizationsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_9A16AF18299559E8(options);
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
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsAppStoreVersionExperimentTreatmentsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_0D4861DBB6A8C82C(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionExperimentV2RelationshipsControlVersionsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_2C9F72C39229A91C(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionExperimentsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_4E5FCE8CAE68C8B7(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionExperimentsV2DataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_5437EA297EC2D6D4(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppStoreVersionRelationshipsAppStoreVersionLocalizationsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_B3829D7F9FF9D694(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGetCollectionFieldsAndroidToIosAppMappingDetail>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_4CE2D0FA3089EC62(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGetCollectionFieldsApp>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_91E586C418836D49(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGetCollectionFieldsAppClip>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_9701CA27F4639824(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGetCollectionFieldsAppCustomProductPage>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_F736EC4AC9A1EC7B(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGetCollectionFieldsAppEncryptionDeclaration>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_73029390C6ADD539(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGetCollectionFieldsAppEvent>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_4BAD95583FBB7D91(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGetCollectionFieldsAppInfo>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_F322C63D46281C86(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGetCollectionFieldsAppStoreVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_684EC0B202679682(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGetCollectionFieldsAppStoreVersionExperiment>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_7A2C8D963E1C0E84(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGetCollectionFieldsBetaAppLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_96719BA5928B25D9(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGetCollectionFieldsBetaAppReviewDetail>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_063A0E4825BD0727(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGetCollectionFieldsBetaGroup>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_13776613CF9ED42A(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGetCollectionFieldsBetaLicenseAgreement>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_F495A0E5FD6CA03C(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGetCollectionFieldsBuild>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_9F570186A8F49BAB(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGetCollectionFieldsBuildIcon>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_3A76984204D94CCD(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGetCollectionFieldsCiProduct>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_6D69B007A6E081F3(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGetCollectionFieldsEndUserLicenseAgreement>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_6013A6EE3190B634(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGetCollectionFieldsGameCenterDetail>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_0CB685AB371A028C(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGetCollectionFieldsGameCenterEnabledVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_DDF9C7F59C7D59F4(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGetCollectionFieldsInAppPurchase>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_A760BBA56BB5A28A(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGetCollectionFieldsPreReleaseVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_8D78C2904172AF15(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGetCollectionFieldsPromotedPurchase>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_74E69D3647F811FB(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGetCollectionFieldsReviewSubmission>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_EDAB671E599F47AE(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGetCollectionFieldsSubscriptionGracePeriod>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_E9113F38B9932819(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGetCollectionFieldsSubscriptionGroup>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_4B0CEB1E1CC371F6(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGetCollectionFilterAppStoreVersionsAppStoreStateItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_15D744DAE71243E7(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGetCollectionFilterAppStoreVersionsAppVersionStateItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_DB85AC3650BCC0EB(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGetCollectionFilterAppStoreVersionsPlatformItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_5F8FA6A976E1D2BE(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGetCollectionFilterReviewSubmissionsPlatformItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_2FCFCC711029FA1C(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGetCollectionFilterReviewSubmissionsStateItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_DC62F7977530DA23(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGetCollectionIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_E2EBB3C984BDB1F5(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsGetCollectionSortItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_107B71BD2DC618CB(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaGroupRelationshipsBetaTestersDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_11CA7D67924936CA(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaGroupRelationshipsBuildsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_F44D6C36505D82CB(options);
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
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiProductRelationshipsPrimaryRepositoriesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_C692331EFC765CEC(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.EndUserLicenseAgreementRelationshipsTerritoriesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_A3C3D233F80FABE6(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailRelationshipsAchievementReleasesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_A68DD0FDB4BB855E(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailRelationshipsActivityReleasesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_56E79E3A7008F283(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailRelationshipsChallengeReleasesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_02789E08C9C7AE0E(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailRelationshipsChallengesMinimumPlatformVersionsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_7533B716E4CAE945(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAchievementsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_DEB281766A499D3E(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAchievementsV2DataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_9BD00982F433E19D(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterActivitiesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_0ED75EEE89A0F196(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterAppVersionsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_C9804BFAA280D3CE(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterChallengesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_10B0B70F4DAD7EF0(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardSetsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_B4CF67BF33C4DE96(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardSetsV2DataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_15F8E865815D1C65(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_B18E00A699E5E3EF(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailRelationshipsGameCenterLeaderboardsV2DataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_E329EFF8D8EC01C2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailRelationshipsLeaderboardReleasesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_B74A98E50711534B(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterDetailRelationshipsLeaderboardSetReleasesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_BFBAD2D6AFF703A5(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterEnabledVersionRelationshipsCompatibleVersionsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_A86BEC57E8E7F473(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.InAppPurchaseRelationshipsAppsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_5CD679DF4C30E993(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem48>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_F9848F0824861543(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.PrereleaseVersionRelationshipsBuildsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_638862375304183F(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ReviewSubmissionRelationshipsItemsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_4AF56A399FDF288B(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptionGroupLocalizationsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_41CD8AB43455922A(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionGroupRelationshipsSubscriptionsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_BA9D382E13A1B866(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionGroupRelationshipsVersionsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_ABFF6378E4A56461(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<string>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_3F34DBFD50DE05D2(options);
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