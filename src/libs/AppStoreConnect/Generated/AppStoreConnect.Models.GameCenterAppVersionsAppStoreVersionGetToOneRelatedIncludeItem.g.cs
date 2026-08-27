
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAppVersionsAppStoreVersionGetToOneRelatedIncludeItem
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
    public static class GameCenterAppVersionsAppStoreVersionGetToOneRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAppVersionsAppStoreVersionGetToOneRelatedIncludeItem value)
        {
            return value switch
            {
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedIncludeItem.AlternativeDistributionPackage => "alternativeDistributionPackage",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedIncludeItem.App => "app",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedIncludeItem.AppClipDefaultExperience => "appClipDefaultExperience",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedIncludeItem.AppStoreReviewDetail => "appStoreReviewDetail",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedIncludeItem.AppStoreVersionExperiments => "appStoreVersionExperiments",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedIncludeItem.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedIncludeItem.AppStoreVersionLocalizations => "appStoreVersionLocalizations",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedIncludeItem.AppStoreVersionPhasedRelease => "appStoreVersionPhasedRelease",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedIncludeItem.AppStoreVersionSubmission => "appStoreVersionSubmission",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedIncludeItem.Build => "build",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedIncludeItem.GameCenterAppVersion => "gameCenterAppVersion",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedIncludeItem.RoutingAppCoverage => "routingAppCoverage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAppVersionsAppStoreVersionGetToOneRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionPackage" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedIncludeItem.AlternativeDistributionPackage,
                "app" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedIncludeItem.App,
                "appClipDefaultExperience" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedIncludeItem.AppClipDefaultExperience,
                "appStoreReviewDetail" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedIncludeItem.AppStoreReviewDetail,
                "appStoreVersionExperiments" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedIncludeItem.AppStoreVersionExperiments,
                "appStoreVersionExperimentsV2" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedIncludeItem.AppStoreVersionExperimentsV2,
                "appStoreVersionLocalizations" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedIncludeItem.AppStoreVersionLocalizations,
                "appStoreVersionPhasedRelease" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedIncludeItem.AppStoreVersionPhasedRelease,
                "appStoreVersionSubmission" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedIncludeItem.AppStoreVersionSubmission,
                "build" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedIncludeItem.Build,
                "gameCenterAppVersion" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedIncludeItem.GameCenterAppVersion,
                "routingAppCoverage" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedIncludeItem.RoutingAppCoverage,
                _ => null,
            };
        }
    }
}