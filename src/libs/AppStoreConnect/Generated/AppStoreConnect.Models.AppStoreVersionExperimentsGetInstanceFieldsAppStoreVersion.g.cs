
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersion
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
    public static class AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersion value)
        {
            return value switch
            {
                AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersion.AlternativeDistributionPackage => "alternativeDistributionPackage",
                AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersion.App => "app",
                AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersion.AppClipDefaultExperience => "appClipDefaultExperience",
                AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersion.AppStoreReviewDetail => "appStoreReviewDetail",
                AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersion.AppStoreState => "appStoreState",
                AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersion.AppStoreVersionExperiments => "appStoreVersionExperiments",
                AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersion.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersion.AppStoreVersionLocalizations => "appStoreVersionLocalizations",
                AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersion.AppStoreVersionPhasedRelease => "appStoreVersionPhasedRelease",
                AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersion.AppStoreVersionSubmission => "appStoreVersionSubmission",
                AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersion.AppVersionState => "appVersionState",
                AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersion.Build => "build",
                AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersion.Copyright => "copyright",
                AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersion.CreatedDate => "createdDate",
                AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersion.CustomerReviews => "customerReviews",
                AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersion.Downloadable => "downloadable",
                AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersion.EarliestReleaseDate => "earliestReleaseDate",
                AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersion.GameCenterAppVersion => "gameCenterAppVersion",
                AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersion.Platform => "platform",
                AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersion.ReleaseType => "releaseType",
                AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersion.ReviewType => "reviewType",
                AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersion.RoutingAppCoverage => "routingAppCoverage",
                AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersion.UsesIdfa => "usesIdfa",
                AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersion.VersionString => "versionString",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersion? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionPackage" => AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersion.AlternativeDistributionPackage,
                "app" => AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersion.App,
                "appClipDefaultExperience" => AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersion.AppClipDefaultExperience,
                "appStoreReviewDetail" => AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersion.AppStoreReviewDetail,
                "appStoreState" => AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersion.AppStoreState,
                "appStoreVersionExperiments" => AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersion.AppStoreVersionExperiments,
                "appStoreVersionExperimentsV2" => AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersion.AppStoreVersionExperimentsV2,
                "appStoreVersionLocalizations" => AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersion.AppStoreVersionLocalizations,
                "appStoreVersionPhasedRelease" => AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersion.AppStoreVersionPhasedRelease,
                "appStoreVersionSubmission" => AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersion.AppStoreVersionSubmission,
                "appVersionState" => AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersion.AppVersionState,
                "build" => AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersion.Build,
                "copyright" => AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersion.Copyright,
                "createdDate" => AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersion.CreatedDate,
                "customerReviews" => AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersion.CustomerReviews,
                "downloadable" => AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersion.Downloadable,
                "earliestReleaseDate" => AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersion.EarliestReleaseDate,
                "gameCenterAppVersion" => AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersion.GameCenterAppVersion,
                "platform" => AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersion.Platform,
                "releaseType" => AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersion.ReleaseType,
                "reviewType" => AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersion.ReviewType,
                "routingAppCoverage" => AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersion.RoutingAppCoverage,
                "usesIdfa" => AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersion.UsesIdfa,
                "versionString" => AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersion.VersionString,
                _ => null,
            };
        }
    }
}