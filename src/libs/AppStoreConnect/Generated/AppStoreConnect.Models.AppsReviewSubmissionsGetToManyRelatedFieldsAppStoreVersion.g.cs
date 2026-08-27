
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsReviewSubmissionsGetToManyRelatedFieldsAppStoreVersion
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
    public static class AppsReviewSubmissionsGetToManyRelatedFieldsAppStoreVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsReviewSubmissionsGetToManyRelatedFieldsAppStoreVersion value)
        {
            return value switch
            {
                AppsReviewSubmissionsGetToManyRelatedFieldsAppStoreVersion.AlternativeDistributionPackage => "alternativeDistributionPackage",
                AppsReviewSubmissionsGetToManyRelatedFieldsAppStoreVersion.App => "app",
                AppsReviewSubmissionsGetToManyRelatedFieldsAppStoreVersion.AppClipDefaultExperience => "appClipDefaultExperience",
                AppsReviewSubmissionsGetToManyRelatedFieldsAppStoreVersion.AppStoreReviewDetail => "appStoreReviewDetail",
                AppsReviewSubmissionsGetToManyRelatedFieldsAppStoreVersion.AppStoreState => "appStoreState",
                AppsReviewSubmissionsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionExperiments => "appStoreVersionExperiments",
                AppsReviewSubmissionsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                AppsReviewSubmissionsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionLocalizations => "appStoreVersionLocalizations",
                AppsReviewSubmissionsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionPhasedRelease => "appStoreVersionPhasedRelease",
                AppsReviewSubmissionsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionSubmission => "appStoreVersionSubmission",
                AppsReviewSubmissionsGetToManyRelatedFieldsAppStoreVersion.AppVersionState => "appVersionState",
                AppsReviewSubmissionsGetToManyRelatedFieldsAppStoreVersion.Build => "build",
                AppsReviewSubmissionsGetToManyRelatedFieldsAppStoreVersion.Copyright => "copyright",
                AppsReviewSubmissionsGetToManyRelatedFieldsAppStoreVersion.CreatedDate => "createdDate",
                AppsReviewSubmissionsGetToManyRelatedFieldsAppStoreVersion.CustomerReviews => "customerReviews",
                AppsReviewSubmissionsGetToManyRelatedFieldsAppStoreVersion.Downloadable => "downloadable",
                AppsReviewSubmissionsGetToManyRelatedFieldsAppStoreVersion.EarliestReleaseDate => "earliestReleaseDate",
                AppsReviewSubmissionsGetToManyRelatedFieldsAppStoreVersion.GameCenterAppVersion => "gameCenterAppVersion",
                AppsReviewSubmissionsGetToManyRelatedFieldsAppStoreVersion.Platform => "platform",
                AppsReviewSubmissionsGetToManyRelatedFieldsAppStoreVersion.ReleaseType => "releaseType",
                AppsReviewSubmissionsGetToManyRelatedFieldsAppStoreVersion.ReviewType => "reviewType",
                AppsReviewSubmissionsGetToManyRelatedFieldsAppStoreVersion.RoutingAppCoverage => "routingAppCoverage",
                AppsReviewSubmissionsGetToManyRelatedFieldsAppStoreVersion.UsesIdfa => "usesIdfa",
                AppsReviewSubmissionsGetToManyRelatedFieldsAppStoreVersion.VersionString => "versionString",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsReviewSubmissionsGetToManyRelatedFieldsAppStoreVersion? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionPackage" => AppsReviewSubmissionsGetToManyRelatedFieldsAppStoreVersion.AlternativeDistributionPackage,
                "app" => AppsReviewSubmissionsGetToManyRelatedFieldsAppStoreVersion.App,
                "appClipDefaultExperience" => AppsReviewSubmissionsGetToManyRelatedFieldsAppStoreVersion.AppClipDefaultExperience,
                "appStoreReviewDetail" => AppsReviewSubmissionsGetToManyRelatedFieldsAppStoreVersion.AppStoreReviewDetail,
                "appStoreState" => AppsReviewSubmissionsGetToManyRelatedFieldsAppStoreVersion.AppStoreState,
                "appStoreVersionExperiments" => AppsReviewSubmissionsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionExperiments,
                "appStoreVersionExperimentsV2" => AppsReviewSubmissionsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionExperimentsV2,
                "appStoreVersionLocalizations" => AppsReviewSubmissionsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionLocalizations,
                "appStoreVersionPhasedRelease" => AppsReviewSubmissionsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionPhasedRelease,
                "appStoreVersionSubmission" => AppsReviewSubmissionsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionSubmission,
                "appVersionState" => AppsReviewSubmissionsGetToManyRelatedFieldsAppStoreVersion.AppVersionState,
                "build" => AppsReviewSubmissionsGetToManyRelatedFieldsAppStoreVersion.Build,
                "copyright" => AppsReviewSubmissionsGetToManyRelatedFieldsAppStoreVersion.Copyright,
                "createdDate" => AppsReviewSubmissionsGetToManyRelatedFieldsAppStoreVersion.CreatedDate,
                "customerReviews" => AppsReviewSubmissionsGetToManyRelatedFieldsAppStoreVersion.CustomerReviews,
                "downloadable" => AppsReviewSubmissionsGetToManyRelatedFieldsAppStoreVersion.Downloadable,
                "earliestReleaseDate" => AppsReviewSubmissionsGetToManyRelatedFieldsAppStoreVersion.EarliestReleaseDate,
                "gameCenterAppVersion" => AppsReviewSubmissionsGetToManyRelatedFieldsAppStoreVersion.GameCenterAppVersion,
                "platform" => AppsReviewSubmissionsGetToManyRelatedFieldsAppStoreVersion.Platform,
                "releaseType" => AppsReviewSubmissionsGetToManyRelatedFieldsAppStoreVersion.ReleaseType,
                "reviewType" => AppsReviewSubmissionsGetToManyRelatedFieldsAppStoreVersion.ReviewType,
                "routingAppCoverage" => AppsReviewSubmissionsGetToManyRelatedFieldsAppStoreVersion.RoutingAppCoverage,
                "usesIdfa" => AppsReviewSubmissionsGetToManyRelatedFieldsAppStoreVersion.UsesIdfa,
                "versionString" => AppsReviewSubmissionsGetToManyRelatedFieldsAppStoreVersion.VersionString,
                _ => null,
            };
        }
    }
}