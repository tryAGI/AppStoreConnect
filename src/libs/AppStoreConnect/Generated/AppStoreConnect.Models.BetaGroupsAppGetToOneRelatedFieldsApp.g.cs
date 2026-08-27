
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaGroupsAppGetToOneRelatedFieldsApp
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
    public static class BetaGroupsAppGetToOneRelatedFieldsAppExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaGroupsAppGetToOneRelatedFieldsApp value)
        {
            return value switch
            {
                BetaGroupsAppGetToOneRelatedFieldsApp.AccessibilityDeclarations => "accessibilityDeclarations",
                BetaGroupsAppGetToOneRelatedFieldsApp.AccessibilityUrl => "accessibilityUrl",
                BetaGroupsAppGetToOneRelatedFieldsApp.AlternativeDistributionKey => "alternativeDistributionKey",
                BetaGroupsAppGetToOneRelatedFieldsApp.AnalyticsReportRequests => "analyticsReportRequests",
                BetaGroupsAppGetToOneRelatedFieldsApp.AndroidToIosAppMappingDetails => "androidToIosAppMappingDetails",
                BetaGroupsAppGetToOneRelatedFieldsApp.AppAvailabilityV2 => "appAvailabilityV2",
                BetaGroupsAppGetToOneRelatedFieldsApp.AppClips => "appClips",
                BetaGroupsAppGetToOneRelatedFieldsApp.AppCustomProductPages => "appCustomProductPages",
                BetaGroupsAppGetToOneRelatedFieldsApp.AppEncryptionDeclarations => "appEncryptionDeclarations",
                BetaGroupsAppGetToOneRelatedFieldsApp.AppEvents => "appEvents",
                BetaGroupsAppGetToOneRelatedFieldsApp.AppInfos => "appInfos",
                BetaGroupsAppGetToOneRelatedFieldsApp.AppPricePoints => "appPricePoints",
                BetaGroupsAppGetToOneRelatedFieldsApp.AppPriceSchedule => "appPriceSchedule",
                BetaGroupsAppGetToOneRelatedFieldsApp.AppStoreIcon => "appStoreIcon",
                BetaGroupsAppGetToOneRelatedFieldsApp.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                BetaGroupsAppGetToOneRelatedFieldsApp.AppStoreVersions => "appStoreVersions",
                BetaGroupsAppGetToOneRelatedFieldsApp.AppTags => "appTags",
                BetaGroupsAppGetToOneRelatedFieldsApp.BackgroundAssets => "backgroundAssets",
                BetaGroupsAppGetToOneRelatedFieldsApp.BetaAppLocalizations => "betaAppLocalizations",
                BetaGroupsAppGetToOneRelatedFieldsApp.BetaAppReviewDetail => "betaAppReviewDetail",
                BetaGroupsAppGetToOneRelatedFieldsApp.BetaFeedbackCrashSubmissions => "betaFeedbackCrashSubmissions",
                BetaGroupsAppGetToOneRelatedFieldsApp.BetaFeedbackScreenshotSubmissions => "betaFeedbackScreenshotSubmissions",
                BetaGroupsAppGetToOneRelatedFieldsApp.BetaGroups => "betaGroups",
                BetaGroupsAppGetToOneRelatedFieldsApp.BetaLicenseAgreement => "betaLicenseAgreement",
                BetaGroupsAppGetToOneRelatedFieldsApp.BetaTesters => "betaTesters",
                BetaGroupsAppGetToOneRelatedFieldsApp.BuildUploads => "buildUploads",
                BetaGroupsAppGetToOneRelatedFieldsApp.Builds => "builds",
                BetaGroupsAppGetToOneRelatedFieldsApp.BundleId => "bundleId",
                BetaGroupsAppGetToOneRelatedFieldsApp.CiProduct => "ciProduct",
                BetaGroupsAppGetToOneRelatedFieldsApp.ContentRightsDeclaration => "contentRightsDeclaration",
                BetaGroupsAppGetToOneRelatedFieldsApp.CustomerReviewSummarizations => "customerReviewSummarizations",
                BetaGroupsAppGetToOneRelatedFieldsApp.CustomerReviews => "customerReviews",
                BetaGroupsAppGetToOneRelatedFieldsApp.EndUserLicenseAgreement => "endUserLicenseAgreement",
                BetaGroupsAppGetToOneRelatedFieldsApp.GameCenterDetail => "gameCenterDetail",
                BetaGroupsAppGetToOneRelatedFieldsApp.GameCenterEnabledVersions => "gameCenterEnabledVersions",
                BetaGroupsAppGetToOneRelatedFieldsApp.InAppPurchases => "inAppPurchases",
                BetaGroupsAppGetToOneRelatedFieldsApp.InAppPurchasesV2 => "inAppPurchasesV2",
                BetaGroupsAppGetToOneRelatedFieldsApp.IsOrEverWasMadeForKids => "isOrEverWasMadeForKids",
                BetaGroupsAppGetToOneRelatedFieldsApp.MarketplaceSearchDetail => "marketplaceSearchDetail",
                BetaGroupsAppGetToOneRelatedFieldsApp.Name => "name",
                BetaGroupsAppGetToOneRelatedFieldsApp.PerfPowerMetrics => "perfPowerMetrics",
                BetaGroupsAppGetToOneRelatedFieldsApp.PreReleaseVersions => "preReleaseVersions",
                BetaGroupsAppGetToOneRelatedFieldsApp.PrimaryLocale => "primaryLocale",
                BetaGroupsAppGetToOneRelatedFieldsApp.PromotedPurchases => "promotedPurchases",
                BetaGroupsAppGetToOneRelatedFieldsApp.ReviewSubmissions => "reviewSubmissions",
                BetaGroupsAppGetToOneRelatedFieldsApp.SearchKeywords => "searchKeywords",
                BetaGroupsAppGetToOneRelatedFieldsApp.Sku => "sku",
                BetaGroupsAppGetToOneRelatedFieldsApp.StreamlinedPurchasingEnabled => "streamlinedPurchasingEnabled",
                BetaGroupsAppGetToOneRelatedFieldsApp.SubscriptionGracePeriod => "subscriptionGracePeriod",
                BetaGroupsAppGetToOneRelatedFieldsApp.SubscriptionGroups => "subscriptionGroups",
                BetaGroupsAppGetToOneRelatedFieldsApp.SubscriptionStatusUrl => "subscriptionStatusUrl",
                BetaGroupsAppGetToOneRelatedFieldsApp.SubscriptionStatusUrlForSandbox => "subscriptionStatusUrlForSandbox",
                BetaGroupsAppGetToOneRelatedFieldsApp.SubscriptionStatusUrlVersion => "subscriptionStatusUrlVersion",
                BetaGroupsAppGetToOneRelatedFieldsApp.SubscriptionStatusUrlVersionForSandbox => "subscriptionStatusUrlVersionForSandbox",
                BetaGroupsAppGetToOneRelatedFieldsApp.Webhooks => "webhooks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaGroupsAppGetToOneRelatedFieldsApp? ToEnum(string value)
        {
            return value switch
            {
                "accessibilityDeclarations" => BetaGroupsAppGetToOneRelatedFieldsApp.AccessibilityDeclarations,
                "accessibilityUrl" => BetaGroupsAppGetToOneRelatedFieldsApp.AccessibilityUrl,
                "alternativeDistributionKey" => BetaGroupsAppGetToOneRelatedFieldsApp.AlternativeDistributionKey,
                "analyticsReportRequests" => BetaGroupsAppGetToOneRelatedFieldsApp.AnalyticsReportRequests,
                "androidToIosAppMappingDetails" => BetaGroupsAppGetToOneRelatedFieldsApp.AndroidToIosAppMappingDetails,
                "appAvailabilityV2" => BetaGroupsAppGetToOneRelatedFieldsApp.AppAvailabilityV2,
                "appClips" => BetaGroupsAppGetToOneRelatedFieldsApp.AppClips,
                "appCustomProductPages" => BetaGroupsAppGetToOneRelatedFieldsApp.AppCustomProductPages,
                "appEncryptionDeclarations" => BetaGroupsAppGetToOneRelatedFieldsApp.AppEncryptionDeclarations,
                "appEvents" => BetaGroupsAppGetToOneRelatedFieldsApp.AppEvents,
                "appInfos" => BetaGroupsAppGetToOneRelatedFieldsApp.AppInfos,
                "appPricePoints" => BetaGroupsAppGetToOneRelatedFieldsApp.AppPricePoints,
                "appPriceSchedule" => BetaGroupsAppGetToOneRelatedFieldsApp.AppPriceSchedule,
                "appStoreIcon" => BetaGroupsAppGetToOneRelatedFieldsApp.AppStoreIcon,
                "appStoreVersionExperimentsV2" => BetaGroupsAppGetToOneRelatedFieldsApp.AppStoreVersionExperimentsV2,
                "appStoreVersions" => BetaGroupsAppGetToOneRelatedFieldsApp.AppStoreVersions,
                "appTags" => BetaGroupsAppGetToOneRelatedFieldsApp.AppTags,
                "backgroundAssets" => BetaGroupsAppGetToOneRelatedFieldsApp.BackgroundAssets,
                "betaAppLocalizations" => BetaGroupsAppGetToOneRelatedFieldsApp.BetaAppLocalizations,
                "betaAppReviewDetail" => BetaGroupsAppGetToOneRelatedFieldsApp.BetaAppReviewDetail,
                "betaFeedbackCrashSubmissions" => BetaGroupsAppGetToOneRelatedFieldsApp.BetaFeedbackCrashSubmissions,
                "betaFeedbackScreenshotSubmissions" => BetaGroupsAppGetToOneRelatedFieldsApp.BetaFeedbackScreenshotSubmissions,
                "betaGroups" => BetaGroupsAppGetToOneRelatedFieldsApp.BetaGroups,
                "betaLicenseAgreement" => BetaGroupsAppGetToOneRelatedFieldsApp.BetaLicenseAgreement,
                "betaTesters" => BetaGroupsAppGetToOneRelatedFieldsApp.BetaTesters,
                "buildUploads" => BetaGroupsAppGetToOneRelatedFieldsApp.BuildUploads,
                "builds" => BetaGroupsAppGetToOneRelatedFieldsApp.Builds,
                "bundleId" => BetaGroupsAppGetToOneRelatedFieldsApp.BundleId,
                "ciProduct" => BetaGroupsAppGetToOneRelatedFieldsApp.CiProduct,
                "contentRightsDeclaration" => BetaGroupsAppGetToOneRelatedFieldsApp.ContentRightsDeclaration,
                "customerReviewSummarizations" => BetaGroupsAppGetToOneRelatedFieldsApp.CustomerReviewSummarizations,
                "customerReviews" => BetaGroupsAppGetToOneRelatedFieldsApp.CustomerReviews,
                "endUserLicenseAgreement" => BetaGroupsAppGetToOneRelatedFieldsApp.EndUserLicenseAgreement,
                "gameCenterDetail" => BetaGroupsAppGetToOneRelatedFieldsApp.GameCenterDetail,
                "gameCenterEnabledVersions" => BetaGroupsAppGetToOneRelatedFieldsApp.GameCenterEnabledVersions,
                "inAppPurchases" => BetaGroupsAppGetToOneRelatedFieldsApp.InAppPurchases,
                "inAppPurchasesV2" => BetaGroupsAppGetToOneRelatedFieldsApp.InAppPurchasesV2,
                "isOrEverWasMadeForKids" => BetaGroupsAppGetToOneRelatedFieldsApp.IsOrEverWasMadeForKids,
                "marketplaceSearchDetail" => BetaGroupsAppGetToOneRelatedFieldsApp.MarketplaceSearchDetail,
                "name" => BetaGroupsAppGetToOneRelatedFieldsApp.Name,
                "perfPowerMetrics" => BetaGroupsAppGetToOneRelatedFieldsApp.PerfPowerMetrics,
                "preReleaseVersions" => BetaGroupsAppGetToOneRelatedFieldsApp.PreReleaseVersions,
                "primaryLocale" => BetaGroupsAppGetToOneRelatedFieldsApp.PrimaryLocale,
                "promotedPurchases" => BetaGroupsAppGetToOneRelatedFieldsApp.PromotedPurchases,
                "reviewSubmissions" => BetaGroupsAppGetToOneRelatedFieldsApp.ReviewSubmissions,
                "searchKeywords" => BetaGroupsAppGetToOneRelatedFieldsApp.SearchKeywords,
                "sku" => BetaGroupsAppGetToOneRelatedFieldsApp.Sku,
                "streamlinedPurchasingEnabled" => BetaGroupsAppGetToOneRelatedFieldsApp.StreamlinedPurchasingEnabled,
                "subscriptionGracePeriod" => BetaGroupsAppGetToOneRelatedFieldsApp.SubscriptionGracePeriod,
                "subscriptionGroups" => BetaGroupsAppGetToOneRelatedFieldsApp.SubscriptionGroups,
                "subscriptionStatusUrl" => BetaGroupsAppGetToOneRelatedFieldsApp.SubscriptionStatusUrl,
                "subscriptionStatusUrlForSandbox" => BetaGroupsAppGetToOneRelatedFieldsApp.SubscriptionStatusUrlForSandbox,
                "subscriptionStatusUrlVersion" => BetaGroupsAppGetToOneRelatedFieldsApp.SubscriptionStatusUrlVersion,
                "subscriptionStatusUrlVersionForSandbox" => BetaGroupsAppGetToOneRelatedFieldsApp.SubscriptionStatusUrlVersionForSandbox,
                "webhooks" => BetaGroupsAppGetToOneRelatedFieldsApp.Webhooks,
                _ => null,
            };
        }
    }
}