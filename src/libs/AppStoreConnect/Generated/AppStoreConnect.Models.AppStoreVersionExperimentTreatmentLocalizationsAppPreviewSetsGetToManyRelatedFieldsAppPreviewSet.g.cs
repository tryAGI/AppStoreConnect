
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionExperimentTreatmentLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreviewSet
    {
        /// <summary>
        ///
        /// </summary>
        AppCustomProductPageLocalization,
        /// <summary>
        ///
        /// </summary>
        AppPreviews,
        /// <summary>
        ///
        /// </summary>
        AppStoreVersionExperimentTreatmentLocalization,
        /// <summary>
        ///
        /// </summary>
        AppStoreVersionLocalization,
        /// <summary>
        ///
        /// </summary>
        PreviewType,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionExperimentTreatmentLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreviewSetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionExperimentTreatmentLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreviewSet value)
        {
            return value switch
            {
                AppStoreVersionExperimentTreatmentLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreviewSet.AppCustomProductPageLocalization => "appCustomProductPageLocalization",
                AppStoreVersionExperimentTreatmentLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreviewSet.AppPreviews => "appPreviews",
                AppStoreVersionExperimentTreatmentLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreviewSet.AppStoreVersionExperimentTreatmentLocalization => "appStoreVersionExperimentTreatmentLocalization",
                AppStoreVersionExperimentTreatmentLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreviewSet.AppStoreVersionLocalization => "appStoreVersionLocalization",
                AppStoreVersionExperimentTreatmentLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreviewSet.PreviewType => "previewType",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionExperimentTreatmentLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreviewSet? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageLocalization" => AppStoreVersionExperimentTreatmentLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreviewSet.AppCustomProductPageLocalization,
                "appPreviews" => AppStoreVersionExperimentTreatmentLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreviewSet.AppPreviews,
                "appStoreVersionExperimentTreatmentLocalization" => AppStoreVersionExperimentTreatmentLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreviewSet.AppStoreVersionExperimentTreatmentLocalization,
                "appStoreVersionLocalization" => AppStoreVersionExperimentTreatmentLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreviewSet.AppStoreVersionLocalization,
                "previewType" => AppStoreVersionExperimentTreatmentLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreviewSet.PreviewType,
                _ => null,
            };
        }
    }
}