
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum WinBackOffersGetInstanceFieldsWinBackOfferPrice
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
    public static class WinBackOffersGetInstanceFieldsWinBackOfferPriceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WinBackOffersGetInstanceFieldsWinBackOfferPrice value)
        {
            return value switch
            {
                WinBackOffersGetInstanceFieldsWinBackOfferPrice.SubscriptionPricePoint => "subscriptionPricePoint",
                WinBackOffersGetInstanceFieldsWinBackOfferPrice.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WinBackOffersGetInstanceFieldsWinBackOfferPrice? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionPricePoint" => WinBackOffersGetInstanceFieldsWinBackOfferPrice.SubscriptionPricePoint,
                "territory" => WinBackOffersGetInstanceFieldsWinBackOfferPrice.Territory,
                _ => null,
            };
        }
    }
}