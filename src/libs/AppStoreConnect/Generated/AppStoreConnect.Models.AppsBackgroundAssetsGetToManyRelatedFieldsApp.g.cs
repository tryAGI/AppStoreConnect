
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsBackgroundAssetsGetToManyRelatedFieldsApp
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
    public static class AppsBackgroundAssetsGetToManyRelatedFieldsAppExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsBackgroundAssetsGetToManyRelatedFieldsApp value)
        {
            return value switch
            {
                AppsBackgroundAssetsGetToManyRelatedFieldsApp.AccessibilityDeclarations => "accessibilityDeclarations",
                AppsBackgroundAssetsGetToManyRelatedFieldsApp.AccessibilityUrl => "accessibilityUrl",
                AppsBackgroundAssetsGetToManyRelatedFieldsApp.AlternativeDistributionKey => "alternativeDistributionKey",
                AppsBackgroundAssetsGetToManyRelatedFieldsApp.AnalyticsReportRequests => "analyticsReportRequests",
                AppsBackgroundAssetsGetToManyRelatedFieldsApp.AndroidToIosAppMappingDetails => "androidToIosAppMappingDetails",
                AppsBackgroundAssetsGetToManyRelatedFieldsApp.AppAvailabilityV2 => "appAvailabilityV2",
                AppsBackgroundAssetsGetToManyRelatedFieldsApp.AppClips => "appClips",
                AppsBackgroundAssetsGetToManyRelatedFieldsApp.AppCustomProductPages => "appCustomProductPages",
                AppsBackgroundAssetsGetToManyRelatedFieldsApp.AppEncryptionDeclarations => "appEncryptionDeclarations",
                AppsBackgroundAssetsGetToManyRelatedFieldsApp.AppEvents => "appEvents",
                AppsBackgroundAssetsGetToManyRelatedFieldsApp.AppInfos => "appInfos",
                AppsBackgroundAssetsGetToManyRelatedFieldsApp.AppPricePoints => "appPricePoints",
                AppsBackgroundAssetsGetToManyRelatedFieldsApp.AppPriceSchedule => "appPriceSchedule",
                AppsBackgroundAssetsGetToManyRelatedFieldsApp.AppStoreIcon => "appStoreIcon",
                AppsBackgroundAssetsGetToManyRelatedFieldsApp.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                AppsBackgroundAssetsGetToManyRelatedFieldsApp.AppStoreVersions => "appStoreVersions",
                AppsBackgroundAssetsGetToManyRelatedFieldsApp.AppTags => "appTags",
                AppsBackgroundAssetsGetToManyRelatedFieldsApp.BackgroundAssets => "backgroundAssets",
                AppsBackgroundAssetsGetToManyRelatedFieldsApp.BetaAppLocalizations => "betaAppLocalizations",
                AppsBackgroundAssetsGetToManyRelatedFieldsApp.BetaAppReviewDetail => "betaAppReviewDetail",
                AppsBackgroundAssetsGetToManyRelatedFieldsApp.BetaFeedbackCrashSubmissions => "betaFeedbackCrashSubmissions",
                AppsBackgroundAssetsGetToManyRelatedFieldsApp.BetaFeedbackScreenshotSubmissions => "betaFeedbackScreenshotSubmissions",
                AppsBackgroundAssetsGetToManyRelatedFieldsApp.BetaGroups => "betaGroups",
                AppsBackgroundAssetsGetToManyRelatedFieldsApp.BetaLicenseAgreement => "betaLicenseAgreement",
                AppsBackgroundAssetsGetToManyRelatedFieldsApp.BetaTesters => "betaTesters",
                AppsBackgroundAssetsGetToManyRelatedFieldsApp.BuildUploads => "buildUploads",
                AppsBackgroundAssetsGetToManyRelatedFieldsApp.Builds => "builds",
                AppsBackgroundAssetsGetToManyRelatedFieldsApp.BundleId => "bundleId",
                AppsBackgroundAssetsGetToManyRelatedFieldsApp.CiProduct => "ciProduct",
                AppsBackgroundAssetsGetToManyRelatedFieldsApp.ContentRightsDeclaration => "contentRightsDeclaration",
                AppsBackgroundAssetsGetToManyRelatedFieldsApp.CustomerReviewSummarizations => "customerReviewSummarizations",
                AppsBackgroundAssetsGetToManyRelatedFieldsApp.CustomerReviews => "customerReviews",
                AppsBackgroundAssetsGetToManyRelatedFieldsApp.EndUserLicenseAgreement => "endUserLicenseAgreement",
                AppsBackgroundAssetsGetToManyRelatedFieldsApp.GameCenterDetail => "gameCenterDetail",
                AppsBackgroundAssetsGetToManyRelatedFieldsApp.GameCenterEnabledVersions => "gameCenterEnabledVersions",
                AppsBackgroundAssetsGetToManyRelatedFieldsApp.InAppPurchases => "inAppPurchases",
                AppsBackgroundAssetsGetToManyRelatedFieldsApp.InAppPurchasesV2 => "inAppPurchasesV2",
                AppsBackgroundAssetsGetToManyRelatedFieldsApp.IsOrEverWasMadeForKids => "isOrEverWasMadeForKids",
                AppsBackgroundAssetsGetToManyRelatedFieldsApp.MarketplaceSearchDetail => "marketplaceSearchDetail",
                AppsBackgroundAssetsGetToManyRelatedFieldsApp.Name => "name",
                AppsBackgroundAssetsGetToManyRelatedFieldsApp.PerfPowerMetrics => "perfPowerMetrics",
                AppsBackgroundAssetsGetToManyRelatedFieldsApp.PreReleaseVersions => "preReleaseVersions",
                AppsBackgroundAssetsGetToManyRelatedFieldsApp.PrimaryLocale => "primaryLocale",
                AppsBackgroundAssetsGetToManyRelatedFieldsApp.PromotedPurchases => "promotedPurchases",
                AppsBackgroundAssetsGetToManyRelatedFieldsApp.ReviewSubmissions => "reviewSubmissions",
                AppsBackgroundAssetsGetToManyRelatedFieldsApp.SearchKeywords => "searchKeywords",
                AppsBackgroundAssetsGetToManyRelatedFieldsApp.Sku => "sku",
                AppsBackgroundAssetsGetToManyRelatedFieldsApp.StreamlinedPurchasingEnabled => "streamlinedPurchasingEnabled",
                AppsBackgroundAssetsGetToManyRelatedFieldsApp.SubscriptionGracePeriod => "subscriptionGracePeriod",
                AppsBackgroundAssetsGetToManyRelatedFieldsApp.SubscriptionGroups => "subscriptionGroups",
                AppsBackgroundAssetsGetToManyRelatedFieldsApp.SubscriptionStatusUrl => "subscriptionStatusUrl",
                AppsBackgroundAssetsGetToManyRelatedFieldsApp.SubscriptionStatusUrlForSandbox => "subscriptionStatusUrlForSandbox",
                AppsBackgroundAssetsGetToManyRelatedFieldsApp.SubscriptionStatusUrlVersion => "subscriptionStatusUrlVersion",
                AppsBackgroundAssetsGetToManyRelatedFieldsApp.SubscriptionStatusUrlVersionForSandbox => "subscriptionStatusUrlVersionForSandbox",
                AppsBackgroundAssetsGetToManyRelatedFieldsApp.Webhooks => "webhooks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsBackgroundAssetsGetToManyRelatedFieldsApp? ToEnum(string value)
        {
            return value switch
            {
                "accessibilityDeclarations" => AppsBackgroundAssetsGetToManyRelatedFieldsApp.AccessibilityDeclarations,
                "accessibilityUrl" => AppsBackgroundAssetsGetToManyRelatedFieldsApp.AccessibilityUrl,
                "alternativeDistributionKey" => AppsBackgroundAssetsGetToManyRelatedFieldsApp.AlternativeDistributionKey,
                "analyticsReportRequests" => AppsBackgroundAssetsGetToManyRelatedFieldsApp.AnalyticsReportRequests,
                "androidToIosAppMappingDetails" => AppsBackgroundAssetsGetToManyRelatedFieldsApp.AndroidToIosAppMappingDetails,
                "appAvailabilityV2" => AppsBackgroundAssetsGetToManyRelatedFieldsApp.AppAvailabilityV2,
                "appClips" => AppsBackgroundAssetsGetToManyRelatedFieldsApp.AppClips,
                "appCustomProductPages" => AppsBackgroundAssetsGetToManyRelatedFieldsApp.AppCustomProductPages,
                "appEncryptionDeclarations" => AppsBackgroundAssetsGetToManyRelatedFieldsApp.AppEncryptionDeclarations,
                "appEvents" => AppsBackgroundAssetsGetToManyRelatedFieldsApp.AppEvents,
                "appInfos" => AppsBackgroundAssetsGetToManyRelatedFieldsApp.AppInfos,
                "appPricePoints" => AppsBackgroundAssetsGetToManyRelatedFieldsApp.AppPricePoints,
                "appPriceSchedule" => AppsBackgroundAssetsGetToManyRelatedFieldsApp.AppPriceSchedule,
                "appStoreIcon" => AppsBackgroundAssetsGetToManyRelatedFieldsApp.AppStoreIcon,
                "appStoreVersionExperimentsV2" => AppsBackgroundAssetsGetToManyRelatedFieldsApp.AppStoreVersionExperimentsV2,
                "appStoreVersions" => AppsBackgroundAssetsGetToManyRelatedFieldsApp.AppStoreVersions,
                "appTags" => AppsBackgroundAssetsGetToManyRelatedFieldsApp.AppTags,
                "backgroundAssets" => AppsBackgroundAssetsGetToManyRelatedFieldsApp.BackgroundAssets,
                "betaAppLocalizations" => AppsBackgroundAssetsGetToManyRelatedFieldsApp.BetaAppLocalizations,
                "betaAppReviewDetail" => AppsBackgroundAssetsGetToManyRelatedFieldsApp.BetaAppReviewDetail,
                "betaFeedbackCrashSubmissions" => AppsBackgroundAssetsGetToManyRelatedFieldsApp.BetaFeedbackCrashSubmissions,
                "betaFeedbackScreenshotSubmissions" => AppsBackgroundAssetsGetToManyRelatedFieldsApp.BetaFeedbackScreenshotSubmissions,
                "betaGroups" => AppsBackgroundAssetsGetToManyRelatedFieldsApp.BetaGroups,
                "betaLicenseAgreement" => AppsBackgroundAssetsGetToManyRelatedFieldsApp.BetaLicenseAgreement,
                "betaTesters" => AppsBackgroundAssetsGetToManyRelatedFieldsApp.BetaTesters,
                "buildUploads" => AppsBackgroundAssetsGetToManyRelatedFieldsApp.BuildUploads,
                "builds" => AppsBackgroundAssetsGetToManyRelatedFieldsApp.Builds,
                "bundleId" => AppsBackgroundAssetsGetToManyRelatedFieldsApp.BundleId,
                "ciProduct" => AppsBackgroundAssetsGetToManyRelatedFieldsApp.CiProduct,
                "contentRightsDeclaration" => AppsBackgroundAssetsGetToManyRelatedFieldsApp.ContentRightsDeclaration,
                "customerReviewSummarizations" => AppsBackgroundAssetsGetToManyRelatedFieldsApp.CustomerReviewSummarizations,
                "customerReviews" => AppsBackgroundAssetsGetToManyRelatedFieldsApp.CustomerReviews,
                "endUserLicenseAgreement" => AppsBackgroundAssetsGetToManyRelatedFieldsApp.EndUserLicenseAgreement,
                "gameCenterDetail" => AppsBackgroundAssetsGetToManyRelatedFieldsApp.GameCenterDetail,
                "gameCenterEnabledVersions" => AppsBackgroundAssetsGetToManyRelatedFieldsApp.GameCenterEnabledVersions,
                "inAppPurchases" => AppsBackgroundAssetsGetToManyRelatedFieldsApp.InAppPurchases,
                "inAppPurchasesV2" => AppsBackgroundAssetsGetToManyRelatedFieldsApp.InAppPurchasesV2,
                "isOrEverWasMadeForKids" => AppsBackgroundAssetsGetToManyRelatedFieldsApp.IsOrEverWasMadeForKids,
                "marketplaceSearchDetail" => AppsBackgroundAssetsGetToManyRelatedFieldsApp.MarketplaceSearchDetail,
                "name" => AppsBackgroundAssetsGetToManyRelatedFieldsApp.Name,
                "perfPowerMetrics" => AppsBackgroundAssetsGetToManyRelatedFieldsApp.PerfPowerMetrics,
                "preReleaseVersions" => AppsBackgroundAssetsGetToManyRelatedFieldsApp.PreReleaseVersions,
                "primaryLocale" => AppsBackgroundAssetsGetToManyRelatedFieldsApp.PrimaryLocale,
                "promotedPurchases" => AppsBackgroundAssetsGetToManyRelatedFieldsApp.PromotedPurchases,
                "reviewSubmissions" => AppsBackgroundAssetsGetToManyRelatedFieldsApp.ReviewSubmissions,
                "searchKeywords" => AppsBackgroundAssetsGetToManyRelatedFieldsApp.SearchKeywords,
                "sku" => AppsBackgroundAssetsGetToManyRelatedFieldsApp.Sku,
                "streamlinedPurchasingEnabled" => AppsBackgroundAssetsGetToManyRelatedFieldsApp.StreamlinedPurchasingEnabled,
                "subscriptionGracePeriod" => AppsBackgroundAssetsGetToManyRelatedFieldsApp.SubscriptionGracePeriod,
                "subscriptionGroups" => AppsBackgroundAssetsGetToManyRelatedFieldsApp.SubscriptionGroups,
                "subscriptionStatusUrl" => AppsBackgroundAssetsGetToManyRelatedFieldsApp.SubscriptionStatusUrl,
                "subscriptionStatusUrlForSandbox" => AppsBackgroundAssetsGetToManyRelatedFieldsApp.SubscriptionStatusUrlForSandbox,
                "subscriptionStatusUrlVersion" => AppsBackgroundAssetsGetToManyRelatedFieldsApp.SubscriptionStatusUrlVersion,
                "subscriptionStatusUrlVersionForSandbox" => AppsBackgroundAssetsGetToManyRelatedFieldsApp.SubscriptionStatusUrlVersionForSandbox,
                "webhooks" => AppsBackgroundAssetsGetToManyRelatedFieldsApp.Webhooks,
                _ => null,
            };
        }
    }
}