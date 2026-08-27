
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppScreenshotSetRelationshipsAppScreenshotsDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        AppScreenshots,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppScreenshotSetRelationshipsAppScreenshotsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppScreenshotSetRelationshipsAppScreenshotsDataItemType value)
        {
            return value switch
            {
                AppScreenshotSetRelationshipsAppScreenshotsDataItemType.AppScreenshots => "appScreenshots",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppScreenshotSetRelationshipsAppScreenshotsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appScreenshots" => AppScreenshotSetRelationshipsAppScreenshotsDataItemType.AppScreenshots,
                _ => null,
            };
        }
    }
}