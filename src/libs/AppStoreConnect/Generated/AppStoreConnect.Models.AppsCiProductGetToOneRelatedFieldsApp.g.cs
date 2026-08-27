
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsCiProductGetToOneRelatedFieldsApp
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
    public static class AppsCiProductGetToOneRelatedFieldsAppExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsCiProductGetToOneRelatedFieldsApp value)
        {
            return value switch
            {
                AppsCiProductGetToOneRelatedFieldsApp.AccessibilityDeclarations => "accessibilityDeclarations",
                AppsCiProductGetToOneRelatedFieldsApp.AccessibilityUrl => "accessibilityUrl",
                AppsCiProductGetToOneRelatedFieldsApp.AlternativeDistributionKey => "alternativeDistributionKey",
                AppsCiProductGetToOneRelatedFieldsApp.AnalyticsReportRequests => "analyticsReportRequests",
                AppsCiProductGetToOneRelatedFieldsApp.AndroidToIosAppMappingDetails => "androidToIosAppMappingDetails",
                AppsCiProductGetToOneRelatedFieldsApp.AppAvailabilityV2 => "appAvailabilityV2",
                AppsCiProductGetToOneRelatedFieldsApp.AppClips => "appClips",
                AppsCiProductGetToOneRelatedFieldsApp.AppCustomProductPages => "appCustomProductPages",
                AppsCiProductGetToOneRelatedFieldsApp.AppEncryptionDeclarations => "appEncryptionDeclarations",
                AppsCiProductGetToOneRelatedFieldsApp.AppEvents => "appEvents",
                AppsCiProductGetToOneRelatedFieldsApp.AppInfos => "appInfos",
                AppsCiProductGetToOneRelatedFieldsApp.AppPricePoints => "appPricePoints",
                AppsCiProductGetToOneRelatedFieldsApp.AppPriceSchedule => "appPriceSchedule",
                AppsCiProductGetToOneRelatedFieldsApp.AppStoreIcon => "appStoreIcon",
                AppsCiProductGetToOneRelatedFieldsApp.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                AppsCiProductGetToOneRelatedFieldsApp.AppStoreVersions => "appStoreVersions",
                AppsCiProductGetToOneRelatedFieldsApp.AppTags => "appTags",
                AppsCiProductGetToOneRelatedFieldsApp.BackgroundAssets => "backgroundAssets",
                AppsCiProductGetToOneRelatedFieldsApp.BetaAppLocalizations => "betaAppLocalizations",
                AppsCiProductGetToOneRelatedFieldsApp.BetaAppReviewDetail => "betaAppReviewDetail",
                AppsCiProductGetToOneRelatedFieldsApp.BetaFeedbackCrashSubmissions => "betaFeedbackCrashSubmissions",
                AppsCiProductGetToOneRelatedFieldsApp.BetaFeedbackScreenshotSubmissions => "betaFeedbackScreenshotSubmissions",
                AppsCiProductGetToOneRelatedFieldsApp.BetaGroups => "betaGroups",
                AppsCiProductGetToOneRelatedFieldsApp.BetaLicenseAgreement => "betaLicenseAgreement",
                AppsCiProductGetToOneRelatedFieldsApp.BetaTesters => "betaTesters",
                AppsCiProductGetToOneRelatedFieldsApp.BuildUploads => "buildUploads",
                AppsCiProductGetToOneRelatedFieldsApp.Builds => "builds",
                AppsCiProductGetToOneRelatedFieldsApp.BundleId => "bundleId",
                AppsCiProductGetToOneRelatedFieldsApp.CiProduct => "ciProduct",
                AppsCiProductGetToOneRelatedFieldsApp.ContentRightsDeclaration => "contentRightsDeclaration",
                AppsCiProductGetToOneRelatedFieldsApp.CustomerReviewSummarizations => "customerReviewSummarizations",
                AppsCiProductGetToOneRelatedFieldsApp.CustomerReviews => "customerReviews",
                AppsCiProductGetToOneRelatedFieldsApp.EndUserLicenseAgreement => "endUserLicenseAgreement",
                AppsCiProductGetToOneRelatedFieldsApp.GameCenterDetail => "gameCenterDetail",
                AppsCiProductGetToOneRelatedFieldsApp.GameCenterEnabledVersions => "gameCenterEnabledVersions",
                AppsCiProductGetToOneRelatedFieldsApp.InAppPurchases => "inAppPurchases",
                AppsCiProductGetToOneRelatedFieldsApp.InAppPurchasesV2 => "inAppPurchasesV2",
                AppsCiProductGetToOneRelatedFieldsApp.IsOrEverWasMadeForKids => "isOrEverWasMadeForKids",
                AppsCiProductGetToOneRelatedFieldsApp.MarketplaceSearchDetail => "marketplaceSearchDetail",
                AppsCiProductGetToOneRelatedFieldsApp.Name => "name",
                AppsCiProductGetToOneRelatedFieldsApp.PerfPowerMetrics => "perfPowerMetrics",
                AppsCiProductGetToOneRelatedFieldsApp.PreReleaseVersions => "preReleaseVersions",
                AppsCiProductGetToOneRelatedFieldsApp.PrimaryLocale => "primaryLocale",
                AppsCiProductGetToOneRelatedFieldsApp.PromotedPurchases => "promotedPurchases",
                AppsCiProductGetToOneRelatedFieldsApp.ReviewSubmissions => "reviewSubmissions",
                AppsCiProductGetToOneRelatedFieldsApp.SearchKeywords => "searchKeywords",
                AppsCiProductGetToOneRelatedFieldsApp.Sku => "sku",
                AppsCiProductGetToOneRelatedFieldsApp.StreamlinedPurchasingEnabled => "streamlinedPurchasingEnabled",
                AppsCiProductGetToOneRelatedFieldsApp.SubscriptionGracePeriod => "subscriptionGracePeriod",
                AppsCiProductGetToOneRelatedFieldsApp.SubscriptionGroups => "subscriptionGroups",
                AppsCiProductGetToOneRelatedFieldsApp.SubscriptionStatusUrl => "subscriptionStatusUrl",
                AppsCiProductGetToOneRelatedFieldsApp.SubscriptionStatusUrlForSandbox => "subscriptionStatusUrlForSandbox",
                AppsCiProductGetToOneRelatedFieldsApp.SubscriptionStatusUrlVersion => "subscriptionStatusUrlVersion",
                AppsCiProductGetToOneRelatedFieldsApp.SubscriptionStatusUrlVersionForSandbox => "subscriptionStatusUrlVersionForSandbox",
                AppsCiProductGetToOneRelatedFieldsApp.Webhooks => "webhooks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsCiProductGetToOneRelatedFieldsApp? ToEnum(string value)
        {
            return value switch
            {
                "accessibilityDeclarations" => AppsCiProductGetToOneRelatedFieldsApp.AccessibilityDeclarations,
                "accessibilityUrl" => AppsCiProductGetToOneRelatedFieldsApp.AccessibilityUrl,
                "alternativeDistributionKey" => AppsCiProductGetToOneRelatedFieldsApp.AlternativeDistributionKey,
                "analyticsReportRequests" => AppsCiProductGetToOneRelatedFieldsApp.AnalyticsReportRequests,
                "androidToIosAppMappingDetails" => AppsCiProductGetToOneRelatedFieldsApp.AndroidToIosAppMappingDetails,
                "appAvailabilityV2" => AppsCiProductGetToOneRelatedFieldsApp.AppAvailabilityV2,
                "appClips" => AppsCiProductGetToOneRelatedFieldsApp.AppClips,
                "appCustomProductPages" => AppsCiProductGetToOneRelatedFieldsApp.AppCustomProductPages,
                "appEncryptionDeclarations" => AppsCiProductGetToOneRelatedFieldsApp.AppEncryptionDeclarations,
                "appEvents" => AppsCiProductGetToOneRelatedFieldsApp.AppEvents,
                "appInfos" => AppsCiProductGetToOneRelatedFieldsApp.AppInfos,
                "appPricePoints" => AppsCiProductGetToOneRelatedFieldsApp.AppPricePoints,
                "appPriceSchedule" => AppsCiProductGetToOneRelatedFieldsApp.AppPriceSchedule,
                "appStoreIcon" => AppsCiProductGetToOneRelatedFieldsApp.AppStoreIcon,
                "appStoreVersionExperimentsV2" => AppsCiProductGetToOneRelatedFieldsApp.AppStoreVersionExperimentsV2,
                "appStoreVersions" => AppsCiProductGetToOneRelatedFieldsApp.AppStoreVersions,
                "appTags" => AppsCiProductGetToOneRelatedFieldsApp.AppTags,
                "backgroundAssets" => AppsCiProductGetToOneRelatedFieldsApp.BackgroundAssets,
                "betaAppLocalizations" => AppsCiProductGetToOneRelatedFieldsApp.BetaAppLocalizations,
                "betaAppReviewDetail" => AppsCiProductGetToOneRelatedFieldsApp.BetaAppReviewDetail,
                "betaFeedbackCrashSubmissions" => AppsCiProductGetToOneRelatedFieldsApp.BetaFeedbackCrashSubmissions,
                "betaFeedbackScreenshotSubmissions" => AppsCiProductGetToOneRelatedFieldsApp.BetaFeedbackScreenshotSubmissions,
                "betaGroups" => AppsCiProductGetToOneRelatedFieldsApp.BetaGroups,
                "betaLicenseAgreement" => AppsCiProductGetToOneRelatedFieldsApp.BetaLicenseAgreement,
                "betaTesters" => AppsCiProductGetToOneRelatedFieldsApp.BetaTesters,
                "buildUploads" => AppsCiProductGetToOneRelatedFieldsApp.BuildUploads,
                "builds" => AppsCiProductGetToOneRelatedFieldsApp.Builds,
                "bundleId" => AppsCiProductGetToOneRelatedFieldsApp.BundleId,
                "ciProduct" => AppsCiProductGetToOneRelatedFieldsApp.CiProduct,
                "contentRightsDeclaration" => AppsCiProductGetToOneRelatedFieldsApp.ContentRightsDeclaration,
                "customerReviewSummarizations" => AppsCiProductGetToOneRelatedFieldsApp.CustomerReviewSummarizations,
                "customerReviews" => AppsCiProductGetToOneRelatedFieldsApp.CustomerReviews,
                "endUserLicenseAgreement" => AppsCiProductGetToOneRelatedFieldsApp.EndUserLicenseAgreement,
                "gameCenterDetail" => AppsCiProductGetToOneRelatedFieldsApp.GameCenterDetail,
                "gameCenterEnabledVersions" => AppsCiProductGetToOneRelatedFieldsApp.GameCenterEnabledVersions,
                "inAppPurchases" => AppsCiProductGetToOneRelatedFieldsApp.InAppPurchases,
                "inAppPurchasesV2" => AppsCiProductGetToOneRelatedFieldsApp.InAppPurchasesV2,
                "isOrEverWasMadeForKids" => AppsCiProductGetToOneRelatedFieldsApp.IsOrEverWasMadeForKids,
                "marketplaceSearchDetail" => AppsCiProductGetToOneRelatedFieldsApp.MarketplaceSearchDetail,
                "name" => AppsCiProductGetToOneRelatedFieldsApp.Name,
                "perfPowerMetrics" => AppsCiProductGetToOneRelatedFieldsApp.PerfPowerMetrics,
                "preReleaseVersions" => AppsCiProductGetToOneRelatedFieldsApp.PreReleaseVersions,
                "primaryLocale" => AppsCiProductGetToOneRelatedFieldsApp.PrimaryLocale,
                "promotedPurchases" => AppsCiProductGetToOneRelatedFieldsApp.PromotedPurchases,
                "reviewSubmissions" => AppsCiProductGetToOneRelatedFieldsApp.ReviewSubmissions,
                "searchKeywords" => AppsCiProductGetToOneRelatedFieldsApp.SearchKeywords,
                "sku" => AppsCiProductGetToOneRelatedFieldsApp.Sku,
                "streamlinedPurchasingEnabled" => AppsCiProductGetToOneRelatedFieldsApp.StreamlinedPurchasingEnabled,
                "subscriptionGracePeriod" => AppsCiProductGetToOneRelatedFieldsApp.SubscriptionGracePeriod,
                "subscriptionGroups" => AppsCiProductGetToOneRelatedFieldsApp.SubscriptionGroups,
                "subscriptionStatusUrl" => AppsCiProductGetToOneRelatedFieldsApp.SubscriptionStatusUrl,
                "subscriptionStatusUrlForSandbox" => AppsCiProductGetToOneRelatedFieldsApp.SubscriptionStatusUrlForSandbox,
                "subscriptionStatusUrlVersion" => AppsCiProductGetToOneRelatedFieldsApp.SubscriptionStatusUrlVersion,
                "subscriptionStatusUrlVersionForSandbox" => AppsCiProductGetToOneRelatedFieldsApp.SubscriptionStatusUrlVersionForSandbox,
                "webhooks" => AppsCiProductGetToOneRelatedFieldsApp.Webhooks,
                _ => null,
            };
        }
    }
}