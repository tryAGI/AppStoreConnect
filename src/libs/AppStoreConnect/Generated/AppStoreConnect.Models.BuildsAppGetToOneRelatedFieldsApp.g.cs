
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildsAppGetToOneRelatedFieldsApp
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
    public static class BuildsAppGetToOneRelatedFieldsAppExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildsAppGetToOneRelatedFieldsApp value)
        {
            return value switch
            {
                BuildsAppGetToOneRelatedFieldsApp.AccessibilityDeclarations => "accessibilityDeclarations",
                BuildsAppGetToOneRelatedFieldsApp.AccessibilityUrl => "accessibilityUrl",
                BuildsAppGetToOneRelatedFieldsApp.AlternativeDistributionKey => "alternativeDistributionKey",
                BuildsAppGetToOneRelatedFieldsApp.AnalyticsReportRequests => "analyticsReportRequests",
                BuildsAppGetToOneRelatedFieldsApp.AndroidToIosAppMappingDetails => "androidToIosAppMappingDetails",
                BuildsAppGetToOneRelatedFieldsApp.AppAvailabilityV2 => "appAvailabilityV2",
                BuildsAppGetToOneRelatedFieldsApp.AppClips => "appClips",
                BuildsAppGetToOneRelatedFieldsApp.AppCustomProductPages => "appCustomProductPages",
                BuildsAppGetToOneRelatedFieldsApp.AppEncryptionDeclarations => "appEncryptionDeclarations",
                BuildsAppGetToOneRelatedFieldsApp.AppEvents => "appEvents",
                BuildsAppGetToOneRelatedFieldsApp.AppInfos => "appInfos",
                BuildsAppGetToOneRelatedFieldsApp.AppPricePoints => "appPricePoints",
                BuildsAppGetToOneRelatedFieldsApp.AppPriceSchedule => "appPriceSchedule",
                BuildsAppGetToOneRelatedFieldsApp.AppStoreIcon => "appStoreIcon",
                BuildsAppGetToOneRelatedFieldsApp.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                BuildsAppGetToOneRelatedFieldsApp.AppStoreVersions => "appStoreVersions",
                BuildsAppGetToOneRelatedFieldsApp.AppTags => "appTags",
                BuildsAppGetToOneRelatedFieldsApp.BackgroundAssets => "backgroundAssets",
                BuildsAppGetToOneRelatedFieldsApp.BetaAppLocalizations => "betaAppLocalizations",
                BuildsAppGetToOneRelatedFieldsApp.BetaAppReviewDetail => "betaAppReviewDetail",
                BuildsAppGetToOneRelatedFieldsApp.BetaFeedbackCrashSubmissions => "betaFeedbackCrashSubmissions",
                BuildsAppGetToOneRelatedFieldsApp.BetaFeedbackScreenshotSubmissions => "betaFeedbackScreenshotSubmissions",
                BuildsAppGetToOneRelatedFieldsApp.BetaGroups => "betaGroups",
                BuildsAppGetToOneRelatedFieldsApp.BetaLicenseAgreement => "betaLicenseAgreement",
                BuildsAppGetToOneRelatedFieldsApp.BetaTesters => "betaTesters",
                BuildsAppGetToOneRelatedFieldsApp.BuildUploads => "buildUploads",
                BuildsAppGetToOneRelatedFieldsApp.Builds => "builds",
                BuildsAppGetToOneRelatedFieldsApp.BundleId => "bundleId",
                BuildsAppGetToOneRelatedFieldsApp.CiProduct => "ciProduct",
                BuildsAppGetToOneRelatedFieldsApp.ContentRightsDeclaration => "contentRightsDeclaration",
                BuildsAppGetToOneRelatedFieldsApp.CustomerReviewSummarizations => "customerReviewSummarizations",
                BuildsAppGetToOneRelatedFieldsApp.CustomerReviews => "customerReviews",
                BuildsAppGetToOneRelatedFieldsApp.EndUserLicenseAgreement => "endUserLicenseAgreement",
                BuildsAppGetToOneRelatedFieldsApp.GameCenterDetail => "gameCenterDetail",
                BuildsAppGetToOneRelatedFieldsApp.GameCenterEnabledVersions => "gameCenterEnabledVersions",
                BuildsAppGetToOneRelatedFieldsApp.InAppPurchases => "inAppPurchases",
                BuildsAppGetToOneRelatedFieldsApp.InAppPurchasesV2 => "inAppPurchasesV2",
                BuildsAppGetToOneRelatedFieldsApp.IsOrEverWasMadeForKids => "isOrEverWasMadeForKids",
                BuildsAppGetToOneRelatedFieldsApp.MarketplaceSearchDetail => "marketplaceSearchDetail",
                BuildsAppGetToOneRelatedFieldsApp.Name => "name",
                BuildsAppGetToOneRelatedFieldsApp.PerfPowerMetrics => "perfPowerMetrics",
                BuildsAppGetToOneRelatedFieldsApp.PreReleaseVersions => "preReleaseVersions",
                BuildsAppGetToOneRelatedFieldsApp.PrimaryLocale => "primaryLocale",
                BuildsAppGetToOneRelatedFieldsApp.PromotedPurchases => "promotedPurchases",
                BuildsAppGetToOneRelatedFieldsApp.ReviewSubmissions => "reviewSubmissions",
                BuildsAppGetToOneRelatedFieldsApp.SearchKeywords => "searchKeywords",
                BuildsAppGetToOneRelatedFieldsApp.Sku => "sku",
                BuildsAppGetToOneRelatedFieldsApp.StreamlinedPurchasingEnabled => "streamlinedPurchasingEnabled",
                BuildsAppGetToOneRelatedFieldsApp.SubscriptionGracePeriod => "subscriptionGracePeriod",
                BuildsAppGetToOneRelatedFieldsApp.SubscriptionGroups => "subscriptionGroups",
                BuildsAppGetToOneRelatedFieldsApp.SubscriptionStatusUrl => "subscriptionStatusUrl",
                BuildsAppGetToOneRelatedFieldsApp.SubscriptionStatusUrlForSandbox => "subscriptionStatusUrlForSandbox",
                BuildsAppGetToOneRelatedFieldsApp.SubscriptionStatusUrlVersion => "subscriptionStatusUrlVersion",
                BuildsAppGetToOneRelatedFieldsApp.SubscriptionStatusUrlVersionForSandbox => "subscriptionStatusUrlVersionForSandbox",
                BuildsAppGetToOneRelatedFieldsApp.Webhooks => "webhooks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildsAppGetToOneRelatedFieldsApp? ToEnum(string value)
        {
            return value switch
            {
                "accessibilityDeclarations" => BuildsAppGetToOneRelatedFieldsApp.AccessibilityDeclarations,
                "accessibilityUrl" => BuildsAppGetToOneRelatedFieldsApp.AccessibilityUrl,
                "alternativeDistributionKey" => BuildsAppGetToOneRelatedFieldsApp.AlternativeDistributionKey,
                "analyticsReportRequests" => BuildsAppGetToOneRelatedFieldsApp.AnalyticsReportRequests,
                "androidToIosAppMappingDetails" => BuildsAppGetToOneRelatedFieldsApp.AndroidToIosAppMappingDetails,
                "appAvailabilityV2" => BuildsAppGetToOneRelatedFieldsApp.AppAvailabilityV2,
                "appClips" => BuildsAppGetToOneRelatedFieldsApp.AppClips,
                "appCustomProductPages" => BuildsAppGetToOneRelatedFieldsApp.AppCustomProductPages,
                "appEncryptionDeclarations" => BuildsAppGetToOneRelatedFieldsApp.AppEncryptionDeclarations,
                "appEvents" => BuildsAppGetToOneRelatedFieldsApp.AppEvents,
                "appInfos" => BuildsAppGetToOneRelatedFieldsApp.AppInfos,
                "appPricePoints" => BuildsAppGetToOneRelatedFieldsApp.AppPricePoints,
                "appPriceSchedule" => BuildsAppGetToOneRelatedFieldsApp.AppPriceSchedule,
                "appStoreIcon" => BuildsAppGetToOneRelatedFieldsApp.AppStoreIcon,
                "appStoreVersionExperimentsV2" => BuildsAppGetToOneRelatedFieldsApp.AppStoreVersionExperimentsV2,
                "appStoreVersions" => BuildsAppGetToOneRelatedFieldsApp.AppStoreVersions,
                "appTags" => BuildsAppGetToOneRelatedFieldsApp.AppTags,
                "backgroundAssets" => BuildsAppGetToOneRelatedFieldsApp.BackgroundAssets,
                "betaAppLocalizations" => BuildsAppGetToOneRelatedFieldsApp.BetaAppLocalizations,
                "betaAppReviewDetail" => BuildsAppGetToOneRelatedFieldsApp.BetaAppReviewDetail,
                "betaFeedbackCrashSubmissions" => BuildsAppGetToOneRelatedFieldsApp.BetaFeedbackCrashSubmissions,
                "betaFeedbackScreenshotSubmissions" => BuildsAppGetToOneRelatedFieldsApp.BetaFeedbackScreenshotSubmissions,
                "betaGroups" => BuildsAppGetToOneRelatedFieldsApp.BetaGroups,
                "betaLicenseAgreement" => BuildsAppGetToOneRelatedFieldsApp.BetaLicenseAgreement,
                "betaTesters" => BuildsAppGetToOneRelatedFieldsApp.BetaTesters,
                "buildUploads" => BuildsAppGetToOneRelatedFieldsApp.BuildUploads,
                "builds" => BuildsAppGetToOneRelatedFieldsApp.Builds,
                "bundleId" => BuildsAppGetToOneRelatedFieldsApp.BundleId,
                "ciProduct" => BuildsAppGetToOneRelatedFieldsApp.CiProduct,
                "contentRightsDeclaration" => BuildsAppGetToOneRelatedFieldsApp.ContentRightsDeclaration,
                "customerReviewSummarizations" => BuildsAppGetToOneRelatedFieldsApp.CustomerReviewSummarizations,
                "customerReviews" => BuildsAppGetToOneRelatedFieldsApp.CustomerReviews,
                "endUserLicenseAgreement" => BuildsAppGetToOneRelatedFieldsApp.EndUserLicenseAgreement,
                "gameCenterDetail" => BuildsAppGetToOneRelatedFieldsApp.GameCenterDetail,
                "gameCenterEnabledVersions" => BuildsAppGetToOneRelatedFieldsApp.GameCenterEnabledVersions,
                "inAppPurchases" => BuildsAppGetToOneRelatedFieldsApp.InAppPurchases,
                "inAppPurchasesV2" => BuildsAppGetToOneRelatedFieldsApp.InAppPurchasesV2,
                "isOrEverWasMadeForKids" => BuildsAppGetToOneRelatedFieldsApp.IsOrEverWasMadeForKids,
                "marketplaceSearchDetail" => BuildsAppGetToOneRelatedFieldsApp.MarketplaceSearchDetail,
                "name" => BuildsAppGetToOneRelatedFieldsApp.Name,
                "perfPowerMetrics" => BuildsAppGetToOneRelatedFieldsApp.PerfPowerMetrics,
                "preReleaseVersions" => BuildsAppGetToOneRelatedFieldsApp.PreReleaseVersions,
                "primaryLocale" => BuildsAppGetToOneRelatedFieldsApp.PrimaryLocale,
                "promotedPurchases" => BuildsAppGetToOneRelatedFieldsApp.PromotedPurchases,
                "reviewSubmissions" => BuildsAppGetToOneRelatedFieldsApp.ReviewSubmissions,
                "searchKeywords" => BuildsAppGetToOneRelatedFieldsApp.SearchKeywords,
                "sku" => BuildsAppGetToOneRelatedFieldsApp.Sku,
                "streamlinedPurchasingEnabled" => BuildsAppGetToOneRelatedFieldsApp.StreamlinedPurchasingEnabled,
                "subscriptionGracePeriod" => BuildsAppGetToOneRelatedFieldsApp.SubscriptionGracePeriod,
                "subscriptionGroups" => BuildsAppGetToOneRelatedFieldsApp.SubscriptionGroups,
                "subscriptionStatusUrl" => BuildsAppGetToOneRelatedFieldsApp.SubscriptionStatusUrl,
                "subscriptionStatusUrlForSandbox" => BuildsAppGetToOneRelatedFieldsApp.SubscriptionStatusUrlForSandbox,
                "subscriptionStatusUrlVersion" => BuildsAppGetToOneRelatedFieldsApp.SubscriptionStatusUrlVersion,
                "subscriptionStatusUrlVersionForSandbox" => BuildsAppGetToOneRelatedFieldsApp.SubscriptionStatusUrlVersionForSandbox,
                "webhooks" => BuildsAppGetToOneRelatedFieldsApp.Webhooks,
                _ => null,
            };
        }
    }
}