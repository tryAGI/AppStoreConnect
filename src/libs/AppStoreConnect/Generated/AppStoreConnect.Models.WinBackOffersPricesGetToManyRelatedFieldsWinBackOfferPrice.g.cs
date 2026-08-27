
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum WinBackOffersPricesGetToManyRelatedFieldsWinBackOfferPrice
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
    public static class WinBackOffersPricesGetToManyRelatedFieldsWinBackOfferPriceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WinBackOffersPricesGetToManyRelatedFieldsWinBackOfferPrice value)
        {
            return value switch
            {
                WinBackOffersPricesGetToManyRelatedFieldsWinBackOfferPrice.SubscriptionPricePoint => "subscriptionPricePoint",
                WinBackOffersPricesGetToManyRelatedFieldsWinBackOfferPrice.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WinBackOffersPricesGetToManyRelatedFieldsWinBackOfferPrice? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionPricePoint" => WinBackOffersPricesGetToManyRelatedFieldsWinBackOfferPrice.SubscriptionPricePoint,
                "territory" => WinBackOffersPricesGetToManyRelatedFieldsWinBackOfferPrice.Territory,
                _ => null,
            };
        }
    }
}