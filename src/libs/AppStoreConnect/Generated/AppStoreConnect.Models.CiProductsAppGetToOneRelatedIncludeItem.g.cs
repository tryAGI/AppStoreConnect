
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiProductsAppGetToOneRelatedIncludeItem
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
    public static class CiProductsAppGetToOneRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiProductsAppGetToOneRelatedIncludeItem value)
        {
            return value switch
            {
                CiProductsAppGetToOneRelatedIncludeItem.AndroidToIosAppMappingDetails => "androidToIosAppMappingDetails",
                CiProductsAppGetToOneRelatedIncludeItem.AppClips => "appClips",
                CiProductsAppGetToOneRelatedIncludeItem.AppCustomProductPages => "appCustomProductPages",
                CiProductsAppGetToOneRelatedIncludeItem.AppEncryptionDeclarations => "appEncryptionDeclarations",
                CiProductsAppGetToOneRelatedIncludeItem.AppEvents => "appEvents",
                CiProductsAppGetToOneRelatedIncludeItem.AppInfos => "appInfos",
                CiProductsAppGetToOneRelatedIncludeItem.AppStoreIcon => "appStoreIcon",
                CiProductsAppGetToOneRelatedIncludeItem.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                CiProductsAppGetToOneRelatedIncludeItem.AppStoreVersions => "appStoreVersions",
                CiProductsAppGetToOneRelatedIncludeItem.BetaAppLocalizations => "betaAppLocalizations",
                CiProductsAppGetToOneRelatedIncludeItem.BetaAppReviewDetail => "betaAppReviewDetail",
                CiProductsAppGetToOneRelatedIncludeItem.BetaGroups => "betaGroups",
                CiProductsAppGetToOneRelatedIncludeItem.BetaLicenseAgreement => "betaLicenseAgreement",
                CiProductsAppGetToOneRelatedIncludeItem.Builds => "builds",
                CiProductsAppGetToOneRelatedIncludeItem.CiProduct => "ciProduct",
                CiProductsAppGetToOneRelatedIncludeItem.EndUserLicenseAgreement => "endUserLicenseAgreement",
                CiProductsAppGetToOneRelatedIncludeItem.GameCenterDetail => "gameCenterDetail",
                CiProductsAppGetToOneRelatedIncludeItem.GameCenterEnabledVersions => "gameCenterEnabledVersions",
                CiProductsAppGetToOneRelatedIncludeItem.InAppPurchases => "inAppPurchases",
                CiProductsAppGetToOneRelatedIncludeItem.InAppPurchasesV2 => "inAppPurchasesV2",
                CiProductsAppGetToOneRelatedIncludeItem.PreReleaseVersions => "preReleaseVersions",
                CiProductsAppGetToOneRelatedIncludeItem.PromotedPurchases => "promotedPurchases",
                CiProductsAppGetToOneRelatedIncludeItem.ReviewSubmissions => "reviewSubmissions",
                CiProductsAppGetToOneRelatedIncludeItem.SubscriptionGracePeriod => "subscriptionGracePeriod",
                CiProductsAppGetToOneRelatedIncludeItem.SubscriptionGroups => "subscriptionGroups",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiProductsAppGetToOneRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "androidToIosAppMappingDetails" => CiProductsAppGetToOneRelatedIncludeItem.AndroidToIosAppMappingDetails,
                "appClips" => CiProductsAppGetToOneRelatedIncludeItem.AppClips,
                "appCustomProductPages" => CiProductsAppGetToOneRelatedIncludeItem.AppCustomProductPages,
                "appEncryptionDeclarations" => CiProductsAppGetToOneRelatedIncludeItem.AppEncryptionDeclarations,
                "appEvents" => CiProductsAppGetToOneRelatedIncludeItem.AppEvents,
                "appInfos" => CiProductsAppGetToOneRelatedIncludeItem.AppInfos,
                "appStoreIcon" => CiProductsAppGetToOneRelatedIncludeItem.AppStoreIcon,
                "appStoreVersionExperimentsV2" => CiProductsAppGetToOneRelatedIncludeItem.AppStoreVersionExperimentsV2,
                "appStoreVersions" => CiProductsAppGetToOneRelatedIncludeItem.AppStoreVersions,
                "betaAppLocalizations" => CiProductsAppGetToOneRelatedIncludeItem.BetaAppLocalizations,
                "betaAppReviewDetail" => CiProductsAppGetToOneRelatedIncludeItem.BetaAppReviewDetail,
                "betaGroups" => CiProductsAppGetToOneRelatedIncludeItem.BetaGroups,
                "betaLicenseAgreement" => CiProductsAppGetToOneRelatedIncludeItem.BetaLicenseAgreement,
                "builds" => CiProductsAppGetToOneRelatedIncludeItem.Builds,
                "ciProduct" => CiProductsAppGetToOneRelatedIncludeItem.CiProduct,
                "endUserLicenseAgreement" => CiProductsAppGetToOneRelatedIncludeItem.EndUserLicenseAgreement,
                "gameCenterDetail" => CiProductsAppGetToOneRelatedIncludeItem.GameCenterDetail,
                "gameCenterEnabledVersions" => CiProductsAppGetToOneRelatedIncludeItem.GameCenterEnabledVersions,
                "inAppPurchases" => CiProductsAppGetToOneRelatedIncludeItem.InAppPurchases,
                "inAppPurchasesV2" => CiProductsAppGetToOneRelatedIncludeItem.InAppPurchasesV2,
                "preReleaseVersions" => CiProductsAppGetToOneRelatedIncludeItem.PreReleaseVersions,
                "promotedPurchases" => CiProductsAppGetToOneRelatedIncludeItem.PromotedPurchases,
                "reviewSubmissions" => CiProductsAppGetToOneRelatedIncludeItem.ReviewSubmissions,
                "subscriptionGracePeriod" => CiProductsAppGetToOneRelatedIncludeItem.SubscriptionGracePeriod,
                "subscriptionGroups" => CiProductsAppGetToOneRelatedIncludeItem.SubscriptionGroups,
                _ => null,
            };
        }
    }
}