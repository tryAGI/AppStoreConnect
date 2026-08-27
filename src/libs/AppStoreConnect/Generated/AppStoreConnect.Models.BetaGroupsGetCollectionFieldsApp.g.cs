
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaGroupsGetCollectionFieldsApp
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
    public static class BetaGroupsGetCollectionFieldsAppExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaGroupsGetCollectionFieldsApp value)
        {
            return value switch
            {
                BetaGroupsGetCollectionFieldsApp.AccessibilityDeclarations => "accessibilityDeclarations",
                BetaGroupsGetCollectionFieldsApp.AccessibilityUrl => "accessibilityUrl",
                BetaGroupsGetCollectionFieldsApp.AlternativeDistributionKey => "alternativeDistributionKey",
                BetaGroupsGetCollectionFieldsApp.AnalyticsReportRequests => "analyticsReportRequests",
                BetaGroupsGetCollectionFieldsApp.AndroidToIosAppMappingDetails => "androidToIosAppMappingDetails",
                BetaGroupsGetCollectionFieldsApp.AppAvailabilityV2 => "appAvailabilityV2",
                BetaGroupsGetCollectionFieldsApp.AppClips => "appClips",
                BetaGroupsGetCollectionFieldsApp.AppCustomProductPages => "appCustomProductPages",
                BetaGroupsGetCollectionFieldsApp.AppEncryptionDeclarations => "appEncryptionDeclarations",
                BetaGroupsGetCollectionFieldsApp.AppEvents => "appEvents",
                BetaGroupsGetCollectionFieldsApp.AppInfos => "appInfos",
                BetaGroupsGetCollectionFieldsApp.AppPricePoints => "appPricePoints",
                BetaGroupsGetCollectionFieldsApp.AppPriceSchedule => "appPriceSchedule",
                BetaGroupsGetCollectionFieldsApp.AppStoreIcon => "appStoreIcon",
                BetaGroupsGetCollectionFieldsApp.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                BetaGroupsGetCollectionFieldsApp.AppStoreVersions => "appStoreVersions",
                BetaGroupsGetCollectionFieldsApp.AppTags => "appTags",
                BetaGroupsGetCollectionFieldsApp.BackgroundAssets => "backgroundAssets",
                BetaGroupsGetCollectionFieldsApp.BetaAppLocalizations => "betaAppLocalizations",
                BetaGroupsGetCollectionFieldsApp.BetaAppReviewDetail => "betaAppReviewDetail",
                BetaGroupsGetCollectionFieldsApp.BetaFeedbackCrashSubmissions => "betaFeedbackCrashSubmissions",
                BetaGroupsGetCollectionFieldsApp.BetaFeedbackScreenshotSubmissions => "betaFeedbackScreenshotSubmissions",
                BetaGroupsGetCollectionFieldsApp.BetaGroups => "betaGroups",
                BetaGroupsGetCollectionFieldsApp.BetaLicenseAgreement => "betaLicenseAgreement",
                BetaGroupsGetCollectionFieldsApp.BetaTesters => "betaTesters",
                BetaGroupsGetCollectionFieldsApp.BuildUploads => "buildUploads",
                BetaGroupsGetCollectionFieldsApp.Builds => "builds",
                BetaGroupsGetCollectionFieldsApp.BundleId => "bundleId",
                BetaGroupsGetCollectionFieldsApp.CiProduct => "ciProduct",
                BetaGroupsGetCollectionFieldsApp.ContentRightsDeclaration => "contentRightsDeclaration",
                BetaGroupsGetCollectionFieldsApp.CustomerReviewSummarizations => "customerReviewSummarizations",
                BetaGroupsGetCollectionFieldsApp.CustomerReviews => "customerReviews",
                BetaGroupsGetCollectionFieldsApp.EndUserLicenseAgreement => "endUserLicenseAgreement",
                BetaGroupsGetCollectionFieldsApp.GameCenterDetail => "gameCenterDetail",
                BetaGroupsGetCollectionFieldsApp.GameCenterEnabledVersions => "gameCenterEnabledVersions",
                BetaGroupsGetCollectionFieldsApp.InAppPurchases => "inAppPurchases",
                BetaGroupsGetCollectionFieldsApp.InAppPurchasesV2 => "inAppPurchasesV2",
                BetaGroupsGetCollectionFieldsApp.IsOrEverWasMadeForKids => "isOrEverWasMadeForKids",
                BetaGroupsGetCollectionFieldsApp.MarketplaceSearchDetail => "marketplaceSearchDetail",
                BetaGroupsGetCollectionFieldsApp.Name => "name",
                BetaGroupsGetCollectionFieldsApp.PerfPowerMetrics => "perfPowerMetrics",
                BetaGroupsGetCollectionFieldsApp.PreReleaseVersions => "preReleaseVersions",
                BetaGroupsGetCollectionFieldsApp.PrimaryLocale => "primaryLocale",
                BetaGroupsGetCollectionFieldsApp.PromotedPurchases => "promotedPurchases",
                BetaGroupsGetCollectionFieldsApp.ReviewSubmissions => "reviewSubmissions",
                BetaGroupsGetCollectionFieldsApp.SearchKeywords => "searchKeywords",
                BetaGroupsGetCollectionFieldsApp.Sku => "sku",
                BetaGroupsGetCollectionFieldsApp.StreamlinedPurchasingEnabled => "streamlinedPurchasingEnabled",
                BetaGroupsGetCollectionFieldsApp.SubscriptionGracePeriod => "subscriptionGracePeriod",
                BetaGroupsGetCollectionFieldsApp.SubscriptionGroups => "subscriptionGroups",
                BetaGroupsGetCollectionFieldsApp.SubscriptionStatusUrl => "subscriptionStatusUrl",
                BetaGroupsGetCollectionFieldsApp.SubscriptionStatusUrlForSandbox => "subscriptionStatusUrlForSandbox",
                BetaGroupsGetCollectionFieldsApp.SubscriptionStatusUrlVersion => "subscriptionStatusUrlVersion",
                BetaGroupsGetCollectionFieldsApp.SubscriptionStatusUrlVersionForSandbox => "subscriptionStatusUrlVersionForSandbox",
                BetaGroupsGetCollectionFieldsApp.Webhooks => "webhooks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaGroupsGetCollectionFieldsApp? ToEnum(string value)
        {
            return value switch
            {
                "accessibilityDeclarations" => BetaGroupsGetCollectionFieldsApp.AccessibilityDeclarations,
                "accessibilityUrl" => BetaGroupsGetCollectionFieldsApp.AccessibilityUrl,
                "alternativeDistributionKey" => BetaGroupsGetCollectionFieldsApp.AlternativeDistributionKey,
                "analyticsReportRequests" => BetaGroupsGetCollectionFieldsApp.AnalyticsReportRequests,
                "androidToIosAppMappingDetails" => BetaGroupsGetCollectionFieldsApp.AndroidToIosAppMappingDetails,
                "appAvailabilityV2" => BetaGroupsGetCollectionFieldsApp.AppAvailabilityV2,
                "appClips" => BetaGroupsGetCollectionFieldsApp.AppClips,
                "appCustomProductPages" => BetaGroupsGetCollectionFieldsApp.AppCustomProductPages,
                "appEncryptionDeclarations" => BetaGroupsGetCollectionFieldsApp.AppEncryptionDeclarations,
                "appEvents" => BetaGroupsGetCollectionFieldsApp.AppEvents,
                "appInfos" => BetaGroupsGetCollectionFieldsApp.AppInfos,
                "appPricePoints" => BetaGroupsGetCollectionFieldsApp.AppPricePoints,
                "appPriceSchedule" => BetaGroupsGetCollectionFieldsApp.AppPriceSchedule,
                "appStoreIcon" => BetaGroupsGetCollectionFieldsApp.AppStoreIcon,
                "appStoreVersionExperimentsV2" => BetaGroupsGetCollectionFieldsApp.AppStoreVersionExperimentsV2,
                "appStoreVersions" => BetaGroupsGetCollectionFieldsApp.AppStoreVersions,
                "appTags" => BetaGroupsGetCollectionFieldsApp.AppTags,
                "backgroundAssets" => BetaGroupsGetCollectionFieldsApp.BackgroundAssets,
                "betaAppLocalizations" => BetaGroupsGetCollectionFieldsApp.BetaAppLocalizations,
                "betaAppReviewDetail" => BetaGroupsGetCollectionFieldsApp.BetaAppReviewDetail,
                "betaFeedbackCrashSubmissions" => BetaGroupsGetCollectionFieldsApp.BetaFeedbackCrashSubmissions,
                "betaFeedbackScreenshotSubmissions" => BetaGroupsGetCollectionFieldsApp.BetaFeedbackScreenshotSubmissions,
                "betaGroups" => BetaGroupsGetCollectionFieldsApp.BetaGroups,
                "betaLicenseAgreement" => BetaGroupsGetCollectionFieldsApp.BetaLicenseAgreement,
                "betaTesters" => BetaGroupsGetCollectionFieldsApp.BetaTesters,
                "buildUploads" => BetaGroupsGetCollectionFieldsApp.BuildUploads,
                "builds" => BetaGroupsGetCollectionFieldsApp.Builds,
                "bundleId" => BetaGroupsGetCollectionFieldsApp.BundleId,
                "ciProduct" => BetaGroupsGetCollectionFieldsApp.CiProduct,
                "contentRightsDeclaration" => BetaGroupsGetCollectionFieldsApp.ContentRightsDeclaration,
                "customerReviewSummarizations" => BetaGroupsGetCollectionFieldsApp.CustomerReviewSummarizations,
                "customerReviews" => BetaGroupsGetCollectionFieldsApp.CustomerReviews,
                "endUserLicenseAgreement" => BetaGroupsGetCollectionFieldsApp.EndUserLicenseAgreement,
                "gameCenterDetail" => BetaGroupsGetCollectionFieldsApp.GameCenterDetail,
                "gameCenterEnabledVersions" => BetaGroupsGetCollectionFieldsApp.GameCenterEnabledVersions,
                "inAppPurchases" => BetaGroupsGetCollectionFieldsApp.InAppPurchases,
                "inAppPurchasesV2" => BetaGroupsGetCollectionFieldsApp.InAppPurchasesV2,
                "isOrEverWasMadeForKids" => BetaGroupsGetCollectionFieldsApp.IsOrEverWasMadeForKids,
                "marketplaceSearchDetail" => BetaGroupsGetCollectionFieldsApp.MarketplaceSearchDetail,
                "name" => BetaGroupsGetCollectionFieldsApp.Name,
                "perfPowerMetrics" => BetaGroupsGetCollectionFieldsApp.PerfPowerMetrics,
                "preReleaseVersions" => BetaGroupsGetCollectionFieldsApp.PreReleaseVersions,
                "primaryLocale" => BetaGroupsGetCollectionFieldsApp.PrimaryLocale,
                "promotedPurchases" => BetaGroupsGetCollectionFieldsApp.PromotedPurchases,
                "reviewSubmissions" => BetaGroupsGetCollectionFieldsApp.ReviewSubmissions,
                "searchKeywords" => BetaGroupsGetCollectionFieldsApp.SearchKeywords,
                "sku" => BetaGroupsGetCollectionFieldsApp.Sku,
                "streamlinedPurchasingEnabled" => BetaGroupsGetCollectionFieldsApp.StreamlinedPurchasingEnabled,
                "subscriptionGracePeriod" => BetaGroupsGetCollectionFieldsApp.SubscriptionGracePeriod,
                "subscriptionGroups" => BetaGroupsGetCollectionFieldsApp.SubscriptionGroups,
                "subscriptionStatusUrl" => BetaGroupsGetCollectionFieldsApp.SubscriptionStatusUrl,
                "subscriptionStatusUrlForSandbox" => BetaGroupsGetCollectionFieldsApp.SubscriptionStatusUrlForSandbox,
                "subscriptionStatusUrlVersion" => BetaGroupsGetCollectionFieldsApp.SubscriptionStatusUrlVersion,
                "subscriptionStatusUrlVersionForSandbox" => BetaGroupsGetCollectionFieldsApp.SubscriptionStatusUrlVersionForSandbox,
                "webhooks" => BetaGroupsGetCollectionFieldsApp.Webhooks,
                _ => null,
            };
        }
    }
}