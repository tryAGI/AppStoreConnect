
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersion
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
    public static class GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersion value)
        {
            return value switch
            {
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersion.AlternativeDistributionPackage => "alternativeDistributionPackage",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersion.App => "app",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersion.AppClipDefaultExperience => "appClipDefaultExperience",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersion.AppStoreReviewDetail => "appStoreReviewDetail",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersion.AppStoreState => "appStoreState",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionExperiments => "appStoreVersionExperiments",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionLocalizations => "appStoreVersionLocalizations",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionPhasedRelease => "appStoreVersionPhasedRelease",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionSubmission => "appStoreVersionSubmission",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersion.AppVersionState => "appVersionState",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersion.Build => "build",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersion.Copyright => "copyright",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersion.CreatedDate => "createdDate",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersion.CustomerReviews => "customerReviews",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersion.Downloadable => "downloadable",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersion.EarliestReleaseDate => "earliestReleaseDate",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersion.GameCenterAppVersion => "gameCenterAppVersion",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersion.Platform => "platform",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersion.ReleaseType => "releaseType",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersion.ReviewType => "reviewType",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersion.RoutingAppCoverage => "routingAppCoverage",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersion.UsesIdfa => "usesIdfa",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersion.VersionString => "versionString",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersion? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionPackage" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersion.AlternativeDistributionPackage,
                "app" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersion.App,
                "appClipDefaultExperience" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersion.AppClipDefaultExperience,
                "appStoreReviewDetail" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersion.AppStoreReviewDetail,
                "appStoreState" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersion.AppStoreState,
                "appStoreVersionExperiments" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionExperiments,
                "appStoreVersionExperimentsV2" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionExperimentsV2,
                "appStoreVersionLocalizations" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionLocalizations,
                "appStoreVersionPhasedRelease" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionPhasedRelease,
                "appStoreVersionSubmission" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionSubmission,
                "appVersionState" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersion.AppVersionState,
                "build" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersion.Build,
                "copyright" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersion.Copyright,
                "createdDate" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersion.CreatedDate,
                "customerReviews" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersion.CustomerReviews,
                "downloadable" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersion.Downloadable,
                "earliestReleaseDate" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersion.EarliestReleaseDate,
                "gameCenterAppVersion" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersion.GameCenterAppVersion,
                "platform" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersion.Platform,
                "releaseType" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersion.ReleaseType,
                "reviewType" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersion.ReviewType,
                "routingAppCoverage" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersion.RoutingAppCoverage,
                "usesIdfa" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersion.UsesIdfa,
                "versionString" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersion.VersionString,
                _ => null,
            };
        }
    }
}