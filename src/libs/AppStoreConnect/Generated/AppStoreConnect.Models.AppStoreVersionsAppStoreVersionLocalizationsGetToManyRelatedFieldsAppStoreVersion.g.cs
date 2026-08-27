
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersion
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
    public static class AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersion value)
        {
            return value switch
            {
                AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersion.AlternativeDistributionPackage => "alternativeDistributionPackage",
                AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersion.App => "app",
                AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersion.AppClipDefaultExperience => "appClipDefaultExperience",
                AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersion.AppStoreReviewDetail => "appStoreReviewDetail",
                AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersion.AppStoreState => "appStoreState",
                AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionExperiments => "appStoreVersionExperiments",
                AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionLocalizations => "appStoreVersionLocalizations",
                AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionPhasedRelease => "appStoreVersionPhasedRelease",
                AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionSubmission => "appStoreVersionSubmission",
                AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersion.AppVersionState => "appVersionState",
                AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersion.Build => "build",
                AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersion.Copyright => "copyright",
                AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersion.CreatedDate => "createdDate",
                AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersion.CustomerReviews => "customerReviews",
                AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersion.Downloadable => "downloadable",
                AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersion.EarliestReleaseDate => "earliestReleaseDate",
                AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersion.GameCenterAppVersion => "gameCenterAppVersion",
                AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersion.Platform => "platform",
                AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersion.ReleaseType => "releaseType",
                AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersion.ReviewType => "reviewType",
                AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersion.RoutingAppCoverage => "routingAppCoverage",
                AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersion.UsesIdfa => "usesIdfa",
                AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersion.VersionString => "versionString",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersion? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionPackage" => AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersion.AlternativeDistributionPackage,
                "app" => AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersion.App,
                "appClipDefaultExperience" => AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersion.AppClipDefaultExperience,
                "appStoreReviewDetail" => AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersion.AppStoreReviewDetail,
                "appStoreState" => AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersion.AppStoreState,
                "appStoreVersionExperiments" => AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionExperiments,
                "appStoreVersionExperimentsV2" => AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionExperimentsV2,
                "appStoreVersionLocalizations" => AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionLocalizations,
                "appStoreVersionPhasedRelease" => AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionPhasedRelease,
                "appStoreVersionSubmission" => AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionSubmission,
                "appVersionState" => AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersion.AppVersionState,
                "build" => AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersion.Build,
                "copyright" => AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersion.Copyright,
                "createdDate" => AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersion.CreatedDate,
                "customerReviews" => AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersion.CustomerReviews,
                "downloadable" => AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersion.Downloadable,
                "earliestReleaseDate" => AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersion.EarliestReleaseDate,
                "gameCenterAppVersion" => AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersion.GameCenterAppVersion,
                "platform" => AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersion.Platform,
                "releaseType" => AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersion.ReleaseType,
                "reviewType" => AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersion.ReviewType,
                "routingAppCoverage" => AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersion.RoutingAppCoverage,
                "usesIdfa" => AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersion.UsesIdfa,
                "versionString" => AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppStoreVersion.VersionString,
                _ => null,
            };
        }
    }
}