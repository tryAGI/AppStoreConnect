
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedFieldsAppScreenshotSet
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
    public static class AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedFieldsAppScreenshotSetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedFieldsAppScreenshotSet value)
        {
            return value switch
            {
                AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedFieldsAppScreenshotSet.AppCustomProductPageLocalization => "appCustomProductPageLocalization",
                AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedFieldsAppScreenshotSet.AppScreenshots => "appScreenshots",
                AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedFieldsAppScreenshotSet.AppStoreVersionExperimentTreatmentLocalization => "appStoreVersionExperimentTreatmentLocalization",
                AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedFieldsAppScreenshotSet.AppStoreVersionLocalization => "appStoreVersionLocalization",
                AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedFieldsAppScreenshotSet.ScreenshotDisplayType => "screenshotDisplayType",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedFieldsAppScreenshotSet? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageLocalization" => AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedFieldsAppScreenshotSet.AppCustomProductPageLocalization,
                "appScreenshots" => AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedFieldsAppScreenshotSet.AppScreenshots,
                "appStoreVersionExperimentTreatmentLocalization" => AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedFieldsAppScreenshotSet.AppStoreVersionExperimentTreatmentLocalization,
                "appStoreVersionLocalization" => AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedFieldsAppScreenshotSet.AppStoreVersionLocalization,
                "screenshotDisplayType" => AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedFieldsAppScreenshotSet.ScreenshotDisplayType,
                _ => null,
            };
        }
    }
}