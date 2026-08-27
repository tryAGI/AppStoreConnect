
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionExperimentTreatmentLocalizationAppScreenshotSetsLinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        AppScreenshotSets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionExperimentTreatmentLocalizationAppScreenshotSetsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionExperimentTreatmentLocalizationAppScreenshotSetsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                AppStoreVersionExperimentTreatmentLocalizationAppScreenshotSetsLinkagesResponseDataItemType.AppScreenshotSets => "appScreenshotSets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionExperimentTreatmentLocalizationAppScreenshotSetsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appScreenshotSets" => AppStoreVersionExperimentTreatmentLocalizationAppScreenshotSetsLinkagesResponseDataItemType.AppScreenshotSets,
                _ => null,
            };
        }
    }
}