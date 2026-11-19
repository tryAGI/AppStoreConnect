
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionPriceRelationshipsAdditionalPriceTiersDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionPriceTiers,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionPriceRelationshipsAdditionalPriceTiersDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPriceRelationshipsAdditionalPriceTiersDataItemType value)
        {
            return value switch
            {
                SubscriptionPriceRelationshipsAdditionalPriceTiersDataItemType.SubscriptionPriceTiers => "subscriptionPriceTiers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPriceRelationshipsAdditionalPriceTiersDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionPriceTiers" => SubscriptionPriceRelationshipsAdditionalPriceTiersDataItemType.SubscriptionPriceTiers,
                _ => null,
            };
        }
    }
}