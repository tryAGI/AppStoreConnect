
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppEventLocalizationRelationshipsAppEventScreenshotsDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        AppEventScreenshots,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppEventLocalizationRelationshipsAppEventScreenshotsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventLocalizationRelationshipsAppEventScreenshotsDataItemType value)
        {
            return value switch
            {
                AppEventLocalizationRelationshipsAppEventScreenshotsDataItemType.AppEventScreenshots => "appEventScreenshots",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventLocalizationRelationshipsAppEventScreenshotsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appEventScreenshots" => AppEventLocalizationRelationshipsAppEventScreenshotsDataItemType.AppEventScreenshots,
                _ => null,
            };
        }
    }
}