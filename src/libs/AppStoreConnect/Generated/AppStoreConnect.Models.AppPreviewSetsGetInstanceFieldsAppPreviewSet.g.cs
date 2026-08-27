
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppPreviewSetsGetInstanceFieldsAppPreviewSet
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
    public static class AppPreviewSetsGetInstanceFieldsAppPreviewSetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPreviewSetsGetInstanceFieldsAppPreviewSet value)
        {
            return value switch
            {
                AppPreviewSetsGetInstanceFieldsAppPreviewSet.AppCustomProductPageLocalization => "appCustomProductPageLocalization",
                AppPreviewSetsGetInstanceFieldsAppPreviewSet.AppPreviews => "appPreviews",
                AppPreviewSetsGetInstanceFieldsAppPreviewSet.AppStoreVersionExperimentTreatmentLocalization => "appStoreVersionExperimentTreatmentLocalization",
                AppPreviewSetsGetInstanceFieldsAppPreviewSet.AppStoreVersionLocalization => "appStoreVersionLocalization",
                AppPreviewSetsGetInstanceFieldsAppPreviewSet.PreviewType => "previewType",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPreviewSetsGetInstanceFieldsAppPreviewSet? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageLocalization" => AppPreviewSetsGetInstanceFieldsAppPreviewSet.AppCustomProductPageLocalization,
                "appPreviews" => AppPreviewSetsGetInstanceFieldsAppPreviewSet.AppPreviews,
                "appStoreVersionExperimentTreatmentLocalization" => AppPreviewSetsGetInstanceFieldsAppPreviewSet.AppStoreVersionExperimentTreatmentLocalization,
                "appStoreVersionLocalization" => AppPreviewSetsGetInstanceFieldsAppPreviewSet.AppStoreVersionLocalization,
                "previewType" => AppPreviewSetsGetInstanceFieldsAppPreviewSet.PreviewType,
                _ => null,
            };
        }
    }
}