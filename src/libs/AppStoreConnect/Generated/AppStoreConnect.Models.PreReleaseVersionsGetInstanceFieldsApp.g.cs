
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum PreReleaseVersionsGetInstanceFieldsApp
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
    public static class PreReleaseVersionsGetInstanceFieldsAppExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PreReleaseVersionsGetInstanceFieldsApp value)
        {
            return value switch
            {
                PreReleaseVersionsGetInstanceFieldsApp.AccessibilityDeclarations => "accessibilityDeclarations",
                PreReleaseVersionsGetInstanceFieldsApp.AccessibilityUrl => "accessibilityUrl",
                PreReleaseVersionsGetInstanceFieldsApp.AlternativeDistributionKey => "alternativeDistributionKey",
                PreReleaseVersionsGetInstanceFieldsApp.AnalyticsReportRequests => "analyticsReportRequests",
                PreReleaseVersionsGetInstanceFieldsApp.AndroidToIosAppMappingDetails => "androidToIosAppMappingDetails",
                PreReleaseVersionsGetInstanceFieldsApp.AppAvailabilityV2 => "appAvailabilityV2",
                PreReleaseVersionsGetInstanceFieldsApp.AppClips => "appClips",
                PreReleaseVersionsGetInstanceFieldsApp.AppCustomProductPages => "appCustomProductPages",
                PreReleaseVersionsGetInstanceFieldsApp.AppEncryptionDeclarations => "appEncryptionDeclarations",
                PreReleaseVersionsGetInstanceFieldsApp.AppEvents => "appEvents",
                PreReleaseVersionsGetInstanceFieldsApp.AppInfos => "appInfos",
                PreReleaseVersionsGetInstanceFieldsApp.AppPricePoints => "appPricePoints",
                PreReleaseVersionsGetInstanceFieldsApp.AppPriceSchedule => "appPriceSchedule",
                PreReleaseVersionsGetInstanceFieldsApp.AppStoreIcon => "appStoreIcon",
                PreReleaseVersionsGetInstanceFieldsApp.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                PreReleaseVersionsGetInstanceFieldsApp.AppStoreVersions => "appStoreVersions",
                PreReleaseVersionsGetInstanceFieldsApp.AppTags => "appTags",
                PreReleaseVersionsGetInstanceFieldsApp.BackgroundAssets => "backgroundAssets",
                PreReleaseVersionsGetInstanceFieldsApp.BetaAppLocalizations => "betaAppLocalizations",
                PreReleaseVersionsGetInstanceFieldsApp.BetaAppReviewDetail => "betaAppReviewDetail",
                PreReleaseVersionsGetInstanceFieldsApp.BetaFeedbackCrashSubmissions => "betaFeedbackCrashSubmissions",
                PreReleaseVersionsGetInstanceFieldsApp.BetaFeedbackScreenshotSubmissions => "betaFeedbackScreenshotSubmissions",
                PreReleaseVersionsGetInstanceFieldsApp.BetaGroups => "betaGroups",
                PreReleaseVersionsGetInstanceFieldsApp.BetaLicenseAgreement => "betaLicenseAgreement",
                PreReleaseVersionsGetInstanceFieldsApp.BetaTesters => "betaTesters",
                PreReleaseVersionsGetInstanceFieldsApp.BuildUploads => "buildUploads",
                PreReleaseVersionsGetInstanceFieldsApp.Builds => "builds",
                PreReleaseVersionsGetInstanceFieldsApp.BundleId => "bundleId",
                PreReleaseVersionsGetInstanceFieldsApp.CiProduct => "ciProduct",
                PreReleaseVersionsGetInstanceFieldsApp.ContentRightsDeclaration => "contentRightsDeclaration",
                PreReleaseVersionsGetInstanceFieldsApp.CustomerReviewSummarizations => "customerReviewSummarizations",
                PreReleaseVersionsGetInstanceFieldsApp.CustomerReviews => "customerReviews",
                PreReleaseVersionsGetInstanceFieldsApp.EndUserLicenseAgreement => "endUserLicenseAgreement",
                PreReleaseVersionsGetInstanceFieldsApp.GameCenterDetail => "gameCenterDetail",
                PreReleaseVersionsGetInstanceFieldsApp.GameCenterEnabledVersions => "gameCenterEnabledVersions",
                PreReleaseVersionsGetInstanceFieldsApp.InAppPurchases => "inAppPurchases",
                PreReleaseVersionsGetInstanceFieldsApp.InAppPurchasesV2 => "inAppPurchasesV2",
                PreReleaseVersionsGetInstanceFieldsApp.IsOrEverWasMadeForKids => "isOrEverWasMadeForKids",
                PreReleaseVersionsGetInstanceFieldsApp.MarketplaceSearchDetail => "marketplaceSearchDetail",
                PreReleaseVersionsGetInstanceFieldsApp.Name => "name",
                PreReleaseVersionsGetInstanceFieldsApp.PerfPowerMetrics => "perfPowerMetrics",
                PreReleaseVersionsGetInstanceFieldsApp.PreReleaseVersions => "preReleaseVersions",
                PreReleaseVersionsGetInstanceFieldsApp.PrimaryLocale => "primaryLocale",
                PreReleaseVersionsGetInstanceFieldsApp.PromotedPurchases => "promotedPurchases",
                PreReleaseVersionsGetInstanceFieldsApp.ReviewSubmissions => "reviewSubmissions",
                PreReleaseVersionsGetInstanceFieldsApp.SearchKeywords => "searchKeywords",
                PreReleaseVersionsGetInstanceFieldsApp.Sku => "sku",
                PreReleaseVersionsGetInstanceFieldsApp.StreamlinedPurchasingEnabled => "streamlinedPurchasingEnabled",
                PreReleaseVersionsGetInstanceFieldsApp.SubscriptionGracePeriod => "subscriptionGracePeriod",
                PreReleaseVersionsGetInstanceFieldsApp.SubscriptionGroups => "subscriptionGroups",
                PreReleaseVersionsGetInstanceFieldsApp.SubscriptionStatusUrl => "subscriptionStatusUrl",
                PreReleaseVersionsGetInstanceFieldsApp.SubscriptionStatusUrlForSandbox => "subscriptionStatusUrlForSandbox",
                PreReleaseVersionsGetInstanceFieldsApp.SubscriptionStatusUrlVersion => "subscriptionStatusUrlVersion",
                PreReleaseVersionsGetInstanceFieldsApp.SubscriptionStatusUrlVersionForSandbox => "subscriptionStatusUrlVersionForSandbox",
                PreReleaseVersionsGetInstanceFieldsApp.Webhooks => "webhooks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PreReleaseVersionsGetInstanceFieldsApp? ToEnum(string value)
        {
            return value switch
            {
                "accessibilityDeclarations" => PreReleaseVersionsGetInstanceFieldsApp.AccessibilityDeclarations,
                "accessibilityUrl" => PreReleaseVersionsGetInstanceFieldsApp.AccessibilityUrl,
                "alternativeDistributionKey" => PreReleaseVersionsGetInstanceFieldsApp.AlternativeDistributionKey,
                "analyticsReportRequests" => PreReleaseVersionsGetInstanceFieldsApp.AnalyticsReportRequests,
                "androidToIosAppMappingDetails" => PreReleaseVersionsGetInstanceFieldsApp.AndroidToIosAppMappingDetails,
                "appAvailabilityV2" => PreReleaseVersionsGetInstanceFieldsApp.AppAvailabilityV2,
                "appClips" => PreReleaseVersionsGetInstanceFieldsApp.AppClips,
                "appCustomProductPages" => PreReleaseVersionsGetInstanceFieldsApp.AppCustomProductPages,
                "appEncryptionDeclarations" => PreReleaseVersionsGetInstanceFieldsApp.AppEncryptionDeclarations,
                "appEvents" => PreReleaseVersionsGetInstanceFieldsApp.AppEvents,
                "appInfos" => PreReleaseVersionsGetInstanceFieldsApp.AppInfos,
                "appPricePoints" => PreReleaseVersionsGetInstanceFieldsApp.AppPricePoints,
                "appPriceSchedule" => PreReleaseVersionsGetInstanceFieldsApp.AppPriceSchedule,
                "appStoreIcon" => PreReleaseVersionsGetInstanceFieldsApp.AppStoreIcon,
                "appStoreVersionExperimentsV2" => PreReleaseVersionsGetInstanceFieldsApp.AppStoreVersionExperimentsV2,
                "appStoreVersions" => PreReleaseVersionsGetInstanceFieldsApp.AppStoreVersions,
                "appTags" => PreReleaseVersionsGetInstanceFieldsApp.AppTags,
                "backgroundAssets" => PreReleaseVersionsGetInstanceFieldsApp.BackgroundAssets,
                "betaAppLocalizations" => PreReleaseVersionsGetInstanceFieldsApp.BetaAppLocalizations,
                "betaAppReviewDetail" => PreReleaseVersionsGetInstanceFieldsApp.BetaAppReviewDetail,
                "betaFeedbackCrashSubmissions" => PreReleaseVersionsGetInstanceFieldsApp.BetaFeedbackCrashSubmissions,
                "betaFeedbackScreenshotSubmissions" => PreReleaseVersionsGetInstanceFieldsApp.BetaFeedbackScreenshotSubmissions,
                "betaGroups" => PreReleaseVersionsGetInstanceFieldsApp.BetaGroups,
                "betaLicenseAgreement" => PreReleaseVersionsGetInstanceFieldsApp.BetaLicenseAgreement,
                "betaTesters" => PreReleaseVersionsGetInstanceFieldsApp.BetaTesters,
                "buildUploads" => PreReleaseVersionsGetInstanceFieldsApp.BuildUploads,
                "builds" => PreReleaseVersionsGetInstanceFieldsApp.Builds,
                "bundleId" => PreReleaseVersionsGetInstanceFieldsApp.BundleId,
                "ciProduct" => PreReleaseVersionsGetInstanceFieldsApp.CiProduct,
                "contentRightsDeclaration" => PreReleaseVersionsGetInstanceFieldsApp.ContentRightsDeclaration,
                "customerReviewSummarizations" => PreReleaseVersionsGetInstanceFieldsApp.CustomerReviewSummarizations,
                "customerReviews" => PreReleaseVersionsGetInstanceFieldsApp.CustomerReviews,
                "endUserLicenseAgreement" => PreReleaseVersionsGetInstanceFieldsApp.EndUserLicenseAgreement,
                "gameCenterDetail" => PreReleaseVersionsGetInstanceFieldsApp.GameCenterDetail,
                "gameCenterEnabledVersions" => PreReleaseVersionsGetInstanceFieldsApp.GameCenterEnabledVersions,
                "inAppPurchases" => PreReleaseVersionsGetInstanceFieldsApp.InAppPurchases,
                "inAppPurchasesV2" => PreReleaseVersionsGetInstanceFieldsApp.InAppPurchasesV2,
                "isOrEverWasMadeForKids" => PreReleaseVersionsGetInstanceFieldsApp.IsOrEverWasMadeForKids,
                "marketplaceSearchDetail" => PreReleaseVersionsGetInstanceFieldsApp.MarketplaceSearchDetail,
                "name" => PreReleaseVersionsGetInstanceFieldsApp.Name,
                "perfPowerMetrics" => PreReleaseVersionsGetInstanceFieldsApp.PerfPowerMetrics,
                "preReleaseVersions" => PreReleaseVersionsGetInstanceFieldsApp.PreReleaseVersions,
                "primaryLocale" => PreReleaseVersionsGetInstanceFieldsApp.PrimaryLocale,
                "promotedPurchases" => PreReleaseVersionsGetInstanceFieldsApp.PromotedPurchases,
                "reviewSubmissions" => PreReleaseVersionsGetInstanceFieldsApp.ReviewSubmissions,
                "searchKeywords" => PreReleaseVersionsGetInstanceFieldsApp.SearchKeywords,
                "sku" => PreReleaseVersionsGetInstanceFieldsApp.Sku,
                "streamlinedPurchasingEnabled" => PreReleaseVersionsGetInstanceFieldsApp.StreamlinedPurchasingEnabled,
                "subscriptionGracePeriod" => PreReleaseVersionsGetInstanceFieldsApp.SubscriptionGracePeriod,
                "subscriptionGroups" => PreReleaseVersionsGetInstanceFieldsApp.SubscriptionGroups,
                "subscriptionStatusUrl" => PreReleaseVersionsGetInstanceFieldsApp.SubscriptionStatusUrl,
                "subscriptionStatusUrlForSandbox" => PreReleaseVersionsGetInstanceFieldsApp.SubscriptionStatusUrlForSandbox,
                "subscriptionStatusUrlVersion" => PreReleaseVersionsGetInstanceFieldsApp.SubscriptionStatusUrlVersion,
                "subscriptionStatusUrlVersionForSandbox" => PreReleaseVersionsGetInstanceFieldsApp.SubscriptionStatusUrlVersionForSandbox,
                "webhooks" => PreReleaseVersionsGetInstanceFieldsApp.Webhooks,
                _ => null,
            };
        }
    }
}