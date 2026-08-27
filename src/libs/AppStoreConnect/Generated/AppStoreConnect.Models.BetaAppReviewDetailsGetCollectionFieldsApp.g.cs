
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaAppReviewDetailsGetCollectionFieldsApp
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
    public static class BetaAppReviewDetailsGetCollectionFieldsAppExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAppReviewDetailsGetCollectionFieldsApp value)
        {
            return value switch
            {
                BetaAppReviewDetailsGetCollectionFieldsApp.AccessibilityDeclarations => "accessibilityDeclarations",
                BetaAppReviewDetailsGetCollectionFieldsApp.AccessibilityUrl => "accessibilityUrl",
                BetaAppReviewDetailsGetCollectionFieldsApp.AlternativeDistributionKey => "alternativeDistributionKey",
                BetaAppReviewDetailsGetCollectionFieldsApp.AnalyticsReportRequests => "analyticsReportRequests",
                BetaAppReviewDetailsGetCollectionFieldsApp.AndroidToIosAppMappingDetails => "androidToIosAppMappingDetails",
                BetaAppReviewDetailsGetCollectionFieldsApp.AppAvailabilityV2 => "appAvailabilityV2",
                BetaAppReviewDetailsGetCollectionFieldsApp.AppClips => "appClips",
                BetaAppReviewDetailsGetCollectionFieldsApp.AppCustomProductPages => "appCustomProductPages",
                BetaAppReviewDetailsGetCollectionFieldsApp.AppEncryptionDeclarations => "appEncryptionDeclarations",
                BetaAppReviewDetailsGetCollectionFieldsApp.AppEvents => "appEvents",
                BetaAppReviewDetailsGetCollectionFieldsApp.AppInfos => "appInfos",
                BetaAppReviewDetailsGetCollectionFieldsApp.AppPricePoints => "appPricePoints",
                BetaAppReviewDetailsGetCollectionFieldsApp.AppPriceSchedule => "appPriceSchedule",
                BetaAppReviewDetailsGetCollectionFieldsApp.AppStoreIcon => "appStoreIcon",
                BetaAppReviewDetailsGetCollectionFieldsApp.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                BetaAppReviewDetailsGetCollectionFieldsApp.AppStoreVersions => "appStoreVersions",
                BetaAppReviewDetailsGetCollectionFieldsApp.AppTags => "appTags",
                BetaAppReviewDetailsGetCollectionFieldsApp.BackgroundAssets => "backgroundAssets",
                BetaAppReviewDetailsGetCollectionFieldsApp.BetaAppLocalizations => "betaAppLocalizations",
                BetaAppReviewDetailsGetCollectionFieldsApp.BetaAppReviewDetail => "betaAppReviewDetail",
                BetaAppReviewDetailsGetCollectionFieldsApp.BetaFeedbackCrashSubmissions => "betaFeedbackCrashSubmissions",
                BetaAppReviewDetailsGetCollectionFieldsApp.BetaFeedbackScreenshotSubmissions => "betaFeedbackScreenshotSubmissions",
                BetaAppReviewDetailsGetCollectionFieldsApp.BetaGroups => "betaGroups",
                BetaAppReviewDetailsGetCollectionFieldsApp.BetaLicenseAgreement => "betaLicenseAgreement",
                BetaAppReviewDetailsGetCollectionFieldsApp.BetaTesters => "betaTesters",
                BetaAppReviewDetailsGetCollectionFieldsApp.BuildUploads => "buildUploads",
                BetaAppReviewDetailsGetCollectionFieldsApp.Builds => "builds",
                BetaAppReviewDetailsGetCollectionFieldsApp.BundleId => "bundleId",
                BetaAppReviewDetailsGetCollectionFieldsApp.CiProduct => "ciProduct",
                BetaAppReviewDetailsGetCollectionFieldsApp.ContentRightsDeclaration => "contentRightsDeclaration",
                BetaAppReviewDetailsGetCollectionFieldsApp.CustomerReviewSummarizations => "customerReviewSummarizations",
                BetaAppReviewDetailsGetCollectionFieldsApp.CustomerReviews => "customerReviews",
                BetaAppReviewDetailsGetCollectionFieldsApp.EndUserLicenseAgreement => "endUserLicenseAgreement",
                BetaAppReviewDetailsGetCollectionFieldsApp.GameCenterDetail => "gameCenterDetail",
                BetaAppReviewDetailsGetCollectionFieldsApp.GameCenterEnabledVersions => "gameCenterEnabledVersions",
                BetaAppReviewDetailsGetCollectionFieldsApp.InAppPurchases => "inAppPurchases",
                BetaAppReviewDetailsGetCollectionFieldsApp.InAppPurchasesV2 => "inAppPurchasesV2",
                BetaAppReviewDetailsGetCollectionFieldsApp.IsOrEverWasMadeForKids => "isOrEverWasMadeForKids",
                BetaAppReviewDetailsGetCollectionFieldsApp.MarketplaceSearchDetail => "marketplaceSearchDetail",
                BetaAppReviewDetailsGetCollectionFieldsApp.Name => "name",
                BetaAppReviewDetailsGetCollectionFieldsApp.PerfPowerMetrics => "perfPowerMetrics",
                BetaAppReviewDetailsGetCollectionFieldsApp.PreReleaseVersions => "preReleaseVersions",
                BetaAppReviewDetailsGetCollectionFieldsApp.PrimaryLocale => "primaryLocale",
                BetaAppReviewDetailsGetCollectionFieldsApp.PromotedPurchases => "promotedPurchases",
                BetaAppReviewDetailsGetCollectionFieldsApp.ReviewSubmissions => "reviewSubmissions",
                BetaAppReviewDetailsGetCollectionFieldsApp.SearchKeywords => "searchKeywords",
                BetaAppReviewDetailsGetCollectionFieldsApp.Sku => "sku",
                BetaAppReviewDetailsGetCollectionFieldsApp.StreamlinedPurchasingEnabled => "streamlinedPurchasingEnabled",
                BetaAppReviewDetailsGetCollectionFieldsApp.SubscriptionGracePeriod => "subscriptionGracePeriod",
                BetaAppReviewDetailsGetCollectionFieldsApp.SubscriptionGroups => "subscriptionGroups",
                BetaAppReviewDetailsGetCollectionFieldsApp.SubscriptionStatusUrl => "subscriptionStatusUrl",
                BetaAppReviewDetailsGetCollectionFieldsApp.SubscriptionStatusUrlForSandbox => "subscriptionStatusUrlForSandbox",
                BetaAppReviewDetailsGetCollectionFieldsApp.SubscriptionStatusUrlVersion => "subscriptionStatusUrlVersion",
                BetaAppReviewDetailsGetCollectionFieldsApp.SubscriptionStatusUrlVersionForSandbox => "subscriptionStatusUrlVersionForSandbox",
                BetaAppReviewDetailsGetCollectionFieldsApp.Webhooks => "webhooks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAppReviewDetailsGetCollectionFieldsApp? ToEnum(string value)
        {
            return value switch
            {
                "accessibilityDeclarations" => BetaAppReviewDetailsGetCollectionFieldsApp.AccessibilityDeclarations,
                "accessibilityUrl" => BetaAppReviewDetailsGetCollectionFieldsApp.AccessibilityUrl,
                "alternativeDistributionKey" => BetaAppReviewDetailsGetCollectionFieldsApp.AlternativeDistributionKey,
                "analyticsReportRequests" => BetaAppReviewDetailsGetCollectionFieldsApp.AnalyticsReportRequests,
                "androidToIosAppMappingDetails" => BetaAppReviewDetailsGetCollectionFieldsApp.AndroidToIosAppMappingDetails,
                "appAvailabilityV2" => BetaAppReviewDetailsGetCollectionFieldsApp.AppAvailabilityV2,
                "appClips" => BetaAppReviewDetailsGetCollectionFieldsApp.AppClips,
                "appCustomProductPages" => BetaAppReviewDetailsGetCollectionFieldsApp.AppCustomProductPages,
                "appEncryptionDeclarations" => BetaAppReviewDetailsGetCollectionFieldsApp.AppEncryptionDeclarations,
                "appEvents" => BetaAppReviewDetailsGetCollectionFieldsApp.AppEvents,
                "appInfos" => BetaAppReviewDetailsGetCollectionFieldsApp.AppInfos,
                "appPricePoints" => BetaAppReviewDetailsGetCollectionFieldsApp.AppPricePoints,
                "appPriceSchedule" => BetaAppReviewDetailsGetCollectionFieldsApp.AppPriceSchedule,
                "appStoreIcon" => BetaAppReviewDetailsGetCollectionFieldsApp.AppStoreIcon,
                "appStoreVersionExperimentsV2" => BetaAppReviewDetailsGetCollectionFieldsApp.AppStoreVersionExperimentsV2,
                "appStoreVersions" => BetaAppReviewDetailsGetCollectionFieldsApp.AppStoreVersions,
                "appTags" => BetaAppReviewDetailsGetCollectionFieldsApp.AppTags,
                "backgroundAssets" => BetaAppReviewDetailsGetCollectionFieldsApp.BackgroundAssets,
                "betaAppLocalizations" => BetaAppReviewDetailsGetCollectionFieldsApp.BetaAppLocalizations,
                "betaAppReviewDetail" => BetaAppReviewDetailsGetCollectionFieldsApp.BetaAppReviewDetail,
                "betaFeedbackCrashSubmissions" => BetaAppReviewDetailsGetCollectionFieldsApp.BetaFeedbackCrashSubmissions,
                "betaFeedbackScreenshotSubmissions" => BetaAppReviewDetailsGetCollectionFieldsApp.BetaFeedbackScreenshotSubmissions,
                "betaGroups" => BetaAppReviewDetailsGetCollectionFieldsApp.BetaGroups,
                "betaLicenseAgreement" => BetaAppReviewDetailsGetCollectionFieldsApp.BetaLicenseAgreement,
                "betaTesters" => BetaAppReviewDetailsGetCollectionFieldsApp.BetaTesters,
                "buildUploads" => BetaAppReviewDetailsGetCollectionFieldsApp.BuildUploads,
                "builds" => BetaAppReviewDetailsGetCollectionFieldsApp.Builds,
                "bundleId" => BetaAppReviewDetailsGetCollectionFieldsApp.BundleId,
                "ciProduct" => BetaAppReviewDetailsGetCollectionFieldsApp.CiProduct,
                "contentRightsDeclaration" => BetaAppReviewDetailsGetCollectionFieldsApp.ContentRightsDeclaration,
                "customerReviewSummarizations" => BetaAppReviewDetailsGetCollectionFieldsApp.CustomerReviewSummarizations,
                "customerReviews" => BetaAppReviewDetailsGetCollectionFieldsApp.CustomerReviews,
                "endUserLicenseAgreement" => BetaAppReviewDetailsGetCollectionFieldsApp.EndUserLicenseAgreement,
                "gameCenterDetail" => BetaAppReviewDetailsGetCollectionFieldsApp.GameCenterDetail,
                "gameCenterEnabledVersions" => BetaAppReviewDetailsGetCollectionFieldsApp.GameCenterEnabledVersions,
                "inAppPurchases" => BetaAppReviewDetailsGetCollectionFieldsApp.InAppPurchases,
                "inAppPurchasesV2" => BetaAppReviewDetailsGetCollectionFieldsApp.InAppPurchasesV2,
                "isOrEverWasMadeForKids" => BetaAppReviewDetailsGetCollectionFieldsApp.IsOrEverWasMadeForKids,
                "marketplaceSearchDetail" => BetaAppReviewDetailsGetCollectionFieldsApp.MarketplaceSearchDetail,
                "name" => BetaAppReviewDetailsGetCollectionFieldsApp.Name,
                "perfPowerMetrics" => BetaAppReviewDetailsGetCollectionFieldsApp.PerfPowerMetrics,
                "preReleaseVersions" => BetaAppReviewDetailsGetCollectionFieldsApp.PreReleaseVersions,
                "primaryLocale" => BetaAppReviewDetailsGetCollectionFieldsApp.PrimaryLocale,
                "promotedPurchases" => BetaAppReviewDetailsGetCollectionFieldsApp.PromotedPurchases,
                "reviewSubmissions" => BetaAppReviewDetailsGetCollectionFieldsApp.ReviewSubmissions,
                "searchKeywords" => BetaAppReviewDetailsGetCollectionFieldsApp.SearchKeywords,
                "sku" => BetaAppReviewDetailsGetCollectionFieldsApp.Sku,
                "streamlinedPurchasingEnabled" => BetaAppReviewDetailsGetCollectionFieldsApp.StreamlinedPurchasingEnabled,
                "subscriptionGracePeriod" => BetaAppReviewDetailsGetCollectionFieldsApp.SubscriptionGracePeriod,
                "subscriptionGroups" => BetaAppReviewDetailsGetCollectionFieldsApp.SubscriptionGroups,
                "subscriptionStatusUrl" => BetaAppReviewDetailsGetCollectionFieldsApp.SubscriptionStatusUrl,
                "subscriptionStatusUrlForSandbox" => BetaAppReviewDetailsGetCollectionFieldsApp.SubscriptionStatusUrlForSandbox,
                "subscriptionStatusUrlVersion" => BetaAppReviewDetailsGetCollectionFieldsApp.SubscriptionStatusUrlVersion,
                "subscriptionStatusUrlVersionForSandbox" => BetaAppReviewDetailsGetCollectionFieldsApp.SubscriptionStatusUrlVersionForSandbox,
                "webhooks" => BetaAppReviewDetailsGetCollectionFieldsApp.Webhooks,
                _ => null,
            };
        }
    }
}