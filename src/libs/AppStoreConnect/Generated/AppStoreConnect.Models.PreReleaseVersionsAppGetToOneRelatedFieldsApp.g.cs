
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum PreReleaseVersionsAppGetToOneRelatedFieldsApp
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
    public static class PreReleaseVersionsAppGetToOneRelatedFieldsAppExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PreReleaseVersionsAppGetToOneRelatedFieldsApp value)
        {
            return value switch
            {
                PreReleaseVersionsAppGetToOneRelatedFieldsApp.AccessibilityDeclarations => "accessibilityDeclarations",
                PreReleaseVersionsAppGetToOneRelatedFieldsApp.AccessibilityUrl => "accessibilityUrl",
                PreReleaseVersionsAppGetToOneRelatedFieldsApp.AlternativeDistributionKey => "alternativeDistributionKey",
                PreReleaseVersionsAppGetToOneRelatedFieldsApp.AnalyticsReportRequests => "analyticsReportRequests",
                PreReleaseVersionsAppGetToOneRelatedFieldsApp.AndroidToIosAppMappingDetails => "androidToIosAppMappingDetails",
                PreReleaseVersionsAppGetToOneRelatedFieldsApp.AppAvailabilityV2 => "appAvailabilityV2",
                PreReleaseVersionsAppGetToOneRelatedFieldsApp.AppClips => "appClips",
                PreReleaseVersionsAppGetToOneRelatedFieldsApp.AppCustomProductPages => "appCustomProductPages",
                PreReleaseVersionsAppGetToOneRelatedFieldsApp.AppEncryptionDeclarations => "appEncryptionDeclarations",
                PreReleaseVersionsAppGetToOneRelatedFieldsApp.AppEvents => "appEvents",
                PreReleaseVersionsAppGetToOneRelatedFieldsApp.AppInfos => "appInfos",
                PreReleaseVersionsAppGetToOneRelatedFieldsApp.AppPricePoints => "appPricePoints",
                PreReleaseVersionsAppGetToOneRelatedFieldsApp.AppPriceSchedule => "appPriceSchedule",
                PreReleaseVersionsAppGetToOneRelatedFieldsApp.AppStoreIcon => "appStoreIcon",
                PreReleaseVersionsAppGetToOneRelatedFieldsApp.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                PreReleaseVersionsAppGetToOneRelatedFieldsApp.AppStoreVersions => "appStoreVersions",
                PreReleaseVersionsAppGetToOneRelatedFieldsApp.AppTags => "appTags",
                PreReleaseVersionsAppGetToOneRelatedFieldsApp.BackgroundAssets => "backgroundAssets",
                PreReleaseVersionsAppGetToOneRelatedFieldsApp.BetaAppLocalizations => "betaAppLocalizations",
                PreReleaseVersionsAppGetToOneRelatedFieldsApp.BetaAppReviewDetail => "betaAppReviewDetail",
                PreReleaseVersionsAppGetToOneRelatedFieldsApp.BetaFeedbackCrashSubmissions => "betaFeedbackCrashSubmissions",
                PreReleaseVersionsAppGetToOneRelatedFieldsApp.BetaFeedbackScreenshotSubmissions => "betaFeedbackScreenshotSubmissions",
                PreReleaseVersionsAppGetToOneRelatedFieldsApp.BetaGroups => "betaGroups",
                PreReleaseVersionsAppGetToOneRelatedFieldsApp.BetaLicenseAgreement => "betaLicenseAgreement",
                PreReleaseVersionsAppGetToOneRelatedFieldsApp.BetaTesters => "betaTesters",
                PreReleaseVersionsAppGetToOneRelatedFieldsApp.BuildUploads => "buildUploads",
                PreReleaseVersionsAppGetToOneRelatedFieldsApp.Builds => "builds",
                PreReleaseVersionsAppGetToOneRelatedFieldsApp.BundleId => "bundleId",
                PreReleaseVersionsAppGetToOneRelatedFieldsApp.CiProduct => "ciProduct",
                PreReleaseVersionsAppGetToOneRelatedFieldsApp.ContentRightsDeclaration => "contentRightsDeclaration",
                PreReleaseVersionsAppGetToOneRelatedFieldsApp.CustomerReviewSummarizations => "customerReviewSummarizations",
                PreReleaseVersionsAppGetToOneRelatedFieldsApp.CustomerReviews => "customerReviews",
                PreReleaseVersionsAppGetToOneRelatedFieldsApp.EndUserLicenseAgreement => "endUserLicenseAgreement",
                PreReleaseVersionsAppGetToOneRelatedFieldsApp.GameCenterDetail => "gameCenterDetail",
                PreReleaseVersionsAppGetToOneRelatedFieldsApp.GameCenterEnabledVersions => "gameCenterEnabledVersions",
                PreReleaseVersionsAppGetToOneRelatedFieldsApp.InAppPurchases => "inAppPurchases",
                PreReleaseVersionsAppGetToOneRelatedFieldsApp.InAppPurchasesV2 => "inAppPurchasesV2",
                PreReleaseVersionsAppGetToOneRelatedFieldsApp.IsOrEverWasMadeForKids => "isOrEverWasMadeForKids",
                PreReleaseVersionsAppGetToOneRelatedFieldsApp.MarketplaceSearchDetail => "marketplaceSearchDetail",
                PreReleaseVersionsAppGetToOneRelatedFieldsApp.Name => "name",
                PreReleaseVersionsAppGetToOneRelatedFieldsApp.PerfPowerMetrics => "perfPowerMetrics",
                PreReleaseVersionsAppGetToOneRelatedFieldsApp.PreReleaseVersions => "preReleaseVersions",
                PreReleaseVersionsAppGetToOneRelatedFieldsApp.PrimaryLocale => "primaryLocale",
                PreReleaseVersionsAppGetToOneRelatedFieldsApp.PromotedPurchases => "promotedPurchases",
                PreReleaseVersionsAppGetToOneRelatedFieldsApp.ReviewSubmissions => "reviewSubmissions",
                PreReleaseVersionsAppGetToOneRelatedFieldsApp.SearchKeywords => "searchKeywords",
                PreReleaseVersionsAppGetToOneRelatedFieldsApp.Sku => "sku",
                PreReleaseVersionsAppGetToOneRelatedFieldsApp.StreamlinedPurchasingEnabled => "streamlinedPurchasingEnabled",
                PreReleaseVersionsAppGetToOneRelatedFieldsApp.SubscriptionGracePeriod => "subscriptionGracePeriod",
                PreReleaseVersionsAppGetToOneRelatedFieldsApp.SubscriptionGroups => "subscriptionGroups",
                PreReleaseVersionsAppGetToOneRelatedFieldsApp.SubscriptionStatusUrl => "subscriptionStatusUrl",
                PreReleaseVersionsAppGetToOneRelatedFieldsApp.SubscriptionStatusUrlForSandbox => "subscriptionStatusUrlForSandbox",
                PreReleaseVersionsAppGetToOneRelatedFieldsApp.SubscriptionStatusUrlVersion => "subscriptionStatusUrlVersion",
                PreReleaseVersionsAppGetToOneRelatedFieldsApp.SubscriptionStatusUrlVersionForSandbox => "subscriptionStatusUrlVersionForSandbox",
                PreReleaseVersionsAppGetToOneRelatedFieldsApp.Webhooks => "webhooks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PreReleaseVersionsAppGetToOneRelatedFieldsApp? ToEnum(string value)
        {
            return value switch
            {
                "accessibilityDeclarations" => PreReleaseVersionsAppGetToOneRelatedFieldsApp.AccessibilityDeclarations,
                "accessibilityUrl" => PreReleaseVersionsAppGetToOneRelatedFieldsApp.AccessibilityUrl,
                "alternativeDistributionKey" => PreReleaseVersionsAppGetToOneRelatedFieldsApp.AlternativeDistributionKey,
                "analyticsReportRequests" => PreReleaseVersionsAppGetToOneRelatedFieldsApp.AnalyticsReportRequests,
                "androidToIosAppMappingDetails" => PreReleaseVersionsAppGetToOneRelatedFieldsApp.AndroidToIosAppMappingDetails,
                "appAvailabilityV2" => PreReleaseVersionsAppGetToOneRelatedFieldsApp.AppAvailabilityV2,
                "appClips" => PreReleaseVersionsAppGetToOneRelatedFieldsApp.AppClips,
                "appCustomProductPages" => PreReleaseVersionsAppGetToOneRelatedFieldsApp.AppCustomProductPages,
                "appEncryptionDeclarations" => PreReleaseVersionsAppGetToOneRelatedFieldsApp.AppEncryptionDeclarations,
                "appEvents" => PreReleaseVersionsAppGetToOneRelatedFieldsApp.AppEvents,
                "appInfos" => PreReleaseVersionsAppGetToOneRelatedFieldsApp.AppInfos,
                "appPricePoints" => PreReleaseVersionsAppGetToOneRelatedFieldsApp.AppPricePoints,
                "appPriceSchedule" => PreReleaseVersionsAppGetToOneRelatedFieldsApp.AppPriceSchedule,
                "appStoreIcon" => PreReleaseVersionsAppGetToOneRelatedFieldsApp.AppStoreIcon,
                "appStoreVersionExperimentsV2" => PreReleaseVersionsAppGetToOneRelatedFieldsApp.AppStoreVersionExperimentsV2,
                "appStoreVersions" => PreReleaseVersionsAppGetToOneRelatedFieldsApp.AppStoreVersions,
                "appTags" => PreReleaseVersionsAppGetToOneRelatedFieldsApp.AppTags,
                "backgroundAssets" => PreReleaseVersionsAppGetToOneRelatedFieldsApp.BackgroundAssets,
                "betaAppLocalizations" => PreReleaseVersionsAppGetToOneRelatedFieldsApp.BetaAppLocalizations,
                "betaAppReviewDetail" => PreReleaseVersionsAppGetToOneRelatedFieldsApp.BetaAppReviewDetail,
                "betaFeedbackCrashSubmissions" => PreReleaseVersionsAppGetToOneRelatedFieldsApp.BetaFeedbackCrashSubmissions,
                "betaFeedbackScreenshotSubmissions" => PreReleaseVersionsAppGetToOneRelatedFieldsApp.BetaFeedbackScreenshotSubmissions,
                "betaGroups" => PreReleaseVersionsAppGetToOneRelatedFieldsApp.BetaGroups,
                "betaLicenseAgreement" => PreReleaseVersionsAppGetToOneRelatedFieldsApp.BetaLicenseAgreement,
                "betaTesters" => PreReleaseVersionsAppGetToOneRelatedFieldsApp.BetaTesters,
                "buildUploads" => PreReleaseVersionsAppGetToOneRelatedFieldsApp.BuildUploads,
                "builds" => PreReleaseVersionsAppGetToOneRelatedFieldsApp.Builds,
                "bundleId" => PreReleaseVersionsAppGetToOneRelatedFieldsApp.BundleId,
                "ciProduct" => PreReleaseVersionsAppGetToOneRelatedFieldsApp.CiProduct,
                "contentRightsDeclaration" => PreReleaseVersionsAppGetToOneRelatedFieldsApp.ContentRightsDeclaration,
                "customerReviewSummarizations" => PreReleaseVersionsAppGetToOneRelatedFieldsApp.CustomerReviewSummarizations,
                "customerReviews" => PreReleaseVersionsAppGetToOneRelatedFieldsApp.CustomerReviews,
                "endUserLicenseAgreement" => PreReleaseVersionsAppGetToOneRelatedFieldsApp.EndUserLicenseAgreement,
                "gameCenterDetail" => PreReleaseVersionsAppGetToOneRelatedFieldsApp.GameCenterDetail,
                "gameCenterEnabledVersions" => PreReleaseVersionsAppGetToOneRelatedFieldsApp.GameCenterEnabledVersions,
                "inAppPurchases" => PreReleaseVersionsAppGetToOneRelatedFieldsApp.InAppPurchases,
                "inAppPurchasesV2" => PreReleaseVersionsAppGetToOneRelatedFieldsApp.InAppPurchasesV2,
                "isOrEverWasMadeForKids" => PreReleaseVersionsAppGetToOneRelatedFieldsApp.IsOrEverWasMadeForKids,
                "marketplaceSearchDetail" => PreReleaseVersionsAppGetToOneRelatedFieldsApp.MarketplaceSearchDetail,
                "name" => PreReleaseVersionsAppGetToOneRelatedFieldsApp.Name,
                "perfPowerMetrics" => PreReleaseVersionsAppGetToOneRelatedFieldsApp.PerfPowerMetrics,
                "preReleaseVersions" => PreReleaseVersionsAppGetToOneRelatedFieldsApp.PreReleaseVersions,
                "primaryLocale" => PreReleaseVersionsAppGetToOneRelatedFieldsApp.PrimaryLocale,
                "promotedPurchases" => PreReleaseVersionsAppGetToOneRelatedFieldsApp.PromotedPurchases,
                "reviewSubmissions" => PreReleaseVersionsAppGetToOneRelatedFieldsApp.ReviewSubmissions,
                "searchKeywords" => PreReleaseVersionsAppGetToOneRelatedFieldsApp.SearchKeywords,
                "sku" => PreReleaseVersionsAppGetToOneRelatedFieldsApp.Sku,
                "streamlinedPurchasingEnabled" => PreReleaseVersionsAppGetToOneRelatedFieldsApp.StreamlinedPurchasingEnabled,
                "subscriptionGracePeriod" => PreReleaseVersionsAppGetToOneRelatedFieldsApp.SubscriptionGracePeriod,
                "subscriptionGroups" => PreReleaseVersionsAppGetToOneRelatedFieldsApp.SubscriptionGroups,
                "subscriptionStatusUrl" => PreReleaseVersionsAppGetToOneRelatedFieldsApp.SubscriptionStatusUrl,
                "subscriptionStatusUrlForSandbox" => PreReleaseVersionsAppGetToOneRelatedFieldsApp.SubscriptionStatusUrlForSandbox,
                "subscriptionStatusUrlVersion" => PreReleaseVersionsAppGetToOneRelatedFieldsApp.SubscriptionStatusUrlVersion,
                "subscriptionStatusUrlVersionForSandbox" => PreReleaseVersionsAppGetToOneRelatedFieldsApp.SubscriptionStatusUrlVersionForSandbox,
                "webhooks" => PreReleaseVersionsAppGetToOneRelatedFieldsApp.Webhooks,
                _ => null,
            };
        }
    }
}