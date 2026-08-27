
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum MarketplaceWebhookUpdateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        MarketplaceWebhooks,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MarketplaceWebhookUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MarketplaceWebhookUpdateRequestDataType value)
        {
            return value switch
            {
                MarketplaceWebhookUpdateRequestDataType.MarketplaceWebhooks => "marketplaceWebhooks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MarketplaceWebhookUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "marketplaceWebhooks" => MarketplaceWebhookUpdateRequestDataType.MarketplaceWebhooks,
                _ => null,
            };
        }
    }
}