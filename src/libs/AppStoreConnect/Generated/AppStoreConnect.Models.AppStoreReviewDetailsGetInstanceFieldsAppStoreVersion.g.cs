
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreReviewDetailsGetInstanceFieldsAppStoreVersion
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
    public static class AppStoreReviewDetailsGetInstanceFieldsAppStoreVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreReviewDetailsGetInstanceFieldsAppStoreVersion value)
        {
            return value switch
            {
                AppStoreReviewDetailsGetInstanceFieldsAppStoreVersion.AlternativeDistributionPackage => "alternativeDistributionPackage",
                AppStoreReviewDetailsGetInstanceFieldsAppStoreVersion.App => "app",
                AppStoreReviewDetailsGetInstanceFieldsAppStoreVersion.AppClipDefaultExperience => "appClipDefaultExperience",
                AppStoreReviewDetailsGetInstanceFieldsAppStoreVersion.AppStoreReviewDetail => "appStoreReviewDetail",
                AppStoreReviewDetailsGetInstanceFieldsAppStoreVersion.AppStoreState => "appStoreState",
                AppStoreReviewDetailsGetInstanceFieldsAppStoreVersion.AppStoreVersionExperiments => "appStoreVersionExperiments",
                AppStoreReviewDetailsGetInstanceFieldsAppStoreVersion.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                AppStoreReviewDetailsGetInstanceFieldsAppStoreVersion.AppStoreVersionLocalizations => "appStoreVersionLocalizations",
                AppStoreReviewDetailsGetInstanceFieldsAppStoreVersion.AppStoreVersionPhasedRelease => "appStoreVersionPhasedRelease",
                AppStoreReviewDetailsGetInstanceFieldsAppStoreVersion.AppStoreVersionSubmission => "appStoreVersionSubmission",
                AppStoreReviewDetailsGetInstanceFieldsAppStoreVersion.AppVersionState => "appVersionState",
                AppStoreReviewDetailsGetInstanceFieldsAppStoreVersion.Build => "build",
                AppStoreReviewDetailsGetInstanceFieldsAppStoreVersion.Copyright => "copyright",
                AppStoreReviewDetailsGetInstanceFieldsAppStoreVersion.CreatedDate => "createdDate",
                AppStoreReviewDetailsGetInstanceFieldsAppStoreVersion.CustomerReviews => "customerReviews",
                AppStoreReviewDetailsGetInstanceFieldsAppStoreVersion.Downloadable => "downloadable",
                AppStoreReviewDetailsGetInstanceFieldsAppStoreVersion.EarliestReleaseDate => "earliestReleaseDate",
                AppStoreReviewDetailsGetInstanceFieldsAppStoreVersion.GameCenterAppVersion => "gameCenterAppVersion",
                AppStoreReviewDetailsGetInstanceFieldsAppStoreVersion.Platform => "platform",
                AppStoreReviewDetailsGetInstanceFieldsAppStoreVersion.ReleaseType => "releaseType",
                AppStoreReviewDetailsGetInstanceFieldsAppStoreVersion.ReviewType => "reviewType",
                AppStoreReviewDetailsGetInstanceFieldsAppStoreVersion.RoutingAppCoverage => "routingAppCoverage",
                AppStoreReviewDetailsGetInstanceFieldsAppStoreVersion.UsesIdfa => "usesIdfa",
                AppStoreReviewDetailsGetInstanceFieldsAppStoreVersion.VersionString => "versionString",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreReviewDetailsGetInstanceFieldsAppStoreVersion? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionPackage" => AppStoreReviewDetailsGetInstanceFieldsAppStoreVersion.AlternativeDistributionPackage,
                "app" => AppStoreReviewDetailsGetInstanceFieldsAppStoreVersion.App,
                "appClipDefaultExperience" => AppStoreReviewDetailsGetInstanceFieldsAppStoreVersion.AppClipDefaultExperience,
                "appStoreReviewDetail" => AppStoreReviewDetailsGetInstanceFieldsAppStoreVersion.AppStoreReviewDetail,
                "appStoreState" => AppStoreReviewDetailsGetInstanceFieldsAppStoreVersion.AppStoreState,
                "appStoreVersionExperiments" => AppStoreReviewDetailsGetInstanceFieldsAppStoreVersion.AppStoreVersionExperiments,
                "appStoreVersionExperimentsV2" => AppStoreReviewDetailsGetInstanceFieldsAppStoreVersion.AppStoreVersionExperimentsV2,
                "appStoreVersionLocalizations" => AppStoreReviewDetailsGetInstanceFieldsAppStoreVersion.AppStoreVersionLocalizations,
                "appStoreVersionPhasedRelease" => AppStoreReviewDetailsGetInstanceFieldsAppStoreVersion.AppStoreVersionPhasedRelease,
                "appStoreVersionSubmission" => AppStoreReviewDetailsGetInstanceFieldsAppStoreVersion.AppStoreVersionSubmission,
                "appVersionState" => AppStoreReviewDetailsGetInstanceFieldsAppStoreVersion.AppVersionState,
                "build" => AppStoreReviewDetailsGetInstanceFieldsAppStoreVersion.Build,
                "copyright" => AppStoreReviewDetailsGetInstanceFieldsAppStoreVersion.Copyright,
                "createdDate" => AppStoreReviewDetailsGetInstanceFieldsAppStoreVersion.CreatedDate,
                "customerReviews" => AppStoreReviewDetailsGetInstanceFieldsAppStoreVersion.CustomerReviews,
                "downloadable" => AppStoreReviewDetailsGetInstanceFieldsAppStoreVersion.Downloadable,
                "earliestReleaseDate" => AppStoreReviewDetailsGetInstanceFieldsAppStoreVersion.EarliestReleaseDate,
                "gameCenterAppVersion" => AppStoreReviewDetailsGetInstanceFieldsAppStoreVersion.GameCenterAppVersion,
                "platform" => AppStoreReviewDetailsGetInstanceFieldsAppStoreVersion.Platform,
                "releaseType" => AppStoreReviewDetailsGetInstanceFieldsAppStoreVersion.ReleaseType,
                "reviewType" => AppStoreReviewDetailsGetInstanceFieldsAppStoreVersion.ReviewType,
                "routingAppCoverage" => AppStoreReviewDetailsGetInstanceFieldsAppStoreVersion.RoutingAppCoverage,
                "usesIdfa" => AppStoreReviewDetailsGetInstanceFieldsAppStoreVersion.UsesIdfa,
                "versionString" => AppStoreReviewDetailsGetInstanceFieldsAppStoreVersion.VersionString,
                _ => null,
            };
        }
    }
}