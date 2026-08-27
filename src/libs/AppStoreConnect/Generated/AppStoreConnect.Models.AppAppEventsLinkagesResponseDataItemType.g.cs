
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAppEventsLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        AppEvents,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAppEventsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAppEventsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                AppAppEventsLinkagesResponseDataItemType.AppEvents => "appEvents",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAppEventsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appEvents" => AppAppEventsLinkagesResponseDataItemType.AppEvents,
                _ => null,
            };
        }
    }
}