
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookUpdateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        Webhooks,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookUpdateRequestDataType value)
        {
            return value switch
            {
                WebhookUpdateRequestDataType.Webhooks => "webhooks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "webhooks" => WebhookUpdateRequestDataType.Webhooks,
                _ => null,
            };
        }
    }
}