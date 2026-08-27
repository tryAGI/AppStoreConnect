
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchasePriceInlineCreateType
    {
        /// <summary>
        ///
        /// </summary>
        InAppPurchasePrices,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchasePriceInlineCreateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasePriceInlineCreateType value)
        {
            return value switch
            {
                InAppPurchasePriceInlineCreateType.InAppPurchasePrices => "inAppPurchasePrices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasePriceInlineCreateType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchasePrices" => InAppPurchasePriceInlineCreateType.InAppPurchasePrices,
                _ => null,
            };
        }
    }
}