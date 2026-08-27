
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionResponseIncludedItemDiscriminatorType
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
    public static class AppStoreVersionResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                AppStoreVersionResponseIncludedItemDiscriminatorType.AlternativeDistributionPackages => "alternativeDistributionPackages",
                AppStoreVersionResponseIncludedItemDiscriminatorType.AppClipDefaultExperiences => "appClipDefaultExperiences",
                AppStoreVersionResponseIncludedItemDiscriminatorType.AppStoreReviewDetails => "appStoreReviewDetails",
                AppStoreVersionResponseIncludedItemDiscriminatorType.AppStoreVersionExperiments => "appStoreVersionExperiments",
                AppStoreVersionResponseIncludedItemDiscriminatorType.AppStoreVersionLocalizations => "appStoreVersionLocalizations",
                AppStoreVersionResponseIncludedItemDiscriminatorType.AppStoreVersionPhasedReleases => "appStoreVersionPhasedReleases",
                AppStoreVersionResponseIncludedItemDiscriminatorType.AppStoreVersionSubmissions => "appStoreVersionSubmissions",
                AppStoreVersionResponseIncludedItemDiscriminatorType.Apps => "apps",
                AppStoreVersionResponseIncludedItemDiscriminatorType.Builds => "builds",
                AppStoreVersionResponseIncludedItemDiscriminatorType.GameCenterAppVersions => "gameCenterAppVersions",
                AppStoreVersionResponseIncludedItemDiscriminatorType.RoutingAppCoverages => "routingAppCoverages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "alternativeDistributionPackages" => AppStoreVersionResponseIncludedItemDiscriminatorType.AlternativeDistributionPackages,
                "appClipDefaultExperiences" => AppStoreVersionResponseIncludedItemDiscriminatorType.AppClipDefaultExperiences,
                "appStoreReviewDetails" => AppStoreVersionResponseIncludedItemDiscriminatorType.AppStoreReviewDetails,
                "appStoreVersionExperiments" => AppStoreVersionResponseIncludedItemDiscriminatorType.AppStoreVersionExperiments,
                "appStoreVersionLocalizations" => AppStoreVersionResponseIncludedItemDiscriminatorType.AppStoreVersionLocalizations,
                "appStoreVersionPhasedReleases" => AppStoreVersionResponseIncludedItemDiscriminatorType.AppStoreVersionPhasedReleases,
                "appStoreVersionSubmissions" => AppStoreVersionResponseIncludedItemDiscriminatorType.AppStoreVersionSubmissions,
                "apps" => AppStoreVersionResponseIncludedItemDiscriminatorType.Apps,
                "builds" => AppStoreVersionResponseIncludedItemDiscriminatorType.Builds,
                "gameCenterAppVersions" => AppStoreVersionResponseIncludedItemDiscriminatorType.GameCenterAppVersions,
                "routingAppCoverages" => AppStoreVersionResponseIncludedItemDiscriminatorType.RoutingAppCoverages,
                _ => null,
            };
        }
    }
}