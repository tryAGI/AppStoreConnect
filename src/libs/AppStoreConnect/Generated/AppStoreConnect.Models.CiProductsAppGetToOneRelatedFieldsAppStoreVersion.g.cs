
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiProductsAppGetToOneRelatedFieldsAppStoreVersion
    {
        /// <summary>
        ///
        /// </summary>
        AlternativeDistributionPackage,
        /// <summary>
        ///
        /// </summary>
        App,
        /// <summary>
        ///
        /// </summary>
        AppClipDefaultExperience,
        /// <summary>
        ///
        /// </summary>
        AppStoreReviewDetail,
        /// <summary>
        ///
        /// </summary>
        AppStoreState,
        /// <summary>
        ///
        /// </summary>
        AppStoreVersionExperiments,
        /// <summary>
        ///
        /// </summary>
        AppStoreVersionExperimentsV2,
        /// <summary>
        ///
        /// </summary>
        AppStoreVersionLocalizations,
        /// <summary>
        ///
        /// </summary>
        AppStoreVersionPhasedRelease,
        /// <summary>
        ///
        /// </summary>
        AppStoreVersionSubmission,
        /// <summary>
        ///
        /// </summary>
        AppVersionState,
        /// <summary>
        ///
        /// </summary>
        Build,
        /// <summary>
        ///
        /// </summary>
        Copyright,
        /// <summary>
        ///
        /// </summary>
        CreatedDate,
        /// <summary>
        ///
        /// </summary>
        CustomerReviews,
        /// <summary>
        ///
        /// </summary>
        Downloadable,
        /// <summary>
        ///
        /// </summary>
        EarliestReleaseDate,
        /// <summary>
        ///
        /// </summary>
        GameCenterAppVersion,
        /// <summary>
        ///
        /// </summary>
        Platform,
        /// <summary>
        ///
        /// </summary>
        ReleaseType,
        /// <summary>
        ///
        /// </summary>
        ReviewType,
        /// <summary>
        ///
        /// </summary>
        RoutingAppCoverage,
        /// <summary>
        ///
        /// </summary>
        UsesIdfa,
        /// <summary>
        ///
        /// </summary>
        VersionString,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiProductsAppGetToOneRelatedFieldsAppStoreVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiProductsAppGetToOneRelatedFieldsAppStoreVersion value)
        {
            return value switch
            {
                CiProductsAppGetToOneRelatedFieldsAppStoreVersion.AlternativeDistributionPackage => "alternativeDistributionPackage",
                CiProductsAppGetToOneRelatedFieldsAppStoreVersion.App => "app",
                CiProductsAppGetToOneRelatedFieldsAppStoreVersion.AppClipDefaultExperience => "appClipDefaultExperience",
                CiProductsAppGetToOneRelatedFieldsAppStoreVersion.AppStoreReviewDetail => "appStoreReviewDetail",
                CiProductsAppGetToOneRelatedFieldsAppStoreVersion.AppStoreState => "appStoreState",
                CiProductsAppGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionExperiments => "appStoreVersionExperiments",
                CiProductsAppGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                CiProductsAppGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionLocalizations => "appStoreVersionLocalizations",
                CiProductsAppGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionPhasedRelease => "appStoreVersionPhasedRelease",
                CiProductsAppGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionSubmission => "appStoreVersionSubmission",
                CiProductsAppGetToOneRelatedFieldsAppStoreVersion.AppVersionState => "appVersionState",
                CiProductsAppGetToOneRelatedFieldsAppStoreVersion.Build => "build",
                CiProductsAppGetToOneRelatedFieldsAppStoreVersion.Copyright => "copyright",
                CiProductsAppGetToOneRelatedFieldsAppStoreVersion.CreatedDate => "createdDate",
                CiProductsAppGetToOneRelatedFieldsAppStoreVersion.CustomerReviews => "customerReviews",
                CiProductsAppGetToOneRelatedFieldsAppStoreVersion.Downloadable => "downloadable",
                CiProductsAppGetToOneRelatedFieldsAppStoreVersion.EarliestReleaseDate => "earliestReleaseDate",
                CiProductsAppGetToOneRelatedFieldsAppStoreVersion.GameCenterAppVersion => "gameCenterAppVersion",
                CiProductsAppGetToOneRelatedFieldsAppStoreVersion.Platform => "platform",
                CiProductsAppGetToOneRelatedFieldsAppStoreVersion.ReleaseType => "releaseType",
                CiProductsAppGetToOneRelatedFieldsAppStoreVersion.ReviewType => "reviewType",
                CiProductsAppGetToOneRelatedFieldsAppStoreVersion.RoutingAppCoverage => "routingAppCoverage",
                CiProductsAppGetToOneRelatedFieldsAppStoreVersion.UsesIdfa => "usesIdfa",
                CiProductsAppGetToOneRelatedFieldsAppStoreVersion.VersionString => "versionString",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiProductsAppGetToOneRelatedFieldsAppStoreVersion? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionPackage" => CiProductsAppGetToOneRelatedFieldsAppStoreVersion.AlternativeDistributionPackage,
                "app" => CiProductsAppGetToOneRelatedFieldsAppStoreVersion.App,
                "appClipDefaultExperience" => CiProductsAppGetToOneRelatedFieldsAppStoreVersion.AppClipDefaultExperience,
                "appStoreReviewDetail" => CiProductsAppGetToOneRelatedFieldsAppStoreVersion.AppStoreReviewDetail,
                "appStoreState" => CiProductsAppGetToOneRelatedFieldsAppStoreVersion.AppStoreState,
                "appStoreVersionExperiments" => CiProductsAppGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionExperiments,
                "appStoreVersionExperimentsV2" => CiProductsAppGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionExperimentsV2,
                "appStoreVersionLocalizations" => CiProductsAppGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionLocalizations,
                "appStoreVersionPhasedRelease" => CiProductsAppGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionPhasedRelease,
                "appStoreVersionSubmission" => CiProductsAppGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionSubmission,
                "appVersionState" => CiProductsAppGetToOneRelatedFieldsAppStoreVersion.AppVersionState,
                "build" => CiProductsAppGetToOneRelatedFieldsAppStoreVersion.Build,
                "copyright" => CiProductsAppGetToOneRelatedFieldsAppStoreVersion.Copyright,
                "createdDate" => CiProductsAppGetToOneRelatedFieldsAppStoreVersion.CreatedDate,
                "customerReviews" => CiProductsAppGetToOneRelatedFieldsAppStoreVersion.CustomerReviews,
                "downloadable" => CiProductsAppGetToOneRelatedFieldsAppStoreVersion.Downloadable,
                "earliestReleaseDate" => CiProductsAppGetToOneRelatedFieldsAppStoreVersion.EarliestReleaseDate,
                "gameCenterAppVersion" => CiProductsAppGetToOneRelatedFieldsAppStoreVersion.GameCenterAppVersion,
                "platform" => CiProductsAppGetToOneRelatedFieldsAppStoreVersion.Platform,
                "releaseType" => CiProductsAppGetToOneRelatedFieldsAppStoreVersion.ReleaseType,
                "reviewType" => CiProductsAppGetToOneRelatedFieldsAppStoreVersion.ReviewType,
                "routingAppCoverage" => CiProductsAppGetToOneRelatedFieldsAppStoreVersion.RoutingAppCoverage,
                "usesIdfa" => CiProductsAppGetToOneRelatedFieldsAppStoreVersion.UsesIdfa,
                "versionString" => CiProductsAppGetToOneRelatedFieldsAppStoreVersion.VersionString,
                _ => null,
            };
        }
    }
}