
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionsPricesGetToManyRelatedFieldsSubscriptionPriceTier
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
    public static class SubscriptionsPricesGetToManyRelatedFieldsSubscriptionPriceTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsPricesGetToManyRelatedFieldsSubscriptionPriceTier value)
        {
            return value switch
            {
                SubscriptionsPricesGetToManyRelatedFieldsSubscriptionPriceTier.MinQuantity => "minQuantity",
                SubscriptionsPricesGetToManyRelatedFieldsSubscriptionPriceTier.SubscriptionPricePoint => "subscriptionPricePoint",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsPricesGetToManyRelatedFieldsSubscriptionPriceTier? ToEnum(string value)
        {
            return value switch
            {
                "minQuantity" => SubscriptionsPricesGetToManyRelatedFieldsSubscriptionPriceTier.MinQuantity,
                "subscriptionPricePoint" => SubscriptionsPricesGetToManyRelatedFieldsSubscriptionPriceTier.SubscriptionPricePoint,
                _ => null,
            };
        }
    }
}