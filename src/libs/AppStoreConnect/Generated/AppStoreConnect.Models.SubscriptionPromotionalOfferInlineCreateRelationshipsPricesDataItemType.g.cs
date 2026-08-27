
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionPromotionalOfferInlineCreateRelationshipsPricesDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        SubscriptionPromotionalOfferPrices,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionPromotionalOfferInlineCreateRelationshipsPricesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPromotionalOfferInlineCreateRelationshipsPricesDataItemType value)
        {
            return value switch
            {
                SubscriptionPromotionalOfferInlineCreateRelationshipsPricesDataItemType.SubscriptionPromotionalOfferPrices => "subscriptionPromotionalOfferPrices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPromotionalOfferInlineCreateRelationshipsPricesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionPromotionalOfferPrices" => SubscriptionPromotionalOfferInlineCreateRelationshipsPricesDataItemType.SubscriptionPromotionalOfferPrices,
                _ => null,
            };
        }
    }
}