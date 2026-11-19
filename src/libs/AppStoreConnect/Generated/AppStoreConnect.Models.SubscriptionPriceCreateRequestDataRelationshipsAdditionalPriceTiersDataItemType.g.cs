
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionPriceCreateRequestDataRelationshipsAdditionalPriceTiersDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionPriceTiers,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionPriceCreateRequestDataRelationshipsAdditionalPriceTiersDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPriceCreateRequestDataRelationshipsAdditionalPriceTiersDataItemType value)
        {
            return value switch
            {
                SubscriptionPriceCreateRequestDataRelationshipsAdditionalPriceTiersDataItemType.SubscriptionPriceTiers => "subscriptionPriceTiers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPriceCreateRequestDataRelationshipsAdditionalPriceTiersDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionPriceTiers" => SubscriptionPriceCreateRequestDataRelationshipsAdditionalPriceTiersDataItemType.SubscriptionPriceTiers,
                _ => null,
            };
        }
    }
}