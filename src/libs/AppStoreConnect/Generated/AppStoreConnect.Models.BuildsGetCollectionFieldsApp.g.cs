
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildsGetCollectionFieldsApp
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
    public static class BuildsGetCollectionFieldsAppExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildsGetCollectionFieldsApp value)
        {
            return value switch
            {
                BuildsGetCollectionFieldsApp.AccessibilityDeclarations => "accessibilityDeclarations",
                BuildsGetCollectionFieldsApp.AccessibilityUrl => "accessibilityUrl",
                BuildsGetCollectionFieldsApp.AlternativeDistributionKey => "alternativeDistributionKey",
                BuildsGetCollectionFieldsApp.AnalyticsReportRequests => "analyticsReportRequests",
                BuildsGetCollectionFieldsApp.AndroidToIosAppMappingDetails => "androidToIosAppMappingDetails",
                BuildsGetCollectionFieldsApp.AppAvailabilityV2 => "appAvailabilityV2",
                BuildsGetCollectionFieldsApp.AppClips => "appClips",
                BuildsGetCollectionFieldsApp.AppCustomProductPages => "appCustomProductPages",
                BuildsGetCollectionFieldsApp.AppEncryptionDeclarations => "appEncryptionDeclarations",
                BuildsGetCollectionFieldsApp.AppEvents => "appEvents",
                BuildsGetCollectionFieldsApp.AppInfos => "appInfos",
                BuildsGetCollectionFieldsApp.AppPricePoints => "appPricePoints",
                BuildsGetCollectionFieldsApp.AppPriceSchedule => "appPriceSchedule",
                BuildsGetCollectionFieldsApp.AppStoreIcon => "appStoreIcon",
                BuildsGetCollectionFieldsApp.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                BuildsGetCollectionFieldsApp.AppStoreVersions => "appStoreVersions",
                BuildsGetCollectionFieldsApp.AppTags => "appTags",
                BuildsGetCollectionFieldsApp.BackgroundAssets => "backgroundAssets",
                BuildsGetCollectionFieldsApp.BetaAppLocalizations => "betaAppLocalizations",
                BuildsGetCollectionFieldsApp.BetaAppReviewDetail => "betaAppReviewDetail",
                BuildsGetCollectionFieldsApp.BetaFeedbackCrashSubmissions => "betaFeedbackCrashSubmissions",
                BuildsGetCollectionFieldsApp.BetaFeedbackScreenshotSubmissions => "betaFeedbackScreenshotSubmissions",
                BuildsGetCollectionFieldsApp.BetaGroups => "betaGroups",
                BuildsGetCollectionFieldsApp.BetaLicenseAgreement => "betaLicenseAgreement",
                BuildsGetCollectionFieldsApp.BetaTesters => "betaTesters",
                BuildsGetCollectionFieldsApp.BuildUploads => "buildUploads",
                BuildsGetCollectionFieldsApp.Builds => "builds",
                BuildsGetCollectionFieldsApp.BundleId => "bundleId",
                BuildsGetCollectionFieldsApp.CiProduct => "ciProduct",
                BuildsGetCollectionFieldsApp.ContentRightsDeclaration => "contentRightsDeclaration",
                BuildsGetCollectionFieldsApp.CustomerReviewSummarizations => "customerReviewSummarizations",
                BuildsGetCollectionFieldsApp.CustomerReviews => "customerReviews",
                BuildsGetCollectionFieldsApp.EndUserLicenseAgreement => "endUserLicenseAgreement",
                BuildsGetCollectionFieldsApp.GameCenterDetail => "gameCenterDetail",
                BuildsGetCollectionFieldsApp.GameCenterEnabledVersions => "gameCenterEnabledVersions",
                BuildsGetCollectionFieldsApp.InAppPurchases => "inAppPurchases",
                BuildsGetCollectionFieldsApp.InAppPurchasesV2 => "inAppPurchasesV2",
                BuildsGetCollectionFieldsApp.IsOrEverWasMadeForKids => "isOrEverWasMadeForKids",
                BuildsGetCollectionFieldsApp.MarketplaceSearchDetail => "marketplaceSearchDetail",
                BuildsGetCollectionFieldsApp.Name => "name",
                BuildsGetCollectionFieldsApp.PerfPowerMetrics => "perfPowerMetrics",
                BuildsGetCollectionFieldsApp.PreReleaseVersions => "preReleaseVersions",
                BuildsGetCollectionFieldsApp.PrimaryLocale => "primaryLocale",
                BuildsGetCollectionFieldsApp.PromotedPurchases => "promotedPurchases",
                BuildsGetCollectionFieldsApp.ReviewSubmissions => "reviewSubmissions",
                BuildsGetCollectionFieldsApp.SearchKeywords => "searchKeywords",
                BuildsGetCollectionFieldsApp.Sku => "sku",
                BuildsGetCollectionFieldsApp.StreamlinedPurchasingEnabled => "streamlinedPurchasingEnabled",
                BuildsGetCollectionFieldsApp.SubscriptionGracePeriod => "subscriptionGracePeriod",
                BuildsGetCollectionFieldsApp.SubscriptionGroups => "subscriptionGroups",
                BuildsGetCollectionFieldsApp.SubscriptionStatusUrl => "subscriptionStatusUrl",
                BuildsGetCollectionFieldsApp.SubscriptionStatusUrlForSandbox => "subscriptionStatusUrlForSandbox",
                BuildsGetCollectionFieldsApp.SubscriptionStatusUrlVersion => "subscriptionStatusUrlVersion",
                BuildsGetCollectionFieldsApp.SubscriptionStatusUrlVersionForSandbox => "subscriptionStatusUrlVersionForSandbox",
                BuildsGetCollectionFieldsApp.Webhooks => "webhooks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildsGetCollectionFieldsApp? ToEnum(string value)
        {
            return value switch
            {
                "accessibilityDeclarations" => BuildsGetCollectionFieldsApp.AccessibilityDeclarations,
                "accessibilityUrl" => BuildsGetCollectionFieldsApp.AccessibilityUrl,
                "alternativeDistributionKey" => BuildsGetCollectionFieldsApp.AlternativeDistributionKey,
                "analyticsReportRequests" => BuildsGetCollectionFieldsApp.AnalyticsReportRequests,
                "androidToIosAppMappingDetails" => BuildsGetCollectionFieldsApp.AndroidToIosAppMappingDetails,
                "appAvailabilityV2" => BuildsGetCollectionFieldsApp.AppAvailabilityV2,
                "appClips" => BuildsGetCollectionFieldsApp.AppClips,
                "appCustomProductPages" => BuildsGetCollectionFieldsApp.AppCustomProductPages,
                "appEncryptionDeclarations" => BuildsGetCollectionFieldsApp.AppEncryptionDeclarations,
                "appEvents" => BuildsGetCollectionFieldsApp.AppEvents,
                "appInfos" => BuildsGetCollectionFieldsApp.AppInfos,
                "appPricePoints" => BuildsGetCollectionFieldsApp.AppPricePoints,
                "appPriceSchedule" => BuildsGetCollectionFieldsApp.AppPriceSchedule,
                "appStoreIcon" => BuildsGetCollectionFieldsApp.AppStoreIcon,
                "appStoreVersionExperimentsV2" => BuildsGetCollectionFieldsApp.AppStoreVersionExperimentsV2,
                "appStoreVersions" => BuildsGetCollectionFieldsApp.AppStoreVersions,
                "appTags" => BuildsGetCollectionFieldsApp.AppTags,
                "backgroundAssets" => BuildsGetCollectionFieldsApp.BackgroundAssets,
                "betaAppLocalizations" => BuildsGetCollectionFieldsApp.BetaAppLocalizations,
                "betaAppReviewDetail" => BuildsGetCollectionFieldsApp.BetaAppReviewDetail,
                "betaFeedbackCrashSubmissions" => BuildsGetCollectionFieldsApp.BetaFeedbackCrashSubmissions,
                "betaFeedbackScreenshotSubmissions" => BuildsGetCollectionFieldsApp.BetaFeedbackScreenshotSubmissions,
                "betaGroups" => BuildsGetCollectionFieldsApp.BetaGroups,
                "betaLicenseAgreement" => BuildsGetCollectionFieldsApp.BetaLicenseAgreement,
                "betaTesters" => BuildsGetCollectionFieldsApp.BetaTesters,
                "buildUploads" => BuildsGetCollectionFieldsApp.BuildUploads,
                "builds" => BuildsGetCollectionFieldsApp.Builds,
                "bundleId" => BuildsGetCollectionFieldsApp.BundleId,
                "ciProduct" => BuildsGetCollectionFieldsApp.CiProduct,
                "contentRightsDeclaration" => BuildsGetCollectionFieldsApp.ContentRightsDeclaration,
                "customerReviewSummarizations" => BuildsGetCollectionFieldsApp.CustomerReviewSummarizations,
                "customerReviews" => BuildsGetCollectionFieldsApp.CustomerReviews,
                "endUserLicenseAgreement" => BuildsGetCollectionFieldsApp.EndUserLicenseAgreement,
                "gameCenterDetail" => BuildsGetCollectionFieldsApp.GameCenterDetail,
                "gameCenterEnabledVersions" => BuildsGetCollectionFieldsApp.GameCenterEnabledVersions,
                "inAppPurchases" => BuildsGetCollectionFieldsApp.InAppPurchases,
                "inAppPurchasesV2" => BuildsGetCollectionFieldsApp.InAppPurchasesV2,
                "isOrEverWasMadeForKids" => BuildsGetCollectionFieldsApp.IsOrEverWasMadeForKids,
                "marketplaceSearchDetail" => BuildsGetCollectionFieldsApp.MarketplaceSearchDetail,
                "name" => BuildsGetCollectionFieldsApp.Name,
                "perfPowerMetrics" => BuildsGetCollectionFieldsApp.PerfPowerMetrics,
                "preReleaseVersions" => BuildsGetCollectionFieldsApp.PreReleaseVersions,
                "primaryLocale" => BuildsGetCollectionFieldsApp.PrimaryLocale,
                "promotedPurchases" => BuildsGetCollectionFieldsApp.PromotedPurchases,
                "reviewSubmissions" => BuildsGetCollectionFieldsApp.ReviewSubmissions,
                "searchKeywords" => BuildsGetCollectionFieldsApp.SearchKeywords,
                "sku" => BuildsGetCollectionFieldsApp.Sku,
                "streamlinedPurchasingEnabled" => BuildsGetCollectionFieldsApp.StreamlinedPurchasingEnabled,
                "subscriptionGracePeriod" => BuildsGetCollectionFieldsApp.SubscriptionGracePeriod,
                "subscriptionGroups" => BuildsGetCollectionFieldsApp.SubscriptionGroups,
                "subscriptionStatusUrl" => BuildsGetCollectionFieldsApp.SubscriptionStatusUrl,
                "subscriptionStatusUrlForSandbox" => BuildsGetCollectionFieldsApp.SubscriptionStatusUrlForSandbox,
                "subscriptionStatusUrlVersion" => BuildsGetCollectionFieldsApp.SubscriptionStatusUrlVersion,
                "subscriptionStatusUrlVersionForSandbox" => BuildsGetCollectionFieldsApp.SubscriptionStatusUrlVersionForSandbox,
                "webhooks" => BuildsGetCollectionFieldsApp.Webhooks,
                _ => null,
            };
        }
    }
}