
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsWebhooksGetToManyRelatedFieldsApp
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
    public static class AppsWebhooksGetToManyRelatedFieldsAppExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsWebhooksGetToManyRelatedFieldsApp value)
        {
            return value switch
            {
                AppsWebhooksGetToManyRelatedFieldsApp.AccessibilityDeclarations => "accessibilityDeclarations",
                AppsWebhooksGetToManyRelatedFieldsApp.AccessibilityUrl => "accessibilityUrl",
                AppsWebhooksGetToManyRelatedFieldsApp.AlternativeDistributionKey => "alternativeDistributionKey",
                AppsWebhooksGetToManyRelatedFieldsApp.AnalyticsReportRequests => "analyticsReportRequests",
                AppsWebhooksGetToManyRelatedFieldsApp.AndroidToIosAppMappingDetails => "androidToIosAppMappingDetails",
                AppsWebhooksGetToManyRelatedFieldsApp.AppAvailabilityV2 => "appAvailabilityV2",
                AppsWebhooksGetToManyRelatedFieldsApp.AppClips => "appClips",
                AppsWebhooksGetToManyRelatedFieldsApp.AppCustomProductPages => "appCustomProductPages",
                AppsWebhooksGetToManyRelatedFieldsApp.AppEncryptionDeclarations => "appEncryptionDeclarations",
                AppsWebhooksGetToManyRelatedFieldsApp.AppEvents => "appEvents",
                AppsWebhooksGetToManyRelatedFieldsApp.AppInfos => "appInfos",
                AppsWebhooksGetToManyRelatedFieldsApp.AppPricePoints => "appPricePoints",
                AppsWebhooksGetToManyRelatedFieldsApp.AppPriceSchedule => "appPriceSchedule",
                AppsWebhooksGetToManyRelatedFieldsApp.AppStoreIcon => "appStoreIcon",
                AppsWebhooksGetToManyRelatedFieldsApp.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                AppsWebhooksGetToManyRelatedFieldsApp.AppStoreVersions => "appStoreVersions",
                AppsWebhooksGetToManyRelatedFieldsApp.AppTags => "appTags",
                AppsWebhooksGetToManyRelatedFieldsApp.BackgroundAssets => "backgroundAssets",
                AppsWebhooksGetToManyRelatedFieldsApp.BetaAppLocalizations => "betaAppLocalizations",
                AppsWebhooksGetToManyRelatedFieldsApp.BetaAppReviewDetail => "betaAppReviewDetail",
                AppsWebhooksGetToManyRelatedFieldsApp.BetaFeedbackCrashSubmissions => "betaFeedbackCrashSubmissions",
                AppsWebhooksGetToManyRelatedFieldsApp.BetaFeedbackScreenshotSubmissions => "betaFeedbackScreenshotSubmissions",
                AppsWebhooksGetToManyRelatedFieldsApp.BetaGroups => "betaGroups",
                AppsWebhooksGetToManyRelatedFieldsApp.BetaLicenseAgreement => "betaLicenseAgreement",
                AppsWebhooksGetToManyRelatedFieldsApp.BetaTesters => "betaTesters",
                AppsWebhooksGetToManyRelatedFieldsApp.BuildUploads => "buildUploads",
                AppsWebhooksGetToManyRelatedFieldsApp.Builds => "builds",
                AppsWebhooksGetToManyRelatedFieldsApp.BundleId => "bundleId",
                AppsWebhooksGetToManyRelatedFieldsApp.CiProduct => "ciProduct",
                AppsWebhooksGetToManyRelatedFieldsApp.ContentRightsDeclaration => "contentRightsDeclaration",
                AppsWebhooksGetToManyRelatedFieldsApp.CustomerReviewSummarizations => "customerReviewSummarizations",
                AppsWebhooksGetToManyRelatedFieldsApp.CustomerReviews => "customerReviews",
                AppsWebhooksGetToManyRelatedFieldsApp.EndUserLicenseAgreement => "endUserLicenseAgreement",
                AppsWebhooksGetToManyRelatedFieldsApp.GameCenterDetail => "gameCenterDetail",
                AppsWebhooksGetToManyRelatedFieldsApp.GameCenterEnabledVersions => "gameCenterEnabledVersions",
                AppsWebhooksGetToManyRelatedFieldsApp.InAppPurchases => "inAppPurchases",
                AppsWebhooksGetToManyRelatedFieldsApp.InAppPurchasesV2 => "inAppPurchasesV2",
                AppsWebhooksGetToManyRelatedFieldsApp.IsOrEverWasMadeForKids => "isOrEverWasMadeForKids",
                AppsWebhooksGetToManyRelatedFieldsApp.MarketplaceSearchDetail => "marketplaceSearchDetail",
                AppsWebhooksGetToManyRelatedFieldsApp.Name => "name",
                AppsWebhooksGetToManyRelatedFieldsApp.PerfPowerMetrics => "perfPowerMetrics",
                AppsWebhooksGetToManyRelatedFieldsApp.PreReleaseVersions => "preReleaseVersions",
                AppsWebhooksGetToManyRelatedFieldsApp.PrimaryLocale => "primaryLocale",
                AppsWebhooksGetToManyRelatedFieldsApp.PromotedPurchases => "promotedPurchases",
                AppsWebhooksGetToManyRelatedFieldsApp.ReviewSubmissions => "reviewSubmissions",
                AppsWebhooksGetToManyRelatedFieldsApp.SearchKeywords => "searchKeywords",
                AppsWebhooksGetToManyRelatedFieldsApp.Sku => "sku",
                AppsWebhooksGetToManyRelatedFieldsApp.StreamlinedPurchasingEnabled => "streamlinedPurchasingEnabled",
                AppsWebhooksGetToManyRelatedFieldsApp.SubscriptionGracePeriod => "subscriptionGracePeriod",
                AppsWebhooksGetToManyRelatedFieldsApp.SubscriptionGroups => "subscriptionGroups",
                AppsWebhooksGetToManyRelatedFieldsApp.SubscriptionStatusUrl => "subscriptionStatusUrl",
                AppsWebhooksGetToManyRelatedFieldsApp.SubscriptionStatusUrlForSandbox => "subscriptionStatusUrlForSandbox",
                AppsWebhooksGetToManyRelatedFieldsApp.SubscriptionStatusUrlVersion => "subscriptionStatusUrlVersion",
                AppsWebhooksGetToManyRelatedFieldsApp.SubscriptionStatusUrlVersionForSandbox => "subscriptionStatusUrlVersionForSandbox",
                AppsWebhooksGetToManyRelatedFieldsApp.Webhooks => "webhooks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsWebhooksGetToManyRelatedFieldsApp? ToEnum(string value)
        {
            return value switch
            {
                "accessibilityDeclarations" => AppsWebhooksGetToManyRelatedFieldsApp.AccessibilityDeclarations,
                "accessibilityUrl" => AppsWebhooksGetToManyRelatedFieldsApp.AccessibilityUrl,
                "alternativeDistributionKey" => AppsWebhooksGetToManyRelatedFieldsApp.AlternativeDistributionKey,
                "analyticsReportRequests" => AppsWebhooksGetToManyRelatedFieldsApp.AnalyticsReportRequests,
                "androidToIosAppMappingDetails" => AppsWebhooksGetToManyRelatedFieldsApp.AndroidToIosAppMappingDetails,
                "appAvailabilityV2" => AppsWebhooksGetToManyRelatedFieldsApp.AppAvailabilityV2,
                "appClips" => AppsWebhooksGetToManyRelatedFieldsApp.AppClips,
                "appCustomProductPages" => AppsWebhooksGetToManyRelatedFieldsApp.AppCustomProductPages,
                "appEncryptionDeclarations" => AppsWebhooksGetToManyRelatedFieldsApp.AppEncryptionDeclarations,
                "appEvents" => AppsWebhooksGetToManyRelatedFieldsApp.AppEvents,
                "appInfos" => AppsWebhooksGetToManyRelatedFieldsApp.AppInfos,
                "appPricePoints" => AppsWebhooksGetToManyRelatedFieldsApp.AppPricePoints,
                "appPriceSchedule" => AppsWebhooksGetToManyRelatedFieldsApp.AppPriceSchedule,
                "appStoreIcon" => AppsWebhooksGetToManyRelatedFieldsApp.AppStoreIcon,
                "appStoreVersionExperimentsV2" => AppsWebhooksGetToManyRelatedFieldsApp.AppStoreVersionExperimentsV2,
                "appStoreVersions" => AppsWebhooksGetToManyRelatedFieldsApp.AppStoreVersions,
                "appTags" => AppsWebhooksGetToManyRelatedFieldsApp.AppTags,
                "backgroundAssets" => AppsWebhooksGetToManyRelatedFieldsApp.BackgroundAssets,
                "betaAppLocalizations" => AppsWebhooksGetToManyRelatedFieldsApp.BetaAppLocalizations,
                "betaAppReviewDetail" => AppsWebhooksGetToManyRelatedFieldsApp.BetaAppReviewDetail,
                "betaFeedbackCrashSubmissions" => AppsWebhooksGetToManyRelatedFieldsApp.BetaFeedbackCrashSubmissions,
                "betaFeedbackScreenshotSubmissions" => AppsWebhooksGetToManyRelatedFieldsApp.BetaFeedbackScreenshotSubmissions,
                "betaGroups" => AppsWebhooksGetToManyRelatedFieldsApp.BetaGroups,
                "betaLicenseAgreement" => AppsWebhooksGetToManyRelatedFieldsApp.BetaLicenseAgreement,
                "betaTesters" => AppsWebhooksGetToManyRelatedFieldsApp.BetaTesters,
                "buildUploads" => AppsWebhooksGetToManyRelatedFieldsApp.BuildUploads,
                "builds" => AppsWebhooksGetToManyRelatedFieldsApp.Builds,
                "bundleId" => AppsWebhooksGetToManyRelatedFieldsApp.BundleId,
                "ciProduct" => AppsWebhooksGetToManyRelatedFieldsApp.CiProduct,
                "contentRightsDeclaration" => AppsWebhooksGetToManyRelatedFieldsApp.ContentRightsDeclaration,
                "customerReviewSummarizations" => AppsWebhooksGetToManyRelatedFieldsApp.CustomerReviewSummarizations,
                "customerReviews" => AppsWebhooksGetToManyRelatedFieldsApp.CustomerReviews,
                "endUserLicenseAgreement" => AppsWebhooksGetToManyRelatedFieldsApp.EndUserLicenseAgreement,
                "gameCenterDetail" => AppsWebhooksGetToManyRelatedFieldsApp.GameCenterDetail,
                "gameCenterEnabledVersions" => AppsWebhooksGetToManyRelatedFieldsApp.GameCenterEnabledVersions,
                "inAppPurchases" => AppsWebhooksGetToManyRelatedFieldsApp.InAppPurchases,
                "inAppPurchasesV2" => AppsWebhooksGetToManyRelatedFieldsApp.InAppPurchasesV2,
                "isOrEverWasMadeForKids" => AppsWebhooksGetToManyRelatedFieldsApp.IsOrEverWasMadeForKids,
                "marketplaceSearchDetail" => AppsWebhooksGetToManyRelatedFieldsApp.MarketplaceSearchDetail,
                "name" => AppsWebhooksGetToManyRelatedFieldsApp.Name,
                "perfPowerMetrics" => AppsWebhooksGetToManyRelatedFieldsApp.PerfPowerMetrics,
                "preReleaseVersions" => AppsWebhooksGetToManyRelatedFieldsApp.PreReleaseVersions,
                "primaryLocale" => AppsWebhooksGetToManyRelatedFieldsApp.PrimaryLocale,
                "promotedPurchases" => AppsWebhooksGetToManyRelatedFieldsApp.PromotedPurchases,
                "reviewSubmissions" => AppsWebhooksGetToManyRelatedFieldsApp.ReviewSubmissions,
                "searchKeywords" => AppsWebhooksGetToManyRelatedFieldsApp.SearchKeywords,
                "sku" => AppsWebhooksGetToManyRelatedFieldsApp.Sku,
                "streamlinedPurchasingEnabled" => AppsWebhooksGetToManyRelatedFieldsApp.StreamlinedPurchasingEnabled,
                "subscriptionGracePeriod" => AppsWebhooksGetToManyRelatedFieldsApp.SubscriptionGracePeriod,
                "subscriptionGroups" => AppsWebhooksGetToManyRelatedFieldsApp.SubscriptionGroups,
                "subscriptionStatusUrl" => AppsWebhooksGetToManyRelatedFieldsApp.SubscriptionStatusUrl,
                "subscriptionStatusUrlForSandbox" => AppsWebhooksGetToManyRelatedFieldsApp.SubscriptionStatusUrlForSandbox,
                "subscriptionStatusUrlVersion" => AppsWebhooksGetToManyRelatedFieldsApp.SubscriptionStatusUrlVersion,
                "subscriptionStatusUrlVersionForSandbox" => AppsWebhooksGetToManyRelatedFieldsApp.SubscriptionStatusUrlVersionForSandbox,
                "webhooks" => AppsWebhooksGetToManyRelatedFieldsApp.Webhooks,
                _ => null,
            };
        }
    }
}