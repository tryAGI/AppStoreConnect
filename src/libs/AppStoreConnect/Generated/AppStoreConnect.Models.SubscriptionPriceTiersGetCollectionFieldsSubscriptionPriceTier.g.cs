
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionPriceTiersGetCollectionFieldsSubscriptionPriceTier
    {
        /// <summary>
        ///
        /// </summary>
        MinQuantity,
        /// <summary>
        ///
        /// </summary>
        SubscriptionPricePoint,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionPriceTiersGetCollectionFieldsSubscriptionPriceTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPriceTiersGetCollectionFieldsSubscriptionPriceTier value)
        {
            return value switch
            {
                SubscriptionPriceTiersGetCollectionFieldsSubscriptionPriceTier.MinQuantity => "minQuantity",
                SubscriptionPriceTiersGetCollectionFieldsSubscriptionPriceTier.SubscriptionPricePoint => "subscriptionPricePoint",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPriceTiersGetCollectionFieldsSubscriptionPriceTier? ToEnum(string value)
        {
            return value switch
            {
                "minQuantity" => SubscriptionPriceTiersGetCollectionFieldsSubscriptionPriceTier.MinQuantity,
                "subscriptionPricePoint" => SubscriptionPriceTiersGetCollectionFieldsSubscriptionPriceTier.SubscriptionPricePoint,
                _ => null,
            };
        }
    }
}