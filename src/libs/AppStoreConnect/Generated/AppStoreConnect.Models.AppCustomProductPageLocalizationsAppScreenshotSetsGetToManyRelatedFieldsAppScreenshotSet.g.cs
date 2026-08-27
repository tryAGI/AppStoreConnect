
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshotSet
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
    public static class AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshotSetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshotSet value)
        {
            return value switch
            {
                AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshotSet.AppCustomProductPageLocalization => "appCustomProductPageLocalization",
                AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshotSet.AppScreenshots => "appScreenshots",
                AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshotSet.AppStoreVersionExperimentTreatmentLocalization => "appStoreVersionExperimentTreatmentLocalization",
                AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshotSet.AppStoreVersionLocalization => "appStoreVersionLocalization",
                AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshotSet.ScreenshotDisplayType => "screenshotDisplayType",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshotSet? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageLocalization" => AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshotSet.AppCustomProductPageLocalization,
                "appScreenshots" => AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshotSet.AppScreenshots,
                "appStoreVersionExperimentTreatmentLocalization" => AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshotSet.AppStoreVersionExperimentTreatmentLocalization,
                "appStoreVersionLocalization" => AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshotSet.AppStoreVersionLocalization,
                "screenshotDisplayType" => AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshotSet.ScreenshotDisplayType,
                _ => null,
            };
        }
    }
}