
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BundleIdsGetCollectionFieldsApp
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
    public static class BundleIdsGetCollectionFieldsAppExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BundleIdsGetCollectionFieldsApp value)
        {
            return value switch
            {
                BundleIdsGetCollectionFieldsApp.AccessibilityDeclarations => "accessibilityDeclarations",
                BundleIdsGetCollectionFieldsApp.AccessibilityUrl => "accessibilityUrl",
                BundleIdsGetCollectionFieldsApp.AlternativeDistributionKey => "alternativeDistributionKey",
                BundleIdsGetCollectionFieldsApp.AnalyticsReportRequests => "analyticsReportRequests",
                BundleIdsGetCollectionFieldsApp.AndroidToIosAppMappingDetails => "androidToIosAppMappingDetails",
                BundleIdsGetCollectionFieldsApp.AppAvailabilityV2 => "appAvailabilityV2",
                BundleIdsGetCollectionFieldsApp.AppClips => "appClips",
                BundleIdsGetCollectionFieldsApp.AppCustomProductPages => "appCustomProductPages",
                BundleIdsGetCollectionFieldsApp.AppEncryptionDeclarations => "appEncryptionDeclarations",
                BundleIdsGetCollectionFieldsApp.AppEvents => "appEvents",
                BundleIdsGetCollectionFieldsApp.AppInfos => "appInfos",
                BundleIdsGetCollectionFieldsApp.AppPricePoints => "appPricePoints",
                BundleIdsGetCollectionFieldsApp.AppPriceSchedule => "appPriceSchedule",
                BundleIdsGetCollectionFieldsApp.AppStoreIcon => "appStoreIcon",
                BundleIdsGetCollectionFieldsApp.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                BundleIdsGetCollectionFieldsApp.AppStoreVersions => "appStoreVersions",
                BundleIdsGetCollectionFieldsApp.AppTags => "appTags",
                BundleIdsGetCollectionFieldsApp.BackgroundAssets => "backgroundAssets",
                BundleIdsGetCollectionFieldsApp.BetaAppLocalizations => "betaAppLocalizations",
                BundleIdsGetCollectionFieldsApp.BetaAppReviewDetail => "betaAppReviewDetail",
                BundleIdsGetCollectionFieldsApp.BetaFeedbackCrashSubmissions => "betaFeedbackCrashSubmissions",
                BundleIdsGetCollectionFieldsApp.BetaFeedbackScreenshotSubmissions => "betaFeedbackScreenshotSubmissions",
                BundleIdsGetCollectionFieldsApp.BetaGroups => "betaGroups",
                BundleIdsGetCollectionFieldsApp.BetaLicenseAgreement => "betaLicenseAgreement",
                BundleIdsGetCollectionFieldsApp.BetaTesters => "betaTesters",
                BundleIdsGetCollectionFieldsApp.BuildUploads => "buildUploads",
                BundleIdsGetCollectionFieldsApp.Builds => "builds",
                BundleIdsGetCollectionFieldsApp.BundleId => "bundleId",
                BundleIdsGetCollectionFieldsApp.CiProduct => "ciProduct",
                BundleIdsGetCollectionFieldsApp.ContentRightsDeclaration => "contentRightsDeclaration",
                BundleIdsGetCollectionFieldsApp.CustomerReviewSummarizations => "customerReviewSummarizations",
                BundleIdsGetCollectionFieldsApp.CustomerReviews => "customerReviews",
                BundleIdsGetCollectionFieldsApp.EndUserLicenseAgreement => "endUserLicenseAgreement",
                BundleIdsGetCollectionFieldsApp.GameCenterDetail => "gameCenterDetail",
                BundleIdsGetCollectionFieldsApp.GameCenterEnabledVersions => "gameCenterEnabledVersions",
                BundleIdsGetCollectionFieldsApp.InAppPurchases => "inAppPurchases",
                BundleIdsGetCollectionFieldsApp.InAppPurchasesV2 => "inAppPurchasesV2",
                BundleIdsGetCollectionFieldsApp.IsOrEverWasMadeForKids => "isOrEverWasMadeForKids",
                BundleIdsGetCollectionFieldsApp.MarketplaceSearchDetail => "marketplaceSearchDetail",
                BundleIdsGetCollectionFieldsApp.Name => "name",
                BundleIdsGetCollectionFieldsApp.PerfPowerMetrics => "perfPowerMetrics",
                BundleIdsGetCollectionFieldsApp.PreReleaseVersions => "preReleaseVersions",
                BundleIdsGetCollectionFieldsApp.PrimaryLocale => "primaryLocale",
                BundleIdsGetCollectionFieldsApp.PromotedPurchases => "promotedPurchases",
                BundleIdsGetCollectionFieldsApp.ReviewSubmissions => "reviewSubmissions",
                BundleIdsGetCollectionFieldsApp.SearchKeywords => "searchKeywords",
                BundleIdsGetCollectionFieldsApp.Sku => "sku",
                BundleIdsGetCollectionFieldsApp.StreamlinedPurchasingEnabled => "streamlinedPurchasingEnabled",
                BundleIdsGetCollectionFieldsApp.SubscriptionGracePeriod => "subscriptionGracePeriod",
                BundleIdsGetCollectionFieldsApp.SubscriptionGroups => "subscriptionGroups",
                BundleIdsGetCollectionFieldsApp.SubscriptionStatusUrl => "subscriptionStatusUrl",
                BundleIdsGetCollectionFieldsApp.SubscriptionStatusUrlForSandbox => "subscriptionStatusUrlForSandbox",
                BundleIdsGetCollectionFieldsApp.SubscriptionStatusUrlVersion => "subscriptionStatusUrlVersion",
                BundleIdsGetCollectionFieldsApp.SubscriptionStatusUrlVersionForSandbox => "subscriptionStatusUrlVersionForSandbox",
                BundleIdsGetCollectionFieldsApp.Webhooks => "webhooks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BundleIdsGetCollectionFieldsApp? ToEnum(string value)
        {
            return value switch
            {
                "accessibilityDeclarations" => BundleIdsGetCollectionFieldsApp.AccessibilityDeclarations,
                "accessibilityUrl" => BundleIdsGetCollectionFieldsApp.AccessibilityUrl,
                "alternativeDistributionKey" => BundleIdsGetCollectionFieldsApp.AlternativeDistributionKey,
                "analyticsReportRequests" => BundleIdsGetCollectionFieldsApp.AnalyticsReportRequests,
                "androidToIosAppMappingDetails" => BundleIdsGetCollectionFieldsApp.AndroidToIosAppMappingDetails,
                "appAvailabilityV2" => BundleIdsGetCollectionFieldsApp.AppAvailabilityV2,
                "appClips" => BundleIdsGetCollectionFieldsApp.AppClips,
                "appCustomProductPages" => BundleIdsGetCollectionFieldsApp.AppCustomProductPages,
                "appEncryptionDeclarations" => BundleIdsGetCollectionFieldsApp.AppEncryptionDeclarations,
                "appEvents" => BundleIdsGetCollectionFieldsApp.AppEvents,
                "appInfos" => BundleIdsGetCollectionFieldsApp.AppInfos,
                "appPricePoints" => BundleIdsGetCollectionFieldsApp.AppPricePoints,
                "appPriceSchedule" => BundleIdsGetCollectionFieldsApp.AppPriceSchedule,
                "appStoreIcon" => BundleIdsGetCollectionFieldsApp.AppStoreIcon,
                "appStoreVersionExperimentsV2" => BundleIdsGetCollectionFieldsApp.AppStoreVersionExperimentsV2,
                "appStoreVersions" => BundleIdsGetCollectionFieldsApp.AppStoreVersions,
                "appTags" => BundleIdsGetCollectionFieldsApp.AppTags,
                "backgroundAssets" => BundleIdsGetCollectionFieldsApp.BackgroundAssets,
                "betaAppLocalizations" => BundleIdsGetCollectionFieldsApp.BetaAppLocalizations,
                "betaAppReviewDetail" => BundleIdsGetCollectionFieldsApp.BetaAppReviewDetail,
                "betaFeedbackCrashSubmissions" => BundleIdsGetCollectionFieldsApp.BetaFeedbackCrashSubmissions,
                "betaFeedbackScreenshotSubmissions" => BundleIdsGetCollectionFieldsApp.BetaFeedbackScreenshotSubmissions,
                "betaGroups" => BundleIdsGetCollectionFieldsApp.BetaGroups,
                "betaLicenseAgreement" => BundleIdsGetCollectionFieldsApp.BetaLicenseAgreement,
                "betaTesters" => BundleIdsGetCollectionFieldsApp.BetaTesters,
                "buildUploads" => BundleIdsGetCollectionFieldsApp.BuildUploads,
                "builds" => BundleIdsGetCollectionFieldsApp.Builds,
                "bundleId" => BundleIdsGetCollectionFieldsApp.BundleId,
                "ciProduct" => BundleIdsGetCollectionFieldsApp.CiProduct,
                "contentRightsDeclaration" => BundleIdsGetCollectionFieldsApp.ContentRightsDeclaration,
                "customerReviewSummarizations" => BundleIdsGetCollectionFieldsApp.CustomerReviewSummarizations,
                "customerReviews" => BundleIdsGetCollectionFieldsApp.CustomerReviews,
                "endUserLicenseAgreement" => BundleIdsGetCollectionFieldsApp.EndUserLicenseAgreement,
                "gameCenterDetail" => BundleIdsGetCollectionFieldsApp.GameCenterDetail,
                "gameCenterEnabledVersions" => BundleIdsGetCollectionFieldsApp.GameCenterEnabledVersions,
                "inAppPurchases" => BundleIdsGetCollectionFieldsApp.InAppPurchases,
                "inAppPurchasesV2" => BundleIdsGetCollectionFieldsApp.InAppPurchasesV2,
                "isOrEverWasMadeForKids" => BundleIdsGetCollectionFieldsApp.IsOrEverWasMadeForKids,
                "marketplaceSearchDetail" => BundleIdsGetCollectionFieldsApp.MarketplaceSearchDetail,
                "name" => BundleIdsGetCollectionFieldsApp.Name,
                "perfPowerMetrics" => BundleIdsGetCollectionFieldsApp.PerfPowerMetrics,
                "preReleaseVersions" => BundleIdsGetCollectionFieldsApp.PreReleaseVersions,
                "primaryLocale" => BundleIdsGetCollectionFieldsApp.PrimaryLocale,
                "promotedPurchases" => BundleIdsGetCollectionFieldsApp.PromotedPurchases,
                "reviewSubmissions" => BundleIdsGetCollectionFieldsApp.ReviewSubmissions,
                "searchKeywords" => BundleIdsGetCollectionFieldsApp.SearchKeywords,
                "sku" => BundleIdsGetCollectionFieldsApp.Sku,
                "streamlinedPurchasingEnabled" => BundleIdsGetCollectionFieldsApp.StreamlinedPurchasingEnabled,
                "subscriptionGracePeriod" => BundleIdsGetCollectionFieldsApp.SubscriptionGracePeriod,
                "subscriptionGroups" => BundleIdsGetCollectionFieldsApp.SubscriptionGroups,
                "subscriptionStatusUrl" => BundleIdsGetCollectionFieldsApp.SubscriptionStatusUrl,
                "subscriptionStatusUrlForSandbox" => BundleIdsGetCollectionFieldsApp.SubscriptionStatusUrlForSandbox,
                "subscriptionStatusUrlVersion" => BundleIdsGetCollectionFieldsApp.SubscriptionStatusUrlVersion,
                "subscriptionStatusUrlVersionForSandbox" => BundleIdsGetCollectionFieldsApp.SubscriptionStatusUrlVersionForSandbox,
                "webhooks" => BundleIdsGetCollectionFieldsApp.Webhooks,
                _ => null,
            };
        }
    }
}