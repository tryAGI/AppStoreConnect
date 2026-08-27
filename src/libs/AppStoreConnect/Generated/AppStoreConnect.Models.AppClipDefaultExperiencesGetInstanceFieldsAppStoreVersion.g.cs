
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppClipDefaultExperiencesGetInstanceFieldsAppStoreVersion
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
    public static class AppClipDefaultExperiencesGetInstanceFieldsAppStoreVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipDefaultExperiencesGetInstanceFieldsAppStoreVersion value)
        {
            return value switch
            {
                AppClipDefaultExperiencesGetInstanceFieldsAppStoreVersion.AlternativeDistributionPackage => "alternativeDistributionPackage",
                AppClipDefaultExperiencesGetInstanceFieldsAppStoreVersion.App => "app",
                AppClipDefaultExperiencesGetInstanceFieldsAppStoreVersion.AppClipDefaultExperience => "appClipDefaultExperience",
                AppClipDefaultExperiencesGetInstanceFieldsAppStoreVersion.AppStoreReviewDetail => "appStoreReviewDetail",
                AppClipDefaultExperiencesGetInstanceFieldsAppStoreVersion.AppStoreState => "appStoreState",
                AppClipDefaultExperiencesGetInstanceFieldsAppStoreVersion.AppStoreVersionExperiments => "appStoreVersionExperiments",
                AppClipDefaultExperiencesGetInstanceFieldsAppStoreVersion.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                AppClipDefaultExperiencesGetInstanceFieldsAppStoreVersion.AppStoreVersionLocalizations => "appStoreVersionLocalizations",
                AppClipDefaultExperiencesGetInstanceFieldsAppStoreVersion.AppStoreVersionPhasedRelease => "appStoreVersionPhasedRelease",
                AppClipDefaultExperiencesGetInstanceFieldsAppStoreVersion.AppStoreVersionSubmission => "appStoreVersionSubmission",
                AppClipDefaultExperiencesGetInstanceFieldsAppStoreVersion.AppVersionState => "appVersionState",
                AppClipDefaultExperiencesGetInstanceFieldsAppStoreVersion.Build => "build",
                AppClipDefaultExperiencesGetInstanceFieldsAppStoreVersion.Copyright => "copyright",
                AppClipDefaultExperiencesGetInstanceFieldsAppStoreVersion.CreatedDate => "createdDate",
                AppClipDefaultExperiencesGetInstanceFieldsAppStoreVersion.CustomerReviews => "customerReviews",
                AppClipDefaultExperiencesGetInstanceFieldsAppStoreVersion.Downloadable => "downloadable",
                AppClipDefaultExperiencesGetInstanceFieldsAppStoreVersion.EarliestReleaseDate => "earliestReleaseDate",
                AppClipDefaultExperiencesGetInstanceFieldsAppStoreVersion.GameCenterAppVersion => "gameCenterAppVersion",
                AppClipDefaultExperiencesGetInstanceFieldsAppStoreVersion.Platform => "platform",
                AppClipDefaultExperiencesGetInstanceFieldsAppStoreVersion.ReleaseType => "releaseType",
                AppClipDefaultExperiencesGetInstanceFieldsAppStoreVersion.ReviewType => "reviewType",
                AppClipDefaultExperiencesGetInstanceFieldsAppStoreVersion.RoutingAppCoverage => "routingAppCoverage",
                AppClipDefaultExperiencesGetInstanceFieldsAppStoreVersion.UsesIdfa => "usesIdfa",
                AppClipDefaultExperiencesGetInstanceFieldsAppStoreVersion.VersionString => "versionString",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipDefaultExperiencesGetInstanceFieldsAppStoreVersion? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionPackage" => AppClipDefaultExperiencesGetInstanceFieldsAppStoreVersion.AlternativeDistributionPackage,
                "app" => AppClipDefaultExperiencesGetInstanceFieldsAppStoreVersion.App,
                "appClipDefaultExperience" => AppClipDefaultExperiencesGetInstanceFieldsAppStoreVersion.AppClipDefaultExperience,
                "appStoreReviewDetail" => AppClipDefaultExperiencesGetInstanceFieldsAppStoreVersion.AppStoreReviewDetail,
                "appStoreState" => AppClipDefaultExperiencesGetInstanceFieldsAppStoreVersion.AppStoreState,
                "appStoreVersionExperiments" => AppClipDefaultExperiencesGetInstanceFieldsAppStoreVersion.AppStoreVersionExperiments,
                "appStoreVersionExperimentsV2" => AppClipDefaultExperiencesGetInstanceFieldsAppStoreVersion.AppStoreVersionExperimentsV2,
                "appStoreVersionLocalizations" => AppClipDefaultExperiencesGetInstanceFieldsAppStoreVersion.AppStoreVersionLocalizations,
                "appStoreVersionPhasedRelease" => AppClipDefaultExperiencesGetInstanceFieldsAppStoreVersion.AppStoreVersionPhasedRelease,
                "appStoreVersionSubmission" => AppClipDefaultExperiencesGetInstanceFieldsAppStoreVersion.AppStoreVersionSubmission,
                "appVersionState" => AppClipDefaultExperiencesGetInstanceFieldsAppStoreVersion.AppVersionState,
                "build" => AppClipDefaultExperiencesGetInstanceFieldsAppStoreVersion.Build,
                "copyright" => AppClipDefaultExperiencesGetInstanceFieldsAppStoreVersion.Copyright,
                "createdDate" => AppClipDefaultExperiencesGetInstanceFieldsAppStoreVersion.CreatedDate,
                "customerReviews" => AppClipDefaultExperiencesGetInstanceFieldsAppStoreVersion.CustomerReviews,
                "downloadable" => AppClipDefaultExperiencesGetInstanceFieldsAppStoreVersion.Downloadable,
                "earliestReleaseDate" => AppClipDefaultExperiencesGetInstanceFieldsAppStoreVersion.EarliestReleaseDate,
                "gameCenterAppVersion" => AppClipDefaultExperiencesGetInstanceFieldsAppStoreVersion.GameCenterAppVersion,
                "platform" => AppClipDefaultExperiencesGetInstanceFieldsAppStoreVersion.Platform,
                "releaseType" => AppClipDefaultExperiencesGetInstanceFieldsAppStoreVersion.ReleaseType,
                "reviewType" => AppClipDefaultExperiencesGetInstanceFieldsAppStoreVersion.ReviewType,
                "routingAppCoverage" => AppClipDefaultExperiencesGetInstanceFieldsAppStoreVersion.RoutingAppCoverage,
                "usesIdfa" => AppClipDefaultExperiencesGetInstanceFieldsAppStoreVersion.UsesIdfa,
                "versionString" => AppClipDefaultExperiencesGetInstanceFieldsAppStoreVersion.VersionString,
                _ => null,
            };
        }
    }
}