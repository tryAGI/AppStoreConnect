
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion
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
    public static class BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion value)
        {
            return value switch
            {
                BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.AlternativeDistributionPackage => "alternativeDistributionPackage",
                BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.App => "app",
                BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.AppClipDefaultExperience => "appClipDefaultExperience",
                BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.AppStoreReviewDetail => "appStoreReviewDetail",
                BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.AppStoreState => "appStoreState",
                BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionExperiments => "appStoreVersionExperiments",
                BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionLocalizations => "appStoreVersionLocalizations",
                BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionPhasedRelease => "appStoreVersionPhasedRelease",
                BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionSubmission => "appStoreVersionSubmission",
                BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.AppVersionState => "appVersionState",
                BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.Build => "build",
                BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.Copyright => "copyright",
                BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.CreatedDate => "createdDate",
                BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.CustomerReviews => "customerReviews",
                BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.Downloadable => "downloadable",
                BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.EarliestReleaseDate => "earliestReleaseDate",
                BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.GameCenterAppVersion => "gameCenterAppVersion",
                BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.Platform => "platform",
                BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.ReleaseType => "releaseType",
                BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.ReviewType => "reviewType",
                BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.RoutingAppCoverage => "routingAppCoverage",
                BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.UsesIdfa => "usesIdfa",
                BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.VersionString => "versionString",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionPackage" => BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.AlternativeDistributionPackage,
                "app" => BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.App,
                "appClipDefaultExperience" => BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.AppClipDefaultExperience,
                "appStoreReviewDetail" => BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.AppStoreReviewDetail,
                "appStoreState" => BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.AppStoreState,
                "appStoreVersionExperiments" => BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionExperiments,
                "appStoreVersionExperimentsV2" => BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionExperimentsV2,
                "appStoreVersionLocalizations" => BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionLocalizations,
                "appStoreVersionPhasedRelease" => BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionPhasedRelease,
                "appStoreVersionSubmission" => BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionSubmission,
                "appVersionState" => BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.AppVersionState,
                "build" => BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.Build,
                "copyright" => BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.Copyright,
                "createdDate" => BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.CreatedDate,
                "customerReviews" => BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.CustomerReviews,
                "downloadable" => BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.Downloadable,
                "earliestReleaseDate" => BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.EarliestReleaseDate,
                "gameCenterAppVersion" => BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.GameCenterAppVersion,
                "platform" => BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.Platform,
                "releaseType" => BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.ReleaseType,
                "reviewType" => BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.ReviewType,
                "routingAppCoverage" => BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.RoutingAppCoverage,
                "usesIdfa" => BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.UsesIdfa,
                "versionString" => BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersion.VersionString,
                _ => null,
            };
        }
    }
}