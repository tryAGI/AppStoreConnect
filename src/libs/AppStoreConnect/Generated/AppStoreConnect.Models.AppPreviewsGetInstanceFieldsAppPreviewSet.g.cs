
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppPreviewsGetInstanceFieldsAppPreviewSet
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
    public static class AppPreviewsGetInstanceFieldsAppPreviewSetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPreviewsGetInstanceFieldsAppPreviewSet value)
        {
            return value switch
            {
                AppPreviewsGetInstanceFieldsAppPreviewSet.AppCustomProductPageLocalization => "appCustomProductPageLocalization",
                AppPreviewsGetInstanceFieldsAppPreviewSet.AppPreviews => "appPreviews",
                AppPreviewsGetInstanceFieldsAppPreviewSet.AppStoreVersionExperimentTreatmentLocalization => "appStoreVersionExperimentTreatmentLocalization",
                AppPreviewsGetInstanceFieldsAppPreviewSet.AppStoreVersionLocalization => "appStoreVersionLocalization",
                AppPreviewsGetInstanceFieldsAppPreviewSet.PreviewType => "previewType",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPreviewsGetInstanceFieldsAppPreviewSet? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageLocalization" => AppPreviewsGetInstanceFieldsAppPreviewSet.AppCustomProductPageLocalization,
                "appPreviews" => AppPreviewsGetInstanceFieldsAppPreviewSet.AppPreviews,
                "appStoreVersionExperimentTreatmentLocalization" => AppPreviewsGetInstanceFieldsAppPreviewSet.AppStoreVersionExperimentTreatmentLocalization,
                "appStoreVersionLocalization" => AppPreviewsGetInstanceFieldsAppPreviewSet.AppStoreVersionLocalization,
                "previewType" => AppPreviewsGetInstanceFieldsAppPreviewSet.PreviewType,
                _ => null,
            };
        }
    }
}