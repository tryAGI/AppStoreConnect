
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAppVersionsGetInstanceFieldsAppStoreVersion
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
    public static class GameCenterAppVersionsGetInstanceFieldsAppStoreVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAppVersionsGetInstanceFieldsAppStoreVersion value)
        {
            return value switch
            {
                GameCenterAppVersionsGetInstanceFieldsAppStoreVersion.AlternativeDistributionPackage => "alternativeDistributionPackage",
                GameCenterAppVersionsGetInstanceFieldsAppStoreVersion.App => "app",
                GameCenterAppVersionsGetInstanceFieldsAppStoreVersion.AppClipDefaultExperience => "appClipDefaultExperience",
                GameCenterAppVersionsGetInstanceFieldsAppStoreVersion.AppStoreReviewDetail => "appStoreReviewDetail",
                GameCenterAppVersionsGetInstanceFieldsAppStoreVersion.AppStoreState => "appStoreState",
                GameCenterAppVersionsGetInstanceFieldsAppStoreVersion.AppStoreVersionExperiments => "appStoreVersionExperiments",
                GameCenterAppVersionsGetInstanceFieldsAppStoreVersion.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                GameCenterAppVersionsGetInstanceFieldsAppStoreVersion.AppStoreVersionLocalizations => "appStoreVersionLocalizations",
                GameCenterAppVersionsGetInstanceFieldsAppStoreVersion.AppStoreVersionPhasedRelease => "appStoreVersionPhasedRelease",
                GameCenterAppVersionsGetInstanceFieldsAppStoreVersion.AppStoreVersionSubmission => "appStoreVersionSubmission",
                GameCenterAppVersionsGetInstanceFieldsAppStoreVersion.AppVersionState => "appVersionState",
                GameCenterAppVersionsGetInstanceFieldsAppStoreVersion.Build => "build",
                GameCenterAppVersionsGetInstanceFieldsAppStoreVersion.Copyright => "copyright",
                GameCenterAppVersionsGetInstanceFieldsAppStoreVersion.CreatedDate => "createdDate",
                GameCenterAppVersionsGetInstanceFieldsAppStoreVersion.CustomerReviews => "customerReviews",
                GameCenterAppVersionsGetInstanceFieldsAppStoreVersion.Downloadable => "downloadable",
                GameCenterAppVersionsGetInstanceFieldsAppStoreVersion.EarliestReleaseDate => "earliestReleaseDate",
                GameCenterAppVersionsGetInstanceFieldsAppStoreVersion.GameCenterAppVersion => "gameCenterAppVersion",
                GameCenterAppVersionsGetInstanceFieldsAppStoreVersion.Platform => "platform",
                GameCenterAppVersionsGetInstanceFieldsAppStoreVersion.ReleaseType => "releaseType",
                GameCenterAppVersionsGetInstanceFieldsAppStoreVersion.ReviewType => "reviewType",
                GameCenterAppVersionsGetInstanceFieldsAppStoreVersion.RoutingAppCoverage => "routingAppCoverage",
                GameCenterAppVersionsGetInstanceFieldsAppStoreVersion.UsesIdfa => "usesIdfa",
                GameCenterAppVersionsGetInstanceFieldsAppStoreVersion.VersionString => "versionString",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAppVersionsGetInstanceFieldsAppStoreVersion? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionPackage" => GameCenterAppVersionsGetInstanceFieldsAppStoreVersion.AlternativeDistributionPackage,
                "app" => GameCenterAppVersionsGetInstanceFieldsAppStoreVersion.App,
                "appClipDefaultExperience" => GameCenterAppVersionsGetInstanceFieldsAppStoreVersion.AppClipDefaultExperience,
                "appStoreReviewDetail" => GameCenterAppVersionsGetInstanceFieldsAppStoreVersion.AppStoreReviewDetail,
                "appStoreState" => GameCenterAppVersionsGetInstanceFieldsAppStoreVersion.AppStoreState,
                "appStoreVersionExperiments" => GameCenterAppVersionsGetInstanceFieldsAppStoreVersion.AppStoreVersionExperiments,
                "appStoreVersionExperimentsV2" => GameCenterAppVersionsGetInstanceFieldsAppStoreVersion.AppStoreVersionExperimentsV2,
                "appStoreVersionLocalizations" => GameCenterAppVersionsGetInstanceFieldsAppStoreVersion.AppStoreVersionLocalizations,
                "appStoreVersionPhasedRelease" => GameCenterAppVersionsGetInstanceFieldsAppStoreVersion.AppStoreVersionPhasedRelease,
                "appStoreVersionSubmission" => GameCenterAppVersionsGetInstanceFieldsAppStoreVersion.AppStoreVersionSubmission,
                "appVersionState" => GameCenterAppVersionsGetInstanceFieldsAppStoreVersion.AppVersionState,
                "build" => GameCenterAppVersionsGetInstanceFieldsAppStoreVersion.Build,
                "copyright" => GameCenterAppVersionsGetInstanceFieldsAppStoreVersion.Copyright,
                "createdDate" => GameCenterAppVersionsGetInstanceFieldsAppStoreVersion.CreatedDate,
                "customerReviews" => GameCenterAppVersionsGetInstanceFieldsAppStoreVersion.CustomerReviews,
                "downloadable" => GameCenterAppVersionsGetInstanceFieldsAppStoreVersion.Downloadable,
                "earliestReleaseDate" => GameCenterAppVersionsGetInstanceFieldsAppStoreVersion.EarliestReleaseDate,
                "gameCenterAppVersion" => GameCenterAppVersionsGetInstanceFieldsAppStoreVersion.GameCenterAppVersion,
                "platform" => GameCenterAppVersionsGetInstanceFieldsAppStoreVersion.Platform,
                "releaseType" => GameCenterAppVersionsGetInstanceFieldsAppStoreVersion.ReleaseType,
                "reviewType" => GameCenterAppVersionsGetInstanceFieldsAppStoreVersion.ReviewType,
                "routingAppCoverage" => GameCenterAppVersionsGetInstanceFieldsAppStoreVersion.RoutingAppCoverage,
                "usesIdfa" => GameCenterAppVersionsGetInstanceFieldsAppStoreVersion.UsesIdfa,
                "versionString" => GameCenterAppVersionsGetInstanceFieldsAppStoreVersion.VersionString,
                _ => null,
            };
        }
    }
}