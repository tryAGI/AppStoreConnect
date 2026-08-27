
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterDetailsGetInstanceFieldsApp
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
    public static class GameCenterDetailsGetInstanceFieldsAppExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsGetInstanceFieldsApp value)
        {
            return value switch
            {
                GameCenterDetailsGetInstanceFieldsApp.AccessibilityDeclarations => "accessibilityDeclarations",
                GameCenterDetailsGetInstanceFieldsApp.AccessibilityUrl => "accessibilityUrl",
                GameCenterDetailsGetInstanceFieldsApp.AlternativeDistributionKey => "alternativeDistributionKey",
                GameCenterDetailsGetInstanceFieldsApp.AnalyticsReportRequests => "analyticsReportRequests",
                GameCenterDetailsGetInstanceFieldsApp.AndroidToIosAppMappingDetails => "androidToIosAppMappingDetails",
                GameCenterDetailsGetInstanceFieldsApp.AppAvailabilityV2 => "appAvailabilityV2",
                GameCenterDetailsGetInstanceFieldsApp.AppClips => "appClips",
                GameCenterDetailsGetInstanceFieldsApp.AppCustomProductPages => "appCustomProductPages",
                GameCenterDetailsGetInstanceFieldsApp.AppEncryptionDeclarations => "appEncryptionDeclarations",
                GameCenterDetailsGetInstanceFieldsApp.AppEvents => "appEvents",
                GameCenterDetailsGetInstanceFieldsApp.AppInfos => "appInfos",
                GameCenterDetailsGetInstanceFieldsApp.AppPricePoints => "appPricePoints",
                GameCenterDetailsGetInstanceFieldsApp.AppPriceSchedule => "appPriceSchedule",
                GameCenterDetailsGetInstanceFieldsApp.AppStoreIcon => "appStoreIcon",
                GameCenterDetailsGetInstanceFieldsApp.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                GameCenterDetailsGetInstanceFieldsApp.AppStoreVersions => "appStoreVersions",
                GameCenterDetailsGetInstanceFieldsApp.AppTags => "appTags",
                GameCenterDetailsGetInstanceFieldsApp.BackgroundAssets => "backgroundAssets",
                GameCenterDetailsGetInstanceFieldsApp.BetaAppLocalizations => "betaAppLocalizations",
                GameCenterDetailsGetInstanceFieldsApp.BetaAppReviewDetail => "betaAppReviewDetail",
                GameCenterDetailsGetInstanceFieldsApp.BetaFeedbackCrashSubmissions => "betaFeedbackCrashSubmissions",
                GameCenterDetailsGetInstanceFieldsApp.BetaFeedbackScreenshotSubmissions => "betaFeedbackScreenshotSubmissions",
                GameCenterDetailsGetInstanceFieldsApp.BetaGroups => "betaGroups",
                GameCenterDetailsGetInstanceFieldsApp.BetaLicenseAgreement => "betaLicenseAgreement",
                GameCenterDetailsGetInstanceFieldsApp.BetaTesters => "betaTesters",
                GameCenterDetailsGetInstanceFieldsApp.BuildUploads => "buildUploads",
                GameCenterDetailsGetInstanceFieldsApp.Builds => "builds",
                GameCenterDetailsGetInstanceFieldsApp.BundleId => "bundleId",
                GameCenterDetailsGetInstanceFieldsApp.CiProduct => "ciProduct",
                GameCenterDetailsGetInstanceFieldsApp.ContentRightsDeclaration => "contentRightsDeclaration",
                GameCenterDetailsGetInstanceFieldsApp.CustomerReviewSummarizations => "customerReviewSummarizations",
                GameCenterDetailsGetInstanceFieldsApp.CustomerReviews => "customerReviews",
                GameCenterDetailsGetInstanceFieldsApp.EndUserLicenseAgreement => "endUserLicenseAgreement",
                GameCenterDetailsGetInstanceFieldsApp.GameCenterDetail => "gameCenterDetail",
                GameCenterDetailsGetInstanceFieldsApp.GameCenterEnabledVersions => "gameCenterEnabledVersions",
                GameCenterDetailsGetInstanceFieldsApp.InAppPurchases => "inAppPurchases",
                GameCenterDetailsGetInstanceFieldsApp.InAppPurchasesV2 => "inAppPurchasesV2",
                GameCenterDetailsGetInstanceFieldsApp.IsOrEverWasMadeForKids => "isOrEverWasMadeForKids",
                GameCenterDetailsGetInstanceFieldsApp.MarketplaceSearchDetail => "marketplaceSearchDetail",
                GameCenterDetailsGetInstanceFieldsApp.Name => "name",
                GameCenterDetailsGetInstanceFieldsApp.PerfPowerMetrics => "perfPowerMetrics",
                GameCenterDetailsGetInstanceFieldsApp.PreReleaseVersions => "preReleaseVersions",
                GameCenterDetailsGetInstanceFieldsApp.PrimaryLocale => "primaryLocale",
                GameCenterDetailsGetInstanceFieldsApp.PromotedPurchases => "promotedPurchases",
                GameCenterDetailsGetInstanceFieldsApp.ReviewSubmissions => "reviewSubmissions",
                GameCenterDetailsGetInstanceFieldsApp.SearchKeywords => "searchKeywords",
                GameCenterDetailsGetInstanceFieldsApp.Sku => "sku",
                GameCenterDetailsGetInstanceFieldsApp.StreamlinedPurchasingEnabled => "streamlinedPurchasingEnabled",
                GameCenterDetailsGetInstanceFieldsApp.SubscriptionGracePeriod => "subscriptionGracePeriod",
                GameCenterDetailsGetInstanceFieldsApp.SubscriptionGroups => "subscriptionGroups",
                GameCenterDetailsGetInstanceFieldsApp.SubscriptionStatusUrl => "subscriptionStatusUrl",
                GameCenterDetailsGetInstanceFieldsApp.SubscriptionStatusUrlForSandbox => "subscriptionStatusUrlForSandbox",
                GameCenterDetailsGetInstanceFieldsApp.SubscriptionStatusUrlVersion => "subscriptionStatusUrlVersion",
                GameCenterDetailsGetInstanceFieldsApp.SubscriptionStatusUrlVersionForSandbox => "subscriptionStatusUrlVersionForSandbox",
                GameCenterDetailsGetInstanceFieldsApp.Webhooks => "webhooks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsGetInstanceFieldsApp? ToEnum(string value)
        {
            return value switch
            {
                "accessibilityDeclarations" => GameCenterDetailsGetInstanceFieldsApp.AccessibilityDeclarations,
                "accessibilityUrl" => GameCenterDetailsGetInstanceFieldsApp.AccessibilityUrl,
                "alternativeDistributionKey" => GameCenterDetailsGetInstanceFieldsApp.AlternativeDistributionKey,
                "analyticsReportRequests" => GameCenterDetailsGetInstanceFieldsApp.AnalyticsReportRequests,
                "androidToIosAppMappingDetails" => GameCenterDetailsGetInstanceFieldsApp.AndroidToIosAppMappingDetails,
                "appAvailabilityV2" => GameCenterDetailsGetInstanceFieldsApp.AppAvailabilityV2,
                "appClips" => GameCenterDetailsGetInstanceFieldsApp.AppClips,
                "appCustomProductPages" => GameCenterDetailsGetInstanceFieldsApp.AppCustomProductPages,
                "appEncryptionDeclarations" => GameCenterDetailsGetInstanceFieldsApp.AppEncryptionDeclarations,
                "appEvents" => GameCenterDetailsGetInstanceFieldsApp.AppEvents,
                "appInfos" => GameCenterDetailsGetInstanceFieldsApp.AppInfos,
                "appPricePoints" => GameCenterDetailsGetInstanceFieldsApp.AppPricePoints,
                "appPriceSchedule" => GameCenterDetailsGetInstanceFieldsApp.AppPriceSchedule,
                "appStoreIcon" => GameCenterDetailsGetInstanceFieldsApp.AppStoreIcon,
                "appStoreVersionExperimentsV2" => GameCenterDetailsGetInstanceFieldsApp.AppStoreVersionExperimentsV2,
                "appStoreVersions" => GameCenterDetailsGetInstanceFieldsApp.AppStoreVersions,
                "appTags" => GameCenterDetailsGetInstanceFieldsApp.AppTags,
                "backgroundAssets" => GameCenterDetailsGetInstanceFieldsApp.BackgroundAssets,
                "betaAppLocalizations" => GameCenterDetailsGetInstanceFieldsApp.BetaAppLocalizations,
                "betaAppReviewDetail" => GameCenterDetailsGetInstanceFieldsApp.BetaAppReviewDetail,
                "betaFeedbackCrashSubmissions" => GameCenterDetailsGetInstanceFieldsApp.BetaFeedbackCrashSubmissions,
                "betaFeedbackScreenshotSubmissions" => GameCenterDetailsGetInstanceFieldsApp.BetaFeedbackScreenshotSubmissions,
                "betaGroups" => GameCenterDetailsGetInstanceFieldsApp.BetaGroups,
                "betaLicenseAgreement" => GameCenterDetailsGetInstanceFieldsApp.BetaLicenseAgreement,
                "betaTesters" => GameCenterDetailsGetInstanceFieldsApp.BetaTesters,
                "buildUploads" => GameCenterDetailsGetInstanceFieldsApp.BuildUploads,
                "builds" => GameCenterDetailsGetInstanceFieldsApp.Builds,
                "bundleId" => GameCenterDetailsGetInstanceFieldsApp.BundleId,
                "ciProduct" => GameCenterDetailsGetInstanceFieldsApp.CiProduct,
                "contentRightsDeclaration" => GameCenterDetailsGetInstanceFieldsApp.ContentRightsDeclaration,
                "customerReviewSummarizations" => GameCenterDetailsGetInstanceFieldsApp.CustomerReviewSummarizations,
                "customerReviews" => GameCenterDetailsGetInstanceFieldsApp.CustomerReviews,
                "endUserLicenseAgreement" => GameCenterDetailsGetInstanceFieldsApp.EndUserLicenseAgreement,
                "gameCenterDetail" => GameCenterDetailsGetInstanceFieldsApp.GameCenterDetail,
                "gameCenterEnabledVersions" => GameCenterDetailsGetInstanceFieldsApp.GameCenterEnabledVersions,
                "inAppPurchases" => GameCenterDetailsGetInstanceFieldsApp.InAppPurchases,
                "inAppPurchasesV2" => GameCenterDetailsGetInstanceFieldsApp.InAppPurchasesV2,
                "isOrEverWasMadeForKids" => GameCenterDetailsGetInstanceFieldsApp.IsOrEverWasMadeForKids,
                "marketplaceSearchDetail" => GameCenterDetailsGetInstanceFieldsApp.MarketplaceSearchDetail,
                "name" => GameCenterDetailsGetInstanceFieldsApp.Name,
                "perfPowerMetrics" => GameCenterDetailsGetInstanceFieldsApp.PerfPowerMetrics,
                "preReleaseVersions" => GameCenterDetailsGetInstanceFieldsApp.PreReleaseVersions,
                "primaryLocale" => GameCenterDetailsGetInstanceFieldsApp.PrimaryLocale,
                "promotedPurchases" => GameCenterDetailsGetInstanceFieldsApp.PromotedPurchases,
                "reviewSubmissions" => GameCenterDetailsGetInstanceFieldsApp.ReviewSubmissions,
                "searchKeywords" => GameCenterDetailsGetInstanceFieldsApp.SearchKeywords,
                "sku" => GameCenterDetailsGetInstanceFieldsApp.Sku,
                "streamlinedPurchasingEnabled" => GameCenterDetailsGetInstanceFieldsApp.StreamlinedPurchasingEnabled,
                "subscriptionGracePeriod" => GameCenterDetailsGetInstanceFieldsApp.SubscriptionGracePeriod,
                "subscriptionGroups" => GameCenterDetailsGetInstanceFieldsApp.SubscriptionGroups,
                "subscriptionStatusUrl" => GameCenterDetailsGetInstanceFieldsApp.SubscriptionStatusUrl,
                "subscriptionStatusUrlForSandbox" => GameCenterDetailsGetInstanceFieldsApp.SubscriptionStatusUrlForSandbox,
                "subscriptionStatusUrlVersion" => GameCenterDetailsGetInstanceFieldsApp.SubscriptionStatusUrlVersion,
                "subscriptionStatusUrlVersionForSandbox" => GameCenterDetailsGetInstanceFieldsApp.SubscriptionStatusUrlVersionForSandbox,
                "webhooks" => GameCenterDetailsGetInstanceFieldsApp.Webhooks,
                _ => null,
            };
        }
    }
}