
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization
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
    public static class AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization value)
        {
            return value switch
            {
                AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization.AppPreviewSets => "appPreviewSets",
                AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization.AppScreenshotSets => "appScreenshotSets",
                AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization.AppStoreVersionExperimentTreatment => "appStoreVersionExperimentTreatment",
                AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization.Locale => "locale",
                AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization.Placements => "placements",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization? ToEnum(string value)
        {
            return value switch
            {
                "appPreviewSets" => AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization.AppPreviewSets,
                "appScreenshotSets" => AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization.AppScreenshotSets,
                "appStoreVersionExperimentTreatment" => AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization.AppStoreVersionExperimentTreatment,
                "locale" => AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization.Locale,
                "placements" => AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization.Placements,
                _ => null,
            };
        }
    }
}