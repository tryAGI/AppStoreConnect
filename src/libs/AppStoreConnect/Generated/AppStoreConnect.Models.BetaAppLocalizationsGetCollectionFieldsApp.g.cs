
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaAppLocalizationsGetCollectionFieldsApp
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
    public static class BetaAppLocalizationsGetCollectionFieldsAppExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAppLocalizationsGetCollectionFieldsApp value)
        {
            return value switch
            {
                BetaAppLocalizationsGetCollectionFieldsApp.AccessibilityDeclarations => "accessibilityDeclarations",
                BetaAppLocalizationsGetCollectionFieldsApp.AccessibilityUrl => "accessibilityUrl",
                BetaAppLocalizationsGetCollectionFieldsApp.AlternativeDistributionKey => "alternativeDistributionKey",
                BetaAppLocalizationsGetCollectionFieldsApp.AnalyticsReportRequests => "analyticsReportRequests",
                BetaAppLocalizationsGetCollectionFieldsApp.AndroidToIosAppMappingDetails => "androidToIosAppMappingDetails",
                BetaAppLocalizationsGetCollectionFieldsApp.AppAvailabilityV2 => "appAvailabilityV2",
                BetaAppLocalizationsGetCollectionFieldsApp.AppClips => "appClips",
                BetaAppLocalizationsGetCollectionFieldsApp.AppCustomProductPages => "appCustomProductPages",
                BetaAppLocalizationsGetCollectionFieldsApp.AppEncryptionDeclarations => "appEncryptionDeclarations",
                BetaAppLocalizationsGetCollectionFieldsApp.AppEvents => "appEvents",
                BetaAppLocalizationsGetCollectionFieldsApp.AppInfos => "appInfos",
                BetaAppLocalizationsGetCollectionFieldsApp.AppPricePoints => "appPricePoints",
                BetaAppLocalizationsGetCollectionFieldsApp.AppPriceSchedule => "appPriceSchedule",
                BetaAppLocalizationsGetCollectionFieldsApp.AppStoreIcon => "appStoreIcon",
                BetaAppLocalizationsGetCollectionFieldsApp.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                BetaAppLocalizationsGetCollectionFieldsApp.AppStoreVersions => "appStoreVersions",
                BetaAppLocalizationsGetCollectionFieldsApp.AppTags => "appTags",
                BetaAppLocalizationsGetCollectionFieldsApp.BackgroundAssets => "backgroundAssets",
                BetaAppLocalizationsGetCollectionFieldsApp.BetaAppLocalizations => "betaAppLocalizations",
                BetaAppLocalizationsGetCollectionFieldsApp.BetaAppReviewDetail => "betaAppReviewDetail",
                BetaAppLocalizationsGetCollectionFieldsApp.BetaFeedbackCrashSubmissions => "betaFeedbackCrashSubmissions",
                BetaAppLocalizationsGetCollectionFieldsApp.BetaFeedbackScreenshotSubmissions => "betaFeedbackScreenshotSubmissions",
                BetaAppLocalizationsGetCollectionFieldsApp.BetaGroups => "betaGroups",
                BetaAppLocalizationsGetCollectionFieldsApp.BetaLicenseAgreement => "betaLicenseAgreement",
                BetaAppLocalizationsGetCollectionFieldsApp.BetaTesters => "betaTesters",
                BetaAppLocalizationsGetCollectionFieldsApp.BuildUploads => "buildUploads",
                BetaAppLocalizationsGetCollectionFieldsApp.Builds => "builds",
                BetaAppLocalizationsGetCollectionFieldsApp.BundleId => "bundleId",
                BetaAppLocalizationsGetCollectionFieldsApp.CiProduct => "ciProduct",
                BetaAppLocalizationsGetCollectionFieldsApp.ContentRightsDeclaration => "contentRightsDeclaration",
                BetaAppLocalizationsGetCollectionFieldsApp.CustomerReviewSummarizations => "customerReviewSummarizations",
                BetaAppLocalizationsGetCollectionFieldsApp.CustomerReviews => "customerReviews",
                BetaAppLocalizationsGetCollectionFieldsApp.EndUserLicenseAgreement => "endUserLicenseAgreement",
                BetaAppLocalizationsGetCollectionFieldsApp.GameCenterDetail => "gameCenterDetail",
                BetaAppLocalizationsGetCollectionFieldsApp.GameCenterEnabledVersions => "gameCenterEnabledVersions",
                BetaAppLocalizationsGetCollectionFieldsApp.InAppPurchases => "inAppPurchases",
                BetaAppLocalizationsGetCollectionFieldsApp.InAppPurchasesV2 => "inAppPurchasesV2",
                BetaAppLocalizationsGetCollectionFieldsApp.IsOrEverWasMadeForKids => "isOrEverWasMadeForKids",
                BetaAppLocalizationsGetCollectionFieldsApp.MarketplaceSearchDetail => "marketplaceSearchDetail",
                BetaAppLocalizationsGetCollectionFieldsApp.Name => "name",
                BetaAppLocalizationsGetCollectionFieldsApp.PerfPowerMetrics => "perfPowerMetrics",
                BetaAppLocalizationsGetCollectionFieldsApp.PreReleaseVersions => "preReleaseVersions",
                BetaAppLocalizationsGetCollectionFieldsApp.PrimaryLocale => "primaryLocale",
                BetaAppLocalizationsGetCollectionFieldsApp.PromotedPurchases => "promotedPurchases",
                BetaAppLocalizationsGetCollectionFieldsApp.ReviewSubmissions => "reviewSubmissions",
                BetaAppLocalizationsGetCollectionFieldsApp.SearchKeywords => "searchKeywords",
                BetaAppLocalizationsGetCollectionFieldsApp.Sku => "sku",
                BetaAppLocalizationsGetCollectionFieldsApp.StreamlinedPurchasingEnabled => "streamlinedPurchasingEnabled",
                BetaAppLocalizationsGetCollectionFieldsApp.SubscriptionGracePeriod => "subscriptionGracePeriod",
                BetaAppLocalizationsGetCollectionFieldsApp.SubscriptionGroups => "subscriptionGroups",
                BetaAppLocalizationsGetCollectionFieldsApp.SubscriptionStatusUrl => "subscriptionStatusUrl",
                BetaAppLocalizationsGetCollectionFieldsApp.SubscriptionStatusUrlForSandbox => "subscriptionStatusUrlForSandbox",
                BetaAppLocalizationsGetCollectionFieldsApp.SubscriptionStatusUrlVersion => "subscriptionStatusUrlVersion",
                BetaAppLocalizationsGetCollectionFieldsApp.SubscriptionStatusUrlVersionForSandbox => "subscriptionStatusUrlVersionForSandbox",
                BetaAppLocalizationsGetCollectionFieldsApp.Webhooks => "webhooks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAppLocalizationsGetCollectionFieldsApp? ToEnum(string value)
        {
            return value switch
            {
                "accessibilityDeclarations" => BetaAppLocalizationsGetCollectionFieldsApp.AccessibilityDeclarations,
                "accessibilityUrl" => BetaAppLocalizationsGetCollectionFieldsApp.AccessibilityUrl,
                "alternativeDistributionKey" => BetaAppLocalizationsGetCollectionFieldsApp.AlternativeDistributionKey,
                "analyticsReportRequests" => BetaAppLocalizationsGetCollectionFieldsApp.AnalyticsReportRequests,
                "androidToIosAppMappingDetails" => BetaAppLocalizationsGetCollectionFieldsApp.AndroidToIosAppMappingDetails,
                "appAvailabilityV2" => BetaAppLocalizationsGetCollectionFieldsApp.AppAvailabilityV2,
                "appClips" => BetaAppLocalizationsGetCollectionFieldsApp.AppClips,
                "appCustomProductPages" => BetaAppLocalizationsGetCollectionFieldsApp.AppCustomProductPages,
                "appEncryptionDeclarations" => BetaAppLocalizationsGetCollectionFieldsApp.AppEncryptionDeclarations,
                "appEvents" => BetaAppLocalizationsGetCollectionFieldsApp.AppEvents,
                "appInfos" => BetaAppLocalizationsGetCollectionFieldsApp.AppInfos,
                "appPricePoints" => BetaAppLocalizationsGetCollectionFieldsApp.AppPricePoints,
                "appPriceSchedule" => BetaAppLocalizationsGetCollectionFieldsApp.AppPriceSchedule,
                "appStoreIcon" => BetaAppLocalizationsGetCollectionFieldsApp.AppStoreIcon,
                "appStoreVersionExperimentsV2" => BetaAppLocalizationsGetCollectionFieldsApp.AppStoreVersionExperimentsV2,
                "appStoreVersions" => BetaAppLocalizationsGetCollectionFieldsApp.AppStoreVersions,
                "appTags" => BetaAppLocalizationsGetCollectionFieldsApp.AppTags,
                "backgroundAssets" => BetaAppLocalizationsGetCollectionFieldsApp.BackgroundAssets,
                "betaAppLocalizations" => BetaAppLocalizationsGetCollectionFieldsApp.BetaAppLocalizations,
                "betaAppReviewDetail" => BetaAppLocalizationsGetCollectionFieldsApp.BetaAppReviewDetail,
                "betaFeedbackCrashSubmissions" => BetaAppLocalizationsGetCollectionFieldsApp.BetaFeedbackCrashSubmissions,
                "betaFeedbackScreenshotSubmissions" => BetaAppLocalizationsGetCollectionFieldsApp.BetaFeedbackScreenshotSubmissions,
                "betaGroups" => BetaAppLocalizationsGetCollectionFieldsApp.BetaGroups,
                "betaLicenseAgreement" => BetaAppLocalizationsGetCollectionFieldsApp.BetaLicenseAgreement,
                "betaTesters" => BetaAppLocalizationsGetCollectionFieldsApp.BetaTesters,
                "buildUploads" => BetaAppLocalizationsGetCollectionFieldsApp.BuildUploads,
                "builds" => BetaAppLocalizationsGetCollectionFieldsApp.Builds,
                "bundleId" => BetaAppLocalizationsGetCollectionFieldsApp.BundleId,
                "ciProduct" => BetaAppLocalizationsGetCollectionFieldsApp.CiProduct,
                "contentRightsDeclaration" => BetaAppLocalizationsGetCollectionFieldsApp.ContentRightsDeclaration,
                "customerReviewSummarizations" => BetaAppLocalizationsGetCollectionFieldsApp.CustomerReviewSummarizations,
                "customerReviews" => BetaAppLocalizationsGetCollectionFieldsApp.CustomerReviews,
                "endUserLicenseAgreement" => BetaAppLocalizationsGetCollectionFieldsApp.EndUserLicenseAgreement,
                "gameCenterDetail" => BetaAppLocalizationsGetCollectionFieldsApp.GameCenterDetail,
                "gameCenterEnabledVersions" => BetaAppLocalizationsGetCollectionFieldsApp.GameCenterEnabledVersions,
                "inAppPurchases" => BetaAppLocalizationsGetCollectionFieldsApp.InAppPurchases,
                "inAppPurchasesV2" => BetaAppLocalizationsGetCollectionFieldsApp.InAppPurchasesV2,
                "isOrEverWasMadeForKids" => BetaAppLocalizationsGetCollectionFieldsApp.IsOrEverWasMadeForKids,
                "marketplaceSearchDetail" => BetaAppLocalizationsGetCollectionFieldsApp.MarketplaceSearchDetail,
                "name" => BetaAppLocalizationsGetCollectionFieldsApp.Name,
                "perfPowerMetrics" => BetaAppLocalizationsGetCollectionFieldsApp.PerfPowerMetrics,
                "preReleaseVersions" => BetaAppLocalizationsGetCollectionFieldsApp.PreReleaseVersions,
                "primaryLocale" => BetaAppLocalizationsGetCollectionFieldsApp.PrimaryLocale,
                "promotedPurchases" => BetaAppLocalizationsGetCollectionFieldsApp.PromotedPurchases,
                "reviewSubmissions" => BetaAppLocalizationsGetCollectionFieldsApp.ReviewSubmissions,
                "searchKeywords" => BetaAppLocalizationsGetCollectionFieldsApp.SearchKeywords,
                "sku" => BetaAppLocalizationsGetCollectionFieldsApp.Sku,
                "streamlinedPurchasingEnabled" => BetaAppLocalizationsGetCollectionFieldsApp.StreamlinedPurchasingEnabled,
                "subscriptionGracePeriod" => BetaAppLocalizationsGetCollectionFieldsApp.SubscriptionGracePeriod,
                "subscriptionGroups" => BetaAppLocalizationsGetCollectionFieldsApp.SubscriptionGroups,
                "subscriptionStatusUrl" => BetaAppLocalizationsGetCollectionFieldsApp.SubscriptionStatusUrl,
                "subscriptionStatusUrlForSandbox" => BetaAppLocalizationsGetCollectionFieldsApp.SubscriptionStatusUrlForSandbox,
                "subscriptionStatusUrlVersion" => BetaAppLocalizationsGetCollectionFieldsApp.SubscriptionStatusUrlVersion,
                "subscriptionStatusUrlVersionForSandbox" => BetaAppLocalizationsGetCollectionFieldsApp.SubscriptionStatusUrlVersionForSandbox,
                "webhooks" => BetaAppLocalizationsGetCollectionFieldsApp.Webhooks,
                _ => null,
            };
        }
    }
}