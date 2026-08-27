
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppPreviewSetsGetInstanceIncludeItem
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppPreviewSetsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPreviewSetsGetInstanceIncludeItem value)
        {
            return value switch
            {
                AppPreviewSetsGetInstanceIncludeItem.AppCustomProductPageLocalization => "appCustomProductPageLocalization",
                AppPreviewSetsGetInstanceIncludeItem.AppPreviews => "appPreviews",
                AppPreviewSetsGetInstanceIncludeItem.AppStoreVersionExperimentTreatmentLocalization => "appStoreVersionExperimentTreatmentLocalization",
                AppPreviewSetsGetInstanceIncludeItem.AppStoreVersionLocalization => "appStoreVersionLocalization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPreviewSetsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageLocalization" => AppPreviewSetsGetInstanceIncludeItem.AppCustomProductPageLocalization,
                "appPreviews" => AppPreviewSetsGetInstanceIncludeItem.AppPreviews,
                "appStoreVersionExperimentTreatmentLocalization" => AppPreviewSetsGetInstanceIncludeItem.AppStoreVersionExperimentTreatmentLocalization,
                "appStoreVersionLocalization" => AppPreviewSetsGetInstanceIncludeItem.AppStoreVersionLocalization,
                _ => null,
            };
        }
    }
}