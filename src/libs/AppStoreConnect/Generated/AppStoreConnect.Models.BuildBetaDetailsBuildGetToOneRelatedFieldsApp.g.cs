
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildBetaDetailsBuildGetToOneRelatedFieldsApp
    {
        /// <summary>
        ///
        /// </summary>
        AccessibilityDeclarations,
        /// <summary>
        ///
        /// </summary>
        AccessibilityUrl,
        /// <summary>
        ///
        /// </summary>
        AlternativeDistributionKey,
        /// <summary>
        ///
        /// </summary>
        AnalyticsReportRequests,
        /// <summary>
        ///
        /// </summary>
        AndroidToIosAppMappingDetails,
        /// <summary>
        ///
        /// </summary>
        AppAvailabilityV2,
        /// <summary>
        ///
        /// </summary>
        AppClips,
        /// <summary>
        ///
        /// </summary>
        AppCustomProductPages,
        /// <summary>
        ///
        /// </summary>
        AppEncryptionDeclarations,
        /// <summary>
        ///
        /// </summary>
        AppEvents,
        /// <summary>
        ///
        /// </summary>
        AppInfos,
        /// <summary>
        ///
        /// </summary>
        AppPricePoints,
        /// <summary>
        ///
        /// </summary>
        AppPriceSchedule,
        /// <summary>
        ///
        /// </summary>
        AppStoreIcon,
        /// <summary>
        ///
        /// </summary>
        AppStoreVersionExperimentsV2,
        /// <summary>
        ///
        /// </summary>
        AppStoreVersions,
        /// <summary>
        ///
        /// </summary>
        AppTags,
        /// <summary>
        ///
        /// </summary>
        BackgroundAssets,
        /// <summary>
        ///
        /// </summary>
        BetaAppLocalizations,
        /// <summary>
        ///
        /// </summary>
        BetaAppReviewDetail,
        /// <summary>
        ///
        /// </summary>
        BetaFeedbackCrashSubmissions,
        /// <summary>
        ///
        /// </summary>
        BetaFeedbackScreenshotSubmissions,
        /// <summary>
        ///
        /// </summary>
        BetaGroups,
        /// <summary>
        ///
        /// </summary>
        BetaLicenseAgreement,
        /// <summary>
        ///
        /// </summary>
        BetaTesters,
        /// <summary>
        ///
        /// </summary>
        BuildUploads,
        /// <summary>
        ///
        /// </summary>
        Builds,
        /// <summary>
        ///
        /// </summary>
        BundleId,
        /// <summary>
        ///
        /// </summary>
        CiProduct,
        /// <summary>
        ///
        /// </summary>
        ContentRightsDeclaration,
        /// <summary>
        ///
        /// </summary>
        CustomerReviewSummarizations,
        /// <summary>
        ///
        /// </summary>
        CustomerReviews,
        /// <summary>
        ///
        /// </summary>
        EndUserLicenseAgreement,
        /// <summary>
        ///
        /// </summary>
        GameCenterDetail,
        /// <summary>
        ///
        /// </summary>
        GameCenterEnabledVersions,
        /// <summary>
        ///
        /// </summary>
        InAppPurchases,
        /// <summary>
        ///
        /// </summary>
        InAppPurchasesV2,
        /// <summary>
        ///
        /// </summary>
        IsOrEverWasMadeForKids,
        /// <summary>
        ///
        /// </summary>
        MarketplaceSearchDetail,
        /// <summary>
        ///
        /// </summary>
        Name,
        /// <summary>
        ///
        /// </summary>
        PerfPowerMetrics,
        /// <summary>
        ///
        /// </summary>
        PreReleaseVersions,
        /// <summary>
        ///
        /// </summary>
        PrimaryLocale,
        /// <summary>
        ///
        /// </summary>
        PromotedPurchases,
        /// <summary>
        ///
        /// </summary>
        ReviewSubmissions,
        /// <summary>
        ///
        /// </summary>
        SearchKeywords,
        /// <summary>
        ///
        /// </summary>
        Sku,
        /// <summary>
        ///
        /// </summary>
        StreamlinedPurchasingEnabled,
        /// <summary>
        ///
        /// </summary>
        SubscriptionGracePeriod,
        /// <summary>
        ///
        /// </summary>
        SubscriptionGroups,
        /// <summary>
        ///
        /// </summary>
        SubscriptionStatusUrl,
        /// <summary>
        ///
        /// </summary>
        SubscriptionStatusUrlForSandbox,
        /// <summary>
        ///
        /// </summary>
        SubscriptionStatusUrlVersion,
        /// <summary>
        ///
        /// </summary>
        SubscriptionStatusUrlVersionForSandbox,
        /// <summary>
        ///
        /// </summary>
        Webhooks,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildBetaDetailsBuildGetToOneRelatedFieldsAppExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildBetaDetailsBuildGetToOneRelatedFieldsApp value)
        {
            return value switch
            {
                BuildBetaDetailsBuildGetToOneRelatedFieldsApp.AccessibilityDeclarations => "accessibilityDeclarations",
                BuildBetaDetailsBuildGetToOneRelatedFieldsApp.AccessibilityUrl => "accessibilityUrl",
                BuildBetaDetailsBuildGetToOneRelatedFieldsApp.AlternativeDistributionKey => "alternativeDistributionKey",
                BuildBetaDetailsBuildGetToOneRelatedFieldsApp.AnalyticsReportRequests => "analyticsReportRequests",
                BuildBetaDetailsBuildGetToOneRelatedFieldsApp.AndroidToIosAppMappingDetails => "androidToIosAppMappingDetails",
                BuildBetaDetailsBuildGetToOneRelatedFieldsApp.AppAvailabilityV2 => "appAvailabilityV2",
                BuildBetaDetailsBuildGetToOneRelatedFieldsApp.AppClips => "appClips",
                BuildBetaDetailsBuildGetToOneRelatedFieldsApp.AppCustomProductPages => "appCustomProductPages",
                BuildBetaDetailsBuildGetToOneRelatedFieldsApp.AppEncryptionDeclarations => "appEncryptionDeclarations",
                BuildBetaDetailsBuildGetToOneRelatedFieldsApp.AppEvents => "appEvents",
                BuildBetaDetailsBuildGetToOneRelatedFieldsApp.AppInfos => "appInfos",
                BuildBetaDetailsBuildGetToOneRelatedFieldsApp.AppPricePoints => "appPricePoints",
                BuildBetaDetailsBuildGetToOneRelatedFieldsApp.AppPriceSchedule => "appPriceSchedule",
                BuildBetaDetailsBuildGetToOneRelatedFieldsApp.AppStoreIcon => "appStoreIcon",
                BuildBetaDetailsBuildGetToOneRelatedFieldsApp.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                BuildBetaDetailsBuildGetToOneRelatedFieldsApp.AppStoreVersions => "appStoreVersions",
                BuildBetaDetailsBuildGetToOneRelatedFieldsApp.AppTags => "appTags",
                BuildBetaDetailsBuildGetToOneRelatedFieldsApp.BackgroundAssets => "backgroundAssets",
                BuildBetaDetailsBuildGetToOneRelatedFieldsApp.BetaAppLocalizations => "betaAppLocalizations",
                BuildBetaDetailsBuildGetToOneRelatedFieldsApp.BetaAppReviewDetail => "betaAppReviewDetail",
                BuildBetaDetailsBuildGetToOneRelatedFieldsApp.BetaFeedbackCrashSubmissions => "betaFeedbackCrashSubmissions",
                BuildBetaDetailsBuildGetToOneRelatedFieldsApp.BetaFeedbackScreenshotSubmissions => "betaFeedbackScreenshotSubmissions",
                BuildBetaDetailsBuildGetToOneRelatedFieldsApp.BetaGroups => "betaGroups",
                BuildBetaDetailsBuildGetToOneRelatedFieldsApp.BetaLicenseAgreement => "betaLicenseAgreement",
                BuildBetaDetailsBuildGetToOneRelatedFieldsApp.BetaTesters => "betaTesters",
                BuildBetaDetailsBuildGetToOneRelatedFieldsApp.BuildUploads => "buildUploads",
                BuildBetaDetailsBuildGetToOneRelatedFieldsApp.Builds => "builds",
                BuildBetaDetailsBuildGetToOneRelatedFieldsApp.BundleId => "bundleId",
                BuildBetaDetailsBuildGetToOneRelatedFieldsApp.CiProduct => "ciProduct",
                BuildBetaDetailsBuildGetToOneRelatedFieldsApp.ContentRightsDeclaration => "contentRightsDeclaration",
                BuildBetaDetailsBuildGetToOneRelatedFieldsApp.CustomerReviewSummarizations => "customerReviewSummarizations",
                BuildBetaDetailsBuildGetToOneRelatedFieldsApp.CustomerReviews => "customerReviews",
                BuildBetaDetailsBuildGetToOneRelatedFieldsApp.EndUserLicenseAgreement => "endUserLicenseAgreement",
                BuildBetaDetailsBuildGetToOneRelatedFieldsApp.GameCenterDetail => "gameCenterDetail",
                BuildBetaDetailsBuildGetToOneRelatedFieldsApp.GameCenterEnabledVersions => "gameCenterEnabledVersions",
                BuildBetaDetailsBuildGetToOneRelatedFieldsApp.InAppPurchases => "inAppPurchases",
                BuildBetaDetailsBuildGetToOneRelatedFieldsApp.InAppPurchasesV2 => "inAppPurchasesV2",
                BuildBetaDetailsBuildGetToOneRelatedFieldsApp.IsOrEverWasMadeForKids => "isOrEverWasMadeForKids",
                BuildBetaDetailsBuildGetToOneRelatedFieldsApp.MarketplaceSearchDetail => "marketplaceSearchDetail",
                BuildBetaDetailsBuildGetToOneRelatedFieldsApp.Name => "name",
                BuildBetaDetailsBuildGetToOneRelatedFieldsApp.PerfPowerMetrics => "perfPowerMetrics",
                BuildBetaDetailsBuildGetToOneRelatedFieldsApp.PreReleaseVersions => "preReleaseVersions",
                BuildBetaDetailsBuildGetToOneRelatedFieldsApp.PrimaryLocale => "primaryLocale",
                BuildBetaDetailsBuildGetToOneRelatedFieldsApp.PromotedPurchases => "promotedPurchases",
                BuildBetaDetailsBuildGetToOneRelatedFieldsApp.ReviewSubmissions => "reviewSubmissions",
                BuildBetaDetailsBuildGetToOneRelatedFieldsApp.SearchKeywords => "searchKeywords",
                BuildBetaDetailsBuildGetToOneRelatedFieldsApp.Sku => "sku",
                BuildBetaDetailsBuildGetToOneRelatedFieldsApp.StreamlinedPurchasingEnabled => "streamlinedPurchasingEnabled",
                BuildBetaDetailsBuildGetToOneRelatedFieldsApp.SubscriptionGracePeriod => "subscriptionGracePeriod",
                BuildBetaDetailsBuildGetToOneRelatedFieldsApp.SubscriptionGroups => "subscriptionGroups",
                BuildBetaDetailsBuildGetToOneRelatedFieldsApp.SubscriptionStatusUrl => "subscriptionStatusUrl",
                BuildBetaDetailsBuildGetToOneRelatedFieldsApp.SubscriptionStatusUrlForSandbox => "subscriptionStatusUrlForSandbox",
                BuildBetaDetailsBuildGetToOneRelatedFieldsApp.SubscriptionStatusUrlVersion => "subscriptionStatusUrlVersion",
                BuildBetaDetailsBuildGetToOneRelatedFieldsApp.SubscriptionStatusUrlVersionForSandbox => "subscriptionStatusUrlVersionForSandbox",
                BuildBetaDetailsBuildGetToOneRelatedFieldsApp.Webhooks => "webhooks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildBetaDetailsBuildGetToOneRelatedFieldsApp? ToEnum(string value)
        {
            return value switch
            {
                "accessibilityDeclarations" => BuildBetaDetailsBuildGetToOneRelatedFieldsApp.AccessibilityDeclarations,
                "accessibilityUrl" => BuildBetaDetailsBuildGetToOneRelatedFieldsApp.AccessibilityUrl,
                "alternativeDistributionKey" => BuildBetaDetailsBuildGetToOneRelatedFieldsApp.AlternativeDistributionKey,
                "analyticsReportRequests" => BuildBetaDetailsBuildGetToOneRelatedFieldsApp.AnalyticsReportRequests,
                "androidToIosAppMappingDetails" => BuildBetaDetailsBuildGetToOneRelatedFieldsApp.AndroidToIosAppMappingDetails,
                "appAvailabilityV2" => BuildBetaDetailsBuildGetToOneRelatedFieldsApp.AppAvailabilityV2,
                "appClips" => BuildBetaDetailsBuildGetToOneRelatedFieldsApp.AppClips,
                "appCustomProductPages" => BuildBetaDetailsBuildGetToOneRelatedFieldsApp.AppCustomProductPages,
                "appEncryptionDeclarations" => BuildBetaDetailsBuildGetToOneRelatedFieldsApp.AppEncryptionDeclarations,
                "appEvents" => BuildBetaDetailsBuildGetToOneRelatedFieldsApp.AppEvents,
                "appInfos" => BuildBetaDetailsBuildGetToOneRelatedFieldsApp.AppInfos,
                "appPricePoints" => BuildBetaDetailsBuildGetToOneRelatedFieldsApp.AppPricePoints,
                "appPriceSchedule" => BuildBetaDetailsBuildGetToOneRelatedFieldsApp.AppPriceSchedule,
                "appStoreIcon" => BuildBetaDetailsBuildGetToOneRelatedFieldsApp.AppStoreIcon,
                "appStoreVersionExperimentsV2" => BuildBetaDetailsBuildGetToOneRelatedFieldsApp.AppStoreVersionExperimentsV2,
                "appStoreVersions" => BuildBetaDetailsBuildGetToOneRelatedFieldsApp.AppStoreVersions,
                "appTags" => BuildBetaDetailsBuildGetToOneRelatedFieldsApp.AppTags,
                "backgroundAssets" => BuildBetaDetailsBuildGetToOneRelatedFieldsApp.BackgroundAssets,
                "betaAppLocalizations" => BuildBetaDetailsBuildGetToOneRelatedFieldsApp.BetaAppLocalizations,
                "betaAppReviewDetail" => BuildBetaDetailsBuildGetToOneRelatedFieldsApp.BetaAppReviewDetail,
                "betaFeedbackCrashSubmissions" => BuildBetaDetailsBuildGetToOneRelatedFieldsApp.BetaFeedbackCrashSubmissions,
                "betaFeedbackScreenshotSubmissions" => BuildBetaDetailsBuildGetToOneRelatedFieldsApp.BetaFeedbackScreenshotSubmissions,
                "betaGroups" => BuildBetaDetailsBuildGetToOneRelatedFieldsApp.BetaGroups,
                "betaLicenseAgreement" => BuildBetaDetailsBuildGetToOneRelatedFieldsApp.BetaLicenseAgreement,
                "betaTesters" => BuildBetaDetailsBuildGetToOneRelatedFieldsApp.BetaTesters,
                "buildUploads" => BuildBetaDetailsBuildGetToOneRelatedFieldsApp.BuildUploads,
                "builds" => BuildBetaDetailsBuildGetToOneRelatedFieldsApp.Builds,
                "bundleId" => BuildBetaDetailsBuildGetToOneRelatedFieldsApp.BundleId,
                "ciProduct" => BuildBetaDetailsBuildGetToOneRelatedFieldsApp.CiProduct,
                "contentRightsDeclaration" => BuildBetaDetailsBuildGetToOneRelatedFieldsApp.ContentRightsDeclaration,
                "customerReviewSummarizations" => BuildBetaDetailsBuildGetToOneRelatedFieldsApp.CustomerReviewSummarizations,
                "customerReviews" => BuildBetaDetailsBuildGetToOneRelatedFieldsApp.CustomerReviews,
                "endUserLicenseAgreement" => BuildBetaDetailsBuildGetToOneRelatedFieldsApp.EndUserLicenseAgreement,
                "gameCenterDetail" => BuildBetaDetailsBuildGetToOneRelatedFieldsApp.GameCenterDetail,
                "gameCenterEnabledVersions" => BuildBetaDetailsBuildGetToOneRelatedFieldsApp.GameCenterEnabledVersions,
                "inAppPurchases" => BuildBetaDetailsBuildGetToOneRelatedFieldsApp.InAppPurchases,
                "inAppPurchasesV2" => BuildBetaDetailsBuildGetToOneRelatedFieldsApp.InAppPurchasesV2,
                "isOrEverWasMadeForKids" => BuildBetaDetailsBuildGetToOneRelatedFieldsApp.IsOrEverWasMadeForKids,
                "marketplaceSearchDetail" => BuildBetaDetailsBuildGetToOneRelatedFieldsApp.MarketplaceSearchDetail,
                "name" => BuildBetaDetailsBuildGetToOneRelatedFieldsApp.Name,
                "perfPowerMetrics" => BuildBetaDetailsBuildGetToOneRelatedFieldsApp.PerfPowerMetrics,
                "preReleaseVersions" => BuildBetaDetailsBuildGetToOneRelatedFieldsApp.PreReleaseVersions,
                "primaryLocale" => BuildBetaDetailsBuildGetToOneRelatedFieldsApp.PrimaryLocale,
                "promotedPurchases" => BuildBetaDetailsBuildGetToOneRelatedFieldsApp.PromotedPurchases,
                "reviewSubmissions" => BuildBetaDetailsBuildGetToOneRelatedFieldsApp.ReviewSubmissions,
                "searchKeywords" => BuildBetaDetailsBuildGetToOneRelatedFieldsApp.SearchKeywords,
                "sku" => BuildBetaDetailsBuildGetToOneRelatedFieldsApp.Sku,
                "streamlinedPurchasingEnabled" => BuildBetaDetailsBuildGetToOneRelatedFieldsApp.StreamlinedPurchasingEnabled,
                "subscriptionGracePeriod" => BuildBetaDetailsBuildGetToOneRelatedFieldsApp.SubscriptionGracePeriod,
                "subscriptionGroups" => BuildBetaDetailsBuildGetToOneRelatedFieldsApp.SubscriptionGroups,
                "subscriptionStatusUrl" => BuildBetaDetailsBuildGetToOneRelatedFieldsApp.SubscriptionStatusUrl,
                "subscriptionStatusUrlForSandbox" => BuildBetaDetailsBuildGetToOneRelatedFieldsApp.SubscriptionStatusUrlForSandbox,
                "subscriptionStatusUrlVersion" => BuildBetaDetailsBuildGetToOneRelatedFieldsApp.SubscriptionStatusUrlVersion,
                "subscriptionStatusUrlVersionForSandbox" => BuildBetaDetailsBuildGetToOneRelatedFieldsApp.SubscriptionStatusUrlVersionForSandbox,
                "webhooks" => BuildBetaDetailsBuildGetToOneRelatedFieldsApp.Webhooks,
                _ => null,
            };
        }
    }
}