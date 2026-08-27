
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum UsersVisibleAppsGetToManyRelatedFieldsApp
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
    public static class UsersVisibleAppsGetToManyRelatedFieldsAppExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsersVisibleAppsGetToManyRelatedFieldsApp value)
        {
            return value switch
            {
                UsersVisibleAppsGetToManyRelatedFieldsApp.AccessibilityDeclarations => "accessibilityDeclarations",
                UsersVisibleAppsGetToManyRelatedFieldsApp.AccessibilityUrl => "accessibilityUrl",
                UsersVisibleAppsGetToManyRelatedFieldsApp.AlternativeDistributionKey => "alternativeDistributionKey",
                UsersVisibleAppsGetToManyRelatedFieldsApp.AnalyticsReportRequests => "analyticsReportRequests",
                UsersVisibleAppsGetToManyRelatedFieldsApp.AndroidToIosAppMappingDetails => "androidToIosAppMappingDetails",
                UsersVisibleAppsGetToManyRelatedFieldsApp.AppAvailabilityV2 => "appAvailabilityV2",
                UsersVisibleAppsGetToManyRelatedFieldsApp.AppClips => "appClips",
                UsersVisibleAppsGetToManyRelatedFieldsApp.AppCustomProductPages => "appCustomProductPages",
                UsersVisibleAppsGetToManyRelatedFieldsApp.AppEncryptionDeclarations => "appEncryptionDeclarations",
                UsersVisibleAppsGetToManyRelatedFieldsApp.AppEvents => "appEvents",
                UsersVisibleAppsGetToManyRelatedFieldsApp.AppInfos => "appInfos",
                UsersVisibleAppsGetToManyRelatedFieldsApp.AppPricePoints => "appPricePoints",
                UsersVisibleAppsGetToManyRelatedFieldsApp.AppPriceSchedule => "appPriceSchedule",
                UsersVisibleAppsGetToManyRelatedFieldsApp.AppStoreIcon => "appStoreIcon",
                UsersVisibleAppsGetToManyRelatedFieldsApp.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                UsersVisibleAppsGetToManyRelatedFieldsApp.AppStoreVersions => "appStoreVersions",
                UsersVisibleAppsGetToManyRelatedFieldsApp.AppTags => "appTags",
                UsersVisibleAppsGetToManyRelatedFieldsApp.BackgroundAssets => "backgroundAssets",
                UsersVisibleAppsGetToManyRelatedFieldsApp.BetaAppLocalizations => "betaAppLocalizations",
                UsersVisibleAppsGetToManyRelatedFieldsApp.BetaAppReviewDetail => "betaAppReviewDetail",
                UsersVisibleAppsGetToManyRelatedFieldsApp.BetaFeedbackCrashSubmissions => "betaFeedbackCrashSubmissions",
                UsersVisibleAppsGetToManyRelatedFieldsApp.BetaFeedbackScreenshotSubmissions => "betaFeedbackScreenshotSubmissions",
                UsersVisibleAppsGetToManyRelatedFieldsApp.BetaGroups => "betaGroups",
                UsersVisibleAppsGetToManyRelatedFieldsApp.BetaLicenseAgreement => "betaLicenseAgreement",
                UsersVisibleAppsGetToManyRelatedFieldsApp.BetaTesters => "betaTesters",
                UsersVisibleAppsGetToManyRelatedFieldsApp.BuildUploads => "buildUploads",
                UsersVisibleAppsGetToManyRelatedFieldsApp.Builds => "builds",
                UsersVisibleAppsGetToManyRelatedFieldsApp.BundleId => "bundleId",
                UsersVisibleAppsGetToManyRelatedFieldsApp.CiProduct => "ciProduct",
                UsersVisibleAppsGetToManyRelatedFieldsApp.ContentRightsDeclaration => "contentRightsDeclaration",
                UsersVisibleAppsGetToManyRelatedFieldsApp.CustomerReviewSummarizations => "customerReviewSummarizations",
                UsersVisibleAppsGetToManyRelatedFieldsApp.CustomerReviews => "customerReviews",
                UsersVisibleAppsGetToManyRelatedFieldsApp.EndUserLicenseAgreement => "endUserLicenseAgreement",
                UsersVisibleAppsGetToManyRelatedFieldsApp.GameCenterDetail => "gameCenterDetail",
                UsersVisibleAppsGetToManyRelatedFieldsApp.GameCenterEnabledVersions => "gameCenterEnabledVersions",
                UsersVisibleAppsGetToManyRelatedFieldsApp.InAppPurchases => "inAppPurchases",
                UsersVisibleAppsGetToManyRelatedFieldsApp.InAppPurchasesV2 => "inAppPurchasesV2",
                UsersVisibleAppsGetToManyRelatedFieldsApp.IsOrEverWasMadeForKids => "isOrEverWasMadeForKids",
                UsersVisibleAppsGetToManyRelatedFieldsApp.MarketplaceSearchDetail => "marketplaceSearchDetail",
                UsersVisibleAppsGetToManyRelatedFieldsApp.Name => "name",
                UsersVisibleAppsGetToManyRelatedFieldsApp.PerfPowerMetrics => "perfPowerMetrics",
                UsersVisibleAppsGetToManyRelatedFieldsApp.PreReleaseVersions => "preReleaseVersions",
                UsersVisibleAppsGetToManyRelatedFieldsApp.PrimaryLocale => "primaryLocale",
                UsersVisibleAppsGetToManyRelatedFieldsApp.PromotedPurchases => "promotedPurchases",
                UsersVisibleAppsGetToManyRelatedFieldsApp.ReviewSubmissions => "reviewSubmissions",
                UsersVisibleAppsGetToManyRelatedFieldsApp.SearchKeywords => "searchKeywords",
                UsersVisibleAppsGetToManyRelatedFieldsApp.Sku => "sku",
                UsersVisibleAppsGetToManyRelatedFieldsApp.StreamlinedPurchasingEnabled => "streamlinedPurchasingEnabled",
                UsersVisibleAppsGetToManyRelatedFieldsApp.SubscriptionGracePeriod => "subscriptionGracePeriod",
                UsersVisibleAppsGetToManyRelatedFieldsApp.SubscriptionGroups => "subscriptionGroups",
                UsersVisibleAppsGetToManyRelatedFieldsApp.SubscriptionStatusUrl => "subscriptionStatusUrl",
                UsersVisibleAppsGetToManyRelatedFieldsApp.SubscriptionStatusUrlForSandbox => "subscriptionStatusUrlForSandbox",
                UsersVisibleAppsGetToManyRelatedFieldsApp.SubscriptionStatusUrlVersion => "subscriptionStatusUrlVersion",
                UsersVisibleAppsGetToManyRelatedFieldsApp.SubscriptionStatusUrlVersionForSandbox => "subscriptionStatusUrlVersionForSandbox",
                UsersVisibleAppsGetToManyRelatedFieldsApp.Webhooks => "webhooks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsersVisibleAppsGetToManyRelatedFieldsApp? ToEnum(string value)
        {
            return value switch
            {
                "accessibilityDeclarations" => UsersVisibleAppsGetToManyRelatedFieldsApp.AccessibilityDeclarations,
                "accessibilityUrl" => UsersVisibleAppsGetToManyRelatedFieldsApp.AccessibilityUrl,
                "alternativeDistributionKey" => UsersVisibleAppsGetToManyRelatedFieldsApp.AlternativeDistributionKey,
                "analyticsReportRequests" => UsersVisibleAppsGetToManyRelatedFieldsApp.AnalyticsReportRequests,
                "androidToIosAppMappingDetails" => UsersVisibleAppsGetToManyRelatedFieldsApp.AndroidToIosAppMappingDetails,
                "appAvailabilityV2" => UsersVisibleAppsGetToManyRelatedFieldsApp.AppAvailabilityV2,
                "appClips" => UsersVisibleAppsGetToManyRelatedFieldsApp.AppClips,
                "appCustomProductPages" => UsersVisibleAppsGetToManyRelatedFieldsApp.AppCustomProductPages,
                "appEncryptionDeclarations" => UsersVisibleAppsGetToManyRelatedFieldsApp.AppEncryptionDeclarations,
                "appEvents" => UsersVisibleAppsGetToManyRelatedFieldsApp.AppEvents,
                "appInfos" => UsersVisibleAppsGetToManyRelatedFieldsApp.AppInfos,
                "appPricePoints" => UsersVisibleAppsGetToManyRelatedFieldsApp.AppPricePoints,
                "appPriceSchedule" => UsersVisibleAppsGetToManyRelatedFieldsApp.AppPriceSchedule,
                "appStoreIcon" => UsersVisibleAppsGetToManyRelatedFieldsApp.AppStoreIcon,
                "appStoreVersionExperimentsV2" => UsersVisibleAppsGetToManyRelatedFieldsApp.AppStoreVersionExperimentsV2,
                "appStoreVersions" => UsersVisibleAppsGetToManyRelatedFieldsApp.AppStoreVersions,
                "appTags" => UsersVisibleAppsGetToManyRelatedFieldsApp.AppTags,
                "backgroundAssets" => UsersVisibleAppsGetToManyRelatedFieldsApp.BackgroundAssets,
                "betaAppLocalizations" => UsersVisibleAppsGetToManyRelatedFieldsApp.BetaAppLocalizations,
                "betaAppReviewDetail" => UsersVisibleAppsGetToManyRelatedFieldsApp.BetaAppReviewDetail,
                "betaFeedbackCrashSubmissions" => UsersVisibleAppsGetToManyRelatedFieldsApp.BetaFeedbackCrashSubmissions,
                "betaFeedbackScreenshotSubmissions" => UsersVisibleAppsGetToManyRelatedFieldsApp.BetaFeedbackScreenshotSubmissions,
                "betaGroups" => UsersVisibleAppsGetToManyRelatedFieldsApp.BetaGroups,
                "betaLicenseAgreement" => UsersVisibleAppsGetToManyRelatedFieldsApp.BetaLicenseAgreement,
                "betaTesters" => UsersVisibleAppsGetToManyRelatedFieldsApp.BetaTesters,
                "buildUploads" => UsersVisibleAppsGetToManyRelatedFieldsApp.BuildUploads,
                "builds" => UsersVisibleAppsGetToManyRelatedFieldsApp.Builds,
                "bundleId" => UsersVisibleAppsGetToManyRelatedFieldsApp.BundleId,
                "ciProduct" => UsersVisibleAppsGetToManyRelatedFieldsApp.CiProduct,
                "contentRightsDeclaration" => UsersVisibleAppsGetToManyRelatedFieldsApp.ContentRightsDeclaration,
                "customerReviewSummarizations" => UsersVisibleAppsGetToManyRelatedFieldsApp.CustomerReviewSummarizations,
                "customerReviews" => UsersVisibleAppsGetToManyRelatedFieldsApp.CustomerReviews,
                "endUserLicenseAgreement" => UsersVisibleAppsGetToManyRelatedFieldsApp.EndUserLicenseAgreement,
                "gameCenterDetail" => UsersVisibleAppsGetToManyRelatedFieldsApp.GameCenterDetail,
                "gameCenterEnabledVersions" => UsersVisibleAppsGetToManyRelatedFieldsApp.GameCenterEnabledVersions,
                "inAppPurchases" => UsersVisibleAppsGetToManyRelatedFieldsApp.InAppPurchases,
                "inAppPurchasesV2" => UsersVisibleAppsGetToManyRelatedFieldsApp.InAppPurchasesV2,
                "isOrEverWasMadeForKids" => UsersVisibleAppsGetToManyRelatedFieldsApp.IsOrEverWasMadeForKids,
                "marketplaceSearchDetail" => UsersVisibleAppsGetToManyRelatedFieldsApp.MarketplaceSearchDetail,
                "name" => UsersVisibleAppsGetToManyRelatedFieldsApp.Name,
                "perfPowerMetrics" => UsersVisibleAppsGetToManyRelatedFieldsApp.PerfPowerMetrics,
                "preReleaseVersions" => UsersVisibleAppsGetToManyRelatedFieldsApp.PreReleaseVersions,
                "primaryLocale" => UsersVisibleAppsGetToManyRelatedFieldsApp.PrimaryLocale,
                "promotedPurchases" => UsersVisibleAppsGetToManyRelatedFieldsApp.PromotedPurchases,
                "reviewSubmissions" => UsersVisibleAppsGetToManyRelatedFieldsApp.ReviewSubmissions,
                "searchKeywords" => UsersVisibleAppsGetToManyRelatedFieldsApp.SearchKeywords,
                "sku" => UsersVisibleAppsGetToManyRelatedFieldsApp.Sku,
                "streamlinedPurchasingEnabled" => UsersVisibleAppsGetToManyRelatedFieldsApp.StreamlinedPurchasingEnabled,
                "subscriptionGracePeriod" => UsersVisibleAppsGetToManyRelatedFieldsApp.SubscriptionGracePeriod,
                "subscriptionGroups" => UsersVisibleAppsGetToManyRelatedFieldsApp.SubscriptionGroups,
                "subscriptionStatusUrl" => UsersVisibleAppsGetToManyRelatedFieldsApp.SubscriptionStatusUrl,
                "subscriptionStatusUrlForSandbox" => UsersVisibleAppsGetToManyRelatedFieldsApp.SubscriptionStatusUrlForSandbox,
                "subscriptionStatusUrlVersion" => UsersVisibleAppsGetToManyRelatedFieldsApp.SubscriptionStatusUrlVersion,
                "subscriptionStatusUrlVersionForSandbox" => UsersVisibleAppsGetToManyRelatedFieldsApp.SubscriptionStatusUrlVersionForSandbox,
                "webhooks" => UsersVisibleAppsGetToManyRelatedFieldsApp.Webhooks,
                _ => null,
            };
        }
    }
}