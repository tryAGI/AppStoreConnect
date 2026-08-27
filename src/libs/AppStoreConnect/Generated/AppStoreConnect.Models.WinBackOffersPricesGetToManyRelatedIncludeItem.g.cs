
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum WinBackOffersPricesGetToManyRelatedIncludeItem
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
    public static class WinBackOffersPricesGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WinBackOffersPricesGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                WinBackOffersPricesGetToManyRelatedIncludeItem.SubscriptionPricePoint => "subscriptionPricePoint",
                WinBackOffersPricesGetToManyRelatedIncludeItem.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WinBackOffersPricesGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionPricePoint" => WinBackOffersPricesGetToManyRelatedIncludeItem.SubscriptionPricePoint,
                "territory" => WinBackOffersPricesGetToManyRelatedIncludeItem.Territory,
                _ => null,
            };
        }
    }
}