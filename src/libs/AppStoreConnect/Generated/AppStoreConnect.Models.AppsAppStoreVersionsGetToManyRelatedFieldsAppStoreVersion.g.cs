
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersion
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
    public static class AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersion value)
        {
            return value switch
            {
                AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersion.AlternativeDistributionPackage => "alternativeDistributionPackage",
                AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersion.App => "app",
                AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersion.AppClipDefaultExperience => "appClipDefaultExperience",
                AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersion.AppStoreReviewDetail => "appStoreReviewDetail",
                AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersion.AppStoreState => "appStoreState",
                AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionExperiments => "appStoreVersionExperiments",
                AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionLocalizations => "appStoreVersionLocalizations",
                AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionPhasedRelease => "appStoreVersionPhasedRelease",
                AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionSubmission => "appStoreVersionSubmission",
                AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersion.AppVersionState => "appVersionState",
                AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersion.Build => "build",
                AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersion.Copyright => "copyright",
                AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersion.CreatedDate => "createdDate",
                AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersion.CustomerReviews => "customerReviews",
                AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersion.Downloadable => "downloadable",
                AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersion.EarliestReleaseDate => "earliestReleaseDate",
                AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersion.GameCenterAppVersion => "gameCenterAppVersion",
                AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersion.Platform => "platform",
                AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersion.ReleaseType => "releaseType",
                AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersion.ReviewType => "reviewType",
                AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersion.RoutingAppCoverage => "routingAppCoverage",
                AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersion.UsesIdfa => "usesIdfa",
                AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersion.VersionString => "versionString",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersion? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionPackage" => AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersion.AlternativeDistributionPackage,
                "app" => AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersion.App,
                "appClipDefaultExperience" => AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersion.AppClipDefaultExperience,
                "appStoreReviewDetail" => AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersion.AppStoreReviewDetail,
                "appStoreState" => AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersion.AppStoreState,
                "appStoreVersionExperiments" => AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionExperiments,
                "appStoreVersionExperimentsV2" => AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionExperimentsV2,
                "appStoreVersionLocalizations" => AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionLocalizations,
                "appStoreVersionPhasedRelease" => AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionPhasedRelease,
                "appStoreVersionSubmission" => AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersion.AppStoreVersionSubmission,
                "appVersionState" => AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersion.AppVersionState,
                "build" => AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersion.Build,
                "copyright" => AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersion.Copyright,
                "createdDate" => AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersion.CreatedDate,
                "customerReviews" => AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersion.CustomerReviews,
                "downloadable" => AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersion.Downloadable,
                "earliestReleaseDate" => AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersion.EarliestReleaseDate,
                "gameCenterAppVersion" => AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersion.GameCenterAppVersion,
                "platform" => AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersion.Platform,
                "releaseType" => AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersion.ReleaseType,
                "reviewType" => AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersion.ReviewType,
                "routingAppCoverage" => AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersion.RoutingAppCoverage,
                "usesIdfa" => AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersion.UsesIdfa,
                "versionString" => AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersion.VersionString,
                _ => null,
            };
        }
    }
}