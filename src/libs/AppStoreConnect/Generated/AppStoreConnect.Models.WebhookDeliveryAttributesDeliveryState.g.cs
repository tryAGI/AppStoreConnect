
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookDeliveryAttributesDeliveryState
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
    public static class WebhookDeliveryAttributesDeliveryStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeliveryAttributesDeliveryState value)
        {
            return value switch
            {
                WebhookDeliveryAttributesDeliveryState.Failed => "FAILED",
                WebhookDeliveryAttributesDeliveryState.Pending => "PENDING",
                WebhookDeliveryAttributesDeliveryState.Succeeded => "SUCCEEDED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeliveryAttributesDeliveryState? ToEnum(string value)
        {
            return value switch
            {
                "FAILED" => WebhookDeliveryAttributesDeliveryState.Failed,
                "PENDING" => WebhookDeliveryAttributesDeliveryState.Pending,
                "SUCCEEDED" => WebhookDeliveryAttributesDeliveryState.Succeeded,
                _ => null,
            };
        }
    }
}