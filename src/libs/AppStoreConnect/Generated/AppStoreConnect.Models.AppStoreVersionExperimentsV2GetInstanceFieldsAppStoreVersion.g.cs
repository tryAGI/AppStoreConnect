
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersion
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
    public static class AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersion value)
        {
            return value switch
            {
                AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersion.AlternativeDistributionPackage => "alternativeDistributionPackage",
                AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersion.App => "app",
                AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersion.AppClipDefaultExperience => "appClipDefaultExperience",
                AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersion.AppStoreReviewDetail => "appStoreReviewDetail",
                AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersion.AppStoreState => "appStoreState",
                AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersion.AppStoreVersionExperiments => "appStoreVersionExperiments",
                AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersion.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersion.AppStoreVersionLocalizations => "appStoreVersionLocalizations",
                AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersion.AppStoreVersionPhasedRelease => "appStoreVersionPhasedRelease",
                AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersion.AppStoreVersionSubmission => "appStoreVersionSubmission",
                AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersion.AppVersionState => "appVersionState",
                AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersion.Build => "build",
                AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersion.Copyright => "copyright",
                AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersion.CreatedDate => "createdDate",
                AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersion.CustomerReviews => "customerReviews",
                AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersion.Downloadable => "downloadable",
                AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersion.EarliestReleaseDate => "earliestReleaseDate",
                AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersion.GameCenterAppVersion => "gameCenterAppVersion",
                AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersion.Platform => "platform",
                AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersion.ReleaseType => "releaseType",
                AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersion.ReviewType => "reviewType",
                AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersion.RoutingAppCoverage => "routingAppCoverage",
                AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersion.UsesIdfa => "usesIdfa",
                AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersion.VersionString => "versionString",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersion? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionPackage" => AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersion.AlternativeDistributionPackage,
                "app" => AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersion.App,
                "appClipDefaultExperience" => AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersion.AppClipDefaultExperience,
                "appStoreReviewDetail" => AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersion.AppStoreReviewDetail,
                "appStoreState" => AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersion.AppStoreState,
                "appStoreVersionExperiments" => AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersion.AppStoreVersionExperiments,
                "appStoreVersionExperimentsV2" => AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersion.AppStoreVersionExperimentsV2,
                "appStoreVersionLocalizations" => AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersion.AppStoreVersionLocalizations,
                "appStoreVersionPhasedRelease" => AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersion.AppStoreVersionPhasedRelease,
                "appStoreVersionSubmission" => AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersion.AppStoreVersionSubmission,
                "appVersionState" => AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersion.AppVersionState,
                "build" => AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersion.Build,
                "copyright" => AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersion.Copyright,
                "createdDate" => AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersion.CreatedDate,
                "customerReviews" => AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersion.CustomerReviews,
                "downloadable" => AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersion.Downloadable,
                "earliestReleaseDate" => AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersion.EarliestReleaseDate,
                "gameCenterAppVersion" => AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersion.GameCenterAppVersion,
                "platform" => AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersion.Platform,
                "releaseType" => AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersion.ReleaseType,
                "reviewType" => AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersion.ReviewType,
                "routingAppCoverage" => AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersion.RoutingAppCoverage,
                "usesIdfa" => AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersion.UsesIdfa,
                "versionString" => AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersion.VersionString,
                _ => null,
            };
        }
    }
}