
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum RoutingAppCoveragesGetInstanceFieldsAppStoreVersion
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
    public static class RoutingAppCoveragesGetInstanceFieldsAppStoreVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RoutingAppCoveragesGetInstanceFieldsAppStoreVersion value)
        {
            return value switch
            {
                RoutingAppCoveragesGetInstanceFieldsAppStoreVersion.AlternativeDistributionPackage => "alternativeDistributionPackage",
                RoutingAppCoveragesGetInstanceFieldsAppStoreVersion.App => "app",
                RoutingAppCoveragesGetInstanceFieldsAppStoreVersion.AppClipDefaultExperience => "appClipDefaultExperience",
                RoutingAppCoveragesGetInstanceFieldsAppStoreVersion.AppStoreReviewDetail => "appStoreReviewDetail",
                RoutingAppCoveragesGetInstanceFieldsAppStoreVersion.AppStoreState => "appStoreState",
                RoutingAppCoveragesGetInstanceFieldsAppStoreVersion.AppStoreVersionExperiments => "appStoreVersionExperiments",
                RoutingAppCoveragesGetInstanceFieldsAppStoreVersion.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                RoutingAppCoveragesGetInstanceFieldsAppStoreVersion.AppStoreVersionLocalizations => "appStoreVersionLocalizations",
                RoutingAppCoveragesGetInstanceFieldsAppStoreVersion.AppStoreVersionPhasedRelease => "appStoreVersionPhasedRelease",
                RoutingAppCoveragesGetInstanceFieldsAppStoreVersion.AppStoreVersionSubmission => "appStoreVersionSubmission",
                RoutingAppCoveragesGetInstanceFieldsAppStoreVersion.AppVersionState => "appVersionState",
                RoutingAppCoveragesGetInstanceFieldsAppStoreVersion.Build => "build",
                RoutingAppCoveragesGetInstanceFieldsAppStoreVersion.Copyright => "copyright",
                RoutingAppCoveragesGetInstanceFieldsAppStoreVersion.CreatedDate => "createdDate",
                RoutingAppCoveragesGetInstanceFieldsAppStoreVersion.CustomerReviews => "customerReviews",
                RoutingAppCoveragesGetInstanceFieldsAppStoreVersion.Downloadable => "downloadable",
                RoutingAppCoveragesGetInstanceFieldsAppStoreVersion.EarliestReleaseDate => "earliestReleaseDate",
                RoutingAppCoveragesGetInstanceFieldsAppStoreVersion.GameCenterAppVersion => "gameCenterAppVersion",
                RoutingAppCoveragesGetInstanceFieldsAppStoreVersion.Platform => "platform",
                RoutingAppCoveragesGetInstanceFieldsAppStoreVersion.ReleaseType => "releaseType",
                RoutingAppCoveragesGetInstanceFieldsAppStoreVersion.ReviewType => "reviewType",
                RoutingAppCoveragesGetInstanceFieldsAppStoreVersion.RoutingAppCoverage => "routingAppCoverage",
                RoutingAppCoveragesGetInstanceFieldsAppStoreVersion.UsesIdfa => "usesIdfa",
                RoutingAppCoveragesGetInstanceFieldsAppStoreVersion.VersionString => "versionString",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RoutingAppCoveragesGetInstanceFieldsAppStoreVersion? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionPackage" => RoutingAppCoveragesGetInstanceFieldsAppStoreVersion.AlternativeDistributionPackage,
                "app" => RoutingAppCoveragesGetInstanceFieldsAppStoreVersion.App,
                "appClipDefaultExperience" => RoutingAppCoveragesGetInstanceFieldsAppStoreVersion.AppClipDefaultExperience,
                "appStoreReviewDetail" => RoutingAppCoveragesGetInstanceFieldsAppStoreVersion.AppStoreReviewDetail,
                "appStoreState" => RoutingAppCoveragesGetInstanceFieldsAppStoreVersion.AppStoreState,
                "appStoreVersionExperiments" => RoutingAppCoveragesGetInstanceFieldsAppStoreVersion.AppStoreVersionExperiments,
                "appStoreVersionExperimentsV2" => RoutingAppCoveragesGetInstanceFieldsAppStoreVersion.AppStoreVersionExperimentsV2,
                "appStoreVersionLocalizations" => RoutingAppCoveragesGetInstanceFieldsAppStoreVersion.AppStoreVersionLocalizations,
                "appStoreVersionPhasedRelease" => RoutingAppCoveragesGetInstanceFieldsAppStoreVersion.AppStoreVersionPhasedRelease,
                "appStoreVersionSubmission" => RoutingAppCoveragesGetInstanceFieldsAppStoreVersion.AppStoreVersionSubmission,
                "appVersionState" => RoutingAppCoveragesGetInstanceFieldsAppStoreVersion.AppVersionState,
                "build" => RoutingAppCoveragesGetInstanceFieldsAppStoreVersion.Build,
                "copyright" => RoutingAppCoveragesGetInstanceFieldsAppStoreVersion.Copyright,
                "createdDate" => RoutingAppCoveragesGetInstanceFieldsAppStoreVersion.CreatedDate,
                "customerReviews" => RoutingAppCoveragesGetInstanceFieldsAppStoreVersion.CustomerReviews,
                "downloadable" => RoutingAppCoveragesGetInstanceFieldsAppStoreVersion.Downloadable,
                "earliestReleaseDate" => RoutingAppCoveragesGetInstanceFieldsAppStoreVersion.EarliestReleaseDate,
                "gameCenterAppVersion" => RoutingAppCoveragesGetInstanceFieldsAppStoreVersion.GameCenterAppVersion,
                "platform" => RoutingAppCoveragesGetInstanceFieldsAppStoreVersion.Platform,
                "releaseType" => RoutingAppCoveragesGetInstanceFieldsAppStoreVersion.ReleaseType,
                "reviewType" => RoutingAppCoveragesGetInstanceFieldsAppStoreVersion.ReviewType,
                "routingAppCoverage" => RoutingAppCoveragesGetInstanceFieldsAppStoreVersion.RoutingAppCoverage,
                "usesIdfa" => RoutingAppCoveragesGetInstanceFieldsAppStoreVersion.UsesIdfa,
                "versionString" => RoutingAppCoveragesGetInstanceFieldsAppStoreVersion.VersionString,
                _ => null,
            };
        }
    }
}