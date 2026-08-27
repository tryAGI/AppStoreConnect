
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ReviewSubmissionsGetCollectionFieldsApp
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
    public static class ReviewSubmissionsGetCollectionFieldsAppExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionsGetCollectionFieldsApp value)
        {
            return value switch
            {
                ReviewSubmissionsGetCollectionFieldsApp.AccessibilityDeclarations => "accessibilityDeclarations",
                ReviewSubmissionsGetCollectionFieldsApp.AccessibilityUrl => "accessibilityUrl",
                ReviewSubmissionsGetCollectionFieldsApp.AlternativeDistributionKey => "alternativeDistributionKey",
                ReviewSubmissionsGetCollectionFieldsApp.AnalyticsReportRequests => "analyticsReportRequests",
                ReviewSubmissionsGetCollectionFieldsApp.AndroidToIosAppMappingDetails => "androidToIosAppMappingDetails",
                ReviewSubmissionsGetCollectionFieldsApp.AppAvailabilityV2 => "appAvailabilityV2",
                ReviewSubmissionsGetCollectionFieldsApp.AppClips => "appClips",
                ReviewSubmissionsGetCollectionFieldsApp.AppCustomProductPages => "appCustomProductPages",
                ReviewSubmissionsGetCollectionFieldsApp.AppEncryptionDeclarations => "appEncryptionDeclarations",
                ReviewSubmissionsGetCollectionFieldsApp.AppEvents => "appEvents",
                ReviewSubmissionsGetCollectionFieldsApp.AppInfos => "appInfos",
                ReviewSubmissionsGetCollectionFieldsApp.AppPricePoints => "appPricePoints",
                ReviewSubmissionsGetCollectionFieldsApp.AppPriceSchedule => "appPriceSchedule",
                ReviewSubmissionsGetCollectionFieldsApp.AppStoreIcon => "appStoreIcon",
                ReviewSubmissionsGetCollectionFieldsApp.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                ReviewSubmissionsGetCollectionFieldsApp.AppStoreVersions => "appStoreVersions",
                ReviewSubmissionsGetCollectionFieldsApp.AppTags => "appTags",
                ReviewSubmissionsGetCollectionFieldsApp.BackgroundAssets => "backgroundAssets",
                ReviewSubmissionsGetCollectionFieldsApp.BetaAppLocalizations => "betaAppLocalizations",
                ReviewSubmissionsGetCollectionFieldsApp.BetaAppReviewDetail => "betaAppReviewDetail",
                ReviewSubmissionsGetCollectionFieldsApp.BetaFeedbackCrashSubmissions => "betaFeedbackCrashSubmissions",
                ReviewSubmissionsGetCollectionFieldsApp.BetaFeedbackScreenshotSubmissions => "betaFeedbackScreenshotSubmissions",
                ReviewSubmissionsGetCollectionFieldsApp.BetaGroups => "betaGroups",
                ReviewSubmissionsGetCollectionFieldsApp.BetaLicenseAgreement => "betaLicenseAgreement",
                ReviewSubmissionsGetCollectionFieldsApp.BetaTesters => "betaTesters",
                ReviewSubmissionsGetCollectionFieldsApp.BuildUploads => "buildUploads",
                ReviewSubmissionsGetCollectionFieldsApp.Builds => "builds",
                ReviewSubmissionsGetCollectionFieldsApp.BundleId => "bundleId",
                ReviewSubmissionsGetCollectionFieldsApp.CiProduct => "ciProduct",
                ReviewSubmissionsGetCollectionFieldsApp.ContentRightsDeclaration => "contentRightsDeclaration",
                ReviewSubmissionsGetCollectionFieldsApp.CustomerReviewSummarizations => "customerReviewSummarizations",
                ReviewSubmissionsGetCollectionFieldsApp.CustomerReviews => "customerReviews",
                ReviewSubmissionsGetCollectionFieldsApp.EndUserLicenseAgreement => "endUserLicenseAgreement",
                ReviewSubmissionsGetCollectionFieldsApp.GameCenterDetail => "gameCenterDetail",
                ReviewSubmissionsGetCollectionFieldsApp.GameCenterEnabledVersions => "gameCenterEnabledVersions",
                ReviewSubmissionsGetCollectionFieldsApp.InAppPurchases => "inAppPurchases",
                ReviewSubmissionsGetCollectionFieldsApp.InAppPurchasesV2 => "inAppPurchasesV2",
                ReviewSubmissionsGetCollectionFieldsApp.IsOrEverWasMadeForKids => "isOrEverWasMadeForKids",
                ReviewSubmissionsGetCollectionFieldsApp.MarketplaceSearchDetail => "marketplaceSearchDetail",
                ReviewSubmissionsGetCollectionFieldsApp.Name => "name",
                ReviewSubmissionsGetCollectionFieldsApp.PerfPowerMetrics => "perfPowerMetrics",
                ReviewSubmissionsGetCollectionFieldsApp.PreReleaseVersions => "preReleaseVersions",
                ReviewSubmissionsGetCollectionFieldsApp.PrimaryLocale => "primaryLocale",
                ReviewSubmissionsGetCollectionFieldsApp.PromotedPurchases => "promotedPurchases",
                ReviewSubmissionsGetCollectionFieldsApp.ReviewSubmissions => "reviewSubmissions",
                ReviewSubmissionsGetCollectionFieldsApp.SearchKeywords => "searchKeywords",
                ReviewSubmissionsGetCollectionFieldsApp.Sku => "sku",
                ReviewSubmissionsGetCollectionFieldsApp.StreamlinedPurchasingEnabled => "streamlinedPurchasingEnabled",
                ReviewSubmissionsGetCollectionFieldsApp.SubscriptionGracePeriod => "subscriptionGracePeriod",
                ReviewSubmissionsGetCollectionFieldsApp.SubscriptionGroups => "subscriptionGroups",
                ReviewSubmissionsGetCollectionFieldsApp.SubscriptionStatusUrl => "subscriptionStatusUrl",
                ReviewSubmissionsGetCollectionFieldsApp.SubscriptionStatusUrlForSandbox => "subscriptionStatusUrlForSandbox",
                ReviewSubmissionsGetCollectionFieldsApp.SubscriptionStatusUrlVersion => "subscriptionStatusUrlVersion",
                ReviewSubmissionsGetCollectionFieldsApp.SubscriptionStatusUrlVersionForSandbox => "subscriptionStatusUrlVersionForSandbox",
                ReviewSubmissionsGetCollectionFieldsApp.Webhooks => "webhooks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionsGetCollectionFieldsApp? ToEnum(string value)
        {
            return value switch
            {
                "accessibilityDeclarations" => ReviewSubmissionsGetCollectionFieldsApp.AccessibilityDeclarations,
                "accessibilityUrl" => ReviewSubmissionsGetCollectionFieldsApp.AccessibilityUrl,
                "alternativeDistributionKey" => ReviewSubmissionsGetCollectionFieldsApp.AlternativeDistributionKey,
                "analyticsReportRequests" => ReviewSubmissionsGetCollectionFieldsApp.AnalyticsReportRequests,
                "androidToIosAppMappingDetails" => ReviewSubmissionsGetCollectionFieldsApp.AndroidToIosAppMappingDetails,
                "appAvailabilityV2" => ReviewSubmissionsGetCollectionFieldsApp.AppAvailabilityV2,
                "appClips" => ReviewSubmissionsGetCollectionFieldsApp.AppClips,
                "appCustomProductPages" => ReviewSubmissionsGetCollectionFieldsApp.AppCustomProductPages,
                "appEncryptionDeclarations" => ReviewSubmissionsGetCollectionFieldsApp.AppEncryptionDeclarations,
                "appEvents" => ReviewSubmissionsGetCollectionFieldsApp.AppEvents,
                "appInfos" => ReviewSubmissionsGetCollectionFieldsApp.AppInfos,
                "appPricePoints" => ReviewSubmissionsGetCollectionFieldsApp.AppPricePoints,
                "appPriceSchedule" => ReviewSubmissionsGetCollectionFieldsApp.AppPriceSchedule,
                "appStoreIcon" => ReviewSubmissionsGetCollectionFieldsApp.AppStoreIcon,
                "appStoreVersionExperimentsV2" => ReviewSubmissionsGetCollectionFieldsApp.AppStoreVersionExperimentsV2,
                "appStoreVersions" => ReviewSubmissionsGetCollectionFieldsApp.AppStoreVersions,
                "appTags" => ReviewSubmissionsGetCollectionFieldsApp.AppTags,
                "backgroundAssets" => ReviewSubmissionsGetCollectionFieldsApp.BackgroundAssets,
                "betaAppLocalizations" => ReviewSubmissionsGetCollectionFieldsApp.BetaAppLocalizations,
                "betaAppReviewDetail" => ReviewSubmissionsGetCollectionFieldsApp.BetaAppReviewDetail,
                "betaFeedbackCrashSubmissions" => ReviewSubmissionsGetCollectionFieldsApp.BetaFeedbackCrashSubmissions,
                "betaFeedbackScreenshotSubmissions" => ReviewSubmissionsGetCollectionFieldsApp.BetaFeedbackScreenshotSubmissions,
                "betaGroups" => ReviewSubmissionsGetCollectionFieldsApp.BetaGroups,
                "betaLicenseAgreement" => ReviewSubmissionsGetCollectionFieldsApp.BetaLicenseAgreement,
                "betaTesters" => ReviewSubmissionsGetCollectionFieldsApp.BetaTesters,
                "buildUploads" => ReviewSubmissionsGetCollectionFieldsApp.BuildUploads,
                "builds" => ReviewSubmissionsGetCollectionFieldsApp.Builds,
                "bundleId" => ReviewSubmissionsGetCollectionFieldsApp.BundleId,
                "ciProduct" => ReviewSubmissionsGetCollectionFieldsApp.CiProduct,
                "contentRightsDeclaration" => ReviewSubmissionsGetCollectionFieldsApp.ContentRightsDeclaration,
                "customerReviewSummarizations" => ReviewSubmissionsGetCollectionFieldsApp.CustomerReviewSummarizations,
                "customerReviews" => ReviewSubmissionsGetCollectionFieldsApp.CustomerReviews,
                "endUserLicenseAgreement" => ReviewSubmissionsGetCollectionFieldsApp.EndUserLicenseAgreement,
                "gameCenterDetail" => ReviewSubmissionsGetCollectionFieldsApp.GameCenterDetail,
                "gameCenterEnabledVersions" => ReviewSubmissionsGetCollectionFieldsApp.GameCenterEnabledVersions,
                "inAppPurchases" => ReviewSubmissionsGetCollectionFieldsApp.InAppPurchases,
                "inAppPurchasesV2" => ReviewSubmissionsGetCollectionFieldsApp.InAppPurchasesV2,
                "isOrEverWasMadeForKids" => ReviewSubmissionsGetCollectionFieldsApp.IsOrEverWasMadeForKids,
                "marketplaceSearchDetail" => ReviewSubmissionsGetCollectionFieldsApp.MarketplaceSearchDetail,
                "name" => ReviewSubmissionsGetCollectionFieldsApp.Name,
                "perfPowerMetrics" => ReviewSubmissionsGetCollectionFieldsApp.PerfPowerMetrics,
                "preReleaseVersions" => ReviewSubmissionsGetCollectionFieldsApp.PreReleaseVersions,
                "primaryLocale" => ReviewSubmissionsGetCollectionFieldsApp.PrimaryLocale,
                "promotedPurchases" => ReviewSubmissionsGetCollectionFieldsApp.PromotedPurchases,
                "reviewSubmissions" => ReviewSubmissionsGetCollectionFieldsApp.ReviewSubmissions,
                "searchKeywords" => ReviewSubmissionsGetCollectionFieldsApp.SearchKeywords,
                "sku" => ReviewSubmissionsGetCollectionFieldsApp.Sku,
                "streamlinedPurchasingEnabled" => ReviewSubmissionsGetCollectionFieldsApp.StreamlinedPurchasingEnabled,
                "subscriptionGracePeriod" => ReviewSubmissionsGetCollectionFieldsApp.SubscriptionGracePeriod,
                "subscriptionGroups" => ReviewSubmissionsGetCollectionFieldsApp.SubscriptionGroups,
                "subscriptionStatusUrl" => ReviewSubmissionsGetCollectionFieldsApp.SubscriptionStatusUrl,
                "subscriptionStatusUrlForSandbox" => ReviewSubmissionsGetCollectionFieldsApp.SubscriptionStatusUrlForSandbox,
                "subscriptionStatusUrlVersion" => ReviewSubmissionsGetCollectionFieldsApp.SubscriptionStatusUrlVersion,
                "subscriptionStatusUrlVersionForSandbox" => ReviewSubmissionsGetCollectionFieldsApp.SubscriptionStatusUrlVersionForSandbox,
                "webhooks" => ReviewSubmissionsGetCollectionFieldsApp.Webhooks,
                _ => null,
            };
        }
    }
}