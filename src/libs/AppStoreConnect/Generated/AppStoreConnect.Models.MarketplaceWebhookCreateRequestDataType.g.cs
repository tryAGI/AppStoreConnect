
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum MarketplaceWebhookCreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        MarketplaceWebhooks,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MarketplaceWebhookCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MarketplaceWebhookCreateRequestDataType value)
        {
            return value switch
            {
                MarketplaceWebhookCreateRequestDataType.MarketplaceWebhooks => "marketplaceWebhooks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MarketplaceWebhookCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "marketplaceWebhooks" => MarketplaceWebhookCreateRequestDataType.MarketplaceWebhooks,
                _ => null,
            };
        }
    }
}