
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsGetInstanceFieldsAppStoreVersion
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
    public static class AppsGetInstanceFieldsAppStoreVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGetInstanceFieldsAppStoreVersion value)
        {
            return value switch
            {
                AppsGetInstanceFieldsAppStoreVersion.AlternativeDistributionPackage => "alternativeDistributionPackage",
                AppsGetInstanceFieldsAppStoreVersion.App => "app",
                AppsGetInstanceFieldsAppStoreVersion.AppClipDefaultExperience => "appClipDefaultExperience",
                AppsGetInstanceFieldsAppStoreVersion.AppStoreReviewDetail => "appStoreReviewDetail",
                AppsGetInstanceFieldsAppStoreVersion.AppStoreState => "appStoreState",
                AppsGetInstanceFieldsAppStoreVersion.AppStoreVersionExperiments => "appStoreVersionExperiments",
                AppsGetInstanceFieldsAppStoreVersion.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                AppsGetInstanceFieldsAppStoreVersion.AppStoreVersionLocalizations => "appStoreVersionLocalizations",
                AppsGetInstanceFieldsAppStoreVersion.AppStoreVersionPhasedRelease => "appStoreVersionPhasedRelease",
                AppsGetInstanceFieldsAppStoreVersion.AppStoreVersionSubmission => "appStoreVersionSubmission",
                AppsGetInstanceFieldsAppStoreVersion.AppVersionState => "appVersionState",
                AppsGetInstanceFieldsAppStoreVersion.Build => "build",
                AppsGetInstanceFieldsAppStoreVersion.Copyright => "copyright",
                AppsGetInstanceFieldsAppStoreVersion.CreatedDate => "createdDate",
                AppsGetInstanceFieldsAppStoreVersion.CustomerReviews => "customerReviews",
                AppsGetInstanceFieldsAppStoreVersion.Downloadable => "downloadable",
                AppsGetInstanceFieldsAppStoreVersion.EarliestReleaseDate => "earliestReleaseDate",
                AppsGetInstanceFieldsAppStoreVersion.GameCenterAppVersion => "gameCenterAppVersion",
                AppsGetInstanceFieldsAppStoreVersion.Platform => "platform",
                AppsGetInstanceFieldsAppStoreVersion.ReleaseType => "releaseType",
                AppsGetInstanceFieldsAppStoreVersion.ReviewType => "reviewType",
                AppsGetInstanceFieldsAppStoreVersion.RoutingAppCoverage => "routingAppCoverage",
                AppsGetInstanceFieldsAppStoreVersion.UsesIdfa => "usesIdfa",
                AppsGetInstanceFieldsAppStoreVersion.VersionString => "versionString",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGetInstanceFieldsAppStoreVersion? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionPackage" => AppsGetInstanceFieldsAppStoreVersion.AlternativeDistributionPackage,
                "app" => AppsGetInstanceFieldsAppStoreVersion.App,
                "appClipDefaultExperience" => AppsGetInstanceFieldsAppStoreVersion.AppClipDefaultExperience,
                "appStoreReviewDetail" => AppsGetInstanceFieldsAppStoreVersion.AppStoreReviewDetail,
                "appStoreState" => AppsGetInstanceFieldsAppStoreVersion.AppStoreState,
                "appStoreVersionExperiments" => AppsGetInstanceFieldsAppStoreVersion.AppStoreVersionExperiments,
                "appStoreVersionExperimentsV2" => AppsGetInstanceFieldsAppStoreVersion.AppStoreVersionExperimentsV2,
                "appStoreVersionLocalizations" => AppsGetInstanceFieldsAppStoreVersion.AppStoreVersionLocalizations,
                "appStoreVersionPhasedRelease" => AppsGetInstanceFieldsAppStoreVersion.AppStoreVersionPhasedRelease,
                "appStoreVersionSubmission" => AppsGetInstanceFieldsAppStoreVersion.AppStoreVersionSubmission,
                "appVersionState" => AppsGetInstanceFieldsAppStoreVersion.AppVersionState,
                "build" => AppsGetInstanceFieldsAppStoreVersion.Build,
                "copyright" => AppsGetInstanceFieldsAppStoreVersion.Copyright,
                "createdDate" => AppsGetInstanceFieldsAppStoreVersion.CreatedDate,
                "customerReviews" => AppsGetInstanceFieldsAppStoreVersion.CustomerReviews,
                "downloadable" => AppsGetInstanceFieldsAppStoreVersion.Downloadable,
                "earliestReleaseDate" => AppsGetInstanceFieldsAppStoreVersion.EarliestReleaseDate,
                "gameCenterAppVersion" => AppsGetInstanceFieldsAppStoreVersion.GameCenterAppVersion,
                "platform" => AppsGetInstanceFieldsAppStoreVersion.Platform,
                "releaseType" => AppsGetInstanceFieldsAppStoreVersion.ReleaseType,
                "reviewType" => AppsGetInstanceFieldsAppStoreVersion.ReviewType,
                "routingAppCoverage" => AppsGetInstanceFieldsAppStoreVersion.RoutingAppCoverage,
                "usesIdfa" => AppsGetInstanceFieldsAppStoreVersion.UsesIdfa,
                "versionString" => AppsGetInstanceFieldsAppStoreVersion.VersionString,
                _ => null,
            };
        }
    }
}