
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterDetailsGetInstanceFieldsAppStoreVersion
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
    public static class GameCenterDetailsGetInstanceFieldsAppStoreVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsGetInstanceFieldsAppStoreVersion value)
        {
            return value switch
            {
                GameCenterDetailsGetInstanceFieldsAppStoreVersion.AlternativeDistributionPackage => "alternativeDistributionPackage",
                GameCenterDetailsGetInstanceFieldsAppStoreVersion.App => "app",
                GameCenterDetailsGetInstanceFieldsAppStoreVersion.AppClipDefaultExperience => "appClipDefaultExperience",
                GameCenterDetailsGetInstanceFieldsAppStoreVersion.AppStoreReviewDetail => "appStoreReviewDetail",
                GameCenterDetailsGetInstanceFieldsAppStoreVersion.AppStoreState => "appStoreState",
                GameCenterDetailsGetInstanceFieldsAppStoreVersion.AppStoreVersionExperiments => "appStoreVersionExperiments",
                GameCenterDetailsGetInstanceFieldsAppStoreVersion.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                GameCenterDetailsGetInstanceFieldsAppStoreVersion.AppStoreVersionLocalizations => "appStoreVersionLocalizations",
                GameCenterDetailsGetInstanceFieldsAppStoreVersion.AppStoreVersionPhasedRelease => "appStoreVersionPhasedRelease",
                GameCenterDetailsGetInstanceFieldsAppStoreVersion.AppStoreVersionSubmission => "appStoreVersionSubmission",
                GameCenterDetailsGetInstanceFieldsAppStoreVersion.AppVersionState => "appVersionState",
                GameCenterDetailsGetInstanceFieldsAppStoreVersion.Build => "build",
                GameCenterDetailsGetInstanceFieldsAppStoreVersion.Copyright => "copyright",
                GameCenterDetailsGetInstanceFieldsAppStoreVersion.CreatedDate => "createdDate",
                GameCenterDetailsGetInstanceFieldsAppStoreVersion.CustomerReviews => "customerReviews",
                GameCenterDetailsGetInstanceFieldsAppStoreVersion.Downloadable => "downloadable",
                GameCenterDetailsGetInstanceFieldsAppStoreVersion.EarliestReleaseDate => "earliestReleaseDate",
                GameCenterDetailsGetInstanceFieldsAppStoreVersion.GameCenterAppVersion => "gameCenterAppVersion",
                GameCenterDetailsGetInstanceFieldsAppStoreVersion.Platform => "platform",
                GameCenterDetailsGetInstanceFieldsAppStoreVersion.ReleaseType => "releaseType",
                GameCenterDetailsGetInstanceFieldsAppStoreVersion.ReviewType => "reviewType",
                GameCenterDetailsGetInstanceFieldsAppStoreVersion.RoutingAppCoverage => "routingAppCoverage",
                GameCenterDetailsGetInstanceFieldsAppStoreVersion.UsesIdfa => "usesIdfa",
                GameCenterDetailsGetInstanceFieldsAppStoreVersion.VersionString => "versionString",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsGetInstanceFieldsAppStoreVersion? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionPackage" => GameCenterDetailsGetInstanceFieldsAppStoreVersion.AlternativeDistributionPackage,
                "app" => GameCenterDetailsGetInstanceFieldsAppStoreVersion.App,
                "appClipDefaultExperience" => GameCenterDetailsGetInstanceFieldsAppStoreVersion.AppClipDefaultExperience,
                "appStoreReviewDetail" => GameCenterDetailsGetInstanceFieldsAppStoreVersion.AppStoreReviewDetail,
                "appStoreState" => GameCenterDetailsGetInstanceFieldsAppStoreVersion.AppStoreState,
                "appStoreVersionExperiments" => GameCenterDetailsGetInstanceFieldsAppStoreVersion.AppStoreVersionExperiments,
                "appStoreVersionExperimentsV2" => GameCenterDetailsGetInstanceFieldsAppStoreVersion.AppStoreVersionExperimentsV2,
                "appStoreVersionLocalizations" => GameCenterDetailsGetInstanceFieldsAppStoreVersion.AppStoreVersionLocalizations,
                "appStoreVersionPhasedRelease" => GameCenterDetailsGetInstanceFieldsAppStoreVersion.AppStoreVersionPhasedRelease,
                "appStoreVersionSubmission" => GameCenterDetailsGetInstanceFieldsAppStoreVersion.AppStoreVersionSubmission,
                "appVersionState" => GameCenterDetailsGetInstanceFieldsAppStoreVersion.AppVersionState,
                "build" => GameCenterDetailsGetInstanceFieldsAppStoreVersion.Build,
                "copyright" => GameCenterDetailsGetInstanceFieldsAppStoreVersion.Copyright,
                "createdDate" => GameCenterDetailsGetInstanceFieldsAppStoreVersion.CreatedDate,
                "customerReviews" => GameCenterDetailsGetInstanceFieldsAppStoreVersion.CustomerReviews,
                "downloadable" => GameCenterDetailsGetInstanceFieldsAppStoreVersion.Downloadable,
                "earliestReleaseDate" => GameCenterDetailsGetInstanceFieldsAppStoreVersion.EarliestReleaseDate,
                "gameCenterAppVersion" => GameCenterDetailsGetInstanceFieldsAppStoreVersion.GameCenterAppVersion,
                "platform" => GameCenterDetailsGetInstanceFieldsAppStoreVersion.Platform,
                "releaseType" => GameCenterDetailsGetInstanceFieldsAppStoreVersion.ReleaseType,
                "reviewType" => GameCenterDetailsGetInstanceFieldsAppStoreVersion.ReviewType,
                "routingAppCoverage" => GameCenterDetailsGetInstanceFieldsAppStoreVersion.RoutingAppCoverage,
                "usesIdfa" => GameCenterDetailsGetInstanceFieldsAppStoreVersion.UsesIdfa,
                "versionString" => GameCenterDetailsGetInstanceFieldsAppStoreVersion.VersionString,
                _ => null,
            };
        }
    }
}