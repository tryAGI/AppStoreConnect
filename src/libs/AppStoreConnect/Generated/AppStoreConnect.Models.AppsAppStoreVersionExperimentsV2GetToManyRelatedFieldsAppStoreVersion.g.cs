
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion
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
    public static class AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion value)
        {
            return value switch
            {
                AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.AlternativeDistributionPackage => "alternativeDistributionPackage",
                AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.App => "app",
                AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.AppClipDefaultExperience => "appClipDefaultExperience",
                AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.AppStoreReviewDetail => "appStoreReviewDetail",
                AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.AppStoreState => "appStoreState",
                AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.AppStoreVersionExperiments => "appStoreVersionExperiments",
                AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.AppStoreVersionLocalizations => "appStoreVersionLocalizations",
                AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.AppStoreVersionPhasedRelease => "appStoreVersionPhasedRelease",
                AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.AppStoreVersionSubmission => "appStoreVersionSubmission",
                AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.AppVersionState => "appVersionState",
                AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.Build => "build",
                AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.Copyright => "copyright",
                AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.CreatedDate => "createdDate",
                AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.CustomerReviews => "customerReviews",
                AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.Downloadable => "downloadable",
                AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.EarliestReleaseDate => "earliestReleaseDate",
                AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.GameCenterAppVersion => "gameCenterAppVersion",
                AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.Platform => "platform",
                AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.ReleaseType => "releaseType",
                AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.ReviewType => "reviewType",
                AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.RoutingAppCoverage => "routingAppCoverage",
                AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.UsesIdfa => "usesIdfa",
                AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.VersionString => "versionString",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionPackage" => AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.AlternativeDistributionPackage,
                "app" => AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.App,
                "appClipDefaultExperience" => AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.AppClipDefaultExperience,
                "appStoreReviewDetail" => AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.AppStoreReviewDetail,
                "appStoreState" => AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.AppStoreState,
                "appStoreVersionExperiments" => AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.AppStoreVersionExperiments,
                "appStoreVersionExperimentsV2" => AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.AppStoreVersionExperimentsV2,
                "appStoreVersionLocalizations" => AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.AppStoreVersionLocalizations,
                "appStoreVersionPhasedRelease" => AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.AppStoreVersionPhasedRelease,
                "appStoreVersionSubmission" => AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.AppStoreVersionSubmission,
                "appVersionState" => AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.AppVersionState,
                "build" => AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.Build,
                "copyright" => AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.Copyright,
                "createdDate" => AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.CreatedDate,
                "customerReviews" => AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.CustomerReviews,
                "downloadable" => AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.Downloadable,
                "earliestReleaseDate" => AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.EarliestReleaseDate,
                "gameCenterAppVersion" => AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.GameCenterAppVersion,
                "platform" => AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.Platform,
                "releaseType" => AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.ReleaseType,
                "reviewType" => AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.ReviewType,
                "routingAppCoverage" => AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.RoutingAppCoverage,
                "usesIdfa" => AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.UsesIdfa,
                "versionString" => AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion.VersionString,
                _ => null,
            };
        }
    }
}