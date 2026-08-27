
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPingType
    {
        /// <summary>
        /// 
        /// </summary>
        WebhookPings,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPingType value)
        {
            return value switch
            {
                WebhookPingType.WebhookPings => "webhookPings",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPingType? ToEnum(string value)
        {
            return value switch
            {
                "webhookPings" => WebhookPingType.WebhookPings,
                _ => null,
            };
        }
    }
}