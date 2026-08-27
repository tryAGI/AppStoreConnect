
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsAppStoreVersion
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
    public static class AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsAppStoreVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsAppStoreVersion value)
        {
            return value switch
            {
                AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsAppStoreVersion.AlternativeDistributionPackage => "alternativeDistributionPackage",
                AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsAppStoreVersion.App => "app",
                AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsAppStoreVersion.AppClipDefaultExperience => "appClipDefaultExperience",
                AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsAppStoreVersion.AppStoreReviewDetail => "appStoreReviewDetail",
                AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsAppStoreVersion.AppStoreState => "appStoreState",
                AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionExperiments => "appStoreVersionExperiments",
                AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionLocalizations => "appStoreVersionLocalizations",
                AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionPhasedRelease => "appStoreVersionPhasedRelease",
                AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionSubmission => "appStoreVersionSubmission",
                AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsAppStoreVersion.AppVersionState => "appVersionState",
                AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsAppStoreVersion.Build => "build",
                AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsAppStoreVersion.Copyright => "copyright",
                AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsAppStoreVersion.CreatedDate => "createdDate",
                AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsAppStoreVersion.CustomerReviews => "customerReviews",
                AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsAppStoreVersion.Downloadable => "downloadable",
                AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsAppStoreVersion.EarliestReleaseDate => "earliestReleaseDate",
                AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsAppStoreVersion.GameCenterAppVersion => "gameCenterAppVersion",
                AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsAppStoreVersion.Platform => "platform",
                AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsAppStoreVersion.ReleaseType => "releaseType",
                AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsAppStoreVersion.ReviewType => "reviewType",
                AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsAppStoreVersion.RoutingAppCoverage => "routingAppCoverage",
                AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsAppStoreVersion.UsesIdfa => "usesIdfa",
                AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsAppStoreVersion.VersionString => "versionString",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsAppStoreVersion? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionPackage" => AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsAppStoreVersion.AlternativeDistributionPackage,
                "app" => AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsAppStoreVersion.App,
                "appClipDefaultExperience" => AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsAppStoreVersion.AppClipDefaultExperience,
                "appStoreReviewDetail" => AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsAppStoreVersion.AppStoreReviewDetail,
                "appStoreState" => AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsAppStoreVersion.AppStoreState,
                "appStoreVersionExperiments" => AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionExperiments,
                "appStoreVersionExperimentsV2" => AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionExperimentsV2,
                "appStoreVersionLocalizations" => AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionLocalizations,
                "appStoreVersionPhasedRelease" => AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionPhasedRelease,
                "appStoreVersionSubmission" => AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionSubmission,
                "appVersionState" => AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsAppStoreVersion.AppVersionState,
                "build" => AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsAppStoreVersion.Build,
                "copyright" => AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsAppStoreVersion.Copyright,
                "createdDate" => AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsAppStoreVersion.CreatedDate,
                "customerReviews" => AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsAppStoreVersion.CustomerReviews,
                "downloadable" => AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsAppStoreVersion.Downloadable,
                "earliestReleaseDate" => AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsAppStoreVersion.EarliestReleaseDate,
                "gameCenterAppVersion" => AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsAppStoreVersion.GameCenterAppVersion,
                "platform" => AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsAppStoreVersion.Platform,
                "releaseType" => AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsAppStoreVersion.ReleaseType,
                "reviewType" => AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsAppStoreVersion.ReviewType,
                "routingAppCoverage" => AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsAppStoreVersion.RoutingAppCoverage,
                "usesIdfa" => AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsAppStoreVersion.UsesIdfa,
                "versionString" => AppStoreVersionsRoutingAppCoverageGetToOneRelatedFieldsAppStoreVersion.VersionString,
                _ => null,
            };
        }
    }
}