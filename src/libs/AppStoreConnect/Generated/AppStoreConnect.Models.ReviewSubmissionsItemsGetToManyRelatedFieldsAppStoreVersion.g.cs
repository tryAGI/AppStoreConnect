
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersion
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
    public static class ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersion value)
        {
            return value switch
            {
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersion.AlternativeDistributionPackage => "alternativeDistributionPackage",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersion.App => "app",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersion.AppClipDefaultExperience => "appClipDefaultExperience",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersion.AppStoreReviewDetail => "appStoreReviewDetail",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersion.AppStoreState => "appStoreState",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionExperiments => "appStoreVersionExperiments",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionLocalizations => "appStoreVersionLocalizations",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionPhasedRelease => "appStoreVersionPhasedRelease",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionSubmission => "appStoreVersionSubmission",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersion.AppVersionState => "appVersionState",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersion.Build => "build",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersion.Copyright => "copyright",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersion.CreatedDate => "createdDate",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersion.CustomerReviews => "customerReviews",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersion.Downloadable => "downloadable",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersion.EarliestReleaseDate => "earliestReleaseDate",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersion.GameCenterAppVersion => "gameCenterAppVersion",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersion.Platform => "platform",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersion.ReleaseType => "releaseType",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersion.ReviewType => "reviewType",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersion.RoutingAppCoverage => "routingAppCoverage",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersion.UsesIdfa => "usesIdfa",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersion.VersionString => "versionString",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersion? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionPackage" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersion.AlternativeDistributionPackage,
                "app" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersion.App,
                "appClipDefaultExperience" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersion.AppClipDefaultExperience,
                "appStoreReviewDetail" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersion.AppStoreReviewDetail,
                "appStoreState" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersion.AppStoreState,
                "appStoreVersionExperiments" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionExperiments,
                "appStoreVersionExperimentsV2" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionExperimentsV2,
                "appStoreVersionLocalizations" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionLocalizations,
                "appStoreVersionPhasedRelease" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionPhasedRelease,
                "appStoreVersionSubmission" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionSubmission,
                "appVersionState" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersion.AppVersionState,
                "build" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersion.Build,
                "copyright" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersion.Copyright,
                "createdDate" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersion.CreatedDate,
                "customerReviews" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersion.CustomerReviews,
                "downloadable" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersion.Downloadable,
                "earliestReleaseDate" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersion.EarliestReleaseDate,
                "gameCenterAppVersion" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersion.GameCenterAppVersion,
                "platform" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersion.Platform,
                "releaseType" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersion.ReleaseType,
                "reviewType" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersion.ReviewType,
                "routingAppCoverage" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersion.RoutingAppCoverage,
                "usesIdfa" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersion.UsesIdfa,
                "versionString" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersion.VersionString,
                _ => null,
            };
        }
    }
}