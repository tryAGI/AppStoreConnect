
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookDeliveryCreateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        WebhookDeliveries,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookDeliveryCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeliveryCreateRequestDataType value)
        {
            return value switch
            {
                WebhookDeliveryCreateRequestDataType.WebhookDeliveries => "webhookDeliveries",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeliveryCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "webhookDeliveries" => WebhookDeliveryCreateRequestDataType.WebhookDeliveries,
                _ => null,
            };
        }
    }
}