
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildsGetInstanceFieldsApp
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
    public static class BuildsGetInstanceFieldsAppExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildsGetInstanceFieldsApp value)
        {
            return value switch
            {
                BuildsGetInstanceFieldsApp.AccessibilityDeclarations => "accessibilityDeclarations",
                BuildsGetInstanceFieldsApp.AccessibilityUrl => "accessibilityUrl",
                BuildsGetInstanceFieldsApp.AlternativeDistributionKey => "alternativeDistributionKey",
                BuildsGetInstanceFieldsApp.AnalyticsReportRequests => "analyticsReportRequests",
                BuildsGetInstanceFieldsApp.AndroidToIosAppMappingDetails => "androidToIosAppMappingDetails",
                BuildsGetInstanceFieldsApp.AppAvailabilityV2 => "appAvailabilityV2",
                BuildsGetInstanceFieldsApp.AppClips => "appClips",
                BuildsGetInstanceFieldsApp.AppCustomProductPages => "appCustomProductPages",
                BuildsGetInstanceFieldsApp.AppEncryptionDeclarations => "appEncryptionDeclarations",
                BuildsGetInstanceFieldsApp.AppEvents => "appEvents",
                BuildsGetInstanceFieldsApp.AppInfos => "appInfos",
                BuildsGetInstanceFieldsApp.AppPricePoints => "appPricePoints",
                BuildsGetInstanceFieldsApp.AppPriceSchedule => "appPriceSchedule",
                BuildsGetInstanceFieldsApp.AppStoreIcon => "appStoreIcon",
                BuildsGetInstanceFieldsApp.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                BuildsGetInstanceFieldsApp.AppStoreVersions => "appStoreVersions",
                BuildsGetInstanceFieldsApp.AppTags => "appTags",
                BuildsGetInstanceFieldsApp.BackgroundAssets => "backgroundAssets",
                BuildsGetInstanceFieldsApp.BetaAppLocalizations => "betaAppLocalizations",
                BuildsGetInstanceFieldsApp.BetaAppReviewDetail => "betaAppReviewDetail",
                BuildsGetInstanceFieldsApp.BetaFeedbackCrashSubmissions => "betaFeedbackCrashSubmissions",
                BuildsGetInstanceFieldsApp.BetaFeedbackScreenshotSubmissions => "betaFeedbackScreenshotSubmissions",
                BuildsGetInstanceFieldsApp.BetaGroups => "betaGroups",
                BuildsGetInstanceFieldsApp.BetaLicenseAgreement => "betaLicenseAgreement",
                BuildsGetInstanceFieldsApp.BetaTesters => "betaTesters",
                BuildsGetInstanceFieldsApp.BuildUploads => "buildUploads",
                BuildsGetInstanceFieldsApp.Builds => "builds",
                BuildsGetInstanceFieldsApp.BundleId => "bundleId",
                BuildsGetInstanceFieldsApp.CiProduct => "ciProduct",
                BuildsGetInstanceFieldsApp.ContentRightsDeclaration => "contentRightsDeclaration",
                BuildsGetInstanceFieldsApp.CustomerReviewSummarizations => "customerReviewSummarizations",
                BuildsGetInstanceFieldsApp.CustomerReviews => "customerReviews",
                BuildsGetInstanceFieldsApp.EndUserLicenseAgreement => "endUserLicenseAgreement",
                BuildsGetInstanceFieldsApp.GameCenterDetail => "gameCenterDetail",
                BuildsGetInstanceFieldsApp.GameCenterEnabledVersions => "gameCenterEnabledVersions",
                BuildsGetInstanceFieldsApp.InAppPurchases => "inAppPurchases",
                BuildsGetInstanceFieldsApp.InAppPurchasesV2 => "inAppPurchasesV2",
                BuildsGetInstanceFieldsApp.IsOrEverWasMadeForKids => "isOrEverWasMadeForKids",
                BuildsGetInstanceFieldsApp.MarketplaceSearchDetail => "marketplaceSearchDetail",
                BuildsGetInstanceFieldsApp.Name => "name",
                BuildsGetInstanceFieldsApp.PerfPowerMetrics => "perfPowerMetrics",
                BuildsGetInstanceFieldsApp.PreReleaseVersions => "preReleaseVersions",
                BuildsGetInstanceFieldsApp.PrimaryLocale => "primaryLocale",
                BuildsGetInstanceFieldsApp.PromotedPurchases => "promotedPurchases",
                BuildsGetInstanceFieldsApp.ReviewSubmissions => "reviewSubmissions",
                BuildsGetInstanceFieldsApp.SearchKeywords => "searchKeywords",
                BuildsGetInstanceFieldsApp.Sku => "sku",
                BuildsGetInstanceFieldsApp.StreamlinedPurchasingEnabled => "streamlinedPurchasingEnabled",
                BuildsGetInstanceFieldsApp.SubscriptionGracePeriod => "subscriptionGracePeriod",
                BuildsGetInstanceFieldsApp.SubscriptionGroups => "subscriptionGroups",
                BuildsGetInstanceFieldsApp.SubscriptionStatusUrl => "subscriptionStatusUrl",
                BuildsGetInstanceFieldsApp.SubscriptionStatusUrlForSandbox => "subscriptionStatusUrlForSandbox",
                BuildsGetInstanceFieldsApp.SubscriptionStatusUrlVersion => "subscriptionStatusUrlVersion",
                BuildsGetInstanceFieldsApp.SubscriptionStatusUrlVersionForSandbox => "subscriptionStatusUrlVersionForSandbox",
                BuildsGetInstanceFieldsApp.Webhooks => "webhooks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildsGetInstanceFieldsApp? ToEnum(string value)
        {
            return value switch
            {
                "accessibilityDeclarations" => BuildsGetInstanceFieldsApp.AccessibilityDeclarations,
                "accessibilityUrl" => BuildsGetInstanceFieldsApp.AccessibilityUrl,
                "alternativeDistributionKey" => BuildsGetInstanceFieldsApp.AlternativeDistributionKey,
                "analyticsReportRequests" => BuildsGetInstanceFieldsApp.AnalyticsReportRequests,
                "androidToIosAppMappingDetails" => BuildsGetInstanceFieldsApp.AndroidToIosAppMappingDetails,
                "appAvailabilityV2" => BuildsGetInstanceFieldsApp.AppAvailabilityV2,
                "appClips" => BuildsGetInstanceFieldsApp.AppClips,
                "appCustomProductPages" => BuildsGetInstanceFieldsApp.AppCustomProductPages,
                "appEncryptionDeclarations" => BuildsGetInstanceFieldsApp.AppEncryptionDeclarations,
                "appEvents" => BuildsGetInstanceFieldsApp.AppEvents,
                "appInfos" => BuildsGetInstanceFieldsApp.AppInfos,
                "appPricePoints" => BuildsGetInstanceFieldsApp.AppPricePoints,
                "appPriceSchedule" => BuildsGetInstanceFieldsApp.AppPriceSchedule,
                "appStoreIcon" => BuildsGetInstanceFieldsApp.AppStoreIcon,
                "appStoreVersionExperimentsV2" => BuildsGetInstanceFieldsApp.AppStoreVersionExperimentsV2,
                "appStoreVersions" => BuildsGetInstanceFieldsApp.AppStoreVersions,
                "appTags" => BuildsGetInstanceFieldsApp.AppTags,
                "backgroundAssets" => BuildsGetInstanceFieldsApp.BackgroundAssets,
                "betaAppLocalizations" => BuildsGetInstanceFieldsApp.BetaAppLocalizations,
                "betaAppReviewDetail" => BuildsGetInstanceFieldsApp.BetaAppReviewDetail,
                "betaFeedbackCrashSubmissions" => BuildsGetInstanceFieldsApp.BetaFeedbackCrashSubmissions,
                "betaFeedbackScreenshotSubmissions" => BuildsGetInstanceFieldsApp.BetaFeedbackScreenshotSubmissions,
                "betaGroups" => BuildsGetInstanceFieldsApp.BetaGroups,
                "betaLicenseAgreement" => BuildsGetInstanceFieldsApp.BetaLicenseAgreement,
                "betaTesters" => BuildsGetInstanceFieldsApp.BetaTesters,
                "buildUploads" => BuildsGetInstanceFieldsApp.BuildUploads,
                "builds" => BuildsGetInstanceFieldsApp.Builds,
                "bundleId" => BuildsGetInstanceFieldsApp.BundleId,
                "ciProduct" => BuildsGetInstanceFieldsApp.CiProduct,
                "contentRightsDeclaration" => BuildsGetInstanceFieldsApp.ContentRightsDeclaration,
                "customerReviewSummarizations" => BuildsGetInstanceFieldsApp.CustomerReviewSummarizations,
                "customerReviews" => BuildsGetInstanceFieldsApp.CustomerReviews,
                "endUserLicenseAgreement" => BuildsGetInstanceFieldsApp.EndUserLicenseAgreement,
                "gameCenterDetail" => BuildsGetInstanceFieldsApp.GameCenterDetail,
                "gameCenterEnabledVersions" => BuildsGetInstanceFieldsApp.GameCenterEnabledVersions,
                "inAppPurchases" => BuildsGetInstanceFieldsApp.InAppPurchases,
                "inAppPurchasesV2" => BuildsGetInstanceFieldsApp.InAppPurchasesV2,
                "isOrEverWasMadeForKids" => BuildsGetInstanceFieldsApp.IsOrEverWasMadeForKids,
                "marketplaceSearchDetail" => BuildsGetInstanceFieldsApp.MarketplaceSearchDetail,
                "name" => BuildsGetInstanceFieldsApp.Name,
                "perfPowerMetrics" => BuildsGetInstanceFieldsApp.PerfPowerMetrics,
                "preReleaseVersions" => BuildsGetInstanceFieldsApp.PreReleaseVersions,
                "primaryLocale" => BuildsGetInstanceFieldsApp.PrimaryLocale,
                "promotedPurchases" => BuildsGetInstanceFieldsApp.PromotedPurchases,
                "reviewSubmissions" => BuildsGetInstanceFieldsApp.ReviewSubmissions,
                "searchKeywords" => BuildsGetInstanceFieldsApp.SearchKeywords,
                "sku" => BuildsGetInstanceFieldsApp.Sku,
                "streamlinedPurchasingEnabled" => BuildsGetInstanceFieldsApp.StreamlinedPurchasingEnabled,
                "subscriptionGracePeriod" => BuildsGetInstanceFieldsApp.SubscriptionGracePeriod,
                "subscriptionGroups" => BuildsGetInstanceFieldsApp.SubscriptionGroups,
                "subscriptionStatusUrl" => BuildsGetInstanceFieldsApp.SubscriptionStatusUrl,
                "subscriptionStatusUrlForSandbox" => BuildsGetInstanceFieldsApp.SubscriptionStatusUrlForSandbox,
                "subscriptionStatusUrlVersion" => BuildsGetInstanceFieldsApp.SubscriptionStatusUrlVersion,
                "subscriptionStatusUrlVersionForSandbox" => BuildsGetInstanceFieldsApp.SubscriptionStatusUrlVersionForSandbox,
                "webhooks" => BuildsGetInstanceFieldsApp.Webhooks,
                _ => null,
            };
        }
    }
}