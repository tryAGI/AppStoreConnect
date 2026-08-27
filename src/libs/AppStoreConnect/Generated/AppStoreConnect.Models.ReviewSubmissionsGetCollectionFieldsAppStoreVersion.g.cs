
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReviewSubmissionsGetCollectionFieldsAppStoreVersion
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
    public static class ReviewSubmissionsGetCollectionFieldsAppStoreVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionsGetCollectionFieldsAppStoreVersion value)
        {
            return value switch
            {
                ReviewSubmissionsGetCollectionFieldsAppStoreVersion.AlternativeDistributionPackage => "alternativeDistributionPackage",
                ReviewSubmissionsGetCollectionFieldsAppStoreVersion.App => "app",
                ReviewSubmissionsGetCollectionFieldsAppStoreVersion.AppClipDefaultExperience => "appClipDefaultExperience",
                ReviewSubmissionsGetCollectionFieldsAppStoreVersion.AppStoreReviewDetail => "appStoreReviewDetail",
                ReviewSubmissionsGetCollectionFieldsAppStoreVersion.AppStoreState => "appStoreState",
                ReviewSubmissionsGetCollectionFieldsAppStoreVersion.AppStoreVersionExperiments => "appStoreVersionExperiments",
                ReviewSubmissionsGetCollectionFieldsAppStoreVersion.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                ReviewSubmissionsGetCollectionFieldsAppStoreVersion.AppStoreVersionLocalizations => "appStoreVersionLocalizations",
                ReviewSubmissionsGetCollectionFieldsAppStoreVersion.AppStoreVersionPhasedRelease => "appStoreVersionPhasedRelease",
                ReviewSubmissionsGetCollectionFieldsAppStoreVersion.AppStoreVersionSubmission => "appStoreVersionSubmission",
                ReviewSubmissionsGetCollectionFieldsAppStoreVersion.AppVersionState => "appVersionState",
                ReviewSubmissionsGetCollectionFieldsAppStoreVersion.Build => "build",
                ReviewSubmissionsGetCollectionFieldsAppStoreVersion.Copyright => "copyright",
                ReviewSubmissionsGetCollectionFieldsAppStoreVersion.CreatedDate => "createdDate",
                ReviewSubmissionsGetCollectionFieldsAppStoreVersion.CustomerReviews => "customerReviews",
                ReviewSubmissionsGetCollectionFieldsAppStoreVersion.Downloadable => "downloadable",
                ReviewSubmissionsGetCollectionFieldsAppStoreVersion.EarliestReleaseDate => "earliestReleaseDate",
                ReviewSubmissionsGetCollectionFieldsAppStoreVersion.GameCenterAppVersion => "gameCenterAppVersion",
                ReviewSubmissionsGetCollectionFieldsAppStoreVersion.Platform => "platform",
                ReviewSubmissionsGetCollectionFieldsAppStoreVersion.ReleaseType => "releaseType",
                ReviewSubmissionsGetCollectionFieldsAppStoreVersion.ReviewType => "reviewType",
                ReviewSubmissionsGetCollectionFieldsAppStoreVersion.RoutingAppCoverage => "routingAppCoverage",
                ReviewSubmissionsGetCollectionFieldsAppStoreVersion.UsesIdfa => "usesIdfa",
                ReviewSubmissionsGetCollectionFieldsAppStoreVersion.VersionString => "versionString",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionsGetCollectionFieldsAppStoreVersion? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionPackage" => ReviewSubmissionsGetCollectionFieldsAppStoreVersion.AlternativeDistributionPackage,
                "app" => ReviewSubmissionsGetCollectionFieldsAppStoreVersion.App,
                "appClipDefaultExperience" => ReviewSubmissionsGetCollectionFieldsAppStoreVersion.AppClipDefaultExperience,
                "appStoreReviewDetail" => ReviewSubmissionsGetCollectionFieldsAppStoreVersion.AppStoreReviewDetail,
                "appStoreState" => ReviewSubmissionsGetCollectionFieldsAppStoreVersion.AppStoreState,
                "appStoreVersionExperiments" => ReviewSubmissionsGetCollectionFieldsAppStoreVersion.AppStoreVersionExperiments,
                "appStoreVersionExperimentsV2" => ReviewSubmissionsGetCollectionFieldsAppStoreVersion.AppStoreVersionExperimentsV2,
                "appStoreVersionLocalizations" => ReviewSubmissionsGetCollectionFieldsAppStoreVersion.AppStoreVersionLocalizations,
                "appStoreVersionPhasedRelease" => ReviewSubmissionsGetCollectionFieldsAppStoreVersion.AppStoreVersionPhasedRelease,
                "appStoreVersionSubmission" => ReviewSubmissionsGetCollectionFieldsAppStoreVersion.AppStoreVersionSubmission,
                "appVersionState" => ReviewSubmissionsGetCollectionFieldsAppStoreVersion.AppVersionState,
                "build" => ReviewSubmissionsGetCollectionFieldsAppStoreVersion.Build,
                "copyright" => ReviewSubmissionsGetCollectionFieldsAppStoreVersion.Copyright,
                "createdDate" => ReviewSubmissionsGetCollectionFieldsAppStoreVersion.CreatedDate,
                "customerReviews" => ReviewSubmissionsGetCollectionFieldsAppStoreVersion.CustomerReviews,
                "downloadable" => ReviewSubmissionsGetCollectionFieldsAppStoreVersion.Downloadable,
                "earliestReleaseDate" => ReviewSubmissionsGetCollectionFieldsAppStoreVersion.EarliestReleaseDate,
                "gameCenterAppVersion" => ReviewSubmissionsGetCollectionFieldsAppStoreVersion.GameCenterAppVersion,
                "platform" => ReviewSubmissionsGetCollectionFieldsAppStoreVersion.Platform,
                "releaseType" => ReviewSubmissionsGetCollectionFieldsAppStoreVersion.ReleaseType,
                "reviewType" => ReviewSubmissionsGetCollectionFieldsAppStoreVersion.ReviewType,
                "routingAppCoverage" => ReviewSubmissionsGetCollectionFieldsAppStoreVersion.RoutingAppCoverage,
                "usesIdfa" => ReviewSubmissionsGetCollectionFieldsAppStoreVersion.UsesIdfa,
                "versionString" => ReviewSubmissionsGetCollectionFieldsAppStoreVersion.VersionString,
                _ => null,
            };
        }
    }
}