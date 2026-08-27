
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum UsersGetInstanceFieldsApp
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
    public static class UsersGetInstanceFieldsAppExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsersGetInstanceFieldsApp value)
        {
            return value switch
            {
                UsersGetInstanceFieldsApp.AccessibilityDeclarations => "accessibilityDeclarations",
                UsersGetInstanceFieldsApp.AccessibilityUrl => "accessibilityUrl",
                UsersGetInstanceFieldsApp.AlternativeDistributionKey => "alternativeDistributionKey",
                UsersGetInstanceFieldsApp.AnalyticsReportRequests => "analyticsReportRequests",
                UsersGetInstanceFieldsApp.AndroidToIosAppMappingDetails => "androidToIosAppMappingDetails",
                UsersGetInstanceFieldsApp.AppAvailabilityV2 => "appAvailabilityV2",
                UsersGetInstanceFieldsApp.AppClips => "appClips",
                UsersGetInstanceFieldsApp.AppCustomProductPages => "appCustomProductPages",
                UsersGetInstanceFieldsApp.AppEncryptionDeclarations => "appEncryptionDeclarations",
                UsersGetInstanceFieldsApp.AppEvents => "appEvents",
                UsersGetInstanceFieldsApp.AppInfos => "appInfos",
                UsersGetInstanceFieldsApp.AppPricePoints => "appPricePoints",
                UsersGetInstanceFieldsApp.AppPriceSchedule => "appPriceSchedule",
                UsersGetInstanceFieldsApp.AppStoreIcon => "appStoreIcon",
                UsersGetInstanceFieldsApp.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                UsersGetInstanceFieldsApp.AppStoreVersions => "appStoreVersions",
                UsersGetInstanceFieldsApp.AppTags => "appTags",
                UsersGetInstanceFieldsApp.BackgroundAssets => "backgroundAssets",
                UsersGetInstanceFieldsApp.BetaAppLocalizations => "betaAppLocalizations",
                UsersGetInstanceFieldsApp.BetaAppReviewDetail => "betaAppReviewDetail",
                UsersGetInstanceFieldsApp.BetaFeedbackCrashSubmissions => "betaFeedbackCrashSubmissions",
                UsersGetInstanceFieldsApp.BetaFeedbackScreenshotSubmissions => "betaFeedbackScreenshotSubmissions",
                UsersGetInstanceFieldsApp.BetaGroups => "betaGroups",
                UsersGetInstanceFieldsApp.BetaLicenseAgreement => "betaLicenseAgreement",
                UsersGetInstanceFieldsApp.BetaTesters => "betaTesters",
                UsersGetInstanceFieldsApp.BuildUploads => "buildUploads",
                UsersGetInstanceFieldsApp.Builds => "builds",
                UsersGetInstanceFieldsApp.BundleId => "bundleId",
                UsersGetInstanceFieldsApp.CiProduct => "ciProduct",
                UsersGetInstanceFieldsApp.ContentRightsDeclaration => "contentRightsDeclaration",
                UsersGetInstanceFieldsApp.CustomerReviewSummarizations => "customerReviewSummarizations",
                UsersGetInstanceFieldsApp.CustomerReviews => "customerReviews",
                UsersGetInstanceFieldsApp.EndUserLicenseAgreement => "endUserLicenseAgreement",
                UsersGetInstanceFieldsApp.GameCenterDetail => "gameCenterDetail",
                UsersGetInstanceFieldsApp.GameCenterEnabledVersions => "gameCenterEnabledVersions",
                UsersGetInstanceFieldsApp.InAppPurchases => "inAppPurchases",
                UsersGetInstanceFieldsApp.InAppPurchasesV2 => "inAppPurchasesV2",
                UsersGetInstanceFieldsApp.IsOrEverWasMadeForKids => "isOrEverWasMadeForKids",
                UsersGetInstanceFieldsApp.MarketplaceSearchDetail => "marketplaceSearchDetail",
                UsersGetInstanceFieldsApp.Name => "name",
                UsersGetInstanceFieldsApp.PerfPowerMetrics => "perfPowerMetrics",
                UsersGetInstanceFieldsApp.PreReleaseVersions => "preReleaseVersions",
                UsersGetInstanceFieldsApp.PrimaryLocale => "primaryLocale",
                UsersGetInstanceFieldsApp.PromotedPurchases => "promotedPurchases",
                UsersGetInstanceFieldsApp.ReviewSubmissions => "reviewSubmissions",
                UsersGetInstanceFieldsApp.SearchKeywords => "searchKeywords",
                UsersGetInstanceFieldsApp.Sku => "sku",
                UsersGetInstanceFieldsApp.StreamlinedPurchasingEnabled => "streamlinedPurchasingEnabled",
                UsersGetInstanceFieldsApp.SubscriptionGracePeriod => "subscriptionGracePeriod",
                UsersGetInstanceFieldsApp.SubscriptionGroups => "subscriptionGroups",
                UsersGetInstanceFieldsApp.SubscriptionStatusUrl => "subscriptionStatusUrl",
                UsersGetInstanceFieldsApp.SubscriptionStatusUrlForSandbox => "subscriptionStatusUrlForSandbox",
                UsersGetInstanceFieldsApp.SubscriptionStatusUrlVersion => "subscriptionStatusUrlVersion",
                UsersGetInstanceFieldsApp.SubscriptionStatusUrlVersionForSandbox => "subscriptionStatusUrlVersionForSandbox",
                UsersGetInstanceFieldsApp.Webhooks => "webhooks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsersGetInstanceFieldsApp? ToEnum(string value)
        {
            return value switch
            {
                "accessibilityDeclarations" => UsersGetInstanceFieldsApp.AccessibilityDeclarations,
                "accessibilityUrl" => UsersGetInstanceFieldsApp.AccessibilityUrl,
                "alternativeDistributionKey" => UsersGetInstanceFieldsApp.AlternativeDistributionKey,
                "analyticsReportRequests" => UsersGetInstanceFieldsApp.AnalyticsReportRequests,
                "androidToIosAppMappingDetails" => UsersGetInstanceFieldsApp.AndroidToIosAppMappingDetails,
                "appAvailabilityV2" => UsersGetInstanceFieldsApp.AppAvailabilityV2,
                "appClips" => UsersGetInstanceFieldsApp.AppClips,
                "appCustomProductPages" => UsersGetInstanceFieldsApp.AppCustomProductPages,
                "appEncryptionDeclarations" => UsersGetInstanceFieldsApp.AppEncryptionDeclarations,
                "appEvents" => UsersGetInstanceFieldsApp.AppEvents,
                "appInfos" => UsersGetInstanceFieldsApp.AppInfos,
                "appPricePoints" => UsersGetInstanceFieldsApp.AppPricePoints,
                "appPriceSchedule" => UsersGetInstanceFieldsApp.AppPriceSchedule,
                "appStoreIcon" => UsersGetInstanceFieldsApp.AppStoreIcon,
                "appStoreVersionExperimentsV2" => UsersGetInstanceFieldsApp.AppStoreVersionExperimentsV2,
                "appStoreVersions" => UsersGetInstanceFieldsApp.AppStoreVersions,
                "appTags" => UsersGetInstanceFieldsApp.AppTags,
                "backgroundAssets" => UsersGetInstanceFieldsApp.BackgroundAssets,
                "betaAppLocalizations" => UsersGetInstanceFieldsApp.BetaAppLocalizations,
                "betaAppReviewDetail" => UsersGetInstanceFieldsApp.BetaAppReviewDetail,
                "betaFeedbackCrashSubmissions" => UsersGetInstanceFieldsApp.BetaFeedbackCrashSubmissions,
                "betaFeedbackScreenshotSubmissions" => UsersGetInstanceFieldsApp.BetaFeedbackScreenshotSubmissions,
                "betaGroups" => UsersGetInstanceFieldsApp.BetaGroups,
                "betaLicenseAgreement" => UsersGetInstanceFieldsApp.BetaLicenseAgreement,
                "betaTesters" => UsersGetInstanceFieldsApp.BetaTesters,
                "buildUploads" => UsersGetInstanceFieldsApp.BuildUploads,
                "builds" => UsersGetInstanceFieldsApp.Builds,
                "bundleId" => UsersGetInstanceFieldsApp.BundleId,
                "ciProduct" => UsersGetInstanceFieldsApp.CiProduct,
                "contentRightsDeclaration" => UsersGetInstanceFieldsApp.ContentRightsDeclaration,
                "customerReviewSummarizations" => UsersGetInstanceFieldsApp.CustomerReviewSummarizations,
                "customerReviews" => UsersGetInstanceFieldsApp.CustomerReviews,
                "endUserLicenseAgreement" => UsersGetInstanceFieldsApp.EndUserLicenseAgreement,
                "gameCenterDetail" => UsersGetInstanceFieldsApp.GameCenterDetail,
                "gameCenterEnabledVersions" => UsersGetInstanceFieldsApp.GameCenterEnabledVersions,
                "inAppPurchases" => UsersGetInstanceFieldsApp.InAppPurchases,
                "inAppPurchasesV2" => UsersGetInstanceFieldsApp.InAppPurchasesV2,
                "isOrEverWasMadeForKids" => UsersGetInstanceFieldsApp.IsOrEverWasMadeForKids,
                "marketplaceSearchDetail" => UsersGetInstanceFieldsApp.MarketplaceSearchDetail,
                "name" => UsersGetInstanceFieldsApp.Name,
                "perfPowerMetrics" => UsersGetInstanceFieldsApp.PerfPowerMetrics,
                "preReleaseVersions" => UsersGetInstanceFieldsApp.PreReleaseVersions,
                "primaryLocale" => UsersGetInstanceFieldsApp.PrimaryLocale,
                "promotedPurchases" => UsersGetInstanceFieldsApp.PromotedPurchases,
                "reviewSubmissions" => UsersGetInstanceFieldsApp.ReviewSubmissions,
                "searchKeywords" => UsersGetInstanceFieldsApp.SearchKeywords,
                "sku" => UsersGetInstanceFieldsApp.Sku,
                "streamlinedPurchasingEnabled" => UsersGetInstanceFieldsApp.StreamlinedPurchasingEnabled,
                "subscriptionGracePeriod" => UsersGetInstanceFieldsApp.SubscriptionGracePeriod,
                "subscriptionGroups" => UsersGetInstanceFieldsApp.SubscriptionGroups,
                "subscriptionStatusUrl" => UsersGetInstanceFieldsApp.SubscriptionStatusUrl,
                "subscriptionStatusUrlForSandbox" => UsersGetInstanceFieldsApp.SubscriptionStatusUrlForSandbox,
                "subscriptionStatusUrlVersion" => UsersGetInstanceFieldsApp.SubscriptionStatusUrlVersion,
                "subscriptionStatusUrlVersionForSandbox" => UsersGetInstanceFieldsApp.SubscriptionStatusUrlVersionForSandbox,
                "webhooks" => UsersGetInstanceFieldsApp.Webhooks,
                _ => null,
            };
        }
    }
}