
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppEventLocalizationsGetInstanceIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        AppEvent,
        /// <summary>
        ///
        /// </summary>
        AppEventScreenshots,
        /// <summary>
        ///
        /// </summary>
        AppEventVideoClips,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppEventLocalizationsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventLocalizationsGetInstanceIncludeItem value)
        {
            return value switch
            {
                AppEventLocalizationsGetInstanceIncludeItem.AppEvent => "appEvent",
                AppEventLocalizationsGetInstanceIncludeItem.AppEventScreenshots => "appEventScreenshots",
                AppEventLocalizationsGetInstanceIncludeItem.AppEventVideoClips => "appEventVideoClips",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventLocalizationsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "appEvent" => AppEventLocalizationsGetInstanceIncludeItem.AppEvent,
                "appEventScreenshots" => AppEventLocalizationsGetInstanceIncludeItem.AppEventScreenshots,
                "appEventVideoClips" => AppEventLocalizationsGetInstanceIncludeItem.AppEventVideoClips,
                _ => null,
            };
        }
    }
}