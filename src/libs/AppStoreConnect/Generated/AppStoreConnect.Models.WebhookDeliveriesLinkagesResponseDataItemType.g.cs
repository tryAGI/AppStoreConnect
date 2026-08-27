
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookDeliveriesLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        WebhookDeliveries,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookDeliveriesLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeliveriesLinkagesResponseDataItemType value)
        {
            return value switch
            {
                WebhookDeliveriesLinkagesResponseDataItemType.WebhookDeliveries => "webhookDeliveries",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeliveriesLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "webhookDeliveries" => WebhookDeliveriesLinkagesResponseDataItemType.WebhookDeliveries,
                _ => null,
            };
        }
    }
}