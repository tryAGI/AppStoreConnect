
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionPriceTierEqualizationsCreateInstanceFieldsSubscriptionPriceTierEqualization
    {
        /// <summary>
        ///
        /// </summary>
        EqualizedPrices,
        /// <summary>
        ///
        /// </summary>
        PriceTierPricePoints,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionPriceTierEqualizationsCreateInstanceFieldsSubscriptionPriceTierEqualizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPriceTierEqualizationsCreateInstanceFieldsSubscriptionPriceTierEqualization value)
        {
            return value switch
            {
                SubscriptionPriceTierEqualizationsCreateInstanceFieldsSubscriptionPriceTierEqualization.EqualizedPrices => "equalizedPrices",
                SubscriptionPriceTierEqualizationsCreateInstanceFieldsSubscriptionPriceTierEqualization.PriceTierPricePoints => "priceTierPricePoints",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPriceTierEqualizationsCreateInstanceFieldsSubscriptionPriceTierEqualization? ToEnum(string value)
        {
            return value switch
            {
                "equalizedPrices" => SubscriptionPriceTierEqualizationsCreateInstanceFieldsSubscriptionPriceTierEqualization.EqualizedPrices,
                "priceTierPricePoints" => SubscriptionPriceTierEqualizationsCreateInstanceFieldsSubscriptionPriceTierEqualization.PriceTierPricePoints,
                _ => null,
            };
        }
    }
}