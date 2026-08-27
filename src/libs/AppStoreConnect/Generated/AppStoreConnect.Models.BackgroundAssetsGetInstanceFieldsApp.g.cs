
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BackgroundAssetsGetInstanceFieldsApp
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
    public static class BackgroundAssetsGetInstanceFieldsAppExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundAssetsGetInstanceFieldsApp value)
        {
            return value switch
            {
                BackgroundAssetsGetInstanceFieldsApp.AccessibilityDeclarations => "accessibilityDeclarations",
                BackgroundAssetsGetInstanceFieldsApp.AccessibilityUrl => "accessibilityUrl",
                BackgroundAssetsGetInstanceFieldsApp.AlternativeDistributionKey => "alternativeDistributionKey",
                BackgroundAssetsGetInstanceFieldsApp.AnalyticsReportRequests => "analyticsReportRequests",
                BackgroundAssetsGetInstanceFieldsApp.AndroidToIosAppMappingDetails => "androidToIosAppMappingDetails",
                BackgroundAssetsGetInstanceFieldsApp.AppAvailabilityV2 => "appAvailabilityV2",
                BackgroundAssetsGetInstanceFieldsApp.AppClips => "appClips",
                BackgroundAssetsGetInstanceFieldsApp.AppCustomProductPages => "appCustomProductPages",
                BackgroundAssetsGetInstanceFieldsApp.AppEncryptionDeclarations => "appEncryptionDeclarations",
                BackgroundAssetsGetInstanceFieldsApp.AppEvents => "appEvents",
                BackgroundAssetsGetInstanceFieldsApp.AppInfos => "appInfos",
                BackgroundAssetsGetInstanceFieldsApp.AppPricePoints => "appPricePoints",
                BackgroundAssetsGetInstanceFieldsApp.AppPriceSchedule => "appPriceSchedule",
                BackgroundAssetsGetInstanceFieldsApp.AppStoreIcon => "appStoreIcon",
                BackgroundAssetsGetInstanceFieldsApp.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                BackgroundAssetsGetInstanceFieldsApp.AppStoreVersions => "appStoreVersions",
                BackgroundAssetsGetInstanceFieldsApp.AppTags => "appTags",
                BackgroundAssetsGetInstanceFieldsApp.BackgroundAssets => "backgroundAssets",
                BackgroundAssetsGetInstanceFieldsApp.BetaAppLocalizations => "betaAppLocalizations",
                BackgroundAssetsGetInstanceFieldsApp.BetaAppReviewDetail => "betaAppReviewDetail",
                BackgroundAssetsGetInstanceFieldsApp.BetaFeedbackCrashSubmissions => "betaFeedbackCrashSubmissions",
                BackgroundAssetsGetInstanceFieldsApp.BetaFeedbackScreenshotSubmissions => "betaFeedbackScreenshotSubmissions",
                BackgroundAssetsGetInstanceFieldsApp.BetaGroups => "betaGroups",
                BackgroundAssetsGetInstanceFieldsApp.BetaLicenseAgreement => "betaLicenseAgreement",
                BackgroundAssetsGetInstanceFieldsApp.BetaTesters => "betaTesters",
                BackgroundAssetsGetInstanceFieldsApp.BuildUploads => "buildUploads",
                BackgroundAssetsGetInstanceFieldsApp.Builds => "builds",
                BackgroundAssetsGetInstanceFieldsApp.BundleId => "bundleId",
                BackgroundAssetsGetInstanceFieldsApp.CiProduct => "ciProduct",
                BackgroundAssetsGetInstanceFieldsApp.ContentRightsDeclaration => "contentRightsDeclaration",
                BackgroundAssetsGetInstanceFieldsApp.CustomerReviewSummarizations => "customerReviewSummarizations",
                BackgroundAssetsGetInstanceFieldsApp.CustomerReviews => "customerReviews",
                BackgroundAssetsGetInstanceFieldsApp.EndUserLicenseAgreement => "endUserLicenseAgreement",
                BackgroundAssetsGetInstanceFieldsApp.GameCenterDetail => "gameCenterDetail",
                BackgroundAssetsGetInstanceFieldsApp.GameCenterEnabledVersions => "gameCenterEnabledVersions",
                BackgroundAssetsGetInstanceFieldsApp.InAppPurchases => "inAppPurchases",
                BackgroundAssetsGetInstanceFieldsApp.InAppPurchasesV2 => "inAppPurchasesV2",
                BackgroundAssetsGetInstanceFieldsApp.IsOrEverWasMadeForKids => "isOrEverWasMadeForKids",
                BackgroundAssetsGetInstanceFieldsApp.MarketplaceSearchDetail => "marketplaceSearchDetail",
                BackgroundAssetsGetInstanceFieldsApp.Name => "name",
                BackgroundAssetsGetInstanceFieldsApp.PerfPowerMetrics => "perfPowerMetrics",
                BackgroundAssetsGetInstanceFieldsApp.PreReleaseVersions => "preReleaseVersions",
                BackgroundAssetsGetInstanceFieldsApp.PrimaryLocale => "primaryLocale",
                BackgroundAssetsGetInstanceFieldsApp.PromotedPurchases => "promotedPurchases",
                BackgroundAssetsGetInstanceFieldsApp.ReviewSubmissions => "reviewSubmissions",
                BackgroundAssetsGetInstanceFieldsApp.SearchKeywords => "searchKeywords",
                BackgroundAssetsGetInstanceFieldsApp.Sku => "sku",
                BackgroundAssetsGetInstanceFieldsApp.StreamlinedPurchasingEnabled => "streamlinedPurchasingEnabled",
                BackgroundAssetsGetInstanceFieldsApp.SubscriptionGracePeriod => "subscriptionGracePeriod",
                BackgroundAssetsGetInstanceFieldsApp.SubscriptionGroups => "subscriptionGroups",
                BackgroundAssetsGetInstanceFieldsApp.SubscriptionStatusUrl => "subscriptionStatusUrl",
                BackgroundAssetsGetInstanceFieldsApp.SubscriptionStatusUrlForSandbox => "subscriptionStatusUrlForSandbox",
                BackgroundAssetsGetInstanceFieldsApp.SubscriptionStatusUrlVersion => "subscriptionStatusUrlVersion",
                BackgroundAssetsGetInstanceFieldsApp.SubscriptionStatusUrlVersionForSandbox => "subscriptionStatusUrlVersionForSandbox",
                BackgroundAssetsGetInstanceFieldsApp.Webhooks => "webhooks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundAssetsGetInstanceFieldsApp? ToEnum(string value)
        {
            return value switch
            {
                "accessibilityDeclarations" => BackgroundAssetsGetInstanceFieldsApp.AccessibilityDeclarations,
                "accessibilityUrl" => BackgroundAssetsGetInstanceFieldsApp.AccessibilityUrl,
                "alternativeDistributionKey" => BackgroundAssetsGetInstanceFieldsApp.AlternativeDistributionKey,
                "analyticsReportRequests" => BackgroundAssetsGetInstanceFieldsApp.AnalyticsReportRequests,
                "androidToIosAppMappingDetails" => BackgroundAssetsGetInstanceFieldsApp.AndroidToIosAppMappingDetails,
                "appAvailabilityV2" => BackgroundAssetsGetInstanceFieldsApp.AppAvailabilityV2,
                "appClips" => BackgroundAssetsGetInstanceFieldsApp.AppClips,
                "appCustomProductPages" => BackgroundAssetsGetInstanceFieldsApp.AppCustomProductPages,
                "appEncryptionDeclarations" => BackgroundAssetsGetInstanceFieldsApp.AppEncryptionDeclarations,
                "appEvents" => BackgroundAssetsGetInstanceFieldsApp.AppEvents,
                "appInfos" => BackgroundAssetsGetInstanceFieldsApp.AppInfos,
                "appPricePoints" => BackgroundAssetsGetInstanceFieldsApp.AppPricePoints,
                "appPriceSchedule" => BackgroundAssetsGetInstanceFieldsApp.AppPriceSchedule,
                "appStoreIcon" => BackgroundAssetsGetInstanceFieldsApp.AppStoreIcon,
                "appStoreVersionExperimentsV2" => BackgroundAssetsGetInstanceFieldsApp.AppStoreVersionExperimentsV2,
                "appStoreVersions" => BackgroundAssetsGetInstanceFieldsApp.AppStoreVersions,
                "appTags" => BackgroundAssetsGetInstanceFieldsApp.AppTags,
                "backgroundAssets" => BackgroundAssetsGetInstanceFieldsApp.BackgroundAssets,
                "betaAppLocalizations" => BackgroundAssetsGetInstanceFieldsApp.BetaAppLocalizations,
                "betaAppReviewDetail" => BackgroundAssetsGetInstanceFieldsApp.BetaAppReviewDetail,
                "betaFeedbackCrashSubmissions" => BackgroundAssetsGetInstanceFieldsApp.BetaFeedbackCrashSubmissions,
                "betaFeedbackScreenshotSubmissions" => BackgroundAssetsGetInstanceFieldsApp.BetaFeedbackScreenshotSubmissions,
                "betaGroups" => BackgroundAssetsGetInstanceFieldsApp.BetaGroups,
                "betaLicenseAgreement" => BackgroundAssetsGetInstanceFieldsApp.BetaLicenseAgreement,
                "betaTesters" => BackgroundAssetsGetInstanceFieldsApp.BetaTesters,
                "buildUploads" => BackgroundAssetsGetInstanceFieldsApp.BuildUploads,
                "builds" => BackgroundAssetsGetInstanceFieldsApp.Builds,
                "bundleId" => BackgroundAssetsGetInstanceFieldsApp.BundleId,
                "ciProduct" => BackgroundAssetsGetInstanceFieldsApp.CiProduct,
                "contentRightsDeclaration" => BackgroundAssetsGetInstanceFieldsApp.ContentRightsDeclaration,
                "customerReviewSummarizations" => BackgroundAssetsGetInstanceFieldsApp.CustomerReviewSummarizations,
                "customerReviews" => BackgroundAssetsGetInstanceFieldsApp.CustomerReviews,
                "endUserLicenseAgreement" => BackgroundAssetsGetInstanceFieldsApp.EndUserLicenseAgreement,
                "gameCenterDetail" => BackgroundAssetsGetInstanceFieldsApp.GameCenterDetail,
                "gameCenterEnabledVersions" => BackgroundAssetsGetInstanceFieldsApp.GameCenterEnabledVersions,
                "inAppPurchases" => BackgroundAssetsGetInstanceFieldsApp.InAppPurchases,
                "inAppPurchasesV2" => BackgroundAssetsGetInstanceFieldsApp.InAppPurchasesV2,
                "isOrEverWasMadeForKids" => BackgroundAssetsGetInstanceFieldsApp.IsOrEverWasMadeForKids,
                "marketplaceSearchDetail" => BackgroundAssetsGetInstanceFieldsApp.MarketplaceSearchDetail,
                "name" => BackgroundAssetsGetInstanceFieldsApp.Name,
                "perfPowerMetrics" => BackgroundAssetsGetInstanceFieldsApp.PerfPowerMetrics,
                "preReleaseVersions" => BackgroundAssetsGetInstanceFieldsApp.PreReleaseVersions,
                "primaryLocale" => BackgroundAssetsGetInstanceFieldsApp.PrimaryLocale,
                "promotedPurchases" => BackgroundAssetsGetInstanceFieldsApp.PromotedPurchases,
                "reviewSubmissions" => BackgroundAssetsGetInstanceFieldsApp.ReviewSubmissions,
                "searchKeywords" => BackgroundAssetsGetInstanceFieldsApp.SearchKeywords,
                "sku" => BackgroundAssetsGetInstanceFieldsApp.Sku,
                "streamlinedPurchasingEnabled" => BackgroundAssetsGetInstanceFieldsApp.StreamlinedPurchasingEnabled,
                "subscriptionGracePeriod" => BackgroundAssetsGetInstanceFieldsApp.SubscriptionGracePeriod,
                "subscriptionGroups" => BackgroundAssetsGetInstanceFieldsApp.SubscriptionGroups,
                "subscriptionStatusUrl" => BackgroundAssetsGetInstanceFieldsApp.SubscriptionStatusUrl,
                "subscriptionStatusUrlForSandbox" => BackgroundAssetsGetInstanceFieldsApp.SubscriptionStatusUrlForSandbox,
                "subscriptionStatusUrlVersion" => BackgroundAssetsGetInstanceFieldsApp.SubscriptionStatusUrlVersion,
                "subscriptionStatusUrlVersionForSandbox" => BackgroundAssetsGetInstanceFieldsApp.SubscriptionStatusUrlVersionForSandbox,
                "webhooks" => BackgroundAssetsGetInstanceFieldsApp.Webhooks,
                _ => null,
            };
        }
    }
}