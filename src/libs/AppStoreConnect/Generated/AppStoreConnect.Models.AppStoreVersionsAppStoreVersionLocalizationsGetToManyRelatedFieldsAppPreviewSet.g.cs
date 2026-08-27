
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppPreviewSet
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
    public static class AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppPreviewSetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppPreviewSet value)
        {
            return value switch
            {
                AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppPreviewSet.AppCustomProductPageLocalization => "appCustomProductPageLocalization",
                AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppPreviewSet.AppPreviews => "appPreviews",
                AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppPreviewSet.AppStoreVersionExperimentTreatmentLocalization => "appStoreVersionExperimentTreatmentLocalization",
                AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppPreviewSet.AppStoreVersionLocalization => "appStoreVersionLocalization",
                AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppPreviewSet.PreviewType => "previewType",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppPreviewSet? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageLocalization" => AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppPreviewSet.AppCustomProductPageLocalization,
                "appPreviews" => AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppPreviewSet.AppPreviews,
                "appStoreVersionExperimentTreatmentLocalization" => AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppPreviewSet.AppStoreVersionExperimentTreatmentLocalization,
                "appStoreVersionLocalization" => AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppPreviewSet.AppStoreVersionLocalization,
                "previewType" => AppStoreVersionsAppStoreVersionLocalizationsGetToManyRelatedFieldsAppPreviewSet.PreviewType,
                _ => null,
            };
        }
    }
}