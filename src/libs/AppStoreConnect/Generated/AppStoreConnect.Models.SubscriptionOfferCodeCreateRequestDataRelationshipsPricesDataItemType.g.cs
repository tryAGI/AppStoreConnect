
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionOfferCodeCreateRequestDataRelationshipsPricesDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionOfferCodePrices,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionOfferCodeCreateRequestDataRelationshipsPricesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionOfferCodeCreateRequestDataRelationshipsPricesDataItemType value)
        {
            return value switch
            {
                SubscriptionOfferCodeCreateRequestDataRelationshipsPricesDataItemType.SubscriptionOfferCodePrices => "subscriptionOfferCodePrices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionOfferCodeCreateRequestDataRelationshipsPricesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionOfferCodePrices" => SubscriptionOfferCodeCreateRequestDataRelationshipsPricesDataItemType.SubscriptionOfferCodePrices,
                _ => null,
            };
        }
    }
}