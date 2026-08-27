
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaTestersGetCollectionFieldsApp
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
    public static class BetaTestersGetCollectionFieldsAppExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaTestersGetCollectionFieldsApp value)
        {
            return value switch
            {
                BetaTestersGetCollectionFieldsApp.AccessibilityDeclarations => "accessibilityDeclarations",
                BetaTestersGetCollectionFieldsApp.AccessibilityUrl => "accessibilityUrl",
                BetaTestersGetCollectionFieldsApp.AlternativeDistributionKey => "alternativeDistributionKey",
                BetaTestersGetCollectionFieldsApp.AnalyticsReportRequests => "analyticsReportRequests",
                BetaTestersGetCollectionFieldsApp.AndroidToIosAppMappingDetails => "androidToIosAppMappingDetails",
                BetaTestersGetCollectionFieldsApp.AppAvailabilityV2 => "appAvailabilityV2",
                BetaTestersGetCollectionFieldsApp.AppClips => "appClips",
                BetaTestersGetCollectionFieldsApp.AppCustomProductPages => "appCustomProductPages",
                BetaTestersGetCollectionFieldsApp.AppEncryptionDeclarations => "appEncryptionDeclarations",
                BetaTestersGetCollectionFieldsApp.AppEvents => "appEvents",
                BetaTestersGetCollectionFieldsApp.AppInfos => "appInfos",
                BetaTestersGetCollectionFieldsApp.AppPricePoints => "appPricePoints",
                BetaTestersGetCollectionFieldsApp.AppPriceSchedule => "appPriceSchedule",
                BetaTestersGetCollectionFieldsApp.AppStoreIcon => "appStoreIcon",
                BetaTestersGetCollectionFieldsApp.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                BetaTestersGetCollectionFieldsApp.AppStoreVersions => "appStoreVersions",
                BetaTestersGetCollectionFieldsApp.AppTags => "appTags",
                BetaTestersGetCollectionFieldsApp.BackgroundAssets => "backgroundAssets",
                BetaTestersGetCollectionFieldsApp.BetaAppLocalizations => "betaAppLocalizations",
                BetaTestersGetCollectionFieldsApp.BetaAppReviewDetail => "betaAppReviewDetail",
                BetaTestersGetCollectionFieldsApp.BetaFeedbackCrashSubmissions => "betaFeedbackCrashSubmissions",
                BetaTestersGetCollectionFieldsApp.BetaFeedbackScreenshotSubmissions => "betaFeedbackScreenshotSubmissions",
                BetaTestersGetCollectionFieldsApp.BetaGroups => "betaGroups",
                BetaTestersGetCollectionFieldsApp.BetaLicenseAgreement => "betaLicenseAgreement",
                BetaTestersGetCollectionFieldsApp.BetaTesters => "betaTesters",
                BetaTestersGetCollectionFieldsApp.BuildUploads => "buildUploads",
                BetaTestersGetCollectionFieldsApp.Builds => "builds",
                BetaTestersGetCollectionFieldsApp.BundleId => "bundleId",
                BetaTestersGetCollectionFieldsApp.CiProduct => "ciProduct",
                BetaTestersGetCollectionFieldsApp.ContentRightsDeclaration => "contentRightsDeclaration",
                BetaTestersGetCollectionFieldsApp.CustomerReviewSummarizations => "customerReviewSummarizations",
                BetaTestersGetCollectionFieldsApp.CustomerReviews => "customerReviews",
                BetaTestersGetCollectionFieldsApp.EndUserLicenseAgreement => "endUserLicenseAgreement",
                BetaTestersGetCollectionFieldsApp.GameCenterDetail => "gameCenterDetail",
                BetaTestersGetCollectionFieldsApp.GameCenterEnabledVersions => "gameCenterEnabledVersions",
                BetaTestersGetCollectionFieldsApp.InAppPurchases => "inAppPurchases",
                BetaTestersGetCollectionFieldsApp.InAppPurchasesV2 => "inAppPurchasesV2",
                BetaTestersGetCollectionFieldsApp.IsOrEverWasMadeForKids => "isOrEverWasMadeForKids",
                BetaTestersGetCollectionFieldsApp.MarketplaceSearchDetail => "marketplaceSearchDetail",
                BetaTestersGetCollectionFieldsApp.Name => "name",
                BetaTestersGetCollectionFieldsApp.PerfPowerMetrics => "perfPowerMetrics",
                BetaTestersGetCollectionFieldsApp.PreReleaseVersions => "preReleaseVersions",
                BetaTestersGetCollectionFieldsApp.PrimaryLocale => "primaryLocale",
                BetaTestersGetCollectionFieldsApp.PromotedPurchases => "promotedPurchases",
                BetaTestersGetCollectionFieldsApp.ReviewSubmissions => "reviewSubmissions",
                BetaTestersGetCollectionFieldsApp.SearchKeywords => "searchKeywords",
                BetaTestersGetCollectionFieldsApp.Sku => "sku",
                BetaTestersGetCollectionFieldsApp.StreamlinedPurchasingEnabled => "streamlinedPurchasingEnabled",
                BetaTestersGetCollectionFieldsApp.SubscriptionGracePeriod => "subscriptionGracePeriod",
                BetaTestersGetCollectionFieldsApp.SubscriptionGroups => "subscriptionGroups",
                BetaTestersGetCollectionFieldsApp.SubscriptionStatusUrl => "subscriptionStatusUrl",
                BetaTestersGetCollectionFieldsApp.SubscriptionStatusUrlForSandbox => "subscriptionStatusUrlForSandbox",
                BetaTestersGetCollectionFieldsApp.SubscriptionStatusUrlVersion => "subscriptionStatusUrlVersion",
                BetaTestersGetCollectionFieldsApp.SubscriptionStatusUrlVersionForSandbox => "subscriptionStatusUrlVersionForSandbox",
                BetaTestersGetCollectionFieldsApp.Webhooks => "webhooks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaTestersGetCollectionFieldsApp? ToEnum(string value)
        {
            return value switch
            {
                "accessibilityDeclarations" => BetaTestersGetCollectionFieldsApp.AccessibilityDeclarations,
                "accessibilityUrl" => BetaTestersGetCollectionFieldsApp.AccessibilityUrl,
                "alternativeDistributionKey" => BetaTestersGetCollectionFieldsApp.AlternativeDistributionKey,
                "analyticsReportRequests" => BetaTestersGetCollectionFieldsApp.AnalyticsReportRequests,
                "androidToIosAppMappingDetails" => BetaTestersGetCollectionFieldsApp.AndroidToIosAppMappingDetails,
                "appAvailabilityV2" => BetaTestersGetCollectionFieldsApp.AppAvailabilityV2,
                "appClips" => BetaTestersGetCollectionFieldsApp.AppClips,
                "appCustomProductPages" => BetaTestersGetCollectionFieldsApp.AppCustomProductPages,
                "appEncryptionDeclarations" => BetaTestersGetCollectionFieldsApp.AppEncryptionDeclarations,
                "appEvents" => BetaTestersGetCollectionFieldsApp.AppEvents,
                "appInfos" => BetaTestersGetCollectionFieldsApp.AppInfos,
                "appPricePoints" => BetaTestersGetCollectionFieldsApp.AppPricePoints,
                "appPriceSchedule" => BetaTestersGetCollectionFieldsApp.AppPriceSchedule,
                "appStoreIcon" => BetaTestersGetCollectionFieldsApp.AppStoreIcon,
                "appStoreVersionExperimentsV2" => BetaTestersGetCollectionFieldsApp.AppStoreVersionExperimentsV2,
                "appStoreVersions" => BetaTestersGetCollectionFieldsApp.AppStoreVersions,
                "appTags" => BetaTestersGetCollectionFieldsApp.AppTags,
                "backgroundAssets" => BetaTestersGetCollectionFieldsApp.BackgroundAssets,
                "betaAppLocalizations" => BetaTestersGetCollectionFieldsApp.BetaAppLocalizations,
                "betaAppReviewDetail" => BetaTestersGetCollectionFieldsApp.BetaAppReviewDetail,
                "betaFeedbackCrashSubmissions" => BetaTestersGetCollectionFieldsApp.BetaFeedbackCrashSubmissions,
                "betaFeedbackScreenshotSubmissions" => BetaTestersGetCollectionFieldsApp.BetaFeedbackScreenshotSubmissions,
                "betaGroups" => BetaTestersGetCollectionFieldsApp.BetaGroups,
                "betaLicenseAgreement" => BetaTestersGetCollectionFieldsApp.BetaLicenseAgreement,
                "betaTesters" => BetaTestersGetCollectionFieldsApp.BetaTesters,
                "buildUploads" => BetaTestersGetCollectionFieldsApp.BuildUploads,
                "builds" => BetaTestersGetCollectionFieldsApp.Builds,
                "bundleId" => BetaTestersGetCollectionFieldsApp.BundleId,
                "ciProduct" => BetaTestersGetCollectionFieldsApp.CiProduct,
                "contentRightsDeclaration" => BetaTestersGetCollectionFieldsApp.ContentRightsDeclaration,
                "customerReviewSummarizations" => BetaTestersGetCollectionFieldsApp.CustomerReviewSummarizations,
                "customerReviews" => BetaTestersGetCollectionFieldsApp.CustomerReviews,
                "endUserLicenseAgreement" => BetaTestersGetCollectionFieldsApp.EndUserLicenseAgreement,
                "gameCenterDetail" => BetaTestersGetCollectionFieldsApp.GameCenterDetail,
                "gameCenterEnabledVersions" => BetaTestersGetCollectionFieldsApp.GameCenterEnabledVersions,
                "inAppPurchases" => BetaTestersGetCollectionFieldsApp.InAppPurchases,
                "inAppPurchasesV2" => BetaTestersGetCollectionFieldsApp.InAppPurchasesV2,
                "isOrEverWasMadeForKids" => BetaTestersGetCollectionFieldsApp.IsOrEverWasMadeForKids,
                "marketplaceSearchDetail" => BetaTestersGetCollectionFieldsApp.MarketplaceSearchDetail,
                "name" => BetaTestersGetCollectionFieldsApp.Name,
                "perfPowerMetrics" => BetaTestersGetCollectionFieldsApp.PerfPowerMetrics,
                "preReleaseVersions" => BetaTestersGetCollectionFieldsApp.PreReleaseVersions,
                "primaryLocale" => BetaTestersGetCollectionFieldsApp.PrimaryLocale,
                "promotedPurchases" => BetaTestersGetCollectionFieldsApp.PromotedPurchases,
                "reviewSubmissions" => BetaTestersGetCollectionFieldsApp.ReviewSubmissions,
                "searchKeywords" => BetaTestersGetCollectionFieldsApp.SearchKeywords,
                "sku" => BetaTestersGetCollectionFieldsApp.Sku,
                "streamlinedPurchasingEnabled" => BetaTestersGetCollectionFieldsApp.StreamlinedPurchasingEnabled,
                "subscriptionGracePeriod" => BetaTestersGetCollectionFieldsApp.SubscriptionGracePeriod,
                "subscriptionGroups" => BetaTestersGetCollectionFieldsApp.SubscriptionGroups,
                "subscriptionStatusUrl" => BetaTestersGetCollectionFieldsApp.SubscriptionStatusUrl,
                "subscriptionStatusUrlForSandbox" => BetaTestersGetCollectionFieldsApp.SubscriptionStatusUrlForSandbox,
                "subscriptionStatusUrlVersion" => BetaTestersGetCollectionFieldsApp.SubscriptionStatusUrlVersion,
                "subscriptionStatusUrlVersionForSandbox" => BetaTestersGetCollectionFieldsApp.SubscriptionStatusUrlVersionForSandbox,
                "webhooks" => BetaTestersGetCollectionFieldsApp.Webhooks,
                _ => null,
            };
        }
    }
}