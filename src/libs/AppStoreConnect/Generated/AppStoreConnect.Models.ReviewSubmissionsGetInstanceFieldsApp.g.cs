
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReviewSubmissionsGetInstanceFieldsApp
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
    public static class ReviewSubmissionsGetInstanceFieldsAppExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionsGetInstanceFieldsApp value)
        {
            return value switch
            {
                ReviewSubmissionsGetInstanceFieldsApp.AccessibilityDeclarations => "accessibilityDeclarations",
                ReviewSubmissionsGetInstanceFieldsApp.AccessibilityUrl => "accessibilityUrl",
                ReviewSubmissionsGetInstanceFieldsApp.AlternativeDistributionKey => "alternativeDistributionKey",
                ReviewSubmissionsGetInstanceFieldsApp.AnalyticsReportRequests => "analyticsReportRequests",
                ReviewSubmissionsGetInstanceFieldsApp.AndroidToIosAppMappingDetails => "androidToIosAppMappingDetails",
                ReviewSubmissionsGetInstanceFieldsApp.AppAvailabilityV2 => "appAvailabilityV2",
                ReviewSubmissionsGetInstanceFieldsApp.AppClips => "appClips",
                ReviewSubmissionsGetInstanceFieldsApp.AppCustomProductPages => "appCustomProductPages",
                ReviewSubmissionsGetInstanceFieldsApp.AppEncryptionDeclarations => "appEncryptionDeclarations",
                ReviewSubmissionsGetInstanceFieldsApp.AppEvents => "appEvents",
                ReviewSubmissionsGetInstanceFieldsApp.AppInfos => "appInfos",
                ReviewSubmissionsGetInstanceFieldsApp.AppPricePoints => "appPricePoints",
                ReviewSubmissionsGetInstanceFieldsApp.AppPriceSchedule => "appPriceSchedule",
                ReviewSubmissionsGetInstanceFieldsApp.AppStoreIcon => "appStoreIcon",
                ReviewSubmissionsGetInstanceFieldsApp.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                ReviewSubmissionsGetInstanceFieldsApp.AppStoreVersions => "appStoreVersions",
                ReviewSubmissionsGetInstanceFieldsApp.AppTags => "appTags",
                ReviewSubmissionsGetInstanceFieldsApp.BackgroundAssets => "backgroundAssets",
                ReviewSubmissionsGetInstanceFieldsApp.BetaAppLocalizations => "betaAppLocalizations",
                ReviewSubmissionsGetInstanceFieldsApp.BetaAppReviewDetail => "betaAppReviewDetail",
                ReviewSubmissionsGetInstanceFieldsApp.BetaFeedbackCrashSubmissions => "betaFeedbackCrashSubmissions",
                ReviewSubmissionsGetInstanceFieldsApp.BetaFeedbackScreenshotSubmissions => "betaFeedbackScreenshotSubmissions",
                ReviewSubmissionsGetInstanceFieldsApp.BetaGroups => "betaGroups",
                ReviewSubmissionsGetInstanceFieldsApp.BetaLicenseAgreement => "betaLicenseAgreement",
                ReviewSubmissionsGetInstanceFieldsApp.BetaTesters => "betaTesters",
                ReviewSubmissionsGetInstanceFieldsApp.BuildUploads => "buildUploads",
                ReviewSubmissionsGetInstanceFieldsApp.Builds => "builds",
                ReviewSubmissionsGetInstanceFieldsApp.BundleId => "bundleId",
                ReviewSubmissionsGetInstanceFieldsApp.CiProduct => "ciProduct",
                ReviewSubmissionsGetInstanceFieldsApp.ContentRightsDeclaration => "contentRightsDeclaration",
                ReviewSubmissionsGetInstanceFieldsApp.CustomerReviewSummarizations => "customerReviewSummarizations",
                ReviewSubmissionsGetInstanceFieldsApp.CustomerReviews => "customerReviews",
                ReviewSubmissionsGetInstanceFieldsApp.EndUserLicenseAgreement => "endUserLicenseAgreement",
                ReviewSubmissionsGetInstanceFieldsApp.GameCenterDetail => "gameCenterDetail",
                ReviewSubmissionsGetInstanceFieldsApp.GameCenterEnabledVersions => "gameCenterEnabledVersions",
                ReviewSubmissionsGetInstanceFieldsApp.InAppPurchases => "inAppPurchases",
                ReviewSubmissionsGetInstanceFieldsApp.InAppPurchasesV2 => "inAppPurchasesV2",
                ReviewSubmissionsGetInstanceFieldsApp.IsOrEverWasMadeForKids => "isOrEverWasMadeForKids",
                ReviewSubmissionsGetInstanceFieldsApp.MarketplaceSearchDetail => "marketplaceSearchDetail",
                ReviewSubmissionsGetInstanceFieldsApp.Name => "name",
                ReviewSubmissionsGetInstanceFieldsApp.PerfPowerMetrics => "perfPowerMetrics",
                ReviewSubmissionsGetInstanceFieldsApp.PreReleaseVersions => "preReleaseVersions",
                ReviewSubmissionsGetInstanceFieldsApp.PrimaryLocale => "primaryLocale",
                ReviewSubmissionsGetInstanceFieldsApp.PromotedPurchases => "promotedPurchases",
                ReviewSubmissionsGetInstanceFieldsApp.ReviewSubmissions => "reviewSubmissions",
                ReviewSubmissionsGetInstanceFieldsApp.SearchKeywords => "searchKeywords",
                ReviewSubmissionsGetInstanceFieldsApp.Sku => "sku",
                ReviewSubmissionsGetInstanceFieldsApp.StreamlinedPurchasingEnabled => "streamlinedPurchasingEnabled",
                ReviewSubmissionsGetInstanceFieldsApp.SubscriptionGracePeriod => "subscriptionGracePeriod",
                ReviewSubmissionsGetInstanceFieldsApp.SubscriptionGroups => "subscriptionGroups",
                ReviewSubmissionsGetInstanceFieldsApp.SubscriptionStatusUrl => "subscriptionStatusUrl",
                ReviewSubmissionsGetInstanceFieldsApp.SubscriptionStatusUrlForSandbox => "subscriptionStatusUrlForSandbox",
                ReviewSubmissionsGetInstanceFieldsApp.SubscriptionStatusUrlVersion => "subscriptionStatusUrlVersion",
                ReviewSubmissionsGetInstanceFieldsApp.SubscriptionStatusUrlVersionForSandbox => "subscriptionStatusUrlVersionForSandbox",
                ReviewSubmissionsGetInstanceFieldsApp.Webhooks => "webhooks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionsGetInstanceFieldsApp? ToEnum(string value)
        {
            return value switch
            {
                "accessibilityDeclarations" => ReviewSubmissionsGetInstanceFieldsApp.AccessibilityDeclarations,
                "accessibilityUrl" => ReviewSubmissionsGetInstanceFieldsApp.AccessibilityUrl,
                "alternativeDistributionKey" => ReviewSubmissionsGetInstanceFieldsApp.AlternativeDistributionKey,
                "analyticsReportRequests" => ReviewSubmissionsGetInstanceFieldsApp.AnalyticsReportRequests,
                "androidToIosAppMappingDetails" => ReviewSubmissionsGetInstanceFieldsApp.AndroidToIosAppMappingDetails,
                "appAvailabilityV2" => ReviewSubmissionsGetInstanceFieldsApp.AppAvailabilityV2,
                "appClips" => ReviewSubmissionsGetInstanceFieldsApp.AppClips,
                "appCustomProductPages" => ReviewSubmissionsGetInstanceFieldsApp.AppCustomProductPages,
                "appEncryptionDeclarations" => ReviewSubmissionsGetInstanceFieldsApp.AppEncryptionDeclarations,
                "appEvents" => ReviewSubmissionsGetInstanceFieldsApp.AppEvents,
                "appInfos" => ReviewSubmissionsGetInstanceFieldsApp.AppInfos,
                "appPricePoints" => ReviewSubmissionsGetInstanceFieldsApp.AppPricePoints,
                "appPriceSchedule" => ReviewSubmissionsGetInstanceFieldsApp.AppPriceSchedule,
                "appStoreIcon" => ReviewSubmissionsGetInstanceFieldsApp.AppStoreIcon,
                "appStoreVersionExperimentsV2" => ReviewSubmissionsGetInstanceFieldsApp.AppStoreVersionExperimentsV2,
                "appStoreVersions" => ReviewSubmissionsGetInstanceFieldsApp.AppStoreVersions,
                "appTags" => ReviewSubmissionsGetInstanceFieldsApp.AppTags,
                "backgroundAssets" => ReviewSubmissionsGetInstanceFieldsApp.BackgroundAssets,
                "betaAppLocalizations" => ReviewSubmissionsGetInstanceFieldsApp.BetaAppLocalizations,
                "betaAppReviewDetail" => ReviewSubmissionsGetInstanceFieldsApp.BetaAppReviewDetail,
                "betaFeedbackCrashSubmissions" => ReviewSubmissionsGetInstanceFieldsApp.BetaFeedbackCrashSubmissions,
                "betaFeedbackScreenshotSubmissions" => ReviewSubmissionsGetInstanceFieldsApp.BetaFeedbackScreenshotSubmissions,
                "betaGroups" => ReviewSubmissionsGetInstanceFieldsApp.BetaGroups,
                "betaLicenseAgreement" => ReviewSubmissionsGetInstanceFieldsApp.BetaLicenseAgreement,
                "betaTesters" => ReviewSubmissionsGetInstanceFieldsApp.BetaTesters,
                "buildUploads" => ReviewSubmissionsGetInstanceFieldsApp.BuildUploads,
                "builds" => ReviewSubmissionsGetInstanceFieldsApp.Builds,
                "bundleId" => ReviewSubmissionsGetInstanceFieldsApp.BundleId,
                "ciProduct" => ReviewSubmissionsGetInstanceFieldsApp.CiProduct,
                "contentRightsDeclaration" => ReviewSubmissionsGetInstanceFieldsApp.ContentRightsDeclaration,
                "customerReviewSummarizations" => ReviewSubmissionsGetInstanceFieldsApp.CustomerReviewSummarizations,
                "customerReviews" => ReviewSubmissionsGetInstanceFieldsApp.CustomerReviews,
                "endUserLicenseAgreement" => ReviewSubmissionsGetInstanceFieldsApp.EndUserLicenseAgreement,
                "gameCenterDetail" => ReviewSubmissionsGetInstanceFieldsApp.GameCenterDetail,
                "gameCenterEnabledVersions" => ReviewSubmissionsGetInstanceFieldsApp.GameCenterEnabledVersions,
                "inAppPurchases" => ReviewSubmissionsGetInstanceFieldsApp.InAppPurchases,
                "inAppPurchasesV2" => ReviewSubmissionsGetInstanceFieldsApp.InAppPurchasesV2,
                "isOrEverWasMadeForKids" => ReviewSubmissionsGetInstanceFieldsApp.IsOrEverWasMadeForKids,
                "marketplaceSearchDetail" => ReviewSubmissionsGetInstanceFieldsApp.MarketplaceSearchDetail,
                "name" => ReviewSubmissionsGetInstanceFieldsApp.Name,
                "perfPowerMetrics" => ReviewSubmissionsGetInstanceFieldsApp.PerfPowerMetrics,
                "preReleaseVersions" => ReviewSubmissionsGetInstanceFieldsApp.PreReleaseVersions,
                "primaryLocale" => ReviewSubmissionsGetInstanceFieldsApp.PrimaryLocale,
                "promotedPurchases" => ReviewSubmissionsGetInstanceFieldsApp.PromotedPurchases,
                "reviewSubmissions" => ReviewSubmissionsGetInstanceFieldsApp.ReviewSubmissions,
                "searchKeywords" => ReviewSubmissionsGetInstanceFieldsApp.SearchKeywords,
                "sku" => ReviewSubmissionsGetInstanceFieldsApp.Sku,
                "streamlinedPurchasingEnabled" => ReviewSubmissionsGetInstanceFieldsApp.StreamlinedPurchasingEnabled,
                "subscriptionGracePeriod" => ReviewSubmissionsGetInstanceFieldsApp.SubscriptionGracePeriod,
                "subscriptionGroups" => ReviewSubmissionsGetInstanceFieldsApp.SubscriptionGroups,
                "subscriptionStatusUrl" => ReviewSubmissionsGetInstanceFieldsApp.SubscriptionStatusUrl,
                "subscriptionStatusUrlForSandbox" => ReviewSubmissionsGetInstanceFieldsApp.SubscriptionStatusUrlForSandbox,
                "subscriptionStatusUrlVersion" => ReviewSubmissionsGetInstanceFieldsApp.SubscriptionStatusUrlVersion,
                "subscriptionStatusUrlVersionForSandbox" => ReviewSubmissionsGetInstanceFieldsApp.SubscriptionStatusUrlVersionForSandbox,
                "webhooks" => ReviewSubmissionsGetInstanceFieldsApp.Webhooks,
                _ => null,
            };
        }
    }
}