
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppPricePointsV3GetInstanceFieldsApp
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
    public static class AppPricePointsV3GetInstanceFieldsAppExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPricePointsV3GetInstanceFieldsApp value)
        {
            return value switch
            {
                AppPricePointsV3GetInstanceFieldsApp.AccessibilityDeclarations => "accessibilityDeclarations",
                AppPricePointsV3GetInstanceFieldsApp.AccessibilityUrl => "accessibilityUrl",
                AppPricePointsV3GetInstanceFieldsApp.AlternativeDistributionKey => "alternativeDistributionKey",
                AppPricePointsV3GetInstanceFieldsApp.AnalyticsReportRequests => "analyticsReportRequests",
                AppPricePointsV3GetInstanceFieldsApp.AndroidToIosAppMappingDetails => "androidToIosAppMappingDetails",
                AppPricePointsV3GetInstanceFieldsApp.AppAvailabilityV2 => "appAvailabilityV2",
                AppPricePointsV3GetInstanceFieldsApp.AppClips => "appClips",
                AppPricePointsV3GetInstanceFieldsApp.AppCustomProductPages => "appCustomProductPages",
                AppPricePointsV3GetInstanceFieldsApp.AppEncryptionDeclarations => "appEncryptionDeclarations",
                AppPricePointsV3GetInstanceFieldsApp.AppEvents => "appEvents",
                AppPricePointsV3GetInstanceFieldsApp.AppInfos => "appInfos",
                AppPricePointsV3GetInstanceFieldsApp.AppPricePoints => "appPricePoints",
                AppPricePointsV3GetInstanceFieldsApp.AppPriceSchedule => "appPriceSchedule",
                AppPricePointsV3GetInstanceFieldsApp.AppStoreIcon => "appStoreIcon",
                AppPricePointsV3GetInstanceFieldsApp.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                AppPricePointsV3GetInstanceFieldsApp.AppStoreVersions => "appStoreVersions",
                AppPricePointsV3GetInstanceFieldsApp.AppTags => "appTags",
                AppPricePointsV3GetInstanceFieldsApp.BackgroundAssets => "backgroundAssets",
                AppPricePointsV3GetInstanceFieldsApp.BetaAppLocalizations => "betaAppLocalizations",
                AppPricePointsV3GetInstanceFieldsApp.BetaAppReviewDetail => "betaAppReviewDetail",
                AppPricePointsV3GetInstanceFieldsApp.BetaFeedbackCrashSubmissions => "betaFeedbackCrashSubmissions",
                AppPricePointsV3GetInstanceFieldsApp.BetaFeedbackScreenshotSubmissions => "betaFeedbackScreenshotSubmissions",
                AppPricePointsV3GetInstanceFieldsApp.BetaGroups => "betaGroups",
                AppPricePointsV3GetInstanceFieldsApp.BetaLicenseAgreement => "betaLicenseAgreement",
                AppPricePointsV3GetInstanceFieldsApp.BetaTesters => "betaTesters",
                AppPricePointsV3GetInstanceFieldsApp.BuildUploads => "buildUploads",
                AppPricePointsV3GetInstanceFieldsApp.Builds => "builds",
                AppPricePointsV3GetInstanceFieldsApp.BundleId => "bundleId",
                AppPricePointsV3GetInstanceFieldsApp.CiProduct => "ciProduct",
                AppPricePointsV3GetInstanceFieldsApp.ContentRightsDeclaration => "contentRightsDeclaration",
                AppPricePointsV3GetInstanceFieldsApp.CustomerReviewSummarizations => "customerReviewSummarizations",
                AppPricePointsV3GetInstanceFieldsApp.CustomerReviews => "customerReviews",
                AppPricePointsV3GetInstanceFieldsApp.EndUserLicenseAgreement => "endUserLicenseAgreement",
                AppPricePointsV3GetInstanceFieldsApp.GameCenterDetail => "gameCenterDetail",
                AppPricePointsV3GetInstanceFieldsApp.GameCenterEnabledVersions => "gameCenterEnabledVersions",
                AppPricePointsV3GetInstanceFieldsApp.InAppPurchases => "inAppPurchases",
                AppPricePointsV3GetInstanceFieldsApp.InAppPurchasesV2 => "inAppPurchasesV2",
                AppPricePointsV3GetInstanceFieldsApp.IsOrEverWasMadeForKids => "isOrEverWasMadeForKids",
                AppPricePointsV3GetInstanceFieldsApp.MarketplaceSearchDetail => "marketplaceSearchDetail",
                AppPricePointsV3GetInstanceFieldsApp.Name => "name",
                AppPricePointsV3GetInstanceFieldsApp.PerfPowerMetrics => "perfPowerMetrics",
                AppPricePointsV3GetInstanceFieldsApp.PreReleaseVersions => "preReleaseVersions",
                AppPricePointsV3GetInstanceFieldsApp.PrimaryLocale => "primaryLocale",
                AppPricePointsV3GetInstanceFieldsApp.PromotedPurchases => "promotedPurchases",
                AppPricePointsV3GetInstanceFieldsApp.ReviewSubmissions => "reviewSubmissions",
                AppPricePointsV3GetInstanceFieldsApp.SearchKeywords => "searchKeywords",
                AppPricePointsV3GetInstanceFieldsApp.Sku => "sku",
                AppPricePointsV3GetInstanceFieldsApp.StreamlinedPurchasingEnabled => "streamlinedPurchasingEnabled",
                AppPricePointsV3GetInstanceFieldsApp.SubscriptionGracePeriod => "subscriptionGracePeriod",
                AppPricePointsV3GetInstanceFieldsApp.SubscriptionGroups => "subscriptionGroups",
                AppPricePointsV3GetInstanceFieldsApp.SubscriptionStatusUrl => "subscriptionStatusUrl",
                AppPricePointsV3GetInstanceFieldsApp.SubscriptionStatusUrlForSandbox => "subscriptionStatusUrlForSandbox",
                AppPricePointsV3GetInstanceFieldsApp.SubscriptionStatusUrlVersion => "subscriptionStatusUrlVersion",
                AppPricePointsV3GetInstanceFieldsApp.SubscriptionStatusUrlVersionForSandbox => "subscriptionStatusUrlVersionForSandbox",
                AppPricePointsV3GetInstanceFieldsApp.Webhooks => "webhooks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPricePointsV3GetInstanceFieldsApp? ToEnum(string value)
        {
            return value switch
            {
                "accessibilityDeclarations" => AppPricePointsV3GetInstanceFieldsApp.AccessibilityDeclarations,
                "accessibilityUrl" => AppPricePointsV3GetInstanceFieldsApp.AccessibilityUrl,
                "alternativeDistributionKey" => AppPricePointsV3GetInstanceFieldsApp.AlternativeDistributionKey,
                "analyticsReportRequests" => AppPricePointsV3GetInstanceFieldsApp.AnalyticsReportRequests,
                "androidToIosAppMappingDetails" => AppPricePointsV3GetInstanceFieldsApp.AndroidToIosAppMappingDetails,
                "appAvailabilityV2" => AppPricePointsV3GetInstanceFieldsApp.AppAvailabilityV2,
                "appClips" => AppPricePointsV3GetInstanceFieldsApp.AppClips,
                "appCustomProductPages" => AppPricePointsV3GetInstanceFieldsApp.AppCustomProductPages,
                "appEncryptionDeclarations" => AppPricePointsV3GetInstanceFieldsApp.AppEncryptionDeclarations,
                "appEvents" => AppPricePointsV3GetInstanceFieldsApp.AppEvents,
                "appInfos" => AppPricePointsV3GetInstanceFieldsApp.AppInfos,
                "appPricePoints" => AppPricePointsV3GetInstanceFieldsApp.AppPricePoints,
                "appPriceSchedule" => AppPricePointsV3GetInstanceFieldsApp.AppPriceSchedule,
                "appStoreIcon" => AppPricePointsV3GetInstanceFieldsApp.AppStoreIcon,
                "appStoreVersionExperimentsV2" => AppPricePointsV3GetInstanceFieldsApp.AppStoreVersionExperimentsV2,
                "appStoreVersions" => AppPricePointsV3GetInstanceFieldsApp.AppStoreVersions,
                "appTags" => AppPricePointsV3GetInstanceFieldsApp.AppTags,
                "backgroundAssets" => AppPricePointsV3GetInstanceFieldsApp.BackgroundAssets,
                "betaAppLocalizations" => AppPricePointsV3GetInstanceFieldsApp.BetaAppLocalizations,
                "betaAppReviewDetail" => AppPricePointsV3GetInstanceFieldsApp.BetaAppReviewDetail,
                "betaFeedbackCrashSubmissions" => AppPricePointsV3GetInstanceFieldsApp.BetaFeedbackCrashSubmissions,
                "betaFeedbackScreenshotSubmissions" => AppPricePointsV3GetInstanceFieldsApp.BetaFeedbackScreenshotSubmissions,
                "betaGroups" => AppPricePointsV3GetInstanceFieldsApp.BetaGroups,
                "betaLicenseAgreement" => AppPricePointsV3GetInstanceFieldsApp.BetaLicenseAgreement,
                "betaTesters" => AppPricePointsV3GetInstanceFieldsApp.BetaTesters,
                "buildUploads" => AppPricePointsV3GetInstanceFieldsApp.BuildUploads,
                "builds" => AppPricePointsV3GetInstanceFieldsApp.Builds,
                "bundleId" => AppPricePointsV3GetInstanceFieldsApp.BundleId,
                "ciProduct" => AppPricePointsV3GetInstanceFieldsApp.CiProduct,
                "contentRightsDeclaration" => AppPricePointsV3GetInstanceFieldsApp.ContentRightsDeclaration,
                "customerReviewSummarizations" => AppPricePointsV3GetInstanceFieldsApp.CustomerReviewSummarizations,
                "customerReviews" => AppPricePointsV3GetInstanceFieldsApp.CustomerReviews,
                "endUserLicenseAgreement" => AppPricePointsV3GetInstanceFieldsApp.EndUserLicenseAgreement,
                "gameCenterDetail" => AppPricePointsV3GetInstanceFieldsApp.GameCenterDetail,
                "gameCenterEnabledVersions" => AppPricePointsV3GetInstanceFieldsApp.GameCenterEnabledVersions,
                "inAppPurchases" => AppPricePointsV3GetInstanceFieldsApp.InAppPurchases,
                "inAppPurchasesV2" => AppPricePointsV3GetInstanceFieldsApp.InAppPurchasesV2,
                "isOrEverWasMadeForKids" => AppPricePointsV3GetInstanceFieldsApp.IsOrEverWasMadeForKids,
                "marketplaceSearchDetail" => AppPricePointsV3GetInstanceFieldsApp.MarketplaceSearchDetail,
                "name" => AppPricePointsV3GetInstanceFieldsApp.Name,
                "perfPowerMetrics" => AppPricePointsV3GetInstanceFieldsApp.PerfPowerMetrics,
                "preReleaseVersions" => AppPricePointsV3GetInstanceFieldsApp.PreReleaseVersions,
                "primaryLocale" => AppPricePointsV3GetInstanceFieldsApp.PrimaryLocale,
                "promotedPurchases" => AppPricePointsV3GetInstanceFieldsApp.PromotedPurchases,
                "reviewSubmissions" => AppPricePointsV3GetInstanceFieldsApp.ReviewSubmissions,
                "searchKeywords" => AppPricePointsV3GetInstanceFieldsApp.SearchKeywords,
                "sku" => AppPricePointsV3GetInstanceFieldsApp.Sku,
                "streamlinedPurchasingEnabled" => AppPricePointsV3GetInstanceFieldsApp.StreamlinedPurchasingEnabled,
                "subscriptionGracePeriod" => AppPricePointsV3GetInstanceFieldsApp.SubscriptionGracePeriod,
                "subscriptionGroups" => AppPricePointsV3GetInstanceFieldsApp.SubscriptionGroups,
                "subscriptionStatusUrl" => AppPricePointsV3GetInstanceFieldsApp.SubscriptionStatusUrl,
                "subscriptionStatusUrlForSandbox" => AppPricePointsV3GetInstanceFieldsApp.SubscriptionStatusUrlForSandbox,
                "subscriptionStatusUrlVersion" => AppPricePointsV3GetInstanceFieldsApp.SubscriptionStatusUrlVersion,
                "subscriptionStatusUrlVersionForSandbox" => AppPricePointsV3GetInstanceFieldsApp.SubscriptionStatusUrlVersionForSandbox,
                "webhooks" => AppPricePointsV3GetInstanceFieldsApp.Webhooks,
                _ => null,
            };
        }
    }
}