
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionsGetInstanceIncludeItem
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
    public static class AppStoreVersionsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionsGetInstanceIncludeItem value)
        {
            return value switch
            {
                AppStoreVersionsGetInstanceIncludeItem.AlternativeDistributionPackage => "alternativeDistributionPackage",
                AppStoreVersionsGetInstanceIncludeItem.App => "app",
                AppStoreVersionsGetInstanceIncludeItem.AppClipDefaultExperience => "appClipDefaultExperience",
                AppStoreVersionsGetInstanceIncludeItem.AppStoreReviewDetail => "appStoreReviewDetail",
                AppStoreVersionsGetInstanceIncludeItem.AppStoreVersionExperiments => "appStoreVersionExperiments",
                AppStoreVersionsGetInstanceIncludeItem.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                AppStoreVersionsGetInstanceIncludeItem.AppStoreVersionLocalizations => "appStoreVersionLocalizations",
                AppStoreVersionsGetInstanceIncludeItem.AppStoreVersionPhasedRelease => "appStoreVersionPhasedRelease",
                AppStoreVersionsGetInstanceIncludeItem.AppStoreVersionSubmission => "appStoreVersionSubmission",
                AppStoreVersionsGetInstanceIncludeItem.Build => "build",
                AppStoreVersionsGetInstanceIncludeItem.GameCenterAppVersion => "gameCenterAppVersion",
                AppStoreVersionsGetInstanceIncludeItem.RoutingAppCoverage => "routingAppCoverage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionPackage" => AppStoreVersionsGetInstanceIncludeItem.AlternativeDistributionPackage,
                "app" => AppStoreVersionsGetInstanceIncludeItem.App,
                "appClipDefaultExperience" => AppStoreVersionsGetInstanceIncludeItem.AppClipDefaultExperience,
                "appStoreReviewDetail" => AppStoreVersionsGetInstanceIncludeItem.AppStoreReviewDetail,
                "appStoreVersionExperiments" => AppStoreVersionsGetInstanceIncludeItem.AppStoreVersionExperiments,
                "appStoreVersionExperimentsV2" => AppStoreVersionsGetInstanceIncludeItem.AppStoreVersionExperimentsV2,
                "appStoreVersionLocalizations" => AppStoreVersionsGetInstanceIncludeItem.AppStoreVersionLocalizations,
                "appStoreVersionPhasedRelease" => AppStoreVersionsGetInstanceIncludeItem.AppStoreVersionPhasedRelease,
                "appStoreVersionSubmission" => AppStoreVersionsGetInstanceIncludeItem.AppStoreVersionSubmission,
                "build" => AppStoreVersionsGetInstanceIncludeItem.Build,
                "gameCenterAppVersion" => AppStoreVersionsGetInstanceIncludeItem.GameCenterAppVersion,
                "routingAppCoverage" => AppStoreVersionsGetInstanceIncludeItem.RoutingAppCoverage,
                _ => null,
            };
        }
    }
}