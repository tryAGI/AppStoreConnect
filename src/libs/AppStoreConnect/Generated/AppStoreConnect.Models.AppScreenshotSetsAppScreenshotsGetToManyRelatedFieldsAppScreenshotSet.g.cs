
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppScreenshotSetsAppScreenshotsGetToManyRelatedFieldsAppScreenshotSet
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
    public static class AppScreenshotSetsAppScreenshotsGetToManyRelatedFieldsAppScreenshotSetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppScreenshotSetsAppScreenshotsGetToManyRelatedFieldsAppScreenshotSet value)
        {
            return value switch
            {
                AppScreenshotSetsAppScreenshotsGetToManyRelatedFieldsAppScreenshotSet.AppCustomProductPageLocalization => "appCustomProductPageLocalization",
                AppScreenshotSetsAppScreenshotsGetToManyRelatedFieldsAppScreenshotSet.AppScreenshots => "appScreenshots",
                AppScreenshotSetsAppScreenshotsGetToManyRelatedFieldsAppScreenshotSet.AppStoreVersionExperimentTreatmentLocalization => "appStoreVersionExperimentTreatmentLocalization",
                AppScreenshotSetsAppScreenshotsGetToManyRelatedFieldsAppScreenshotSet.AppStoreVersionLocalization => "appStoreVersionLocalization",
                AppScreenshotSetsAppScreenshotsGetToManyRelatedFieldsAppScreenshotSet.ScreenshotDisplayType => "screenshotDisplayType",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppScreenshotSetsAppScreenshotsGetToManyRelatedFieldsAppScreenshotSet? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageLocalization" => AppScreenshotSetsAppScreenshotsGetToManyRelatedFieldsAppScreenshotSet.AppCustomProductPageLocalization,
                "appScreenshots" => AppScreenshotSetsAppScreenshotsGetToManyRelatedFieldsAppScreenshotSet.AppScreenshots,
                "appStoreVersionExperimentTreatmentLocalization" => AppScreenshotSetsAppScreenshotsGetToManyRelatedFieldsAppScreenshotSet.AppStoreVersionExperimentTreatmentLocalization,
                "appStoreVersionLocalization" => AppScreenshotSetsAppScreenshotsGetToManyRelatedFieldsAppScreenshotSet.AppStoreVersionLocalization,
                "screenshotDisplayType" => AppScreenshotSetsAppScreenshotsGetToManyRelatedFieldsAppScreenshotSet.ScreenshotDisplayType,
                _ => null,
            };
        }
    }
}