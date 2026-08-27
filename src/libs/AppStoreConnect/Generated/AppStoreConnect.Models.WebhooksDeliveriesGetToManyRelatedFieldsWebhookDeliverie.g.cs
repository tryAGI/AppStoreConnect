
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhooksDeliveriesGetToManyRelatedFieldsWebhookDeliverie
    {
        /// <summary>
        ///
        /// </summary>
        CreatedDate,
        /// <summary>
        ///
        /// </summary>
        DeliveryState,
        /// <summary>
        ///
        /// </summary>
        ErrorMessage,
        /// <summary>
        ///
        /// </summary>
        Event,
        /// <summary>
        ///
        /// </summary>
        Redelivery,
        /// <summary>
        ///
        /// </summary>
        Request,
        /// <summary>
        ///
        /// </summary>
        Response,
        /// <summary>
        ///
        /// </summary>
        SentDate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhooksDeliveriesGetToManyRelatedFieldsWebhookDeliverieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksDeliveriesGetToManyRelatedFieldsWebhookDeliverie value)
        {
            return value switch
            {
                WebhooksDeliveriesGetToManyRelatedFieldsWebhookDeliverie.CreatedDate => "createdDate",
                WebhooksDeliveriesGetToManyRelatedFieldsWebhookDeliverie.DeliveryState => "deliveryState",
                WebhooksDeliveriesGetToManyRelatedFieldsWebhookDeliverie.ErrorMessage => "errorMessage",
                WebhooksDeliveriesGetToManyRelatedFieldsWebhookDeliverie.Event => "event",
                WebhooksDeliveriesGetToManyRelatedFieldsWebhookDeliverie.Redelivery => "redelivery",
                WebhooksDeliveriesGetToManyRelatedFieldsWebhookDeliverie.Request => "request",
                WebhooksDeliveriesGetToManyRelatedFieldsWebhookDeliverie.Response => "response",
                WebhooksDeliveriesGetToManyRelatedFieldsWebhookDeliverie.SentDate => "sentDate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksDeliveriesGetToManyRelatedFieldsWebhookDeliverie? ToEnum(string value)
        {
            return value switch
            {
                "createdDate" => WebhooksDeliveriesGetToManyRelatedFieldsWebhookDeliverie.CreatedDate,
                "deliveryState" => WebhooksDeliveriesGetToManyRelatedFieldsWebhookDeliverie.DeliveryState,
                "errorMessage" => WebhooksDeliveriesGetToManyRelatedFieldsWebhookDeliverie.ErrorMessage,
                "event" => WebhooksDeliveriesGetToManyRelatedFieldsWebhookDeliverie.Event,
                "redelivery" => WebhooksDeliveriesGetToManyRelatedFieldsWebhookDeliverie.Redelivery,
                "request" => WebhooksDeliveriesGetToManyRelatedFieldsWebhookDeliverie.Request,
                "response" => WebhooksDeliveriesGetToManyRelatedFieldsWebhookDeliverie.Response,
                "sentDate" => WebhooksDeliveriesGetToManyRelatedFieldsWebhookDeliverie.SentDate,
                _ => null,
            };
        }
    }
}