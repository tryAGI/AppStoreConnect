
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaAppLocalizationsGetInstanceFieldsApp
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
    public static class BetaAppLocalizationsGetInstanceFieldsAppExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAppLocalizationsGetInstanceFieldsApp value)
        {
            return value switch
            {
                BetaAppLocalizationsGetInstanceFieldsApp.AccessibilityDeclarations => "accessibilityDeclarations",
                BetaAppLocalizationsGetInstanceFieldsApp.AccessibilityUrl => "accessibilityUrl",
                BetaAppLocalizationsGetInstanceFieldsApp.AlternativeDistributionKey => "alternativeDistributionKey",
                BetaAppLocalizationsGetInstanceFieldsApp.AnalyticsReportRequests => "analyticsReportRequests",
                BetaAppLocalizationsGetInstanceFieldsApp.AndroidToIosAppMappingDetails => "androidToIosAppMappingDetails",
                BetaAppLocalizationsGetInstanceFieldsApp.AppAvailabilityV2 => "appAvailabilityV2",
                BetaAppLocalizationsGetInstanceFieldsApp.AppClips => "appClips",
                BetaAppLocalizationsGetInstanceFieldsApp.AppCustomProductPages => "appCustomProductPages",
                BetaAppLocalizationsGetInstanceFieldsApp.AppEncryptionDeclarations => "appEncryptionDeclarations",
                BetaAppLocalizationsGetInstanceFieldsApp.AppEvents => "appEvents",
                BetaAppLocalizationsGetInstanceFieldsApp.AppInfos => "appInfos",
                BetaAppLocalizationsGetInstanceFieldsApp.AppPricePoints => "appPricePoints",
                BetaAppLocalizationsGetInstanceFieldsApp.AppPriceSchedule => "appPriceSchedule",
                BetaAppLocalizationsGetInstanceFieldsApp.AppStoreIcon => "appStoreIcon",
                BetaAppLocalizationsGetInstanceFieldsApp.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                BetaAppLocalizationsGetInstanceFieldsApp.AppStoreVersions => "appStoreVersions",
                BetaAppLocalizationsGetInstanceFieldsApp.AppTags => "appTags",
                BetaAppLocalizationsGetInstanceFieldsApp.BackgroundAssets => "backgroundAssets",
                BetaAppLocalizationsGetInstanceFieldsApp.BetaAppLocalizations => "betaAppLocalizations",
                BetaAppLocalizationsGetInstanceFieldsApp.BetaAppReviewDetail => "betaAppReviewDetail",
                BetaAppLocalizationsGetInstanceFieldsApp.BetaFeedbackCrashSubmissions => "betaFeedbackCrashSubmissions",
                BetaAppLocalizationsGetInstanceFieldsApp.BetaFeedbackScreenshotSubmissions => "betaFeedbackScreenshotSubmissions",
                BetaAppLocalizationsGetInstanceFieldsApp.BetaGroups => "betaGroups",
                BetaAppLocalizationsGetInstanceFieldsApp.BetaLicenseAgreement => "betaLicenseAgreement",
                BetaAppLocalizationsGetInstanceFieldsApp.BetaTesters => "betaTesters",
                BetaAppLocalizationsGetInstanceFieldsApp.BuildUploads => "buildUploads",
                BetaAppLocalizationsGetInstanceFieldsApp.Builds => "builds",
                BetaAppLocalizationsGetInstanceFieldsApp.BundleId => "bundleId",
                BetaAppLocalizationsGetInstanceFieldsApp.CiProduct => "ciProduct",
                BetaAppLocalizationsGetInstanceFieldsApp.ContentRightsDeclaration => "contentRightsDeclaration",
                BetaAppLocalizationsGetInstanceFieldsApp.CustomerReviewSummarizations => "customerReviewSummarizations",
                BetaAppLocalizationsGetInstanceFieldsApp.CustomerReviews => "customerReviews",
                BetaAppLocalizationsGetInstanceFieldsApp.EndUserLicenseAgreement => "endUserLicenseAgreement",
                BetaAppLocalizationsGetInstanceFieldsApp.GameCenterDetail => "gameCenterDetail",
                BetaAppLocalizationsGetInstanceFieldsApp.GameCenterEnabledVersions => "gameCenterEnabledVersions",
                BetaAppLocalizationsGetInstanceFieldsApp.InAppPurchases => "inAppPurchases",
                BetaAppLocalizationsGetInstanceFieldsApp.InAppPurchasesV2 => "inAppPurchasesV2",
                BetaAppLocalizationsGetInstanceFieldsApp.IsOrEverWasMadeForKids => "isOrEverWasMadeForKids",
                BetaAppLocalizationsGetInstanceFieldsApp.MarketplaceSearchDetail => "marketplaceSearchDetail",
                BetaAppLocalizationsGetInstanceFieldsApp.Name => "name",
                BetaAppLocalizationsGetInstanceFieldsApp.PerfPowerMetrics => "perfPowerMetrics",
                BetaAppLocalizationsGetInstanceFieldsApp.PreReleaseVersions => "preReleaseVersions",
                BetaAppLocalizationsGetInstanceFieldsApp.PrimaryLocale => "primaryLocale",
                BetaAppLocalizationsGetInstanceFieldsApp.PromotedPurchases => "promotedPurchases",
                BetaAppLocalizationsGetInstanceFieldsApp.ReviewSubmissions => "reviewSubmissions",
                BetaAppLocalizationsGetInstanceFieldsApp.SearchKeywords => "searchKeywords",
                BetaAppLocalizationsGetInstanceFieldsApp.Sku => "sku",
                BetaAppLocalizationsGetInstanceFieldsApp.StreamlinedPurchasingEnabled => "streamlinedPurchasingEnabled",
                BetaAppLocalizationsGetInstanceFieldsApp.SubscriptionGracePeriod => "subscriptionGracePeriod",
                BetaAppLocalizationsGetInstanceFieldsApp.SubscriptionGroups => "subscriptionGroups",
                BetaAppLocalizationsGetInstanceFieldsApp.SubscriptionStatusUrl => "subscriptionStatusUrl",
                BetaAppLocalizationsGetInstanceFieldsApp.SubscriptionStatusUrlForSandbox => "subscriptionStatusUrlForSandbox",
                BetaAppLocalizationsGetInstanceFieldsApp.SubscriptionStatusUrlVersion => "subscriptionStatusUrlVersion",
                BetaAppLocalizationsGetInstanceFieldsApp.SubscriptionStatusUrlVersionForSandbox => "subscriptionStatusUrlVersionForSandbox",
                BetaAppLocalizationsGetInstanceFieldsApp.Webhooks => "webhooks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAppLocalizationsGetInstanceFieldsApp? ToEnum(string value)
        {
            return value switch
            {
                "accessibilityDeclarations" => BetaAppLocalizationsGetInstanceFieldsApp.AccessibilityDeclarations,
                "accessibilityUrl" => BetaAppLocalizationsGetInstanceFieldsApp.AccessibilityUrl,
                "alternativeDistributionKey" => BetaAppLocalizationsGetInstanceFieldsApp.AlternativeDistributionKey,
                "analyticsReportRequests" => BetaAppLocalizationsGetInstanceFieldsApp.AnalyticsReportRequests,
                "androidToIosAppMappingDetails" => BetaAppLocalizationsGetInstanceFieldsApp.AndroidToIosAppMappingDetails,
                "appAvailabilityV2" => BetaAppLocalizationsGetInstanceFieldsApp.AppAvailabilityV2,
                "appClips" => BetaAppLocalizationsGetInstanceFieldsApp.AppClips,
                "appCustomProductPages" => BetaAppLocalizationsGetInstanceFieldsApp.AppCustomProductPages,
                "appEncryptionDeclarations" => BetaAppLocalizationsGetInstanceFieldsApp.AppEncryptionDeclarations,
                "appEvents" => BetaAppLocalizationsGetInstanceFieldsApp.AppEvents,
                "appInfos" => BetaAppLocalizationsGetInstanceFieldsApp.AppInfos,
                "appPricePoints" => BetaAppLocalizationsGetInstanceFieldsApp.AppPricePoints,
                "appPriceSchedule" => BetaAppLocalizationsGetInstanceFieldsApp.AppPriceSchedule,
                "appStoreIcon" => BetaAppLocalizationsGetInstanceFieldsApp.AppStoreIcon,
                "appStoreVersionExperimentsV2" => BetaAppLocalizationsGetInstanceFieldsApp.AppStoreVersionExperimentsV2,
                "appStoreVersions" => BetaAppLocalizationsGetInstanceFieldsApp.AppStoreVersions,
                "appTags" => BetaAppLocalizationsGetInstanceFieldsApp.AppTags,
                "backgroundAssets" => BetaAppLocalizationsGetInstanceFieldsApp.BackgroundAssets,
                "betaAppLocalizations" => BetaAppLocalizationsGetInstanceFieldsApp.BetaAppLocalizations,
                "betaAppReviewDetail" => BetaAppLocalizationsGetInstanceFieldsApp.BetaAppReviewDetail,
                "betaFeedbackCrashSubmissions" => BetaAppLocalizationsGetInstanceFieldsApp.BetaFeedbackCrashSubmissions,
                "betaFeedbackScreenshotSubmissions" => BetaAppLocalizationsGetInstanceFieldsApp.BetaFeedbackScreenshotSubmissions,
                "betaGroups" => BetaAppLocalizationsGetInstanceFieldsApp.BetaGroups,
                "betaLicenseAgreement" => BetaAppLocalizationsGetInstanceFieldsApp.BetaLicenseAgreement,
                "betaTesters" => BetaAppLocalizationsGetInstanceFieldsApp.BetaTesters,
                "buildUploads" => BetaAppLocalizationsGetInstanceFieldsApp.BuildUploads,
                "builds" => BetaAppLocalizationsGetInstanceFieldsApp.Builds,
                "bundleId" => BetaAppLocalizationsGetInstanceFieldsApp.BundleId,
                "ciProduct" => BetaAppLocalizationsGetInstanceFieldsApp.CiProduct,
                "contentRightsDeclaration" => BetaAppLocalizationsGetInstanceFieldsApp.ContentRightsDeclaration,
                "customerReviewSummarizations" => BetaAppLocalizationsGetInstanceFieldsApp.CustomerReviewSummarizations,
                "customerReviews" => BetaAppLocalizationsGetInstanceFieldsApp.CustomerReviews,
                "endUserLicenseAgreement" => BetaAppLocalizationsGetInstanceFieldsApp.EndUserLicenseAgreement,
                "gameCenterDetail" => BetaAppLocalizationsGetInstanceFieldsApp.GameCenterDetail,
                "gameCenterEnabledVersions" => BetaAppLocalizationsGetInstanceFieldsApp.GameCenterEnabledVersions,
                "inAppPurchases" => BetaAppLocalizationsGetInstanceFieldsApp.InAppPurchases,
                "inAppPurchasesV2" => BetaAppLocalizationsGetInstanceFieldsApp.InAppPurchasesV2,
                "isOrEverWasMadeForKids" => BetaAppLocalizationsGetInstanceFieldsApp.IsOrEverWasMadeForKids,
                "marketplaceSearchDetail" => BetaAppLocalizationsGetInstanceFieldsApp.MarketplaceSearchDetail,
                "name" => BetaAppLocalizationsGetInstanceFieldsApp.Name,
                "perfPowerMetrics" => BetaAppLocalizationsGetInstanceFieldsApp.PerfPowerMetrics,
                "preReleaseVersions" => BetaAppLocalizationsGetInstanceFieldsApp.PreReleaseVersions,
                "primaryLocale" => BetaAppLocalizationsGetInstanceFieldsApp.PrimaryLocale,
                "promotedPurchases" => BetaAppLocalizationsGetInstanceFieldsApp.PromotedPurchases,
                "reviewSubmissions" => BetaAppLocalizationsGetInstanceFieldsApp.ReviewSubmissions,
                "searchKeywords" => BetaAppLocalizationsGetInstanceFieldsApp.SearchKeywords,
                "sku" => BetaAppLocalizationsGetInstanceFieldsApp.Sku,
                "streamlinedPurchasingEnabled" => BetaAppLocalizationsGetInstanceFieldsApp.StreamlinedPurchasingEnabled,
                "subscriptionGracePeriod" => BetaAppLocalizationsGetInstanceFieldsApp.SubscriptionGracePeriod,
                "subscriptionGroups" => BetaAppLocalizationsGetInstanceFieldsApp.SubscriptionGroups,
                "subscriptionStatusUrl" => BetaAppLocalizationsGetInstanceFieldsApp.SubscriptionStatusUrl,
                "subscriptionStatusUrlForSandbox" => BetaAppLocalizationsGetInstanceFieldsApp.SubscriptionStatusUrlForSandbox,
                "subscriptionStatusUrlVersion" => BetaAppLocalizationsGetInstanceFieldsApp.SubscriptionStatusUrlVersion,
                "subscriptionStatusUrlVersionForSandbox" => BetaAppLocalizationsGetInstanceFieldsApp.SubscriptionStatusUrlVersionForSandbox,
                "webhooks" => BetaAppLocalizationsGetInstanceFieldsApp.Webhooks,
                _ => null,
            };
        }
    }
}