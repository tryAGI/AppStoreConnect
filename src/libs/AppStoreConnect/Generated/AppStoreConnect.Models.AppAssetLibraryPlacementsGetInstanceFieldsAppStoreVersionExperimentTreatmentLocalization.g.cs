
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryPlacementsGetInstanceFieldsAppStoreVersionExperimentTreatmentLocalization
    {
        /// <summary>
        ///
        /// </summary>
        AppPreviewSets,
        /// <summary>
        ///
        /// </summary>
        AppScreenshotSets,
        /// <summary>
        ///
        /// </summary>
        AppStoreVersionExperimentTreatment,
        /// <summary>
        ///
        /// </summary>
        Locale,
        /// <summary>
        ///
        /// </summary>
        Placements,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAssetLibraryPlacementsGetInstanceFieldsAppStoreVersionExperimentTreatmentLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryPlacementsGetInstanceFieldsAppStoreVersionExperimentTreatmentLocalization value)
        {
            return value switch
            {
                AppAssetLibraryPlacementsGetInstanceFieldsAppStoreVersionExperimentTreatmentLocalization.AppPreviewSets => "appPreviewSets",
                AppAssetLibraryPlacementsGetInstanceFieldsAppStoreVersionExperimentTreatmentLocalization.AppScreenshotSets => "appScreenshotSets",
                AppAssetLibraryPlacementsGetInstanceFieldsAppStoreVersionExperimentTreatmentLocalization.AppStoreVersionExperimentTreatment => "appStoreVersionExperimentTreatment",
                AppAssetLibraryPlacementsGetInstanceFieldsAppStoreVersionExperimentTreatmentLocalization.Locale => "locale",
                AppAssetLibraryPlacementsGetInstanceFieldsAppStoreVersionExperimentTreatmentLocalization.Placements => "placements",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryPlacementsGetInstanceFieldsAppStoreVersionExperimentTreatmentLocalization? ToEnum(string value)
        {
            return value switch
            {
                "appPreviewSets" => AppAssetLibraryPlacementsGetInstanceFieldsAppStoreVersionExperimentTreatmentLocalization.AppPreviewSets,
                "appScreenshotSets" => AppAssetLibraryPlacementsGetInstanceFieldsAppStoreVersionExperimentTreatmentLocalization.AppScreenshotSets,
                "appStoreVersionExperimentTreatment" => AppAssetLibraryPlacementsGetInstanceFieldsAppStoreVersionExperimentTreatmentLocalization.AppStoreVersionExperimentTreatment,
                "locale" => AppAssetLibraryPlacementsGetInstanceFieldsAppStoreVersionExperimentTreatmentLocalization.Locale,
                "placements" => AppAssetLibraryPlacementsGetInstanceFieldsAppStoreVersionExperimentTreatmentLocalization.Placements,
                _ => null,
            };
        }
    }
}