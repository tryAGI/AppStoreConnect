
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOfferPrice
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
    public static class SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOfferPriceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOfferPrice value)
        {
            return value switch
            {
                SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOfferPrice.SubscriptionPricePoint => "subscriptionPricePoint",
                SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOfferPrice.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOfferPrice? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionPricePoint" => SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOfferPrice.SubscriptionPricePoint,
                "territory" => SubscriptionsWinBackOffersGetToManyRelatedFieldsWinBackOfferPrice.Territory,
                _ => null,
            };
        }
    }
}