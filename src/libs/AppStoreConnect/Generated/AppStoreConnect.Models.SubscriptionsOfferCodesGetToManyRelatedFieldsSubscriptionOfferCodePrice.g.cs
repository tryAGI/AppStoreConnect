
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodePrice
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
    public static class SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodePriceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodePrice value)
        {
            return value switch
            {
                SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodePrice.SubscriptionPricePoint => "subscriptionPricePoint",
                SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodePrice.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodePrice? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionPricePoint" => SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodePrice.SubscriptionPricePoint,
                "territory" => SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodePrice.Territory,
                _ => null,
            };
        }
    }
}