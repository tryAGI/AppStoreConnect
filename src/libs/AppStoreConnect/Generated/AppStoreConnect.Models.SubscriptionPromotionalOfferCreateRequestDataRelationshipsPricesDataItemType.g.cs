
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionPromotionalOfferCreateRequestDataRelationshipsPricesDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionPromotionalOfferPrices,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionPromotionalOfferCreateRequestDataRelationshipsPricesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPromotionalOfferCreateRequestDataRelationshipsPricesDataItemType value)
        {
            return value switch
            {
                SubscriptionPromotionalOfferCreateRequestDataRelationshipsPricesDataItemType.SubscriptionPromotionalOfferPrices => "subscriptionPromotionalOfferPrices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPromotionalOfferCreateRequestDataRelationshipsPricesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionPromotionalOfferPrices" => SubscriptionPromotionalOfferCreateRequestDataRelationshipsPricesDataItemType.SubscriptionPromotionalOfferPrices,
                _ => null,
            };
        }
    }
}