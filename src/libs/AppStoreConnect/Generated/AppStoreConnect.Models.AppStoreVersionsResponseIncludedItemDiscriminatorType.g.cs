
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionsResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        AlternativeDistributionPackages,
        /// <summary>
        /// 
        /// </summary>
        AppClipDefaultExperiences,
        /// <summary>
        /// 
        /// </summary>
        AppStoreReviewDetails,
        /// <summary>
        /// 
        /// </summary>
        AppStoreVersionExperiments,
        /// <summary>
        /// 
        /// </summary>
        AppStoreVersionLocalizations,
        /// <summary>
        /// 
        /// </summary>
        AppStoreVersionPhasedReleases,
        /// <summary>
        /// 
        /// </summary>
        AppStoreVersionSubmissions,
        /// <summary>
        /// 
        /// </summary>
        Apps,
        /// <summary>
        /// 
        /// </summary>
        Builds,
        /// <summary>
        /// 
        /// </summary>
        GameCenterAppVersions,
        /// <summary>
        /// 
        /// </summary>
        RoutingAppCoverages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionsResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionsResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                AppStoreVersionsResponseIncludedItemDiscriminatorType.AlternativeDistributionPackages => "alternativeDistributionPackages",
                AppStoreVersionsResponseIncludedItemDiscriminatorType.AppClipDefaultExperiences => "appClipDefaultExperiences",
                AppStoreVersionsResponseIncludedItemDiscriminatorType.AppStoreReviewDetails => "appStoreReviewDetails",
                AppStoreVersionsResponseIncludedItemDiscriminatorType.AppStoreVersionExperiments => "appStoreVersionExperiments",
                AppStoreVersionsResponseIncludedItemDiscriminatorType.AppStoreVersionLocalizations => "appStoreVersionLocalizations",
                AppStoreVersionsResponseIncludedItemDiscriminatorType.AppStoreVersionPhasedReleases => "appStoreVersionPhasedReleases",
                AppStoreVersionsResponseIncludedItemDiscriminatorType.AppStoreVersionSubmissions => "appStoreVersionSubmissions",
                AppStoreVersionsResponseIncludedItemDiscriminatorType.Apps => "apps",
                AppStoreVersionsResponseIncludedItemDiscriminatorType.Builds => "builds",
                AppStoreVersionsResponseIncludedItemDiscriminatorType.GameCenterAppVersions => "gameCenterAppVersions",
                AppStoreVersionsResponseIncludedItemDiscriminatorType.RoutingAppCoverages => "routingAppCoverages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionsResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionPackages" => AppStoreVersionsResponseIncludedItemDiscriminatorType.AlternativeDistributionPackages,
                "appClipDefaultExperiences" => AppStoreVersionsResponseIncludedItemDiscriminatorType.AppClipDefaultExperiences,
                "appStoreReviewDetails" => AppStoreVersionsResponseIncludedItemDiscriminatorType.AppStoreReviewDetails,
                "appStoreVersionExperiments" => AppStoreVersionsResponseIncludedItemDiscriminatorType.AppStoreVersionExperiments,
                "appStoreVersionLocalizations" => AppStoreVersionsResponseIncludedItemDiscriminatorType.AppStoreVersionLocalizations,
                "appStoreVersionPhasedReleases" => AppStoreVersionsResponseIncludedItemDiscriminatorType.AppStoreVersionPhasedReleases,
                "appStoreVersionSubmissions" => AppStoreVersionsResponseIncludedItemDiscriminatorType.AppStoreVersionSubmissions,
                "apps" => AppStoreVersionsResponseIncludedItemDiscriminatorType.Apps,
                "builds" => AppStoreVersionsResponseIncludedItemDiscriminatorType.Builds,
                "gameCenterAppVersions" => AppStoreVersionsResponseIncludedItemDiscriminatorType.GameCenterAppVersions,
                "routingAppCoverages" => AppStoreVersionsResponseIncludedItemDiscriminatorType.RoutingAppCoverages,
                _ => null,
            };
        }
    }
}