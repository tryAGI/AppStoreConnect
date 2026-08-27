
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionPromotionalOfferUpdateRequestDataRelationshipsPricesDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionPromotionalOfferPrices,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionPromotionalOfferUpdateRequestDataRelationshipsPricesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPromotionalOfferUpdateRequestDataRelationshipsPricesDataItemType value)
        {
            return value switch
            {
                SubscriptionPromotionalOfferUpdateRequestDataRelationshipsPricesDataItemType.SubscriptionPromotionalOfferPrices => "subscriptionPromotionalOfferPrices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPromotionalOfferUpdateRequestDataRelationshipsPricesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionPromotionalOfferPrices" => SubscriptionPromotionalOfferUpdateRequestDataRelationshipsPricesDataItemType.SubscriptionPromotionalOfferPrices,
                _ => null,
            };
        }
    }
}