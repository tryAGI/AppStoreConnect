
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsAppStoreVersion
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
    public static class GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsAppStoreVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsAppStoreVersion value)
        {
            return value switch
            {
                GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsAppStoreVersion.AlternativeDistributionPackage => "alternativeDistributionPackage",
                GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsAppStoreVersion.App => "app",
                GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsAppStoreVersion.AppClipDefaultExperience => "appClipDefaultExperience",
                GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsAppStoreVersion.AppStoreReviewDetail => "appStoreReviewDetail",
                GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsAppStoreVersion.AppStoreState => "appStoreState",
                GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionExperiments => "appStoreVersionExperiments",
                GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionLocalizations => "appStoreVersionLocalizations",
                GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionPhasedRelease => "appStoreVersionPhasedRelease",
                GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionSubmission => "appStoreVersionSubmission",
                GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsAppStoreVersion.AppVersionState => "appVersionState",
                GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsAppStoreVersion.Build => "build",
                GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsAppStoreVersion.Copyright => "copyright",
                GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsAppStoreVersion.CreatedDate => "createdDate",
                GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsAppStoreVersion.CustomerReviews => "customerReviews",
                GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsAppStoreVersion.Downloadable => "downloadable",
                GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsAppStoreVersion.EarliestReleaseDate => "earliestReleaseDate",
                GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsAppStoreVersion.GameCenterAppVersion => "gameCenterAppVersion",
                GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsAppStoreVersion.Platform => "platform",
                GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsAppStoreVersion.ReleaseType => "releaseType",
                GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsAppStoreVersion.ReviewType => "reviewType",
                GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsAppStoreVersion.RoutingAppCoverage => "routingAppCoverage",
                GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsAppStoreVersion.UsesIdfa => "usesIdfa",
                GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsAppStoreVersion.VersionString => "versionString",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsAppStoreVersion? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionPackage" => GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsAppStoreVersion.AlternativeDistributionPackage,
                "app" => GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsAppStoreVersion.App,
                "appClipDefaultExperience" => GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsAppStoreVersion.AppClipDefaultExperience,
                "appStoreReviewDetail" => GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsAppStoreVersion.AppStoreReviewDetail,
                "appStoreState" => GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsAppStoreVersion.AppStoreState,
                "appStoreVersionExperiments" => GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionExperiments,
                "appStoreVersionExperimentsV2" => GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionExperimentsV2,
                "appStoreVersionLocalizations" => GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionLocalizations,
                "appStoreVersionPhasedRelease" => GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionPhasedRelease,
                "appStoreVersionSubmission" => GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionSubmission,
                "appVersionState" => GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsAppStoreVersion.AppVersionState,
                "build" => GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsAppStoreVersion.Build,
                "copyright" => GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsAppStoreVersion.Copyright,
                "createdDate" => GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsAppStoreVersion.CreatedDate,
                "customerReviews" => GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsAppStoreVersion.CustomerReviews,
                "downloadable" => GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsAppStoreVersion.Downloadable,
                "earliestReleaseDate" => GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsAppStoreVersion.EarliestReleaseDate,
                "gameCenterAppVersion" => GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsAppStoreVersion.GameCenterAppVersion,
                "platform" => GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsAppStoreVersion.Platform,
                "releaseType" => GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsAppStoreVersion.ReleaseType,
                "reviewType" => GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsAppStoreVersion.ReviewType,
                "routingAppCoverage" => GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsAppStoreVersion.RoutingAppCoverage,
                "usesIdfa" => GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsAppStoreVersion.UsesIdfa,
                "versionString" => GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsAppStoreVersion.VersionString,
                _ => null,
            };
        }
    }
}