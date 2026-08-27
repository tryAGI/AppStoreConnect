
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchasesGetInstanceIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        Apps,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchasesGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasesGetInstanceIncludeItem value)
        {
            return value switch
            {
                InAppPurchasesGetInstanceIncludeItem.Apps => "apps",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasesGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "apps" => InAppPurchasesGetInstanceIncludeItem.Apps,
                _ => null,
            };
        }
    }
}