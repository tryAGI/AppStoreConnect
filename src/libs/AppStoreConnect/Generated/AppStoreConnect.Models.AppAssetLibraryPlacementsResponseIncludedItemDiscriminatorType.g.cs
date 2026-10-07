
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryPlacementsResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        AppAssetLibraryImages,
        /// <summary>
        ///
        /// </summary>
        AppAssetLibraryVideos,
        /// <summary>
        ///
        /// </summary>
        AppCustomProductPageLocalizations,
        /// <summary>
        ///
        /// </summary>
        AppEventLocalizations,
        /// <summary>
        ///
        /// </summary>
        AppStoreVersionExperimentTreatmentLocalizations,
        /// <summary>
        ///
        /// </summary>
        AppStoreVersionLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAssetLibraryPlacementsResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryPlacementsResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                AppAssetLibraryPlacementsResponseIncludedItemDiscriminatorType.AppAssetLibraryImages => "appAssetLibraryImages",
                AppAssetLibraryPlacementsResponseIncludedItemDiscriminatorType.AppAssetLibraryVideos => "appAssetLibraryVideos",
                AppAssetLibraryPlacementsResponseIncludedItemDiscriminatorType.AppCustomProductPageLocalizations => "appCustomProductPageLocalizations",
                AppAssetLibraryPlacementsResponseIncludedItemDiscriminatorType.AppEventLocalizations => "appEventLocalizations",
                AppAssetLibraryPlacementsResponseIncludedItemDiscriminatorType.AppStoreVersionExperimentTreatmentLocalizations => "appStoreVersionExperimentTreatmentLocalizations",
                AppAssetLibraryPlacementsResponseIncludedItemDiscriminatorType.AppStoreVersionLocalizations => "appStoreVersionLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryPlacementsResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "appAssetLibraryImages" => AppAssetLibraryPlacementsResponseIncludedItemDiscriminatorType.AppAssetLibraryImages,
                "appAssetLibraryVideos" => AppAssetLibraryPlacementsResponseIncludedItemDiscriminatorType.AppAssetLibraryVideos,
                "appCustomProductPageLocalizations" => AppAssetLibraryPlacementsResponseIncludedItemDiscriminatorType.AppCustomProductPageLocalizations,
                "appEventLocalizations" => AppAssetLibraryPlacementsResponseIncludedItemDiscriminatorType.AppEventLocalizations,
                "appStoreVersionExperimentTreatmentLocalizations" => AppAssetLibraryPlacementsResponseIncludedItemDiscriminatorType.AppStoreVersionExperimentTreatmentLocalizations,
                "appStoreVersionLocalizations" => AppAssetLibraryPlacementsResponseIncludedItemDiscriminatorType.AppStoreVersionLocalizations,
                _ => null,
            };
        }
    }
}