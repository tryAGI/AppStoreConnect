
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedFieldsAppPreviewSet
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
    public static class AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedFieldsAppPreviewSetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedFieldsAppPreviewSet value)
        {
            return value switch
            {
                AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedFieldsAppPreviewSet.AppCustomProductPageLocalization => "appCustomProductPageLocalization",
                AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedFieldsAppPreviewSet.AppPreviews => "appPreviews",
                AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedFieldsAppPreviewSet.AppStoreVersionExperimentTreatmentLocalization => "appStoreVersionExperimentTreatmentLocalization",
                AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedFieldsAppPreviewSet.AppStoreVersionLocalization => "appStoreVersionLocalization",
                AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedFieldsAppPreviewSet.PreviewType => "previewType",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedFieldsAppPreviewSet? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageLocalization" => AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedFieldsAppPreviewSet.AppCustomProductPageLocalization,
                "appPreviews" => AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedFieldsAppPreviewSet.AppPreviews,
                "appStoreVersionExperimentTreatmentLocalization" => AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedFieldsAppPreviewSet.AppStoreVersionExperimentTreatmentLocalization,
                "appStoreVersionLocalization" => AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedFieldsAppPreviewSet.AppStoreVersionLocalization,
                "previewType" => AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedFieldsAppPreviewSet.PreviewType,
                _ => null,
            };
        }
    }
}