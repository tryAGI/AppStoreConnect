
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum UserInvitationsGetCollectionFieldsApp
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
    public static class UserInvitationsGetCollectionFieldsAppExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserInvitationsGetCollectionFieldsApp value)
        {
            return value switch
            {
                UserInvitationsGetCollectionFieldsApp.AccessibilityDeclarations => "accessibilityDeclarations",
                UserInvitationsGetCollectionFieldsApp.AccessibilityUrl => "accessibilityUrl",
                UserInvitationsGetCollectionFieldsApp.AlternativeDistributionKey => "alternativeDistributionKey",
                UserInvitationsGetCollectionFieldsApp.AnalyticsReportRequests => "analyticsReportRequests",
                UserInvitationsGetCollectionFieldsApp.AndroidToIosAppMappingDetails => "androidToIosAppMappingDetails",
                UserInvitationsGetCollectionFieldsApp.AppAvailabilityV2 => "appAvailabilityV2",
                UserInvitationsGetCollectionFieldsApp.AppClips => "appClips",
                UserInvitationsGetCollectionFieldsApp.AppCustomProductPages => "appCustomProductPages",
                UserInvitationsGetCollectionFieldsApp.AppEncryptionDeclarations => "appEncryptionDeclarations",
                UserInvitationsGetCollectionFieldsApp.AppEvents => "appEvents",
                UserInvitationsGetCollectionFieldsApp.AppInfos => "appInfos",
                UserInvitationsGetCollectionFieldsApp.AppPricePoints => "appPricePoints",
                UserInvitationsGetCollectionFieldsApp.AppPriceSchedule => "appPriceSchedule",
                UserInvitationsGetCollectionFieldsApp.AppStoreIcon => "appStoreIcon",
                UserInvitationsGetCollectionFieldsApp.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                UserInvitationsGetCollectionFieldsApp.AppStoreVersions => "appStoreVersions",
                UserInvitationsGetCollectionFieldsApp.AppTags => "appTags",
                UserInvitationsGetCollectionFieldsApp.BackgroundAssets => "backgroundAssets",
                UserInvitationsGetCollectionFieldsApp.BetaAppLocalizations => "betaAppLocalizations",
                UserInvitationsGetCollectionFieldsApp.BetaAppReviewDetail => "betaAppReviewDetail",
                UserInvitationsGetCollectionFieldsApp.BetaFeedbackCrashSubmissions => "betaFeedbackCrashSubmissions",
                UserInvitationsGetCollectionFieldsApp.BetaFeedbackScreenshotSubmissions => "betaFeedbackScreenshotSubmissions",
                UserInvitationsGetCollectionFieldsApp.BetaGroups => "betaGroups",
                UserInvitationsGetCollectionFieldsApp.BetaLicenseAgreement => "betaLicenseAgreement",
                UserInvitationsGetCollectionFieldsApp.BetaTesters => "betaTesters",
                UserInvitationsGetCollectionFieldsApp.BuildUploads => "buildUploads",
                UserInvitationsGetCollectionFieldsApp.Builds => "builds",
                UserInvitationsGetCollectionFieldsApp.BundleId => "bundleId",
                UserInvitationsGetCollectionFieldsApp.CiProduct => "ciProduct",
                UserInvitationsGetCollectionFieldsApp.ContentRightsDeclaration => "contentRightsDeclaration",
                UserInvitationsGetCollectionFieldsApp.CustomerReviewSummarizations => "customerReviewSummarizations",
                UserInvitationsGetCollectionFieldsApp.CustomerReviews => "customerReviews",
                UserInvitationsGetCollectionFieldsApp.EndUserLicenseAgreement => "endUserLicenseAgreement",
                UserInvitationsGetCollectionFieldsApp.GameCenterDetail => "gameCenterDetail",
                UserInvitationsGetCollectionFieldsApp.GameCenterEnabledVersions => "gameCenterEnabledVersions",
                UserInvitationsGetCollectionFieldsApp.InAppPurchases => "inAppPurchases",
                UserInvitationsGetCollectionFieldsApp.InAppPurchasesV2 => "inAppPurchasesV2",
                UserInvitationsGetCollectionFieldsApp.IsOrEverWasMadeForKids => "isOrEverWasMadeForKids",
                UserInvitationsGetCollectionFieldsApp.MarketplaceSearchDetail => "marketplaceSearchDetail",
                UserInvitationsGetCollectionFieldsApp.Name => "name",
                UserInvitationsGetCollectionFieldsApp.PerfPowerMetrics => "perfPowerMetrics",
                UserInvitationsGetCollectionFieldsApp.PreReleaseVersions => "preReleaseVersions",
                UserInvitationsGetCollectionFieldsApp.PrimaryLocale => "primaryLocale",
                UserInvitationsGetCollectionFieldsApp.PromotedPurchases => "promotedPurchases",
                UserInvitationsGetCollectionFieldsApp.ReviewSubmissions => "reviewSubmissions",
                UserInvitationsGetCollectionFieldsApp.SearchKeywords => "searchKeywords",
                UserInvitationsGetCollectionFieldsApp.Sku => "sku",
                UserInvitationsGetCollectionFieldsApp.StreamlinedPurchasingEnabled => "streamlinedPurchasingEnabled",
                UserInvitationsGetCollectionFieldsApp.SubscriptionGracePeriod => "subscriptionGracePeriod",
                UserInvitationsGetCollectionFieldsApp.SubscriptionGroups => "subscriptionGroups",
                UserInvitationsGetCollectionFieldsApp.SubscriptionStatusUrl => "subscriptionStatusUrl",
                UserInvitationsGetCollectionFieldsApp.SubscriptionStatusUrlForSandbox => "subscriptionStatusUrlForSandbox",
                UserInvitationsGetCollectionFieldsApp.SubscriptionStatusUrlVersion => "subscriptionStatusUrlVersion",
                UserInvitationsGetCollectionFieldsApp.SubscriptionStatusUrlVersionForSandbox => "subscriptionStatusUrlVersionForSandbox",
                UserInvitationsGetCollectionFieldsApp.Webhooks => "webhooks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserInvitationsGetCollectionFieldsApp? ToEnum(string value)
        {
            return value switch
            {
                "accessibilityDeclarations" => UserInvitationsGetCollectionFieldsApp.AccessibilityDeclarations,
                "accessibilityUrl" => UserInvitationsGetCollectionFieldsApp.AccessibilityUrl,
                "alternativeDistributionKey" => UserInvitationsGetCollectionFieldsApp.AlternativeDistributionKey,
                "analyticsReportRequests" => UserInvitationsGetCollectionFieldsApp.AnalyticsReportRequests,
                "androidToIosAppMappingDetails" => UserInvitationsGetCollectionFieldsApp.AndroidToIosAppMappingDetails,
                "appAvailabilityV2" => UserInvitationsGetCollectionFieldsApp.AppAvailabilityV2,
                "appClips" => UserInvitationsGetCollectionFieldsApp.AppClips,
                "appCustomProductPages" => UserInvitationsGetCollectionFieldsApp.AppCustomProductPages,
                "appEncryptionDeclarations" => UserInvitationsGetCollectionFieldsApp.AppEncryptionDeclarations,
                "appEvents" => UserInvitationsGetCollectionFieldsApp.AppEvents,
                "appInfos" => UserInvitationsGetCollectionFieldsApp.AppInfos,
                "appPricePoints" => UserInvitationsGetCollectionFieldsApp.AppPricePoints,
                "appPriceSchedule" => UserInvitationsGetCollectionFieldsApp.AppPriceSchedule,
                "appStoreIcon" => UserInvitationsGetCollectionFieldsApp.AppStoreIcon,
                "appStoreVersionExperimentsV2" => UserInvitationsGetCollectionFieldsApp.AppStoreVersionExperimentsV2,
                "appStoreVersions" => UserInvitationsGetCollectionFieldsApp.AppStoreVersions,
                "appTags" => UserInvitationsGetCollectionFieldsApp.AppTags,
                "backgroundAssets" => UserInvitationsGetCollectionFieldsApp.BackgroundAssets,
                "betaAppLocalizations" => UserInvitationsGetCollectionFieldsApp.BetaAppLocalizations,
                "betaAppReviewDetail" => UserInvitationsGetCollectionFieldsApp.BetaAppReviewDetail,
                "betaFeedbackCrashSubmissions" => UserInvitationsGetCollectionFieldsApp.BetaFeedbackCrashSubmissions,
                "betaFeedbackScreenshotSubmissions" => UserInvitationsGetCollectionFieldsApp.BetaFeedbackScreenshotSubmissions,
                "betaGroups" => UserInvitationsGetCollectionFieldsApp.BetaGroups,
                "betaLicenseAgreement" => UserInvitationsGetCollectionFieldsApp.BetaLicenseAgreement,
                "betaTesters" => UserInvitationsGetCollectionFieldsApp.BetaTesters,
                "buildUploads" => UserInvitationsGetCollectionFieldsApp.BuildUploads,
                "builds" => UserInvitationsGetCollectionFieldsApp.Builds,
                "bundleId" => UserInvitationsGetCollectionFieldsApp.BundleId,
                "ciProduct" => UserInvitationsGetCollectionFieldsApp.CiProduct,
                "contentRightsDeclaration" => UserInvitationsGetCollectionFieldsApp.ContentRightsDeclaration,
                "customerReviewSummarizations" => UserInvitationsGetCollectionFieldsApp.CustomerReviewSummarizations,
                "customerReviews" => UserInvitationsGetCollectionFieldsApp.CustomerReviews,
                "endUserLicenseAgreement" => UserInvitationsGetCollectionFieldsApp.EndUserLicenseAgreement,
                "gameCenterDetail" => UserInvitationsGetCollectionFieldsApp.GameCenterDetail,
                "gameCenterEnabledVersions" => UserInvitationsGetCollectionFieldsApp.GameCenterEnabledVersions,
                "inAppPurchases" => UserInvitationsGetCollectionFieldsApp.InAppPurchases,
                "inAppPurchasesV2" => UserInvitationsGetCollectionFieldsApp.InAppPurchasesV2,
                "isOrEverWasMadeForKids" => UserInvitationsGetCollectionFieldsApp.IsOrEverWasMadeForKids,
                "marketplaceSearchDetail" => UserInvitationsGetCollectionFieldsApp.MarketplaceSearchDetail,
                "name" => UserInvitationsGetCollectionFieldsApp.Name,
                "perfPowerMetrics" => UserInvitationsGetCollectionFieldsApp.PerfPowerMetrics,
                "preReleaseVersions" => UserInvitationsGetCollectionFieldsApp.PreReleaseVersions,
                "primaryLocale" => UserInvitationsGetCollectionFieldsApp.PrimaryLocale,
                "promotedPurchases" => UserInvitationsGetCollectionFieldsApp.PromotedPurchases,
                "reviewSubmissions" => UserInvitationsGetCollectionFieldsApp.ReviewSubmissions,
                "searchKeywords" => UserInvitationsGetCollectionFieldsApp.SearchKeywords,
                "sku" => UserInvitationsGetCollectionFieldsApp.Sku,
                "streamlinedPurchasingEnabled" => UserInvitationsGetCollectionFieldsApp.StreamlinedPurchasingEnabled,
                "subscriptionGracePeriod" => UserInvitationsGetCollectionFieldsApp.SubscriptionGracePeriod,
                "subscriptionGroups" => UserInvitationsGetCollectionFieldsApp.SubscriptionGroups,
                "subscriptionStatusUrl" => UserInvitationsGetCollectionFieldsApp.SubscriptionStatusUrl,
                "subscriptionStatusUrlForSandbox" => UserInvitationsGetCollectionFieldsApp.SubscriptionStatusUrlForSandbox,
                "subscriptionStatusUrlVersion" => UserInvitationsGetCollectionFieldsApp.SubscriptionStatusUrlVersion,
                "subscriptionStatusUrlVersionForSandbox" => UserInvitationsGetCollectionFieldsApp.SubscriptionStatusUrlVersionForSandbox,
                "webhooks" => UserInvitationsGetCollectionFieldsApp.Webhooks,
                _ => null,
            };
        }
    }
}