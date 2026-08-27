
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookDeliveryRelationshipsEventDataType
    {
        /// <summary>
        ///
        /// </summary>
        WebhookEvents,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookDeliveryRelationshipsEventDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeliveryRelationshipsEventDataType value)
        {
            return value switch
            {
                WebhookDeliveryRelationshipsEventDataType.WebhookEvents => "webhookEvents",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeliveryRelationshipsEventDataType? ToEnum(string value)
        {
            return value switch
            {
                "webhookEvents" => WebhookDeliveryRelationshipsEventDataType.WebhookEvents,
                _ => null,
            };
        }
    }
}