
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionsGetInstanceFieldsAppStoreVersion
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
    public static class AppStoreVersionsGetInstanceFieldsAppStoreVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionsGetInstanceFieldsAppStoreVersion value)
        {
            return value switch
            {
                AppStoreVersionsGetInstanceFieldsAppStoreVersion.AlternativeDistributionPackage => "alternativeDistributionPackage",
                AppStoreVersionsGetInstanceFieldsAppStoreVersion.App => "app",
                AppStoreVersionsGetInstanceFieldsAppStoreVersion.AppClipDefaultExperience => "appClipDefaultExperience",
                AppStoreVersionsGetInstanceFieldsAppStoreVersion.AppStoreReviewDetail => "appStoreReviewDetail",
                AppStoreVersionsGetInstanceFieldsAppStoreVersion.AppStoreState => "appStoreState",
                AppStoreVersionsGetInstanceFieldsAppStoreVersion.AppStoreVersionExperiments => "appStoreVersionExperiments",
                AppStoreVersionsGetInstanceFieldsAppStoreVersion.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                AppStoreVersionsGetInstanceFieldsAppStoreVersion.AppStoreVersionLocalizations => "appStoreVersionLocalizations",
                AppStoreVersionsGetInstanceFieldsAppStoreVersion.AppStoreVersionPhasedRelease => "appStoreVersionPhasedRelease",
                AppStoreVersionsGetInstanceFieldsAppStoreVersion.AppStoreVersionSubmission => "appStoreVersionSubmission",
                AppStoreVersionsGetInstanceFieldsAppStoreVersion.AppVersionState => "appVersionState",
                AppStoreVersionsGetInstanceFieldsAppStoreVersion.Build => "build",
                AppStoreVersionsGetInstanceFieldsAppStoreVersion.Copyright => "copyright",
                AppStoreVersionsGetInstanceFieldsAppStoreVersion.CreatedDate => "createdDate",
                AppStoreVersionsGetInstanceFieldsAppStoreVersion.CustomerReviews => "customerReviews",
                AppStoreVersionsGetInstanceFieldsAppStoreVersion.Downloadable => "downloadable",
                AppStoreVersionsGetInstanceFieldsAppStoreVersion.EarliestReleaseDate => "earliestReleaseDate",
                AppStoreVersionsGetInstanceFieldsAppStoreVersion.GameCenterAppVersion => "gameCenterAppVersion",
                AppStoreVersionsGetInstanceFieldsAppStoreVersion.Platform => "platform",
                AppStoreVersionsGetInstanceFieldsAppStoreVersion.ReleaseType => "releaseType",
                AppStoreVersionsGetInstanceFieldsAppStoreVersion.ReviewType => "reviewType",
                AppStoreVersionsGetInstanceFieldsAppStoreVersion.RoutingAppCoverage => "routingAppCoverage",
                AppStoreVersionsGetInstanceFieldsAppStoreVersion.UsesIdfa => "usesIdfa",
                AppStoreVersionsGetInstanceFieldsAppStoreVersion.VersionString => "versionString",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionsGetInstanceFieldsAppStoreVersion? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionPackage" => AppStoreVersionsGetInstanceFieldsAppStoreVersion.AlternativeDistributionPackage,
                "app" => AppStoreVersionsGetInstanceFieldsAppStoreVersion.App,
                "appClipDefaultExperience" => AppStoreVersionsGetInstanceFieldsAppStoreVersion.AppClipDefaultExperience,
                "appStoreReviewDetail" => AppStoreVersionsGetInstanceFieldsAppStoreVersion.AppStoreReviewDetail,
                "appStoreState" => AppStoreVersionsGetInstanceFieldsAppStoreVersion.AppStoreState,
                "appStoreVersionExperiments" => AppStoreVersionsGetInstanceFieldsAppStoreVersion.AppStoreVersionExperiments,
                "appStoreVersionExperimentsV2" => AppStoreVersionsGetInstanceFieldsAppStoreVersion.AppStoreVersionExperimentsV2,
                "appStoreVersionLocalizations" => AppStoreVersionsGetInstanceFieldsAppStoreVersion.AppStoreVersionLocalizations,
                "appStoreVersionPhasedRelease" => AppStoreVersionsGetInstanceFieldsAppStoreVersion.AppStoreVersionPhasedRelease,
                "appStoreVersionSubmission" => AppStoreVersionsGetInstanceFieldsAppStoreVersion.AppStoreVersionSubmission,
                "appVersionState" => AppStoreVersionsGetInstanceFieldsAppStoreVersion.AppVersionState,
                "build" => AppStoreVersionsGetInstanceFieldsAppStoreVersion.Build,
                "copyright" => AppStoreVersionsGetInstanceFieldsAppStoreVersion.Copyright,
                "createdDate" => AppStoreVersionsGetInstanceFieldsAppStoreVersion.CreatedDate,
                "customerReviews" => AppStoreVersionsGetInstanceFieldsAppStoreVersion.CustomerReviews,
                "downloadable" => AppStoreVersionsGetInstanceFieldsAppStoreVersion.Downloadable,
                "earliestReleaseDate" => AppStoreVersionsGetInstanceFieldsAppStoreVersion.EarliestReleaseDate,
                "gameCenterAppVersion" => AppStoreVersionsGetInstanceFieldsAppStoreVersion.GameCenterAppVersion,
                "platform" => AppStoreVersionsGetInstanceFieldsAppStoreVersion.Platform,
                "releaseType" => AppStoreVersionsGetInstanceFieldsAppStoreVersion.ReleaseType,
                "reviewType" => AppStoreVersionsGetInstanceFieldsAppStoreVersion.ReviewType,
                "routingAppCoverage" => AppStoreVersionsGetInstanceFieldsAppStoreVersion.RoutingAppCoverage,
                "usesIdfa" => AppStoreVersionsGetInstanceFieldsAppStoreVersion.UsesIdfa,
                "versionString" => AppStoreVersionsGetInstanceFieldsAppStoreVersion.VersionString,
                _ => null,
            };
        }
    }
}