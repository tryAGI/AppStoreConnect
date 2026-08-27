
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsAppClipsGetToManyRelatedFieldsApp
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
    public static class AppsAppClipsGetToManyRelatedFieldsAppExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsAppClipsGetToManyRelatedFieldsApp value)
        {
            return value switch
            {
                AppsAppClipsGetToManyRelatedFieldsApp.AccessibilityDeclarations => "accessibilityDeclarations",
                AppsAppClipsGetToManyRelatedFieldsApp.AccessibilityUrl => "accessibilityUrl",
                AppsAppClipsGetToManyRelatedFieldsApp.AlternativeDistributionKey => "alternativeDistributionKey",
                AppsAppClipsGetToManyRelatedFieldsApp.AnalyticsReportRequests => "analyticsReportRequests",
                AppsAppClipsGetToManyRelatedFieldsApp.AndroidToIosAppMappingDetails => "androidToIosAppMappingDetails",
                AppsAppClipsGetToManyRelatedFieldsApp.AppAvailabilityV2 => "appAvailabilityV2",
                AppsAppClipsGetToManyRelatedFieldsApp.AppClips => "appClips",
                AppsAppClipsGetToManyRelatedFieldsApp.AppCustomProductPages => "appCustomProductPages",
                AppsAppClipsGetToManyRelatedFieldsApp.AppEncryptionDeclarations => "appEncryptionDeclarations",
                AppsAppClipsGetToManyRelatedFieldsApp.AppEvents => "appEvents",
                AppsAppClipsGetToManyRelatedFieldsApp.AppInfos => "appInfos",
                AppsAppClipsGetToManyRelatedFieldsApp.AppPricePoints => "appPricePoints",
                AppsAppClipsGetToManyRelatedFieldsApp.AppPriceSchedule => "appPriceSchedule",
                AppsAppClipsGetToManyRelatedFieldsApp.AppStoreIcon => "appStoreIcon",
                AppsAppClipsGetToManyRelatedFieldsApp.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                AppsAppClipsGetToManyRelatedFieldsApp.AppStoreVersions => "appStoreVersions",
                AppsAppClipsGetToManyRelatedFieldsApp.AppTags => "appTags",
                AppsAppClipsGetToManyRelatedFieldsApp.BackgroundAssets => "backgroundAssets",
                AppsAppClipsGetToManyRelatedFieldsApp.BetaAppLocalizations => "betaAppLocalizations",
                AppsAppClipsGetToManyRelatedFieldsApp.BetaAppReviewDetail => "betaAppReviewDetail",
                AppsAppClipsGetToManyRelatedFieldsApp.BetaFeedbackCrashSubmissions => "betaFeedbackCrashSubmissions",
                AppsAppClipsGetToManyRelatedFieldsApp.BetaFeedbackScreenshotSubmissions => "betaFeedbackScreenshotSubmissions",
                AppsAppClipsGetToManyRelatedFieldsApp.BetaGroups => "betaGroups",
                AppsAppClipsGetToManyRelatedFieldsApp.BetaLicenseAgreement => "betaLicenseAgreement",
                AppsAppClipsGetToManyRelatedFieldsApp.BetaTesters => "betaTesters",
                AppsAppClipsGetToManyRelatedFieldsApp.BuildUploads => "buildUploads",
                AppsAppClipsGetToManyRelatedFieldsApp.Builds => "builds",
                AppsAppClipsGetToManyRelatedFieldsApp.BundleId => "bundleId",
                AppsAppClipsGetToManyRelatedFieldsApp.CiProduct => "ciProduct",
                AppsAppClipsGetToManyRelatedFieldsApp.ContentRightsDeclaration => "contentRightsDeclaration",
                AppsAppClipsGetToManyRelatedFieldsApp.CustomerReviewSummarizations => "customerReviewSummarizations",
                AppsAppClipsGetToManyRelatedFieldsApp.CustomerReviews => "customerReviews",
                AppsAppClipsGetToManyRelatedFieldsApp.EndUserLicenseAgreement => "endUserLicenseAgreement",
                AppsAppClipsGetToManyRelatedFieldsApp.GameCenterDetail => "gameCenterDetail",
                AppsAppClipsGetToManyRelatedFieldsApp.GameCenterEnabledVersions => "gameCenterEnabledVersions",
                AppsAppClipsGetToManyRelatedFieldsApp.InAppPurchases => "inAppPurchases",
                AppsAppClipsGetToManyRelatedFieldsApp.InAppPurchasesV2 => "inAppPurchasesV2",
                AppsAppClipsGetToManyRelatedFieldsApp.IsOrEverWasMadeForKids => "isOrEverWasMadeForKids",
                AppsAppClipsGetToManyRelatedFieldsApp.MarketplaceSearchDetail => "marketplaceSearchDetail",
                AppsAppClipsGetToManyRelatedFieldsApp.Name => "name",
                AppsAppClipsGetToManyRelatedFieldsApp.PerfPowerMetrics => "perfPowerMetrics",
                AppsAppClipsGetToManyRelatedFieldsApp.PreReleaseVersions => "preReleaseVersions",
                AppsAppClipsGetToManyRelatedFieldsApp.PrimaryLocale => "primaryLocale",
                AppsAppClipsGetToManyRelatedFieldsApp.PromotedPurchases => "promotedPurchases",
                AppsAppClipsGetToManyRelatedFieldsApp.ReviewSubmissions => "reviewSubmissions",
                AppsAppClipsGetToManyRelatedFieldsApp.SearchKeywords => "searchKeywords",
                AppsAppClipsGetToManyRelatedFieldsApp.Sku => "sku",
                AppsAppClipsGetToManyRelatedFieldsApp.StreamlinedPurchasingEnabled => "streamlinedPurchasingEnabled",
                AppsAppClipsGetToManyRelatedFieldsApp.SubscriptionGracePeriod => "subscriptionGracePeriod",
                AppsAppClipsGetToManyRelatedFieldsApp.SubscriptionGroups => "subscriptionGroups",
                AppsAppClipsGetToManyRelatedFieldsApp.SubscriptionStatusUrl => "subscriptionStatusUrl",
                AppsAppClipsGetToManyRelatedFieldsApp.SubscriptionStatusUrlForSandbox => "subscriptionStatusUrlForSandbox",
                AppsAppClipsGetToManyRelatedFieldsApp.SubscriptionStatusUrlVersion => "subscriptionStatusUrlVersion",
                AppsAppClipsGetToManyRelatedFieldsApp.SubscriptionStatusUrlVersionForSandbox => "subscriptionStatusUrlVersionForSandbox",
                AppsAppClipsGetToManyRelatedFieldsApp.Webhooks => "webhooks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsAppClipsGetToManyRelatedFieldsApp? ToEnum(string value)
        {
            return value switch
            {
                "accessibilityDeclarations" => AppsAppClipsGetToManyRelatedFieldsApp.AccessibilityDeclarations,
                "accessibilityUrl" => AppsAppClipsGetToManyRelatedFieldsApp.AccessibilityUrl,
                "alternativeDistributionKey" => AppsAppClipsGetToManyRelatedFieldsApp.AlternativeDistributionKey,
                "analyticsReportRequests" => AppsAppClipsGetToManyRelatedFieldsApp.AnalyticsReportRequests,
                "androidToIosAppMappingDetails" => AppsAppClipsGetToManyRelatedFieldsApp.AndroidToIosAppMappingDetails,
                "appAvailabilityV2" => AppsAppClipsGetToManyRelatedFieldsApp.AppAvailabilityV2,
                "appClips" => AppsAppClipsGetToManyRelatedFieldsApp.AppClips,
                "appCustomProductPages" => AppsAppClipsGetToManyRelatedFieldsApp.AppCustomProductPages,
                "appEncryptionDeclarations" => AppsAppClipsGetToManyRelatedFieldsApp.AppEncryptionDeclarations,
                "appEvents" => AppsAppClipsGetToManyRelatedFieldsApp.AppEvents,
                "appInfos" => AppsAppClipsGetToManyRelatedFieldsApp.AppInfos,
                "appPricePoints" => AppsAppClipsGetToManyRelatedFieldsApp.AppPricePoints,
                "appPriceSchedule" => AppsAppClipsGetToManyRelatedFieldsApp.AppPriceSchedule,
                "appStoreIcon" => AppsAppClipsGetToManyRelatedFieldsApp.AppStoreIcon,
                "appStoreVersionExperimentsV2" => AppsAppClipsGetToManyRelatedFieldsApp.AppStoreVersionExperimentsV2,
                "appStoreVersions" => AppsAppClipsGetToManyRelatedFieldsApp.AppStoreVersions,
                "appTags" => AppsAppClipsGetToManyRelatedFieldsApp.AppTags,
                "backgroundAssets" => AppsAppClipsGetToManyRelatedFieldsApp.BackgroundAssets,
                "betaAppLocalizations" => AppsAppClipsGetToManyRelatedFieldsApp.BetaAppLocalizations,
                "betaAppReviewDetail" => AppsAppClipsGetToManyRelatedFieldsApp.BetaAppReviewDetail,
                "betaFeedbackCrashSubmissions" => AppsAppClipsGetToManyRelatedFieldsApp.BetaFeedbackCrashSubmissions,
                "betaFeedbackScreenshotSubmissions" => AppsAppClipsGetToManyRelatedFieldsApp.BetaFeedbackScreenshotSubmissions,
                "betaGroups" => AppsAppClipsGetToManyRelatedFieldsApp.BetaGroups,
                "betaLicenseAgreement" => AppsAppClipsGetToManyRelatedFieldsApp.BetaLicenseAgreement,
                "betaTesters" => AppsAppClipsGetToManyRelatedFieldsApp.BetaTesters,
                "buildUploads" => AppsAppClipsGetToManyRelatedFieldsApp.BuildUploads,
                "builds" => AppsAppClipsGetToManyRelatedFieldsApp.Builds,
                "bundleId" => AppsAppClipsGetToManyRelatedFieldsApp.BundleId,
                "ciProduct" => AppsAppClipsGetToManyRelatedFieldsApp.CiProduct,
                "contentRightsDeclaration" => AppsAppClipsGetToManyRelatedFieldsApp.ContentRightsDeclaration,
                "customerReviewSummarizations" => AppsAppClipsGetToManyRelatedFieldsApp.CustomerReviewSummarizations,
                "customerReviews" => AppsAppClipsGetToManyRelatedFieldsApp.CustomerReviews,
                "endUserLicenseAgreement" => AppsAppClipsGetToManyRelatedFieldsApp.EndUserLicenseAgreement,
                "gameCenterDetail" => AppsAppClipsGetToManyRelatedFieldsApp.GameCenterDetail,
                "gameCenterEnabledVersions" => AppsAppClipsGetToManyRelatedFieldsApp.GameCenterEnabledVersions,
                "inAppPurchases" => AppsAppClipsGetToManyRelatedFieldsApp.InAppPurchases,
                "inAppPurchasesV2" => AppsAppClipsGetToManyRelatedFieldsApp.InAppPurchasesV2,
                "isOrEverWasMadeForKids" => AppsAppClipsGetToManyRelatedFieldsApp.IsOrEverWasMadeForKids,
                "marketplaceSearchDetail" => AppsAppClipsGetToManyRelatedFieldsApp.MarketplaceSearchDetail,
                "name" => AppsAppClipsGetToManyRelatedFieldsApp.Name,
                "perfPowerMetrics" => AppsAppClipsGetToManyRelatedFieldsApp.PerfPowerMetrics,
                "preReleaseVersions" => AppsAppClipsGetToManyRelatedFieldsApp.PreReleaseVersions,
                "primaryLocale" => AppsAppClipsGetToManyRelatedFieldsApp.PrimaryLocale,
                "promotedPurchases" => AppsAppClipsGetToManyRelatedFieldsApp.PromotedPurchases,
                "reviewSubmissions" => AppsAppClipsGetToManyRelatedFieldsApp.ReviewSubmissions,
                "searchKeywords" => AppsAppClipsGetToManyRelatedFieldsApp.SearchKeywords,
                "sku" => AppsAppClipsGetToManyRelatedFieldsApp.Sku,
                "streamlinedPurchasingEnabled" => AppsAppClipsGetToManyRelatedFieldsApp.StreamlinedPurchasingEnabled,
                "subscriptionGracePeriod" => AppsAppClipsGetToManyRelatedFieldsApp.SubscriptionGracePeriod,
                "subscriptionGroups" => AppsAppClipsGetToManyRelatedFieldsApp.SubscriptionGroups,
                "subscriptionStatusUrl" => AppsAppClipsGetToManyRelatedFieldsApp.SubscriptionStatusUrl,
                "subscriptionStatusUrlForSandbox" => AppsAppClipsGetToManyRelatedFieldsApp.SubscriptionStatusUrlForSandbox,
                "subscriptionStatusUrlVersion" => AppsAppClipsGetToManyRelatedFieldsApp.SubscriptionStatusUrlVersion,
                "subscriptionStatusUrlVersionForSandbox" => AppsAppClipsGetToManyRelatedFieldsApp.SubscriptionStatusUrlVersionForSandbox,
                "webhooks" => AppsAppClipsGetToManyRelatedFieldsApp.Webhooks,
                _ => null,
            };
        }
    }
}