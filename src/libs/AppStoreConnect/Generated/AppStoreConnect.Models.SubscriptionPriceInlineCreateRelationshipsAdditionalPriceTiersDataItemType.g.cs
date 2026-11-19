
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionPriceInlineCreateRelationshipsAdditionalPriceTiersDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionPriceTiers,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionPriceInlineCreateRelationshipsAdditionalPriceTiersDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPriceInlineCreateRelationshipsAdditionalPriceTiersDataItemType value)
        {
            return value switch
            {
                SubscriptionPriceInlineCreateRelationshipsAdditionalPriceTiersDataItemType.SubscriptionPriceTiers => "subscriptionPriceTiers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPriceInlineCreateRelationshipsAdditionalPriceTiersDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionPriceTiers" => SubscriptionPriceInlineCreateRelationshipsAdditionalPriceTiersDataItemType.SubscriptionPriceTiers,
                _ => null,
            };
        }
    }
}