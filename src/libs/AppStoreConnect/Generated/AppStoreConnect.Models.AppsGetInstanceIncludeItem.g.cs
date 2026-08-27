
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsGetInstanceIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        AndroidToIosAppMappingDetails,
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
        BetaAppLocalizations,
        /// <summary>
        /// 
        /// </summary>
        BetaAppReviewDetail,
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
        Builds,
        /// <summary>
        /// 
        /// </summary>
        CiProduct,
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
        PreReleaseVersions,
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
        SubscriptionGracePeriod,
        /// <summary>
        /// 
        /// </summary>
        SubscriptionGroups,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGetInstanceIncludeItem value)
        {
            return value switch
            {
                AppsGetInstanceIncludeItem.AndroidToIosAppMappingDetails => "androidToIosAppMappingDetails",
                AppsGetInstanceIncludeItem.AppClips => "appClips",
                AppsGetInstanceIncludeItem.AppCustomProductPages => "appCustomProductPages",
                AppsGetInstanceIncludeItem.AppEncryptionDeclarations => "appEncryptionDeclarations",
                AppsGetInstanceIncludeItem.AppEvents => "appEvents",
                AppsGetInstanceIncludeItem.AppInfos => "appInfos",
                AppsGetInstanceIncludeItem.AppStoreIcon => "appStoreIcon",
                AppsGetInstanceIncludeItem.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                AppsGetInstanceIncludeItem.AppStoreVersions => "appStoreVersions",
                AppsGetInstanceIncludeItem.BetaAppLocalizations => "betaAppLocalizations",
                AppsGetInstanceIncludeItem.BetaAppReviewDetail => "betaAppReviewDetail",
                AppsGetInstanceIncludeItem.BetaGroups => "betaGroups",
                AppsGetInstanceIncludeItem.BetaLicenseAgreement => "betaLicenseAgreement",
                AppsGetInstanceIncludeItem.Builds => "builds",
                AppsGetInstanceIncludeItem.CiProduct => "ciProduct",
                AppsGetInstanceIncludeItem.EndUserLicenseAgreement => "endUserLicenseAgreement",
                AppsGetInstanceIncludeItem.GameCenterDetail => "gameCenterDetail",
                AppsGetInstanceIncludeItem.GameCenterEnabledVersions => "gameCenterEnabledVersions",
                AppsGetInstanceIncludeItem.InAppPurchases => "inAppPurchases",
                AppsGetInstanceIncludeItem.InAppPurchasesV2 => "inAppPurchasesV2",
                AppsGetInstanceIncludeItem.PreReleaseVersions => "preReleaseVersions",
                AppsGetInstanceIncludeItem.PromotedPurchases => "promotedPurchases",
                AppsGetInstanceIncludeItem.ReviewSubmissions => "reviewSubmissions",
                AppsGetInstanceIncludeItem.SubscriptionGracePeriod => "subscriptionGracePeriod",
                AppsGetInstanceIncludeItem.SubscriptionGroups => "subscriptionGroups",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "androidToIosAppMappingDetails" => AppsGetInstanceIncludeItem.AndroidToIosAppMappingDetails,
                "appClips" => AppsGetInstanceIncludeItem.AppClips,
                "appCustomProductPages" => AppsGetInstanceIncludeItem.AppCustomProductPages,
                "appEncryptionDeclarations" => AppsGetInstanceIncludeItem.AppEncryptionDeclarations,
                "appEvents" => AppsGetInstanceIncludeItem.AppEvents,
                "appInfos" => AppsGetInstanceIncludeItem.AppInfos,
                "appStoreIcon" => AppsGetInstanceIncludeItem.AppStoreIcon,
                "appStoreVersionExperimentsV2" => AppsGetInstanceIncludeItem.AppStoreVersionExperimentsV2,
                "appStoreVersions" => AppsGetInstanceIncludeItem.AppStoreVersions,
                "betaAppLocalizations" => AppsGetInstanceIncludeItem.BetaAppLocalizations,
                "betaAppReviewDetail" => AppsGetInstanceIncludeItem.BetaAppReviewDetail,
                "betaGroups" => AppsGetInstanceIncludeItem.BetaGroups,
                "betaLicenseAgreement" => AppsGetInstanceIncludeItem.BetaLicenseAgreement,
                "builds" => AppsGetInstanceIncludeItem.Builds,
                "ciProduct" => AppsGetInstanceIncludeItem.CiProduct,
                "endUserLicenseAgreement" => AppsGetInstanceIncludeItem.EndUserLicenseAgreement,
                "gameCenterDetail" => AppsGetInstanceIncludeItem.GameCenterDetail,
                "gameCenterEnabledVersions" => AppsGetInstanceIncludeItem.GameCenterEnabledVersions,
                "inAppPurchases" => AppsGetInstanceIncludeItem.InAppPurchases,
                "inAppPurchasesV2" => AppsGetInstanceIncludeItem.InAppPurchasesV2,
                "preReleaseVersions" => AppsGetInstanceIncludeItem.PreReleaseVersions,
                "promotedPurchases" => AppsGetInstanceIncludeItem.PromotedPurchases,
                "reviewSubmissions" => AppsGetInstanceIncludeItem.ReviewSubmissions,
                "subscriptionGracePeriod" => AppsGetInstanceIncludeItem.SubscriptionGracePeriod,
                "subscriptionGroups" => AppsGetInstanceIncludeItem.SubscriptionGroups,
                _ => null,
            };
        }
    }
}