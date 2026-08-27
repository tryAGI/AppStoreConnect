
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsGetInstanceFieldsApp
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
    public static class AppsGetInstanceFieldsAppExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGetInstanceFieldsApp value)
        {
            return value switch
            {
                AppsGetInstanceFieldsApp.AccessibilityDeclarations => "accessibilityDeclarations",
                AppsGetInstanceFieldsApp.AccessibilityUrl => "accessibilityUrl",
                AppsGetInstanceFieldsApp.AlternativeDistributionKey => "alternativeDistributionKey",
                AppsGetInstanceFieldsApp.AnalyticsReportRequests => "analyticsReportRequests",
                AppsGetInstanceFieldsApp.AndroidToIosAppMappingDetails => "androidToIosAppMappingDetails",
                AppsGetInstanceFieldsApp.AppAvailabilityV2 => "appAvailabilityV2",
                AppsGetInstanceFieldsApp.AppClips => "appClips",
                AppsGetInstanceFieldsApp.AppCustomProductPages => "appCustomProductPages",
                AppsGetInstanceFieldsApp.AppEncryptionDeclarations => "appEncryptionDeclarations",
                AppsGetInstanceFieldsApp.AppEvents => "appEvents",
                AppsGetInstanceFieldsApp.AppInfos => "appInfos",
                AppsGetInstanceFieldsApp.AppPricePoints => "appPricePoints",
                AppsGetInstanceFieldsApp.AppPriceSchedule => "appPriceSchedule",
                AppsGetInstanceFieldsApp.AppStoreIcon => "appStoreIcon",
                AppsGetInstanceFieldsApp.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                AppsGetInstanceFieldsApp.AppStoreVersions => "appStoreVersions",
                AppsGetInstanceFieldsApp.AppTags => "appTags",
                AppsGetInstanceFieldsApp.BackgroundAssets => "backgroundAssets",
                AppsGetInstanceFieldsApp.BetaAppLocalizations => "betaAppLocalizations",
                AppsGetInstanceFieldsApp.BetaAppReviewDetail => "betaAppReviewDetail",
                AppsGetInstanceFieldsApp.BetaFeedbackCrashSubmissions => "betaFeedbackCrashSubmissions",
                AppsGetInstanceFieldsApp.BetaFeedbackScreenshotSubmissions => "betaFeedbackScreenshotSubmissions",
                AppsGetInstanceFieldsApp.BetaGroups => "betaGroups",
                AppsGetInstanceFieldsApp.BetaLicenseAgreement => "betaLicenseAgreement",
                AppsGetInstanceFieldsApp.BetaTesters => "betaTesters",
                AppsGetInstanceFieldsApp.BuildUploads => "buildUploads",
                AppsGetInstanceFieldsApp.Builds => "builds",
                AppsGetInstanceFieldsApp.BundleId => "bundleId",
                AppsGetInstanceFieldsApp.CiProduct => "ciProduct",
                AppsGetInstanceFieldsApp.ContentRightsDeclaration => "contentRightsDeclaration",
                AppsGetInstanceFieldsApp.CustomerReviewSummarizations => "customerReviewSummarizations",
                AppsGetInstanceFieldsApp.CustomerReviews => "customerReviews",
                AppsGetInstanceFieldsApp.EndUserLicenseAgreement => "endUserLicenseAgreement",
                AppsGetInstanceFieldsApp.GameCenterDetail => "gameCenterDetail",
                AppsGetInstanceFieldsApp.GameCenterEnabledVersions => "gameCenterEnabledVersions",
                AppsGetInstanceFieldsApp.InAppPurchases => "inAppPurchases",
                AppsGetInstanceFieldsApp.InAppPurchasesV2 => "inAppPurchasesV2",
                AppsGetInstanceFieldsApp.IsOrEverWasMadeForKids => "isOrEverWasMadeForKids",
                AppsGetInstanceFieldsApp.MarketplaceSearchDetail => "marketplaceSearchDetail",
                AppsGetInstanceFieldsApp.Name => "name",
                AppsGetInstanceFieldsApp.PerfPowerMetrics => "perfPowerMetrics",
                AppsGetInstanceFieldsApp.PreReleaseVersions => "preReleaseVersions",
                AppsGetInstanceFieldsApp.PrimaryLocale => "primaryLocale",
                AppsGetInstanceFieldsApp.PromotedPurchases => "promotedPurchases",
                AppsGetInstanceFieldsApp.ReviewSubmissions => "reviewSubmissions",
                AppsGetInstanceFieldsApp.SearchKeywords => "searchKeywords",
                AppsGetInstanceFieldsApp.Sku => "sku",
                AppsGetInstanceFieldsApp.StreamlinedPurchasingEnabled => "streamlinedPurchasingEnabled",
                AppsGetInstanceFieldsApp.SubscriptionGracePeriod => "subscriptionGracePeriod",
                AppsGetInstanceFieldsApp.SubscriptionGroups => "subscriptionGroups",
                AppsGetInstanceFieldsApp.SubscriptionStatusUrl => "subscriptionStatusUrl",
                AppsGetInstanceFieldsApp.SubscriptionStatusUrlForSandbox => "subscriptionStatusUrlForSandbox",
                AppsGetInstanceFieldsApp.SubscriptionStatusUrlVersion => "subscriptionStatusUrlVersion",
                AppsGetInstanceFieldsApp.SubscriptionStatusUrlVersionForSandbox => "subscriptionStatusUrlVersionForSandbox",
                AppsGetInstanceFieldsApp.Webhooks => "webhooks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGetInstanceFieldsApp? ToEnum(string value)
        {
            return value switch
            {
                "accessibilityDeclarations" => AppsGetInstanceFieldsApp.AccessibilityDeclarations,
                "accessibilityUrl" => AppsGetInstanceFieldsApp.AccessibilityUrl,
                "alternativeDistributionKey" => AppsGetInstanceFieldsApp.AlternativeDistributionKey,
                "analyticsReportRequests" => AppsGetInstanceFieldsApp.AnalyticsReportRequests,
                "androidToIosAppMappingDetails" => AppsGetInstanceFieldsApp.AndroidToIosAppMappingDetails,
                "appAvailabilityV2" => AppsGetInstanceFieldsApp.AppAvailabilityV2,
                "appClips" => AppsGetInstanceFieldsApp.AppClips,
                "appCustomProductPages" => AppsGetInstanceFieldsApp.AppCustomProductPages,
                "appEncryptionDeclarations" => AppsGetInstanceFieldsApp.AppEncryptionDeclarations,
                "appEvents" => AppsGetInstanceFieldsApp.AppEvents,
                "appInfos" => AppsGetInstanceFieldsApp.AppInfos,
                "appPricePoints" => AppsGetInstanceFieldsApp.AppPricePoints,
                "appPriceSchedule" => AppsGetInstanceFieldsApp.AppPriceSchedule,
                "appStoreIcon" => AppsGetInstanceFieldsApp.AppStoreIcon,
                "appStoreVersionExperimentsV2" => AppsGetInstanceFieldsApp.AppStoreVersionExperimentsV2,
                "appStoreVersions" => AppsGetInstanceFieldsApp.AppStoreVersions,
                "appTags" => AppsGetInstanceFieldsApp.AppTags,
                "backgroundAssets" => AppsGetInstanceFieldsApp.BackgroundAssets,
                "betaAppLocalizations" => AppsGetInstanceFieldsApp.BetaAppLocalizations,
                "betaAppReviewDetail" => AppsGetInstanceFieldsApp.BetaAppReviewDetail,
                "betaFeedbackCrashSubmissions" => AppsGetInstanceFieldsApp.BetaFeedbackCrashSubmissions,
                "betaFeedbackScreenshotSubmissions" => AppsGetInstanceFieldsApp.BetaFeedbackScreenshotSubmissions,
                "betaGroups" => AppsGetInstanceFieldsApp.BetaGroups,
                "betaLicenseAgreement" => AppsGetInstanceFieldsApp.BetaLicenseAgreement,
                "betaTesters" => AppsGetInstanceFieldsApp.BetaTesters,
                "buildUploads" => AppsGetInstanceFieldsApp.BuildUploads,
                "builds" => AppsGetInstanceFieldsApp.Builds,
                "bundleId" => AppsGetInstanceFieldsApp.BundleId,
                "ciProduct" => AppsGetInstanceFieldsApp.CiProduct,
                "contentRightsDeclaration" => AppsGetInstanceFieldsApp.ContentRightsDeclaration,
                "customerReviewSummarizations" => AppsGetInstanceFieldsApp.CustomerReviewSummarizations,
                "customerReviews" => AppsGetInstanceFieldsApp.CustomerReviews,
                "endUserLicenseAgreement" => AppsGetInstanceFieldsApp.EndUserLicenseAgreement,
                "gameCenterDetail" => AppsGetInstanceFieldsApp.GameCenterDetail,
                "gameCenterEnabledVersions" => AppsGetInstanceFieldsApp.GameCenterEnabledVersions,
                "inAppPurchases" => AppsGetInstanceFieldsApp.InAppPurchases,
                "inAppPurchasesV2" => AppsGetInstanceFieldsApp.InAppPurchasesV2,
                "isOrEverWasMadeForKids" => AppsGetInstanceFieldsApp.IsOrEverWasMadeForKids,
                "marketplaceSearchDetail" => AppsGetInstanceFieldsApp.MarketplaceSearchDetail,
                "name" => AppsGetInstanceFieldsApp.Name,
                "perfPowerMetrics" => AppsGetInstanceFieldsApp.PerfPowerMetrics,
                "preReleaseVersions" => AppsGetInstanceFieldsApp.PreReleaseVersions,
                "primaryLocale" => AppsGetInstanceFieldsApp.PrimaryLocale,
                "promotedPurchases" => AppsGetInstanceFieldsApp.PromotedPurchases,
                "reviewSubmissions" => AppsGetInstanceFieldsApp.ReviewSubmissions,
                "searchKeywords" => AppsGetInstanceFieldsApp.SearchKeywords,
                "sku" => AppsGetInstanceFieldsApp.Sku,
                "streamlinedPurchasingEnabled" => AppsGetInstanceFieldsApp.StreamlinedPurchasingEnabled,
                "subscriptionGracePeriod" => AppsGetInstanceFieldsApp.SubscriptionGracePeriod,
                "subscriptionGroups" => AppsGetInstanceFieldsApp.SubscriptionGroups,
                "subscriptionStatusUrl" => AppsGetInstanceFieldsApp.SubscriptionStatusUrl,
                "subscriptionStatusUrlForSandbox" => AppsGetInstanceFieldsApp.SubscriptionStatusUrlForSandbox,
                "subscriptionStatusUrlVersion" => AppsGetInstanceFieldsApp.SubscriptionStatusUrlVersion,
                "subscriptionStatusUrlVersionForSandbox" => AppsGetInstanceFieldsApp.SubscriptionStatusUrlVersionForSandbox,
                "webhooks" => AppsGetInstanceFieldsApp.Webhooks,
                _ => null,
            };
        }
    }
}