
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppScreenshotsGetInstanceFieldsAppScreenshotSet
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
    public static class AppScreenshotsGetInstanceFieldsAppScreenshotSetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppScreenshotsGetInstanceFieldsAppScreenshotSet value)
        {
            return value switch
            {
                AppScreenshotsGetInstanceFieldsAppScreenshotSet.AppCustomProductPageLocalization => "appCustomProductPageLocalization",
                AppScreenshotsGetInstanceFieldsAppScreenshotSet.AppScreenshots => "appScreenshots",
                AppScreenshotsGetInstanceFieldsAppScreenshotSet.AppStoreVersionExperimentTreatmentLocalization => "appStoreVersionExperimentTreatmentLocalization",
                AppScreenshotsGetInstanceFieldsAppScreenshotSet.AppStoreVersionLocalization => "appStoreVersionLocalization",
                AppScreenshotsGetInstanceFieldsAppScreenshotSet.ScreenshotDisplayType => "screenshotDisplayType",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppScreenshotsGetInstanceFieldsAppScreenshotSet? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageLocalization" => AppScreenshotsGetInstanceFieldsAppScreenshotSet.AppCustomProductPageLocalization,
                "appScreenshots" => AppScreenshotsGetInstanceFieldsAppScreenshotSet.AppScreenshots,
                "appStoreVersionExperimentTreatmentLocalization" => AppScreenshotsGetInstanceFieldsAppScreenshotSet.AppStoreVersionExperimentTreatmentLocalization,
                "appStoreVersionLocalization" => AppScreenshotsGetInstanceFieldsAppScreenshotSet.AppStoreVersionLocalization,
                "screenshotDisplayType" => AppScreenshotsGetInstanceFieldsAppScreenshotSet.ScreenshotDisplayType,
                _ => null,
            };
        }
    }
}