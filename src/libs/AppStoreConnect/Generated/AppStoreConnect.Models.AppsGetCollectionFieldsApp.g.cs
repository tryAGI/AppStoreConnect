
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsGetCollectionFieldsApp
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
    public static class AppsGetCollectionFieldsAppExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGetCollectionFieldsApp value)
        {
            return value switch
            {
                AppsGetCollectionFieldsApp.AccessibilityDeclarations => "accessibilityDeclarations",
                AppsGetCollectionFieldsApp.AccessibilityUrl => "accessibilityUrl",
                AppsGetCollectionFieldsApp.AlternativeDistributionKey => "alternativeDistributionKey",
                AppsGetCollectionFieldsApp.AnalyticsReportRequests => "analyticsReportRequests",
                AppsGetCollectionFieldsApp.AndroidToIosAppMappingDetails => "androidToIosAppMappingDetails",
                AppsGetCollectionFieldsApp.AppAvailabilityV2 => "appAvailabilityV2",
                AppsGetCollectionFieldsApp.AppClips => "appClips",
                AppsGetCollectionFieldsApp.AppCustomProductPages => "appCustomProductPages",
                AppsGetCollectionFieldsApp.AppEncryptionDeclarations => "appEncryptionDeclarations",
                AppsGetCollectionFieldsApp.AppEvents => "appEvents",
                AppsGetCollectionFieldsApp.AppInfos => "appInfos",
                AppsGetCollectionFieldsApp.AppPricePoints => "appPricePoints",
                AppsGetCollectionFieldsApp.AppPriceSchedule => "appPriceSchedule",
                AppsGetCollectionFieldsApp.AppStoreIcon => "appStoreIcon",
                AppsGetCollectionFieldsApp.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                AppsGetCollectionFieldsApp.AppStoreVersions => "appStoreVersions",
                AppsGetCollectionFieldsApp.AppTags => "appTags",
                AppsGetCollectionFieldsApp.BackgroundAssets => "backgroundAssets",
                AppsGetCollectionFieldsApp.BetaAppLocalizations => "betaAppLocalizations",
                AppsGetCollectionFieldsApp.BetaAppReviewDetail => "betaAppReviewDetail",
                AppsGetCollectionFieldsApp.BetaFeedbackCrashSubmissions => "betaFeedbackCrashSubmissions",
                AppsGetCollectionFieldsApp.BetaFeedbackScreenshotSubmissions => "betaFeedbackScreenshotSubmissions",
                AppsGetCollectionFieldsApp.BetaGroups => "betaGroups",
                AppsGetCollectionFieldsApp.BetaLicenseAgreement => "betaLicenseAgreement",
                AppsGetCollectionFieldsApp.BetaTesters => "betaTesters",
                AppsGetCollectionFieldsApp.BuildUploads => "buildUploads",
                AppsGetCollectionFieldsApp.Builds => "builds",
                AppsGetCollectionFieldsApp.BundleId => "bundleId",
                AppsGetCollectionFieldsApp.CiProduct => "ciProduct",
                AppsGetCollectionFieldsApp.ContentRightsDeclaration => "contentRightsDeclaration",
                AppsGetCollectionFieldsApp.CustomerReviewSummarizations => "customerReviewSummarizations",
                AppsGetCollectionFieldsApp.CustomerReviews => "customerReviews",
                AppsGetCollectionFieldsApp.EndUserLicenseAgreement => "endUserLicenseAgreement",
                AppsGetCollectionFieldsApp.GameCenterDetail => "gameCenterDetail",
                AppsGetCollectionFieldsApp.GameCenterEnabledVersions => "gameCenterEnabledVersions",
                AppsGetCollectionFieldsApp.InAppPurchases => "inAppPurchases",
                AppsGetCollectionFieldsApp.InAppPurchasesV2 => "inAppPurchasesV2",
                AppsGetCollectionFieldsApp.IsOrEverWasMadeForKids => "isOrEverWasMadeForKids",
                AppsGetCollectionFieldsApp.MarketplaceSearchDetail => "marketplaceSearchDetail",
                AppsGetCollectionFieldsApp.Name => "name",
                AppsGetCollectionFieldsApp.PerfPowerMetrics => "perfPowerMetrics",
                AppsGetCollectionFieldsApp.PreReleaseVersions => "preReleaseVersions",
                AppsGetCollectionFieldsApp.PrimaryLocale => "primaryLocale",
                AppsGetCollectionFieldsApp.PromotedPurchases => "promotedPurchases",
                AppsGetCollectionFieldsApp.ReviewSubmissions => "reviewSubmissions",
                AppsGetCollectionFieldsApp.SearchKeywords => "searchKeywords",
                AppsGetCollectionFieldsApp.Sku => "sku",
                AppsGetCollectionFieldsApp.StreamlinedPurchasingEnabled => "streamlinedPurchasingEnabled",
                AppsGetCollectionFieldsApp.SubscriptionGracePeriod => "subscriptionGracePeriod",
                AppsGetCollectionFieldsApp.SubscriptionGroups => "subscriptionGroups",
                AppsGetCollectionFieldsApp.SubscriptionStatusUrl => "subscriptionStatusUrl",
                AppsGetCollectionFieldsApp.SubscriptionStatusUrlForSandbox => "subscriptionStatusUrlForSandbox",
                AppsGetCollectionFieldsApp.SubscriptionStatusUrlVersion => "subscriptionStatusUrlVersion",
                AppsGetCollectionFieldsApp.SubscriptionStatusUrlVersionForSandbox => "subscriptionStatusUrlVersionForSandbox",
                AppsGetCollectionFieldsApp.Webhooks => "webhooks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGetCollectionFieldsApp? ToEnum(string value)
        {
            return value switch
            {
                "accessibilityDeclarations" => AppsGetCollectionFieldsApp.AccessibilityDeclarations,
                "accessibilityUrl" => AppsGetCollectionFieldsApp.AccessibilityUrl,
                "alternativeDistributionKey" => AppsGetCollectionFieldsApp.AlternativeDistributionKey,
                "analyticsReportRequests" => AppsGetCollectionFieldsApp.AnalyticsReportRequests,
                "androidToIosAppMappingDetails" => AppsGetCollectionFieldsApp.AndroidToIosAppMappingDetails,
                "appAvailabilityV2" => AppsGetCollectionFieldsApp.AppAvailabilityV2,
                "appClips" => AppsGetCollectionFieldsApp.AppClips,
                "appCustomProductPages" => AppsGetCollectionFieldsApp.AppCustomProductPages,
                "appEncryptionDeclarations" => AppsGetCollectionFieldsApp.AppEncryptionDeclarations,
                "appEvents" => AppsGetCollectionFieldsApp.AppEvents,
                "appInfos" => AppsGetCollectionFieldsApp.AppInfos,
                "appPricePoints" => AppsGetCollectionFieldsApp.AppPricePoints,
                "appPriceSchedule" => AppsGetCollectionFieldsApp.AppPriceSchedule,
                "appStoreIcon" => AppsGetCollectionFieldsApp.AppStoreIcon,
                "appStoreVersionExperimentsV2" => AppsGetCollectionFieldsApp.AppStoreVersionExperimentsV2,
                "appStoreVersions" => AppsGetCollectionFieldsApp.AppStoreVersions,
                "appTags" => AppsGetCollectionFieldsApp.AppTags,
                "backgroundAssets" => AppsGetCollectionFieldsApp.BackgroundAssets,
                "betaAppLocalizations" => AppsGetCollectionFieldsApp.BetaAppLocalizations,
                "betaAppReviewDetail" => AppsGetCollectionFieldsApp.BetaAppReviewDetail,
                "betaFeedbackCrashSubmissions" => AppsGetCollectionFieldsApp.BetaFeedbackCrashSubmissions,
                "betaFeedbackScreenshotSubmissions" => AppsGetCollectionFieldsApp.BetaFeedbackScreenshotSubmissions,
                "betaGroups" => AppsGetCollectionFieldsApp.BetaGroups,
                "betaLicenseAgreement" => AppsGetCollectionFieldsApp.BetaLicenseAgreement,
                "betaTesters" => AppsGetCollectionFieldsApp.BetaTesters,
                "buildUploads" => AppsGetCollectionFieldsApp.BuildUploads,
                "builds" => AppsGetCollectionFieldsApp.Builds,
                "bundleId" => AppsGetCollectionFieldsApp.BundleId,
                "ciProduct" => AppsGetCollectionFieldsApp.CiProduct,
                "contentRightsDeclaration" => AppsGetCollectionFieldsApp.ContentRightsDeclaration,
                "customerReviewSummarizations" => AppsGetCollectionFieldsApp.CustomerReviewSummarizations,
                "customerReviews" => AppsGetCollectionFieldsApp.CustomerReviews,
                "endUserLicenseAgreement" => AppsGetCollectionFieldsApp.EndUserLicenseAgreement,
                "gameCenterDetail" => AppsGetCollectionFieldsApp.GameCenterDetail,
                "gameCenterEnabledVersions" => AppsGetCollectionFieldsApp.GameCenterEnabledVersions,
                "inAppPurchases" => AppsGetCollectionFieldsApp.InAppPurchases,
                "inAppPurchasesV2" => AppsGetCollectionFieldsApp.InAppPurchasesV2,
                "isOrEverWasMadeForKids" => AppsGetCollectionFieldsApp.IsOrEverWasMadeForKids,
                "marketplaceSearchDetail" => AppsGetCollectionFieldsApp.MarketplaceSearchDetail,
                "name" => AppsGetCollectionFieldsApp.Name,
                "perfPowerMetrics" => AppsGetCollectionFieldsApp.PerfPowerMetrics,
                "preReleaseVersions" => AppsGetCollectionFieldsApp.PreReleaseVersions,
                "primaryLocale" => AppsGetCollectionFieldsApp.PrimaryLocale,
                "promotedPurchases" => AppsGetCollectionFieldsApp.PromotedPurchases,
                "reviewSubmissions" => AppsGetCollectionFieldsApp.ReviewSubmissions,
                "searchKeywords" => AppsGetCollectionFieldsApp.SearchKeywords,
                "sku" => AppsGetCollectionFieldsApp.Sku,
                "streamlinedPurchasingEnabled" => AppsGetCollectionFieldsApp.StreamlinedPurchasingEnabled,
                "subscriptionGracePeriod" => AppsGetCollectionFieldsApp.SubscriptionGracePeriod,
                "subscriptionGroups" => AppsGetCollectionFieldsApp.SubscriptionGroups,
                "subscriptionStatusUrl" => AppsGetCollectionFieldsApp.SubscriptionStatusUrl,
                "subscriptionStatusUrlForSandbox" => AppsGetCollectionFieldsApp.SubscriptionStatusUrlForSandbox,
                "subscriptionStatusUrlVersion" => AppsGetCollectionFieldsApp.SubscriptionStatusUrlVersion,
                "subscriptionStatusUrlVersionForSandbox" => AppsGetCollectionFieldsApp.SubscriptionStatusUrlVersionForSandbox,
                "webhooks" => AppsGetCollectionFieldsApp.Webhooks,
                _ => null,
            };
        }
    }
}