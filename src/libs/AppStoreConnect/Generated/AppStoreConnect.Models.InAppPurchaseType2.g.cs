
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseType2
    {
        /// <summary>
        ///
        /// </summary>
        InAppPurchases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseType2 value)
        {
            return value switch
            {
                InAppPurchaseType2.InAppPurchases => "inAppPurchases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseType2? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchases" => InAppPurchaseType2.InAppPurchases,
                _ => null,
            };
        }
    }
}