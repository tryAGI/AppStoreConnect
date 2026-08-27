
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreviewSet
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
    public static class AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreviewSetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreviewSet value)
        {
            return value switch
            {
                AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreviewSet.AppCustomProductPageLocalization => "appCustomProductPageLocalization",
                AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreviewSet.AppPreviews => "appPreviews",
                AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreviewSet.AppStoreVersionExperimentTreatmentLocalization => "appStoreVersionExperimentTreatmentLocalization",
                AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreviewSet.AppStoreVersionLocalization => "appStoreVersionLocalization",
                AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreviewSet.PreviewType => "previewType",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreviewSet? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageLocalization" => AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreviewSet.AppCustomProductPageLocalization,
                "appPreviews" => AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreviewSet.AppPreviews,
                "appStoreVersionExperimentTreatmentLocalization" => AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreviewSet.AppStoreVersionExperimentTreatmentLocalization,
                "appStoreVersionLocalization" => AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreviewSet.AppStoreVersionLocalization,
                "previewType" => AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppPreviewSet.PreviewType,
                _ => null,
            };
        }
    }
}