
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionOfferCodeRelationshipsPricesDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        SubscriptionOfferCodePrices,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionOfferCodeRelationshipsPricesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionOfferCodeRelationshipsPricesDataItemType value)
        {
            return value switch
            {
                SubscriptionOfferCodeRelationshipsPricesDataItemType.SubscriptionOfferCodePrices => "subscriptionOfferCodePrices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionOfferCodeRelationshipsPricesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionOfferCodePrices" => SubscriptionOfferCodeRelationshipsPricesDataItemType.SubscriptionOfferCodePrices,
                _ => null,
            };
        }
    }
}