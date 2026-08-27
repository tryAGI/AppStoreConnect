
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionExperimentTreatmentLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionExperimentTreatmentLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionExperimentTreatmentLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization value)
        {
            return value switch
            {
                AppStoreVersionExperimentTreatmentLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization.AppPreviewSets => "appPreviewSets",
                AppStoreVersionExperimentTreatmentLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization.AppScreenshotSets => "appScreenshotSets",
                AppStoreVersionExperimentTreatmentLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization.AppStoreVersionExperimentTreatment => "appStoreVersionExperimentTreatment",
                AppStoreVersionExperimentTreatmentLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization.Locale => "locale",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionExperimentTreatmentLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization? ToEnum(string value)
        {
            return value switch
            {
                "appPreviewSets" => AppStoreVersionExperimentTreatmentLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization.AppPreviewSets,
                "appScreenshotSets" => AppStoreVersionExperimentTreatmentLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization.AppScreenshotSets,
                "appStoreVersionExperimentTreatment" => AppStoreVersionExperimentTreatmentLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization.AppStoreVersionExperimentTreatment,
                "locale" => AppStoreVersionExperimentTreatmentLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentLocalization.Locale,
                _ => null,
            };
        }
    }
}