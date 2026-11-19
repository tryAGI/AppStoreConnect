
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionPriceAdditionalPriceTiersLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionPriceTiers,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionPriceAdditionalPriceTiersLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPriceAdditionalPriceTiersLinkagesResponseDataItemType value)
        {
            return value switch
            {
                SubscriptionPriceAdditionalPriceTiersLinkagesResponseDataItemType.SubscriptionPriceTiers => "subscriptionPriceTiers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPriceAdditionalPriceTiersLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionPriceTiers" => SubscriptionPriceAdditionalPriceTiersLinkagesResponseDataItemType.SubscriptionPriceTiers,
                _ => null,
            };
        }
    }
}