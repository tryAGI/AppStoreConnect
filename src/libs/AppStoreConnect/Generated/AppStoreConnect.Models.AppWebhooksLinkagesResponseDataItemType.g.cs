
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppWebhooksLinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Webhooks,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppWebhooksLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppWebhooksLinkagesResponseDataItemType value)
        {
            return value switch
            {
                AppWebhooksLinkagesResponseDataItemType.Webhooks => "webhooks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppWebhooksLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "webhooks" => AppWebhooksLinkagesResponseDataItemType.Webhooks,
                _ => null,
            };
        }
    }
}