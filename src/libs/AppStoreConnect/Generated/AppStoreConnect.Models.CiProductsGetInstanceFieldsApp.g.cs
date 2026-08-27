
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiProductsGetInstanceFieldsApp
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
    public static class CiProductsGetInstanceFieldsAppExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiProductsGetInstanceFieldsApp value)
        {
            return value switch
            {
                CiProductsGetInstanceFieldsApp.AccessibilityDeclarations => "accessibilityDeclarations",
                CiProductsGetInstanceFieldsApp.AccessibilityUrl => "accessibilityUrl",
                CiProductsGetInstanceFieldsApp.AlternativeDistributionKey => "alternativeDistributionKey",
                CiProductsGetInstanceFieldsApp.AnalyticsReportRequests => "analyticsReportRequests",
                CiProductsGetInstanceFieldsApp.AndroidToIosAppMappingDetails => "androidToIosAppMappingDetails",
                CiProductsGetInstanceFieldsApp.AppAvailabilityV2 => "appAvailabilityV2",
                CiProductsGetInstanceFieldsApp.AppClips => "appClips",
                CiProductsGetInstanceFieldsApp.AppCustomProductPages => "appCustomProductPages",
                CiProductsGetInstanceFieldsApp.AppEncryptionDeclarations => "appEncryptionDeclarations",
                CiProductsGetInstanceFieldsApp.AppEvents => "appEvents",
                CiProductsGetInstanceFieldsApp.AppInfos => "appInfos",
                CiProductsGetInstanceFieldsApp.AppPricePoints => "appPricePoints",
                CiProductsGetInstanceFieldsApp.AppPriceSchedule => "appPriceSchedule",
                CiProductsGetInstanceFieldsApp.AppStoreIcon => "appStoreIcon",
                CiProductsGetInstanceFieldsApp.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                CiProductsGetInstanceFieldsApp.AppStoreVersions => "appStoreVersions",
                CiProductsGetInstanceFieldsApp.AppTags => "appTags",
                CiProductsGetInstanceFieldsApp.BackgroundAssets => "backgroundAssets",
                CiProductsGetInstanceFieldsApp.BetaAppLocalizations => "betaAppLocalizations",
                CiProductsGetInstanceFieldsApp.BetaAppReviewDetail => "betaAppReviewDetail",
                CiProductsGetInstanceFieldsApp.BetaFeedbackCrashSubmissions => "betaFeedbackCrashSubmissions",
                CiProductsGetInstanceFieldsApp.BetaFeedbackScreenshotSubmissions => "betaFeedbackScreenshotSubmissions",
                CiProductsGetInstanceFieldsApp.BetaGroups => "betaGroups",
                CiProductsGetInstanceFieldsApp.BetaLicenseAgreement => "betaLicenseAgreement",
                CiProductsGetInstanceFieldsApp.BetaTesters => "betaTesters",
                CiProductsGetInstanceFieldsApp.BuildUploads => "buildUploads",
                CiProductsGetInstanceFieldsApp.Builds => "builds",
                CiProductsGetInstanceFieldsApp.BundleId => "bundleId",
                CiProductsGetInstanceFieldsApp.CiProduct => "ciProduct",
                CiProductsGetInstanceFieldsApp.ContentRightsDeclaration => "contentRightsDeclaration",
                CiProductsGetInstanceFieldsApp.CustomerReviewSummarizations => "customerReviewSummarizations",
                CiProductsGetInstanceFieldsApp.CustomerReviews => "customerReviews",
                CiProductsGetInstanceFieldsApp.EndUserLicenseAgreement => "endUserLicenseAgreement",
                CiProductsGetInstanceFieldsApp.GameCenterDetail => "gameCenterDetail",
                CiProductsGetInstanceFieldsApp.GameCenterEnabledVersions => "gameCenterEnabledVersions",
                CiProductsGetInstanceFieldsApp.InAppPurchases => "inAppPurchases",
                CiProductsGetInstanceFieldsApp.InAppPurchasesV2 => "inAppPurchasesV2",
                CiProductsGetInstanceFieldsApp.IsOrEverWasMadeForKids => "isOrEverWasMadeForKids",
                CiProductsGetInstanceFieldsApp.MarketplaceSearchDetail => "marketplaceSearchDetail",
                CiProductsGetInstanceFieldsApp.Name => "name",
                CiProductsGetInstanceFieldsApp.PerfPowerMetrics => "perfPowerMetrics",
                CiProductsGetInstanceFieldsApp.PreReleaseVersions => "preReleaseVersions",
                CiProductsGetInstanceFieldsApp.PrimaryLocale => "primaryLocale",
                CiProductsGetInstanceFieldsApp.PromotedPurchases => "promotedPurchases",
                CiProductsGetInstanceFieldsApp.ReviewSubmissions => "reviewSubmissions",
                CiProductsGetInstanceFieldsApp.SearchKeywords => "searchKeywords",
                CiProductsGetInstanceFieldsApp.Sku => "sku",
                CiProductsGetInstanceFieldsApp.StreamlinedPurchasingEnabled => "streamlinedPurchasingEnabled",
                CiProductsGetInstanceFieldsApp.SubscriptionGracePeriod => "subscriptionGracePeriod",
                CiProductsGetInstanceFieldsApp.SubscriptionGroups => "subscriptionGroups",
                CiProductsGetInstanceFieldsApp.SubscriptionStatusUrl => "subscriptionStatusUrl",
                CiProductsGetInstanceFieldsApp.SubscriptionStatusUrlForSandbox => "subscriptionStatusUrlForSandbox",
                CiProductsGetInstanceFieldsApp.SubscriptionStatusUrlVersion => "subscriptionStatusUrlVersion",
                CiProductsGetInstanceFieldsApp.SubscriptionStatusUrlVersionForSandbox => "subscriptionStatusUrlVersionForSandbox",
                CiProductsGetInstanceFieldsApp.Webhooks => "webhooks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiProductsGetInstanceFieldsApp? ToEnum(string value)
        {
            return value switch
            {
                "accessibilityDeclarations" => CiProductsGetInstanceFieldsApp.AccessibilityDeclarations,
                "accessibilityUrl" => CiProductsGetInstanceFieldsApp.AccessibilityUrl,
                "alternativeDistributionKey" => CiProductsGetInstanceFieldsApp.AlternativeDistributionKey,
                "analyticsReportRequests" => CiProductsGetInstanceFieldsApp.AnalyticsReportRequests,
                "androidToIosAppMappingDetails" => CiProductsGetInstanceFieldsApp.AndroidToIosAppMappingDetails,
                "appAvailabilityV2" => CiProductsGetInstanceFieldsApp.AppAvailabilityV2,
                "appClips" => CiProductsGetInstanceFieldsApp.AppClips,
                "appCustomProductPages" => CiProductsGetInstanceFieldsApp.AppCustomProductPages,
                "appEncryptionDeclarations" => CiProductsGetInstanceFieldsApp.AppEncryptionDeclarations,
                "appEvents" => CiProductsGetInstanceFieldsApp.AppEvents,
                "appInfos" => CiProductsGetInstanceFieldsApp.AppInfos,
                "appPricePoints" => CiProductsGetInstanceFieldsApp.AppPricePoints,
                "appPriceSchedule" => CiProductsGetInstanceFieldsApp.AppPriceSchedule,
                "appStoreIcon" => CiProductsGetInstanceFieldsApp.AppStoreIcon,
                "appStoreVersionExperimentsV2" => CiProductsGetInstanceFieldsApp.AppStoreVersionExperimentsV2,
                "appStoreVersions" => CiProductsGetInstanceFieldsApp.AppStoreVersions,
                "appTags" => CiProductsGetInstanceFieldsApp.AppTags,
                "backgroundAssets" => CiProductsGetInstanceFieldsApp.BackgroundAssets,
                "betaAppLocalizations" => CiProductsGetInstanceFieldsApp.BetaAppLocalizations,
                "betaAppReviewDetail" => CiProductsGetInstanceFieldsApp.BetaAppReviewDetail,
                "betaFeedbackCrashSubmissions" => CiProductsGetInstanceFieldsApp.BetaFeedbackCrashSubmissions,
                "betaFeedbackScreenshotSubmissions" => CiProductsGetInstanceFieldsApp.BetaFeedbackScreenshotSubmissions,
                "betaGroups" => CiProductsGetInstanceFieldsApp.BetaGroups,
                "betaLicenseAgreement" => CiProductsGetInstanceFieldsApp.BetaLicenseAgreement,
                "betaTesters" => CiProductsGetInstanceFieldsApp.BetaTesters,
                "buildUploads" => CiProductsGetInstanceFieldsApp.BuildUploads,
                "builds" => CiProductsGetInstanceFieldsApp.Builds,
                "bundleId" => CiProductsGetInstanceFieldsApp.BundleId,
                "ciProduct" => CiProductsGetInstanceFieldsApp.CiProduct,
                "contentRightsDeclaration" => CiProductsGetInstanceFieldsApp.ContentRightsDeclaration,
                "customerReviewSummarizations" => CiProductsGetInstanceFieldsApp.CustomerReviewSummarizations,
                "customerReviews" => CiProductsGetInstanceFieldsApp.CustomerReviews,
                "endUserLicenseAgreement" => CiProductsGetInstanceFieldsApp.EndUserLicenseAgreement,
                "gameCenterDetail" => CiProductsGetInstanceFieldsApp.GameCenterDetail,
                "gameCenterEnabledVersions" => CiProductsGetInstanceFieldsApp.GameCenterEnabledVersions,
                "inAppPurchases" => CiProductsGetInstanceFieldsApp.InAppPurchases,
                "inAppPurchasesV2" => CiProductsGetInstanceFieldsApp.InAppPurchasesV2,
                "isOrEverWasMadeForKids" => CiProductsGetInstanceFieldsApp.IsOrEverWasMadeForKids,
                "marketplaceSearchDetail" => CiProductsGetInstanceFieldsApp.MarketplaceSearchDetail,
                "name" => CiProductsGetInstanceFieldsApp.Name,
                "perfPowerMetrics" => CiProductsGetInstanceFieldsApp.PerfPowerMetrics,
                "preReleaseVersions" => CiProductsGetInstanceFieldsApp.PreReleaseVersions,
                "primaryLocale" => CiProductsGetInstanceFieldsApp.PrimaryLocale,
                "promotedPurchases" => CiProductsGetInstanceFieldsApp.PromotedPurchases,
                "reviewSubmissions" => CiProductsGetInstanceFieldsApp.ReviewSubmissions,
                "searchKeywords" => CiProductsGetInstanceFieldsApp.SearchKeywords,
                "sku" => CiProductsGetInstanceFieldsApp.Sku,
                "streamlinedPurchasingEnabled" => CiProductsGetInstanceFieldsApp.StreamlinedPurchasingEnabled,
                "subscriptionGracePeriod" => CiProductsGetInstanceFieldsApp.SubscriptionGracePeriod,
                "subscriptionGroups" => CiProductsGetInstanceFieldsApp.SubscriptionGroups,
                "subscriptionStatusUrl" => CiProductsGetInstanceFieldsApp.SubscriptionStatusUrl,
                "subscriptionStatusUrlForSandbox" => CiProductsGetInstanceFieldsApp.SubscriptionStatusUrlForSandbox,
                "subscriptionStatusUrlVersion" => CiProductsGetInstanceFieldsApp.SubscriptionStatusUrlVersion,
                "subscriptionStatusUrlVersionForSandbox" => CiProductsGetInstanceFieldsApp.SubscriptionStatusUrlVersionForSandbox,
                "webhooks" => CiProductsGetInstanceFieldsApp.Webhooks,
                _ => null,
            };
        }
    }
}