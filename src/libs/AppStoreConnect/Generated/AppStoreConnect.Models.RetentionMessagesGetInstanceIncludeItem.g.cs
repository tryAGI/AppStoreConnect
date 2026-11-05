
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionMessagesGetInstanceIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        Subscriptions,
        /// <summary>
        ///
        /// </summary>
        Versions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetentionMessagesGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionMessagesGetInstanceIncludeItem value)
        {
            return value switch
            {
                RetentionMessagesGetInstanceIncludeItem.Subscriptions => "subscriptions",
                RetentionMessagesGetInstanceIncludeItem.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionMessagesGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "subscriptions" => RetentionMessagesGetInstanceIncludeItem.Subscriptions,
                "versions" => RetentionMessagesGetInstanceIncludeItem.Versions,
                _ => null,
            };
        }
    }
}