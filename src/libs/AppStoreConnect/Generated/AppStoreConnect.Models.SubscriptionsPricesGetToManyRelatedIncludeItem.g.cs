
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionsPricesGetToManyRelatedIncludeItem
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
    public static class SubscriptionsPricesGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsPricesGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                SubscriptionsPricesGetToManyRelatedIncludeItem.SubscriptionPricePoint => "subscriptionPricePoint",
                SubscriptionsPricesGetToManyRelatedIncludeItem.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsPricesGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionPricePoint" => SubscriptionsPricesGetToManyRelatedIncludeItem.SubscriptionPricePoint,
                "territory" => SubscriptionsPricesGetToManyRelatedIncludeItem.Territory,
                _ => null,
            };
        }
    }
}