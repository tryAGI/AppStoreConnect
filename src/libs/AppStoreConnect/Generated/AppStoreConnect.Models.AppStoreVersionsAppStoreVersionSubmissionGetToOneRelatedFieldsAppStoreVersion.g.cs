
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersion
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
    public static class AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersion value)
        {
            return value switch
            {
                AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersion.AlternativeDistributionPackage => "alternativeDistributionPackage",
                AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersion.App => "app",
                AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersion.AppClipDefaultExperience => "appClipDefaultExperience",
                AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersion.AppStoreReviewDetail => "appStoreReviewDetail",
                AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersion.AppStoreState => "appStoreState",
                AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionExperiments => "appStoreVersionExperiments",
                AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionLocalizations => "appStoreVersionLocalizations",
                AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionPhasedRelease => "appStoreVersionPhasedRelease",
                AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionSubmission => "appStoreVersionSubmission",
                AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersion.AppVersionState => "appVersionState",
                AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersion.Build => "build",
                AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersion.Copyright => "copyright",
                AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersion.CreatedDate => "createdDate",
                AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersion.CustomerReviews => "customerReviews",
                AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersion.Downloadable => "downloadable",
                AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersion.EarliestReleaseDate => "earliestReleaseDate",
                AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersion.GameCenterAppVersion => "gameCenterAppVersion",
                AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersion.Platform => "platform",
                AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersion.ReleaseType => "releaseType",
                AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersion.ReviewType => "reviewType",
                AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersion.RoutingAppCoverage => "routingAppCoverage",
                AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersion.UsesIdfa => "usesIdfa",
                AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersion.VersionString => "versionString",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersion? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionPackage" => AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersion.AlternativeDistributionPackage,
                "app" => AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersion.App,
                "appClipDefaultExperience" => AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersion.AppClipDefaultExperience,
                "appStoreReviewDetail" => AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersion.AppStoreReviewDetail,
                "appStoreState" => AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersion.AppStoreState,
                "appStoreVersionExperiments" => AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionExperiments,
                "appStoreVersionExperimentsV2" => AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionExperimentsV2,
                "appStoreVersionLocalizations" => AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionLocalizations,
                "appStoreVersionPhasedRelease" => AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionPhasedRelease,
                "appStoreVersionSubmission" => AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionSubmission,
                "appVersionState" => AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersion.AppVersionState,
                "build" => AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersion.Build,
                "copyright" => AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersion.Copyright,
                "createdDate" => AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersion.CreatedDate,
                "customerReviews" => AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersion.CustomerReviews,
                "downloadable" => AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersion.Downloadable,
                "earliestReleaseDate" => AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersion.EarliestReleaseDate,
                "gameCenterAppVersion" => AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersion.GameCenterAppVersion,
                "platform" => AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersion.Platform,
                "releaseType" => AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersion.ReleaseType,
                "reviewType" => AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersion.ReviewType,
                "routingAppCoverage" => AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersion.RoutingAppCoverage,
                "usesIdfa" => AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersion.UsesIdfa,
                "versionString" => AppStoreVersionsAppStoreVersionSubmissionGetToOneRelatedFieldsAppStoreVersion.VersionString,
                _ => null,
            };
        }
    }
}