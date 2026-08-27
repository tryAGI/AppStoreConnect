
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhooksGetInstanceIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        App,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhooksGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksGetInstanceIncludeItem value)
        {
            return value switch
            {
                WebhooksGetInstanceIncludeItem.App => "app",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "app" => WebhooksGetInstanceIncludeItem.App,
                _ => null,
            };
        }
    }
}