
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppStoreVersion
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
    public static class AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppStoreVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppStoreVersion value)
        {
            return value switch
            {
                AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppStoreVersion.AlternativeDistributionPackage => "alternativeDistributionPackage",
                AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppStoreVersion.App => "app",
                AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppStoreVersion.AppClipDefaultExperience => "appClipDefaultExperience",
                AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppStoreVersion.AppStoreReviewDetail => "appStoreReviewDetail",
                AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppStoreVersion.AppStoreState => "appStoreState",
                AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionExperiments => "appStoreVersionExperiments",
                AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionLocalizations => "appStoreVersionLocalizations",
                AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionPhasedRelease => "appStoreVersionPhasedRelease",
                AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionSubmission => "appStoreVersionSubmission",
                AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppStoreVersion.AppVersionState => "appVersionState",
                AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppStoreVersion.Build => "build",
                AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppStoreVersion.Copyright => "copyright",
                AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppStoreVersion.CreatedDate => "createdDate",
                AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppStoreVersion.CustomerReviews => "customerReviews",
                AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppStoreVersion.Downloadable => "downloadable",
                AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppStoreVersion.EarliestReleaseDate => "earliestReleaseDate",
                AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppStoreVersion.GameCenterAppVersion => "gameCenterAppVersion",
                AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppStoreVersion.Platform => "platform",
                AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppStoreVersion.ReleaseType => "releaseType",
                AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppStoreVersion.ReviewType => "reviewType",
                AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppStoreVersion.RoutingAppCoverage => "routingAppCoverage",
                AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppStoreVersion.UsesIdfa => "usesIdfa",
                AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppStoreVersion.VersionString => "versionString",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppStoreVersion? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionPackage" => AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppStoreVersion.AlternativeDistributionPackage,
                "app" => AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppStoreVersion.App,
                "appClipDefaultExperience" => AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppStoreVersion.AppClipDefaultExperience,
                "appStoreReviewDetail" => AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppStoreVersion.AppStoreReviewDetail,
                "appStoreState" => AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppStoreVersion.AppStoreState,
                "appStoreVersionExperiments" => AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionExperiments,
                "appStoreVersionExperimentsV2" => AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionExperimentsV2,
                "appStoreVersionLocalizations" => AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionLocalizations,
                "appStoreVersionPhasedRelease" => AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionPhasedRelease,
                "appStoreVersionSubmission" => AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionSubmission,
                "appVersionState" => AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppStoreVersion.AppVersionState,
                "build" => AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppStoreVersion.Build,
                "copyright" => AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppStoreVersion.Copyright,
                "createdDate" => AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppStoreVersion.CreatedDate,
                "customerReviews" => AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppStoreVersion.CustomerReviews,
                "downloadable" => AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppStoreVersion.Downloadable,
                "earliestReleaseDate" => AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppStoreVersion.EarliestReleaseDate,
                "gameCenterAppVersion" => AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppStoreVersion.GameCenterAppVersion,
                "platform" => AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppStoreVersion.Platform,
                "releaseType" => AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppStoreVersion.ReleaseType,
                "reviewType" => AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppStoreVersion.ReviewType,
                "routingAppCoverage" => AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppStoreVersion.RoutingAppCoverage,
                "usesIdfa" => AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppStoreVersion.UsesIdfa,
                "versionString" => AppClipsAppClipDefaultExperiencesGetToManyRelatedFieldsAppStoreVersion.VersionString,
                _ => null,
            };
        }
    }
}