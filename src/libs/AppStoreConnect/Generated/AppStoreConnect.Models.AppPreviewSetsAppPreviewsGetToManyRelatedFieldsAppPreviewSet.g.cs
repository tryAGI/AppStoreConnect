
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreviewSet
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
    public static class AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreviewSetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreviewSet value)
        {
            return value switch
            {
                AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreviewSet.AppCustomProductPageLocalization => "appCustomProductPageLocalization",
                AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreviewSet.AppPreviews => "appPreviews",
                AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreviewSet.AppStoreVersionExperimentTreatmentLocalization => "appStoreVersionExperimentTreatmentLocalization",
                AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreviewSet.AppStoreVersionLocalization => "appStoreVersionLocalization",
                AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreviewSet.PreviewType => "previewType",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreviewSet? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageLocalization" => AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreviewSet.AppCustomProductPageLocalization,
                "appPreviews" => AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreviewSet.AppPreviews,
                "appStoreVersionExperimentTreatmentLocalization" => AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreviewSet.AppStoreVersionExperimentTreatmentLocalization,
                "appStoreVersionLocalization" => AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreviewSet.AppStoreVersionLocalization,
                "previewType" => AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreviewSet.PreviewType,
                _ => null,
            };
        }
    }
}