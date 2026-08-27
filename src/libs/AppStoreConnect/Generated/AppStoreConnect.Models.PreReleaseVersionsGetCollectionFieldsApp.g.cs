
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum PreReleaseVersionsGetCollectionFieldsApp
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
    public static class PreReleaseVersionsGetCollectionFieldsAppExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PreReleaseVersionsGetCollectionFieldsApp value)
        {
            return value switch
            {
                PreReleaseVersionsGetCollectionFieldsApp.AccessibilityDeclarations => "accessibilityDeclarations",
                PreReleaseVersionsGetCollectionFieldsApp.AccessibilityUrl => "accessibilityUrl",
                PreReleaseVersionsGetCollectionFieldsApp.AlternativeDistributionKey => "alternativeDistributionKey",
                PreReleaseVersionsGetCollectionFieldsApp.AnalyticsReportRequests => "analyticsReportRequests",
                PreReleaseVersionsGetCollectionFieldsApp.AndroidToIosAppMappingDetails => "androidToIosAppMappingDetails",
                PreReleaseVersionsGetCollectionFieldsApp.AppAvailabilityV2 => "appAvailabilityV2",
                PreReleaseVersionsGetCollectionFieldsApp.AppClips => "appClips",
                PreReleaseVersionsGetCollectionFieldsApp.AppCustomProductPages => "appCustomProductPages",
                PreReleaseVersionsGetCollectionFieldsApp.AppEncryptionDeclarations => "appEncryptionDeclarations",
                PreReleaseVersionsGetCollectionFieldsApp.AppEvents => "appEvents",
                PreReleaseVersionsGetCollectionFieldsApp.AppInfos => "appInfos",
                PreReleaseVersionsGetCollectionFieldsApp.AppPricePoints => "appPricePoints",
                PreReleaseVersionsGetCollectionFieldsApp.AppPriceSchedule => "appPriceSchedule",
                PreReleaseVersionsGetCollectionFieldsApp.AppStoreIcon => "appStoreIcon",
                PreReleaseVersionsGetCollectionFieldsApp.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                PreReleaseVersionsGetCollectionFieldsApp.AppStoreVersions => "appStoreVersions",
                PreReleaseVersionsGetCollectionFieldsApp.AppTags => "appTags",
                PreReleaseVersionsGetCollectionFieldsApp.BackgroundAssets => "backgroundAssets",
                PreReleaseVersionsGetCollectionFieldsApp.BetaAppLocalizations => "betaAppLocalizations",
                PreReleaseVersionsGetCollectionFieldsApp.BetaAppReviewDetail => "betaAppReviewDetail",
                PreReleaseVersionsGetCollectionFieldsApp.BetaFeedbackCrashSubmissions => "betaFeedbackCrashSubmissions",
                PreReleaseVersionsGetCollectionFieldsApp.BetaFeedbackScreenshotSubmissions => "betaFeedbackScreenshotSubmissions",
                PreReleaseVersionsGetCollectionFieldsApp.BetaGroups => "betaGroups",
                PreReleaseVersionsGetCollectionFieldsApp.BetaLicenseAgreement => "betaLicenseAgreement",
                PreReleaseVersionsGetCollectionFieldsApp.BetaTesters => "betaTesters",
                PreReleaseVersionsGetCollectionFieldsApp.BuildUploads => "buildUploads",
                PreReleaseVersionsGetCollectionFieldsApp.Builds => "builds",
                PreReleaseVersionsGetCollectionFieldsApp.BundleId => "bundleId",
                PreReleaseVersionsGetCollectionFieldsApp.CiProduct => "ciProduct",
                PreReleaseVersionsGetCollectionFieldsApp.ContentRightsDeclaration => "contentRightsDeclaration",
                PreReleaseVersionsGetCollectionFieldsApp.CustomerReviewSummarizations => "customerReviewSummarizations",
                PreReleaseVersionsGetCollectionFieldsApp.CustomerReviews => "customerReviews",
                PreReleaseVersionsGetCollectionFieldsApp.EndUserLicenseAgreement => "endUserLicenseAgreement",
                PreReleaseVersionsGetCollectionFieldsApp.GameCenterDetail => "gameCenterDetail",
                PreReleaseVersionsGetCollectionFieldsApp.GameCenterEnabledVersions => "gameCenterEnabledVersions",
                PreReleaseVersionsGetCollectionFieldsApp.InAppPurchases => "inAppPurchases",
                PreReleaseVersionsGetCollectionFieldsApp.InAppPurchasesV2 => "inAppPurchasesV2",
                PreReleaseVersionsGetCollectionFieldsApp.IsOrEverWasMadeForKids => "isOrEverWasMadeForKids",
                PreReleaseVersionsGetCollectionFieldsApp.MarketplaceSearchDetail => "marketplaceSearchDetail",
                PreReleaseVersionsGetCollectionFieldsApp.Name => "name",
                PreReleaseVersionsGetCollectionFieldsApp.PerfPowerMetrics => "perfPowerMetrics",
                PreReleaseVersionsGetCollectionFieldsApp.PreReleaseVersions => "preReleaseVersions",
                PreReleaseVersionsGetCollectionFieldsApp.PrimaryLocale => "primaryLocale",
                PreReleaseVersionsGetCollectionFieldsApp.PromotedPurchases => "promotedPurchases",
                PreReleaseVersionsGetCollectionFieldsApp.ReviewSubmissions => "reviewSubmissions",
                PreReleaseVersionsGetCollectionFieldsApp.SearchKeywords => "searchKeywords",
                PreReleaseVersionsGetCollectionFieldsApp.Sku => "sku",
                PreReleaseVersionsGetCollectionFieldsApp.StreamlinedPurchasingEnabled => "streamlinedPurchasingEnabled",
                PreReleaseVersionsGetCollectionFieldsApp.SubscriptionGracePeriod => "subscriptionGracePeriod",
                PreReleaseVersionsGetCollectionFieldsApp.SubscriptionGroups => "subscriptionGroups",
                PreReleaseVersionsGetCollectionFieldsApp.SubscriptionStatusUrl => "subscriptionStatusUrl",
                PreReleaseVersionsGetCollectionFieldsApp.SubscriptionStatusUrlForSandbox => "subscriptionStatusUrlForSandbox",
                PreReleaseVersionsGetCollectionFieldsApp.SubscriptionStatusUrlVersion => "subscriptionStatusUrlVersion",
                PreReleaseVersionsGetCollectionFieldsApp.SubscriptionStatusUrlVersionForSandbox => "subscriptionStatusUrlVersionForSandbox",
                PreReleaseVersionsGetCollectionFieldsApp.Webhooks => "webhooks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PreReleaseVersionsGetCollectionFieldsApp? ToEnum(string value)
        {
            return value switch
            {
                "accessibilityDeclarations" => PreReleaseVersionsGetCollectionFieldsApp.AccessibilityDeclarations,
                "accessibilityUrl" => PreReleaseVersionsGetCollectionFieldsApp.AccessibilityUrl,
                "alternativeDistributionKey" => PreReleaseVersionsGetCollectionFieldsApp.AlternativeDistributionKey,
                "analyticsReportRequests" => PreReleaseVersionsGetCollectionFieldsApp.AnalyticsReportRequests,
                "androidToIosAppMappingDetails" => PreReleaseVersionsGetCollectionFieldsApp.AndroidToIosAppMappingDetails,
                "appAvailabilityV2" => PreReleaseVersionsGetCollectionFieldsApp.AppAvailabilityV2,
                "appClips" => PreReleaseVersionsGetCollectionFieldsApp.AppClips,
                "appCustomProductPages" => PreReleaseVersionsGetCollectionFieldsApp.AppCustomProductPages,
                "appEncryptionDeclarations" => PreReleaseVersionsGetCollectionFieldsApp.AppEncryptionDeclarations,
                "appEvents" => PreReleaseVersionsGetCollectionFieldsApp.AppEvents,
                "appInfos" => PreReleaseVersionsGetCollectionFieldsApp.AppInfos,
                "appPricePoints" => PreReleaseVersionsGetCollectionFieldsApp.AppPricePoints,
                "appPriceSchedule" => PreReleaseVersionsGetCollectionFieldsApp.AppPriceSchedule,
                "appStoreIcon" => PreReleaseVersionsGetCollectionFieldsApp.AppStoreIcon,
                "appStoreVersionExperimentsV2" => PreReleaseVersionsGetCollectionFieldsApp.AppStoreVersionExperimentsV2,
                "appStoreVersions" => PreReleaseVersionsGetCollectionFieldsApp.AppStoreVersions,
                "appTags" => PreReleaseVersionsGetCollectionFieldsApp.AppTags,
                "backgroundAssets" => PreReleaseVersionsGetCollectionFieldsApp.BackgroundAssets,
                "betaAppLocalizations" => PreReleaseVersionsGetCollectionFieldsApp.BetaAppLocalizations,
                "betaAppReviewDetail" => PreReleaseVersionsGetCollectionFieldsApp.BetaAppReviewDetail,
                "betaFeedbackCrashSubmissions" => PreReleaseVersionsGetCollectionFieldsApp.BetaFeedbackCrashSubmissions,
                "betaFeedbackScreenshotSubmissions" => PreReleaseVersionsGetCollectionFieldsApp.BetaFeedbackScreenshotSubmissions,
                "betaGroups" => PreReleaseVersionsGetCollectionFieldsApp.BetaGroups,
                "betaLicenseAgreement" => PreReleaseVersionsGetCollectionFieldsApp.BetaLicenseAgreement,
                "betaTesters" => PreReleaseVersionsGetCollectionFieldsApp.BetaTesters,
                "buildUploads" => PreReleaseVersionsGetCollectionFieldsApp.BuildUploads,
                "builds" => PreReleaseVersionsGetCollectionFieldsApp.Builds,
                "bundleId" => PreReleaseVersionsGetCollectionFieldsApp.BundleId,
                "ciProduct" => PreReleaseVersionsGetCollectionFieldsApp.CiProduct,
                "contentRightsDeclaration" => PreReleaseVersionsGetCollectionFieldsApp.ContentRightsDeclaration,
                "customerReviewSummarizations" => PreReleaseVersionsGetCollectionFieldsApp.CustomerReviewSummarizations,
                "customerReviews" => PreReleaseVersionsGetCollectionFieldsApp.CustomerReviews,
                "endUserLicenseAgreement" => PreReleaseVersionsGetCollectionFieldsApp.EndUserLicenseAgreement,
                "gameCenterDetail" => PreReleaseVersionsGetCollectionFieldsApp.GameCenterDetail,
                "gameCenterEnabledVersions" => PreReleaseVersionsGetCollectionFieldsApp.GameCenterEnabledVersions,
                "inAppPurchases" => PreReleaseVersionsGetCollectionFieldsApp.InAppPurchases,
                "inAppPurchasesV2" => PreReleaseVersionsGetCollectionFieldsApp.InAppPurchasesV2,
                "isOrEverWasMadeForKids" => PreReleaseVersionsGetCollectionFieldsApp.IsOrEverWasMadeForKids,
                "marketplaceSearchDetail" => PreReleaseVersionsGetCollectionFieldsApp.MarketplaceSearchDetail,
                "name" => PreReleaseVersionsGetCollectionFieldsApp.Name,
                "perfPowerMetrics" => PreReleaseVersionsGetCollectionFieldsApp.PerfPowerMetrics,
                "preReleaseVersions" => PreReleaseVersionsGetCollectionFieldsApp.PreReleaseVersions,
                "primaryLocale" => PreReleaseVersionsGetCollectionFieldsApp.PrimaryLocale,
                "promotedPurchases" => PreReleaseVersionsGetCollectionFieldsApp.PromotedPurchases,
                "reviewSubmissions" => PreReleaseVersionsGetCollectionFieldsApp.ReviewSubmissions,
                "searchKeywords" => PreReleaseVersionsGetCollectionFieldsApp.SearchKeywords,
                "sku" => PreReleaseVersionsGetCollectionFieldsApp.Sku,
                "streamlinedPurchasingEnabled" => PreReleaseVersionsGetCollectionFieldsApp.StreamlinedPurchasingEnabled,
                "subscriptionGracePeriod" => PreReleaseVersionsGetCollectionFieldsApp.SubscriptionGracePeriod,
                "subscriptionGroups" => PreReleaseVersionsGetCollectionFieldsApp.SubscriptionGroups,
                "subscriptionStatusUrl" => PreReleaseVersionsGetCollectionFieldsApp.SubscriptionStatusUrl,
                "subscriptionStatusUrlForSandbox" => PreReleaseVersionsGetCollectionFieldsApp.SubscriptionStatusUrlForSandbox,
                "subscriptionStatusUrlVersion" => PreReleaseVersionsGetCollectionFieldsApp.SubscriptionStatusUrlVersion,
                "subscriptionStatusUrlVersionForSandbox" => PreReleaseVersionsGetCollectionFieldsApp.SubscriptionStatusUrlVersionForSandbox,
                "webhooks" => PreReleaseVersionsGetCollectionFieldsApp.Webhooks,
                _ => null,
            };
        }
    }
}