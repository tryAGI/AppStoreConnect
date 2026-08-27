
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionLocalizationResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        AppKeywords,
        /// <summary>
        /// 
        /// </summary>
        AppPreviewSets,
        /// <summary>
        /// 
        /// </summary>
        AppScreenshotSets,
        /// <summary>
        /// 
        /// </summary>
        AppStoreVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionLocalizationResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionLocalizationResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                AppStoreVersionLocalizationResponseIncludedItemDiscriminatorType.AppKeywords => "appKeywords",
                AppStoreVersionLocalizationResponseIncludedItemDiscriminatorType.AppPreviewSets => "appPreviewSets",
                AppStoreVersionLocalizationResponseIncludedItemDiscriminatorType.AppScreenshotSets => "appScreenshotSets",
                AppStoreVersionLocalizationResponseIncludedItemDiscriminatorType.AppStoreVersions => "appStoreVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionLocalizationResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "appKeywords" => AppStoreVersionLocalizationResponseIncludedItemDiscriminatorType.AppKeywords,
                "appPreviewSets" => AppStoreVersionLocalizationResponseIncludedItemDiscriminatorType.AppPreviewSets,
                "appScreenshotSets" => AppStoreVersionLocalizationResponseIncludedItemDiscriminatorType.AppScreenshotSets,
                "appStoreVersions" => AppStoreVersionLocalizationResponseIncludedItemDiscriminatorType.AppStoreVersions,
                _ => null,
            };
        }
    }
}