
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum EndUserLicenseAgreementsGetInstanceFieldsApp
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
    public static class EndUserLicenseAgreementsGetInstanceFieldsAppExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EndUserLicenseAgreementsGetInstanceFieldsApp value)
        {
            return value switch
            {
                EndUserLicenseAgreementsGetInstanceFieldsApp.AccessibilityDeclarations => "accessibilityDeclarations",
                EndUserLicenseAgreementsGetInstanceFieldsApp.AccessibilityUrl => "accessibilityUrl",
                EndUserLicenseAgreementsGetInstanceFieldsApp.AlternativeDistributionKey => "alternativeDistributionKey",
                EndUserLicenseAgreementsGetInstanceFieldsApp.AnalyticsReportRequests => "analyticsReportRequests",
                EndUserLicenseAgreementsGetInstanceFieldsApp.AndroidToIosAppMappingDetails => "androidToIosAppMappingDetails",
                EndUserLicenseAgreementsGetInstanceFieldsApp.AppAvailabilityV2 => "appAvailabilityV2",
                EndUserLicenseAgreementsGetInstanceFieldsApp.AppClips => "appClips",
                EndUserLicenseAgreementsGetInstanceFieldsApp.AppCustomProductPages => "appCustomProductPages",
                EndUserLicenseAgreementsGetInstanceFieldsApp.AppEncryptionDeclarations => "appEncryptionDeclarations",
                EndUserLicenseAgreementsGetInstanceFieldsApp.AppEvents => "appEvents",
                EndUserLicenseAgreementsGetInstanceFieldsApp.AppInfos => "appInfos",
                EndUserLicenseAgreementsGetInstanceFieldsApp.AppPricePoints => "appPricePoints",
                EndUserLicenseAgreementsGetInstanceFieldsApp.AppPriceSchedule => "appPriceSchedule",
                EndUserLicenseAgreementsGetInstanceFieldsApp.AppStoreIcon => "appStoreIcon",
                EndUserLicenseAgreementsGetInstanceFieldsApp.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                EndUserLicenseAgreementsGetInstanceFieldsApp.AppStoreVersions => "appStoreVersions",
                EndUserLicenseAgreementsGetInstanceFieldsApp.AppTags => "appTags",
                EndUserLicenseAgreementsGetInstanceFieldsApp.BackgroundAssets => "backgroundAssets",
                EndUserLicenseAgreementsGetInstanceFieldsApp.BetaAppLocalizations => "betaAppLocalizations",
                EndUserLicenseAgreementsGetInstanceFieldsApp.BetaAppReviewDetail => "betaAppReviewDetail",
                EndUserLicenseAgreementsGetInstanceFieldsApp.BetaFeedbackCrashSubmissions => "betaFeedbackCrashSubmissions",
                EndUserLicenseAgreementsGetInstanceFieldsApp.BetaFeedbackScreenshotSubmissions => "betaFeedbackScreenshotSubmissions",
                EndUserLicenseAgreementsGetInstanceFieldsApp.BetaGroups => "betaGroups",
                EndUserLicenseAgreementsGetInstanceFieldsApp.BetaLicenseAgreement => "betaLicenseAgreement",
                EndUserLicenseAgreementsGetInstanceFieldsApp.BetaTesters => "betaTesters",
                EndUserLicenseAgreementsGetInstanceFieldsApp.BuildUploads => "buildUploads",
                EndUserLicenseAgreementsGetInstanceFieldsApp.Builds => "builds",
                EndUserLicenseAgreementsGetInstanceFieldsApp.BundleId => "bundleId",
                EndUserLicenseAgreementsGetInstanceFieldsApp.CiProduct => "ciProduct",
                EndUserLicenseAgreementsGetInstanceFieldsApp.ContentRightsDeclaration => "contentRightsDeclaration",
                EndUserLicenseAgreementsGetInstanceFieldsApp.CustomerReviewSummarizations => "customerReviewSummarizations",
                EndUserLicenseAgreementsGetInstanceFieldsApp.CustomerReviews => "customerReviews",
                EndUserLicenseAgreementsGetInstanceFieldsApp.EndUserLicenseAgreement => "endUserLicenseAgreement",
                EndUserLicenseAgreementsGetInstanceFieldsApp.GameCenterDetail => "gameCenterDetail",
                EndUserLicenseAgreementsGetInstanceFieldsApp.GameCenterEnabledVersions => "gameCenterEnabledVersions",
                EndUserLicenseAgreementsGetInstanceFieldsApp.InAppPurchases => "inAppPurchases",
                EndUserLicenseAgreementsGetInstanceFieldsApp.InAppPurchasesV2 => "inAppPurchasesV2",
                EndUserLicenseAgreementsGetInstanceFieldsApp.IsOrEverWasMadeForKids => "isOrEverWasMadeForKids",
                EndUserLicenseAgreementsGetInstanceFieldsApp.MarketplaceSearchDetail => "marketplaceSearchDetail",
                EndUserLicenseAgreementsGetInstanceFieldsApp.Name => "name",
                EndUserLicenseAgreementsGetInstanceFieldsApp.PerfPowerMetrics => "perfPowerMetrics",
                EndUserLicenseAgreementsGetInstanceFieldsApp.PreReleaseVersions => "preReleaseVersions",
                EndUserLicenseAgreementsGetInstanceFieldsApp.PrimaryLocale => "primaryLocale",
                EndUserLicenseAgreementsGetInstanceFieldsApp.PromotedPurchases => "promotedPurchases",
                EndUserLicenseAgreementsGetInstanceFieldsApp.ReviewSubmissions => "reviewSubmissions",
                EndUserLicenseAgreementsGetInstanceFieldsApp.SearchKeywords => "searchKeywords",
                EndUserLicenseAgreementsGetInstanceFieldsApp.Sku => "sku",
                EndUserLicenseAgreementsGetInstanceFieldsApp.StreamlinedPurchasingEnabled => "streamlinedPurchasingEnabled",
                EndUserLicenseAgreementsGetInstanceFieldsApp.SubscriptionGracePeriod => "subscriptionGracePeriod",
                EndUserLicenseAgreementsGetInstanceFieldsApp.SubscriptionGroups => "subscriptionGroups",
                EndUserLicenseAgreementsGetInstanceFieldsApp.SubscriptionStatusUrl => "subscriptionStatusUrl",
                EndUserLicenseAgreementsGetInstanceFieldsApp.SubscriptionStatusUrlForSandbox => "subscriptionStatusUrlForSandbox",
                EndUserLicenseAgreementsGetInstanceFieldsApp.SubscriptionStatusUrlVersion => "subscriptionStatusUrlVersion",
                EndUserLicenseAgreementsGetInstanceFieldsApp.SubscriptionStatusUrlVersionForSandbox => "subscriptionStatusUrlVersionForSandbox",
                EndUserLicenseAgreementsGetInstanceFieldsApp.Webhooks => "webhooks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EndUserLicenseAgreementsGetInstanceFieldsApp? ToEnum(string value)
        {
            return value switch
            {
                "accessibilityDeclarations" => EndUserLicenseAgreementsGetInstanceFieldsApp.AccessibilityDeclarations,
                "accessibilityUrl" => EndUserLicenseAgreementsGetInstanceFieldsApp.AccessibilityUrl,
                "alternativeDistributionKey" => EndUserLicenseAgreementsGetInstanceFieldsApp.AlternativeDistributionKey,
                "analyticsReportRequests" => EndUserLicenseAgreementsGetInstanceFieldsApp.AnalyticsReportRequests,
                "androidToIosAppMappingDetails" => EndUserLicenseAgreementsGetInstanceFieldsApp.AndroidToIosAppMappingDetails,
                "appAvailabilityV2" => EndUserLicenseAgreementsGetInstanceFieldsApp.AppAvailabilityV2,
                "appClips" => EndUserLicenseAgreementsGetInstanceFieldsApp.AppClips,
                "appCustomProductPages" => EndUserLicenseAgreementsGetInstanceFieldsApp.AppCustomProductPages,
                "appEncryptionDeclarations" => EndUserLicenseAgreementsGetInstanceFieldsApp.AppEncryptionDeclarations,
                "appEvents" => EndUserLicenseAgreementsGetInstanceFieldsApp.AppEvents,
                "appInfos" => EndUserLicenseAgreementsGetInstanceFieldsApp.AppInfos,
                "appPricePoints" => EndUserLicenseAgreementsGetInstanceFieldsApp.AppPricePoints,
                "appPriceSchedule" => EndUserLicenseAgreementsGetInstanceFieldsApp.AppPriceSchedule,
                "appStoreIcon" => EndUserLicenseAgreementsGetInstanceFieldsApp.AppStoreIcon,
                "appStoreVersionExperimentsV2" => EndUserLicenseAgreementsGetInstanceFieldsApp.AppStoreVersionExperimentsV2,
                "appStoreVersions" => EndUserLicenseAgreementsGetInstanceFieldsApp.AppStoreVersions,
                "appTags" => EndUserLicenseAgreementsGetInstanceFieldsApp.AppTags,
                "backgroundAssets" => EndUserLicenseAgreementsGetInstanceFieldsApp.BackgroundAssets,
                "betaAppLocalizations" => EndUserLicenseAgreementsGetInstanceFieldsApp.BetaAppLocalizations,
                "betaAppReviewDetail" => EndUserLicenseAgreementsGetInstanceFieldsApp.BetaAppReviewDetail,
                "betaFeedbackCrashSubmissions" => EndUserLicenseAgreementsGetInstanceFieldsApp.BetaFeedbackCrashSubmissions,
                "betaFeedbackScreenshotSubmissions" => EndUserLicenseAgreementsGetInstanceFieldsApp.BetaFeedbackScreenshotSubmissions,
                "betaGroups" => EndUserLicenseAgreementsGetInstanceFieldsApp.BetaGroups,
                "betaLicenseAgreement" => EndUserLicenseAgreementsGetInstanceFieldsApp.BetaLicenseAgreement,
                "betaTesters" => EndUserLicenseAgreementsGetInstanceFieldsApp.BetaTesters,
                "buildUploads" => EndUserLicenseAgreementsGetInstanceFieldsApp.BuildUploads,
                "builds" => EndUserLicenseAgreementsGetInstanceFieldsApp.Builds,
                "bundleId" => EndUserLicenseAgreementsGetInstanceFieldsApp.BundleId,
                "ciProduct" => EndUserLicenseAgreementsGetInstanceFieldsApp.CiProduct,
                "contentRightsDeclaration" => EndUserLicenseAgreementsGetInstanceFieldsApp.ContentRightsDeclaration,
                "customerReviewSummarizations" => EndUserLicenseAgreementsGetInstanceFieldsApp.CustomerReviewSummarizations,
                "customerReviews" => EndUserLicenseAgreementsGetInstanceFieldsApp.CustomerReviews,
                "endUserLicenseAgreement" => EndUserLicenseAgreementsGetInstanceFieldsApp.EndUserLicenseAgreement,
                "gameCenterDetail" => EndUserLicenseAgreementsGetInstanceFieldsApp.GameCenterDetail,
                "gameCenterEnabledVersions" => EndUserLicenseAgreementsGetInstanceFieldsApp.GameCenterEnabledVersions,
                "inAppPurchases" => EndUserLicenseAgreementsGetInstanceFieldsApp.InAppPurchases,
                "inAppPurchasesV2" => EndUserLicenseAgreementsGetInstanceFieldsApp.InAppPurchasesV2,
                "isOrEverWasMadeForKids" => EndUserLicenseAgreementsGetInstanceFieldsApp.IsOrEverWasMadeForKids,
                "marketplaceSearchDetail" => EndUserLicenseAgreementsGetInstanceFieldsApp.MarketplaceSearchDetail,
                "name" => EndUserLicenseAgreementsGetInstanceFieldsApp.Name,
                "perfPowerMetrics" => EndUserLicenseAgreementsGetInstanceFieldsApp.PerfPowerMetrics,
                "preReleaseVersions" => EndUserLicenseAgreementsGetInstanceFieldsApp.PreReleaseVersions,
                "primaryLocale" => EndUserLicenseAgreementsGetInstanceFieldsApp.PrimaryLocale,
                "promotedPurchases" => EndUserLicenseAgreementsGetInstanceFieldsApp.PromotedPurchases,
                "reviewSubmissions" => EndUserLicenseAgreementsGetInstanceFieldsApp.ReviewSubmissions,
                "searchKeywords" => EndUserLicenseAgreementsGetInstanceFieldsApp.SearchKeywords,
                "sku" => EndUserLicenseAgreementsGetInstanceFieldsApp.Sku,
                "streamlinedPurchasingEnabled" => EndUserLicenseAgreementsGetInstanceFieldsApp.StreamlinedPurchasingEnabled,
                "subscriptionGracePeriod" => EndUserLicenseAgreementsGetInstanceFieldsApp.SubscriptionGracePeriod,
                "subscriptionGroups" => EndUserLicenseAgreementsGetInstanceFieldsApp.SubscriptionGroups,
                "subscriptionStatusUrl" => EndUserLicenseAgreementsGetInstanceFieldsApp.SubscriptionStatusUrl,
                "subscriptionStatusUrlForSandbox" => EndUserLicenseAgreementsGetInstanceFieldsApp.SubscriptionStatusUrlForSandbox,
                "subscriptionStatusUrlVersion" => EndUserLicenseAgreementsGetInstanceFieldsApp.SubscriptionStatusUrlVersion,
                "subscriptionStatusUrlVersionForSandbox" => EndUserLicenseAgreementsGetInstanceFieldsApp.SubscriptionStatusUrlVersionForSandbox,
                "webhooks" => EndUserLicenseAgreementsGetInstanceFieldsApp.Webhooks,
                _ => null,
            };
        }
    }
}