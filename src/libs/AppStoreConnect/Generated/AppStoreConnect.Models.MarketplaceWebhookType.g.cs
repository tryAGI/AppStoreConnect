
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum MarketplaceWebhookType
    {
        /// <summary>
        ///
        /// </summary>
        MarketplaceWebhooks,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MarketplaceWebhookTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MarketplaceWebhookType value)
        {
            return value switch
            {
                MarketplaceWebhookType.MarketplaceWebhooks => "marketplaceWebhooks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MarketplaceWebhookType? ToEnum(string value)
        {
            return value switch
            {
                "marketplaceWebhooks" => MarketplaceWebhookType.MarketplaceWebhooks,
                _ => null,
            };
        }
    }
}