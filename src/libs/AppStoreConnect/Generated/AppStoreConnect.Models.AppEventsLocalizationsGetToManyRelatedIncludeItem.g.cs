
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppEventsLocalizationsGetToManyRelatedIncludeItem
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
    public static class AppEventsLocalizationsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventsLocalizationsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                AppEventsLocalizationsGetToManyRelatedIncludeItem.AppEvent => "appEvent",
                AppEventsLocalizationsGetToManyRelatedIncludeItem.AppEventScreenshots => "appEventScreenshots",
                AppEventsLocalizationsGetToManyRelatedIncludeItem.AppEventVideoClips => "appEventVideoClips",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventsLocalizationsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "appEvent" => AppEventsLocalizationsGetToManyRelatedIncludeItem.AppEvent,
                "appEventScreenshots" => AppEventsLocalizationsGetToManyRelatedIncludeItem.AppEventScreenshots,
                "appEventVideoClips" => AppEventsLocalizationsGetToManyRelatedIncludeItem.AppEventVideoClips,
                _ => null,
            };
        }
    }
}