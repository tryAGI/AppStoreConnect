
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionsGetInstanceFieldsApp
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
    public static class AppStoreVersionsGetInstanceFieldsAppExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionsGetInstanceFieldsApp value)
        {
            return value switch
            {
                AppStoreVersionsGetInstanceFieldsApp.AccessibilityDeclarations => "accessibilityDeclarations",
                AppStoreVersionsGetInstanceFieldsApp.AccessibilityUrl => "accessibilityUrl",
                AppStoreVersionsGetInstanceFieldsApp.AlternativeDistributionKey => "alternativeDistributionKey",
                AppStoreVersionsGetInstanceFieldsApp.AnalyticsReportRequests => "analyticsReportRequests",
                AppStoreVersionsGetInstanceFieldsApp.AndroidToIosAppMappingDetails => "androidToIosAppMappingDetails",
                AppStoreVersionsGetInstanceFieldsApp.AppAvailabilityV2 => "appAvailabilityV2",
                AppStoreVersionsGetInstanceFieldsApp.AppClips => "appClips",
                AppStoreVersionsGetInstanceFieldsApp.AppCustomProductPages => "appCustomProductPages",
                AppStoreVersionsGetInstanceFieldsApp.AppEncryptionDeclarations => "appEncryptionDeclarations",
                AppStoreVersionsGetInstanceFieldsApp.AppEvents => "appEvents",
                AppStoreVersionsGetInstanceFieldsApp.AppInfos => "appInfos",
                AppStoreVersionsGetInstanceFieldsApp.AppPricePoints => "appPricePoints",
                AppStoreVersionsGetInstanceFieldsApp.AppPriceSchedule => "appPriceSchedule",
                AppStoreVersionsGetInstanceFieldsApp.AppStoreIcon => "appStoreIcon",
                AppStoreVersionsGetInstanceFieldsApp.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                AppStoreVersionsGetInstanceFieldsApp.AppStoreVersions => "appStoreVersions",
                AppStoreVersionsGetInstanceFieldsApp.AppTags => "appTags",
                AppStoreVersionsGetInstanceFieldsApp.BackgroundAssets => "backgroundAssets",
                AppStoreVersionsGetInstanceFieldsApp.BetaAppLocalizations => "betaAppLocalizations",
                AppStoreVersionsGetInstanceFieldsApp.BetaAppReviewDetail => "betaAppReviewDetail",
                AppStoreVersionsGetInstanceFieldsApp.BetaFeedbackCrashSubmissions => "betaFeedbackCrashSubmissions",
                AppStoreVersionsGetInstanceFieldsApp.BetaFeedbackScreenshotSubmissions => "betaFeedbackScreenshotSubmissions",
                AppStoreVersionsGetInstanceFieldsApp.BetaGroups => "betaGroups",
                AppStoreVersionsGetInstanceFieldsApp.BetaLicenseAgreement => "betaLicenseAgreement",
                AppStoreVersionsGetInstanceFieldsApp.BetaTesters => "betaTesters",
                AppStoreVersionsGetInstanceFieldsApp.BuildUploads => "buildUploads",
                AppStoreVersionsGetInstanceFieldsApp.Builds => "builds",
                AppStoreVersionsGetInstanceFieldsApp.BundleId => "bundleId",
                AppStoreVersionsGetInstanceFieldsApp.CiProduct => "ciProduct",
                AppStoreVersionsGetInstanceFieldsApp.ContentRightsDeclaration => "contentRightsDeclaration",
                AppStoreVersionsGetInstanceFieldsApp.CustomerReviewSummarizations => "customerReviewSummarizations",
                AppStoreVersionsGetInstanceFieldsApp.CustomerReviews => "customerReviews",
                AppStoreVersionsGetInstanceFieldsApp.EndUserLicenseAgreement => "endUserLicenseAgreement",
                AppStoreVersionsGetInstanceFieldsApp.GameCenterDetail => "gameCenterDetail",
                AppStoreVersionsGetInstanceFieldsApp.GameCenterEnabledVersions => "gameCenterEnabledVersions",
                AppStoreVersionsGetInstanceFieldsApp.InAppPurchases => "inAppPurchases",
                AppStoreVersionsGetInstanceFieldsApp.InAppPurchasesV2 => "inAppPurchasesV2",
                AppStoreVersionsGetInstanceFieldsApp.IsOrEverWasMadeForKids => "isOrEverWasMadeForKids",
                AppStoreVersionsGetInstanceFieldsApp.MarketplaceSearchDetail => "marketplaceSearchDetail",
                AppStoreVersionsGetInstanceFieldsApp.Name => "name",
                AppStoreVersionsGetInstanceFieldsApp.PerfPowerMetrics => "perfPowerMetrics",
                AppStoreVersionsGetInstanceFieldsApp.PreReleaseVersions => "preReleaseVersions",
                AppStoreVersionsGetInstanceFieldsApp.PrimaryLocale => "primaryLocale",
                AppStoreVersionsGetInstanceFieldsApp.PromotedPurchases => "promotedPurchases",
                AppStoreVersionsGetInstanceFieldsApp.ReviewSubmissions => "reviewSubmissions",
                AppStoreVersionsGetInstanceFieldsApp.SearchKeywords => "searchKeywords",
                AppStoreVersionsGetInstanceFieldsApp.Sku => "sku",
                AppStoreVersionsGetInstanceFieldsApp.StreamlinedPurchasingEnabled => "streamlinedPurchasingEnabled",
                AppStoreVersionsGetInstanceFieldsApp.SubscriptionGracePeriod => "subscriptionGracePeriod",
                AppStoreVersionsGetInstanceFieldsApp.SubscriptionGroups => "subscriptionGroups",
                AppStoreVersionsGetInstanceFieldsApp.SubscriptionStatusUrl => "subscriptionStatusUrl",
                AppStoreVersionsGetInstanceFieldsApp.SubscriptionStatusUrlForSandbox => "subscriptionStatusUrlForSandbox",
                AppStoreVersionsGetInstanceFieldsApp.SubscriptionStatusUrlVersion => "subscriptionStatusUrlVersion",
                AppStoreVersionsGetInstanceFieldsApp.SubscriptionStatusUrlVersionForSandbox => "subscriptionStatusUrlVersionForSandbox",
                AppStoreVersionsGetInstanceFieldsApp.Webhooks => "webhooks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionsGetInstanceFieldsApp? ToEnum(string value)
        {
            return value switch
            {
                "accessibilityDeclarations" => AppStoreVersionsGetInstanceFieldsApp.AccessibilityDeclarations,
                "accessibilityUrl" => AppStoreVersionsGetInstanceFieldsApp.AccessibilityUrl,
                "alternativeDistributionKey" => AppStoreVersionsGetInstanceFieldsApp.AlternativeDistributionKey,
                "analyticsReportRequests" => AppStoreVersionsGetInstanceFieldsApp.AnalyticsReportRequests,
                "androidToIosAppMappingDetails" => AppStoreVersionsGetInstanceFieldsApp.AndroidToIosAppMappingDetails,
                "appAvailabilityV2" => AppStoreVersionsGetInstanceFieldsApp.AppAvailabilityV2,
                "appClips" => AppStoreVersionsGetInstanceFieldsApp.AppClips,
                "appCustomProductPages" => AppStoreVersionsGetInstanceFieldsApp.AppCustomProductPages,
                "appEncryptionDeclarations" => AppStoreVersionsGetInstanceFieldsApp.AppEncryptionDeclarations,
                "appEvents" => AppStoreVersionsGetInstanceFieldsApp.AppEvents,
                "appInfos" => AppStoreVersionsGetInstanceFieldsApp.AppInfos,
                "appPricePoints" => AppStoreVersionsGetInstanceFieldsApp.AppPricePoints,
                "appPriceSchedule" => AppStoreVersionsGetInstanceFieldsApp.AppPriceSchedule,
                "appStoreIcon" => AppStoreVersionsGetInstanceFieldsApp.AppStoreIcon,
                "appStoreVersionExperimentsV2" => AppStoreVersionsGetInstanceFieldsApp.AppStoreVersionExperimentsV2,
                "appStoreVersions" => AppStoreVersionsGetInstanceFieldsApp.AppStoreVersions,
                "appTags" => AppStoreVersionsGetInstanceFieldsApp.AppTags,
                "backgroundAssets" => AppStoreVersionsGetInstanceFieldsApp.BackgroundAssets,
                "betaAppLocalizations" => AppStoreVersionsGetInstanceFieldsApp.BetaAppLocalizations,
                "betaAppReviewDetail" => AppStoreVersionsGetInstanceFieldsApp.BetaAppReviewDetail,
                "betaFeedbackCrashSubmissions" => AppStoreVersionsGetInstanceFieldsApp.BetaFeedbackCrashSubmissions,
                "betaFeedbackScreenshotSubmissions" => AppStoreVersionsGetInstanceFieldsApp.BetaFeedbackScreenshotSubmissions,
                "betaGroups" => AppStoreVersionsGetInstanceFieldsApp.BetaGroups,
                "betaLicenseAgreement" => AppStoreVersionsGetInstanceFieldsApp.BetaLicenseAgreement,
                "betaTesters" => AppStoreVersionsGetInstanceFieldsApp.BetaTesters,
                "buildUploads" => AppStoreVersionsGetInstanceFieldsApp.BuildUploads,
                "builds" => AppStoreVersionsGetInstanceFieldsApp.Builds,
                "bundleId" => AppStoreVersionsGetInstanceFieldsApp.BundleId,
                "ciProduct" => AppStoreVersionsGetInstanceFieldsApp.CiProduct,
                "contentRightsDeclaration" => AppStoreVersionsGetInstanceFieldsApp.ContentRightsDeclaration,
                "customerReviewSummarizations" => AppStoreVersionsGetInstanceFieldsApp.CustomerReviewSummarizations,
                "customerReviews" => AppStoreVersionsGetInstanceFieldsApp.CustomerReviews,
                "endUserLicenseAgreement" => AppStoreVersionsGetInstanceFieldsApp.EndUserLicenseAgreement,
                "gameCenterDetail" => AppStoreVersionsGetInstanceFieldsApp.GameCenterDetail,
                "gameCenterEnabledVersions" => AppStoreVersionsGetInstanceFieldsApp.GameCenterEnabledVersions,
                "inAppPurchases" => AppStoreVersionsGetInstanceFieldsApp.InAppPurchases,
                "inAppPurchasesV2" => AppStoreVersionsGetInstanceFieldsApp.InAppPurchasesV2,
                "isOrEverWasMadeForKids" => AppStoreVersionsGetInstanceFieldsApp.IsOrEverWasMadeForKids,
                "marketplaceSearchDetail" => AppStoreVersionsGetInstanceFieldsApp.MarketplaceSearchDetail,
                "name" => AppStoreVersionsGetInstanceFieldsApp.Name,
                "perfPowerMetrics" => AppStoreVersionsGetInstanceFieldsApp.PerfPowerMetrics,
                "preReleaseVersions" => AppStoreVersionsGetInstanceFieldsApp.PreReleaseVersions,
                "primaryLocale" => AppStoreVersionsGetInstanceFieldsApp.PrimaryLocale,
                "promotedPurchases" => AppStoreVersionsGetInstanceFieldsApp.PromotedPurchases,
                "reviewSubmissions" => AppStoreVersionsGetInstanceFieldsApp.ReviewSubmissions,
                "searchKeywords" => AppStoreVersionsGetInstanceFieldsApp.SearchKeywords,
                "sku" => AppStoreVersionsGetInstanceFieldsApp.Sku,
                "streamlinedPurchasingEnabled" => AppStoreVersionsGetInstanceFieldsApp.StreamlinedPurchasingEnabled,
                "subscriptionGracePeriod" => AppStoreVersionsGetInstanceFieldsApp.SubscriptionGracePeriod,
                "subscriptionGroups" => AppStoreVersionsGetInstanceFieldsApp.SubscriptionGroups,
                "subscriptionStatusUrl" => AppStoreVersionsGetInstanceFieldsApp.SubscriptionStatusUrl,
                "subscriptionStatusUrlForSandbox" => AppStoreVersionsGetInstanceFieldsApp.SubscriptionStatusUrlForSandbox,
                "subscriptionStatusUrlVersion" => AppStoreVersionsGetInstanceFieldsApp.SubscriptionStatusUrlVersion,
                "subscriptionStatusUrlVersionForSandbox" => AppStoreVersionsGetInstanceFieldsApp.SubscriptionStatusUrlVersionForSandbox,
                "webhooks" => AppStoreVersionsGetInstanceFieldsApp.Webhooks,
                _ => null,
            };
        }
    }
}