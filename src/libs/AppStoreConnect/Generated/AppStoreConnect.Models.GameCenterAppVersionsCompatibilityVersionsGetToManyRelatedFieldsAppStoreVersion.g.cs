
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedFieldsAppStoreVersion
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
    public static class GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedFieldsAppStoreVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedFieldsAppStoreVersion value)
        {
            return value switch
            {
                GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedFieldsAppStoreVersion.AlternativeDistributionPackage => "alternativeDistributionPackage",
                GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedFieldsAppStoreVersion.App => "app",
                GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedFieldsAppStoreVersion.AppClipDefaultExperience => "appClipDefaultExperience",
                GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedFieldsAppStoreVersion.AppStoreReviewDetail => "appStoreReviewDetail",
                GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedFieldsAppStoreVersion.AppStoreState => "appStoreState",
                GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionExperiments => "appStoreVersionExperiments",
                GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionLocalizations => "appStoreVersionLocalizations",
                GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionPhasedRelease => "appStoreVersionPhasedRelease",
                GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionSubmission => "appStoreVersionSubmission",
                GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedFieldsAppStoreVersion.AppVersionState => "appVersionState",
                GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedFieldsAppStoreVersion.Build => "build",
                GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedFieldsAppStoreVersion.Copyright => "copyright",
                GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedFieldsAppStoreVersion.CreatedDate => "createdDate",
                GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedFieldsAppStoreVersion.CustomerReviews => "customerReviews",
                GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedFieldsAppStoreVersion.Downloadable => "downloadable",
                GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedFieldsAppStoreVersion.EarliestReleaseDate => "earliestReleaseDate",
                GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedFieldsAppStoreVersion.GameCenterAppVersion => "gameCenterAppVersion",
                GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedFieldsAppStoreVersion.Platform => "platform",
                GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedFieldsAppStoreVersion.ReleaseType => "releaseType",
                GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedFieldsAppStoreVersion.ReviewType => "reviewType",
                GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedFieldsAppStoreVersion.RoutingAppCoverage => "routingAppCoverage",
                GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedFieldsAppStoreVersion.UsesIdfa => "usesIdfa",
                GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedFieldsAppStoreVersion.VersionString => "versionString",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedFieldsAppStoreVersion? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionPackage" => GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedFieldsAppStoreVersion.AlternativeDistributionPackage,
                "app" => GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedFieldsAppStoreVersion.App,
                "appClipDefaultExperience" => GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedFieldsAppStoreVersion.AppClipDefaultExperience,
                "appStoreReviewDetail" => GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedFieldsAppStoreVersion.AppStoreReviewDetail,
                "appStoreState" => GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedFieldsAppStoreVersion.AppStoreState,
                "appStoreVersionExperiments" => GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionExperiments,
                "appStoreVersionExperimentsV2" => GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionExperimentsV2,
                "appStoreVersionLocalizations" => GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionLocalizations,
                "appStoreVersionPhasedRelease" => GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionPhasedRelease,
                "appStoreVersionSubmission" => GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionSubmission,
                "appVersionState" => GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedFieldsAppStoreVersion.AppVersionState,
                "build" => GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedFieldsAppStoreVersion.Build,
                "copyright" => GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedFieldsAppStoreVersion.Copyright,
                "createdDate" => GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedFieldsAppStoreVersion.CreatedDate,
                "customerReviews" => GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedFieldsAppStoreVersion.CustomerReviews,
                "downloadable" => GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedFieldsAppStoreVersion.Downloadable,
                "earliestReleaseDate" => GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedFieldsAppStoreVersion.EarliestReleaseDate,
                "gameCenterAppVersion" => GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedFieldsAppStoreVersion.GameCenterAppVersion,
                "platform" => GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedFieldsAppStoreVersion.Platform,
                "releaseType" => GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedFieldsAppStoreVersion.ReleaseType,
                "reviewType" => GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedFieldsAppStoreVersion.ReviewType,
                "routingAppCoverage" => GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedFieldsAppStoreVersion.RoutingAppCoverage,
                "usesIdfa" => GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedFieldsAppStoreVersion.UsesIdfa,
                "versionString" => GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedFieldsAppStoreVersion.VersionString,
                _ => null,
            };
        }
    }
}