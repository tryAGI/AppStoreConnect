
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization
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
    public static class AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization value)
        {
            return value switch
            {
                AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization.AppPreviewSets => "appPreviewSets",
                AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization.AppScreenshotSets => "appScreenshotSets",
                AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization.AppStoreVersionExperimentTreatment => "appStoreVersionExperimentTreatment",
                AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization.Locale => "locale",
                AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization.Placements => "placements",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization? ToEnum(string value)
        {
            return value switch
            {
                "appPreviewSets" => AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization.AppPreviewSets,
                "appScreenshotSets" => AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization.AppScreenshotSets,
                "appStoreVersionExperimentTreatment" => AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization.AppStoreVersionExperimentTreatment,
                "locale" => AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization.Locale,
                "placements" => AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization.Placements,
                _ => null,
            };
        }
    }
}