
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppPriceSchedulesGetInstanceFieldsApp
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
    public static class AppPriceSchedulesGetInstanceFieldsAppExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPriceSchedulesGetInstanceFieldsApp value)
        {
            return value switch
            {
                AppPriceSchedulesGetInstanceFieldsApp.AccessibilityDeclarations => "accessibilityDeclarations",
                AppPriceSchedulesGetInstanceFieldsApp.AccessibilityUrl => "accessibilityUrl",
                AppPriceSchedulesGetInstanceFieldsApp.AlternativeDistributionKey => "alternativeDistributionKey",
                AppPriceSchedulesGetInstanceFieldsApp.AnalyticsReportRequests => "analyticsReportRequests",
                AppPriceSchedulesGetInstanceFieldsApp.AndroidToIosAppMappingDetails => "androidToIosAppMappingDetails",
                AppPriceSchedulesGetInstanceFieldsApp.AppAvailabilityV2 => "appAvailabilityV2",
                AppPriceSchedulesGetInstanceFieldsApp.AppClips => "appClips",
                AppPriceSchedulesGetInstanceFieldsApp.AppCustomProductPages => "appCustomProductPages",
                AppPriceSchedulesGetInstanceFieldsApp.AppEncryptionDeclarations => "appEncryptionDeclarations",
                AppPriceSchedulesGetInstanceFieldsApp.AppEvents => "appEvents",
                AppPriceSchedulesGetInstanceFieldsApp.AppInfos => "appInfos",
                AppPriceSchedulesGetInstanceFieldsApp.AppPricePoints => "appPricePoints",
                AppPriceSchedulesGetInstanceFieldsApp.AppPriceSchedule => "appPriceSchedule",
                AppPriceSchedulesGetInstanceFieldsApp.AppStoreIcon => "appStoreIcon",
                AppPriceSchedulesGetInstanceFieldsApp.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                AppPriceSchedulesGetInstanceFieldsApp.AppStoreVersions => "appStoreVersions",
                AppPriceSchedulesGetInstanceFieldsApp.AppTags => "appTags",
                AppPriceSchedulesGetInstanceFieldsApp.BackgroundAssets => "backgroundAssets",
                AppPriceSchedulesGetInstanceFieldsApp.BetaAppLocalizations => "betaAppLocalizations",
                AppPriceSchedulesGetInstanceFieldsApp.BetaAppReviewDetail => "betaAppReviewDetail",
                AppPriceSchedulesGetInstanceFieldsApp.BetaFeedbackCrashSubmissions => "betaFeedbackCrashSubmissions",
                AppPriceSchedulesGetInstanceFieldsApp.BetaFeedbackScreenshotSubmissions => "betaFeedbackScreenshotSubmissions",
                AppPriceSchedulesGetInstanceFieldsApp.BetaGroups => "betaGroups",
                AppPriceSchedulesGetInstanceFieldsApp.BetaLicenseAgreement => "betaLicenseAgreement",
                AppPriceSchedulesGetInstanceFieldsApp.BetaTesters => "betaTesters",
                AppPriceSchedulesGetInstanceFieldsApp.BuildUploads => "buildUploads",
                AppPriceSchedulesGetInstanceFieldsApp.Builds => "builds",
                AppPriceSchedulesGetInstanceFieldsApp.BundleId => "bundleId",
                AppPriceSchedulesGetInstanceFieldsApp.CiProduct => "ciProduct",
                AppPriceSchedulesGetInstanceFieldsApp.ContentRightsDeclaration => "contentRightsDeclaration",
                AppPriceSchedulesGetInstanceFieldsApp.CustomerReviewSummarizations => "customerReviewSummarizations",
                AppPriceSchedulesGetInstanceFieldsApp.CustomerReviews => "customerReviews",
                AppPriceSchedulesGetInstanceFieldsApp.EndUserLicenseAgreement => "endUserLicenseAgreement",
                AppPriceSchedulesGetInstanceFieldsApp.GameCenterDetail => "gameCenterDetail",
                AppPriceSchedulesGetInstanceFieldsApp.GameCenterEnabledVersions => "gameCenterEnabledVersions",
                AppPriceSchedulesGetInstanceFieldsApp.InAppPurchases => "inAppPurchases",
                AppPriceSchedulesGetInstanceFieldsApp.InAppPurchasesV2 => "inAppPurchasesV2",
                AppPriceSchedulesGetInstanceFieldsApp.IsOrEverWasMadeForKids => "isOrEverWasMadeForKids",
                AppPriceSchedulesGetInstanceFieldsApp.MarketplaceSearchDetail => "marketplaceSearchDetail",
                AppPriceSchedulesGetInstanceFieldsApp.Name => "name",
                AppPriceSchedulesGetInstanceFieldsApp.PerfPowerMetrics => "perfPowerMetrics",
                AppPriceSchedulesGetInstanceFieldsApp.PreReleaseVersions => "preReleaseVersions",
                AppPriceSchedulesGetInstanceFieldsApp.PrimaryLocale => "primaryLocale",
                AppPriceSchedulesGetInstanceFieldsApp.PromotedPurchases => "promotedPurchases",
                AppPriceSchedulesGetInstanceFieldsApp.ReviewSubmissions => "reviewSubmissions",
                AppPriceSchedulesGetInstanceFieldsApp.SearchKeywords => "searchKeywords",
                AppPriceSchedulesGetInstanceFieldsApp.Sku => "sku",
                AppPriceSchedulesGetInstanceFieldsApp.StreamlinedPurchasingEnabled => "streamlinedPurchasingEnabled",
                AppPriceSchedulesGetInstanceFieldsApp.SubscriptionGracePeriod => "subscriptionGracePeriod",
                AppPriceSchedulesGetInstanceFieldsApp.SubscriptionGroups => "subscriptionGroups",
                AppPriceSchedulesGetInstanceFieldsApp.SubscriptionStatusUrl => "subscriptionStatusUrl",
                AppPriceSchedulesGetInstanceFieldsApp.SubscriptionStatusUrlForSandbox => "subscriptionStatusUrlForSandbox",
                AppPriceSchedulesGetInstanceFieldsApp.SubscriptionStatusUrlVersion => "subscriptionStatusUrlVersion",
                AppPriceSchedulesGetInstanceFieldsApp.SubscriptionStatusUrlVersionForSandbox => "subscriptionStatusUrlVersionForSandbox",
                AppPriceSchedulesGetInstanceFieldsApp.Webhooks => "webhooks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPriceSchedulesGetInstanceFieldsApp? ToEnum(string value)
        {
            return value switch
            {
                "accessibilityDeclarations" => AppPriceSchedulesGetInstanceFieldsApp.AccessibilityDeclarations,
                "accessibilityUrl" => AppPriceSchedulesGetInstanceFieldsApp.AccessibilityUrl,
                "alternativeDistributionKey" => AppPriceSchedulesGetInstanceFieldsApp.AlternativeDistributionKey,
                "analyticsReportRequests" => AppPriceSchedulesGetInstanceFieldsApp.AnalyticsReportRequests,
                "androidToIosAppMappingDetails" => AppPriceSchedulesGetInstanceFieldsApp.AndroidToIosAppMappingDetails,
                "appAvailabilityV2" => AppPriceSchedulesGetInstanceFieldsApp.AppAvailabilityV2,
                "appClips" => AppPriceSchedulesGetInstanceFieldsApp.AppClips,
                "appCustomProductPages" => AppPriceSchedulesGetInstanceFieldsApp.AppCustomProductPages,
                "appEncryptionDeclarations" => AppPriceSchedulesGetInstanceFieldsApp.AppEncryptionDeclarations,
                "appEvents" => AppPriceSchedulesGetInstanceFieldsApp.AppEvents,
                "appInfos" => AppPriceSchedulesGetInstanceFieldsApp.AppInfos,
                "appPricePoints" => AppPriceSchedulesGetInstanceFieldsApp.AppPricePoints,
                "appPriceSchedule" => AppPriceSchedulesGetInstanceFieldsApp.AppPriceSchedule,
                "appStoreIcon" => AppPriceSchedulesGetInstanceFieldsApp.AppStoreIcon,
                "appStoreVersionExperimentsV2" => AppPriceSchedulesGetInstanceFieldsApp.AppStoreVersionExperimentsV2,
                "appStoreVersions" => AppPriceSchedulesGetInstanceFieldsApp.AppStoreVersions,
                "appTags" => AppPriceSchedulesGetInstanceFieldsApp.AppTags,
                "backgroundAssets" => AppPriceSchedulesGetInstanceFieldsApp.BackgroundAssets,
                "betaAppLocalizations" => AppPriceSchedulesGetInstanceFieldsApp.BetaAppLocalizations,
                "betaAppReviewDetail" => AppPriceSchedulesGetInstanceFieldsApp.BetaAppReviewDetail,
                "betaFeedbackCrashSubmissions" => AppPriceSchedulesGetInstanceFieldsApp.BetaFeedbackCrashSubmissions,
                "betaFeedbackScreenshotSubmissions" => AppPriceSchedulesGetInstanceFieldsApp.BetaFeedbackScreenshotSubmissions,
                "betaGroups" => AppPriceSchedulesGetInstanceFieldsApp.BetaGroups,
                "betaLicenseAgreement" => AppPriceSchedulesGetInstanceFieldsApp.BetaLicenseAgreement,
                "betaTesters" => AppPriceSchedulesGetInstanceFieldsApp.BetaTesters,
                "buildUploads" => AppPriceSchedulesGetInstanceFieldsApp.BuildUploads,
                "builds" => AppPriceSchedulesGetInstanceFieldsApp.Builds,
                "bundleId" => AppPriceSchedulesGetInstanceFieldsApp.BundleId,
                "ciProduct" => AppPriceSchedulesGetInstanceFieldsApp.CiProduct,
                "contentRightsDeclaration" => AppPriceSchedulesGetInstanceFieldsApp.ContentRightsDeclaration,
                "customerReviewSummarizations" => AppPriceSchedulesGetInstanceFieldsApp.CustomerReviewSummarizations,
                "customerReviews" => AppPriceSchedulesGetInstanceFieldsApp.CustomerReviews,
                "endUserLicenseAgreement" => AppPriceSchedulesGetInstanceFieldsApp.EndUserLicenseAgreement,
                "gameCenterDetail" => AppPriceSchedulesGetInstanceFieldsApp.GameCenterDetail,
                "gameCenterEnabledVersions" => AppPriceSchedulesGetInstanceFieldsApp.GameCenterEnabledVersions,
                "inAppPurchases" => AppPriceSchedulesGetInstanceFieldsApp.InAppPurchases,
                "inAppPurchasesV2" => AppPriceSchedulesGetInstanceFieldsApp.InAppPurchasesV2,
                "isOrEverWasMadeForKids" => AppPriceSchedulesGetInstanceFieldsApp.IsOrEverWasMadeForKids,
                "marketplaceSearchDetail" => AppPriceSchedulesGetInstanceFieldsApp.MarketplaceSearchDetail,
                "name" => AppPriceSchedulesGetInstanceFieldsApp.Name,
                "perfPowerMetrics" => AppPriceSchedulesGetInstanceFieldsApp.PerfPowerMetrics,
                "preReleaseVersions" => AppPriceSchedulesGetInstanceFieldsApp.PreReleaseVersions,
                "primaryLocale" => AppPriceSchedulesGetInstanceFieldsApp.PrimaryLocale,
                "promotedPurchases" => AppPriceSchedulesGetInstanceFieldsApp.PromotedPurchases,
                "reviewSubmissions" => AppPriceSchedulesGetInstanceFieldsApp.ReviewSubmissions,
                "searchKeywords" => AppPriceSchedulesGetInstanceFieldsApp.SearchKeywords,
                "sku" => AppPriceSchedulesGetInstanceFieldsApp.Sku,
                "streamlinedPurchasingEnabled" => AppPriceSchedulesGetInstanceFieldsApp.StreamlinedPurchasingEnabled,
                "subscriptionGracePeriod" => AppPriceSchedulesGetInstanceFieldsApp.SubscriptionGracePeriod,
                "subscriptionGroups" => AppPriceSchedulesGetInstanceFieldsApp.SubscriptionGroups,
                "subscriptionStatusUrl" => AppPriceSchedulesGetInstanceFieldsApp.SubscriptionStatusUrl,
                "subscriptionStatusUrlForSandbox" => AppPriceSchedulesGetInstanceFieldsApp.SubscriptionStatusUrlForSandbox,
                "subscriptionStatusUrlVersion" => AppPriceSchedulesGetInstanceFieldsApp.SubscriptionStatusUrlVersion,
                "subscriptionStatusUrlVersionForSandbox" => AppPriceSchedulesGetInstanceFieldsApp.SubscriptionStatusUrlVersionForSandbox,
                "webhooks" => AppPriceSchedulesGetInstanceFieldsApp.Webhooks,
                _ => null,
            };
        }
    }
}