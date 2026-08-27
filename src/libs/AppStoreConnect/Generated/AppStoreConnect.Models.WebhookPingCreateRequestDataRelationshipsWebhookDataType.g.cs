
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPingCreateRequestDataRelationshipsWebhookDataType
    {
        /// <summary>
        /// 
        /// </summary>
        Webhooks,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPingCreateRequestDataRelationshipsWebhookDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPingCreateRequestDataRelationshipsWebhookDataType value)
        {
            return value switch
            {
                WebhookPingCreateRequestDataRelationshipsWebhookDataType.Webhooks => "webhooks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPingCreateRequestDataRelationshipsWebhookDataType? ToEnum(string value)
        {
            return value switch
            {
                "webhooks" => WebhookPingCreateRequestDataRelationshipsWebhookDataType.Webhooks,
                _ => null,
            };
        }
    }
}