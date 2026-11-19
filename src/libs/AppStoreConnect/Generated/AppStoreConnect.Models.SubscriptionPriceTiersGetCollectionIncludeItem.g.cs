
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionPriceTiersGetCollectionIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionPricePoint,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionPriceTiersGetCollectionIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPriceTiersGetCollectionIncludeItem value)
        {
            return value switch
            {
                SubscriptionPriceTiersGetCollectionIncludeItem.SubscriptionPricePoint => "subscriptionPricePoint",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPriceTiersGetCollectionIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionPricePoint" => SubscriptionPriceTiersGetCollectionIncludeItem.SubscriptionPricePoint,
                _ => null,
            };
        }
    }
}