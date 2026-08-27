
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionLocalizationsGetInstanceFieldsAppScreenshotSet
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
    public static class AppStoreVersionLocalizationsGetInstanceFieldsAppScreenshotSetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionLocalizationsGetInstanceFieldsAppScreenshotSet value)
        {
            return value switch
            {
                AppStoreVersionLocalizationsGetInstanceFieldsAppScreenshotSet.AppCustomProductPageLocalization => "appCustomProductPageLocalization",
                AppStoreVersionLocalizationsGetInstanceFieldsAppScreenshotSet.AppScreenshots => "appScreenshots",
                AppStoreVersionLocalizationsGetInstanceFieldsAppScreenshotSet.AppStoreVersionExperimentTreatmentLocalization => "appStoreVersionExperimentTreatmentLocalization",
                AppStoreVersionLocalizationsGetInstanceFieldsAppScreenshotSet.AppStoreVersionLocalization => "appStoreVersionLocalization",
                AppStoreVersionLocalizationsGetInstanceFieldsAppScreenshotSet.ScreenshotDisplayType => "screenshotDisplayType",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionLocalizationsGetInstanceFieldsAppScreenshotSet? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageLocalization" => AppStoreVersionLocalizationsGetInstanceFieldsAppScreenshotSet.AppCustomProductPageLocalization,
                "appScreenshots" => AppStoreVersionLocalizationsGetInstanceFieldsAppScreenshotSet.AppScreenshots,
                "appStoreVersionExperimentTreatmentLocalization" => AppStoreVersionLocalizationsGetInstanceFieldsAppScreenshotSet.AppStoreVersionExperimentTreatmentLocalization,
                "appStoreVersionLocalization" => AppStoreVersionLocalizationsGetInstanceFieldsAppScreenshotSet.AppStoreVersionLocalization,
                "screenshotDisplayType" => AppStoreVersionLocalizationsGetInstanceFieldsAppScreenshotSet.ScreenshotDisplayType,
                _ => null,
            };
        }
    }
}