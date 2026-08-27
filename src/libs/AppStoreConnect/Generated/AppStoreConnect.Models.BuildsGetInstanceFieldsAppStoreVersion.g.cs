
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildsGetInstanceFieldsAppStoreVersion
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
    public static class BuildsGetInstanceFieldsAppStoreVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildsGetInstanceFieldsAppStoreVersion value)
        {
            return value switch
            {
                BuildsGetInstanceFieldsAppStoreVersion.AlternativeDistributionPackage => "alternativeDistributionPackage",
                BuildsGetInstanceFieldsAppStoreVersion.App => "app",
                BuildsGetInstanceFieldsAppStoreVersion.AppClipDefaultExperience => "appClipDefaultExperience",
                BuildsGetInstanceFieldsAppStoreVersion.AppStoreReviewDetail => "appStoreReviewDetail",
                BuildsGetInstanceFieldsAppStoreVersion.AppStoreState => "appStoreState",
                BuildsGetInstanceFieldsAppStoreVersion.AppStoreVersionExperiments => "appStoreVersionExperiments",
                BuildsGetInstanceFieldsAppStoreVersion.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                BuildsGetInstanceFieldsAppStoreVersion.AppStoreVersionLocalizations => "appStoreVersionLocalizations",
                BuildsGetInstanceFieldsAppStoreVersion.AppStoreVersionPhasedRelease => "appStoreVersionPhasedRelease",
                BuildsGetInstanceFieldsAppStoreVersion.AppStoreVersionSubmission => "appStoreVersionSubmission",
                BuildsGetInstanceFieldsAppStoreVersion.AppVersionState => "appVersionState",
                BuildsGetInstanceFieldsAppStoreVersion.Build => "build",
                BuildsGetInstanceFieldsAppStoreVersion.Copyright => "copyright",
                BuildsGetInstanceFieldsAppStoreVersion.CreatedDate => "createdDate",
                BuildsGetInstanceFieldsAppStoreVersion.CustomerReviews => "customerReviews",
                BuildsGetInstanceFieldsAppStoreVersion.Downloadable => "downloadable",
                BuildsGetInstanceFieldsAppStoreVersion.EarliestReleaseDate => "earliestReleaseDate",
                BuildsGetInstanceFieldsAppStoreVersion.GameCenterAppVersion => "gameCenterAppVersion",
                BuildsGetInstanceFieldsAppStoreVersion.Platform => "platform",
                BuildsGetInstanceFieldsAppStoreVersion.ReleaseType => "releaseType",
                BuildsGetInstanceFieldsAppStoreVersion.ReviewType => "reviewType",
                BuildsGetInstanceFieldsAppStoreVersion.RoutingAppCoverage => "routingAppCoverage",
                BuildsGetInstanceFieldsAppStoreVersion.UsesIdfa => "usesIdfa",
                BuildsGetInstanceFieldsAppStoreVersion.VersionString => "versionString",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildsGetInstanceFieldsAppStoreVersion? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionPackage" => BuildsGetInstanceFieldsAppStoreVersion.AlternativeDistributionPackage,
                "app" => BuildsGetInstanceFieldsAppStoreVersion.App,
                "appClipDefaultExperience" => BuildsGetInstanceFieldsAppStoreVersion.AppClipDefaultExperience,
                "appStoreReviewDetail" => BuildsGetInstanceFieldsAppStoreVersion.AppStoreReviewDetail,
                "appStoreState" => BuildsGetInstanceFieldsAppStoreVersion.AppStoreState,
                "appStoreVersionExperiments" => BuildsGetInstanceFieldsAppStoreVersion.AppStoreVersionExperiments,
                "appStoreVersionExperimentsV2" => BuildsGetInstanceFieldsAppStoreVersion.AppStoreVersionExperimentsV2,
                "appStoreVersionLocalizations" => BuildsGetInstanceFieldsAppStoreVersion.AppStoreVersionLocalizations,
                "appStoreVersionPhasedRelease" => BuildsGetInstanceFieldsAppStoreVersion.AppStoreVersionPhasedRelease,
                "appStoreVersionSubmission" => BuildsGetInstanceFieldsAppStoreVersion.AppStoreVersionSubmission,
                "appVersionState" => BuildsGetInstanceFieldsAppStoreVersion.AppVersionState,
                "build" => BuildsGetInstanceFieldsAppStoreVersion.Build,
                "copyright" => BuildsGetInstanceFieldsAppStoreVersion.Copyright,
                "createdDate" => BuildsGetInstanceFieldsAppStoreVersion.CreatedDate,
                "customerReviews" => BuildsGetInstanceFieldsAppStoreVersion.CustomerReviews,
                "downloadable" => BuildsGetInstanceFieldsAppStoreVersion.Downloadable,
                "earliestReleaseDate" => BuildsGetInstanceFieldsAppStoreVersion.EarliestReleaseDate,
                "gameCenterAppVersion" => BuildsGetInstanceFieldsAppStoreVersion.GameCenterAppVersion,
                "platform" => BuildsGetInstanceFieldsAppStoreVersion.Platform,
                "releaseType" => BuildsGetInstanceFieldsAppStoreVersion.ReleaseType,
                "reviewType" => BuildsGetInstanceFieldsAppStoreVersion.ReviewType,
                "routingAppCoverage" => BuildsGetInstanceFieldsAppStoreVersion.RoutingAppCoverage,
                "usesIdfa" => BuildsGetInstanceFieldsAppStoreVersion.UsesIdfa,
                "versionString" => BuildsGetInstanceFieldsAppStoreVersion.VersionString,
                _ => null,
            };
        }
    }
}