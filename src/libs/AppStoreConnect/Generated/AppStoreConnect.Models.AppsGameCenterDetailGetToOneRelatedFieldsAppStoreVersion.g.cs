
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsGameCenterDetailGetToOneRelatedFieldsAppStoreVersion
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
    public static class AppsGameCenterDetailGetToOneRelatedFieldsAppStoreVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGameCenterDetailGetToOneRelatedFieldsAppStoreVersion value)
        {
            return value switch
            {
                AppsGameCenterDetailGetToOneRelatedFieldsAppStoreVersion.AlternativeDistributionPackage => "alternativeDistributionPackage",
                AppsGameCenterDetailGetToOneRelatedFieldsAppStoreVersion.App => "app",
                AppsGameCenterDetailGetToOneRelatedFieldsAppStoreVersion.AppClipDefaultExperience => "appClipDefaultExperience",
                AppsGameCenterDetailGetToOneRelatedFieldsAppStoreVersion.AppStoreReviewDetail => "appStoreReviewDetail",
                AppsGameCenterDetailGetToOneRelatedFieldsAppStoreVersion.AppStoreState => "appStoreState",
                AppsGameCenterDetailGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionExperiments => "appStoreVersionExperiments",
                AppsGameCenterDetailGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                AppsGameCenterDetailGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionLocalizations => "appStoreVersionLocalizations",
                AppsGameCenterDetailGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionPhasedRelease => "appStoreVersionPhasedRelease",
                AppsGameCenterDetailGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionSubmission => "appStoreVersionSubmission",
                AppsGameCenterDetailGetToOneRelatedFieldsAppStoreVersion.AppVersionState => "appVersionState",
                AppsGameCenterDetailGetToOneRelatedFieldsAppStoreVersion.Build => "build",
                AppsGameCenterDetailGetToOneRelatedFieldsAppStoreVersion.Copyright => "copyright",
                AppsGameCenterDetailGetToOneRelatedFieldsAppStoreVersion.CreatedDate => "createdDate",
                AppsGameCenterDetailGetToOneRelatedFieldsAppStoreVersion.CustomerReviews => "customerReviews",
                AppsGameCenterDetailGetToOneRelatedFieldsAppStoreVersion.Downloadable => "downloadable",
                AppsGameCenterDetailGetToOneRelatedFieldsAppStoreVersion.EarliestReleaseDate => "earliestReleaseDate",
                AppsGameCenterDetailGetToOneRelatedFieldsAppStoreVersion.GameCenterAppVersion => "gameCenterAppVersion",
                AppsGameCenterDetailGetToOneRelatedFieldsAppStoreVersion.Platform => "platform",
                AppsGameCenterDetailGetToOneRelatedFieldsAppStoreVersion.ReleaseType => "releaseType",
                AppsGameCenterDetailGetToOneRelatedFieldsAppStoreVersion.ReviewType => "reviewType",
                AppsGameCenterDetailGetToOneRelatedFieldsAppStoreVersion.RoutingAppCoverage => "routingAppCoverage",
                AppsGameCenterDetailGetToOneRelatedFieldsAppStoreVersion.UsesIdfa => "usesIdfa",
                AppsGameCenterDetailGetToOneRelatedFieldsAppStoreVersion.VersionString => "versionString",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGameCenterDetailGetToOneRelatedFieldsAppStoreVersion? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionPackage" => AppsGameCenterDetailGetToOneRelatedFieldsAppStoreVersion.AlternativeDistributionPackage,
                "app" => AppsGameCenterDetailGetToOneRelatedFieldsAppStoreVersion.App,
                "appClipDefaultExperience" => AppsGameCenterDetailGetToOneRelatedFieldsAppStoreVersion.AppClipDefaultExperience,
                "appStoreReviewDetail" => AppsGameCenterDetailGetToOneRelatedFieldsAppStoreVersion.AppStoreReviewDetail,
                "appStoreState" => AppsGameCenterDetailGetToOneRelatedFieldsAppStoreVersion.AppStoreState,
                "appStoreVersionExperiments" => AppsGameCenterDetailGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionExperiments,
                "appStoreVersionExperimentsV2" => AppsGameCenterDetailGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionExperimentsV2,
                "appStoreVersionLocalizations" => AppsGameCenterDetailGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionLocalizations,
                "appStoreVersionPhasedRelease" => AppsGameCenterDetailGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionPhasedRelease,
                "appStoreVersionSubmission" => AppsGameCenterDetailGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionSubmission,
                "appVersionState" => AppsGameCenterDetailGetToOneRelatedFieldsAppStoreVersion.AppVersionState,
                "build" => AppsGameCenterDetailGetToOneRelatedFieldsAppStoreVersion.Build,
                "copyright" => AppsGameCenterDetailGetToOneRelatedFieldsAppStoreVersion.Copyright,
                "createdDate" => AppsGameCenterDetailGetToOneRelatedFieldsAppStoreVersion.CreatedDate,
                "customerReviews" => AppsGameCenterDetailGetToOneRelatedFieldsAppStoreVersion.CustomerReviews,
                "downloadable" => AppsGameCenterDetailGetToOneRelatedFieldsAppStoreVersion.Downloadable,
                "earliestReleaseDate" => AppsGameCenterDetailGetToOneRelatedFieldsAppStoreVersion.EarliestReleaseDate,
                "gameCenterAppVersion" => AppsGameCenterDetailGetToOneRelatedFieldsAppStoreVersion.GameCenterAppVersion,
                "platform" => AppsGameCenterDetailGetToOneRelatedFieldsAppStoreVersion.Platform,
                "releaseType" => AppsGameCenterDetailGetToOneRelatedFieldsAppStoreVersion.ReleaseType,
                "reviewType" => AppsGameCenterDetailGetToOneRelatedFieldsAppStoreVersion.ReviewType,
                "routingAppCoverage" => AppsGameCenterDetailGetToOneRelatedFieldsAppStoreVersion.RoutingAppCoverage,
                "usesIdfa" => AppsGameCenterDetailGetToOneRelatedFieldsAppStoreVersion.UsesIdfa,
                "versionString" => AppsGameCenterDetailGetToOneRelatedFieldsAppStoreVersion.VersionString,
                _ => null,
            };
        }
    }
}