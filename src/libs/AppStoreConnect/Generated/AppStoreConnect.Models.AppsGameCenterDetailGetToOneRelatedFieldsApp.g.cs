
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsGameCenterDetailGetToOneRelatedFieldsApp
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
    public static class AppsGameCenterDetailGetToOneRelatedFieldsAppExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGameCenterDetailGetToOneRelatedFieldsApp value)
        {
            return value switch
            {
                AppsGameCenterDetailGetToOneRelatedFieldsApp.AccessibilityDeclarations => "accessibilityDeclarations",
                AppsGameCenterDetailGetToOneRelatedFieldsApp.AccessibilityUrl => "accessibilityUrl",
                AppsGameCenterDetailGetToOneRelatedFieldsApp.AlternativeDistributionKey => "alternativeDistributionKey",
                AppsGameCenterDetailGetToOneRelatedFieldsApp.AnalyticsReportRequests => "analyticsReportRequests",
                AppsGameCenterDetailGetToOneRelatedFieldsApp.AndroidToIosAppMappingDetails => "androidToIosAppMappingDetails",
                AppsGameCenterDetailGetToOneRelatedFieldsApp.AppAvailabilityV2 => "appAvailabilityV2",
                AppsGameCenterDetailGetToOneRelatedFieldsApp.AppClips => "appClips",
                AppsGameCenterDetailGetToOneRelatedFieldsApp.AppCustomProductPages => "appCustomProductPages",
                AppsGameCenterDetailGetToOneRelatedFieldsApp.AppEncryptionDeclarations => "appEncryptionDeclarations",
                AppsGameCenterDetailGetToOneRelatedFieldsApp.AppEvents => "appEvents",
                AppsGameCenterDetailGetToOneRelatedFieldsApp.AppInfos => "appInfos",
                AppsGameCenterDetailGetToOneRelatedFieldsApp.AppPricePoints => "appPricePoints",
                AppsGameCenterDetailGetToOneRelatedFieldsApp.AppPriceSchedule => "appPriceSchedule",
                AppsGameCenterDetailGetToOneRelatedFieldsApp.AppStoreIcon => "appStoreIcon",
                AppsGameCenterDetailGetToOneRelatedFieldsApp.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                AppsGameCenterDetailGetToOneRelatedFieldsApp.AppStoreVersions => "appStoreVersions",
                AppsGameCenterDetailGetToOneRelatedFieldsApp.AppTags => "appTags",
                AppsGameCenterDetailGetToOneRelatedFieldsApp.BackgroundAssets => "backgroundAssets",
                AppsGameCenterDetailGetToOneRelatedFieldsApp.BetaAppLocalizations => "betaAppLocalizations",
                AppsGameCenterDetailGetToOneRelatedFieldsApp.BetaAppReviewDetail => "betaAppReviewDetail",
                AppsGameCenterDetailGetToOneRelatedFieldsApp.BetaFeedbackCrashSubmissions => "betaFeedbackCrashSubmissions",
                AppsGameCenterDetailGetToOneRelatedFieldsApp.BetaFeedbackScreenshotSubmissions => "betaFeedbackScreenshotSubmissions",
                AppsGameCenterDetailGetToOneRelatedFieldsApp.BetaGroups => "betaGroups",
                AppsGameCenterDetailGetToOneRelatedFieldsApp.BetaLicenseAgreement => "betaLicenseAgreement",
                AppsGameCenterDetailGetToOneRelatedFieldsApp.BetaTesters => "betaTesters",
                AppsGameCenterDetailGetToOneRelatedFieldsApp.BuildUploads => "buildUploads",
                AppsGameCenterDetailGetToOneRelatedFieldsApp.Builds => "builds",
                AppsGameCenterDetailGetToOneRelatedFieldsApp.BundleId => "bundleId",
                AppsGameCenterDetailGetToOneRelatedFieldsApp.CiProduct => "ciProduct",
                AppsGameCenterDetailGetToOneRelatedFieldsApp.ContentRightsDeclaration => "contentRightsDeclaration",
                AppsGameCenterDetailGetToOneRelatedFieldsApp.CustomerReviewSummarizations => "customerReviewSummarizations",
                AppsGameCenterDetailGetToOneRelatedFieldsApp.CustomerReviews => "customerReviews",
                AppsGameCenterDetailGetToOneRelatedFieldsApp.EndUserLicenseAgreement => "endUserLicenseAgreement",
                AppsGameCenterDetailGetToOneRelatedFieldsApp.GameCenterDetail => "gameCenterDetail",
                AppsGameCenterDetailGetToOneRelatedFieldsApp.GameCenterEnabledVersions => "gameCenterEnabledVersions",
                AppsGameCenterDetailGetToOneRelatedFieldsApp.InAppPurchases => "inAppPurchases",
                AppsGameCenterDetailGetToOneRelatedFieldsApp.InAppPurchasesV2 => "inAppPurchasesV2",
                AppsGameCenterDetailGetToOneRelatedFieldsApp.IsOrEverWasMadeForKids => "isOrEverWasMadeForKids",
                AppsGameCenterDetailGetToOneRelatedFieldsApp.MarketplaceSearchDetail => "marketplaceSearchDetail",
                AppsGameCenterDetailGetToOneRelatedFieldsApp.Name => "name",
                AppsGameCenterDetailGetToOneRelatedFieldsApp.PerfPowerMetrics => "perfPowerMetrics",
                AppsGameCenterDetailGetToOneRelatedFieldsApp.PreReleaseVersions => "preReleaseVersions",
                AppsGameCenterDetailGetToOneRelatedFieldsApp.PrimaryLocale => "primaryLocale",
                AppsGameCenterDetailGetToOneRelatedFieldsApp.PromotedPurchases => "promotedPurchases",
                AppsGameCenterDetailGetToOneRelatedFieldsApp.ReviewSubmissions => "reviewSubmissions",
                AppsGameCenterDetailGetToOneRelatedFieldsApp.SearchKeywords => "searchKeywords",
                AppsGameCenterDetailGetToOneRelatedFieldsApp.Sku => "sku",
                AppsGameCenterDetailGetToOneRelatedFieldsApp.StreamlinedPurchasingEnabled => "streamlinedPurchasingEnabled",
                AppsGameCenterDetailGetToOneRelatedFieldsApp.SubscriptionGracePeriod => "subscriptionGracePeriod",
                AppsGameCenterDetailGetToOneRelatedFieldsApp.SubscriptionGroups => "subscriptionGroups",
                AppsGameCenterDetailGetToOneRelatedFieldsApp.SubscriptionStatusUrl => "subscriptionStatusUrl",
                AppsGameCenterDetailGetToOneRelatedFieldsApp.SubscriptionStatusUrlForSandbox => "subscriptionStatusUrlForSandbox",
                AppsGameCenterDetailGetToOneRelatedFieldsApp.SubscriptionStatusUrlVersion => "subscriptionStatusUrlVersion",
                AppsGameCenterDetailGetToOneRelatedFieldsApp.SubscriptionStatusUrlVersionForSandbox => "subscriptionStatusUrlVersionForSandbox",
                AppsGameCenterDetailGetToOneRelatedFieldsApp.Webhooks => "webhooks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGameCenterDetailGetToOneRelatedFieldsApp? ToEnum(string value)
        {
            return value switch
            {
                "accessibilityDeclarations" => AppsGameCenterDetailGetToOneRelatedFieldsApp.AccessibilityDeclarations,
                "accessibilityUrl" => AppsGameCenterDetailGetToOneRelatedFieldsApp.AccessibilityUrl,
                "alternativeDistributionKey" => AppsGameCenterDetailGetToOneRelatedFieldsApp.AlternativeDistributionKey,
                "analyticsReportRequests" => AppsGameCenterDetailGetToOneRelatedFieldsApp.AnalyticsReportRequests,
                "androidToIosAppMappingDetails" => AppsGameCenterDetailGetToOneRelatedFieldsApp.AndroidToIosAppMappingDetails,
                "appAvailabilityV2" => AppsGameCenterDetailGetToOneRelatedFieldsApp.AppAvailabilityV2,
                "appClips" => AppsGameCenterDetailGetToOneRelatedFieldsApp.AppClips,
                "appCustomProductPages" => AppsGameCenterDetailGetToOneRelatedFieldsApp.AppCustomProductPages,
                "appEncryptionDeclarations" => AppsGameCenterDetailGetToOneRelatedFieldsApp.AppEncryptionDeclarations,
                "appEvents" => AppsGameCenterDetailGetToOneRelatedFieldsApp.AppEvents,
                "appInfos" => AppsGameCenterDetailGetToOneRelatedFieldsApp.AppInfos,
                "appPricePoints" => AppsGameCenterDetailGetToOneRelatedFieldsApp.AppPricePoints,
                "appPriceSchedule" => AppsGameCenterDetailGetToOneRelatedFieldsApp.AppPriceSchedule,
                "appStoreIcon" => AppsGameCenterDetailGetToOneRelatedFieldsApp.AppStoreIcon,
                "appStoreVersionExperimentsV2" => AppsGameCenterDetailGetToOneRelatedFieldsApp.AppStoreVersionExperimentsV2,
                "appStoreVersions" => AppsGameCenterDetailGetToOneRelatedFieldsApp.AppStoreVersions,
                "appTags" => AppsGameCenterDetailGetToOneRelatedFieldsApp.AppTags,
                "backgroundAssets" => AppsGameCenterDetailGetToOneRelatedFieldsApp.BackgroundAssets,
                "betaAppLocalizations" => AppsGameCenterDetailGetToOneRelatedFieldsApp.BetaAppLocalizations,
                "betaAppReviewDetail" => AppsGameCenterDetailGetToOneRelatedFieldsApp.BetaAppReviewDetail,
                "betaFeedbackCrashSubmissions" => AppsGameCenterDetailGetToOneRelatedFieldsApp.BetaFeedbackCrashSubmissions,
                "betaFeedbackScreenshotSubmissions" => AppsGameCenterDetailGetToOneRelatedFieldsApp.BetaFeedbackScreenshotSubmissions,
                "betaGroups" => AppsGameCenterDetailGetToOneRelatedFieldsApp.BetaGroups,
                "betaLicenseAgreement" => AppsGameCenterDetailGetToOneRelatedFieldsApp.BetaLicenseAgreement,
                "betaTesters" => AppsGameCenterDetailGetToOneRelatedFieldsApp.BetaTesters,
                "buildUploads" => AppsGameCenterDetailGetToOneRelatedFieldsApp.BuildUploads,
                "builds" => AppsGameCenterDetailGetToOneRelatedFieldsApp.Builds,
                "bundleId" => AppsGameCenterDetailGetToOneRelatedFieldsApp.BundleId,
                "ciProduct" => AppsGameCenterDetailGetToOneRelatedFieldsApp.CiProduct,
                "contentRightsDeclaration" => AppsGameCenterDetailGetToOneRelatedFieldsApp.ContentRightsDeclaration,
                "customerReviewSummarizations" => AppsGameCenterDetailGetToOneRelatedFieldsApp.CustomerReviewSummarizations,
                "customerReviews" => AppsGameCenterDetailGetToOneRelatedFieldsApp.CustomerReviews,
                "endUserLicenseAgreement" => AppsGameCenterDetailGetToOneRelatedFieldsApp.EndUserLicenseAgreement,
                "gameCenterDetail" => AppsGameCenterDetailGetToOneRelatedFieldsApp.GameCenterDetail,
                "gameCenterEnabledVersions" => AppsGameCenterDetailGetToOneRelatedFieldsApp.GameCenterEnabledVersions,
                "inAppPurchases" => AppsGameCenterDetailGetToOneRelatedFieldsApp.InAppPurchases,
                "inAppPurchasesV2" => AppsGameCenterDetailGetToOneRelatedFieldsApp.InAppPurchasesV2,
                "isOrEverWasMadeForKids" => AppsGameCenterDetailGetToOneRelatedFieldsApp.IsOrEverWasMadeForKids,
                "marketplaceSearchDetail" => AppsGameCenterDetailGetToOneRelatedFieldsApp.MarketplaceSearchDetail,
                "name" => AppsGameCenterDetailGetToOneRelatedFieldsApp.Name,
                "perfPowerMetrics" => AppsGameCenterDetailGetToOneRelatedFieldsApp.PerfPowerMetrics,
                "preReleaseVersions" => AppsGameCenterDetailGetToOneRelatedFieldsApp.PreReleaseVersions,
                "primaryLocale" => AppsGameCenterDetailGetToOneRelatedFieldsApp.PrimaryLocale,
                "promotedPurchases" => AppsGameCenterDetailGetToOneRelatedFieldsApp.PromotedPurchases,
                "reviewSubmissions" => AppsGameCenterDetailGetToOneRelatedFieldsApp.ReviewSubmissions,
                "searchKeywords" => AppsGameCenterDetailGetToOneRelatedFieldsApp.SearchKeywords,
                "sku" => AppsGameCenterDetailGetToOneRelatedFieldsApp.Sku,
                "streamlinedPurchasingEnabled" => AppsGameCenterDetailGetToOneRelatedFieldsApp.StreamlinedPurchasingEnabled,
                "subscriptionGracePeriod" => AppsGameCenterDetailGetToOneRelatedFieldsApp.SubscriptionGracePeriod,
                "subscriptionGroups" => AppsGameCenterDetailGetToOneRelatedFieldsApp.SubscriptionGroups,
                "subscriptionStatusUrl" => AppsGameCenterDetailGetToOneRelatedFieldsApp.SubscriptionStatusUrl,
                "subscriptionStatusUrlForSandbox" => AppsGameCenterDetailGetToOneRelatedFieldsApp.SubscriptionStatusUrlForSandbox,
                "subscriptionStatusUrlVersion" => AppsGameCenterDetailGetToOneRelatedFieldsApp.SubscriptionStatusUrlVersion,
                "subscriptionStatusUrlVersionForSandbox" => AppsGameCenterDetailGetToOneRelatedFieldsApp.SubscriptionStatusUrlVersionForSandbox,
                "webhooks" => AppsGameCenterDetailGetToOneRelatedFieldsApp.Webhooks,
                _ => null,
            };
        }
    }
}