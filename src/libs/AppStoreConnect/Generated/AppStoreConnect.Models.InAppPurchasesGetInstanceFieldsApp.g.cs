
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchasesGetInstanceFieldsApp
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
    public static class InAppPurchasesGetInstanceFieldsAppExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasesGetInstanceFieldsApp value)
        {
            return value switch
            {
                InAppPurchasesGetInstanceFieldsApp.AccessibilityDeclarations => "accessibilityDeclarations",
                InAppPurchasesGetInstanceFieldsApp.AccessibilityUrl => "accessibilityUrl",
                InAppPurchasesGetInstanceFieldsApp.AlternativeDistributionKey => "alternativeDistributionKey",
                InAppPurchasesGetInstanceFieldsApp.AnalyticsReportRequests => "analyticsReportRequests",
                InAppPurchasesGetInstanceFieldsApp.AndroidToIosAppMappingDetails => "androidToIosAppMappingDetails",
                InAppPurchasesGetInstanceFieldsApp.AppAvailabilityV2 => "appAvailabilityV2",
                InAppPurchasesGetInstanceFieldsApp.AppClips => "appClips",
                InAppPurchasesGetInstanceFieldsApp.AppCustomProductPages => "appCustomProductPages",
                InAppPurchasesGetInstanceFieldsApp.AppEncryptionDeclarations => "appEncryptionDeclarations",
                InAppPurchasesGetInstanceFieldsApp.AppEvents => "appEvents",
                InAppPurchasesGetInstanceFieldsApp.AppInfos => "appInfos",
                InAppPurchasesGetInstanceFieldsApp.AppPricePoints => "appPricePoints",
                InAppPurchasesGetInstanceFieldsApp.AppPriceSchedule => "appPriceSchedule",
                InAppPurchasesGetInstanceFieldsApp.AppStoreIcon => "appStoreIcon",
                InAppPurchasesGetInstanceFieldsApp.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                InAppPurchasesGetInstanceFieldsApp.AppStoreVersions => "appStoreVersions",
                InAppPurchasesGetInstanceFieldsApp.AppTags => "appTags",
                InAppPurchasesGetInstanceFieldsApp.BackgroundAssets => "backgroundAssets",
                InAppPurchasesGetInstanceFieldsApp.BetaAppLocalizations => "betaAppLocalizations",
                InAppPurchasesGetInstanceFieldsApp.BetaAppReviewDetail => "betaAppReviewDetail",
                InAppPurchasesGetInstanceFieldsApp.BetaFeedbackCrashSubmissions => "betaFeedbackCrashSubmissions",
                InAppPurchasesGetInstanceFieldsApp.BetaFeedbackScreenshotSubmissions => "betaFeedbackScreenshotSubmissions",
                InAppPurchasesGetInstanceFieldsApp.BetaGroups => "betaGroups",
                InAppPurchasesGetInstanceFieldsApp.BetaLicenseAgreement => "betaLicenseAgreement",
                InAppPurchasesGetInstanceFieldsApp.BetaTesters => "betaTesters",
                InAppPurchasesGetInstanceFieldsApp.BuildUploads => "buildUploads",
                InAppPurchasesGetInstanceFieldsApp.Builds => "builds",
                InAppPurchasesGetInstanceFieldsApp.BundleId => "bundleId",
                InAppPurchasesGetInstanceFieldsApp.CiProduct => "ciProduct",
                InAppPurchasesGetInstanceFieldsApp.ContentRightsDeclaration => "contentRightsDeclaration",
                InAppPurchasesGetInstanceFieldsApp.CustomerReviewSummarizations => "customerReviewSummarizations",
                InAppPurchasesGetInstanceFieldsApp.CustomerReviews => "customerReviews",
                InAppPurchasesGetInstanceFieldsApp.EndUserLicenseAgreement => "endUserLicenseAgreement",
                InAppPurchasesGetInstanceFieldsApp.GameCenterDetail => "gameCenterDetail",
                InAppPurchasesGetInstanceFieldsApp.GameCenterEnabledVersions => "gameCenterEnabledVersions",
                InAppPurchasesGetInstanceFieldsApp.InAppPurchases => "inAppPurchases",
                InAppPurchasesGetInstanceFieldsApp.InAppPurchasesV2 => "inAppPurchasesV2",
                InAppPurchasesGetInstanceFieldsApp.IsOrEverWasMadeForKids => "isOrEverWasMadeForKids",
                InAppPurchasesGetInstanceFieldsApp.MarketplaceSearchDetail => "marketplaceSearchDetail",
                InAppPurchasesGetInstanceFieldsApp.Name => "name",
                InAppPurchasesGetInstanceFieldsApp.PerfPowerMetrics => "perfPowerMetrics",
                InAppPurchasesGetInstanceFieldsApp.PreReleaseVersions => "preReleaseVersions",
                InAppPurchasesGetInstanceFieldsApp.PrimaryLocale => "primaryLocale",
                InAppPurchasesGetInstanceFieldsApp.PromotedPurchases => "promotedPurchases",
                InAppPurchasesGetInstanceFieldsApp.ReviewSubmissions => "reviewSubmissions",
                InAppPurchasesGetInstanceFieldsApp.SearchKeywords => "searchKeywords",
                InAppPurchasesGetInstanceFieldsApp.Sku => "sku",
                InAppPurchasesGetInstanceFieldsApp.StreamlinedPurchasingEnabled => "streamlinedPurchasingEnabled",
                InAppPurchasesGetInstanceFieldsApp.SubscriptionGracePeriod => "subscriptionGracePeriod",
                InAppPurchasesGetInstanceFieldsApp.SubscriptionGroups => "subscriptionGroups",
                InAppPurchasesGetInstanceFieldsApp.SubscriptionStatusUrl => "subscriptionStatusUrl",
                InAppPurchasesGetInstanceFieldsApp.SubscriptionStatusUrlForSandbox => "subscriptionStatusUrlForSandbox",
                InAppPurchasesGetInstanceFieldsApp.SubscriptionStatusUrlVersion => "subscriptionStatusUrlVersion",
                InAppPurchasesGetInstanceFieldsApp.SubscriptionStatusUrlVersionForSandbox => "subscriptionStatusUrlVersionForSandbox",
                InAppPurchasesGetInstanceFieldsApp.Webhooks => "webhooks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasesGetInstanceFieldsApp? ToEnum(string value)
        {
            return value switch
            {
                "accessibilityDeclarations" => InAppPurchasesGetInstanceFieldsApp.AccessibilityDeclarations,
                "accessibilityUrl" => InAppPurchasesGetInstanceFieldsApp.AccessibilityUrl,
                "alternativeDistributionKey" => InAppPurchasesGetInstanceFieldsApp.AlternativeDistributionKey,
                "analyticsReportRequests" => InAppPurchasesGetInstanceFieldsApp.AnalyticsReportRequests,
                "androidToIosAppMappingDetails" => InAppPurchasesGetInstanceFieldsApp.AndroidToIosAppMappingDetails,
                "appAvailabilityV2" => InAppPurchasesGetInstanceFieldsApp.AppAvailabilityV2,
                "appClips" => InAppPurchasesGetInstanceFieldsApp.AppClips,
                "appCustomProductPages" => InAppPurchasesGetInstanceFieldsApp.AppCustomProductPages,
                "appEncryptionDeclarations" => InAppPurchasesGetInstanceFieldsApp.AppEncryptionDeclarations,
                "appEvents" => InAppPurchasesGetInstanceFieldsApp.AppEvents,
                "appInfos" => InAppPurchasesGetInstanceFieldsApp.AppInfos,
                "appPricePoints" => InAppPurchasesGetInstanceFieldsApp.AppPricePoints,
                "appPriceSchedule" => InAppPurchasesGetInstanceFieldsApp.AppPriceSchedule,
                "appStoreIcon" => InAppPurchasesGetInstanceFieldsApp.AppStoreIcon,
                "appStoreVersionExperimentsV2" => InAppPurchasesGetInstanceFieldsApp.AppStoreVersionExperimentsV2,
                "appStoreVersions" => InAppPurchasesGetInstanceFieldsApp.AppStoreVersions,
                "appTags" => InAppPurchasesGetInstanceFieldsApp.AppTags,
                "backgroundAssets" => InAppPurchasesGetInstanceFieldsApp.BackgroundAssets,
                "betaAppLocalizations" => InAppPurchasesGetInstanceFieldsApp.BetaAppLocalizations,
                "betaAppReviewDetail" => InAppPurchasesGetInstanceFieldsApp.BetaAppReviewDetail,
                "betaFeedbackCrashSubmissions" => InAppPurchasesGetInstanceFieldsApp.BetaFeedbackCrashSubmissions,
                "betaFeedbackScreenshotSubmissions" => InAppPurchasesGetInstanceFieldsApp.BetaFeedbackScreenshotSubmissions,
                "betaGroups" => InAppPurchasesGetInstanceFieldsApp.BetaGroups,
                "betaLicenseAgreement" => InAppPurchasesGetInstanceFieldsApp.BetaLicenseAgreement,
                "betaTesters" => InAppPurchasesGetInstanceFieldsApp.BetaTesters,
                "buildUploads" => InAppPurchasesGetInstanceFieldsApp.BuildUploads,
                "builds" => InAppPurchasesGetInstanceFieldsApp.Builds,
                "bundleId" => InAppPurchasesGetInstanceFieldsApp.BundleId,
                "ciProduct" => InAppPurchasesGetInstanceFieldsApp.CiProduct,
                "contentRightsDeclaration" => InAppPurchasesGetInstanceFieldsApp.ContentRightsDeclaration,
                "customerReviewSummarizations" => InAppPurchasesGetInstanceFieldsApp.CustomerReviewSummarizations,
                "customerReviews" => InAppPurchasesGetInstanceFieldsApp.CustomerReviews,
                "endUserLicenseAgreement" => InAppPurchasesGetInstanceFieldsApp.EndUserLicenseAgreement,
                "gameCenterDetail" => InAppPurchasesGetInstanceFieldsApp.GameCenterDetail,
                "gameCenterEnabledVersions" => InAppPurchasesGetInstanceFieldsApp.GameCenterEnabledVersions,
                "inAppPurchases" => InAppPurchasesGetInstanceFieldsApp.InAppPurchases,
                "inAppPurchasesV2" => InAppPurchasesGetInstanceFieldsApp.InAppPurchasesV2,
                "isOrEverWasMadeForKids" => InAppPurchasesGetInstanceFieldsApp.IsOrEverWasMadeForKids,
                "marketplaceSearchDetail" => InAppPurchasesGetInstanceFieldsApp.MarketplaceSearchDetail,
                "name" => InAppPurchasesGetInstanceFieldsApp.Name,
                "perfPowerMetrics" => InAppPurchasesGetInstanceFieldsApp.PerfPowerMetrics,
                "preReleaseVersions" => InAppPurchasesGetInstanceFieldsApp.PreReleaseVersions,
                "primaryLocale" => InAppPurchasesGetInstanceFieldsApp.PrimaryLocale,
                "promotedPurchases" => InAppPurchasesGetInstanceFieldsApp.PromotedPurchases,
                "reviewSubmissions" => InAppPurchasesGetInstanceFieldsApp.ReviewSubmissions,
                "searchKeywords" => InAppPurchasesGetInstanceFieldsApp.SearchKeywords,
                "sku" => InAppPurchasesGetInstanceFieldsApp.Sku,
                "streamlinedPurchasingEnabled" => InAppPurchasesGetInstanceFieldsApp.StreamlinedPurchasingEnabled,
                "subscriptionGracePeriod" => InAppPurchasesGetInstanceFieldsApp.SubscriptionGracePeriod,
                "subscriptionGroups" => InAppPurchasesGetInstanceFieldsApp.SubscriptionGroups,
                "subscriptionStatusUrl" => InAppPurchasesGetInstanceFieldsApp.SubscriptionStatusUrl,
                "subscriptionStatusUrlForSandbox" => InAppPurchasesGetInstanceFieldsApp.SubscriptionStatusUrlForSandbox,
                "subscriptionStatusUrlVersion" => InAppPurchasesGetInstanceFieldsApp.SubscriptionStatusUrlVersion,
                "subscriptionStatusUrlVersionForSandbox" => InAppPurchasesGetInstanceFieldsApp.SubscriptionStatusUrlVersionForSandbox,
                "webhooks" => InAppPurchasesGetInstanceFieldsApp.Webhooks,
                _ => null,
            };
        }
    }
}