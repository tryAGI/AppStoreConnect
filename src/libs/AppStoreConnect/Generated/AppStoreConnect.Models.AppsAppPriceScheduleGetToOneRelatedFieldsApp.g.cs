
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsAppPriceScheduleGetToOneRelatedFieldsApp
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
    public static class AppsAppPriceScheduleGetToOneRelatedFieldsAppExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsAppPriceScheduleGetToOneRelatedFieldsApp value)
        {
            return value switch
            {
                AppsAppPriceScheduleGetToOneRelatedFieldsApp.AccessibilityDeclarations => "accessibilityDeclarations",
                AppsAppPriceScheduleGetToOneRelatedFieldsApp.AccessibilityUrl => "accessibilityUrl",
                AppsAppPriceScheduleGetToOneRelatedFieldsApp.AlternativeDistributionKey => "alternativeDistributionKey",
                AppsAppPriceScheduleGetToOneRelatedFieldsApp.AnalyticsReportRequests => "analyticsReportRequests",
                AppsAppPriceScheduleGetToOneRelatedFieldsApp.AndroidToIosAppMappingDetails => "androidToIosAppMappingDetails",
                AppsAppPriceScheduleGetToOneRelatedFieldsApp.AppAvailabilityV2 => "appAvailabilityV2",
                AppsAppPriceScheduleGetToOneRelatedFieldsApp.AppClips => "appClips",
                AppsAppPriceScheduleGetToOneRelatedFieldsApp.AppCustomProductPages => "appCustomProductPages",
                AppsAppPriceScheduleGetToOneRelatedFieldsApp.AppEncryptionDeclarations => "appEncryptionDeclarations",
                AppsAppPriceScheduleGetToOneRelatedFieldsApp.AppEvents => "appEvents",
                AppsAppPriceScheduleGetToOneRelatedFieldsApp.AppInfos => "appInfos",
                AppsAppPriceScheduleGetToOneRelatedFieldsApp.AppPricePoints => "appPricePoints",
                AppsAppPriceScheduleGetToOneRelatedFieldsApp.AppPriceSchedule => "appPriceSchedule",
                AppsAppPriceScheduleGetToOneRelatedFieldsApp.AppStoreIcon => "appStoreIcon",
                AppsAppPriceScheduleGetToOneRelatedFieldsApp.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                AppsAppPriceScheduleGetToOneRelatedFieldsApp.AppStoreVersions => "appStoreVersions",
                AppsAppPriceScheduleGetToOneRelatedFieldsApp.AppTags => "appTags",
                AppsAppPriceScheduleGetToOneRelatedFieldsApp.BackgroundAssets => "backgroundAssets",
                AppsAppPriceScheduleGetToOneRelatedFieldsApp.BetaAppLocalizations => "betaAppLocalizations",
                AppsAppPriceScheduleGetToOneRelatedFieldsApp.BetaAppReviewDetail => "betaAppReviewDetail",
                AppsAppPriceScheduleGetToOneRelatedFieldsApp.BetaFeedbackCrashSubmissions => "betaFeedbackCrashSubmissions",
                AppsAppPriceScheduleGetToOneRelatedFieldsApp.BetaFeedbackScreenshotSubmissions => "betaFeedbackScreenshotSubmissions",
                AppsAppPriceScheduleGetToOneRelatedFieldsApp.BetaGroups => "betaGroups",
                AppsAppPriceScheduleGetToOneRelatedFieldsApp.BetaLicenseAgreement => "betaLicenseAgreement",
                AppsAppPriceScheduleGetToOneRelatedFieldsApp.BetaTesters => "betaTesters",
                AppsAppPriceScheduleGetToOneRelatedFieldsApp.BuildUploads => "buildUploads",
                AppsAppPriceScheduleGetToOneRelatedFieldsApp.Builds => "builds",
                AppsAppPriceScheduleGetToOneRelatedFieldsApp.BundleId => "bundleId",
                AppsAppPriceScheduleGetToOneRelatedFieldsApp.CiProduct => "ciProduct",
                AppsAppPriceScheduleGetToOneRelatedFieldsApp.ContentRightsDeclaration => "contentRightsDeclaration",
                AppsAppPriceScheduleGetToOneRelatedFieldsApp.CustomerReviewSummarizations => "customerReviewSummarizations",
                AppsAppPriceScheduleGetToOneRelatedFieldsApp.CustomerReviews => "customerReviews",
                AppsAppPriceScheduleGetToOneRelatedFieldsApp.EndUserLicenseAgreement => "endUserLicenseAgreement",
                AppsAppPriceScheduleGetToOneRelatedFieldsApp.GameCenterDetail => "gameCenterDetail",
                AppsAppPriceScheduleGetToOneRelatedFieldsApp.GameCenterEnabledVersions => "gameCenterEnabledVersions",
                AppsAppPriceScheduleGetToOneRelatedFieldsApp.InAppPurchases => "inAppPurchases",
                AppsAppPriceScheduleGetToOneRelatedFieldsApp.InAppPurchasesV2 => "inAppPurchasesV2",
                AppsAppPriceScheduleGetToOneRelatedFieldsApp.IsOrEverWasMadeForKids => "isOrEverWasMadeForKids",
                AppsAppPriceScheduleGetToOneRelatedFieldsApp.MarketplaceSearchDetail => "marketplaceSearchDetail",
                AppsAppPriceScheduleGetToOneRelatedFieldsApp.Name => "name",
                AppsAppPriceScheduleGetToOneRelatedFieldsApp.PerfPowerMetrics => "perfPowerMetrics",
                AppsAppPriceScheduleGetToOneRelatedFieldsApp.PreReleaseVersions => "preReleaseVersions",
                AppsAppPriceScheduleGetToOneRelatedFieldsApp.PrimaryLocale => "primaryLocale",
                AppsAppPriceScheduleGetToOneRelatedFieldsApp.PromotedPurchases => "promotedPurchases",
                AppsAppPriceScheduleGetToOneRelatedFieldsApp.ReviewSubmissions => "reviewSubmissions",
                AppsAppPriceScheduleGetToOneRelatedFieldsApp.SearchKeywords => "searchKeywords",
                AppsAppPriceScheduleGetToOneRelatedFieldsApp.Sku => "sku",
                AppsAppPriceScheduleGetToOneRelatedFieldsApp.StreamlinedPurchasingEnabled => "streamlinedPurchasingEnabled",
                AppsAppPriceScheduleGetToOneRelatedFieldsApp.SubscriptionGracePeriod => "subscriptionGracePeriod",
                AppsAppPriceScheduleGetToOneRelatedFieldsApp.SubscriptionGroups => "subscriptionGroups",
                AppsAppPriceScheduleGetToOneRelatedFieldsApp.SubscriptionStatusUrl => "subscriptionStatusUrl",
                AppsAppPriceScheduleGetToOneRelatedFieldsApp.SubscriptionStatusUrlForSandbox => "subscriptionStatusUrlForSandbox",
                AppsAppPriceScheduleGetToOneRelatedFieldsApp.SubscriptionStatusUrlVersion => "subscriptionStatusUrlVersion",
                AppsAppPriceScheduleGetToOneRelatedFieldsApp.SubscriptionStatusUrlVersionForSandbox => "subscriptionStatusUrlVersionForSandbox",
                AppsAppPriceScheduleGetToOneRelatedFieldsApp.Webhooks => "webhooks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsAppPriceScheduleGetToOneRelatedFieldsApp? ToEnum(string value)
        {
            return value switch
            {
                "accessibilityDeclarations" => AppsAppPriceScheduleGetToOneRelatedFieldsApp.AccessibilityDeclarations,
                "accessibilityUrl" => AppsAppPriceScheduleGetToOneRelatedFieldsApp.AccessibilityUrl,
                "alternativeDistributionKey" => AppsAppPriceScheduleGetToOneRelatedFieldsApp.AlternativeDistributionKey,
                "analyticsReportRequests" => AppsAppPriceScheduleGetToOneRelatedFieldsApp.AnalyticsReportRequests,
                "androidToIosAppMappingDetails" => AppsAppPriceScheduleGetToOneRelatedFieldsApp.AndroidToIosAppMappingDetails,
                "appAvailabilityV2" => AppsAppPriceScheduleGetToOneRelatedFieldsApp.AppAvailabilityV2,
                "appClips" => AppsAppPriceScheduleGetToOneRelatedFieldsApp.AppClips,
                "appCustomProductPages" => AppsAppPriceScheduleGetToOneRelatedFieldsApp.AppCustomProductPages,
                "appEncryptionDeclarations" => AppsAppPriceScheduleGetToOneRelatedFieldsApp.AppEncryptionDeclarations,
                "appEvents" => AppsAppPriceScheduleGetToOneRelatedFieldsApp.AppEvents,
                "appInfos" => AppsAppPriceScheduleGetToOneRelatedFieldsApp.AppInfos,
                "appPricePoints" => AppsAppPriceScheduleGetToOneRelatedFieldsApp.AppPricePoints,
                "appPriceSchedule" => AppsAppPriceScheduleGetToOneRelatedFieldsApp.AppPriceSchedule,
                "appStoreIcon" => AppsAppPriceScheduleGetToOneRelatedFieldsApp.AppStoreIcon,
                "appStoreVersionExperimentsV2" => AppsAppPriceScheduleGetToOneRelatedFieldsApp.AppStoreVersionExperimentsV2,
                "appStoreVersions" => AppsAppPriceScheduleGetToOneRelatedFieldsApp.AppStoreVersions,
                "appTags" => AppsAppPriceScheduleGetToOneRelatedFieldsApp.AppTags,
                "backgroundAssets" => AppsAppPriceScheduleGetToOneRelatedFieldsApp.BackgroundAssets,
                "betaAppLocalizations" => AppsAppPriceScheduleGetToOneRelatedFieldsApp.BetaAppLocalizations,
                "betaAppReviewDetail" => AppsAppPriceScheduleGetToOneRelatedFieldsApp.BetaAppReviewDetail,
                "betaFeedbackCrashSubmissions" => AppsAppPriceScheduleGetToOneRelatedFieldsApp.BetaFeedbackCrashSubmissions,
                "betaFeedbackScreenshotSubmissions" => AppsAppPriceScheduleGetToOneRelatedFieldsApp.BetaFeedbackScreenshotSubmissions,
                "betaGroups" => AppsAppPriceScheduleGetToOneRelatedFieldsApp.BetaGroups,
                "betaLicenseAgreement" => AppsAppPriceScheduleGetToOneRelatedFieldsApp.BetaLicenseAgreement,
                "betaTesters" => AppsAppPriceScheduleGetToOneRelatedFieldsApp.BetaTesters,
                "buildUploads" => AppsAppPriceScheduleGetToOneRelatedFieldsApp.BuildUploads,
                "builds" => AppsAppPriceScheduleGetToOneRelatedFieldsApp.Builds,
                "bundleId" => AppsAppPriceScheduleGetToOneRelatedFieldsApp.BundleId,
                "ciProduct" => AppsAppPriceScheduleGetToOneRelatedFieldsApp.CiProduct,
                "contentRightsDeclaration" => AppsAppPriceScheduleGetToOneRelatedFieldsApp.ContentRightsDeclaration,
                "customerReviewSummarizations" => AppsAppPriceScheduleGetToOneRelatedFieldsApp.CustomerReviewSummarizations,
                "customerReviews" => AppsAppPriceScheduleGetToOneRelatedFieldsApp.CustomerReviews,
                "endUserLicenseAgreement" => AppsAppPriceScheduleGetToOneRelatedFieldsApp.EndUserLicenseAgreement,
                "gameCenterDetail" => AppsAppPriceScheduleGetToOneRelatedFieldsApp.GameCenterDetail,
                "gameCenterEnabledVersions" => AppsAppPriceScheduleGetToOneRelatedFieldsApp.GameCenterEnabledVersions,
                "inAppPurchases" => AppsAppPriceScheduleGetToOneRelatedFieldsApp.InAppPurchases,
                "inAppPurchasesV2" => AppsAppPriceScheduleGetToOneRelatedFieldsApp.InAppPurchasesV2,
                "isOrEverWasMadeForKids" => AppsAppPriceScheduleGetToOneRelatedFieldsApp.IsOrEverWasMadeForKids,
                "marketplaceSearchDetail" => AppsAppPriceScheduleGetToOneRelatedFieldsApp.MarketplaceSearchDetail,
                "name" => AppsAppPriceScheduleGetToOneRelatedFieldsApp.Name,
                "perfPowerMetrics" => AppsAppPriceScheduleGetToOneRelatedFieldsApp.PerfPowerMetrics,
                "preReleaseVersions" => AppsAppPriceScheduleGetToOneRelatedFieldsApp.PreReleaseVersions,
                "primaryLocale" => AppsAppPriceScheduleGetToOneRelatedFieldsApp.PrimaryLocale,
                "promotedPurchases" => AppsAppPriceScheduleGetToOneRelatedFieldsApp.PromotedPurchases,
                "reviewSubmissions" => AppsAppPriceScheduleGetToOneRelatedFieldsApp.ReviewSubmissions,
                "searchKeywords" => AppsAppPriceScheduleGetToOneRelatedFieldsApp.SearchKeywords,
                "sku" => AppsAppPriceScheduleGetToOneRelatedFieldsApp.Sku,
                "streamlinedPurchasingEnabled" => AppsAppPriceScheduleGetToOneRelatedFieldsApp.StreamlinedPurchasingEnabled,
                "subscriptionGracePeriod" => AppsAppPriceScheduleGetToOneRelatedFieldsApp.SubscriptionGracePeriod,
                "subscriptionGroups" => AppsAppPriceScheduleGetToOneRelatedFieldsApp.SubscriptionGroups,
                "subscriptionStatusUrl" => AppsAppPriceScheduleGetToOneRelatedFieldsApp.SubscriptionStatusUrl,
                "subscriptionStatusUrlForSandbox" => AppsAppPriceScheduleGetToOneRelatedFieldsApp.SubscriptionStatusUrlForSandbox,
                "subscriptionStatusUrlVersion" => AppsAppPriceScheduleGetToOneRelatedFieldsApp.SubscriptionStatusUrlVersion,
                "subscriptionStatusUrlVersionForSandbox" => AppsAppPriceScheduleGetToOneRelatedFieldsApp.SubscriptionStatusUrlVersionForSandbox,
                "webhooks" => AppsAppPriceScheduleGetToOneRelatedFieldsApp.Webhooks,
                _ => null,
            };
        }
    }
}