
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum MarketplaceWebhooksGetCollectionFieldsMarketplaceWebhook
    {
        /// <summary>
        /// 
        /// </summary>
        EndpointUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MarketplaceWebhooksGetCollectionFieldsMarketplaceWebhookExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MarketplaceWebhooksGetCollectionFieldsMarketplaceWebhook value)
        {
            return value switch
            {
                MarketplaceWebhooksGetCollectionFieldsMarketplaceWebhook.EndpointUrl => "endpointUrl",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MarketplaceWebhooksGetCollectionFieldsMarketplaceWebhook? ToEnum(string value)
        {
            return value switch
            {
                "endpointUrl" => MarketplaceWebhooksGetCollectionFieldsMarketplaceWebhook.EndpointUrl,
                _ => null,
            };
        }
    }
}