
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreVersion
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
    public static class AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreVersion value)
        {
            return value switch
            {
                AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreVersion.AlternativeDistributionPackage => "alternativeDistributionPackage",
                AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreVersion.App => "app",
                AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreVersion.AppClipDefaultExperience => "appClipDefaultExperience",
                AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreVersion.AppStoreReviewDetail => "appStoreReviewDetail",
                AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreVersion.AppStoreState => "appStoreState",
                AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionExperiments => "appStoreVersionExperiments",
                AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionLocalizations => "appStoreVersionLocalizations",
                AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionPhasedRelease => "appStoreVersionPhasedRelease",
                AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionSubmission => "appStoreVersionSubmission",
                AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreVersion.AppVersionState => "appVersionState",
                AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreVersion.Build => "build",
                AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreVersion.Copyright => "copyright",
                AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreVersion.CreatedDate => "createdDate",
                AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreVersion.CustomerReviews => "customerReviews",
                AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreVersion.Downloadable => "downloadable",
                AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreVersion.EarliestReleaseDate => "earliestReleaseDate",
                AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreVersion.GameCenterAppVersion => "gameCenterAppVersion",
                AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreVersion.Platform => "platform",
                AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreVersion.ReleaseType => "releaseType",
                AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreVersion.ReviewType => "reviewType",
                AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreVersion.RoutingAppCoverage => "routingAppCoverage",
                AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreVersion.UsesIdfa => "usesIdfa",
                AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreVersion.VersionString => "versionString",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreVersion? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionPackage" => AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreVersion.AlternativeDistributionPackage,
                "app" => AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreVersion.App,
                "appClipDefaultExperience" => AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreVersion.AppClipDefaultExperience,
                "appStoreReviewDetail" => AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreVersion.AppStoreReviewDetail,
                "appStoreState" => AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreVersion.AppStoreState,
                "appStoreVersionExperiments" => AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionExperiments,
                "appStoreVersionExperimentsV2" => AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionExperimentsV2,
                "appStoreVersionLocalizations" => AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionLocalizations,
                "appStoreVersionPhasedRelease" => AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionPhasedRelease,
                "appStoreVersionSubmission" => AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionSubmission,
                "appVersionState" => AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreVersion.AppVersionState,
                "build" => AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreVersion.Build,
                "copyright" => AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreVersion.Copyright,
                "createdDate" => AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreVersion.CreatedDate,
                "customerReviews" => AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreVersion.CustomerReviews,
                "downloadable" => AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreVersion.Downloadable,
                "earliestReleaseDate" => AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreVersion.EarliestReleaseDate,
                "gameCenterAppVersion" => AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreVersion.GameCenterAppVersion,
                "platform" => AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreVersion.Platform,
                "releaseType" => AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreVersion.ReleaseType,
                "reviewType" => AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreVersion.ReviewType,
                "routingAppCoverage" => AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreVersion.RoutingAppCoverage,
                "usesIdfa" => AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreVersion.UsesIdfa,
                "versionString" => AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreVersion.VersionString,
                _ => null,
            };
        }
    }
}