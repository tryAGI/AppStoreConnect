
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaAppReviewDetailsGetInstanceFieldsApp
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
    public static class BetaAppReviewDetailsGetInstanceFieldsAppExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAppReviewDetailsGetInstanceFieldsApp value)
        {
            return value switch
            {
                BetaAppReviewDetailsGetInstanceFieldsApp.AccessibilityDeclarations => "accessibilityDeclarations",
                BetaAppReviewDetailsGetInstanceFieldsApp.AccessibilityUrl => "accessibilityUrl",
                BetaAppReviewDetailsGetInstanceFieldsApp.AlternativeDistributionKey => "alternativeDistributionKey",
                BetaAppReviewDetailsGetInstanceFieldsApp.AnalyticsReportRequests => "analyticsReportRequests",
                BetaAppReviewDetailsGetInstanceFieldsApp.AndroidToIosAppMappingDetails => "androidToIosAppMappingDetails",
                BetaAppReviewDetailsGetInstanceFieldsApp.AppAvailabilityV2 => "appAvailabilityV2",
                BetaAppReviewDetailsGetInstanceFieldsApp.AppClips => "appClips",
                BetaAppReviewDetailsGetInstanceFieldsApp.AppCustomProductPages => "appCustomProductPages",
                BetaAppReviewDetailsGetInstanceFieldsApp.AppEncryptionDeclarations => "appEncryptionDeclarations",
                BetaAppReviewDetailsGetInstanceFieldsApp.AppEvents => "appEvents",
                BetaAppReviewDetailsGetInstanceFieldsApp.AppInfos => "appInfos",
                BetaAppReviewDetailsGetInstanceFieldsApp.AppPricePoints => "appPricePoints",
                BetaAppReviewDetailsGetInstanceFieldsApp.AppPriceSchedule => "appPriceSchedule",
                BetaAppReviewDetailsGetInstanceFieldsApp.AppStoreIcon => "appStoreIcon",
                BetaAppReviewDetailsGetInstanceFieldsApp.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                BetaAppReviewDetailsGetInstanceFieldsApp.AppStoreVersions => "appStoreVersions",
                BetaAppReviewDetailsGetInstanceFieldsApp.AppTags => "appTags",
                BetaAppReviewDetailsGetInstanceFieldsApp.BackgroundAssets => "backgroundAssets",
                BetaAppReviewDetailsGetInstanceFieldsApp.BetaAppLocalizations => "betaAppLocalizations",
                BetaAppReviewDetailsGetInstanceFieldsApp.BetaAppReviewDetail => "betaAppReviewDetail",
                BetaAppReviewDetailsGetInstanceFieldsApp.BetaFeedbackCrashSubmissions => "betaFeedbackCrashSubmissions",
                BetaAppReviewDetailsGetInstanceFieldsApp.BetaFeedbackScreenshotSubmissions => "betaFeedbackScreenshotSubmissions",
                BetaAppReviewDetailsGetInstanceFieldsApp.BetaGroups => "betaGroups",
                BetaAppReviewDetailsGetInstanceFieldsApp.BetaLicenseAgreement => "betaLicenseAgreement",
                BetaAppReviewDetailsGetInstanceFieldsApp.BetaTesters => "betaTesters",
                BetaAppReviewDetailsGetInstanceFieldsApp.BuildUploads => "buildUploads",
                BetaAppReviewDetailsGetInstanceFieldsApp.Builds => "builds",
                BetaAppReviewDetailsGetInstanceFieldsApp.BundleId => "bundleId",
                BetaAppReviewDetailsGetInstanceFieldsApp.CiProduct => "ciProduct",
                BetaAppReviewDetailsGetInstanceFieldsApp.ContentRightsDeclaration => "contentRightsDeclaration",
                BetaAppReviewDetailsGetInstanceFieldsApp.CustomerReviewSummarizations => "customerReviewSummarizations",
                BetaAppReviewDetailsGetInstanceFieldsApp.CustomerReviews => "customerReviews",
                BetaAppReviewDetailsGetInstanceFieldsApp.EndUserLicenseAgreement => "endUserLicenseAgreement",
                BetaAppReviewDetailsGetInstanceFieldsApp.GameCenterDetail => "gameCenterDetail",
                BetaAppReviewDetailsGetInstanceFieldsApp.GameCenterEnabledVersions => "gameCenterEnabledVersions",
                BetaAppReviewDetailsGetInstanceFieldsApp.InAppPurchases => "inAppPurchases",
                BetaAppReviewDetailsGetInstanceFieldsApp.InAppPurchasesV2 => "inAppPurchasesV2",
                BetaAppReviewDetailsGetInstanceFieldsApp.IsOrEverWasMadeForKids => "isOrEverWasMadeForKids",
                BetaAppReviewDetailsGetInstanceFieldsApp.MarketplaceSearchDetail => "marketplaceSearchDetail",
                BetaAppReviewDetailsGetInstanceFieldsApp.Name => "name",
                BetaAppReviewDetailsGetInstanceFieldsApp.PerfPowerMetrics => "perfPowerMetrics",
                BetaAppReviewDetailsGetInstanceFieldsApp.PreReleaseVersions => "preReleaseVersions",
                BetaAppReviewDetailsGetInstanceFieldsApp.PrimaryLocale => "primaryLocale",
                BetaAppReviewDetailsGetInstanceFieldsApp.PromotedPurchases => "promotedPurchases",
                BetaAppReviewDetailsGetInstanceFieldsApp.ReviewSubmissions => "reviewSubmissions",
                BetaAppReviewDetailsGetInstanceFieldsApp.SearchKeywords => "searchKeywords",
                BetaAppReviewDetailsGetInstanceFieldsApp.Sku => "sku",
                BetaAppReviewDetailsGetInstanceFieldsApp.StreamlinedPurchasingEnabled => "streamlinedPurchasingEnabled",
                BetaAppReviewDetailsGetInstanceFieldsApp.SubscriptionGracePeriod => "subscriptionGracePeriod",
                BetaAppReviewDetailsGetInstanceFieldsApp.SubscriptionGroups => "subscriptionGroups",
                BetaAppReviewDetailsGetInstanceFieldsApp.SubscriptionStatusUrl => "subscriptionStatusUrl",
                BetaAppReviewDetailsGetInstanceFieldsApp.SubscriptionStatusUrlForSandbox => "subscriptionStatusUrlForSandbox",
                BetaAppReviewDetailsGetInstanceFieldsApp.SubscriptionStatusUrlVersion => "subscriptionStatusUrlVersion",
                BetaAppReviewDetailsGetInstanceFieldsApp.SubscriptionStatusUrlVersionForSandbox => "subscriptionStatusUrlVersionForSandbox",
                BetaAppReviewDetailsGetInstanceFieldsApp.Webhooks => "webhooks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAppReviewDetailsGetInstanceFieldsApp? ToEnum(string value)
        {
            return value switch
            {
                "accessibilityDeclarations" => BetaAppReviewDetailsGetInstanceFieldsApp.AccessibilityDeclarations,
                "accessibilityUrl" => BetaAppReviewDetailsGetInstanceFieldsApp.AccessibilityUrl,
                "alternativeDistributionKey" => BetaAppReviewDetailsGetInstanceFieldsApp.AlternativeDistributionKey,
                "analyticsReportRequests" => BetaAppReviewDetailsGetInstanceFieldsApp.AnalyticsReportRequests,
                "androidToIosAppMappingDetails" => BetaAppReviewDetailsGetInstanceFieldsApp.AndroidToIosAppMappingDetails,
                "appAvailabilityV2" => BetaAppReviewDetailsGetInstanceFieldsApp.AppAvailabilityV2,
                "appClips" => BetaAppReviewDetailsGetInstanceFieldsApp.AppClips,
                "appCustomProductPages" => BetaAppReviewDetailsGetInstanceFieldsApp.AppCustomProductPages,
                "appEncryptionDeclarations" => BetaAppReviewDetailsGetInstanceFieldsApp.AppEncryptionDeclarations,
                "appEvents" => BetaAppReviewDetailsGetInstanceFieldsApp.AppEvents,
                "appInfos" => BetaAppReviewDetailsGetInstanceFieldsApp.AppInfos,
                "appPricePoints" => BetaAppReviewDetailsGetInstanceFieldsApp.AppPricePoints,
                "appPriceSchedule" => BetaAppReviewDetailsGetInstanceFieldsApp.AppPriceSchedule,
                "appStoreIcon" => BetaAppReviewDetailsGetInstanceFieldsApp.AppStoreIcon,
                "appStoreVersionExperimentsV2" => BetaAppReviewDetailsGetInstanceFieldsApp.AppStoreVersionExperimentsV2,
                "appStoreVersions" => BetaAppReviewDetailsGetInstanceFieldsApp.AppStoreVersions,
                "appTags" => BetaAppReviewDetailsGetInstanceFieldsApp.AppTags,
                "backgroundAssets" => BetaAppReviewDetailsGetInstanceFieldsApp.BackgroundAssets,
                "betaAppLocalizations" => BetaAppReviewDetailsGetInstanceFieldsApp.BetaAppLocalizations,
                "betaAppReviewDetail" => BetaAppReviewDetailsGetInstanceFieldsApp.BetaAppReviewDetail,
                "betaFeedbackCrashSubmissions" => BetaAppReviewDetailsGetInstanceFieldsApp.BetaFeedbackCrashSubmissions,
                "betaFeedbackScreenshotSubmissions" => BetaAppReviewDetailsGetInstanceFieldsApp.BetaFeedbackScreenshotSubmissions,
                "betaGroups" => BetaAppReviewDetailsGetInstanceFieldsApp.BetaGroups,
                "betaLicenseAgreement" => BetaAppReviewDetailsGetInstanceFieldsApp.BetaLicenseAgreement,
                "betaTesters" => BetaAppReviewDetailsGetInstanceFieldsApp.BetaTesters,
                "buildUploads" => BetaAppReviewDetailsGetInstanceFieldsApp.BuildUploads,
                "builds" => BetaAppReviewDetailsGetInstanceFieldsApp.Builds,
                "bundleId" => BetaAppReviewDetailsGetInstanceFieldsApp.BundleId,
                "ciProduct" => BetaAppReviewDetailsGetInstanceFieldsApp.CiProduct,
                "contentRightsDeclaration" => BetaAppReviewDetailsGetInstanceFieldsApp.ContentRightsDeclaration,
                "customerReviewSummarizations" => BetaAppReviewDetailsGetInstanceFieldsApp.CustomerReviewSummarizations,
                "customerReviews" => BetaAppReviewDetailsGetInstanceFieldsApp.CustomerReviews,
                "endUserLicenseAgreement" => BetaAppReviewDetailsGetInstanceFieldsApp.EndUserLicenseAgreement,
                "gameCenterDetail" => BetaAppReviewDetailsGetInstanceFieldsApp.GameCenterDetail,
                "gameCenterEnabledVersions" => BetaAppReviewDetailsGetInstanceFieldsApp.GameCenterEnabledVersions,
                "inAppPurchases" => BetaAppReviewDetailsGetInstanceFieldsApp.InAppPurchases,
                "inAppPurchasesV2" => BetaAppReviewDetailsGetInstanceFieldsApp.InAppPurchasesV2,
                "isOrEverWasMadeForKids" => BetaAppReviewDetailsGetInstanceFieldsApp.IsOrEverWasMadeForKids,
                "marketplaceSearchDetail" => BetaAppReviewDetailsGetInstanceFieldsApp.MarketplaceSearchDetail,
                "name" => BetaAppReviewDetailsGetInstanceFieldsApp.Name,
                "perfPowerMetrics" => BetaAppReviewDetailsGetInstanceFieldsApp.PerfPowerMetrics,
                "preReleaseVersions" => BetaAppReviewDetailsGetInstanceFieldsApp.PreReleaseVersions,
                "primaryLocale" => BetaAppReviewDetailsGetInstanceFieldsApp.PrimaryLocale,
                "promotedPurchases" => BetaAppReviewDetailsGetInstanceFieldsApp.PromotedPurchases,
                "reviewSubmissions" => BetaAppReviewDetailsGetInstanceFieldsApp.ReviewSubmissions,
                "searchKeywords" => BetaAppReviewDetailsGetInstanceFieldsApp.SearchKeywords,
                "sku" => BetaAppReviewDetailsGetInstanceFieldsApp.Sku,
                "streamlinedPurchasingEnabled" => BetaAppReviewDetailsGetInstanceFieldsApp.StreamlinedPurchasingEnabled,
                "subscriptionGracePeriod" => BetaAppReviewDetailsGetInstanceFieldsApp.SubscriptionGracePeriod,
                "subscriptionGroups" => BetaAppReviewDetailsGetInstanceFieldsApp.SubscriptionGroups,
                "subscriptionStatusUrl" => BetaAppReviewDetailsGetInstanceFieldsApp.SubscriptionStatusUrl,
                "subscriptionStatusUrlForSandbox" => BetaAppReviewDetailsGetInstanceFieldsApp.SubscriptionStatusUrlForSandbox,
                "subscriptionStatusUrlVersion" => BetaAppReviewDetailsGetInstanceFieldsApp.SubscriptionStatusUrlVersion,
                "subscriptionStatusUrlVersionForSandbox" => BetaAppReviewDetailsGetInstanceFieldsApp.SubscriptionStatusUrlVersionForSandbox,
                "webhooks" => BetaAppReviewDetailsGetInstanceFieldsApp.Webhooks,
                _ => null,
            };
        }
    }
}