
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion
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
    public static class GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion value)
        {
            return value switch
            {
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.AlternativeDistributionPackage => "alternativeDistributionPackage",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.App => "app",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.AppClipDefaultExperience => "appClipDefaultExperience",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.AppStoreReviewDetail => "appStoreReviewDetail",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.AppStoreState => "appStoreState",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionExperiments => "appStoreVersionExperiments",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionLocalizations => "appStoreVersionLocalizations",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionPhasedRelease => "appStoreVersionPhasedRelease",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionSubmission => "appStoreVersionSubmission",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.AppVersionState => "appVersionState",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.Build => "build",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.Copyright => "copyright",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.CreatedDate => "createdDate",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.CustomerReviews => "customerReviews",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.Downloadable => "downloadable",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.EarliestReleaseDate => "earliestReleaseDate",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.GameCenterAppVersion => "gameCenterAppVersion",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.Platform => "platform",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.ReleaseType => "releaseType",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.ReviewType => "reviewType",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.RoutingAppCoverage => "routingAppCoverage",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.UsesIdfa => "usesIdfa",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.VersionString => "versionString",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionPackage" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.AlternativeDistributionPackage,
                "app" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.App,
                "appClipDefaultExperience" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.AppClipDefaultExperience,
                "appStoreReviewDetail" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.AppStoreReviewDetail,
                "appStoreState" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.AppStoreState,
                "appStoreVersionExperiments" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionExperiments,
                "appStoreVersionExperimentsV2" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionExperimentsV2,
                "appStoreVersionLocalizations" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionLocalizations,
                "appStoreVersionPhasedRelease" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionPhasedRelease,
                "appStoreVersionSubmission" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionSubmission,
                "appVersionState" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.AppVersionState,
                "build" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.Build,
                "copyright" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.Copyright,
                "createdDate" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.CreatedDate,
                "customerReviews" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.CustomerReviews,
                "downloadable" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.Downloadable,
                "earliestReleaseDate" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.EarliestReleaseDate,
                "gameCenterAppVersion" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.GameCenterAppVersion,
                "platform" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.Platform,
                "releaseType" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.ReleaseType,
                "reviewType" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.ReviewType,
                "routingAppCoverage" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.RoutingAppCoverage,
                "usesIdfa" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.UsesIdfa,
                "versionString" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.VersionString,
                _ => null,
            };
        }
    }
}