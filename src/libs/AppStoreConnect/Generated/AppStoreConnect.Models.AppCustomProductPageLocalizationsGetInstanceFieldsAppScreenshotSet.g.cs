
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppCustomProductPageLocalizationsGetInstanceFieldsAppScreenshotSet
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
    public static class AppCustomProductPageLocalizationsGetInstanceFieldsAppScreenshotSetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPageLocalizationsGetInstanceFieldsAppScreenshotSet value)
        {
            return value switch
            {
                AppCustomProductPageLocalizationsGetInstanceFieldsAppScreenshotSet.AppCustomProductPageLocalization => "appCustomProductPageLocalization",
                AppCustomProductPageLocalizationsGetInstanceFieldsAppScreenshotSet.AppScreenshots => "appScreenshots",
                AppCustomProductPageLocalizationsGetInstanceFieldsAppScreenshotSet.AppStoreVersionExperimentTreatmentLocalization => "appStoreVersionExperimentTreatmentLocalization",
                AppCustomProductPageLocalizationsGetInstanceFieldsAppScreenshotSet.AppStoreVersionLocalization => "appStoreVersionLocalization",
                AppCustomProductPageLocalizationsGetInstanceFieldsAppScreenshotSet.ScreenshotDisplayType => "screenshotDisplayType",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPageLocalizationsGetInstanceFieldsAppScreenshotSet? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageLocalization" => AppCustomProductPageLocalizationsGetInstanceFieldsAppScreenshotSet.AppCustomProductPageLocalization,
                "appScreenshots" => AppCustomProductPageLocalizationsGetInstanceFieldsAppScreenshotSet.AppScreenshots,
                "appStoreVersionExperimentTreatmentLocalization" => AppCustomProductPageLocalizationsGetInstanceFieldsAppScreenshotSet.AppStoreVersionExperimentTreatmentLocalization,
                "appStoreVersionLocalization" => AppCustomProductPageLocalizationsGetInstanceFieldsAppScreenshotSet.AppStoreVersionLocalization,
                "screenshotDisplayType" => AppCustomProductPageLocalizationsGetInstanceFieldsAppScreenshotSet.ScreenshotDisplayType,
                _ => null,
            };
        }
    }
}