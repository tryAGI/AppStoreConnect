
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppClipsGetInstanceIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        App,
        /// <summary>
        ///
        /// </summary>
        AppClipDefaultExperiences,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipsGetInstanceIncludeItem value)
        {
            return value switch
            {
                AppClipsGetInstanceIncludeItem.App => "app",
                AppClipsGetInstanceIncludeItem.AppClipDefaultExperiences => "appClipDefaultExperiences",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppClipsGetInstanceIncludeItem.App,
                "appClipDefaultExperiences" => AppClipsGetInstanceIncludeItem.AppClipDefaultExperiences,
                _ => null,
            };
        }
    }
}