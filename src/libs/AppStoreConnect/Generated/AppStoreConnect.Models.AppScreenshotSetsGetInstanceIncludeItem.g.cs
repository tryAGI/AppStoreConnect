
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppScreenshotSetsGetInstanceIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        AppCustomProductPageLocalization,
        /// <summary>
        ///
        /// </summary>
        AppScreenshots,
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
    public static class AppScreenshotSetsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppScreenshotSetsGetInstanceIncludeItem value)
        {
            return value switch
            {
                AppScreenshotSetsGetInstanceIncludeItem.AppCustomProductPageLocalization => "appCustomProductPageLocalization",
                AppScreenshotSetsGetInstanceIncludeItem.AppScreenshots => "appScreenshots",
                AppScreenshotSetsGetInstanceIncludeItem.AppStoreVersionExperimentTreatmentLocalization => "appStoreVersionExperimentTreatmentLocalization",
                AppScreenshotSetsGetInstanceIncludeItem.AppStoreVersionLocalization => "appStoreVersionLocalization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppScreenshotSetsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageLocalization" => AppScreenshotSetsGetInstanceIncludeItem.AppCustomProductPageLocalization,
                "appScreenshots" => AppScreenshotSetsGetInstanceIncludeItem.AppScreenshots,
                "appStoreVersionExperimentTreatmentLocalization" => AppScreenshotSetsGetInstanceIncludeItem.AppStoreVersionExperimentTreatmentLocalization,
                "appStoreVersionLocalization" => AppScreenshotSetsGetInstanceIncludeItem.AppStoreVersionLocalization,
                _ => null,
            };
        }
    }
}