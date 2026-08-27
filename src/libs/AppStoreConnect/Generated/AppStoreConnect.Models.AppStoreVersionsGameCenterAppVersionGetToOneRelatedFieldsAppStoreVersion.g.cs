
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsAppStoreVersion
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
    public static class AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsAppStoreVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsAppStoreVersion value)
        {
            return value switch
            {
                AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsAppStoreVersion.AlternativeDistributionPackage => "alternativeDistributionPackage",
                AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsAppStoreVersion.App => "app",
                AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsAppStoreVersion.AppClipDefaultExperience => "appClipDefaultExperience",
                AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsAppStoreVersion.AppStoreReviewDetail => "appStoreReviewDetail",
                AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsAppStoreVersion.AppStoreState => "appStoreState",
                AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionExperiments => "appStoreVersionExperiments",
                AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionLocalizations => "appStoreVersionLocalizations",
                AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionPhasedRelease => "appStoreVersionPhasedRelease",
                AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionSubmission => "appStoreVersionSubmission",
                AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsAppStoreVersion.AppVersionState => "appVersionState",
                AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsAppStoreVersion.Build => "build",
                AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsAppStoreVersion.Copyright => "copyright",
                AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsAppStoreVersion.CreatedDate => "createdDate",
                AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsAppStoreVersion.CustomerReviews => "customerReviews",
                AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsAppStoreVersion.Downloadable => "downloadable",
                AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsAppStoreVersion.EarliestReleaseDate => "earliestReleaseDate",
                AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsAppStoreVersion.GameCenterAppVersion => "gameCenterAppVersion",
                AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsAppStoreVersion.Platform => "platform",
                AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsAppStoreVersion.ReleaseType => "releaseType",
                AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsAppStoreVersion.ReviewType => "reviewType",
                AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsAppStoreVersion.RoutingAppCoverage => "routingAppCoverage",
                AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsAppStoreVersion.UsesIdfa => "usesIdfa",
                AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsAppStoreVersion.VersionString => "versionString",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsAppStoreVersion? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionPackage" => AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsAppStoreVersion.AlternativeDistributionPackage,
                "app" => AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsAppStoreVersion.App,
                "appClipDefaultExperience" => AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsAppStoreVersion.AppClipDefaultExperience,
                "appStoreReviewDetail" => AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsAppStoreVersion.AppStoreReviewDetail,
                "appStoreState" => AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsAppStoreVersion.AppStoreState,
                "appStoreVersionExperiments" => AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionExperiments,
                "appStoreVersionExperimentsV2" => AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionExperimentsV2,
                "appStoreVersionLocalizations" => AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionLocalizations,
                "appStoreVersionPhasedRelease" => AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionPhasedRelease,
                "appStoreVersionSubmission" => AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionSubmission,
                "appVersionState" => AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsAppStoreVersion.AppVersionState,
                "build" => AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsAppStoreVersion.Build,
                "copyright" => AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsAppStoreVersion.Copyright,
                "createdDate" => AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsAppStoreVersion.CreatedDate,
                "customerReviews" => AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsAppStoreVersion.CustomerReviews,
                "downloadable" => AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsAppStoreVersion.Downloadable,
                "earliestReleaseDate" => AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsAppStoreVersion.EarliestReleaseDate,
                "gameCenterAppVersion" => AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsAppStoreVersion.GameCenterAppVersion,
                "platform" => AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsAppStoreVersion.Platform,
                "releaseType" => AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsAppStoreVersion.ReleaseType,
                "reviewType" => AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsAppStoreVersion.ReviewType,
                "routingAppCoverage" => AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsAppStoreVersion.RoutingAppCoverage,
                "usesIdfa" => AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsAppStoreVersion.UsesIdfa,
                "versionString" => AppStoreVersionsGameCenterAppVersionGetToOneRelatedFieldsAppStoreVersion.VersionString,
                _ => null,
            };
        }
    }
}