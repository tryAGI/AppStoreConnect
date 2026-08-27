
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodePrice
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
    public static class SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodePriceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodePrice value)
        {
            return value switch
            {
                SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodePrice.SubscriptionPricePoint => "subscriptionPricePoint",
                SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodePrice.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodePrice? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionPricePoint" => SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodePrice.SubscriptionPricePoint,
                "territory" => SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodePrice.Territory,
                _ => null,
            };
        }
    }
}