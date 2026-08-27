
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsGetCollectionIncludeItem
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
    public static class AppsGetCollectionIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGetCollectionIncludeItem value)
        {
            return value switch
            {
                AppsGetCollectionIncludeItem.AndroidToIosAppMappingDetails => "androidToIosAppMappingDetails",
                AppsGetCollectionIncludeItem.AppClips => "appClips",
                AppsGetCollectionIncludeItem.AppCustomProductPages => "appCustomProductPages",
                AppsGetCollectionIncludeItem.AppEncryptionDeclarations => "appEncryptionDeclarations",
                AppsGetCollectionIncludeItem.AppEvents => "appEvents",
                AppsGetCollectionIncludeItem.AppInfos => "appInfos",
                AppsGetCollectionIncludeItem.AppStoreIcon => "appStoreIcon",
                AppsGetCollectionIncludeItem.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                AppsGetCollectionIncludeItem.AppStoreVersions => "appStoreVersions",
                AppsGetCollectionIncludeItem.BetaAppLocalizations => "betaAppLocalizations",
                AppsGetCollectionIncludeItem.BetaAppReviewDetail => "betaAppReviewDetail",
                AppsGetCollectionIncludeItem.BetaGroups => "betaGroups",
                AppsGetCollectionIncludeItem.BetaLicenseAgreement => "betaLicenseAgreement",
                AppsGetCollectionIncludeItem.Builds => "builds",
                AppsGetCollectionIncludeItem.CiProduct => "ciProduct",
                AppsGetCollectionIncludeItem.EndUserLicenseAgreement => "endUserLicenseAgreement",
                AppsGetCollectionIncludeItem.GameCenterDetail => "gameCenterDetail",
                AppsGetCollectionIncludeItem.GameCenterEnabledVersions => "gameCenterEnabledVersions",
                AppsGetCollectionIncludeItem.InAppPurchases => "inAppPurchases",
                AppsGetCollectionIncludeItem.InAppPurchasesV2 => "inAppPurchasesV2",
                AppsGetCollectionIncludeItem.PreReleaseVersions => "preReleaseVersions",
                AppsGetCollectionIncludeItem.PromotedPurchases => "promotedPurchases",
                AppsGetCollectionIncludeItem.ReviewSubmissions => "reviewSubmissions",
                AppsGetCollectionIncludeItem.SubscriptionGracePeriod => "subscriptionGracePeriod",
                AppsGetCollectionIncludeItem.SubscriptionGroups => "subscriptionGroups",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGetCollectionIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "androidToIosAppMappingDetails" => AppsGetCollectionIncludeItem.AndroidToIosAppMappingDetails,
                "appClips" => AppsGetCollectionIncludeItem.AppClips,
                "appCustomProductPages" => AppsGetCollectionIncludeItem.AppCustomProductPages,
                "appEncryptionDeclarations" => AppsGetCollectionIncludeItem.AppEncryptionDeclarations,
                "appEvents" => AppsGetCollectionIncludeItem.AppEvents,
                "appInfos" => AppsGetCollectionIncludeItem.AppInfos,
                "appStoreIcon" => AppsGetCollectionIncludeItem.AppStoreIcon,
                "appStoreVersionExperimentsV2" => AppsGetCollectionIncludeItem.AppStoreVersionExperimentsV2,
                "appStoreVersions" => AppsGetCollectionIncludeItem.AppStoreVersions,
                "betaAppLocalizations" => AppsGetCollectionIncludeItem.BetaAppLocalizations,
                "betaAppReviewDetail" => AppsGetCollectionIncludeItem.BetaAppReviewDetail,
                "betaGroups" => AppsGetCollectionIncludeItem.BetaGroups,
                "betaLicenseAgreement" => AppsGetCollectionIncludeItem.BetaLicenseAgreement,
                "builds" => AppsGetCollectionIncludeItem.Builds,
                "ciProduct" => AppsGetCollectionIncludeItem.CiProduct,
                "endUserLicenseAgreement" => AppsGetCollectionIncludeItem.EndUserLicenseAgreement,
                "gameCenterDetail" => AppsGetCollectionIncludeItem.GameCenterDetail,
                "gameCenterEnabledVersions" => AppsGetCollectionIncludeItem.GameCenterEnabledVersions,
                "inAppPurchases" => AppsGetCollectionIncludeItem.InAppPurchases,
                "inAppPurchasesV2" => AppsGetCollectionIncludeItem.InAppPurchasesV2,
                "preReleaseVersions" => AppsGetCollectionIncludeItem.PreReleaseVersions,
                "promotedPurchases" => AppsGetCollectionIncludeItem.PromotedPurchases,
                "reviewSubmissions" => AppsGetCollectionIncludeItem.ReviewSubmissions,
                "subscriptionGracePeriod" => AppsGetCollectionIncludeItem.SubscriptionGracePeriod,
                "subscriptionGroups" => AppsGetCollectionIncludeItem.SubscriptionGroups,
                _ => null,
            };
        }
    }
}