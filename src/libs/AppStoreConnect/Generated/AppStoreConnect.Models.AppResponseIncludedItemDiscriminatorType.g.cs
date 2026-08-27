
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppResponseIncludedItemDiscriminatorType
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
    public static class AppResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                AppResponseIncludedItemDiscriminatorType.AndroidToIosAppMappingDetails => "androidToIosAppMappingDetails",
                AppResponseIncludedItemDiscriminatorType.AppClips => "appClips",
                AppResponseIncludedItemDiscriminatorType.AppCustomProductPages => "appCustomProductPages",
                AppResponseIncludedItemDiscriminatorType.AppEncryptionDeclarations => "appEncryptionDeclarations",
                AppResponseIncludedItemDiscriminatorType.AppEvents => "appEvents",
                AppResponseIncludedItemDiscriminatorType.AppInfos => "appInfos",
                AppResponseIncludedItemDiscriminatorType.AppStoreVersionExperiments => "appStoreVersionExperiments",
                AppResponseIncludedItemDiscriminatorType.AppStoreVersions => "appStoreVersions",
                AppResponseIncludedItemDiscriminatorType.BetaAppLocalizations => "betaAppLocalizations",
                AppResponseIncludedItemDiscriminatorType.BetaAppReviewDetails => "betaAppReviewDetails",
                AppResponseIncludedItemDiscriminatorType.BetaGroups => "betaGroups",
                AppResponseIncludedItemDiscriminatorType.BetaLicenseAgreements => "betaLicenseAgreements",
                AppResponseIncludedItemDiscriminatorType.BuildIcons => "buildIcons",
                AppResponseIncludedItemDiscriminatorType.Builds => "builds",
                AppResponseIncludedItemDiscriminatorType.CiProducts => "ciProducts",
                AppResponseIncludedItemDiscriminatorType.EndUserLicenseAgreements => "endUserLicenseAgreements",
                AppResponseIncludedItemDiscriminatorType.GameCenterDetails => "gameCenterDetails",
                AppResponseIncludedItemDiscriminatorType.GameCenterEnabledVersions => "gameCenterEnabledVersions",
                AppResponseIncludedItemDiscriminatorType.InAppPurchases => "inAppPurchases",
                AppResponseIncludedItemDiscriminatorType.PreReleaseVersions => "preReleaseVersions",
                AppResponseIncludedItemDiscriminatorType.PromotedPurchases => "promotedPurchases",
                AppResponseIncludedItemDiscriminatorType.ReviewSubmissions => "reviewSubmissions",
                AppResponseIncludedItemDiscriminatorType.SubscriptionGracePeriods => "subscriptionGracePeriods",
                AppResponseIncludedItemDiscriminatorType.SubscriptionGroups => "subscriptionGroups",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "androidToIosAppMappingDetails" => AppResponseIncludedItemDiscriminatorType.AndroidToIosAppMappingDetails,
                "appClips" => AppResponseIncludedItemDiscriminatorType.AppClips,
                "appCustomProductPages" => AppResponseIncludedItemDiscriminatorType.AppCustomProductPages,
                "appEncryptionDeclarations" => AppResponseIncludedItemDiscriminatorType.AppEncryptionDeclarations,
                "appEvents" => AppResponseIncludedItemDiscriminatorType.AppEvents,
                "appInfos" => AppResponseIncludedItemDiscriminatorType.AppInfos,
                "appStoreVersionExperiments" => AppResponseIncludedItemDiscriminatorType.AppStoreVersionExperiments,
                "appStoreVersions" => AppResponseIncludedItemDiscriminatorType.AppStoreVersions,
                "betaAppLocalizations" => AppResponseIncludedItemDiscriminatorType.BetaAppLocalizations,
                "betaAppReviewDetails" => AppResponseIncludedItemDiscriminatorType.BetaAppReviewDetails,
                "betaGroups" => AppResponseIncludedItemDiscriminatorType.BetaGroups,
                "betaLicenseAgreements" => AppResponseIncludedItemDiscriminatorType.BetaLicenseAgreements,
                "buildIcons" => AppResponseIncludedItemDiscriminatorType.BuildIcons,
                "builds" => AppResponseIncludedItemDiscriminatorType.Builds,
                "ciProducts" => AppResponseIncludedItemDiscriminatorType.CiProducts,
                "endUserLicenseAgreements" => AppResponseIncludedItemDiscriminatorType.EndUserLicenseAgreements,
                "gameCenterDetails" => AppResponseIncludedItemDiscriminatorType.GameCenterDetails,
                "gameCenterEnabledVersions" => AppResponseIncludedItemDiscriminatorType.GameCenterEnabledVersions,
                "inAppPurchases" => AppResponseIncludedItemDiscriminatorType.InAppPurchases,
                "preReleaseVersions" => AppResponseIncludedItemDiscriminatorType.PreReleaseVersions,
                "promotedPurchases" => AppResponseIncludedItemDiscriminatorType.PromotedPurchases,
                "reviewSubmissions" => AppResponseIncludedItemDiscriminatorType.ReviewSubmissions,
                "subscriptionGracePeriods" => AppResponseIncludedItemDiscriminatorType.SubscriptionGracePeriods,
                "subscriptionGroups" => AppResponseIncludedItemDiscriminatorType.SubscriptionGroups,
                _ => null,
            };
        }
    }
}