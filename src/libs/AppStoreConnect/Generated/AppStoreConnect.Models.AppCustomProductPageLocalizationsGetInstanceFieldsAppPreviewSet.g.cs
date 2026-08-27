
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppCustomProductPageLocalizationsGetInstanceFieldsAppPreviewSet
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
    public static class AppCustomProductPageLocalizationsGetInstanceFieldsAppPreviewSetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPageLocalizationsGetInstanceFieldsAppPreviewSet value)
        {
            return value switch
            {
                AppCustomProductPageLocalizationsGetInstanceFieldsAppPreviewSet.AppCustomProductPageLocalization => "appCustomProductPageLocalization",
                AppCustomProductPageLocalizationsGetInstanceFieldsAppPreviewSet.AppPreviews => "appPreviews",
                AppCustomProductPageLocalizationsGetInstanceFieldsAppPreviewSet.AppStoreVersionExperimentTreatmentLocalization => "appStoreVersionExperimentTreatmentLocalization",
                AppCustomProductPageLocalizationsGetInstanceFieldsAppPreviewSet.AppStoreVersionLocalization => "appStoreVersionLocalization",
                AppCustomProductPageLocalizationsGetInstanceFieldsAppPreviewSet.PreviewType => "previewType",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPageLocalizationsGetInstanceFieldsAppPreviewSet? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageLocalization" => AppCustomProductPageLocalizationsGetInstanceFieldsAppPreviewSet.AppCustomProductPageLocalization,
                "appPreviews" => AppCustomProductPageLocalizationsGetInstanceFieldsAppPreviewSet.AppPreviews,
                "appStoreVersionExperimentTreatmentLocalization" => AppCustomProductPageLocalizationsGetInstanceFieldsAppPreviewSet.AppStoreVersionExperimentTreatmentLocalization,
                "appStoreVersionLocalization" => AppCustomProductPageLocalizationsGetInstanceFieldsAppPreviewSet.AppStoreVersionLocalization,
                "previewType" => AppCustomProductPageLocalizationsGetInstanceFieldsAppPreviewSet.PreviewType,
                _ => null,
            };
        }
    }
}