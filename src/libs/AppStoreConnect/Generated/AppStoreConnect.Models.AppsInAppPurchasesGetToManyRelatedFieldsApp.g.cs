
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsInAppPurchasesGetToManyRelatedFieldsApp
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
    public static class AppsInAppPurchasesGetToManyRelatedFieldsAppExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsInAppPurchasesGetToManyRelatedFieldsApp value)
        {
            return value switch
            {
                AppsInAppPurchasesGetToManyRelatedFieldsApp.AccessibilityDeclarations => "accessibilityDeclarations",
                AppsInAppPurchasesGetToManyRelatedFieldsApp.AccessibilityUrl => "accessibilityUrl",
                AppsInAppPurchasesGetToManyRelatedFieldsApp.AlternativeDistributionKey => "alternativeDistributionKey",
                AppsInAppPurchasesGetToManyRelatedFieldsApp.AnalyticsReportRequests => "analyticsReportRequests",
                AppsInAppPurchasesGetToManyRelatedFieldsApp.AndroidToIosAppMappingDetails => "androidToIosAppMappingDetails",
                AppsInAppPurchasesGetToManyRelatedFieldsApp.AppAvailabilityV2 => "appAvailabilityV2",
                AppsInAppPurchasesGetToManyRelatedFieldsApp.AppClips => "appClips",
                AppsInAppPurchasesGetToManyRelatedFieldsApp.AppCustomProductPages => "appCustomProductPages",
                AppsInAppPurchasesGetToManyRelatedFieldsApp.AppEncryptionDeclarations => "appEncryptionDeclarations",
                AppsInAppPurchasesGetToManyRelatedFieldsApp.AppEvents => "appEvents",
                AppsInAppPurchasesGetToManyRelatedFieldsApp.AppInfos => "appInfos",
                AppsInAppPurchasesGetToManyRelatedFieldsApp.AppPricePoints => "appPricePoints",
                AppsInAppPurchasesGetToManyRelatedFieldsApp.AppPriceSchedule => "appPriceSchedule",
                AppsInAppPurchasesGetToManyRelatedFieldsApp.AppStoreIcon => "appStoreIcon",
                AppsInAppPurchasesGetToManyRelatedFieldsApp.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                AppsInAppPurchasesGetToManyRelatedFieldsApp.AppStoreVersions => "appStoreVersions",
                AppsInAppPurchasesGetToManyRelatedFieldsApp.AppTags => "appTags",
                AppsInAppPurchasesGetToManyRelatedFieldsApp.BackgroundAssets => "backgroundAssets",
                AppsInAppPurchasesGetToManyRelatedFieldsApp.BetaAppLocalizations => "betaAppLocalizations",
                AppsInAppPurchasesGetToManyRelatedFieldsApp.BetaAppReviewDetail => "betaAppReviewDetail",
                AppsInAppPurchasesGetToManyRelatedFieldsApp.BetaFeedbackCrashSubmissions => "betaFeedbackCrashSubmissions",
                AppsInAppPurchasesGetToManyRelatedFieldsApp.BetaFeedbackScreenshotSubmissions => "betaFeedbackScreenshotSubmissions",
                AppsInAppPurchasesGetToManyRelatedFieldsApp.BetaGroups => "betaGroups",
                AppsInAppPurchasesGetToManyRelatedFieldsApp.BetaLicenseAgreement => "betaLicenseAgreement",
                AppsInAppPurchasesGetToManyRelatedFieldsApp.BetaTesters => "betaTesters",
                AppsInAppPurchasesGetToManyRelatedFieldsApp.BuildUploads => "buildUploads",
                AppsInAppPurchasesGetToManyRelatedFieldsApp.Builds => "builds",
                AppsInAppPurchasesGetToManyRelatedFieldsApp.BundleId => "bundleId",
                AppsInAppPurchasesGetToManyRelatedFieldsApp.CiProduct => "ciProduct",
                AppsInAppPurchasesGetToManyRelatedFieldsApp.ContentRightsDeclaration => "contentRightsDeclaration",
                AppsInAppPurchasesGetToManyRelatedFieldsApp.CustomerReviewSummarizations => "customerReviewSummarizations",
                AppsInAppPurchasesGetToManyRelatedFieldsApp.CustomerReviews => "customerReviews",
                AppsInAppPurchasesGetToManyRelatedFieldsApp.EndUserLicenseAgreement => "endUserLicenseAgreement",
                AppsInAppPurchasesGetToManyRelatedFieldsApp.GameCenterDetail => "gameCenterDetail",
                AppsInAppPurchasesGetToManyRelatedFieldsApp.GameCenterEnabledVersions => "gameCenterEnabledVersions",
                AppsInAppPurchasesGetToManyRelatedFieldsApp.InAppPurchases => "inAppPurchases",
                AppsInAppPurchasesGetToManyRelatedFieldsApp.InAppPurchasesV2 => "inAppPurchasesV2",
                AppsInAppPurchasesGetToManyRelatedFieldsApp.IsOrEverWasMadeForKids => "isOrEverWasMadeForKids",
                AppsInAppPurchasesGetToManyRelatedFieldsApp.MarketplaceSearchDetail => "marketplaceSearchDetail",
                AppsInAppPurchasesGetToManyRelatedFieldsApp.Name => "name",
                AppsInAppPurchasesGetToManyRelatedFieldsApp.PerfPowerMetrics => "perfPowerMetrics",
                AppsInAppPurchasesGetToManyRelatedFieldsApp.PreReleaseVersions => "preReleaseVersions",
                AppsInAppPurchasesGetToManyRelatedFieldsApp.PrimaryLocale => "primaryLocale",
                AppsInAppPurchasesGetToManyRelatedFieldsApp.PromotedPurchases => "promotedPurchases",
                AppsInAppPurchasesGetToManyRelatedFieldsApp.ReviewSubmissions => "reviewSubmissions",
                AppsInAppPurchasesGetToManyRelatedFieldsApp.SearchKeywords => "searchKeywords",
                AppsInAppPurchasesGetToManyRelatedFieldsApp.Sku => "sku",
                AppsInAppPurchasesGetToManyRelatedFieldsApp.StreamlinedPurchasingEnabled => "streamlinedPurchasingEnabled",
                AppsInAppPurchasesGetToManyRelatedFieldsApp.SubscriptionGracePeriod => "subscriptionGracePeriod",
                AppsInAppPurchasesGetToManyRelatedFieldsApp.SubscriptionGroups => "subscriptionGroups",
                AppsInAppPurchasesGetToManyRelatedFieldsApp.SubscriptionStatusUrl => "subscriptionStatusUrl",
                AppsInAppPurchasesGetToManyRelatedFieldsApp.SubscriptionStatusUrlForSandbox => "subscriptionStatusUrlForSandbox",
                AppsInAppPurchasesGetToManyRelatedFieldsApp.SubscriptionStatusUrlVersion => "subscriptionStatusUrlVersion",
                AppsInAppPurchasesGetToManyRelatedFieldsApp.SubscriptionStatusUrlVersionForSandbox => "subscriptionStatusUrlVersionForSandbox",
                AppsInAppPurchasesGetToManyRelatedFieldsApp.Webhooks => "webhooks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsInAppPurchasesGetToManyRelatedFieldsApp? ToEnum(string value)
        {
            return value switch
            {
                "accessibilityDeclarations" => AppsInAppPurchasesGetToManyRelatedFieldsApp.AccessibilityDeclarations,
                "accessibilityUrl" => AppsInAppPurchasesGetToManyRelatedFieldsApp.AccessibilityUrl,
                "alternativeDistributionKey" => AppsInAppPurchasesGetToManyRelatedFieldsApp.AlternativeDistributionKey,
                "analyticsReportRequests" => AppsInAppPurchasesGetToManyRelatedFieldsApp.AnalyticsReportRequests,
                "androidToIosAppMappingDetails" => AppsInAppPurchasesGetToManyRelatedFieldsApp.AndroidToIosAppMappingDetails,
                "appAvailabilityV2" => AppsInAppPurchasesGetToManyRelatedFieldsApp.AppAvailabilityV2,
                "appClips" => AppsInAppPurchasesGetToManyRelatedFieldsApp.AppClips,
                "appCustomProductPages" => AppsInAppPurchasesGetToManyRelatedFieldsApp.AppCustomProductPages,
                "appEncryptionDeclarations" => AppsInAppPurchasesGetToManyRelatedFieldsApp.AppEncryptionDeclarations,
                "appEvents" => AppsInAppPurchasesGetToManyRelatedFieldsApp.AppEvents,
                "appInfos" => AppsInAppPurchasesGetToManyRelatedFieldsApp.AppInfos,
                "appPricePoints" => AppsInAppPurchasesGetToManyRelatedFieldsApp.AppPricePoints,
                "appPriceSchedule" => AppsInAppPurchasesGetToManyRelatedFieldsApp.AppPriceSchedule,
                "appStoreIcon" => AppsInAppPurchasesGetToManyRelatedFieldsApp.AppStoreIcon,
                "appStoreVersionExperimentsV2" => AppsInAppPurchasesGetToManyRelatedFieldsApp.AppStoreVersionExperimentsV2,
                "appStoreVersions" => AppsInAppPurchasesGetToManyRelatedFieldsApp.AppStoreVersions,
                "appTags" => AppsInAppPurchasesGetToManyRelatedFieldsApp.AppTags,
                "backgroundAssets" => AppsInAppPurchasesGetToManyRelatedFieldsApp.BackgroundAssets,
                "betaAppLocalizations" => AppsInAppPurchasesGetToManyRelatedFieldsApp.BetaAppLocalizations,
                "betaAppReviewDetail" => AppsInAppPurchasesGetToManyRelatedFieldsApp.BetaAppReviewDetail,
                "betaFeedbackCrashSubmissions" => AppsInAppPurchasesGetToManyRelatedFieldsApp.BetaFeedbackCrashSubmissions,
                "betaFeedbackScreenshotSubmissions" => AppsInAppPurchasesGetToManyRelatedFieldsApp.BetaFeedbackScreenshotSubmissions,
                "betaGroups" => AppsInAppPurchasesGetToManyRelatedFieldsApp.BetaGroups,
                "betaLicenseAgreement" => AppsInAppPurchasesGetToManyRelatedFieldsApp.BetaLicenseAgreement,
                "betaTesters" => AppsInAppPurchasesGetToManyRelatedFieldsApp.BetaTesters,
                "buildUploads" => AppsInAppPurchasesGetToManyRelatedFieldsApp.BuildUploads,
                "builds" => AppsInAppPurchasesGetToManyRelatedFieldsApp.Builds,
                "bundleId" => AppsInAppPurchasesGetToManyRelatedFieldsApp.BundleId,
                "ciProduct" => AppsInAppPurchasesGetToManyRelatedFieldsApp.CiProduct,
                "contentRightsDeclaration" => AppsInAppPurchasesGetToManyRelatedFieldsApp.ContentRightsDeclaration,
                "customerReviewSummarizations" => AppsInAppPurchasesGetToManyRelatedFieldsApp.CustomerReviewSummarizations,
                "customerReviews" => AppsInAppPurchasesGetToManyRelatedFieldsApp.CustomerReviews,
                "endUserLicenseAgreement" => AppsInAppPurchasesGetToManyRelatedFieldsApp.EndUserLicenseAgreement,
                "gameCenterDetail" => AppsInAppPurchasesGetToManyRelatedFieldsApp.GameCenterDetail,
                "gameCenterEnabledVersions" => AppsInAppPurchasesGetToManyRelatedFieldsApp.GameCenterEnabledVersions,
                "inAppPurchases" => AppsInAppPurchasesGetToManyRelatedFieldsApp.InAppPurchases,
                "inAppPurchasesV2" => AppsInAppPurchasesGetToManyRelatedFieldsApp.InAppPurchasesV2,
                "isOrEverWasMadeForKids" => AppsInAppPurchasesGetToManyRelatedFieldsApp.IsOrEverWasMadeForKids,
                "marketplaceSearchDetail" => AppsInAppPurchasesGetToManyRelatedFieldsApp.MarketplaceSearchDetail,
                "name" => AppsInAppPurchasesGetToManyRelatedFieldsApp.Name,
                "perfPowerMetrics" => AppsInAppPurchasesGetToManyRelatedFieldsApp.PerfPowerMetrics,
                "preReleaseVersions" => AppsInAppPurchasesGetToManyRelatedFieldsApp.PreReleaseVersions,
                "primaryLocale" => AppsInAppPurchasesGetToManyRelatedFieldsApp.PrimaryLocale,
                "promotedPurchases" => AppsInAppPurchasesGetToManyRelatedFieldsApp.PromotedPurchases,
                "reviewSubmissions" => AppsInAppPurchasesGetToManyRelatedFieldsApp.ReviewSubmissions,
                "searchKeywords" => AppsInAppPurchasesGetToManyRelatedFieldsApp.SearchKeywords,
                "sku" => AppsInAppPurchasesGetToManyRelatedFieldsApp.Sku,
                "streamlinedPurchasingEnabled" => AppsInAppPurchasesGetToManyRelatedFieldsApp.StreamlinedPurchasingEnabled,
                "subscriptionGracePeriod" => AppsInAppPurchasesGetToManyRelatedFieldsApp.SubscriptionGracePeriod,
                "subscriptionGroups" => AppsInAppPurchasesGetToManyRelatedFieldsApp.SubscriptionGroups,
                "subscriptionStatusUrl" => AppsInAppPurchasesGetToManyRelatedFieldsApp.SubscriptionStatusUrl,
                "subscriptionStatusUrlForSandbox" => AppsInAppPurchasesGetToManyRelatedFieldsApp.SubscriptionStatusUrlForSandbox,
                "subscriptionStatusUrlVersion" => AppsInAppPurchasesGetToManyRelatedFieldsApp.SubscriptionStatusUrlVersion,
                "subscriptionStatusUrlVersionForSandbox" => AppsInAppPurchasesGetToManyRelatedFieldsApp.SubscriptionStatusUrlVersionForSandbox,
                "webhooks" => AppsInAppPurchasesGetToManyRelatedFieldsApp.Webhooks,
                _ => null,
            };
        }
    }
}