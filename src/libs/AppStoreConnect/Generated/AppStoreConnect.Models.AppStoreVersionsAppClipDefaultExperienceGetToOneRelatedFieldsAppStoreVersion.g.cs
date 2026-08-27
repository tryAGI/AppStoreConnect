
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppStoreVersion
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
    public static class AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppStoreVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppStoreVersion value)
        {
            return value switch
            {
                AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppStoreVersion.AlternativeDistributionPackage => "alternativeDistributionPackage",
                AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppStoreVersion.App => "app",
                AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppStoreVersion.AppClipDefaultExperience => "appClipDefaultExperience",
                AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppStoreVersion.AppStoreReviewDetail => "appStoreReviewDetail",
                AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppStoreVersion.AppStoreState => "appStoreState",
                AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionExperiments => "appStoreVersionExperiments",
                AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionLocalizations => "appStoreVersionLocalizations",
                AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionPhasedRelease => "appStoreVersionPhasedRelease",
                AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionSubmission => "appStoreVersionSubmission",
                AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppStoreVersion.AppVersionState => "appVersionState",
                AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppStoreVersion.Build => "build",
                AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppStoreVersion.Copyright => "copyright",
                AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppStoreVersion.CreatedDate => "createdDate",
                AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppStoreVersion.CustomerReviews => "customerReviews",
                AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppStoreVersion.Downloadable => "downloadable",
                AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppStoreVersion.EarliestReleaseDate => "earliestReleaseDate",
                AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppStoreVersion.GameCenterAppVersion => "gameCenterAppVersion",
                AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppStoreVersion.Platform => "platform",
                AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppStoreVersion.ReleaseType => "releaseType",
                AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppStoreVersion.ReviewType => "reviewType",
                AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppStoreVersion.RoutingAppCoverage => "routingAppCoverage",
                AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppStoreVersion.UsesIdfa => "usesIdfa",
                AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppStoreVersion.VersionString => "versionString",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppStoreVersion? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionPackage" => AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppStoreVersion.AlternativeDistributionPackage,
                "app" => AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppStoreVersion.App,
                "appClipDefaultExperience" => AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppStoreVersion.AppClipDefaultExperience,
                "appStoreReviewDetail" => AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppStoreVersion.AppStoreReviewDetail,
                "appStoreState" => AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppStoreVersion.AppStoreState,
                "appStoreVersionExperiments" => AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionExperiments,
                "appStoreVersionExperimentsV2" => AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionExperimentsV2,
                "appStoreVersionLocalizations" => AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionLocalizations,
                "appStoreVersionPhasedRelease" => AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionPhasedRelease,
                "appStoreVersionSubmission" => AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionSubmission,
                "appVersionState" => AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppStoreVersion.AppVersionState,
                "build" => AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppStoreVersion.Build,
                "copyright" => AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppStoreVersion.Copyright,
                "createdDate" => AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppStoreVersion.CreatedDate,
                "customerReviews" => AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppStoreVersion.CustomerReviews,
                "downloadable" => AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppStoreVersion.Downloadable,
                "earliestReleaseDate" => AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppStoreVersion.EarliestReleaseDate,
                "gameCenterAppVersion" => AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppStoreVersion.GameCenterAppVersion,
                "platform" => AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppStoreVersion.Platform,
                "releaseType" => AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppStoreVersion.ReleaseType,
                "reviewType" => AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppStoreVersion.ReviewType,
                "routingAppCoverage" => AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppStoreVersion.RoutingAppCoverage,
                "usesIdfa" => AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppStoreVersion.UsesIdfa,
                "versionString" => AppStoreVersionsAppClipDefaultExperienceGetToOneRelatedFieldsAppStoreVersion.VersionString,
                _ => null,
            };
        }
    }
}