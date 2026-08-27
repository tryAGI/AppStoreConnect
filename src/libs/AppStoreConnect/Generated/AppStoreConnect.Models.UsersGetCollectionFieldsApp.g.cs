
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum UsersGetCollectionFieldsApp
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
    public static class UsersGetCollectionFieldsAppExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsersGetCollectionFieldsApp value)
        {
            return value switch
            {
                UsersGetCollectionFieldsApp.AccessibilityDeclarations => "accessibilityDeclarations",
                UsersGetCollectionFieldsApp.AccessibilityUrl => "accessibilityUrl",
                UsersGetCollectionFieldsApp.AlternativeDistributionKey => "alternativeDistributionKey",
                UsersGetCollectionFieldsApp.AnalyticsReportRequests => "analyticsReportRequests",
                UsersGetCollectionFieldsApp.AndroidToIosAppMappingDetails => "androidToIosAppMappingDetails",
                UsersGetCollectionFieldsApp.AppAvailabilityV2 => "appAvailabilityV2",
                UsersGetCollectionFieldsApp.AppClips => "appClips",
                UsersGetCollectionFieldsApp.AppCustomProductPages => "appCustomProductPages",
                UsersGetCollectionFieldsApp.AppEncryptionDeclarations => "appEncryptionDeclarations",
                UsersGetCollectionFieldsApp.AppEvents => "appEvents",
                UsersGetCollectionFieldsApp.AppInfos => "appInfos",
                UsersGetCollectionFieldsApp.AppPricePoints => "appPricePoints",
                UsersGetCollectionFieldsApp.AppPriceSchedule => "appPriceSchedule",
                UsersGetCollectionFieldsApp.AppStoreIcon => "appStoreIcon",
                UsersGetCollectionFieldsApp.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                UsersGetCollectionFieldsApp.AppStoreVersions => "appStoreVersions",
                UsersGetCollectionFieldsApp.AppTags => "appTags",
                UsersGetCollectionFieldsApp.BackgroundAssets => "backgroundAssets",
                UsersGetCollectionFieldsApp.BetaAppLocalizations => "betaAppLocalizations",
                UsersGetCollectionFieldsApp.BetaAppReviewDetail => "betaAppReviewDetail",
                UsersGetCollectionFieldsApp.BetaFeedbackCrashSubmissions => "betaFeedbackCrashSubmissions",
                UsersGetCollectionFieldsApp.BetaFeedbackScreenshotSubmissions => "betaFeedbackScreenshotSubmissions",
                UsersGetCollectionFieldsApp.BetaGroups => "betaGroups",
                UsersGetCollectionFieldsApp.BetaLicenseAgreement => "betaLicenseAgreement",
                UsersGetCollectionFieldsApp.BetaTesters => "betaTesters",
                UsersGetCollectionFieldsApp.BuildUploads => "buildUploads",
                UsersGetCollectionFieldsApp.Builds => "builds",
                UsersGetCollectionFieldsApp.BundleId => "bundleId",
                UsersGetCollectionFieldsApp.CiProduct => "ciProduct",
                UsersGetCollectionFieldsApp.ContentRightsDeclaration => "contentRightsDeclaration",
                UsersGetCollectionFieldsApp.CustomerReviewSummarizations => "customerReviewSummarizations",
                UsersGetCollectionFieldsApp.CustomerReviews => "customerReviews",
                UsersGetCollectionFieldsApp.EndUserLicenseAgreement => "endUserLicenseAgreement",
                UsersGetCollectionFieldsApp.GameCenterDetail => "gameCenterDetail",
                UsersGetCollectionFieldsApp.GameCenterEnabledVersions => "gameCenterEnabledVersions",
                UsersGetCollectionFieldsApp.InAppPurchases => "inAppPurchases",
                UsersGetCollectionFieldsApp.InAppPurchasesV2 => "inAppPurchasesV2",
                UsersGetCollectionFieldsApp.IsOrEverWasMadeForKids => "isOrEverWasMadeForKids",
                UsersGetCollectionFieldsApp.MarketplaceSearchDetail => "marketplaceSearchDetail",
                UsersGetCollectionFieldsApp.Name => "name",
                UsersGetCollectionFieldsApp.PerfPowerMetrics => "perfPowerMetrics",
                UsersGetCollectionFieldsApp.PreReleaseVersions => "preReleaseVersions",
                UsersGetCollectionFieldsApp.PrimaryLocale => "primaryLocale",
                UsersGetCollectionFieldsApp.PromotedPurchases => "promotedPurchases",
                UsersGetCollectionFieldsApp.ReviewSubmissions => "reviewSubmissions",
                UsersGetCollectionFieldsApp.SearchKeywords => "searchKeywords",
                UsersGetCollectionFieldsApp.Sku => "sku",
                UsersGetCollectionFieldsApp.StreamlinedPurchasingEnabled => "streamlinedPurchasingEnabled",
                UsersGetCollectionFieldsApp.SubscriptionGracePeriod => "subscriptionGracePeriod",
                UsersGetCollectionFieldsApp.SubscriptionGroups => "subscriptionGroups",
                UsersGetCollectionFieldsApp.SubscriptionStatusUrl => "subscriptionStatusUrl",
                UsersGetCollectionFieldsApp.SubscriptionStatusUrlForSandbox => "subscriptionStatusUrlForSandbox",
                UsersGetCollectionFieldsApp.SubscriptionStatusUrlVersion => "subscriptionStatusUrlVersion",
                UsersGetCollectionFieldsApp.SubscriptionStatusUrlVersionForSandbox => "subscriptionStatusUrlVersionForSandbox",
                UsersGetCollectionFieldsApp.Webhooks => "webhooks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsersGetCollectionFieldsApp? ToEnum(string value)
        {
            return value switch
            {
                "accessibilityDeclarations" => UsersGetCollectionFieldsApp.AccessibilityDeclarations,
                "accessibilityUrl" => UsersGetCollectionFieldsApp.AccessibilityUrl,
                "alternativeDistributionKey" => UsersGetCollectionFieldsApp.AlternativeDistributionKey,
                "analyticsReportRequests" => UsersGetCollectionFieldsApp.AnalyticsReportRequests,
                "androidToIosAppMappingDetails" => UsersGetCollectionFieldsApp.AndroidToIosAppMappingDetails,
                "appAvailabilityV2" => UsersGetCollectionFieldsApp.AppAvailabilityV2,
                "appClips" => UsersGetCollectionFieldsApp.AppClips,
                "appCustomProductPages" => UsersGetCollectionFieldsApp.AppCustomProductPages,
                "appEncryptionDeclarations" => UsersGetCollectionFieldsApp.AppEncryptionDeclarations,
                "appEvents" => UsersGetCollectionFieldsApp.AppEvents,
                "appInfos" => UsersGetCollectionFieldsApp.AppInfos,
                "appPricePoints" => UsersGetCollectionFieldsApp.AppPricePoints,
                "appPriceSchedule" => UsersGetCollectionFieldsApp.AppPriceSchedule,
                "appStoreIcon" => UsersGetCollectionFieldsApp.AppStoreIcon,
                "appStoreVersionExperimentsV2" => UsersGetCollectionFieldsApp.AppStoreVersionExperimentsV2,
                "appStoreVersions" => UsersGetCollectionFieldsApp.AppStoreVersions,
                "appTags" => UsersGetCollectionFieldsApp.AppTags,
                "backgroundAssets" => UsersGetCollectionFieldsApp.BackgroundAssets,
                "betaAppLocalizations" => UsersGetCollectionFieldsApp.BetaAppLocalizations,
                "betaAppReviewDetail" => UsersGetCollectionFieldsApp.BetaAppReviewDetail,
                "betaFeedbackCrashSubmissions" => UsersGetCollectionFieldsApp.BetaFeedbackCrashSubmissions,
                "betaFeedbackScreenshotSubmissions" => UsersGetCollectionFieldsApp.BetaFeedbackScreenshotSubmissions,
                "betaGroups" => UsersGetCollectionFieldsApp.BetaGroups,
                "betaLicenseAgreement" => UsersGetCollectionFieldsApp.BetaLicenseAgreement,
                "betaTesters" => UsersGetCollectionFieldsApp.BetaTesters,
                "buildUploads" => UsersGetCollectionFieldsApp.BuildUploads,
                "builds" => UsersGetCollectionFieldsApp.Builds,
                "bundleId" => UsersGetCollectionFieldsApp.BundleId,
                "ciProduct" => UsersGetCollectionFieldsApp.CiProduct,
                "contentRightsDeclaration" => UsersGetCollectionFieldsApp.ContentRightsDeclaration,
                "customerReviewSummarizations" => UsersGetCollectionFieldsApp.CustomerReviewSummarizations,
                "customerReviews" => UsersGetCollectionFieldsApp.CustomerReviews,
                "endUserLicenseAgreement" => UsersGetCollectionFieldsApp.EndUserLicenseAgreement,
                "gameCenterDetail" => UsersGetCollectionFieldsApp.GameCenterDetail,
                "gameCenterEnabledVersions" => UsersGetCollectionFieldsApp.GameCenterEnabledVersions,
                "inAppPurchases" => UsersGetCollectionFieldsApp.InAppPurchases,
                "inAppPurchasesV2" => UsersGetCollectionFieldsApp.InAppPurchasesV2,
                "isOrEverWasMadeForKids" => UsersGetCollectionFieldsApp.IsOrEverWasMadeForKids,
                "marketplaceSearchDetail" => UsersGetCollectionFieldsApp.MarketplaceSearchDetail,
                "name" => UsersGetCollectionFieldsApp.Name,
                "perfPowerMetrics" => UsersGetCollectionFieldsApp.PerfPowerMetrics,
                "preReleaseVersions" => UsersGetCollectionFieldsApp.PreReleaseVersions,
                "primaryLocale" => UsersGetCollectionFieldsApp.PrimaryLocale,
                "promotedPurchases" => UsersGetCollectionFieldsApp.PromotedPurchases,
                "reviewSubmissions" => UsersGetCollectionFieldsApp.ReviewSubmissions,
                "searchKeywords" => UsersGetCollectionFieldsApp.SearchKeywords,
                "sku" => UsersGetCollectionFieldsApp.Sku,
                "streamlinedPurchasingEnabled" => UsersGetCollectionFieldsApp.StreamlinedPurchasingEnabled,
                "subscriptionGracePeriod" => UsersGetCollectionFieldsApp.SubscriptionGracePeriod,
                "subscriptionGroups" => UsersGetCollectionFieldsApp.SubscriptionGroups,
                "subscriptionStatusUrl" => UsersGetCollectionFieldsApp.SubscriptionStatusUrl,
                "subscriptionStatusUrlForSandbox" => UsersGetCollectionFieldsApp.SubscriptionStatusUrlForSandbox,
                "subscriptionStatusUrlVersion" => UsersGetCollectionFieldsApp.SubscriptionStatusUrlVersion,
                "subscriptionStatusUrlVersionForSandbox" => UsersGetCollectionFieldsApp.SubscriptionStatusUrlVersionForSandbox,
                "webhooks" => UsersGetCollectionFieldsApp.Webhooks,
                _ => null,
            };
        }
    }
}