
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryPlacementResponseIncludedItemDiscriminatorType
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
    public static class AppAssetLibraryPlacementResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryPlacementResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                AppAssetLibraryPlacementResponseIncludedItemDiscriminatorType.AppAssetLibraryImages => "appAssetLibraryImages",
                AppAssetLibraryPlacementResponseIncludedItemDiscriminatorType.AppAssetLibraryVideos => "appAssetLibraryVideos",
                AppAssetLibraryPlacementResponseIncludedItemDiscriminatorType.AppCustomProductPageLocalizations => "appCustomProductPageLocalizations",
                AppAssetLibraryPlacementResponseIncludedItemDiscriminatorType.AppEventLocalizations => "appEventLocalizations",
                AppAssetLibraryPlacementResponseIncludedItemDiscriminatorType.AppStoreVersionExperimentTreatmentLocalizations => "appStoreVersionExperimentTreatmentLocalizations",
                AppAssetLibraryPlacementResponseIncludedItemDiscriminatorType.AppStoreVersionLocalizations => "appStoreVersionLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryPlacementResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "appAssetLibraryImages" => AppAssetLibraryPlacementResponseIncludedItemDiscriminatorType.AppAssetLibraryImages,
                "appAssetLibraryVideos" => AppAssetLibraryPlacementResponseIncludedItemDiscriminatorType.AppAssetLibraryVideos,
                "appCustomProductPageLocalizations" => AppAssetLibraryPlacementResponseIncludedItemDiscriminatorType.AppCustomProductPageLocalizations,
                "appEventLocalizations" => AppAssetLibraryPlacementResponseIncludedItemDiscriminatorType.AppEventLocalizations,
                "appStoreVersionExperimentTreatmentLocalizations" => AppAssetLibraryPlacementResponseIncludedItemDiscriminatorType.AppStoreVersionExperimentTreatmentLocalizations,
                "appStoreVersionLocalizations" => AppAssetLibraryPlacementResponseIncludedItemDiscriminatorType.AppStoreVersionLocalizations,
                _ => null,
            };
        }
    }
}