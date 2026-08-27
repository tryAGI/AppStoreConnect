
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaGroupsGetInstanceFieldsApp
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
    public static class BetaGroupsGetInstanceFieldsAppExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaGroupsGetInstanceFieldsApp value)
        {
            return value switch
            {
                BetaGroupsGetInstanceFieldsApp.AccessibilityDeclarations => "accessibilityDeclarations",
                BetaGroupsGetInstanceFieldsApp.AccessibilityUrl => "accessibilityUrl",
                BetaGroupsGetInstanceFieldsApp.AlternativeDistributionKey => "alternativeDistributionKey",
                BetaGroupsGetInstanceFieldsApp.AnalyticsReportRequests => "analyticsReportRequests",
                BetaGroupsGetInstanceFieldsApp.AndroidToIosAppMappingDetails => "androidToIosAppMappingDetails",
                BetaGroupsGetInstanceFieldsApp.AppAvailabilityV2 => "appAvailabilityV2",
                BetaGroupsGetInstanceFieldsApp.AppClips => "appClips",
                BetaGroupsGetInstanceFieldsApp.AppCustomProductPages => "appCustomProductPages",
                BetaGroupsGetInstanceFieldsApp.AppEncryptionDeclarations => "appEncryptionDeclarations",
                BetaGroupsGetInstanceFieldsApp.AppEvents => "appEvents",
                BetaGroupsGetInstanceFieldsApp.AppInfos => "appInfos",
                BetaGroupsGetInstanceFieldsApp.AppPricePoints => "appPricePoints",
                BetaGroupsGetInstanceFieldsApp.AppPriceSchedule => "appPriceSchedule",
                BetaGroupsGetInstanceFieldsApp.AppStoreIcon => "appStoreIcon",
                BetaGroupsGetInstanceFieldsApp.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                BetaGroupsGetInstanceFieldsApp.AppStoreVersions => "appStoreVersions",
                BetaGroupsGetInstanceFieldsApp.AppTags => "appTags",
                BetaGroupsGetInstanceFieldsApp.BackgroundAssets => "backgroundAssets",
                BetaGroupsGetInstanceFieldsApp.BetaAppLocalizations => "betaAppLocalizations",
                BetaGroupsGetInstanceFieldsApp.BetaAppReviewDetail => "betaAppReviewDetail",
                BetaGroupsGetInstanceFieldsApp.BetaFeedbackCrashSubmissions => "betaFeedbackCrashSubmissions",
                BetaGroupsGetInstanceFieldsApp.BetaFeedbackScreenshotSubmissions => "betaFeedbackScreenshotSubmissions",
                BetaGroupsGetInstanceFieldsApp.BetaGroups => "betaGroups",
                BetaGroupsGetInstanceFieldsApp.BetaLicenseAgreement => "betaLicenseAgreement",
                BetaGroupsGetInstanceFieldsApp.BetaTesters => "betaTesters",
                BetaGroupsGetInstanceFieldsApp.BuildUploads => "buildUploads",
                BetaGroupsGetInstanceFieldsApp.Builds => "builds",
                BetaGroupsGetInstanceFieldsApp.BundleId => "bundleId",
                BetaGroupsGetInstanceFieldsApp.CiProduct => "ciProduct",
                BetaGroupsGetInstanceFieldsApp.ContentRightsDeclaration => "contentRightsDeclaration",
                BetaGroupsGetInstanceFieldsApp.CustomerReviewSummarizations => "customerReviewSummarizations",
                BetaGroupsGetInstanceFieldsApp.CustomerReviews => "customerReviews",
                BetaGroupsGetInstanceFieldsApp.EndUserLicenseAgreement => "endUserLicenseAgreement",
                BetaGroupsGetInstanceFieldsApp.GameCenterDetail => "gameCenterDetail",
                BetaGroupsGetInstanceFieldsApp.GameCenterEnabledVersions => "gameCenterEnabledVersions",
                BetaGroupsGetInstanceFieldsApp.InAppPurchases => "inAppPurchases",
                BetaGroupsGetInstanceFieldsApp.InAppPurchasesV2 => "inAppPurchasesV2",
                BetaGroupsGetInstanceFieldsApp.IsOrEverWasMadeForKids => "isOrEverWasMadeForKids",
                BetaGroupsGetInstanceFieldsApp.MarketplaceSearchDetail => "marketplaceSearchDetail",
                BetaGroupsGetInstanceFieldsApp.Name => "name",
                BetaGroupsGetInstanceFieldsApp.PerfPowerMetrics => "perfPowerMetrics",
                BetaGroupsGetInstanceFieldsApp.PreReleaseVersions => "preReleaseVersions",
                BetaGroupsGetInstanceFieldsApp.PrimaryLocale => "primaryLocale",
                BetaGroupsGetInstanceFieldsApp.PromotedPurchases => "promotedPurchases",
                BetaGroupsGetInstanceFieldsApp.ReviewSubmissions => "reviewSubmissions",
                BetaGroupsGetInstanceFieldsApp.SearchKeywords => "searchKeywords",
                BetaGroupsGetInstanceFieldsApp.Sku => "sku",
                BetaGroupsGetInstanceFieldsApp.StreamlinedPurchasingEnabled => "streamlinedPurchasingEnabled",
                BetaGroupsGetInstanceFieldsApp.SubscriptionGracePeriod => "subscriptionGracePeriod",
                BetaGroupsGetInstanceFieldsApp.SubscriptionGroups => "subscriptionGroups",
                BetaGroupsGetInstanceFieldsApp.SubscriptionStatusUrl => "subscriptionStatusUrl",
                BetaGroupsGetInstanceFieldsApp.SubscriptionStatusUrlForSandbox => "subscriptionStatusUrlForSandbox",
                BetaGroupsGetInstanceFieldsApp.SubscriptionStatusUrlVersion => "subscriptionStatusUrlVersion",
                BetaGroupsGetInstanceFieldsApp.SubscriptionStatusUrlVersionForSandbox => "subscriptionStatusUrlVersionForSandbox",
                BetaGroupsGetInstanceFieldsApp.Webhooks => "webhooks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaGroupsGetInstanceFieldsApp? ToEnum(string value)
        {
            return value switch
            {
                "accessibilityDeclarations" => BetaGroupsGetInstanceFieldsApp.AccessibilityDeclarations,
                "accessibilityUrl" => BetaGroupsGetInstanceFieldsApp.AccessibilityUrl,
                "alternativeDistributionKey" => BetaGroupsGetInstanceFieldsApp.AlternativeDistributionKey,
                "analyticsReportRequests" => BetaGroupsGetInstanceFieldsApp.AnalyticsReportRequests,
                "androidToIosAppMappingDetails" => BetaGroupsGetInstanceFieldsApp.AndroidToIosAppMappingDetails,
                "appAvailabilityV2" => BetaGroupsGetInstanceFieldsApp.AppAvailabilityV2,
                "appClips" => BetaGroupsGetInstanceFieldsApp.AppClips,
                "appCustomProductPages" => BetaGroupsGetInstanceFieldsApp.AppCustomProductPages,
                "appEncryptionDeclarations" => BetaGroupsGetInstanceFieldsApp.AppEncryptionDeclarations,
                "appEvents" => BetaGroupsGetInstanceFieldsApp.AppEvents,
                "appInfos" => BetaGroupsGetInstanceFieldsApp.AppInfos,
                "appPricePoints" => BetaGroupsGetInstanceFieldsApp.AppPricePoints,
                "appPriceSchedule" => BetaGroupsGetInstanceFieldsApp.AppPriceSchedule,
                "appStoreIcon" => BetaGroupsGetInstanceFieldsApp.AppStoreIcon,
                "appStoreVersionExperimentsV2" => BetaGroupsGetInstanceFieldsApp.AppStoreVersionExperimentsV2,
                "appStoreVersions" => BetaGroupsGetInstanceFieldsApp.AppStoreVersions,
                "appTags" => BetaGroupsGetInstanceFieldsApp.AppTags,
                "backgroundAssets" => BetaGroupsGetInstanceFieldsApp.BackgroundAssets,
                "betaAppLocalizations" => BetaGroupsGetInstanceFieldsApp.BetaAppLocalizations,
                "betaAppReviewDetail" => BetaGroupsGetInstanceFieldsApp.BetaAppReviewDetail,
                "betaFeedbackCrashSubmissions" => BetaGroupsGetInstanceFieldsApp.BetaFeedbackCrashSubmissions,
                "betaFeedbackScreenshotSubmissions" => BetaGroupsGetInstanceFieldsApp.BetaFeedbackScreenshotSubmissions,
                "betaGroups" => BetaGroupsGetInstanceFieldsApp.BetaGroups,
                "betaLicenseAgreement" => BetaGroupsGetInstanceFieldsApp.BetaLicenseAgreement,
                "betaTesters" => BetaGroupsGetInstanceFieldsApp.BetaTesters,
                "buildUploads" => BetaGroupsGetInstanceFieldsApp.BuildUploads,
                "builds" => BetaGroupsGetInstanceFieldsApp.Builds,
                "bundleId" => BetaGroupsGetInstanceFieldsApp.BundleId,
                "ciProduct" => BetaGroupsGetInstanceFieldsApp.CiProduct,
                "contentRightsDeclaration" => BetaGroupsGetInstanceFieldsApp.ContentRightsDeclaration,
                "customerReviewSummarizations" => BetaGroupsGetInstanceFieldsApp.CustomerReviewSummarizations,
                "customerReviews" => BetaGroupsGetInstanceFieldsApp.CustomerReviews,
                "endUserLicenseAgreement" => BetaGroupsGetInstanceFieldsApp.EndUserLicenseAgreement,
                "gameCenterDetail" => BetaGroupsGetInstanceFieldsApp.GameCenterDetail,
                "gameCenterEnabledVersions" => BetaGroupsGetInstanceFieldsApp.GameCenterEnabledVersions,
                "inAppPurchases" => BetaGroupsGetInstanceFieldsApp.InAppPurchases,
                "inAppPurchasesV2" => BetaGroupsGetInstanceFieldsApp.InAppPurchasesV2,
                "isOrEverWasMadeForKids" => BetaGroupsGetInstanceFieldsApp.IsOrEverWasMadeForKids,
                "marketplaceSearchDetail" => BetaGroupsGetInstanceFieldsApp.MarketplaceSearchDetail,
                "name" => BetaGroupsGetInstanceFieldsApp.Name,
                "perfPowerMetrics" => BetaGroupsGetInstanceFieldsApp.PerfPowerMetrics,
                "preReleaseVersions" => BetaGroupsGetInstanceFieldsApp.PreReleaseVersions,
                "primaryLocale" => BetaGroupsGetInstanceFieldsApp.PrimaryLocale,
                "promotedPurchases" => BetaGroupsGetInstanceFieldsApp.PromotedPurchases,
                "reviewSubmissions" => BetaGroupsGetInstanceFieldsApp.ReviewSubmissions,
                "searchKeywords" => BetaGroupsGetInstanceFieldsApp.SearchKeywords,
                "sku" => BetaGroupsGetInstanceFieldsApp.Sku,
                "streamlinedPurchasingEnabled" => BetaGroupsGetInstanceFieldsApp.StreamlinedPurchasingEnabled,
                "subscriptionGracePeriod" => BetaGroupsGetInstanceFieldsApp.SubscriptionGracePeriod,
                "subscriptionGroups" => BetaGroupsGetInstanceFieldsApp.SubscriptionGroups,
                "subscriptionStatusUrl" => BetaGroupsGetInstanceFieldsApp.SubscriptionStatusUrl,
                "subscriptionStatusUrlForSandbox" => BetaGroupsGetInstanceFieldsApp.SubscriptionStatusUrlForSandbox,
                "subscriptionStatusUrlVersion" => BetaGroupsGetInstanceFieldsApp.SubscriptionStatusUrlVersion,
                "subscriptionStatusUrlVersionForSandbox" => BetaGroupsGetInstanceFieldsApp.SubscriptionStatusUrlVersionForSandbox,
                "webhooks" => BetaGroupsGetInstanceFieldsApp.Webhooks,
                _ => null,
            };
        }
    }
}