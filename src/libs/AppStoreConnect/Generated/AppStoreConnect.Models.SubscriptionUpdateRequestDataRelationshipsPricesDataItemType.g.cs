
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionUpdateRequestDataRelationshipsPricesDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        SubscriptionPrices,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionUpdateRequestDataRelationshipsPricesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionUpdateRequestDataRelationshipsPricesDataItemType value)
        {
            return value switch
            {
                SubscriptionUpdateRequestDataRelationshipsPricesDataItemType.SubscriptionPrices => "subscriptionPrices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionUpdateRequestDataRelationshipsPricesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionPrices" => SubscriptionUpdateRequestDataRelationshipsPricesDataItemType.SubscriptionPrices,
                _ => null,
            };
        }
    }
}