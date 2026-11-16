
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookEventType2
    {
        /// <summary>
        ///
        /// </summary>
        WebhookEvents,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookEventType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookEventType2 value)
        {
            return value switch
            {
                WebhookEventType2.WebhookEvents => "webhookEvents",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookEventType2? ToEnum(string value)
        {
            return value switch
            {
                "webhookEvents" => WebhookEventType2.WebhookEvents,
                _ => null,
            };
        }
    }
}