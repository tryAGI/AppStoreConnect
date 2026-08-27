
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ReviewSubmissionsGetInstanceFieldsAppStoreVersion
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
    public static class ReviewSubmissionsGetInstanceFieldsAppStoreVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionsGetInstanceFieldsAppStoreVersion value)
        {
            return value switch
            {
                ReviewSubmissionsGetInstanceFieldsAppStoreVersion.AlternativeDistributionPackage => "alternativeDistributionPackage",
                ReviewSubmissionsGetInstanceFieldsAppStoreVersion.App => "app",
                ReviewSubmissionsGetInstanceFieldsAppStoreVersion.AppClipDefaultExperience => "appClipDefaultExperience",
                ReviewSubmissionsGetInstanceFieldsAppStoreVersion.AppStoreReviewDetail => "appStoreReviewDetail",
                ReviewSubmissionsGetInstanceFieldsAppStoreVersion.AppStoreState => "appStoreState",
                ReviewSubmissionsGetInstanceFieldsAppStoreVersion.AppStoreVersionExperiments => "appStoreVersionExperiments",
                ReviewSubmissionsGetInstanceFieldsAppStoreVersion.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                ReviewSubmissionsGetInstanceFieldsAppStoreVersion.AppStoreVersionLocalizations => "appStoreVersionLocalizations",
                ReviewSubmissionsGetInstanceFieldsAppStoreVersion.AppStoreVersionPhasedRelease => "appStoreVersionPhasedRelease",
                ReviewSubmissionsGetInstanceFieldsAppStoreVersion.AppStoreVersionSubmission => "appStoreVersionSubmission",
                ReviewSubmissionsGetInstanceFieldsAppStoreVersion.AppVersionState => "appVersionState",
                ReviewSubmissionsGetInstanceFieldsAppStoreVersion.Build => "build",
                ReviewSubmissionsGetInstanceFieldsAppStoreVersion.Copyright => "copyright",
                ReviewSubmissionsGetInstanceFieldsAppStoreVersion.CreatedDate => "createdDate",
                ReviewSubmissionsGetInstanceFieldsAppStoreVersion.CustomerReviews => "customerReviews",
                ReviewSubmissionsGetInstanceFieldsAppStoreVersion.Downloadable => "downloadable",
                ReviewSubmissionsGetInstanceFieldsAppStoreVersion.EarliestReleaseDate => "earliestReleaseDate",
                ReviewSubmissionsGetInstanceFieldsAppStoreVersion.GameCenterAppVersion => "gameCenterAppVersion",
                ReviewSubmissionsGetInstanceFieldsAppStoreVersion.Platform => "platform",
                ReviewSubmissionsGetInstanceFieldsAppStoreVersion.ReleaseType => "releaseType",
                ReviewSubmissionsGetInstanceFieldsAppStoreVersion.ReviewType => "reviewType",
                ReviewSubmissionsGetInstanceFieldsAppStoreVersion.RoutingAppCoverage => "routingAppCoverage",
                ReviewSubmissionsGetInstanceFieldsAppStoreVersion.UsesIdfa => "usesIdfa",
                ReviewSubmissionsGetInstanceFieldsAppStoreVersion.VersionString => "versionString",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionsGetInstanceFieldsAppStoreVersion? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionPackage" => ReviewSubmissionsGetInstanceFieldsAppStoreVersion.AlternativeDistributionPackage,
                "app" => ReviewSubmissionsGetInstanceFieldsAppStoreVersion.App,
                "appClipDefaultExperience" => ReviewSubmissionsGetInstanceFieldsAppStoreVersion.AppClipDefaultExperience,
                "appStoreReviewDetail" => ReviewSubmissionsGetInstanceFieldsAppStoreVersion.AppStoreReviewDetail,
                "appStoreState" => ReviewSubmissionsGetInstanceFieldsAppStoreVersion.AppStoreState,
                "appStoreVersionExperiments" => ReviewSubmissionsGetInstanceFieldsAppStoreVersion.AppStoreVersionExperiments,
                "appStoreVersionExperimentsV2" => ReviewSubmissionsGetInstanceFieldsAppStoreVersion.AppStoreVersionExperimentsV2,
                "appStoreVersionLocalizations" => ReviewSubmissionsGetInstanceFieldsAppStoreVersion.AppStoreVersionLocalizations,
                "appStoreVersionPhasedRelease" => ReviewSubmissionsGetInstanceFieldsAppStoreVersion.AppStoreVersionPhasedRelease,
                "appStoreVersionSubmission" => ReviewSubmissionsGetInstanceFieldsAppStoreVersion.AppStoreVersionSubmission,
                "appVersionState" => ReviewSubmissionsGetInstanceFieldsAppStoreVersion.AppVersionState,
                "build" => ReviewSubmissionsGetInstanceFieldsAppStoreVersion.Build,
                "copyright" => ReviewSubmissionsGetInstanceFieldsAppStoreVersion.Copyright,
                "createdDate" => ReviewSubmissionsGetInstanceFieldsAppStoreVersion.CreatedDate,
                "customerReviews" => ReviewSubmissionsGetInstanceFieldsAppStoreVersion.CustomerReviews,
                "downloadable" => ReviewSubmissionsGetInstanceFieldsAppStoreVersion.Downloadable,
                "earliestReleaseDate" => ReviewSubmissionsGetInstanceFieldsAppStoreVersion.EarliestReleaseDate,
                "gameCenterAppVersion" => ReviewSubmissionsGetInstanceFieldsAppStoreVersion.GameCenterAppVersion,
                "platform" => ReviewSubmissionsGetInstanceFieldsAppStoreVersion.Platform,
                "releaseType" => ReviewSubmissionsGetInstanceFieldsAppStoreVersion.ReleaseType,
                "reviewType" => ReviewSubmissionsGetInstanceFieldsAppStoreVersion.ReviewType,
                "routingAppCoverage" => ReviewSubmissionsGetInstanceFieldsAppStoreVersion.RoutingAppCoverage,
                "usesIdfa" => ReviewSubmissionsGetInstanceFieldsAppStoreVersion.UsesIdfa,
                "versionString" => ReviewSubmissionsGetInstanceFieldsAppStoreVersion.VersionString,
                _ => null,
            };
        }
    }
}