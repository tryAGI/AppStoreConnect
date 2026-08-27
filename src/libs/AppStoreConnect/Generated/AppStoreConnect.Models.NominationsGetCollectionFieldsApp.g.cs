
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum NominationsGetCollectionFieldsApp
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
    public static class NominationsGetCollectionFieldsAppExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NominationsGetCollectionFieldsApp value)
        {
            return value switch
            {
                NominationsGetCollectionFieldsApp.AccessibilityDeclarations => "accessibilityDeclarations",
                NominationsGetCollectionFieldsApp.AccessibilityUrl => "accessibilityUrl",
                NominationsGetCollectionFieldsApp.AlternativeDistributionKey => "alternativeDistributionKey",
                NominationsGetCollectionFieldsApp.AnalyticsReportRequests => "analyticsReportRequests",
                NominationsGetCollectionFieldsApp.AndroidToIosAppMappingDetails => "androidToIosAppMappingDetails",
                NominationsGetCollectionFieldsApp.AppAvailabilityV2 => "appAvailabilityV2",
                NominationsGetCollectionFieldsApp.AppClips => "appClips",
                NominationsGetCollectionFieldsApp.AppCustomProductPages => "appCustomProductPages",
                NominationsGetCollectionFieldsApp.AppEncryptionDeclarations => "appEncryptionDeclarations",
                NominationsGetCollectionFieldsApp.AppEvents => "appEvents",
                NominationsGetCollectionFieldsApp.AppInfos => "appInfos",
                NominationsGetCollectionFieldsApp.AppPricePoints => "appPricePoints",
                NominationsGetCollectionFieldsApp.AppPriceSchedule => "appPriceSchedule",
                NominationsGetCollectionFieldsApp.AppStoreIcon => "appStoreIcon",
                NominationsGetCollectionFieldsApp.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                NominationsGetCollectionFieldsApp.AppStoreVersions => "appStoreVersions",
                NominationsGetCollectionFieldsApp.AppTags => "appTags",
                NominationsGetCollectionFieldsApp.BackgroundAssets => "backgroundAssets",
                NominationsGetCollectionFieldsApp.BetaAppLocalizations => "betaAppLocalizations",
                NominationsGetCollectionFieldsApp.BetaAppReviewDetail => "betaAppReviewDetail",
                NominationsGetCollectionFieldsApp.BetaFeedbackCrashSubmissions => "betaFeedbackCrashSubmissions",
                NominationsGetCollectionFieldsApp.BetaFeedbackScreenshotSubmissions => "betaFeedbackScreenshotSubmissions",
                NominationsGetCollectionFieldsApp.BetaGroups => "betaGroups",
                NominationsGetCollectionFieldsApp.BetaLicenseAgreement => "betaLicenseAgreement",
                NominationsGetCollectionFieldsApp.BetaTesters => "betaTesters",
                NominationsGetCollectionFieldsApp.BuildUploads => "buildUploads",
                NominationsGetCollectionFieldsApp.Builds => "builds",
                NominationsGetCollectionFieldsApp.BundleId => "bundleId",
                NominationsGetCollectionFieldsApp.CiProduct => "ciProduct",
                NominationsGetCollectionFieldsApp.ContentRightsDeclaration => "contentRightsDeclaration",
                NominationsGetCollectionFieldsApp.CustomerReviewSummarizations => "customerReviewSummarizations",
                NominationsGetCollectionFieldsApp.CustomerReviews => "customerReviews",
                NominationsGetCollectionFieldsApp.EndUserLicenseAgreement => "endUserLicenseAgreement",
                NominationsGetCollectionFieldsApp.GameCenterDetail => "gameCenterDetail",
                NominationsGetCollectionFieldsApp.GameCenterEnabledVersions => "gameCenterEnabledVersions",
                NominationsGetCollectionFieldsApp.InAppPurchases => "inAppPurchases",
                NominationsGetCollectionFieldsApp.InAppPurchasesV2 => "inAppPurchasesV2",
                NominationsGetCollectionFieldsApp.IsOrEverWasMadeForKids => "isOrEverWasMadeForKids",
                NominationsGetCollectionFieldsApp.MarketplaceSearchDetail => "marketplaceSearchDetail",
                NominationsGetCollectionFieldsApp.Name => "name",
                NominationsGetCollectionFieldsApp.PerfPowerMetrics => "perfPowerMetrics",
                NominationsGetCollectionFieldsApp.PreReleaseVersions => "preReleaseVersions",
                NominationsGetCollectionFieldsApp.PrimaryLocale => "primaryLocale",
                NominationsGetCollectionFieldsApp.PromotedPurchases => "promotedPurchases",
                NominationsGetCollectionFieldsApp.ReviewSubmissions => "reviewSubmissions",
                NominationsGetCollectionFieldsApp.SearchKeywords => "searchKeywords",
                NominationsGetCollectionFieldsApp.Sku => "sku",
                NominationsGetCollectionFieldsApp.StreamlinedPurchasingEnabled => "streamlinedPurchasingEnabled",
                NominationsGetCollectionFieldsApp.SubscriptionGracePeriod => "subscriptionGracePeriod",
                NominationsGetCollectionFieldsApp.SubscriptionGroups => "subscriptionGroups",
                NominationsGetCollectionFieldsApp.SubscriptionStatusUrl => "subscriptionStatusUrl",
                NominationsGetCollectionFieldsApp.SubscriptionStatusUrlForSandbox => "subscriptionStatusUrlForSandbox",
                NominationsGetCollectionFieldsApp.SubscriptionStatusUrlVersion => "subscriptionStatusUrlVersion",
                NominationsGetCollectionFieldsApp.SubscriptionStatusUrlVersionForSandbox => "subscriptionStatusUrlVersionForSandbox",
                NominationsGetCollectionFieldsApp.Webhooks => "webhooks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NominationsGetCollectionFieldsApp? ToEnum(string value)
        {
            return value switch
            {
                "accessibilityDeclarations" => NominationsGetCollectionFieldsApp.AccessibilityDeclarations,
                "accessibilityUrl" => NominationsGetCollectionFieldsApp.AccessibilityUrl,
                "alternativeDistributionKey" => NominationsGetCollectionFieldsApp.AlternativeDistributionKey,
                "analyticsReportRequests" => NominationsGetCollectionFieldsApp.AnalyticsReportRequests,
                "androidToIosAppMappingDetails" => NominationsGetCollectionFieldsApp.AndroidToIosAppMappingDetails,
                "appAvailabilityV2" => NominationsGetCollectionFieldsApp.AppAvailabilityV2,
                "appClips" => NominationsGetCollectionFieldsApp.AppClips,
                "appCustomProductPages" => NominationsGetCollectionFieldsApp.AppCustomProductPages,
                "appEncryptionDeclarations" => NominationsGetCollectionFieldsApp.AppEncryptionDeclarations,
                "appEvents" => NominationsGetCollectionFieldsApp.AppEvents,
                "appInfos" => NominationsGetCollectionFieldsApp.AppInfos,
                "appPricePoints" => NominationsGetCollectionFieldsApp.AppPricePoints,
                "appPriceSchedule" => NominationsGetCollectionFieldsApp.AppPriceSchedule,
                "appStoreIcon" => NominationsGetCollectionFieldsApp.AppStoreIcon,
                "appStoreVersionExperimentsV2" => NominationsGetCollectionFieldsApp.AppStoreVersionExperimentsV2,
                "appStoreVersions" => NominationsGetCollectionFieldsApp.AppStoreVersions,
                "appTags" => NominationsGetCollectionFieldsApp.AppTags,
                "backgroundAssets" => NominationsGetCollectionFieldsApp.BackgroundAssets,
                "betaAppLocalizations" => NominationsGetCollectionFieldsApp.BetaAppLocalizations,
                "betaAppReviewDetail" => NominationsGetCollectionFieldsApp.BetaAppReviewDetail,
                "betaFeedbackCrashSubmissions" => NominationsGetCollectionFieldsApp.BetaFeedbackCrashSubmissions,
                "betaFeedbackScreenshotSubmissions" => NominationsGetCollectionFieldsApp.BetaFeedbackScreenshotSubmissions,
                "betaGroups" => NominationsGetCollectionFieldsApp.BetaGroups,
                "betaLicenseAgreement" => NominationsGetCollectionFieldsApp.BetaLicenseAgreement,
                "betaTesters" => NominationsGetCollectionFieldsApp.BetaTesters,
                "buildUploads" => NominationsGetCollectionFieldsApp.BuildUploads,
                "builds" => NominationsGetCollectionFieldsApp.Builds,
                "bundleId" => NominationsGetCollectionFieldsApp.BundleId,
                "ciProduct" => NominationsGetCollectionFieldsApp.CiProduct,
                "contentRightsDeclaration" => NominationsGetCollectionFieldsApp.ContentRightsDeclaration,
                "customerReviewSummarizations" => NominationsGetCollectionFieldsApp.CustomerReviewSummarizations,
                "customerReviews" => NominationsGetCollectionFieldsApp.CustomerReviews,
                "endUserLicenseAgreement" => NominationsGetCollectionFieldsApp.EndUserLicenseAgreement,
                "gameCenterDetail" => NominationsGetCollectionFieldsApp.GameCenterDetail,
                "gameCenterEnabledVersions" => NominationsGetCollectionFieldsApp.GameCenterEnabledVersions,
                "inAppPurchases" => NominationsGetCollectionFieldsApp.InAppPurchases,
                "inAppPurchasesV2" => NominationsGetCollectionFieldsApp.InAppPurchasesV2,
                "isOrEverWasMadeForKids" => NominationsGetCollectionFieldsApp.IsOrEverWasMadeForKids,
                "marketplaceSearchDetail" => NominationsGetCollectionFieldsApp.MarketplaceSearchDetail,
                "name" => NominationsGetCollectionFieldsApp.Name,
                "perfPowerMetrics" => NominationsGetCollectionFieldsApp.PerfPowerMetrics,
                "preReleaseVersions" => NominationsGetCollectionFieldsApp.PreReleaseVersions,
                "primaryLocale" => NominationsGetCollectionFieldsApp.PrimaryLocale,
                "promotedPurchases" => NominationsGetCollectionFieldsApp.PromotedPurchases,
                "reviewSubmissions" => NominationsGetCollectionFieldsApp.ReviewSubmissions,
                "searchKeywords" => NominationsGetCollectionFieldsApp.SearchKeywords,
                "sku" => NominationsGetCollectionFieldsApp.Sku,
                "streamlinedPurchasingEnabled" => NominationsGetCollectionFieldsApp.StreamlinedPurchasingEnabled,
                "subscriptionGracePeriod" => NominationsGetCollectionFieldsApp.SubscriptionGracePeriod,
                "subscriptionGroups" => NominationsGetCollectionFieldsApp.SubscriptionGroups,
                "subscriptionStatusUrl" => NominationsGetCollectionFieldsApp.SubscriptionStatusUrl,
                "subscriptionStatusUrlForSandbox" => NominationsGetCollectionFieldsApp.SubscriptionStatusUrlForSandbox,
                "subscriptionStatusUrlVersion" => NominationsGetCollectionFieldsApp.SubscriptionStatusUrlVersion,
                "subscriptionStatusUrlVersionForSandbox" => NominationsGetCollectionFieldsApp.SubscriptionStatusUrlVersionForSandbox,
                "webhooks" => NominationsGetCollectionFieldsApp.Webhooks,
                _ => null,
            };
        }
    }
}