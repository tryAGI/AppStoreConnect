
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildsAppStoreVersionGetToOneRelatedIncludeItem
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
    public static class BuildsAppStoreVersionGetToOneRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildsAppStoreVersionGetToOneRelatedIncludeItem value)
        {
            return value switch
            {
                BuildsAppStoreVersionGetToOneRelatedIncludeItem.AlternativeDistributionPackage => "alternativeDistributionPackage",
                BuildsAppStoreVersionGetToOneRelatedIncludeItem.App => "app",
                BuildsAppStoreVersionGetToOneRelatedIncludeItem.AppClipDefaultExperience => "appClipDefaultExperience",
                BuildsAppStoreVersionGetToOneRelatedIncludeItem.AppStoreReviewDetail => "appStoreReviewDetail",
                BuildsAppStoreVersionGetToOneRelatedIncludeItem.AppStoreVersionExperiments => "appStoreVersionExperiments",
                BuildsAppStoreVersionGetToOneRelatedIncludeItem.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                BuildsAppStoreVersionGetToOneRelatedIncludeItem.AppStoreVersionLocalizations => "appStoreVersionLocalizations",
                BuildsAppStoreVersionGetToOneRelatedIncludeItem.AppStoreVersionPhasedRelease => "appStoreVersionPhasedRelease",
                BuildsAppStoreVersionGetToOneRelatedIncludeItem.AppStoreVersionSubmission => "appStoreVersionSubmission",
                BuildsAppStoreVersionGetToOneRelatedIncludeItem.Build => "build",
                BuildsAppStoreVersionGetToOneRelatedIncludeItem.GameCenterAppVersion => "gameCenterAppVersion",
                BuildsAppStoreVersionGetToOneRelatedIncludeItem.RoutingAppCoverage => "routingAppCoverage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildsAppStoreVersionGetToOneRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionPackage" => BuildsAppStoreVersionGetToOneRelatedIncludeItem.AlternativeDistributionPackage,
                "app" => BuildsAppStoreVersionGetToOneRelatedIncludeItem.App,
                "appClipDefaultExperience" => BuildsAppStoreVersionGetToOneRelatedIncludeItem.AppClipDefaultExperience,
                "appStoreReviewDetail" => BuildsAppStoreVersionGetToOneRelatedIncludeItem.AppStoreReviewDetail,
                "appStoreVersionExperiments" => BuildsAppStoreVersionGetToOneRelatedIncludeItem.AppStoreVersionExperiments,
                "appStoreVersionExperimentsV2" => BuildsAppStoreVersionGetToOneRelatedIncludeItem.AppStoreVersionExperimentsV2,
                "appStoreVersionLocalizations" => BuildsAppStoreVersionGetToOneRelatedIncludeItem.AppStoreVersionLocalizations,
                "appStoreVersionPhasedRelease" => BuildsAppStoreVersionGetToOneRelatedIncludeItem.AppStoreVersionPhasedRelease,
                "appStoreVersionSubmission" => BuildsAppStoreVersionGetToOneRelatedIncludeItem.AppStoreVersionSubmission,
                "build" => BuildsAppStoreVersionGetToOneRelatedIncludeItem.Build,
                "gameCenterAppVersion" => BuildsAppStoreVersionGetToOneRelatedIncludeItem.GameCenterAppVersion,
                "routingAppCoverage" => BuildsAppStoreVersionGetToOneRelatedIncludeItem.RoutingAppCoverage,
                _ => null,
            };
        }
    }
}