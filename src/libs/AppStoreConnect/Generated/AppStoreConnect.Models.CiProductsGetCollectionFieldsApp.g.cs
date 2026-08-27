
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiProductsGetCollectionFieldsApp
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
    public static class CiProductsGetCollectionFieldsAppExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiProductsGetCollectionFieldsApp value)
        {
            return value switch
            {
                CiProductsGetCollectionFieldsApp.AccessibilityDeclarations => "accessibilityDeclarations",
                CiProductsGetCollectionFieldsApp.AccessibilityUrl => "accessibilityUrl",
                CiProductsGetCollectionFieldsApp.AlternativeDistributionKey => "alternativeDistributionKey",
                CiProductsGetCollectionFieldsApp.AnalyticsReportRequests => "analyticsReportRequests",
                CiProductsGetCollectionFieldsApp.AndroidToIosAppMappingDetails => "androidToIosAppMappingDetails",
                CiProductsGetCollectionFieldsApp.AppAvailabilityV2 => "appAvailabilityV2",
                CiProductsGetCollectionFieldsApp.AppClips => "appClips",
                CiProductsGetCollectionFieldsApp.AppCustomProductPages => "appCustomProductPages",
                CiProductsGetCollectionFieldsApp.AppEncryptionDeclarations => "appEncryptionDeclarations",
                CiProductsGetCollectionFieldsApp.AppEvents => "appEvents",
                CiProductsGetCollectionFieldsApp.AppInfos => "appInfos",
                CiProductsGetCollectionFieldsApp.AppPricePoints => "appPricePoints",
                CiProductsGetCollectionFieldsApp.AppPriceSchedule => "appPriceSchedule",
                CiProductsGetCollectionFieldsApp.AppStoreIcon => "appStoreIcon",
                CiProductsGetCollectionFieldsApp.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                CiProductsGetCollectionFieldsApp.AppStoreVersions => "appStoreVersions",
                CiProductsGetCollectionFieldsApp.AppTags => "appTags",
                CiProductsGetCollectionFieldsApp.BackgroundAssets => "backgroundAssets",
                CiProductsGetCollectionFieldsApp.BetaAppLocalizations => "betaAppLocalizations",
                CiProductsGetCollectionFieldsApp.BetaAppReviewDetail => "betaAppReviewDetail",
                CiProductsGetCollectionFieldsApp.BetaFeedbackCrashSubmissions => "betaFeedbackCrashSubmissions",
                CiProductsGetCollectionFieldsApp.BetaFeedbackScreenshotSubmissions => "betaFeedbackScreenshotSubmissions",
                CiProductsGetCollectionFieldsApp.BetaGroups => "betaGroups",
                CiProductsGetCollectionFieldsApp.BetaLicenseAgreement => "betaLicenseAgreement",
                CiProductsGetCollectionFieldsApp.BetaTesters => "betaTesters",
                CiProductsGetCollectionFieldsApp.BuildUploads => "buildUploads",
                CiProductsGetCollectionFieldsApp.Builds => "builds",
                CiProductsGetCollectionFieldsApp.BundleId => "bundleId",
                CiProductsGetCollectionFieldsApp.CiProduct => "ciProduct",
                CiProductsGetCollectionFieldsApp.ContentRightsDeclaration => "contentRightsDeclaration",
                CiProductsGetCollectionFieldsApp.CustomerReviewSummarizations => "customerReviewSummarizations",
                CiProductsGetCollectionFieldsApp.CustomerReviews => "customerReviews",
                CiProductsGetCollectionFieldsApp.EndUserLicenseAgreement => "endUserLicenseAgreement",
                CiProductsGetCollectionFieldsApp.GameCenterDetail => "gameCenterDetail",
                CiProductsGetCollectionFieldsApp.GameCenterEnabledVersions => "gameCenterEnabledVersions",
                CiProductsGetCollectionFieldsApp.InAppPurchases => "inAppPurchases",
                CiProductsGetCollectionFieldsApp.InAppPurchasesV2 => "inAppPurchasesV2",
                CiProductsGetCollectionFieldsApp.IsOrEverWasMadeForKids => "isOrEverWasMadeForKids",
                CiProductsGetCollectionFieldsApp.MarketplaceSearchDetail => "marketplaceSearchDetail",
                CiProductsGetCollectionFieldsApp.Name => "name",
                CiProductsGetCollectionFieldsApp.PerfPowerMetrics => "perfPowerMetrics",
                CiProductsGetCollectionFieldsApp.PreReleaseVersions => "preReleaseVersions",
                CiProductsGetCollectionFieldsApp.PrimaryLocale => "primaryLocale",
                CiProductsGetCollectionFieldsApp.PromotedPurchases => "promotedPurchases",
                CiProductsGetCollectionFieldsApp.ReviewSubmissions => "reviewSubmissions",
                CiProductsGetCollectionFieldsApp.SearchKeywords => "searchKeywords",
                CiProductsGetCollectionFieldsApp.Sku => "sku",
                CiProductsGetCollectionFieldsApp.StreamlinedPurchasingEnabled => "streamlinedPurchasingEnabled",
                CiProductsGetCollectionFieldsApp.SubscriptionGracePeriod => "subscriptionGracePeriod",
                CiProductsGetCollectionFieldsApp.SubscriptionGroups => "subscriptionGroups",
                CiProductsGetCollectionFieldsApp.SubscriptionStatusUrl => "subscriptionStatusUrl",
                CiProductsGetCollectionFieldsApp.SubscriptionStatusUrlForSandbox => "subscriptionStatusUrlForSandbox",
                CiProductsGetCollectionFieldsApp.SubscriptionStatusUrlVersion => "subscriptionStatusUrlVersion",
                CiProductsGetCollectionFieldsApp.SubscriptionStatusUrlVersionForSandbox => "subscriptionStatusUrlVersionForSandbox",
                CiProductsGetCollectionFieldsApp.Webhooks => "webhooks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiProductsGetCollectionFieldsApp? ToEnum(string value)
        {
            return value switch
            {
                "accessibilityDeclarations" => CiProductsGetCollectionFieldsApp.AccessibilityDeclarations,
                "accessibilityUrl" => CiProductsGetCollectionFieldsApp.AccessibilityUrl,
                "alternativeDistributionKey" => CiProductsGetCollectionFieldsApp.AlternativeDistributionKey,
                "analyticsReportRequests" => CiProductsGetCollectionFieldsApp.AnalyticsReportRequests,
                "androidToIosAppMappingDetails" => CiProductsGetCollectionFieldsApp.AndroidToIosAppMappingDetails,
                "appAvailabilityV2" => CiProductsGetCollectionFieldsApp.AppAvailabilityV2,
                "appClips" => CiProductsGetCollectionFieldsApp.AppClips,
                "appCustomProductPages" => CiProductsGetCollectionFieldsApp.AppCustomProductPages,
                "appEncryptionDeclarations" => CiProductsGetCollectionFieldsApp.AppEncryptionDeclarations,
                "appEvents" => CiProductsGetCollectionFieldsApp.AppEvents,
                "appInfos" => CiProductsGetCollectionFieldsApp.AppInfos,
                "appPricePoints" => CiProductsGetCollectionFieldsApp.AppPricePoints,
                "appPriceSchedule" => CiProductsGetCollectionFieldsApp.AppPriceSchedule,
                "appStoreIcon" => CiProductsGetCollectionFieldsApp.AppStoreIcon,
                "appStoreVersionExperimentsV2" => CiProductsGetCollectionFieldsApp.AppStoreVersionExperimentsV2,
                "appStoreVersions" => CiProductsGetCollectionFieldsApp.AppStoreVersions,
                "appTags" => CiProductsGetCollectionFieldsApp.AppTags,
                "backgroundAssets" => CiProductsGetCollectionFieldsApp.BackgroundAssets,
                "betaAppLocalizations" => CiProductsGetCollectionFieldsApp.BetaAppLocalizations,
                "betaAppReviewDetail" => CiProductsGetCollectionFieldsApp.BetaAppReviewDetail,
                "betaFeedbackCrashSubmissions" => CiProductsGetCollectionFieldsApp.BetaFeedbackCrashSubmissions,
                "betaFeedbackScreenshotSubmissions" => CiProductsGetCollectionFieldsApp.BetaFeedbackScreenshotSubmissions,
                "betaGroups" => CiProductsGetCollectionFieldsApp.BetaGroups,
                "betaLicenseAgreement" => CiProductsGetCollectionFieldsApp.BetaLicenseAgreement,
                "betaTesters" => CiProductsGetCollectionFieldsApp.BetaTesters,
                "buildUploads" => CiProductsGetCollectionFieldsApp.BuildUploads,
                "builds" => CiProductsGetCollectionFieldsApp.Builds,
                "bundleId" => CiProductsGetCollectionFieldsApp.BundleId,
                "ciProduct" => CiProductsGetCollectionFieldsApp.CiProduct,
                "contentRightsDeclaration" => CiProductsGetCollectionFieldsApp.ContentRightsDeclaration,
                "customerReviewSummarizations" => CiProductsGetCollectionFieldsApp.CustomerReviewSummarizations,
                "customerReviews" => CiProductsGetCollectionFieldsApp.CustomerReviews,
                "endUserLicenseAgreement" => CiProductsGetCollectionFieldsApp.EndUserLicenseAgreement,
                "gameCenterDetail" => CiProductsGetCollectionFieldsApp.GameCenterDetail,
                "gameCenterEnabledVersions" => CiProductsGetCollectionFieldsApp.GameCenterEnabledVersions,
                "inAppPurchases" => CiProductsGetCollectionFieldsApp.InAppPurchases,
                "inAppPurchasesV2" => CiProductsGetCollectionFieldsApp.InAppPurchasesV2,
                "isOrEverWasMadeForKids" => CiProductsGetCollectionFieldsApp.IsOrEverWasMadeForKids,
                "marketplaceSearchDetail" => CiProductsGetCollectionFieldsApp.MarketplaceSearchDetail,
                "name" => CiProductsGetCollectionFieldsApp.Name,
                "perfPowerMetrics" => CiProductsGetCollectionFieldsApp.PerfPowerMetrics,
                "preReleaseVersions" => CiProductsGetCollectionFieldsApp.PreReleaseVersions,
                "primaryLocale" => CiProductsGetCollectionFieldsApp.PrimaryLocale,
                "promotedPurchases" => CiProductsGetCollectionFieldsApp.PromotedPurchases,
                "reviewSubmissions" => CiProductsGetCollectionFieldsApp.ReviewSubmissions,
                "searchKeywords" => CiProductsGetCollectionFieldsApp.SearchKeywords,
                "sku" => CiProductsGetCollectionFieldsApp.Sku,
                "streamlinedPurchasingEnabled" => CiProductsGetCollectionFieldsApp.StreamlinedPurchasingEnabled,
                "subscriptionGracePeriod" => CiProductsGetCollectionFieldsApp.SubscriptionGracePeriod,
                "subscriptionGroups" => CiProductsGetCollectionFieldsApp.SubscriptionGroups,
                "subscriptionStatusUrl" => CiProductsGetCollectionFieldsApp.SubscriptionStatusUrl,
                "subscriptionStatusUrlForSandbox" => CiProductsGetCollectionFieldsApp.SubscriptionStatusUrlForSandbox,
                "subscriptionStatusUrlVersion" => CiProductsGetCollectionFieldsApp.SubscriptionStatusUrlVersion,
                "subscriptionStatusUrlVersionForSandbox" => CiProductsGetCollectionFieldsApp.SubscriptionStatusUrlVersionForSandbox,
                "webhooks" => CiProductsGetCollectionFieldsApp.Webhooks,
                _ => null,
            };
        }
    }
}