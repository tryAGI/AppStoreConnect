
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhooksDeliveriesGetToManyRelatedFieldsWebhookEvent
    {
        /// <summary>
        ///
        /// </summary>
        CreatedDate,
        /// <summary>
        ///
        /// </summary>
        EventType,
        /// <summary>
        ///
        /// </summary>
        Payload,
        /// <summary>
        ///
        /// </summary>
        Ping,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhooksDeliveriesGetToManyRelatedFieldsWebhookEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksDeliveriesGetToManyRelatedFieldsWebhookEvent value)
        {
            return value switch
            {
                WebhooksDeliveriesGetToManyRelatedFieldsWebhookEvent.CreatedDate => "createdDate",
                WebhooksDeliveriesGetToManyRelatedFieldsWebhookEvent.EventType => "eventType",
                WebhooksDeliveriesGetToManyRelatedFieldsWebhookEvent.Payload => "payload",
                WebhooksDeliveriesGetToManyRelatedFieldsWebhookEvent.Ping => "ping",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksDeliveriesGetToManyRelatedFieldsWebhookEvent? ToEnum(string value)
        {
            return value switch
            {
                "createdDate" => WebhooksDeliveriesGetToManyRelatedFieldsWebhookEvent.CreatedDate,
                "eventType" => WebhooksDeliveriesGetToManyRelatedFieldsWebhookEvent.EventType,
                "payload" => WebhooksDeliveriesGetToManyRelatedFieldsWebhookEvent.Payload,
                "ping" => WebhooksDeliveriesGetToManyRelatedFieldsWebhookEvent.Ping,
                _ => null,
            };
        }
    }
}