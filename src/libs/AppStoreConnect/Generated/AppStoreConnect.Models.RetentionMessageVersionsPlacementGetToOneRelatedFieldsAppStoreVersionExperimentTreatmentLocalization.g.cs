
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppStoreVersionExperimentTreatmentLocalization
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
    public static class RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppStoreVersionExperimentTreatmentLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppStoreVersionExperimentTreatmentLocalization value)
        {
            return value switch
            {
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppStoreVersionExperimentTreatmentLocalization.AppPreviewSets => "appPreviewSets",
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppStoreVersionExperimentTreatmentLocalization.AppScreenshotSets => "appScreenshotSets",
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppStoreVersionExperimentTreatmentLocalization.AppStoreVersionExperimentTreatment => "appStoreVersionExperimentTreatment",
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppStoreVersionExperimentTreatmentLocalization.Locale => "locale",
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppStoreVersionExperimentTreatmentLocalization.Placements => "placements",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppStoreVersionExperimentTreatmentLocalization? ToEnum(string value)
        {
            return value switch
            {
                "appPreviewSets" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppStoreVersionExperimentTreatmentLocalization.AppPreviewSets,
                "appScreenshotSets" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppStoreVersionExperimentTreatmentLocalization.AppScreenshotSets,
                "appStoreVersionExperimentTreatment" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppStoreVersionExperimentTreatmentLocalization.AppStoreVersionExperimentTreatment,
                "locale" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppStoreVersionExperimentTreatmentLocalization.Locale,
                "placements" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppStoreVersionExperimentTreatmentLocalization.Placements,
                _ => null,
            };
        }
    }
}