
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedIncludeItem
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
        Build,
        /// <summary>
        ///
        /// </summary>
        GameCenterAppVersion,
        /// <summary>
        ///
        /// </summary>
        RoutingAppCoverage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedIncludeItem value)
        {
            return value switch
            {
                AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedIncludeItem.AlternativeDistributionPackage => "alternativeDistributionPackage",
                AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedIncludeItem.App => "app",
                AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedIncludeItem.AppClipDefaultExperience => "appClipDefaultExperience",
                AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedIncludeItem.AppStoreReviewDetail => "appStoreReviewDetail",
                AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedIncludeItem.AppStoreVersionExperiments => "appStoreVersionExperiments",
                AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedIncludeItem.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedIncludeItem.AppStoreVersionLocalizations => "appStoreVersionLocalizations",
                AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedIncludeItem.AppStoreVersionPhasedRelease => "appStoreVersionPhasedRelease",
                AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedIncludeItem.AppStoreVersionSubmission => "appStoreVersionSubmission",
                AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedIncludeItem.Build => "build",
                AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedIncludeItem.GameCenterAppVersion => "gameCenterAppVersion",
                AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedIncludeItem.RoutingAppCoverage => "routingAppCoverage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionPackage" => AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedIncludeItem.AlternativeDistributionPackage,
                "app" => AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedIncludeItem.App,
                "appClipDefaultExperience" => AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedIncludeItem.AppClipDefaultExperience,
                "appStoreReviewDetail" => AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedIncludeItem.AppStoreReviewDetail,
                "appStoreVersionExperiments" => AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedIncludeItem.AppStoreVersionExperiments,
                "appStoreVersionExperimentsV2" => AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedIncludeItem.AppStoreVersionExperimentsV2,
                "appStoreVersionLocalizations" => AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedIncludeItem.AppStoreVersionLocalizations,
                "appStoreVersionPhasedRelease" => AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedIncludeItem.AppStoreVersionPhasedRelease,
                "appStoreVersionSubmission" => AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedIncludeItem.AppStoreVersionSubmission,
                "build" => AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedIncludeItem.Build,
                "gameCenterAppVersion" => AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedIncludeItem.GameCenterAppVersion,
                "routingAppCoverage" => AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedIncludeItem.RoutingAppCoverage,
                _ => null,
            };
        }
    }
}