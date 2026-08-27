
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppClipHeaderImagesGetInstanceIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        AppClipDefaultExperienceLocalization,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipHeaderImagesGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipHeaderImagesGetInstanceIncludeItem value)
        {
            return value switch
            {
                AppClipHeaderImagesGetInstanceIncludeItem.AppClipDefaultExperienceLocalization => "appClipDefaultExperienceLocalization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipHeaderImagesGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "appClipDefaultExperienceLocalization" => AppClipHeaderImagesGetInstanceIncludeItem.AppClipDefaultExperienceLocalization,
                _ => null,
            };
        }
    }
}