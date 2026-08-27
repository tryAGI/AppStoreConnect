
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsResponseIncludedItemDiscriminatorType
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
        AppStoreVersionExperiments,
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
        BetaAppReviewDetails,
        /// <summary>
        ///
        /// </summary>
        BetaGroups,
        /// <summary>
        ///
        /// </summary>
        BetaLicenseAgreements,
        /// <summary>
        ///
        /// </summary>
        BuildIcons,
        /// <summary>
        ///
        /// </summary>
        Builds,
        /// <summary>
        ///
        /// </summary>
        CiProducts,
        /// <summary>
        ///
        /// </summary>
        EndUserLicenseAgreements,
        /// <summary>
        ///
        /// </summary>
        GameCenterDetails,
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
        SubscriptionGracePeriods,
        /// <summary>
        ///
        /// </summary>
        SubscriptionGroups,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                AppsResponseIncludedItemDiscriminatorType.AndroidToIosAppMappingDetails => "androidToIosAppMappingDetails",
                AppsResponseIncludedItemDiscriminatorType.AppClips => "appClips",
                AppsResponseIncludedItemDiscriminatorType.AppCustomProductPages => "appCustomProductPages",
                AppsResponseIncludedItemDiscriminatorType.AppEncryptionDeclarations => "appEncryptionDeclarations",
                AppsResponseIncludedItemDiscriminatorType.AppEvents => "appEvents",
                AppsResponseIncludedItemDiscriminatorType.AppInfos => "appInfos",
                AppsResponseIncludedItemDiscriminatorType.AppStoreVersionExperiments => "appStoreVersionExperiments",
                AppsResponseIncludedItemDiscriminatorType.AppStoreVersions => "appStoreVersions",
                AppsResponseIncludedItemDiscriminatorType.BetaAppLocalizations => "betaAppLocalizations",
                AppsResponseIncludedItemDiscriminatorType.BetaAppReviewDetails => "betaAppReviewDetails",
                AppsResponseIncludedItemDiscriminatorType.BetaGroups => "betaGroups",
                AppsResponseIncludedItemDiscriminatorType.BetaLicenseAgreements => "betaLicenseAgreements",
                AppsResponseIncludedItemDiscriminatorType.BuildIcons => "buildIcons",
                AppsResponseIncludedItemDiscriminatorType.Builds => "builds",
                AppsResponseIncludedItemDiscriminatorType.CiProducts => "ciProducts",
                AppsResponseIncludedItemDiscriminatorType.EndUserLicenseAgreements => "endUserLicenseAgreements",
                AppsResponseIncludedItemDiscriminatorType.GameCenterDetails => "gameCenterDetails",
                AppsResponseIncludedItemDiscriminatorType.GameCenterEnabledVersions => "gameCenterEnabledVersions",
                AppsResponseIncludedItemDiscriminatorType.InAppPurchases => "inAppPurchases",
                AppsResponseIncludedItemDiscriminatorType.PreReleaseVersions => "preReleaseVersions",
                AppsResponseIncludedItemDiscriminatorType.PromotedPurchases => "promotedPurchases",
                AppsResponseIncludedItemDiscriminatorType.ReviewSubmissions => "reviewSubmissions",
                AppsResponseIncludedItemDiscriminatorType.SubscriptionGracePeriods => "subscriptionGracePeriods",
                AppsResponseIncludedItemDiscriminatorType.SubscriptionGroups => "subscriptionGroups",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "androidToIosAppMappingDetails" => AppsResponseIncludedItemDiscriminatorType.AndroidToIosAppMappingDetails,
                "appClips" => AppsResponseIncludedItemDiscriminatorType.AppClips,
                "appCustomProductPages" => AppsResponseIncludedItemDiscriminatorType.AppCustomProductPages,
                "appEncryptionDeclarations" => AppsResponseIncludedItemDiscriminatorType.AppEncryptionDeclarations,
                "appEvents" => AppsResponseIncludedItemDiscriminatorType.AppEvents,
                "appInfos" => AppsResponseIncludedItemDiscriminatorType.AppInfos,
                "appStoreVersionExperiments" => AppsResponseIncludedItemDiscriminatorType.AppStoreVersionExperiments,
                "appStoreVersions" => AppsResponseIncludedItemDiscriminatorType.AppStoreVersions,
                "betaAppLocalizations" => AppsResponseIncludedItemDiscriminatorType.BetaAppLocalizations,
                "betaAppReviewDetails" => AppsResponseIncludedItemDiscriminatorType.BetaAppReviewDetails,
                "betaGroups" => AppsResponseIncludedItemDiscriminatorType.BetaGroups,
                "betaLicenseAgreements" => AppsResponseIncludedItemDiscriminatorType.BetaLicenseAgreements,
                "buildIcons" => AppsResponseIncludedItemDiscriminatorType.BuildIcons,
                "builds" => AppsResponseIncludedItemDiscriminatorType.Builds,
                "ciProducts" => AppsResponseIncludedItemDiscriminatorType.CiProducts,
                "endUserLicenseAgreements" => AppsResponseIncludedItemDiscriminatorType.EndUserLicenseAgreements,
                "gameCenterDetails" => AppsResponseIncludedItemDiscriminatorType.GameCenterDetails,
                "gameCenterEnabledVersions" => AppsResponseIncludedItemDiscriminatorType.GameCenterEnabledVersions,
                "inAppPurchases" => AppsResponseIncludedItemDiscriminatorType.InAppPurchases,
                "preReleaseVersions" => AppsResponseIncludedItemDiscriminatorType.PreReleaseVersions,
                "promotedPurchases" => AppsResponseIncludedItemDiscriminatorType.PromotedPurchases,
                "reviewSubmissions" => AppsResponseIncludedItemDiscriminatorType.ReviewSubmissions,
                "subscriptionGracePeriods" => AppsResponseIncludedItemDiscriminatorType.SubscriptionGracePeriods,
                "subscriptionGroups" => AppsResponseIncludedItemDiscriminatorType.SubscriptionGroups,
                _ => null,
            };
        }
    }
}