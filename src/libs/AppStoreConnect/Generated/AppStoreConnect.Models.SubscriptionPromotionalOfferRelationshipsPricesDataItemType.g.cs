
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionPromotionalOfferRelationshipsPricesDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionPromotionalOfferPrices,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionPromotionalOfferRelationshipsPricesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPromotionalOfferRelationshipsPricesDataItemType value)
        {
            return value switch
            {
                SubscriptionPromotionalOfferRelationshipsPricesDataItemType.SubscriptionPromotionalOfferPrices => "subscriptionPromotionalOfferPrices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPromotionalOfferRelationshipsPricesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionPromotionalOfferPrices" => SubscriptionPromotionalOfferRelationshipsPricesDataItemType.SubscriptionPromotionalOfferPrices,
                _ => null,
            };
        }
    }
}