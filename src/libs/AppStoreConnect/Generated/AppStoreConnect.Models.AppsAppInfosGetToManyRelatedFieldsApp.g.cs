
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsAppInfosGetToManyRelatedFieldsApp
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
    public static class AppsAppInfosGetToManyRelatedFieldsAppExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsAppInfosGetToManyRelatedFieldsApp value)
        {
            return value switch
            {
                AppsAppInfosGetToManyRelatedFieldsApp.AccessibilityDeclarations => "accessibilityDeclarations",
                AppsAppInfosGetToManyRelatedFieldsApp.AccessibilityUrl => "accessibilityUrl",
                AppsAppInfosGetToManyRelatedFieldsApp.AlternativeDistributionKey => "alternativeDistributionKey",
                AppsAppInfosGetToManyRelatedFieldsApp.AnalyticsReportRequests => "analyticsReportRequests",
                AppsAppInfosGetToManyRelatedFieldsApp.AndroidToIosAppMappingDetails => "androidToIosAppMappingDetails",
                AppsAppInfosGetToManyRelatedFieldsApp.AppAvailabilityV2 => "appAvailabilityV2",
                AppsAppInfosGetToManyRelatedFieldsApp.AppClips => "appClips",
                AppsAppInfosGetToManyRelatedFieldsApp.AppCustomProductPages => "appCustomProductPages",
                AppsAppInfosGetToManyRelatedFieldsApp.AppEncryptionDeclarations => "appEncryptionDeclarations",
                AppsAppInfosGetToManyRelatedFieldsApp.AppEvents => "appEvents",
                AppsAppInfosGetToManyRelatedFieldsApp.AppInfos => "appInfos",
                AppsAppInfosGetToManyRelatedFieldsApp.AppPricePoints => "appPricePoints",
                AppsAppInfosGetToManyRelatedFieldsApp.AppPriceSchedule => "appPriceSchedule",
                AppsAppInfosGetToManyRelatedFieldsApp.AppStoreIcon => "appStoreIcon",
                AppsAppInfosGetToManyRelatedFieldsApp.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                AppsAppInfosGetToManyRelatedFieldsApp.AppStoreVersions => "appStoreVersions",
                AppsAppInfosGetToManyRelatedFieldsApp.AppTags => "appTags",
                AppsAppInfosGetToManyRelatedFieldsApp.BackgroundAssets => "backgroundAssets",
                AppsAppInfosGetToManyRelatedFieldsApp.BetaAppLocalizations => "betaAppLocalizations",
                AppsAppInfosGetToManyRelatedFieldsApp.BetaAppReviewDetail => "betaAppReviewDetail",
                AppsAppInfosGetToManyRelatedFieldsApp.BetaFeedbackCrashSubmissions => "betaFeedbackCrashSubmissions",
                AppsAppInfosGetToManyRelatedFieldsApp.BetaFeedbackScreenshotSubmissions => "betaFeedbackScreenshotSubmissions",
                AppsAppInfosGetToManyRelatedFieldsApp.BetaGroups => "betaGroups",
                AppsAppInfosGetToManyRelatedFieldsApp.BetaLicenseAgreement => "betaLicenseAgreement",
                AppsAppInfosGetToManyRelatedFieldsApp.BetaTesters => "betaTesters",
                AppsAppInfosGetToManyRelatedFieldsApp.BuildUploads => "buildUploads",
                AppsAppInfosGetToManyRelatedFieldsApp.Builds => "builds",
                AppsAppInfosGetToManyRelatedFieldsApp.BundleId => "bundleId",
                AppsAppInfosGetToManyRelatedFieldsApp.CiProduct => "ciProduct",
                AppsAppInfosGetToManyRelatedFieldsApp.ContentRightsDeclaration => "contentRightsDeclaration",
                AppsAppInfosGetToManyRelatedFieldsApp.CustomerReviewSummarizations => "customerReviewSummarizations",
                AppsAppInfosGetToManyRelatedFieldsApp.CustomerReviews => "customerReviews",
                AppsAppInfosGetToManyRelatedFieldsApp.EndUserLicenseAgreement => "endUserLicenseAgreement",
                AppsAppInfosGetToManyRelatedFieldsApp.GameCenterDetail => "gameCenterDetail",
                AppsAppInfosGetToManyRelatedFieldsApp.GameCenterEnabledVersions => "gameCenterEnabledVersions",
                AppsAppInfosGetToManyRelatedFieldsApp.InAppPurchases => "inAppPurchases",
                AppsAppInfosGetToManyRelatedFieldsApp.InAppPurchasesV2 => "inAppPurchasesV2",
                AppsAppInfosGetToManyRelatedFieldsApp.IsOrEverWasMadeForKids => "isOrEverWasMadeForKids",
                AppsAppInfosGetToManyRelatedFieldsApp.MarketplaceSearchDetail => "marketplaceSearchDetail",
                AppsAppInfosGetToManyRelatedFieldsApp.Name => "name",
                AppsAppInfosGetToManyRelatedFieldsApp.PerfPowerMetrics => "perfPowerMetrics",
                AppsAppInfosGetToManyRelatedFieldsApp.PreReleaseVersions => "preReleaseVersions",
                AppsAppInfosGetToManyRelatedFieldsApp.PrimaryLocale => "primaryLocale",
                AppsAppInfosGetToManyRelatedFieldsApp.PromotedPurchases => "promotedPurchases",
                AppsAppInfosGetToManyRelatedFieldsApp.ReviewSubmissions => "reviewSubmissions",
                AppsAppInfosGetToManyRelatedFieldsApp.SearchKeywords => "searchKeywords",
                AppsAppInfosGetToManyRelatedFieldsApp.Sku => "sku",
                AppsAppInfosGetToManyRelatedFieldsApp.StreamlinedPurchasingEnabled => "streamlinedPurchasingEnabled",
                AppsAppInfosGetToManyRelatedFieldsApp.SubscriptionGracePeriod => "subscriptionGracePeriod",
                AppsAppInfosGetToManyRelatedFieldsApp.SubscriptionGroups => "subscriptionGroups",
                AppsAppInfosGetToManyRelatedFieldsApp.SubscriptionStatusUrl => "subscriptionStatusUrl",
                AppsAppInfosGetToManyRelatedFieldsApp.SubscriptionStatusUrlForSandbox => "subscriptionStatusUrlForSandbox",
                AppsAppInfosGetToManyRelatedFieldsApp.SubscriptionStatusUrlVersion => "subscriptionStatusUrlVersion",
                AppsAppInfosGetToManyRelatedFieldsApp.SubscriptionStatusUrlVersionForSandbox => "subscriptionStatusUrlVersionForSandbox",
                AppsAppInfosGetToManyRelatedFieldsApp.Webhooks => "webhooks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsAppInfosGetToManyRelatedFieldsApp? ToEnum(string value)
        {
            return value switch
            {
                "accessibilityDeclarations" => AppsAppInfosGetToManyRelatedFieldsApp.AccessibilityDeclarations,
                "accessibilityUrl" => AppsAppInfosGetToManyRelatedFieldsApp.AccessibilityUrl,
                "alternativeDistributionKey" => AppsAppInfosGetToManyRelatedFieldsApp.AlternativeDistributionKey,
                "analyticsReportRequests" => AppsAppInfosGetToManyRelatedFieldsApp.AnalyticsReportRequests,
                "androidToIosAppMappingDetails" => AppsAppInfosGetToManyRelatedFieldsApp.AndroidToIosAppMappingDetails,
                "appAvailabilityV2" => AppsAppInfosGetToManyRelatedFieldsApp.AppAvailabilityV2,
                "appClips" => AppsAppInfosGetToManyRelatedFieldsApp.AppClips,
                "appCustomProductPages" => AppsAppInfosGetToManyRelatedFieldsApp.AppCustomProductPages,
                "appEncryptionDeclarations" => AppsAppInfosGetToManyRelatedFieldsApp.AppEncryptionDeclarations,
                "appEvents" => AppsAppInfosGetToManyRelatedFieldsApp.AppEvents,
                "appInfos" => AppsAppInfosGetToManyRelatedFieldsApp.AppInfos,
                "appPricePoints" => AppsAppInfosGetToManyRelatedFieldsApp.AppPricePoints,
                "appPriceSchedule" => AppsAppInfosGetToManyRelatedFieldsApp.AppPriceSchedule,
                "appStoreIcon" => AppsAppInfosGetToManyRelatedFieldsApp.AppStoreIcon,
                "appStoreVersionExperimentsV2" => AppsAppInfosGetToManyRelatedFieldsApp.AppStoreVersionExperimentsV2,
                "appStoreVersions" => AppsAppInfosGetToManyRelatedFieldsApp.AppStoreVersions,
                "appTags" => AppsAppInfosGetToManyRelatedFieldsApp.AppTags,
                "backgroundAssets" => AppsAppInfosGetToManyRelatedFieldsApp.BackgroundAssets,
                "betaAppLocalizations" => AppsAppInfosGetToManyRelatedFieldsApp.BetaAppLocalizations,
                "betaAppReviewDetail" => AppsAppInfosGetToManyRelatedFieldsApp.BetaAppReviewDetail,
                "betaFeedbackCrashSubmissions" => AppsAppInfosGetToManyRelatedFieldsApp.BetaFeedbackCrashSubmissions,
                "betaFeedbackScreenshotSubmissions" => AppsAppInfosGetToManyRelatedFieldsApp.BetaFeedbackScreenshotSubmissions,
                "betaGroups" => AppsAppInfosGetToManyRelatedFieldsApp.BetaGroups,
                "betaLicenseAgreement" => AppsAppInfosGetToManyRelatedFieldsApp.BetaLicenseAgreement,
                "betaTesters" => AppsAppInfosGetToManyRelatedFieldsApp.BetaTesters,
                "buildUploads" => AppsAppInfosGetToManyRelatedFieldsApp.BuildUploads,
                "builds" => AppsAppInfosGetToManyRelatedFieldsApp.Builds,
                "bundleId" => AppsAppInfosGetToManyRelatedFieldsApp.BundleId,
                "ciProduct" => AppsAppInfosGetToManyRelatedFieldsApp.CiProduct,
                "contentRightsDeclaration" => AppsAppInfosGetToManyRelatedFieldsApp.ContentRightsDeclaration,
                "customerReviewSummarizations" => AppsAppInfosGetToManyRelatedFieldsApp.CustomerReviewSummarizations,
                "customerReviews" => AppsAppInfosGetToManyRelatedFieldsApp.CustomerReviews,
                "endUserLicenseAgreement" => AppsAppInfosGetToManyRelatedFieldsApp.EndUserLicenseAgreement,
                "gameCenterDetail" => AppsAppInfosGetToManyRelatedFieldsApp.GameCenterDetail,
                "gameCenterEnabledVersions" => AppsAppInfosGetToManyRelatedFieldsApp.GameCenterEnabledVersions,
                "inAppPurchases" => AppsAppInfosGetToManyRelatedFieldsApp.InAppPurchases,
                "inAppPurchasesV2" => AppsAppInfosGetToManyRelatedFieldsApp.InAppPurchasesV2,
                "isOrEverWasMadeForKids" => AppsAppInfosGetToManyRelatedFieldsApp.IsOrEverWasMadeForKids,
                "marketplaceSearchDetail" => AppsAppInfosGetToManyRelatedFieldsApp.MarketplaceSearchDetail,
                "name" => AppsAppInfosGetToManyRelatedFieldsApp.Name,
                "perfPowerMetrics" => AppsAppInfosGetToManyRelatedFieldsApp.PerfPowerMetrics,
                "preReleaseVersions" => AppsAppInfosGetToManyRelatedFieldsApp.PreReleaseVersions,
                "primaryLocale" => AppsAppInfosGetToManyRelatedFieldsApp.PrimaryLocale,
                "promotedPurchases" => AppsAppInfosGetToManyRelatedFieldsApp.PromotedPurchases,
                "reviewSubmissions" => AppsAppInfosGetToManyRelatedFieldsApp.ReviewSubmissions,
                "searchKeywords" => AppsAppInfosGetToManyRelatedFieldsApp.SearchKeywords,
                "sku" => AppsAppInfosGetToManyRelatedFieldsApp.Sku,
                "streamlinedPurchasingEnabled" => AppsAppInfosGetToManyRelatedFieldsApp.StreamlinedPurchasingEnabled,
                "subscriptionGracePeriod" => AppsAppInfosGetToManyRelatedFieldsApp.SubscriptionGracePeriod,
                "subscriptionGroups" => AppsAppInfosGetToManyRelatedFieldsApp.SubscriptionGroups,
                "subscriptionStatusUrl" => AppsAppInfosGetToManyRelatedFieldsApp.SubscriptionStatusUrl,
                "subscriptionStatusUrlForSandbox" => AppsAppInfosGetToManyRelatedFieldsApp.SubscriptionStatusUrlForSandbox,
                "subscriptionStatusUrlVersion" => AppsAppInfosGetToManyRelatedFieldsApp.SubscriptionStatusUrlVersion,
                "subscriptionStatusUrlVersionForSandbox" => AppsAppInfosGetToManyRelatedFieldsApp.SubscriptionStatusUrlVersionForSandbox,
                "webhooks" => AppsAppInfosGetToManyRelatedFieldsApp.Webhooks,
                _ => null,
            };
        }
    }
}