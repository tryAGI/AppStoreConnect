
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshotSet
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
    public static class AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshotSetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshotSet value)
        {
            return value switch
            {
                AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshotSet.AppCustomProductPageLocalization => "appCustomProductPageLocalization",
                AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshotSet.AppScreenshots => "appScreenshots",
                AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshotSet.AppStoreVersionExperimentTreatmentLocalization => "appStoreVersionExperimentTreatmentLocalization",
                AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshotSet.AppStoreVersionLocalization => "appStoreVersionLocalization",
                AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshotSet.ScreenshotDisplayType => "screenshotDisplayType",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshotSet? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageLocalization" => AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshotSet.AppCustomProductPageLocalization,
                "appScreenshots" => AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshotSet.AppScreenshots,
                "appStoreVersionExperimentTreatmentLocalization" => AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshotSet.AppStoreVersionExperimentTreatmentLocalization,
                "appStoreVersionLocalization" => AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshotSet.AppStoreVersionLocalization,
                "screenshotDisplayType" => AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppScreenshotSet.ScreenshotDisplayType,
                _ => null,
            };
        }
    }
}