
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersion
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
    public static class AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersion value)
        {
            return value switch
            {
                AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersion.AlternativeDistributionPackage => "alternativeDistributionPackage",
                AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersion.App => "app",
                AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersion.AppClipDefaultExperience => "appClipDefaultExperience",
                AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersion.AppStoreReviewDetail => "appStoreReviewDetail",
                AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersion.AppStoreState => "appStoreState",
                AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersion.AppStoreVersionExperiments => "appStoreVersionExperiments",
                AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersion.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersion.AppStoreVersionLocalizations => "appStoreVersionLocalizations",
                AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersion.AppStoreVersionPhasedRelease => "appStoreVersionPhasedRelease",
                AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersion.AppStoreVersionSubmission => "appStoreVersionSubmission",
                AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersion.AppVersionState => "appVersionState",
                AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersion.Build => "build",
                AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersion.Copyright => "copyright",
                AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersion.CreatedDate => "createdDate",
                AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersion.CustomerReviews => "customerReviews",
                AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersion.Downloadable => "downloadable",
                AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersion.EarliestReleaseDate => "earliestReleaseDate",
                AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersion.GameCenterAppVersion => "gameCenterAppVersion",
                AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersion.Platform => "platform",
                AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersion.ReleaseType => "releaseType",
                AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersion.ReviewType => "reviewType",
                AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersion.RoutingAppCoverage => "routingAppCoverage",
                AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersion.UsesIdfa => "usesIdfa",
                AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersion.VersionString => "versionString",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersion? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionPackage" => AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersion.AlternativeDistributionPackage,
                "app" => AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersion.App,
                "appClipDefaultExperience" => AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersion.AppClipDefaultExperience,
                "appStoreReviewDetail" => AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersion.AppStoreReviewDetail,
                "appStoreState" => AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersion.AppStoreState,
                "appStoreVersionExperiments" => AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersion.AppStoreVersionExperiments,
                "appStoreVersionExperimentsV2" => AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersion.AppStoreVersionExperimentsV2,
                "appStoreVersionLocalizations" => AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersion.AppStoreVersionLocalizations,
                "appStoreVersionPhasedRelease" => AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersion.AppStoreVersionPhasedRelease,
                "appStoreVersionSubmission" => AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersion.AppStoreVersionSubmission,
                "appVersionState" => AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersion.AppVersionState,
                "build" => AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersion.Build,
                "copyright" => AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersion.Copyright,
                "createdDate" => AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersion.CreatedDate,
                "customerReviews" => AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersion.CustomerReviews,
                "downloadable" => AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersion.Downloadable,
                "earliestReleaseDate" => AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersion.EarliestReleaseDate,
                "gameCenterAppVersion" => AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersion.GameCenterAppVersion,
                "platform" => AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersion.Platform,
                "releaseType" => AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersion.ReleaseType,
                "reviewType" => AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersion.ReviewType,
                "routingAppCoverage" => AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersion.RoutingAppCoverage,
                "usesIdfa" => AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersion.UsesIdfa,
                "versionString" => AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersion.VersionString,
                _ => null,
            };
        }
    }
}