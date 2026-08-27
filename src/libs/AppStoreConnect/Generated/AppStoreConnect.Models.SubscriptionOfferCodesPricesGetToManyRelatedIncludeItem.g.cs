
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionOfferCodesPricesGetToManyRelatedIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        SubscriptionPricePoint,
        /// <summary>
        /// 
        /// </summary>
        Territory,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionOfferCodesPricesGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionOfferCodesPricesGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                SubscriptionOfferCodesPricesGetToManyRelatedIncludeItem.SubscriptionPricePoint => "subscriptionPricePoint",
                SubscriptionOfferCodesPricesGetToManyRelatedIncludeItem.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionOfferCodesPricesGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionPricePoint" => SubscriptionOfferCodesPricesGetToManyRelatedIncludeItem.SubscriptionPricePoint,
                "territory" => SubscriptionOfferCodesPricesGetToManyRelatedIncludeItem.Territory,
                _ => null,
            };
        }
    }
}