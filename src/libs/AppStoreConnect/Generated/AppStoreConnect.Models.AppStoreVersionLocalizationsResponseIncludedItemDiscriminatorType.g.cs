
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionLocalizationsResponseIncludedItemDiscriminatorType
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
    public static class AppStoreVersionLocalizationsResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionLocalizationsResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                AppStoreVersionLocalizationsResponseIncludedItemDiscriminatorType.AppKeywords => "appKeywords",
                AppStoreVersionLocalizationsResponseIncludedItemDiscriminatorType.AppPreviewSets => "appPreviewSets",
                AppStoreVersionLocalizationsResponseIncludedItemDiscriminatorType.AppScreenshotSets => "appScreenshotSets",
                AppStoreVersionLocalizationsResponseIncludedItemDiscriminatorType.AppStoreVersions => "appStoreVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionLocalizationsResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "appKeywords" => AppStoreVersionLocalizationsResponseIncludedItemDiscriminatorType.AppKeywords,
                "appPreviewSets" => AppStoreVersionLocalizationsResponseIncludedItemDiscriminatorType.AppPreviewSets,
                "appScreenshotSets" => AppStoreVersionLocalizationsResponseIncludedItemDiscriminatorType.AppScreenshotSets,
                "appStoreVersions" => AppStoreVersionLocalizationsResponseIncludedItemDiscriminatorType.AppStoreVersions,
                _ => null,
            };
        }
    }
}