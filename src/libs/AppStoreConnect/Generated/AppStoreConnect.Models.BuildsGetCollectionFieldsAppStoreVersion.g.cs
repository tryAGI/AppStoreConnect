
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildsGetCollectionFieldsAppStoreVersion
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
    public static class BuildsGetCollectionFieldsAppStoreVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildsGetCollectionFieldsAppStoreVersion value)
        {
            return value switch
            {
                BuildsGetCollectionFieldsAppStoreVersion.AlternativeDistributionPackage => "alternativeDistributionPackage",
                BuildsGetCollectionFieldsAppStoreVersion.App => "app",
                BuildsGetCollectionFieldsAppStoreVersion.AppClipDefaultExperience => "appClipDefaultExperience",
                BuildsGetCollectionFieldsAppStoreVersion.AppStoreReviewDetail => "appStoreReviewDetail",
                BuildsGetCollectionFieldsAppStoreVersion.AppStoreState => "appStoreState",
                BuildsGetCollectionFieldsAppStoreVersion.AppStoreVersionExperiments => "appStoreVersionExperiments",
                BuildsGetCollectionFieldsAppStoreVersion.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                BuildsGetCollectionFieldsAppStoreVersion.AppStoreVersionLocalizations => "appStoreVersionLocalizations",
                BuildsGetCollectionFieldsAppStoreVersion.AppStoreVersionPhasedRelease => "appStoreVersionPhasedRelease",
                BuildsGetCollectionFieldsAppStoreVersion.AppStoreVersionSubmission => "appStoreVersionSubmission",
                BuildsGetCollectionFieldsAppStoreVersion.AppVersionState => "appVersionState",
                BuildsGetCollectionFieldsAppStoreVersion.Build => "build",
                BuildsGetCollectionFieldsAppStoreVersion.Copyright => "copyright",
                BuildsGetCollectionFieldsAppStoreVersion.CreatedDate => "createdDate",
                BuildsGetCollectionFieldsAppStoreVersion.CustomerReviews => "customerReviews",
                BuildsGetCollectionFieldsAppStoreVersion.Downloadable => "downloadable",
                BuildsGetCollectionFieldsAppStoreVersion.EarliestReleaseDate => "earliestReleaseDate",
                BuildsGetCollectionFieldsAppStoreVersion.GameCenterAppVersion => "gameCenterAppVersion",
                BuildsGetCollectionFieldsAppStoreVersion.Platform => "platform",
                BuildsGetCollectionFieldsAppStoreVersion.ReleaseType => "releaseType",
                BuildsGetCollectionFieldsAppStoreVersion.ReviewType => "reviewType",
                BuildsGetCollectionFieldsAppStoreVersion.RoutingAppCoverage => "routingAppCoverage",
                BuildsGetCollectionFieldsAppStoreVersion.UsesIdfa => "usesIdfa",
                BuildsGetCollectionFieldsAppStoreVersion.VersionString => "versionString",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildsGetCollectionFieldsAppStoreVersion? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionPackage" => BuildsGetCollectionFieldsAppStoreVersion.AlternativeDistributionPackage,
                "app" => BuildsGetCollectionFieldsAppStoreVersion.App,
                "appClipDefaultExperience" => BuildsGetCollectionFieldsAppStoreVersion.AppClipDefaultExperience,
                "appStoreReviewDetail" => BuildsGetCollectionFieldsAppStoreVersion.AppStoreReviewDetail,
                "appStoreState" => BuildsGetCollectionFieldsAppStoreVersion.AppStoreState,
                "appStoreVersionExperiments" => BuildsGetCollectionFieldsAppStoreVersion.AppStoreVersionExperiments,
                "appStoreVersionExperimentsV2" => BuildsGetCollectionFieldsAppStoreVersion.AppStoreVersionExperimentsV2,
                "appStoreVersionLocalizations" => BuildsGetCollectionFieldsAppStoreVersion.AppStoreVersionLocalizations,
                "appStoreVersionPhasedRelease" => BuildsGetCollectionFieldsAppStoreVersion.AppStoreVersionPhasedRelease,
                "appStoreVersionSubmission" => BuildsGetCollectionFieldsAppStoreVersion.AppStoreVersionSubmission,
                "appVersionState" => BuildsGetCollectionFieldsAppStoreVersion.AppVersionState,
                "build" => BuildsGetCollectionFieldsAppStoreVersion.Build,
                "copyright" => BuildsGetCollectionFieldsAppStoreVersion.Copyright,
                "createdDate" => BuildsGetCollectionFieldsAppStoreVersion.CreatedDate,
                "customerReviews" => BuildsGetCollectionFieldsAppStoreVersion.CustomerReviews,
                "downloadable" => BuildsGetCollectionFieldsAppStoreVersion.Downloadable,
                "earliestReleaseDate" => BuildsGetCollectionFieldsAppStoreVersion.EarliestReleaseDate,
                "gameCenterAppVersion" => BuildsGetCollectionFieldsAppStoreVersion.GameCenterAppVersion,
                "platform" => BuildsGetCollectionFieldsAppStoreVersion.Platform,
                "releaseType" => BuildsGetCollectionFieldsAppStoreVersion.ReleaseType,
                "reviewType" => BuildsGetCollectionFieldsAppStoreVersion.ReviewType,
                "routingAppCoverage" => BuildsGetCollectionFieldsAppStoreVersion.RoutingAppCoverage,
                "usesIdfa" => BuildsGetCollectionFieldsAppStoreVersion.UsesIdfa,
                "versionString" => BuildsGetCollectionFieldsAppStoreVersion.VersionString,
                _ => null,
            };
        }
    }
}