
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksDeliveriesGetToManyRelatedFilterDeliveryStateItem
    {
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Succeeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhooksDeliveriesGetToManyRelatedFilterDeliveryStateItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksDeliveriesGetToManyRelatedFilterDeliveryStateItem value)
        {
            return value switch
            {
                WebhooksDeliveriesGetToManyRelatedFilterDeliveryStateItem.Failed => "FAILED",
                WebhooksDeliveriesGetToManyRelatedFilterDeliveryStateItem.Pending => "PENDING",
                WebhooksDeliveriesGetToManyRelatedFilterDeliveryStateItem.Succeeded => "SUCCEEDED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksDeliveriesGetToManyRelatedFilterDeliveryStateItem? ToEnum(string value)
        {
            return value switch
            {
                "FAILED" => WebhooksDeliveriesGetToManyRelatedFilterDeliveryStateItem.Failed,
                "PENDING" => WebhooksDeliveriesGetToManyRelatedFilterDeliveryStateItem.Pending,
                "SUCCEEDED" => WebhooksDeliveriesGetToManyRelatedFilterDeliveryStateItem.Succeeded,
                _ => null,
            };
        }
    }
}