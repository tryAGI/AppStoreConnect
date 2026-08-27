
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchasePriceType
    {
        /// <summary>
        /// 
        /// </summary>
        InAppPurchasePrices,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchasePriceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasePriceType value)
        {
            return value switch
            {
                InAppPurchasePriceType.InAppPurchasePrices => "inAppPurchasePrices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasePriceType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchasePrices" => InAppPurchasePriceType.InAppPurchasePrices,
                _ => null,
            };
        }
    }
}