
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion
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
    public static class AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion value)
        {
            return value switch
            {
                AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.AlternativeDistributionPackage => "alternativeDistributionPackage",
                AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.App => "app",
                AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.AppClipDefaultExperience => "appClipDefaultExperience",
                AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.AppStoreReviewDetail => "appStoreReviewDetail",
                AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.AppStoreState => "appStoreState",
                AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.AppStoreVersionExperiments => "appStoreVersionExperiments",
                AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.AppStoreVersionLocalizations => "appStoreVersionLocalizations",
                AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.AppStoreVersionPhasedRelease => "appStoreVersionPhasedRelease",
                AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.AppStoreVersionSubmission => "appStoreVersionSubmission",
                AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.AppVersionState => "appVersionState",
                AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.Build => "build",
                AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.Copyright => "copyright",
                AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.CreatedDate => "createdDate",
                AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.CustomerReviews => "customerReviews",
                AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.Downloadable => "downloadable",
                AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.EarliestReleaseDate => "earliestReleaseDate",
                AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.GameCenterAppVersion => "gameCenterAppVersion",
                AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.Platform => "platform",
                AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.ReleaseType => "releaseType",
                AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.ReviewType => "reviewType",
                AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.RoutingAppCoverage => "routingAppCoverage",
                AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.UsesIdfa => "usesIdfa",
                AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.VersionString => "versionString",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionPackage" => AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.AlternativeDistributionPackage,
                "app" => AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.App,
                "appClipDefaultExperience" => AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.AppClipDefaultExperience,
                "appStoreReviewDetail" => AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.AppStoreReviewDetail,
                "appStoreState" => AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.AppStoreState,
                "appStoreVersionExperiments" => AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.AppStoreVersionExperiments,
                "appStoreVersionExperimentsV2" => AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.AppStoreVersionExperimentsV2,
                "appStoreVersionLocalizations" => AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.AppStoreVersionLocalizations,
                "appStoreVersionPhasedRelease" => AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.AppStoreVersionPhasedRelease,
                "appStoreVersionSubmission" => AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.AppStoreVersionSubmission,
                "appVersionState" => AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.AppVersionState,
                "build" => AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.Build,
                "copyright" => AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.Copyright,
                "createdDate" => AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.CreatedDate,
                "customerReviews" => AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.CustomerReviews,
                "downloadable" => AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.Downloadable,
                "earliestReleaseDate" => AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.EarliestReleaseDate,
                "gameCenterAppVersion" => AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.GameCenterAppVersion,
                "platform" => AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.Platform,
                "releaseType" => AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.ReleaseType,
                "reviewType" => AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.ReviewType,
                "routingAppCoverage" => AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.RoutingAppCoverage,
                "usesIdfa" => AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.UsesIdfa,
                "versionString" => AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.VersionString,
                _ => null,
            };
        }
    }
}