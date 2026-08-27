
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaLicenseAgreementsGetInstanceFieldsApp
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
    public static class BetaLicenseAgreementsGetInstanceFieldsAppExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaLicenseAgreementsGetInstanceFieldsApp value)
        {
            return value switch
            {
                BetaLicenseAgreementsGetInstanceFieldsApp.AccessibilityDeclarations => "accessibilityDeclarations",
                BetaLicenseAgreementsGetInstanceFieldsApp.AccessibilityUrl => "accessibilityUrl",
                BetaLicenseAgreementsGetInstanceFieldsApp.AlternativeDistributionKey => "alternativeDistributionKey",
                BetaLicenseAgreementsGetInstanceFieldsApp.AnalyticsReportRequests => "analyticsReportRequests",
                BetaLicenseAgreementsGetInstanceFieldsApp.AndroidToIosAppMappingDetails => "androidToIosAppMappingDetails",
                BetaLicenseAgreementsGetInstanceFieldsApp.AppAvailabilityV2 => "appAvailabilityV2",
                BetaLicenseAgreementsGetInstanceFieldsApp.AppClips => "appClips",
                BetaLicenseAgreementsGetInstanceFieldsApp.AppCustomProductPages => "appCustomProductPages",
                BetaLicenseAgreementsGetInstanceFieldsApp.AppEncryptionDeclarations => "appEncryptionDeclarations",
                BetaLicenseAgreementsGetInstanceFieldsApp.AppEvents => "appEvents",
                BetaLicenseAgreementsGetInstanceFieldsApp.AppInfos => "appInfos",
                BetaLicenseAgreementsGetInstanceFieldsApp.AppPricePoints => "appPricePoints",
                BetaLicenseAgreementsGetInstanceFieldsApp.AppPriceSchedule => "appPriceSchedule",
                BetaLicenseAgreementsGetInstanceFieldsApp.AppStoreIcon => "appStoreIcon",
                BetaLicenseAgreementsGetInstanceFieldsApp.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                BetaLicenseAgreementsGetInstanceFieldsApp.AppStoreVersions => "appStoreVersions",
                BetaLicenseAgreementsGetInstanceFieldsApp.AppTags => "appTags",
                BetaLicenseAgreementsGetInstanceFieldsApp.BackgroundAssets => "backgroundAssets",
                BetaLicenseAgreementsGetInstanceFieldsApp.BetaAppLocalizations => "betaAppLocalizations",
                BetaLicenseAgreementsGetInstanceFieldsApp.BetaAppReviewDetail => "betaAppReviewDetail",
                BetaLicenseAgreementsGetInstanceFieldsApp.BetaFeedbackCrashSubmissions => "betaFeedbackCrashSubmissions",
                BetaLicenseAgreementsGetInstanceFieldsApp.BetaFeedbackScreenshotSubmissions => "betaFeedbackScreenshotSubmissions",
                BetaLicenseAgreementsGetInstanceFieldsApp.BetaGroups => "betaGroups",
                BetaLicenseAgreementsGetInstanceFieldsApp.BetaLicenseAgreement => "betaLicenseAgreement",
                BetaLicenseAgreementsGetInstanceFieldsApp.BetaTesters => "betaTesters",
                BetaLicenseAgreementsGetInstanceFieldsApp.BuildUploads => "buildUploads",
                BetaLicenseAgreementsGetInstanceFieldsApp.Builds => "builds",
                BetaLicenseAgreementsGetInstanceFieldsApp.BundleId => "bundleId",
                BetaLicenseAgreementsGetInstanceFieldsApp.CiProduct => "ciProduct",
                BetaLicenseAgreementsGetInstanceFieldsApp.ContentRightsDeclaration => "contentRightsDeclaration",
                BetaLicenseAgreementsGetInstanceFieldsApp.CustomerReviewSummarizations => "customerReviewSummarizations",
                BetaLicenseAgreementsGetInstanceFieldsApp.CustomerReviews => "customerReviews",
                BetaLicenseAgreementsGetInstanceFieldsApp.EndUserLicenseAgreement => "endUserLicenseAgreement",
                BetaLicenseAgreementsGetInstanceFieldsApp.GameCenterDetail => "gameCenterDetail",
                BetaLicenseAgreementsGetInstanceFieldsApp.GameCenterEnabledVersions => "gameCenterEnabledVersions",
                BetaLicenseAgreementsGetInstanceFieldsApp.InAppPurchases => "inAppPurchases",
                BetaLicenseAgreementsGetInstanceFieldsApp.InAppPurchasesV2 => "inAppPurchasesV2",
                BetaLicenseAgreementsGetInstanceFieldsApp.IsOrEverWasMadeForKids => "isOrEverWasMadeForKids",
                BetaLicenseAgreementsGetInstanceFieldsApp.MarketplaceSearchDetail => "marketplaceSearchDetail",
                BetaLicenseAgreementsGetInstanceFieldsApp.Name => "name",
                BetaLicenseAgreementsGetInstanceFieldsApp.PerfPowerMetrics => "perfPowerMetrics",
                BetaLicenseAgreementsGetInstanceFieldsApp.PreReleaseVersions => "preReleaseVersions",
                BetaLicenseAgreementsGetInstanceFieldsApp.PrimaryLocale => "primaryLocale",
                BetaLicenseAgreementsGetInstanceFieldsApp.PromotedPurchases => "promotedPurchases",
                BetaLicenseAgreementsGetInstanceFieldsApp.ReviewSubmissions => "reviewSubmissions",
                BetaLicenseAgreementsGetInstanceFieldsApp.SearchKeywords => "searchKeywords",
                BetaLicenseAgreementsGetInstanceFieldsApp.Sku => "sku",
                BetaLicenseAgreementsGetInstanceFieldsApp.StreamlinedPurchasingEnabled => "streamlinedPurchasingEnabled",
                BetaLicenseAgreementsGetInstanceFieldsApp.SubscriptionGracePeriod => "subscriptionGracePeriod",
                BetaLicenseAgreementsGetInstanceFieldsApp.SubscriptionGroups => "subscriptionGroups",
                BetaLicenseAgreementsGetInstanceFieldsApp.SubscriptionStatusUrl => "subscriptionStatusUrl",
                BetaLicenseAgreementsGetInstanceFieldsApp.SubscriptionStatusUrlForSandbox => "subscriptionStatusUrlForSandbox",
                BetaLicenseAgreementsGetInstanceFieldsApp.SubscriptionStatusUrlVersion => "subscriptionStatusUrlVersion",
                BetaLicenseAgreementsGetInstanceFieldsApp.SubscriptionStatusUrlVersionForSandbox => "subscriptionStatusUrlVersionForSandbox",
                BetaLicenseAgreementsGetInstanceFieldsApp.Webhooks => "webhooks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaLicenseAgreementsGetInstanceFieldsApp? ToEnum(string value)
        {
            return value switch
            {
                "accessibilityDeclarations" => BetaLicenseAgreementsGetInstanceFieldsApp.AccessibilityDeclarations,
                "accessibilityUrl" => BetaLicenseAgreementsGetInstanceFieldsApp.AccessibilityUrl,
                "alternativeDistributionKey" => BetaLicenseAgreementsGetInstanceFieldsApp.AlternativeDistributionKey,
                "analyticsReportRequests" => BetaLicenseAgreementsGetInstanceFieldsApp.AnalyticsReportRequests,
                "androidToIosAppMappingDetails" => BetaLicenseAgreementsGetInstanceFieldsApp.AndroidToIosAppMappingDetails,
                "appAvailabilityV2" => BetaLicenseAgreementsGetInstanceFieldsApp.AppAvailabilityV2,
                "appClips" => BetaLicenseAgreementsGetInstanceFieldsApp.AppClips,
                "appCustomProductPages" => BetaLicenseAgreementsGetInstanceFieldsApp.AppCustomProductPages,
                "appEncryptionDeclarations" => BetaLicenseAgreementsGetInstanceFieldsApp.AppEncryptionDeclarations,
                "appEvents" => BetaLicenseAgreementsGetInstanceFieldsApp.AppEvents,
                "appInfos" => BetaLicenseAgreementsGetInstanceFieldsApp.AppInfos,
                "appPricePoints" => BetaLicenseAgreementsGetInstanceFieldsApp.AppPricePoints,
                "appPriceSchedule" => BetaLicenseAgreementsGetInstanceFieldsApp.AppPriceSchedule,
                "appStoreIcon" => BetaLicenseAgreementsGetInstanceFieldsApp.AppStoreIcon,
                "appStoreVersionExperimentsV2" => BetaLicenseAgreementsGetInstanceFieldsApp.AppStoreVersionExperimentsV2,
                "appStoreVersions" => BetaLicenseAgreementsGetInstanceFieldsApp.AppStoreVersions,
                "appTags" => BetaLicenseAgreementsGetInstanceFieldsApp.AppTags,
                "backgroundAssets" => BetaLicenseAgreementsGetInstanceFieldsApp.BackgroundAssets,
                "betaAppLocalizations" => BetaLicenseAgreementsGetInstanceFieldsApp.BetaAppLocalizations,
                "betaAppReviewDetail" => BetaLicenseAgreementsGetInstanceFieldsApp.BetaAppReviewDetail,
                "betaFeedbackCrashSubmissions" => BetaLicenseAgreementsGetInstanceFieldsApp.BetaFeedbackCrashSubmissions,
                "betaFeedbackScreenshotSubmissions" => BetaLicenseAgreementsGetInstanceFieldsApp.BetaFeedbackScreenshotSubmissions,
                "betaGroups" => BetaLicenseAgreementsGetInstanceFieldsApp.BetaGroups,
                "betaLicenseAgreement" => BetaLicenseAgreementsGetInstanceFieldsApp.BetaLicenseAgreement,
                "betaTesters" => BetaLicenseAgreementsGetInstanceFieldsApp.BetaTesters,
                "buildUploads" => BetaLicenseAgreementsGetInstanceFieldsApp.BuildUploads,
                "builds" => BetaLicenseAgreementsGetInstanceFieldsApp.Builds,
                "bundleId" => BetaLicenseAgreementsGetInstanceFieldsApp.BundleId,
                "ciProduct" => BetaLicenseAgreementsGetInstanceFieldsApp.CiProduct,
                "contentRightsDeclaration" => BetaLicenseAgreementsGetInstanceFieldsApp.ContentRightsDeclaration,
                "customerReviewSummarizations" => BetaLicenseAgreementsGetInstanceFieldsApp.CustomerReviewSummarizations,
                "customerReviews" => BetaLicenseAgreementsGetInstanceFieldsApp.CustomerReviews,
                "endUserLicenseAgreement" => BetaLicenseAgreementsGetInstanceFieldsApp.EndUserLicenseAgreement,
                "gameCenterDetail" => BetaLicenseAgreementsGetInstanceFieldsApp.GameCenterDetail,
                "gameCenterEnabledVersions" => BetaLicenseAgreementsGetInstanceFieldsApp.GameCenterEnabledVersions,
                "inAppPurchases" => BetaLicenseAgreementsGetInstanceFieldsApp.InAppPurchases,
                "inAppPurchasesV2" => BetaLicenseAgreementsGetInstanceFieldsApp.InAppPurchasesV2,
                "isOrEverWasMadeForKids" => BetaLicenseAgreementsGetInstanceFieldsApp.IsOrEverWasMadeForKids,
                "marketplaceSearchDetail" => BetaLicenseAgreementsGetInstanceFieldsApp.MarketplaceSearchDetail,
                "name" => BetaLicenseAgreementsGetInstanceFieldsApp.Name,
                "perfPowerMetrics" => BetaLicenseAgreementsGetInstanceFieldsApp.PerfPowerMetrics,
                "preReleaseVersions" => BetaLicenseAgreementsGetInstanceFieldsApp.PreReleaseVersions,
                "primaryLocale" => BetaLicenseAgreementsGetInstanceFieldsApp.PrimaryLocale,
                "promotedPurchases" => BetaLicenseAgreementsGetInstanceFieldsApp.PromotedPurchases,
                "reviewSubmissions" => BetaLicenseAgreementsGetInstanceFieldsApp.ReviewSubmissions,
                "searchKeywords" => BetaLicenseAgreementsGetInstanceFieldsApp.SearchKeywords,
                "sku" => BetaLicenseAgreementsGetInstanceFieldsApp.Sku,
                "streamlinedPurchasingEnabled" => BetaLicenseAgreementsGetInstanceFieldsApp.StreamlinedPurchasingEnabled,
                "subscriptionGracePeriod" => BetaLicenseAgreementsGetInstanceFieldsApp.SubscriptionGracePeriod,
                "subscriptionGroups" => BetaLicenseAgreementsGetInstanceFieldsApp.SubscriptionGroups,
                "subscriptionStatusUrl" => BetaLicenseAgreementsGetInstanceFieldsApp.SubscriptionStatusUrl,
                "subscriptionStatusUrlForSandbox" => BetaLicenseAgreementsGetInstanceFieldsApp.SubscriptionStatusUrlForSandbox,
                "subscriptionStatusUrlVersion" => BetaLicenseAgreementsGetInstanceFieldsApp.SubscriptionStatusUrlVersion,
                "subscriptionStatusUrlVersionForSandbox" => BetaLicenseAgreementsGetInstanceFieldsApp.SubscriptionStatusUrlVersionForSandbox,
                "webhooks" => BetaLicenseAgreementsGetInstanceFieldsApp.Webhooks,
                _ => null,
            };
        }
    }
}