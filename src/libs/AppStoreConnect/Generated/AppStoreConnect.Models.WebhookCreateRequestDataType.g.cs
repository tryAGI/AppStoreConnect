
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookCreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        Webhooks,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCreateRequestDataType value)
        {
            return value switch
            {
                WebhookCreateRequestDataType.Webhooks => "webhooks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "webhooks" => WebhookCreateRequestDataType.Webhooks,
                _ => null,
            };
        }
    }
}