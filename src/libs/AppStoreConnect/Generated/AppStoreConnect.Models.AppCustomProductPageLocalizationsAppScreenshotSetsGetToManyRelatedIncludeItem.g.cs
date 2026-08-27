
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedIncludeItem
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
    public static class AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedIncludeItem.AppCustomProductPageLocalization => "appCustomProductPageLocalization",
                AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedIncludeItem.AppScreenshots => "appScreenshots",
                AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedIncludeItem.AppStoreVersionExperimentTreatmentLocalization => "appStoreVersionExperimentTreatmentLocalization",
                AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedIncludeItem.AppStoreVersionLocalization => "appStoreVersionLocalization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageLocalization" => AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedIncludeItem.AppCustomProductPageLocalization,
                "appScreenshots" => AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedIncludeItem.AppScreenshots,
                "appStoreVersionExperimentTreatmentLocalization" => AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedIncludeItem.AppStoreVersionExperimentTreatmentLocalization,
                "appStoreVersionLocalization" => AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedIncludeItem.AppStoreVersionLocalization,
                _ => null,
            };
        }
    }
}