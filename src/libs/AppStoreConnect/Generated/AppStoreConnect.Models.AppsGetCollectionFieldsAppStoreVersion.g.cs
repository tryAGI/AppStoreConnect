
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsGetCollectionFieldsAppStoreVersion
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
    public static class AppsGetCollectionFieldsAppStoreVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGetCollectionFieldsAppStoreVersion value)
        {
            return value switch
            {
                AppsGetCollectionFieldsAppStoreVersion.AlternativeDistributionPackage => "alternativeDistributionPackage",
                AppsGetCollectionFieldsAppStoreVersion.App => "app",
                AppsGetCollectionFieldsAppStoreVersion.AppClipDefaultExperience => "appClipDefaultExperience",
                AppsGetCollectionFieldsAppStoreVersion.AppStoreReviewDetail => "appStoreReviewDetail",
                AppsGetCollectionFieldsAppStoreVersion.AppStoreState => "appStoreState",
                AppsGetCollectionFieldsAppStoreVersion.AppStoreVersionExperiments => "appStoreVersionExperiments",
                AppsGetCollectionFieldsAppStoreVersion.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                AppsGetCollectionFieldsAppStoreVersion.AppStoreVersionLocalizations => "appStoreVersionLocalizations",
                AppsGetCollectionFieldsAppStoreVersion.AppStoreVersionPhasedRelease => "appStoreVersionPhasedRelease",
                AppsGetCollectionFieldsAppStoreVersion.AppStoreVersionSubmission => "appStoreVersionSubmission",
                AppsGetCollectionFieldsAppStoreVersion.AppVersionState => "appVersionState",
                AppsGetCollectionFieldsAppStoreVersion.Build => "build",
                AppsGetCollectionFieldsAppStoreVersion.Copyright => "copyright",
                AppsGetCollectionFieldsAppStoreVersion.CreatedDate => "createdDate",
                AppsGetCollectionFieldsAppStoreVersion.CustomerReviews => "customerReviews",
                AppsGetCollectionFieldsAppStoreVersion.Downloadable => "downloadable",
                AppsGetCollectionFieldsAppStoreVersion.EarliestReleaseDate => "earliestReleaseDate",
                AppsGetCollectionFieldsAppStoreVersion.GameCenterAppVersion => "gameCenterAppVersion",
                AppsGetCollectionFieldsAppStoreVersion.Platform => "platform",
                AppsGetCollectionFieldsAppStoreVersion.ReleaseType => "releaseType",
                AppsGetCollectionFieldsAppStoreVersion.ReviewType => "reviewType",
                AppsGetCollectionFieldsAppStoreVersion.RoutingAppCoverage => "routingAppCoverage",
                AppsGetCollectionFieldsAppStoreVersion.UsesIdfa => "usesIdfa",
                AppsGetCollectionFieldsAppStoreVersion.VersionString => "versionString",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGetCollectionFieldsAppStoreVersion? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionPackage" => AppsGetCollectionFieldsAppStoreVersion.AlternativeDistributionPackage,
                "app" => AppsGetCollectionFieldsAppStoreVersion.App,
                "appClipDefaultExperience" => AppsGetCollectionFieldsAppStoreVersion.AppClipDefaultExperience,
                "appStoreReviewDetail" => AppsGetCollectionFieldsAppStoreVersion.AppStoreReviewDetail,
                "appStoreState" => AppsGetCollectionFieldsAppStoreVersion.AppStoreState,
                "appStoreVersionExperiments" => AppsGetCollectionFieldsAppStoreVersion.AppStoreVersionExperiments,
                "appStoreVersionExperimentsV2" => AppsGetCollectionFieldsAppStoreVersion.AppStoreVersionExperimentsV2,
                "appStoreVersionLocalizations" => AppsGetCollectionFieldsAppStoreVersion.AppStoreVersionLocalizations,
                "appStoreVersionPhasedRelease" => AppsGetCollectionFieldsAppStoreVersion.AppStoreVersionPhasedRelease,
                "appStoreVersionSubmission" => AppsGetCollectionFieldsAppStoreVersion.AppStoreVersionSubmission,
                "appVersionState" => AppsGetCollectionFieldsAppStoreVersion.AppVersionState,
                "build" => AppsGetCollectionFieldsAppStoreVersion.Build,
                "copyright" => AppsGetCollectionFieldsAppStoreVersion.Copyright,
                "createdDate" => AppsGetCollectionFieldsAppStoreVersion.CreatedDate,
                "customerReviews" => AppsGetCollectionFieldsAppStoreVersion.CustomerReviews,
                "downloadable" => AppsGetCollectionFieldsAppStoreVersion.Downloadable,
                "earliestReleaseDate" => AppsGetCollectionFieldsAppStoreVersion.EarliestReleaseDate,
                "gameCenterAppVersion" => AppsGetCollectionFieldsAppStoreVersion.GameCenterAppVersion,
                "platform" => AppsGetCollectionFieldsAppStoreVersion.Platform,
                "releaseType" => AppsGetCollectionFieldsAppStoreVersion.ReleaseType,
                "reviewType" => AppsGetCollectionFieldsAppStoreVersion.ReviewType,
                "routingAppCoverage" => AppsGetCollectionFieldsAppStoreVersion.RoutingAppCoverage,
                "usesIdfa" => AppsGetCollectionFieldsAppStoreVersion.UsesIdfa,
                "versionString" => AppsGetCollectionFieldsAppStoreVersion.VersionString,
                _ => null,
            };
        }
    }
}