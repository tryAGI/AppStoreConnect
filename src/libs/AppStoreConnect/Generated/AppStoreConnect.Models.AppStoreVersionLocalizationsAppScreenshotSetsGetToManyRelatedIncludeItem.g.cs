
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedIncludeItem
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
    public static class AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedIncludeItem.AppCustomProductPageLocalization => "appCustomProductPageLocalization",
                AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedIncludeItem.AppScreenshots => "appScreenshots",
                AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedIncludeItem.AppStoreVersionExperimentTreatmentLocalization => "appStoreVersionExperimentTreatmentLocalization",
                AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedIncludeItem.AppStoreVersionLocalization => "appStoreVersionLocalization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageLocalization" => AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedIncludeItem.AppCustomProductPageLocalization,
                "appScreenshots" => AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedIncludeItem.AppScreenshots,
                "appStoreVersionExperimentTreatmentLocalization" => AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedIncludeItem.AppStoreVersionExperimentTreatmentLocalization,
                "appStoreVersionLocalization" => AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedIncludeItem.AppStoreVersionLocalization,
                _ => null,
            };
        }
    }
}