
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookDeliveryCreateRequestDataRelationshipsTemplateDataType
    {
        /// <summary>
        ///
        /// </summary>
        WebhookDeliveries,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookDeliveryCreateRequestDataRelationshipsTemplateDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeliveryCreateRequestDataRelationshipsTemplateDataType value)
        {
            return value switch
            {
                WebhookDeliveryCreateRequestDataRelationshipsTemplateDataType.WebhookDeliveries => "webhookDeliveries",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeliveryCreateRequestDataRelationshipsTemplateDataType? ToEnum(string value)
        {
            return value switch
            {
                "webhookDeliveries" => WebhookDeliveryCreateRequestDataRelationshipsTemplateDataType.WebhookDeliveries,
                _ => null,
            };
        }
    }
}