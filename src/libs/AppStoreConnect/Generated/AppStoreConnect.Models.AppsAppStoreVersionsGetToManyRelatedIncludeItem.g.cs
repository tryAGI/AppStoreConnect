
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsAppStoreVersionsGetToManyRelatedIncludeItem
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
    public static class AppsAppStoreVersionsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsAppStoreVersionsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                AppsAppStoreVersionsGetToManyRelatedIncludeItem.AlternativeDistributionPackage => "alternativeDistributionPackage",
                AppsAppStoreVersionsGetToManyRelatedIncludeItem.App => "app",
                AppsAppStoreVersionsGetToManyRelatedIncludeItem.AppClipDefaultExperience => "appClipDefaultExperience",
                AppsAppStoreVersionsGetToManyRelatedIncludeItem.AppStoreReviewDetail => "appStoreReviewDetail",
                AppsAppStoreVersionsGetToManyRelatedIncludeItem.AppStoreVersionExperiments => "appStoreVersionExperiments",
                AppsAppStoreVersionsGetToManyRelatedIncludeItem.AppStoreVersionExperimentsV2 => "appStoreVersionExperimentsV2",
                AppsAppStoreVersionsGetToManyRelatedIncludeItem.AppStoreVersionLocalizations => "appStoreVersionLocalizations",
                AppsAppStoreVersionsGetToManyRelatedIncludeItem.AppStoreVersionPhasedRelease => "appStoreVersionPhasedRelease",
                AppsAppStoreVersionsGetToManyRelatedIncludeItem.AppStoreVersionSubmission => "appStoreVersionSubmission",
                AppsAppStoreVersionsGetToManyRelatedIncludeItem.Build => "build",
                AppsAppStoreVersionsGetToManyRelatedIncludeItem.GameCenterAppVersion => "gameCenterAppVersion",
                AppsAppStoreVersionsGetToManyRelatedIncludeItem.RoutingAppCoverage => "routingAppCoverage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsAppStoreVersionsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionPackage" => AppsAppStoreVersionsGetToManyRelatedIncludeItem.AlternativeDistributionPackage,
                "app" => AppsAppStoreVersionsGetToManyRelatedIncludeItem.App,
                "appClipDefaultExperience" => AppsAppStoreVersionsGetToManyRelatedIncludeItem.AppClipDefaultExperience,
                "appStoreReviewDetail" => AppsAppStoreVersionsGetToManyRelatedIncludeItem.AppStoreReviewDetail,
                "appStoreVersionExperiments" => AppsAppStoreVersionsGetToManyRelatedIncludeItem.AppStoreVersionExperiments,
                "appStoreVersionExperimentsV2" => AppsAppStoreVersionsGetToManyRelatedIncludeItem.AppStoreVersionExperimentsV2,
                "appStoreVersionLocalizations" => AppsAppStoreVersionsGetToManyRelatedIncludeItem.AppStoreVersionLocalizations,
                "appStoreVersionPhasedRelease" => AppsAppStoreVersionsGetToManyRelatedIncludeItem.AppStoreVersionPhasedRelease,
                "appStoreVersionSubmission" => AppsAppStoreVersionsGetToManyRelatedIncludeItem.AppStoreVersionSubmission,
                "build" => AppsAppStoreVersionsGetToManyRelatedIncludeItem.Build,
                "gameCenterAppVersion" => AppsAppStoreVersionsGetToManyRelatedIncludeItem.GameCenterAppVersion,
                "routingAppCoverage" => AppsAppStoreVersionsGetToManyRelatedIncludeItem.RoutingAppCoverage,
                _ => null,
            };
        }
    }
}