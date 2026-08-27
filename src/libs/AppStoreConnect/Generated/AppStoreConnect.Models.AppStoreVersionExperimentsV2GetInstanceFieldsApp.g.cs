
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionExperimentsV2GetInstanceFieldsApp
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
    public static class AppStoreVersionExperimentsV2GetInstanceFieldsAppExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionExperimentsV2GetInstanceFieldsApp value)
        {
            return value switch
            {
                AppStoreVersionExperimentsV2GetInstanceFieldsApp.AccessibilityDeclarations => "accessibilityDeclarations",
                AppStoreVersionExperimentsV2GetInstanceFieldsApp.AccessibilityUrl => "accessibilityUrl",
                AppStoreVersionExperimentsV2GetInstanceFieldsApp.AlternativeDistributionKey => "alternativeDistributionKey",
                AppStoreVersionExperimentsV2GetInstanceFieldsApp.AnalyticsReportRequests => "analyticsReportRequests",
                AppStoreVersionExperimentsV2GetInstanceFieldsApp.AndroidToIosAppMappingDetails => "androidToIosAppMappingDetails",
                AppStoreVersionExperimentsV2GetInstanceFieldsApp.AppAvailabilityV2 => "appAvailabilityV2",
                AppStoreVersionExperimentsV2GetInstanceFieldsApp.AppClips => "appClips",
                AppStoreVersionExperimentsV2GetInstanceFieldsApp.AppCustomProductPages => "appCustomProductPages",
                AppStoreVersionExperimentsV2GetInstanceFieldsApp.AppEncryptionDeclarations => "appEncryptionDeclarations",
                AppStoreVersionExperimentsV2GetInstanceFieldsApp.AppEvents => "appEvents",
                AppStoreVersionExperimentsV2GetInstanceFieldsApp.AppInfos => "appInfos",
                AppStoreVersionExperimentsV2GetInstanceFieldsApp.AppPricePoints => "appPricePoints",
                AppStoreVersionExperimentsV2GetInstanceFieldsApp.AppPriceSchedule => "appPriceSchedule",
                AppStoreVersionExperimentsV2GetInstanceFieldsApp.AppStoreIcon => "appStoreIcon",
                AppStoreVersionExperimentsV2GetInstanceFieldsApp.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                AppStoreVersionExperimentsV2GetInstanceFieldsApp.AppStoreVersions => "appStoreVersions",
                AppStoreVersionExperimentsV2GetInstanceFieldsApp.AppTags => "appTags",
                AppStoreVersionExperimentsV2GetInstanceFieldsApp.BackgroundAssets => "backgroundAssets",
                AppStoreVersionExperimentsV2GetInstanceFieldsApp.BetaAppLocalizations => "betaAppLocalizations",
                AppStoreVersionExperimentsV2GetInstanceFieldsApp.BetaAppReviewDetail => "betaAppReviewDetail",
                AppStoreVersionExperimentsV2GetInstanceFieldsApp.BetaFeedbackCrashSubmissions => "betaFeedbackCrashSubmissions",
                AppStoreVersionExperimentsV2GetInstanceFieldsApp.BetaFeedbackScreenshotSubmissions => "betaFeedbackScreenshotSubmissions",
                AppStoreVersionExperimentsV2GetInstanceFieldsApp.BetaGroups => "betaGroups",
                AppStoreVersionExperimentsV2GetInstanceFieldsApp.BetaLicenseAgreement => "betaLicenseAgreement",
                AppStoreVersionExperimentsV2GetInstanceFieldsApp.BetaTesters => "betaTesters",
                AppStoreVersionExperimentsV2GetInstanceFieldsApp.BuildUploads => "buildUploads",
                AppStoreVersionExperimentsV2GetInstanceFieldsApp.Builds => "builds",
                AppStoreVersionExperimentsV2GetInstanceFieldsApp.BundleId => "bundleId",
                AppStoreVersionExperimentsV2GetInstanceFieldsApp.CiProduct => "ciProduct",
                AppStoreVersionExperimentsV2GetInstanceFieldsApp.ContentRightsDeclaration => "contentRightsDeclaration",
                AppStoreVersionExperimentsV2GetInstanceFieldsApp.CustomerReviewSummarizations => "customerReviewSummarizations",
                AppStoreVersionExperimentsV2GetInstanceFieldsApp.CustomerReviews => "customerReviews",
                AppStoreVersionExperimentsV2GetInstanceFieldsApp.EndUserLicenseAgreement => "endUserLicenseAgreement",
                AppStoreVersionExperimentsV2GetInstanceFieldsApp.GameCenterDetail => "gameCenterDetail",
                AppStoreVersionExperimentsV2GetInstanceFieldsApp.GameCenterEnabledVersions => "gameCenterEnabledVersions",
                AppStoreVersionExperimentsV2GetInstanceFieldsApp.InAppPurchases => "inAppPurchases",
                AppStoreVersionExperimentsV2GetInstanceFieldsApp.InAppPurchasesV2 => "inAppPurchasesV2",
                AppStoreVersionExperimentsV2GetInstanceFieldsApp.IsOrEverWasMadeForKids => "isOrEverWasMadeForKids",
                AppStoreVersionExperimentsV2GetInstanceFieldsApp.MarketplaceSearchDetail => "marketplaceSearchDetail",
                AppStoreVersionExperimentsV2GetInstanceFieldsApp.Name => "name",
                AppStoreVersionExperimentsV2GetInstanceFieldsApp.PerfPowerMetrics => "perfPowerMetrics",
                AppStoreVersionExperimentsV2GetInstanceFieldsApp.PreReleaseVersions => "preReleaseVersions",
                AppStoreVersionExperimentsV2GetInstanceFieldsApp.PrimaryLocale => "primaryLocale",
                AppStoreVersionExperimentsV2GetInstanceFieldsApp.PromotedPurchases => "promotedPurchases",
                AppStoreVersionExperimentsV2GetInstanceFieldsApp.ReviewSubmissions => "reviewSubmissions",
                AppStoreVersionExperimentsV2GetInstanceFieldsApp.SearchKeywords => "searchKeywords",
                AppStoreVersionExperimentsV2GetInstanceFieldsApp.Sku => "sku",
                AppStoreVersionExperimentsV2GetInstanceFieldsApp.StreamlinedPurchasingEnabled => "streamlinedPurchasingEnabled",
                AppStoreVersionExperimentsV2GetInstanceFieldsApp.SubscriptionGracePeriod => "subscriptionGracePeriod",
                AppStoreVersionExperimentsV2GetInstanceFieldsApp.SubscriptionGroups => "subscriptionGroups",
                AppStoreVersionExperimentsV2GetInstanceFieldsApp.SubscriptionStatusUrl => "subscriptionStatusUrl",
                AppStoreVersionExperimentsV2GetInstanceFieldsApp.SubscriptionStatusUrlForSandbox => "subscriptionStatusUrlForSandbox",
                AppStoreVersionExperimentsV2GetInstanceFieldsApp.SubscriptionStatusUrlVersion => "subscriptionStatusUrlVersion",
                AppStoreVersionExperimentsV2GetInstanceFieldsApp.SubscriptionStatusUrlVersionForSandbox => "subscriptionStatusUrlVersionForSandbox",
                AppStoreVersionExperimentsV2GetInstanceFieldsApp.Webhooks => "webhooks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionExperimentsV2GetInstanceFieldsApp? ToEnum(string value)
        {
            return value switch
            {
                "accessibilityDeclarations" => AppStoreVersionExperimentsV2GetInstanceFieldsApp.AccessibilityDeclarations,
                "accessibilityUrl" => AppStoreVersionExperimentsV2GetInstanceFieldsApp.AccessibilityUrl,
                "alternativeDistributionKey" => AppStoreVersionExperimentsV2GetInstanceFieldsApp.AlternativeDistributionKey,
                "analyticsReportRequests" => AppStoreVersionExperimentsV2GetInstanceFieldsApp.AnalyticsReportRequests,
                "androidToIosAppMappingDetails" => AppStoreVersionExperimentsV2GetInstanceFieldsApp.AndroidToIosAppMappingDetails,
                "appAvailabilityV2" => AppStoreVersionExperimentsV2GetInstanceFieldsApp.AppAvailabilityV2,
                "appClips" => AppStoreVersionExperimentsV2GetInstanceFieldsApp.AppClips,
                "appCustomProductPages" => AppStoreVersionExperimentsV2GetInstanceFieldsApp.AppCustomProductPages,
                "appEncryptionDeclarations" => AppStoreVersionExperimentsV2GetInstanceFieldsApp.AppEncryptionDeclarations,
                "appEvents" => AppStoreVersionExperimentsV2GetInstanceFieldsApp.AppEvents,
                "appInfos" => AppStoreVersionExperimentsV2GetInstanceFieldsApp.AppInfos,
                "appPricePoints" => AppStoreVersionExperimentsV2GetInstanceFieldsApp.AppPricePoints,
                "appPriceSchedule" => AppStoreVersionExperimentsV2GetInstanceFieldsApp.AppPriceSchedule,
                "appStoreIcon" => AppStoreVersionExperimentsV2GetInstanceFieldsApp.AppStoreIcon,
                "appStoreVersionExperimentsV2" => AppStoreVersionExperimentsV2GetInstanceFieldsApp.AppStoreVersionExperimentsV2,
                "appStoreVersions" => AppStoreVersionExperimentsV2GetInstanceFieldsApp.AppStoreVersions,
                "appTags" => AppStoreVersionExperimentsV2GetInstanceFieldsApp.AppTags,
                "backgroundAssets" => AppStoreVersionExperimentsV2GetInstanceFieldsApp.BackgroundAssets,
                "betaAppLocalizations" => AppStoreVersionExperimentsV2GetInstanceFieldsApp.BetaAppLocalizations,
                "betaAppReviewDetail" => AppStoreVersionExperimentsV2GetInstanceFieldsApp.BetaAppReviewDetail,
                "betaFeedbackCrashSubmissions" => AppStoreVersionExperimentsV2GetInstanceFieldsApp.BetaFeedbackCrashSubmissions,
                "betaFeedbackScreenshotSubmissions" => AppStoreVersionExperimentsV2GetInstanceFieldsApp.BetaFeedbackScreenshotSubmissions,
                "betaGroups" => AppStoreVersionExperimentsV2GetInstanceFieldsApp.BetaGroups,
                "betaLicenseAgreement" => AppStoreVersionExperimentsV2GetInstanceFieldsApp.BetaLicenseAgreement,
                "betaTesters" => AppStoreVersionExperimentsV2GetInstanceFieldsApp.BetaTesters,
                "buildUploads" => AppStoreVersionExperimentsV2GetInstanceFieldsApp.BuildUploads,
                "builds" => AppStoreVersionExperimentsV2GetInstanceFieldsApp.Builds,
                "bundleId" => AppStoreVersionExperimentsV2GetInstanceFieldsApp.BundleId,
                "ciProduct" => AppStoreVersionExperimentsV2GetInstanceFieldsApp.CiProduct,
                "contentRightsDeclaration" => AppStoreVersionExperimentsV2GetInstanceFieldsApp.ContentRightsDeclaration,
                "customerReviewSummarizations" => AppStoreVersionExperimentsV2GetInstanceFieldsApp.CustomerReviewSummarizations,
                "customerReviews" => AppStoreVersionExperimentsV2GetInstanceFieldsApp.CustomerReviews,
                "endUserLicenseAgreement" => AppStoreVersionExperimentsV2GetInstanceFieldsApp.EndUserLicenseAgreement,
                "gameCenterDetail" => AppStoreVersionExperimentsV2GetInstanceFieldsApp.GameCenterDetail,
                "gameCenterEnabledVersions" => AppStoreVersionExperimentsV2GetInstanceFieldsApp.GameCenterEnabledVersions,
                "inAppPurchases" => AppStoreVersionExperimentsV2GetInstanceFieldsApp.InAppPurchases,
                "inAppPurchasesV2" => AppStoreVersionExperimentsV2GetInstanceFieldsApp.InAppPurchasesV2,
                "isOrEverWasMadeForKids" => AppStoreVersionExperimentsV2GetInstanceFieldsApp.IsOrEverWasMadeForKids,
                "marketplaceSearchDetail" => AppStoreVersionExperimentsV2GetInstanceFieldsApp.MarketplaceSearchDetail,
                "name" => AppStoreVersionExperimentsV2GetInstanceFieldsApp.Name,
                "perfPowerMetrics" => AppStoreVersionExperimentsV2GetInstanceFieldsApp.PerfPowerMetrics,
                "preReleaseVersions" => AppStoreVersionExperimentsV2GetInstanceFieldsApp.PreReleaseVersions,
                "primaryLocale" => AppStoreVersionExperimentsV2GetInstanceFieldsApp.PrimaryLocale,
                "promotedPurchases" => AppStoreVersionExperimentsV2GetInstanceFieldsApp.PromotedPurchases,
                "reviewSubmissions" => AppStoreVersionExperimentsV2GetInstanceFieldsApp.ReviewSubmissions,
                "searchKeywords" => AppStoreVersionExperimentsV2GetInstanceFieldsApp.SearchKeywords,
                "sku" => AppStoreVersionExperimentsV2GetInstanceFieldsApp.Sku,
                "streamlinedPurchasingEnabled" => AppStoreVersionExperimentsV2GetInstanceFieldsApp.StreamlinedPurchasingEnabled,
                "subscriptionGracePeriod" => AppStoreVersionExperimentsV2GetInstanceFieldsApp.SubscriptionGracePeriod,
                "subscriptionGroups" => AppStoreVersionExperimentsV2GetInstanceFieldsApp.SubscriptionGroups,
                "subscriptionStatusUrl" => AppStoreVersionExperimentsV2GetInstanceFieldsApp.SubscriptionStatusUrl,
                "subscriptionStatusUrlForSandbox" => AppStoreVersionExperimentsV2GetInstanceFieldsApp.SubscriptionStatusUrlForSandbox,
                "subscriptionStatusUrlVersion" => AppStoreVersionExperimentsV2GetInstanceFieldsApp.SubscriptionStatusUrlVersion,
                "subscriptionStatusUrlVersionForSandbox" => AppStoreVersionExperimentsV2GetInstanceFieldsApp.SubscriptionStatusUrlVersionForSandbox,
                "webhooks" => AppStoreVersionExperimentsV2GetInstanceFieldsApp.Webhooks,
                _ => null,
            };
        }
    }
}