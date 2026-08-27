
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersion
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
    public static class AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersion value)
        {
            return value switch
            {
                AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersion.AlternativeDistributionPackage => "alternativeDistributionPackage",
                AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersion.App => "app",
                AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersion.AppClipDefaultExperience => "appClipDefaultExperience",
                AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersion.AppStoreReviewDetail => "appStoreReviewDetail",
                AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersion.AppStoreState => "appStoreState",
                AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionExperiments => "appStoreVersionExperiments",
                AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionLocalizations => "appStoreVersionLocalizations",
                AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionPhasedRelease => "appStoreVersionPhasedRelease",
                AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionSubmission => "appStoreVersionSubmission",
                AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersion.AppVersionState => "appVersionState",
                AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersion.Build => "build",
                AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersion.Copyright => "copyright",
                AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersion.CreatedDate => "createdDate",
                AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersion.CustomerReviews => "customerReviews",
                AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersion.Downloadable => "downloadable",
                AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersion.EarliestReleaseDate => "earliestReleaseDate",
                AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersion.GameCenterAppVersion => "gameCenterAppVersion",
                AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersion.Platform => "platform",
                AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersion.ReleaseType => "releaseType",
                AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersion.ReviewType => "reviewType",
                AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersion.RoutingAppCoverage => "routingAppCoverage",
                AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersion.UsesIdfa => "usesIdfa",
                AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersion.VersionString => "versionString",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersion? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionPackage" => AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersion.AlternativeDistributionPackage,
                "app" => AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersion.App,
                "appClipDefaultExperience" => AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersion.AppClipDefaultExperience,
                "appStoreReviewDetail" => AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersion.AppStoreReviewDetail,
                "appStoreState" => AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersion.AppStoreState,
                "appStoreVersionExperiments" => AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionExperiments,
                "appStoreVersionExperimentsV2" => AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionExperimentsV2,
                "appStoreVersionLocalizations" => AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionLocalizations,
                "appStoreVersionPhasedRelease" => AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionPhasedRelease,
                "appStoreVersionSubmission" => AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionSubmission,
                "appVersionState" => AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersion.AppVersionState,
                "build" => AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersion.Build,
                "copyright" => AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersion.Copyright,
                "createdDate" => AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersion.CreatedDate,
                "customerReviews" => AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersion.CustomerReviews,
                "downloadable" => AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersion.Downloadable,
                "earliestReleaseDate" => AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersion.EarliestReleaseDate,
                "gameCenterAppVersion" => AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersion.GameCenterAppVersion,
                "platform" => AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersion.Platform,
                "releaseType" => AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersion.ReleaseType,
                "reviewType" => AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersion.ReviewType,
                "routingAppCoverage" => AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersion.RoutingAppCoverage,
                "usesIdfa" => AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersion.UsesIdfa,
                "versionString" => AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersion.VersionString,
                _ => null,
            };
        }
    }
}