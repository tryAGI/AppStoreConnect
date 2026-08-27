
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPingCreateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        WebhookPings,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPingCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPingCreateRequestDataType value)
        {
            return value switch
            {
                WebhookPingCreateRequestDataType.WebhookPings => "webhookPings",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPingCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "webhookPings" => WebhookPingCreateRequestDataType.WebhookPings,
                _ => null,
            };
        }
    }
}