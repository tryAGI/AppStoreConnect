
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhooksGetInstanceFieldsApp
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
    public static class WebhooksGetInstanceFieldsAppExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksGetInstanceFieldsApp value)
        {
            return value switch
            {
                WebhooksGetInstanceFieldsApp.AccessibilityDeclarations => "accessibilityDeclarations",
                WebhooksGetInstanceFieldsApp.AccessibilityUrl => "accessibilityUrl",
                WebhooksGetInstanceFieldsApp.AlternativeDistributionKey => "alternativeDistributionKey",
                WebhooksGetInstanceFieldsApp.AnalyticsReportRequests => "analyticsReportRequests",
                WebhooksGetInstanceFieldsApp.AndroidToIosAppMappingDetails => "androidToIosAppMappingDetails",
                WebhooksGetInstanceFieldsApp.AppAvailabilityV2 => "appAvailabilityV2",
                WebhooksGetInstanceFieldsApp.AppClips => "appClips",
                WebhooksGetInstanceFieldsApp.AppCustomProductPages => "appCustomProductPages",
                WebhooksGetInstanceFieldsApp.AppEncryptionDeclarations => "appEncryptionDeclarations",
                WebhooksGetInstanceFieldsApp.AppEvents => "appEvents",
                WebhooksGetInstanceFieldsApp.AppInfos => "appInfos",
                WebhooksGetInstanceFieldsApp.AppPricePoints => "appPricePoints",
                WebhooksGetInstanceFieldsApp.AppPriceSchedule => "appPriceSchedule",
                WebhooksGetInstanceFieldsApp.AppStoreIcon => "appStoreIcon",
                WebhooksGetInstanceFieldsApp.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                WebhooksGetInstanceFieldsApp.AppStoreVersions => "appStoreVersions",
                WebhooksGetInstanceFieldsApp.AppTags => "appTags",
                WebhooksGetInstanceFieldsApp.BackgroundAssets => "backgroundAssets",
                WebhooksGetInstanceFieldsApp.BetaAppLocalizations => "betaAppLocalizations",
                WebhooksGetInstanceFieldsApp.BetaAppReviewDetail => "betaAppReviewDetail",
                WebhooksGetInstanceFieldsApp.BetaFeedbackCrashSubmissions => "betaFeedbackCrashSubmissions",
                WebhooksGetInstanceFieldsApp.BetaFeedbackScreenshotSubmissions => "betaFeedbackScreenshotSubmissions",
                WebhooksGetInstanceFieldsApp.BetaGroups => "betaGroups",
                WebhooksGetInstanceFieldsApp.BetaLicenseAgreement => "betaLicenseAgreement",
                WebhooksGetInstanceFieldsApp.BetaTesters => "betaTesters",
                WebhooksGetInstanceFieldsApp.BuildUploads => "buildUploads",
                WebhooksGetInstanceFieldsApp.Builds => "builds",
                WebhooksGetInstanceFieldsApp.BundleId => "bundleId",
                WebhooksGetInstanceFieldsApp.CiProduct => "ciProduct",
                WebhooksGetInstanceFieldsApp.ContentRightsDeclaration => "contentRightsDeclaration",
                WebhooksGetInstanceFieldsApp.CustomerReviewSummarizations => "customerReviewSummarizations",
                WebhooksGetInstanceFieldsApp.CustomerReviews => "customerReviews",
                WebhooksGetInstanceFieldsApp.EndUserLicenseAgreement => "endUserLicenseAgreement",
                WebhooksGetInstanceFieldsApp.GameCenterDetail => "gameCenterDetail",
                WebhooksGetInstanceFieldsApp.GameCenterEnabledVersions => "gameCenterEnabledVersions",
                WebhooksGetInstanceFieldsApp.InAppPurchases => "inAppPurchases",
                WebhooksGetInstanceFieldsApp.InAppPurchasesV2 => "inAppPurchasesV2",
                WebhooksGetInstanceFieldsApp.IsOrEverWasMadeForKids => "isOrEverWasMadeForKids",
                WebhooksGetInstanceFieldsApp.MarketplaceSearchDetail => "marketplaceSearchDetail",
                WebhooksGetInstanceFieldsApp.Name => "name",
                WebhooksGetInstanceFieldsApp.PerfPowerMetrics => "perfPowerMetrics",
                WebhooksGetInstanceFieldsApp.PreReleaseVersions => "preReleaseVersions",
                WebhooksGetInstanceFieldsApp.PrimaryLocale => "primaryLocale",
                WebhooksGetInstanceFieldsApp.PromotedPurchases => "promotedPurchases",
                WebhooksGetInstanceFieldsApp.ReviewSubmissions => "reviewSubmissions",
                WebhooksGetInstanceFieldsApp.SearchKeywords => "searchKeywords",
                WebhooksGetInstanceFieldsApp.Sku => "sku",
                WebhooksGetInstanceFieldsApp.StreamlinedPurchasingEnabled => "streamlinedPurchasingEnabled",
                WebhooksGetInstanceFieldsApp.SubscriptionGracePeriod => "subscriptionGracePeriod",
                WebhooksGetInstanceFieldsApp.SubscriptionGroups => "subscriptionGroups",
                WebhooksGetInstanceFieldsApp.SubscriptionStatusUrl => "subscriptionStatusUrl",
                WebhooksGetInstanceFieldsApp.SubscriptionStatusUrlForSandbox => "subscriptionStatusUrlForSandbox",
                WebhooksGetInstanceFieldsApp.SubscriptionStatusUrlVersion => "subscriptionStatusUrlVersion",
                WebhooksGetInstanceFieldsApp.SubscriptionStatusUrlVersionForSandbox => "subscriptionStatusUrlVersionForSandbox",
                WebhooksGetInstanceFieldsApp.Webhooks => "webhooks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksGetInstanceFieldsApp? ToEnum(string value)
        {
            return value switch
            {
                "accessibilityDeclarations" => WebhooksGetInstanceFieldsApp.AccessibilityDeclarations,
                "accessibilityUrl" => WebhooksGetInstanceFieldsApp.AccessibilityUrl,
                "alternativeDistributionKey" => WebhooksGetInstanceFieldsApp.AlternativeDistributionKey,
                "analyticsReportRequests" => WebhooksGetInstanceFieldsApp.AnalyticsReportRequests,
                "androidToIosAppMappingDetails" => WebhooksGetInstanceFieldsApp.AndroidToIosAppMappingDetails,
                "appAvailabilityV2" => WebhooksGetInstanceFieldsApp.AppAvailabilityV2,
                "appClips" => WebhooksGetInstanceFieldsApp.AppClips,
                "appCustomProductPages" => WebhooksGetInstanceFieldsApp.AppCustomProductPages,
                "appEncryptionDeclarations" => WebhooksGetInstanceFieldsApp.AppEncryptionDeclarations,
                "appEvents" => WebhooksGetInstanceFieldsApp.AppEvents,
                "appInfos" => WebhooksGetInstanceFieldsApp.AppInfos,
                "appPricePoints" => WebhooksGetInstanceFieldsApp.AppPricePoints,
                "appPriceSchedule" => WebhooksGetInstanceFieldsApp.AppPriceSchedule,
                "appStoreIcon" => WebhooksGetInstanceFieldsApp.AppStoreIcon,
                "appStoreVersionExperimentsV2" => WebhooksGetInstanceFieldsApp.AppStoreVersionExperimentsV2,
                "appStoreVersions" => WebhooksGetInstanceFieldsApp.AppStoreVersions,
                "appTags" => WebhooksGetInstanceFieldsApp.AppTags,
                "backgroundAssets" => WebhooksGetInstanceFieldsApp.BackgroundAssets,
                "betaAppLocalizations" => WebhooksGetInstanceFieldsApp.BetaAppLocalizations,
                "betaAppReviewDetail" => WebhooksGetInstanceFieldsApp.BetaAppReviewDetail,
                "betaFeedbackCrashSubmissions" => WebhooksGetInstanceFieldsApp.BetaFeedbackCrashSubmissions,
                "betaFeedbackScreenshotSubmissions" => WebhooksGetInstanceFieldsApp.BetaFeedbackScreenshotSubmissions,
                "betaGroups" => WebhooksGetInstanceFieldsApp.BetaGroups,
                "betaLicenseAgreement" => WebhooksGetInstanceFieldsApp.BetaLicenseAgreement,
                "betaTesters" => WebhooksGetInstanceFieldsApp.BetaTesters,
                "buildUploads" => WebhooksGetInstanceFieldsApp.BuildUploads,
                "builds" => WebhooksGetInstanceFieldsApp.Builds,
                "bundleId" => WebhooksGetInstanceFieldsApp.BundleId,
                "ciProduct" => WebhooksGetInstanceFieldsApp.CiProduct,
                "contentRightsDeclaration" => WebhooksGetInstanceFieldsApp.ContentRightsDeclaration,
                "customerReviewSummarizations" => WebhooksGetInstanceFieldsApp.CustomerReviewSummarizations,
                "customerReviews" => WebhooksGetInstanceFieldsApp.CustomerReviews,
                "endUserLicenseAgreement" => WebhooksGetInstanceFieldsApp.EndUserLicenseAgreement,
                "gameCenterDetail" => WebhooksGetInstanceFieldsApp.GameCenterDetail,
                "gameCenterEnabledVersions" => WebhooksGetInstanceFieldsApp.GameCenterEnabledVersions,
                "inAppPurchases" => WebhooksGetInstanceFieldsApp.InAppPurchases,
                "inAppPurchasesV2" => WebhooksGetInstanceFieldsApp.InAppPurchasesV2,
                "isOrEverWasMadeForKids" => WebhooksGetInstanceFieldsApp.IsOrEverWasMadeForKids,
                "marketplaceSearchDetail" => WebhooksGetInstanceFieldsApp.MarketplaceSearchDetail,
                "name" => WebhooksGetInstanceFieldsApp.Name,
                "perfPowerMetrics" => WebhooksGetInstanceFieldsApp.PerfPowerMetrics,
                "preReleaseVersions" => WebhooksGetInstanceFieldsApp.PreReleaseVersions,
                "primaryLocale" => WebhooksGetInstanceFieldsApp.PrimaryLocale,
                "promotedPurchases" => WebhooksGetInstanceFieldsApp.PromotedPurchases,
                "reviewSubmissions" => WebhooksGetInstanceFieldsApp.ReviewSubmissions,
                "searchKeywords" => WebhooksGetInstanceFieldsApp.SearchKeywords,
                "sku" => WebhooksGetInstanceFieldsApp.Sku,
                "streamlinedPurchasingEnabled" => WebhooksGetInstanceFieldsApp.StreamlinedPurchasingEnabled,
                "subscriptionGracePeriod" => WebhooksGetInstanceFieldsApp.SubscriptionGracePeriod,
                "subscriptionGroups" => WebhooksGetInstanceFieldsApp.SubscriptionGroups,
                "subscriptionStatusUrl" => WebhooksGetInstanceFieldsApp.SubscriptionStatusUrl,
                "subscriptionStatusUrlForSandbox" => WebhooksGetInstanceFieldsApp.SubscriptionStatusUrlForSandbox,
                "subscriptionStatusUrlVersion" => WebhooksGetInstanceFieldsApp.SubscriptionStatusUrlVersion,
                "subscriptionStatusUrlVersionForSandbox" => WebhooksGetInstanceFieldsApp.SubscriptionStatusUrlVersionForSandbox,
                "webhooks" => WebhooksGetInstanceFieldsApp.Webhooks,
                _ => null,
            };
        }
    }
}