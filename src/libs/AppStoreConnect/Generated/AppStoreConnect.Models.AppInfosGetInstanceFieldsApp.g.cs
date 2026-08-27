
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppInfosGetInstanceFieldsApp
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
    public static class AppInfosGetInstanceFieldsAppExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppInfosGetInstanceFieldsApp value)
        {
            return value switch
            {
                AppInfosGetInstanceFieldsApp.AccessibilityDeclarations => "accessibilityDeclarations",
                AppInfosGetInstanceFieldsApp.AccessibilityUrl => "accessibilityUrl",
                AppInfosGetInstanceFieldsApp.AlternativeDistributionKey => "alternativeDistributionKey",
                AppInfosGetInstanceFieldsApp.AnalyticsReportRequests => "analyticsReportRequests",
                AppInfosGetInstanceFieldsApp.AndroidToIosAppMappingDetails => "androidToIosAppMappingDetails",
                AppInfosGetInstanceFieldsApp.AppAvailabilityV2 => "appAvailabilityV2",
                AppInfosGetInstanceFieldsApp.AppClips => "appClips",
                AppInfosGetInstanceFieldsApp.AppCustomProductPages => "appCustomProductPages",
                AppInfosGetInstanceFieldsApp.AppEncryptionDeclarations => "appEncryptionDeclarations",
                AppInfosGetInstanceFieldsApp.AppEvents => "appEvents",
                AppInfosGetInstanceFieldsApp.AppInfos => "appInfos",
                AppInfosGetInstanceFieldsApp.AppPricePoints => "appPricePoints",
                AppInfosGetInstanceFieldsApp.AppPriceSchedule => "appPriceSchedule",
                AppInfosGetInstanceFieldsApp.AppStoreIcon => "appStoreIcon",
                AppInfosGetInstanceFieldsApp.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                AppInfosGetInstanceFieldsApp.AppStoreVersions => "appStoreVersions",
                AppInfosGetInstanceFieldsApp.AppTags => "appTags",
                AppInfosGetInstanceFieldsApp.BackgroundAssets => "backgroundAssets",
                AppInfosGetInstanceFieldsApp.BetaAppLocalizations => "betaAppLocalizations",
                AppInfosGetInstanceFieldsApp.BetaAppReviewDetail => "betaAppReviewDetail",
                AppInfosGetInstanceFieldsApp.BetaFeedbackCrashSubmissions => "betaFeedbackCrashSubmissions",
                AppInfosGetInstanceFieldsApp.BetaFeedbackScreenshotSubmissions => "betaFeedbackScreenshotSubmissions",
                AppInfosGetInstanceFieldsApp.BetaGroups => "betaGroups",
                AppInfosGetInstanceFieldsApp.BetaLicenseAgreement => "betaLicenseAgreement",
                AppInfosGetInstanceFieldsApp.BetaTesters => "betaTesters",
                AppInfosGetInstanceFieldsApp.BuildUploads => "buildUploads",
                AppInfosGetInstanceFieldsApp.Builds => "builds",
                AppInfosGetInstanceFieldsApp.BundleId => "bundleId",
                AppInfosGetInstanceFieldsApp.CiProduct => "ciProduct",
                AppInfosGetInstanceFieldsApp.ContentRightsDeclaration => "contentRightsDeclaration",
                AppInfosGetInstanceFieldsApp.CustomerReviewSummarizations => "customerReviewSummarizations",
                AppInfosGetInstanceFieldsApp.CustomerReviews => "customerReviews",
                AppInfosGetInstanceFieldsApp.EndUserLicenseAgreement => "endUserLicenseAgreement",
                AppInfosGetInstanceFieldsApp.GameCenterDetail => "gameCenterDetail",
                AppInfosGetInstanceFieldsApp.GameCenterEnabledVersions => "gameCenterEnabledVersions",
                AppInfosGetInstanceFieldsApp.InAppPurchases => "inAppPurchases",
                AppInfosGetInstanceFieldsApp.InAppPurchasesV2 => "inAppPurchasesV2",
                AppInfosGetInstanceFieldsApp.IsOrEverWasMadeForKids => "isOrEverWasMadeForKids",
                AppInfosGetInstanceFieldsApp.MarketplaceSearchDetail => "marketplaceSearchDetail",
                AppInfosGetInstanceFieldsApp.Name => "name",
                AppInfosGetInstanceFieldsApp.PerfPowerMetrics => "perfPowerMetrics",
                AppInfosGetInstanceFieldsApp.PreReleaseVersions => "preReleaseVersions",
                AppInfosGetInstanceFieldsApp.PrimaryLocale => "primaryLocale",
                AppInfosGetInstanceFieldsApp.PromotedPurchases => "promotedPurchases",
                AppInfosGetInstanceFieldsApp.ReviewSubmissions => "reviewSubmissions",
                AppInfosGetInstanceFieldsApp.SearchKeywords => "searchKeywords",
                AppInfosGetInstanceFieldsApp.Sku => "sku",
                AppInfosGetInstanceFieldsApp.StreamlinedPurchasingEnabled => "streamlinedPurchasingEnabled",
                AppInfosGetInstanceFieldsApp.SubscriptionGracePeriod => "subscriptionGracePeriod",
                AppInfosGetInstanceFieldsApp.SubscriptionGroups => "subscriptionGroups",
                AppInfosGetInstanceFieldsApp.SubscriptionStatusUrl => "subscriptionStatusUrl",
                AppInfosGetInstanceFieldsApp.SubscriptionStatusUrlForSandbox => "subscriptionStatusUrlForSandbox",
                AppInfosGetInstanceFieldsApp.SubscriptionStatusUrlVersion => "subscriptionStatusUrlVersion",
                AppInfosGetInstanceFieldsApp.SubscriptionStatusUrlVersionForSandbox => "subscriptionStatusUrlVersionForSandbox",
                AppInfosGetInstanceFieldsApp.Webhooks => "webhooks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppInfosGetInstanceFieldsApp? ToEnum(string value)
        {
            return value switch
            {
                "accessibilityDeclarations" => AppInfosGetInstanceFieldsApp.AccessibilityDeclarations,
                "accessibilityUrl" => AppInfosGetInstanceFieldsApp.AccessibilityUrl,
                "alternativeDistributionKey" => AppInfosGetInstanceFieldsApp.AlternativeDistributionKey,
                "analyticsReportRequests" => AppInfosGetInstanceFieldsApp.AnalyticsReportRequests,
                "androidToIosAppMappingDetails" => AppInfosGetInstanceFieldsApp.AndroidToIosAppMappingDetails,
                "appAvailabilityV2" => AppInfosGetInstanceFieldsApp.AppAvailabilityV2,
                "appClips" => AppInfosGetInstanceFieldsApp.AppClips,
                "appCustomProductPages" => AppInfosGetInstanceFieldsApp.AppCustomProductPages,
                "appEncryptionDeclarations" => AppInfosGetInstanceFieldsApp.AppEncryptionDeclarations,
                "appEvents" => AppInfosGetInstanceFieldsApp.AppEvents,
                "appInfos" => AppInfosGetInstanceFieldsApp.AppInfos,
                "appPricePoints" => AppInfosGetInstanceFieldsApp.AppPricePoints,
                "appPriceSchedule" => AppInfosGetInstanceFieldsApp.AppPriceSchedule,
                "appStoreIcon" => AppInfosGetInstanceFieldsApp.AppStoreIcon,
                "appStoreVersionExperimentsV2" => AppInfosGetInstanceFieldsApp.AppStoreVersionExperimentsV2,
                "appStoreVersions" => AppInfosGetInstanceFieldsApp.AppStoreVersions,
                "appTags" => AppInfosGetInstanceFieldsApp.AppTags,
                "backgroundAssets" => AppInfosGetInstanceFieldsApp.BackgroundAssets,
                "betaAppLocalizations" => AppInfosGetInstanceFieldsApp.BetaAppLocalizations,
                "betaAppReviewDetail" => AppInfosGetInstanceFieldsApp.BetaAppReviewDetail,
                "betaFeedbackCrashSubmissions" => AppInfosGetInstanceFieldsApp.BetaFeedbackCrashSubmissions,
                "betaFeedbackScreenshotSubmissions" => AppInfosGetInstanceFieldsApp.BetaFeedbackScreenshotSubmissions,
                "betaGroups" => AppInfosGetInstanceFieldsApp.BetaGroups,
                "betaLicenseAgreement" => AppInfosGetInstanceFieldsApp.BetaLicenseAgreement,
                "betaTesters" => AppInfosGetInstanceFieldsApp.BetaTesters,
                "buildUploads" => AppInfosGetInstanceFieldsApp.BuildUploads,
                "builds" => AppInfosGetInstanceFieldsApp.Builds,
                "bundleId" => AppInfosGetInstanceFieldsApp.BundleId,
                "ciProduct" => AppInfosGetInstanceFieldsApp.CiProduct,
                "contentRightsDeclaration" => AppInfosGetInstanceFieldsApp.ContentRightsDeclaration,
                "customerReviewSummarizations" => AppInfosGetInstanceFieldsApp.CustomerReviewSummarizations,
                "customerReviews" => AppInfosGetInstanceFieldsApp.CustomerReviews,
                "endUserLicenseAgreement" => AppInfosGetInstanceFieldsApp.EndUserLicenseAgreement,
                "gameCenterDetail" => AppInfosGetInstanceFieldsApp.GameCenterDetail,
                "gameCenterEnabledVersions" => AppInfosGetInstanceFieldsApp.GameCenterEnabledVersions,
                "inAppPurchases" => AppInfosGetInstanceFieldsApp.InAppPurchases,
                "inAppPurchasesV2" => AppInfosGetInstanceFieldsApp.InAppPurchasesV2,
                "isOrEverWasMadeForKids" => AppInfosGetInstanceFieldsApp.IsOrEverWasMadeForKids,
                "marketplaceSearchDetail" => AppInfosGetInstanceFieldsApp.MarketplaceSearchDetail,
                "name" => AppInfosGetInstanceFieldsApp.Name,
                "perfPowerMetrics" => AppInfosGetInstanceFieldsApp.PerfPowerMetrics,
                "preReleaseVersions" => AppInfosGetInstanceFieldsApp.PreReleaseVersions,
                "primaryLocale" => AppInfosGetInstanceFieldsApp.PrimaryLocale,
                "promotedPurchases" => AppInfosGetInstanceFieldsApp.PromotedPurchases,
                "reviewSubmissions" => AppInfosGetInstanceFieldsApp.ReviewSubmissions,
                "searchKeywords" => AppInfosGetInstanceFieldsApp.SearchKeywords,
                "sku" => AppInfosGetInstanceFieldsApp.Sku,
                "streamlinedPurchasingEnabled" => AppInfosGetInstanceFieldsApp.StreamlinedPurchasingEnabled,
                "subscriptionGracePeriod" => AppInfosGetInstanceFieldsApp.SubscriptionGracePeriod,
                "subscriptionGroups" => AppInfosGetInstanceFieldsApp.SubscriptionGroups,
                "subscriptionStatusUrl" => AppInfosGetInstanceFieldsApp.SubscriptionStatusUrl,
                "subscriptionStatusUrlForSandbox" => AppInfosGetInstanceFieldsApp.SubscriptionStatusUrlForSandbox,
                "subscriptionStatusUrlVersion" => AppInfosGetInstanceFieldsApp.SubscriptionStatusUrlVersion,
                "subscriptionStatusUrlVersionForSandbox" => AppInfosGetInstanceFieldsApp.SubscriptionStatusUrlVersionForSandbox,
                "webhooks" => AppInfosGetInstanceFieldsApp.Webhooks,
                _ => null,
            };
        }
    }
}