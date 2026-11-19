
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionPricesAdditionalPriceTiersGetToManyRelatedIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionPricePoint,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionPricesAdditionalPriceTiersGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPricesAdditionalPriceTiersGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                SubscriptionPricesAdditionalPriceTiersGetToManyRelatedIncludeItem.SubscriptionPricePoint => "subscriptionPricePoint",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPricesAdditionalPriceTiersGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionPricePoint" => SubscriptionPricesAdditionalPriceTiersGetToManyRelatedIncludeItem.SubscriptionPricePoint,
                _ => null,
            };
        }
    }
}