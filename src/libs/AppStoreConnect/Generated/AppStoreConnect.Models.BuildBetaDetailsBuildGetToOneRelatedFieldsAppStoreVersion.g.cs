
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersion
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
    public static class BuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersion value)
        {
            return value switch
            {
                BuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersion.AlternativeDistributionPackage => "alternativeDistributionPackage",
                BuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersion.App => "app",
                BuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersion.AppClipDefaultExperience => "appClipDefaultExperience",
                BuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersion.AppStoreReviewDetail => "appStoreReviewDetail",
                BuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersion.AppStoreState => "appStoreState",
                BuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionExperiments => "appStoreVersionExperiments",
                BuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                BuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionLocalizations => "appStoreVersionLocalizations",
                BuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionPhasedRelease => "appStoreVersionPhasedRelease",
                BuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionSubmission => "appStoreVersionSubmission",
                BuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersion.AppVersionState => "appVersionState",
                BuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersion.Build => "build",
                BuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersion.Copyright => "copyright",
                BuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersion.CreatedDate => "createdDate",
                BuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersion.CustomerReviews => "customerReviews",
                BuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersion.Downloadable => "downloadable",
                BuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersion.EarliestReleaseDate => "earliestReleaseDate",
                BuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersion.GameCenterAppVersion => "gameCenterAppVersion",
                BuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersion.Platform => "platform",
                BuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersion.ReleaseType => "releaseType",
                BuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersion.ReviewType => "reviewType",
                BuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersion.RoutingAppCoverage => "routingAppCoverage",
                BuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersion.UsesIdfa => "usesIdfa",
                BuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersion.VersionString => "versionString",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersion? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionPackage" => BuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersion.AlternativeDistributionPackage,
                "app" => BuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersion.App,
                "appClipDefaultExperience" => BuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersion.AppClipDefaultExperience,
                "appStoreReviewDetail" => BuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersion.AppStoreReviewDetail,
                "appStoreState" => BuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersion.AppStoreState,
                "appStoreVersionExperiments" => BuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionExperiments,
                "appStoreVersionExperimentsV2" => BuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionExperimentsV2,
                "appStoreVersionLocalizations" => BuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionLocalizations,
                "appStoreVersionPhasedRelease" => BuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionPhasedRelease,
                "appStoreVersionSubmission" => BuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersion.AppStoreVersionSubmission,
                "appVersionState" => BuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersion.AppVersionState,
                "build" => BuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersion.Build,
                "copyright" => BuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersion.Copyright,
                "createdDate" => BuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersion.CreatedDate,
                "customerReviews" => BuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersion.CustomerReviews,
                "downloadable" => BuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersion.Downloadable,
                "earliestReleaseDate" => BuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersion.EarliestReleaseDate,
                "gameCenterAppVersion" => BuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersion.GameCenterAppVersion,
                "platform" => BuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersion.Platform,
                "releaseType" => BuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersion.ReleaseType,
                "reviewType" => BuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersion.ReviewType,
                "routingAppCoverage" => BuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersion.RoutingAppCoverage,
                "usesIdfa" => BuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersion.UsesIdfa,
                "versionString" => BuildBetaDetailsBuildGetToOneRelatedFieldsAppStoreVersion.VersionString,
                _ => null,
            };
        }
    }
}