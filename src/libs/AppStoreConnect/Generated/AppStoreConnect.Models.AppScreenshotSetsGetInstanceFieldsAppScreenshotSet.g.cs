
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppScreenshotSetsGetInstanceFieldsAppScreenshotSet
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
        /// <summary>
        ///
        /// </summary>
        ScreenshotDisplayType,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppScreenshotSetsGetInstanceFieldsAppScreenshotSetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppScreenshotSetsGetInstanceFieldsAppScreenshotSet value)
        {
            return value switch
            {
                AppScreenshotSetsGetInstanceFieldsAppScreenshotSet.AppCustomProductPageLocalization => "appCustomProductPageLocalization",
                AppScreenshotSetsGetInstanceFieldsAppScreenshotSet.AppScreenshots => "appScreenshots",
                AppScreenshotSetsGetInstanceFieldsAppScreenshotSet.AppStoreVersionExperimentTreatmentLocalization => "appStoreVersionExperimentTreatmentLocalization",
                AppScreenshotSetsGetInstanceFieldsAppScreenshotSet.AppStoreVersionLocalization => "appStoreVersionLocalization",
                AppScreenshotSetsGetInstanceFieldsAppScreenshotSet.ScreenshotDisplayType => "screenshotDisplayType",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppScreenshotSetsGetInstanceFieldsAppScreenshotSet? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageLocalization" => AppScreenshotSetsGetInstanceFieldsAppScreenshotSet.AppCustomProductPageLocalization,
                "appScreenshots" => AppScreenshotSetsGetInstanceFieldsAppScreenshotSet.AppScreenshots,
                "appStoreVersionExperimentTreatmentLocalization" => AppScreenshotSetsGetInstanceFieldsAppScreenshotSet.AppStoreVersionExperimentTreatmentLocalization,
                "appStoreVersionLocalization" => AppScreenshotSetsGetInstanceFieldsAppScreenshotSet.AppStoreVersionLocalization,
                "screenshotDisplayType" => AppScreenshotSetsGetInstanceFieldsAppScreenshotSet.ScreenshotDisplayType,
                _ => null,
            };
        }
    }
}