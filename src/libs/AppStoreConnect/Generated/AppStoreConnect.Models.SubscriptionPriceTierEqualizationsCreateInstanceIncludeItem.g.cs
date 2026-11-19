
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionPriceTierEqualizationsCreateInstanceIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        PriceTierPricePoints,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionPriceTierEqualizationsCreateInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPriceTierEqualizationsCreateInstanceIncludeItem value)
        {
            return value switch
            {
                SubscriptionPriceTierEqualizationsCreateInstanceIncludeItem.PriceTierPricePoints => "priceTierPricePoints",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPriceTierEqualizationsCreateInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "priceTierPricePoints" => SubscriptionPriceTierEqualizationsCreateInstanceIncludeItem.PriceTierPricePoints,
                _ => null,
            };
        }
    }
}