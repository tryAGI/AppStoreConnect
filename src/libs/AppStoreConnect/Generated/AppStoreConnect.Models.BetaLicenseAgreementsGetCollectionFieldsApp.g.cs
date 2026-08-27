
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaLicenseAgreementsGetCollectionFieldsApp
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
    public static class BetaLicenseAgreementsGetCollectionFieldsAppExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaLicenseAgreementsGetCollectionFieldsApp value)
        {
            return value switch
            {
                BetaLicenseAgreementsGetCollectionFieldsApp.AccessibilityDeclarations => "accessibilityDeclarations",
                BetaLicenseAgreementsGetCollectionFieldsApp.AccessibilityUrl => "accessibilityUrl",
                BetaLicenseAgreementsGetCollectionFieldsApp.AlternativeDistributionKey => "alternativeDistributionKey",
                BetaLicenseAgreementsGetCollectionFieldsApp.AnalyticsReportRequests => "analyticsReportRequests",
                BetaLicenseAgreementsGetCollectionFieldsApp.AndroidToIosAppMappingDetails => "androidToIosAppMappingDetails",
                BetaLicenseAgreementsGetCollectionFieldsApp.AppAvailabilityV2 => "appAvailabilityV2",
                BetaLicenseAgreementsGetCollectionFieldsApp.AppClips => "appClips",
                BetaLicenseAgreementsGetCollectionFieldsApp.AppCustomProductPages => "appCustomProductPages",
                BetaLicenseAgreementsGetCollectionFieldsApp.AppEncryptionDeclarations => "appEncryptionDeclarations",
                BetaLicenseAgreementsGetCollectionFieldsApp.AppEvents => "appEvents",
                BetaLicenseAgreementsGetCollectionFieldsApp.AppInfos => "appInfos",
                BetaLicenseAgreementsGetCollectionFieldsApp.AppPricePoints => "appPricePoints",
                BetaLicenseAgreementsGetCollectionFieldsApp.AppPriceSchedule => "appPriceSchedule",
                BetaLicenseAgreementsGetCollectionFieldsApp.AppStoreIcon => "appStoreIcon",
                BetaLicenseAgreementsGetCollectionFieldsApp.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                BetaLicenseAgreementsGetCollectionFieldsApp.AppStoreVersions => "appStoreVersions",
                BetaLicenseAgreementsGetCollectionFieldsApp.AppTags => "appTags",
                BetaLicenseAgreementsGetCollectionFieldsApp.BackgroundAssets => "backgroundAssets",
                BetaLicenseAgreementsGetCollectionFieldsApp.BetaAppLocalizations => "betaAppLocalizations",
                BetaLicenseAgreementsGetCollectionFieldsApp.BetaAppReviewDetail => "betaAppReviewDetail",
                BetaLicenseAgreementsGetCollectionFieldsApp.BetaFeedbackCrashSubmissions => "betaFeedbackCrashSubmissions",
                BetaLicenseAgreementsGetCollectionFieldsApp.BetaFeedbackScreenshotSubmissions => "betaFeedbackScreenshotSubmissions",
                BetaLicenseAgreementsGetCollectionFieldsApp.BetaGroups => "betaGroups",
                BetaLicenseAgreementsGetCollectionFieldsApp.BetaLicenseAgreement => "betaLicenseAgreement",
                BetaLicenseAgreementsGetCollectionFieldsApp.BetaTesters => "betaTesters",
                BetaLicenseAgreementsGetCollectionFieldsApp.BuildUploads => "buildUploads",
                BetaLicenseAgreementsGetCollectionFieldsApp.Builds => "builds",
                BetaLicenseAgreementsGetCollectionFieldsApp.BundleId => "bundleId",
                BetaLicenseAgreementsGetCollectionFieldsApp.CiProduct => "ciProduct",
                BetaLicenseAgreementsGetCollectionFieldsApp.ContentRightsDeclaration => "contentRightsDeclaration",
                BetaLicenseAgreementsGetCollectionFieldsApp.CustomerReviewSummarizations => "customerReviewSummarizations",
                BetaLicenseAgreementsGetCollectionFieldsApp.CustomerReviews => "customerReviews",
                BetaLicenseAgreementsGetCollectionFieldsApp.EndUserLicenseAgreement => "endUserLicenseAgreement",
                BetaLicenseAgreementsGetCollectionFieldsApp.GameCenterDetail => "gameCenterDetail",
                BetaLicenseAgreementsGetCollectionFieldsApp.GameCenterEnabledVersions => "gameCenterEnabledVersions",
                BetaLicenseAgreementsGetCollectionFieldsApp.InAppPurchases => "inAppPurchases",
                BetaLicenseAgreementsGetCollectionFieldsApp.InAppPurchasesV2 => "inAppPurchasesV2",
                BetaLicenseAgreementsGetCollectionFieldsApp.IsOrEverWasMadeForKids => "isOrEverWasMadeForKids",
                BetaLicenseAgreementsGetCollectionFieldsApp.MarketplaceSearchDetail => "marketplaceSearchDetail",
                BetaLicenseAgreementsGetCollectionFieldsApp.Name => "name",
                BetaLicenseAgreementsGetCollectionFieldsApp.PerfPowerMetrics => "perfPowerMetrics",
                BetaLicenseAgreementsGetCollectionFieldsApp.PreReleaseVersions => "preReleaseVersions",
                BetaLicenseAgreementsGetCollectionFieldsApp.PrimaryLocale => "primaryLocale",
                BetaLicenseAgreementsGetCollectionFieldsApp.PromotedPurchases => "promotedPurchases",
                BetaLicenseAgreementsGetCollectionFieldsApp.ReviewSubmissions => "reviewSubmissions",
                BetaLicenseAgreementsGetCollectionFieldsApp.SearchKeywords => "searchKeywords",
                BetaLicenseAgreementsGetCollectionFieldsApp.Sku => "sku",
                BetaLicenseAgreementsGetCollectionFieldsApp.StreamlinedPurchasingEnabled => "streamlinedPurchasingEnabled",
                BetaLicenseAgreementsGetCollectionFieldsApp.SubscriptionGracePeriod => "subscriptionGracePeriod",
                BetaLicenseAgreementsGetCollectionFieldsApp.SubscriptionGroups => "subscriptionGroups",
                BetaLicenseAgreementsGetCollectionFieldsApp.SubscriptionStatusUrl => "subscriptionStatusUrl",
                BetaLicenseAgreementsGetCollectionFieldsApp.SubscriptionStatusUrlForSandbox => "subscriptionStatusUrlForSandbox",
                BetaLicenseAgreementsGetCollectionFieldsApp.SubscriptionStatusUrlVersion => "subscriptionStatusUrlVersion",
                BetaLicenseAgreementsGetCollectionFieldsApp.SubscriptionStatusUrlVersionForSandbox => "subscriptionStatusUrlVersionForSandbox",
                BetaLicenseAgreementsGetCollectionFieldsApp.Webhooks => "webhooks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaLicenseAgreementsGetCollectionFieldsApp? ToEnum(string value)
        {
            return value switch
            {
                "accessibilityDeclarations" => BetaLicenseAgreementsGetCollectionFieldsApp.AccessibilityDeclarations,
                "accessibilityUrl" => BetaLicenseAgreementsGetCollectionFieldsApp.AccessibilityUrl,
                "alternativeDistributionKey" => BetaLicenseAgreementsGetCollectionFieldsApp.AlternativeDistributionKey,
                "analyticsReportRequests" => BetaLicenseAgreementsGetCollectionFieldsApp.AnalyticsReportRequests,
                "androidToIosAppMappingDetails" => BetaLicenseAgreementsGetCollectionFieldsApp.AndroidToIosAppMappingDetails,
                "appAvailabilityV2" => BetaLicenseAgreementsGetCollectionFieldsApp.AppAvailabilityV2,
                "appClips" => BetaLicenseAgreementsGetCollectionFieldsApp.AppClips,
                "appCustomProductPages" => BetaLicenseAgreementsGetCollectionFieldsApp.AppCustomProductPages,
                "appEncryptionDeclarations" => BetaLicenseAgreementsGetCollectionFieldsApp.AppEncryptionDeclarations,
                "appEvents" => BetaLicenseAgreementsGetCollectionFieldsApp.AppEvents,
                "appInfos" => BetaLicenseAgreementsGetCollectionFieldsApp.AppInfos,
                "appPricePoints" => BetaLicenseAgreementsGetCollectionFieldsApp.AppPricePoints,
                "appPriceSchedule" => BetaLicenseAgreementsGetCollectionFieldsApp.AppPriceSchedule,
                "appStoreIcon" => BetaLicenseAgreementsGetCollectionFieldsApp.AppStoreIcon,
                "appStoreVersionExperimentsV2" => BetaLicenseAgreementsGetCollectionFieldsApp.AppStoreVersionExperimentsV2,
                "appStoreVersions" => BetaLicenseAgreementsGetCollectionFieldsApp.AppStoreVersions,
                "appTags" => BetaLicenseAgreementsGetCollectionFieldsApp.AppTags,
                "backgroundAssets" => BetaLicenseAgreementsGetCollectionFieldsApp.BackgroundAssets,
                "betaAppLocalizations" => BetaLicenseAgreementsGetCollectionFieldsApp.BetaAppLocalizations,
                "betaAppReviewDetail" => BetaLicenseAgreementsGetCollectionFieldsApp.BetaAppReviewDetail,
                "betaFeedbackCrashSubmissions" => BetaLicenseAgreementsGetCollectionFieldsApp.BetaFeedbackCrashSubmissions,
                "betaFeedbackScreenshotSubmissions" => BetaLicenseAgreementsGetCollectionFieldsApp.BetaFeedbackScreenshotSubmissions,
                "betaGroups" => BetaLicenseAgreementsGetCollectionFieldsApp.BetaGroups,
                "betaLicenseAgreement" => BetaLicenseAgreementsGetCollectionFieldsApp.BetaLicenseAgreement,
                "betaTesters" => BetaLicenseAgreementsGetCollectionFieldsApp.BetaTesters,
                "buildUploads" => BetaLicenseAgreementsGetCollectionFieldsApp.BuildUploads,
                "builds" => BetaLicenseAgreementsGetCollectionFieldsApp.Builds,
                "bundleId" => BetaLicenseAgreementsGetCollectionFieldsApp.BundleId,
                "ciProduct" => BetaLicenseAgreementsGetCollectionFieldsApp.CiProduct,
                "contentRightsDeclaration" => BetaLicenseAgreementsGetCollectionFieldsApp.ContentRightsDeclaration,
                "customerReviewSummarizations" => BetaLicenseAgreementsGetCollectionFieldsApp.CustomerReviewSummarizations,
                "customerReviews" => BetaLicenseAgreementsGetCollectionFieldsApp.CustomerReviews,
                "endUserLicenseAgreement" => BetaLicenseAgreementsGetCollectionFieldsApp.EndUserLicenseAgreement,
                "gameCenterDetail" => BetaLicenseAgreementsGetCollectionFieldsApp.GameCenterDetail,
                "gameCenterEnabledVersions" => BetaLicenseAgreementsGetCollectionFieldsApp.GameCenterEnabledVersions,
                "inAppPurchases" => BetaLicenseAgreementsGetCollectionFieldsApp.InAppPurchases,
                "inAppPurchasesV2" => BetaLicenseAgreementsGetCollectionFieldsApp.InAppPurchasesV2,
                "isOrEverWasMadeForKids" => BetaLicenseAgreementsGetCollectionFieldsApp.IsOrEverWasMadeForKids,
                "marketplaceSearchDetail" => BetaLicenseAgreementsGetCollectionFieldsApp.MarketplaceSearchDetail,
                "name" => BetaLicenseAgreementsGetCollectionFieldsApp.Name,
                "perfPowerMetrics" => BetaLicenseAgreementsGetCollectionFieldsApp.PerfPowerMetrics,
                "preReleaseVersions" => BetaLicenseAgreementsGetCollectionFieldsApp.PreReleaseVersions,
                "primaryLocale" => BetaLicenseAgreementsGetCollectionFieldsApp.PrimaryLocale,
                "promotedPurchases" => BetaLicenseAgreementsGetCollectionFieldsApp.PromotedPurchases,
                "reviewSubmissions" => BetaLicenseAgreementsGetCollectionFieldsApp.ReviewSubmissions,
                "searchKeywords" => BetaLicenseAgreementsGetCollectionFieldsApp.SearchKeywords,
                "sku" => BetaLicenseAgreementsGetCollectionFieldsApp.Sku,
                "streamlinedPurchasingEnabled" => BetaLicenseAgreementsGetCollectionFieldsApp.StreamlinedPurchasingEnabled,
                "subscriptionGracePeriod" => BetaLicenseAgreementsGetCollectionFieldsApp.SubscriptionGracePeriod,
                "subscriptionGroups" => BetaLicenseAgreementsGetCollectionFieldsApp.SubscriptionGroups,
                "subscriptionStatusUrl" => BetaLicenseAgreementsGetCollectionFieldsApp.SubscriptionStatusUrl,
                "subscriptionStatusUrlForSandbox" => BetaLicenseAgreementsGetCollectionFieldsApp.SubscriptionStatusUrlForSandbox,
                "subscriptionStatusUrlVersion" => BetaLicenseAgreementsGetCollectionFieldsApp.SubscriptionStatusUrlVersion,
                "subscriptionStatusUrlVersionForSandbox" => BetaLicenseAgreementsGetCollectionFieldsApp.SubscriptionStatusUrlVersionForSandbox,
                "webhooks" => BetaLicenseAgreementsGetCollectionFieldsApp.Webhooks,
                _ => null,
            };
        }
    }
}