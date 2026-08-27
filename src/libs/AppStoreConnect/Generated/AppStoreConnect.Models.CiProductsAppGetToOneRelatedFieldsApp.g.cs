
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiProductsAppGetToOneRelatedFieldsApp
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
    public static class CiProductsAppGetToOneRelatedFieldsAppExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiProductsAppGetToOneRelatedFieldsApp value)
        {
            return value switch
            {
                CiProductsAppGetToOneRelatedFieldsApp.AccessibilityDeclarations => "accessibilityDeclarations",
                CiProductsAppGetToOneRelatedFieldsApp.AccessibilityUrl => "accessibilityUrl",
                CiProductsAppGetToOneRelatedFieldsApp.AlternativeDistributionKey => "alternativeDistributionKey",
                CiProductsAppGetToOneRelatedFieldsApp.AnalyticsReportRequests => "analyticsReportRequests",
                CiProductsAppGetToOneRelatedFieldsApp.AndroidToIosAppMappingDetails => "androidToIosAppMappingDetails",
                CiProductsAppGetToOneRelatedFieldsApp.AppAvailabilityV2 => "appAvailabilityV2",
                CiProductsAppGetToOneRelatedFieldsApp.AppClips => "appClips",
                CiProductsAppGetToOneRelatedFieldsApp.AppCustomProductPages => "appCustomProductPages",
                CiProductsAppGetToOneRelatedFieldsApp.AppEncryptionDeclarations => "appEncryptionDeclarations",
                CiProductsAppGetToOneRelatedFieldsApp.AppEvents => "appEvents",
                CiProductsAppGetToOneRelatedFieldsApp.AppInfos => "appInfos",
                CiProductsAppGetToOneRelatedFieldsApp.AppPricePoints => "appPricePoints",
                CiProductsAppGetToOneRelatedFieldsApp.AppPriceSchedule => "appPriceSchedule",
                CiProductsAppGetToOneRelatedFieldsApp.AppStoreIcon => "appStoreIcon",
                CiProductsAppGetToOneRelatedFieldsApp.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                CiProductsAppGetToOneRelatedFieldsApp.AppStoreVersions => "appStoreVersions",
                CiProductsAppGetToOneRelatedFieldsApp.AppTags => "appTags",
                CiProductsAppGetToOneRelatedFieldsApp.BackgroundAssets => "backgroundAssets",
                CiProductsAppGetToOneRelatedFieldsApp.BetaAppLocalizations => "betaAppLocalizations",
                CiProductsAppGetToOneRelatedFieldsApp.BetaAppReviewDetail => "betaAppReviewDetail",
                CiProductsAppGetToOneRelatedFieldsApp.BetaFeedbackCrashSubmissions => "betaFeedbackCrashSubmissions",
                CiProductsAppGetToOneRelatedFieldsApp.BetaFeedbackScreenshotSubmissions => "betaFeedbackScreenshotSubmissions",
                CiProductsAppGetToOneRelatedFieldsApp.BetaGroups => "betaGroups",
                CiProductsAppGetToOneRelatedFieldsApp.BetaLicenseAgreement => "betaLicenseAgreement",
                CiProductsAppGetToOneRelatedFieldsApp.BetaTesters => "betaTesters",
                CiProductsAppGetToOneRelatedFieldsApp.BuildUploads => "buildUploads",
                CiProductsAppGetToOneRelatedFieldsApp.Builds => "builds",
                CiProductsAppGetToOneRelatedFieldsApp.BundleId => "bundleId",
                CiProductsAppGetToOneRelatedFieldsApp.CiProduct => "ciProduct",
                CiProductsAppGetToOneRelatedFieldsApp.ContentRightsDeclaration => "contentRightsDeclaration",
                CiProductsAppGetToOneRelatedFieldsApp.CustomerReviewSummarizations => "customerReviewSummarizations",
                CiProductsAppGetToOneRelatedFieldsApp.CustomerReviews => "customerReviews",
                CiProductsAppGetToOneRelatedFieldsApp.EndUserLicenseAgreement => "endUserLicenseAgreement",
                CiProductsAppGetToOneRelatedFieldsApp.GameCenterDetail => "gameCenterDetail",
                CiProductsAppGetToOneRelatedFieldsApp.GameCenterEnabledVersions => "gameCenterEnabledVersions",
                CiProductsAppGetToOneRelatedFieldsApp.InAppPurchases => "inAppPurchases",
                CiProductsAppGetToOneRelatedFieldsApp.InAppPurchasesV2 => "inAppPurchasesV2",
                CiProductsAppGetToOneRelatedFieldsApp.IsOrEverWasMadeForKids => "isOrEverWasMadeForKids",
                CiProductsAppGetToOneRelatedFieldsApp.MarketplaceSearchDetail => "marketplaceSearchDetail",
                CiProductsAppGetToOneRelatedFieldsApp.Name => "name",
                CiProductsAppGetToOneRelatedFieldsApp.PerfPowerMetrics => "perfPowerMetrics",
                CiProductsAppGetToOneRelatedFieldsApp.PreReleaseVersions => "preReleaseVersions",
                CiProductsAppGetToOneRelatedFieldsApp.PrimaryLocale => "primaryLocale",
                CiProductsAppGetToOneRelatedFieldsApp.PromotedPurchases => "promotedPurchases",
                CiProductsAppGetToOneRelatedFieldsApp.ReviewSubmissions => "reviewSubmissions",
                CiProductsAppGetToOneRelatedFieldsApp.SearchKeywords => "searchKeywords",
                CiProductsAppGetToOneRelatedFieldsApp.Sku => "sku",
                CiProductsAppGetToOneRelatedFieldsApp.StreamlinedPurchasingEnabled => "streamlinedPurchasingEnabled",
                CiProductsAppGetToOneRelatedFieldsApp.SubscriptionGracePeriod => "subscriptionGracePeriod",
                CiProductsAppGetToOneRelatedFieldsApp.SubscriptionGroups => "subscriptionGroups",
                CiProductsAppGetToOneRelatedFieldsApp.SubscriptionStatusUrl => "subscriptionStatusUrl",
                CiProductsAppGetToOneRelatedFieldsApp.SubscriptionStatusUrlForSandbox => "subscriptionStatusUrlForSandbox",
                CiProductsAppGetToOneRelatedFieldsApp.SubscriptionStatusUrlVersion => "subscriptionStatusUrlVersion",
                CiProductsAppGetToOneRelatedFieldsApp.SubscriptionStatusUrlVersionForSandbox => "subscriptionStatusUrlVersionForSandbox",
                CiProductsAppGetToOneRelatedFieldsApp.Webhooks => "webhooks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiProductsAppGetToOneRelatedFieldsApp? ToEnum(string value)
        {
            return value switch
            {
                "accessibilityDeclarations" => CiProductsAppGetToOneRelatedFieldsApp.AccessibilityDeclarations,
                "accessibilityUrl" => CiProductsAppGetToOneRelatedFieldsApp.AccessibilityUrl,
                "alternativeDistributionKey" => CiProductsAppGetToOneRelatedFieldsApp.AlternativeDistributionKey,
                "analyticsReportRequests" => CiProductsAppGetToOneRelatedFieldsApp.AnalyticsReportRequests,
                "androidToIosAppMappingDetails" => CiProductsAppGetToOneRelatedFieldsApp.AndroidToIosAppMappingDetails,
                "appAvailabilityV2" => CiProductsAppGetToOneRelatedFieldsApp.AppAvailabilityV2,
                "appClips" => CiProductsAppGetToOneRelatedFieldsApp.AppClips,
                "appCustomProductPages" => CiProductsAppGetToOneRelatedFieldsApp.AppCustomProductPages,
                "appEncryptionDeclarations" => CiProductsAppGetToOneRelatedFieldsApp.AppEncryptionDeclarations,
                "appEvents" => CiProductsAppGetToOneRelatedFieldsApp.AppEvents,
                "appInfos" => CiProductsAppGetToOneRelatedFieldsApp.AppInfos,
                "appPricePoints" => CiProductsAppGetToOneRelatedFieldsApp.AppPricePoints,
                "appPriceSchedule" => CiProductsAppGetToOneRelatedFieldsApp.AppPriceSchedule,
                "appStoreIcon" => CiProductsAppGetToOneRelatedFieldsApp.AppStoreIcon,
                "appStoreVersionExperimentsV2" => CiProductsAppGetToOneRelatedFieldsApp.AppStoreVersionExperimentsV2,
                "appStoreVersions" => CiProductsAppGetToOneRelatedFieldsApp.AppStoreVersions,
                "appTags" => CiProductsAppGetToOneRelatedFieldsApp.AppTags,
                "backgroundAssets" => CiProductsAppGetToOneRelatedFieldsApp.BackgroundAssets,
                "betaAppLocalizations" => CiProductsAppGetToOneRelatedFieldsApp.BetaAppLocalizations,
                "betaAppReviewDetail" => CiProductsAppGetToOneRelatedFieldsApp.BetaAppReviewDetail,
                "betaFeedbackCrashSubmissions" => CiProductsAppGetToOneRelatedFieldsApp.BetaFeedbackCrashSubmissions,
                "betaFeedbackScreenshotSubmissions" => CiProductsAppGetToOneRelatedFieldsApp.BetaFeedbackScreenshotSubmissions,
                "betaGroups" => CiProductsAppGetToOneRelatedFieldsApp.BetaGroups,
                "betaLicenseAgreement" => CiProductsAppGetToOneRelatedFieldsApp.BetaLicenseAgreement,
                "betaTesters" => CiProductsAppGetToOneRelatedFieldsApp.BetaTesters,
                "buildUploads" => CiProductsAppGetToOneRelatedFieldsApp.BuildUploads,
                "builds" => CiProductsAppGetToOneRelatedFieldsApp.Builds,
                "bundleId" => CiProductsAppGetToOneRelatedFieldsApp.BundleId,
                "ciProduct" => CiProductsAppGetToOneRelatedFieldsApp.CiProduct,
                "contentRightsDeclaration" => CiProductsAppGetToOneRelatedFieldsApp.ContentRightsDeclaration,
                "customerReviewSummarizations" => CiProductsAppGetToOneRelatedFieldsApp.CustomerReviewSummarizations,
                "customerReviews" => CiProductsAppGetToOneRelatedFieldsApp.CustomerReviews,
                "endUserLicenseAgreement" => CiProductsAppGetToOneRelatedFieldsApp.EndUserLicenseAgreement,
                "gameCenterDetail" => CiProductsAppGetToOneRelatedFieldsApp.GameCenterDetail,
                "gameCenterEnabledVersions" => CiProductsAppGetToOneRelatedFieldsApp.GameCenterEnabledVersions,
                "inAppPurchases" => CiProductsAppGetToOneRelatedFieldsApp.InAppPurchases,
                "inAppPurchasesV2" => CiProductsAppGetToOneRelatedFieldsApp.InAppPurchasesV2,
                "isOrEverWasMadeForKids" => CiProductsAppGetToOneRelatedFieldsApp.IsOrEverWasMadeForKids,
                "marketplaceSearchDetail" => CiProductsAppGetToOneRelatedFieldsApp.MarketplaceSearchDetail,
                "name" => CiProductsAppGetToOneRelatedFieldsApp.Name,
                "perfPowerMetrics" => CiProductsAppGetToOneRelatedFieldsApp.PerfPowerMetrics,
                "preReleaseVersions" => CiProductsAppGetToOneRelatedFieldsApp.PreReleaseVersions,
                "primaryLocale" => CiProductsAppGetToOneRelatedFieldsApp.PrimaryLocale,
                "promotedPurchases" => CiProductsAppGetToOneRelatedFieldsApp.PromotedPurchases,
                "reviewSubmissions" => CiProductsAppGetToOneRelatedFieldsApp.ReviewSubmissions,
                "searchKeywords" => CiProductsAppGetToOneRelatedFieldsApp.SearchKeywords,
                "sku" => CiProductsAppGetToOneRelatedFieldsApp.Sku,
                "streamlinedPurchasingEnabled" => CiProductsAppGetToOneRelatedFieldsApp.StreamlinedPurchasingEnabled,
                "subscriptionGracePeriod" => CiProductsAppGetToOneRelatedFieldsApp.SubscriptionGracePeriod,
                "subscriptionGroups" => CiProductsAppGetToOneRelatedFieldsApp.SubscriptionGroups,
                "subscriptionStatusUrl" => CiProductsAppGetToOneRelatedFieldsApp.SubscriptionStatusUrl,
                "subscriptionStatusUrlForSandbox" => CiProductsAppGetToOneRelatedFieldsApp.SubscriptionStatusUrlForSandbox,
                "subscriptionStatusUrlVersion" => CiProductsAppGetToOneRelatedFieldsApp.SubscriptionStatusUrlVersion,
                "subscriptionStatusUrlVersionForSandbox" => CiProductsAppGetToOneRelatedFieldsApp.SubscriptionStatusUrlVersionForSandbox,
                "webhooks" => CiProductsAppGetToOneRelatedFieldsApp.Webhooks,
                _ => null,
            };
        }
    }
}