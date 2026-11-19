
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionPricesAdditionalPriceTiersGetToManyRelatedFieldsSubscriptionPriceTier
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
    public static class SubscriptionPricesAdditionalPriceTiersGetToManyRelatedFieldsSubscriptionPriceTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPricesAdditionalPriceTiersGetToManyRelatedFieldsSubscriptionPriceTier value)
        {
            return value switch
            {
                SubscriptionPricesAdditionalPriceTiersGetToManyRelatedFieldsSubscriptionPriceTier.MinQuantity => "minQuantity",
                SubscriptionPricesAdditionalPriceTiersGetToManyRelatedFieldsSubscriptionPriceTier.SubscriptionPricePoint => "subscriptionPricePoint",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPricesAdditionalPriceTiersGetToManyRelatedFieldsSubscriptionPriceTier? ToEnum(string value)
        {
            return value switch
            {
                "minQuantity" => SubscriptionPricesAdditionalPriceTiersGetToManyRelatedFieldsSubscriptionPriceTier.MinQuantity,
                "subscriptionPricePoint" => SubscriptionPricesAdditionalPriceTiersGetToManyRelatedFieldsSubscriptionPriceTier.SubscriptionPricePoint,
                _ => null,
            };
        }
    }
}