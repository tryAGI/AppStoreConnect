
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion
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
    public static class CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion value)
        {
            return value switch
            {
                CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion.AlternativeDistributionPackage => "alternativeDistributionPackage",
                CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion.App => "app",
                CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion.AppClipDefaultExperience => "appClipDefaultExperience",
                CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion.AppStoreReviewDetail => "appStoreReviewDetail",
                CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion.AppStoreState => "appStoreState",
                CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionExperiments => "appStoreVersionExperiments",
                CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionLocalizations => "appStoreVersionLocalizations",
                CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionPhasedRelease => "appStoreVersionPhasedRelease",
                CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionSubmission => "appStoreVersionSubmission",
                CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion.AppVersionState => "appVersionState",
                CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion.Build => "build",
                CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion.Copyright => "copyright",
                CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion.CreatedDate => "createdDate",
                CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion.CustomerReviews => "customerReviews",
                CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion.Downloadable => "downloadable",
                CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion.EarliestReleaseDate => "earliestReleaseDate",
                CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion.GameCenterAppVersion => "gameCenterAppVersion",
                CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion.Platform => "platform",
                CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion.ReleaseType => "releaseType",
                CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion.ReviewType => "reviewType",
                CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion.RoutingAppCoverage => "routingAppCoverage",
                CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion.UsesIdfa => "usesIdfa",
                CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion.VersionString => "versionString",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionPackage" => CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion.AlternativeDistributionPackage,
                "app" => CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion.App,
                "appClipDefaultExperience" => CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion.AppClipDefaultExperience,
                "appStoreReviewDetail" => CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion.AppStoreReviewDetail,
                "appStoreState" => CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion.AppStoreState,
                "appStoreVersionExperiments" => CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionExperiments,
                "appStoreVersionExperimentsV2" => CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionExperimentsV2,
                "appStoreVersionLocalizations" => CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionLocalizations,
                "appStoreVersionPhasedRelease" => CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionPhasedRelease,
                "appStoreVersionSubmission" => CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionSubmission,
                "appVersionState" => CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion.AppVersionState,
                "build" => CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion.Build,
                "copyright" => CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion.Copyright,
                "createdDate" => CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion.CreatedDate,
                "customerReviews" => CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion.CustomerReviews,
                "downloadable" => CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion.Downloadable,
                "earliestReleaseDate" => CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion.EarliestReleaseDate,
                "gameCenterAppVersion" => CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion.GameCenterAppVersion,
                "platform" => CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion.Platform,
                "releaseType" => CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion.ReleaseType,
                "reviewType" => CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion.ReviewType,
                "routingAppCoverage" => CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion.RoutingAppCoverage,
                "usesIdfa" => CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion.UsesIdfa,
                "versionString" => CiBuildRunsBuildsGetToManyRelatedFieldsAppStoreVersion.VersionString,
                _ => null,
            };
        }
    }
}