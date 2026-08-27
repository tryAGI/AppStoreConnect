
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookDeliveryType
    {
        /// <summary>
        /// 
        /// </summary>
        WebhookDeliveries,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookDeliveryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeliveryType value)
        {
            return value switch
            {
                WebhookDeliveryType.WebhookDeliveries => "webhookDeliveries",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeliveryType? ToEnum(string value)
        {
            return value switch
            {
                "webhookDeliveries" => WebhookDeliveryType.WebhookDeliveries,
                _ => null,
            };
        }
    }
}