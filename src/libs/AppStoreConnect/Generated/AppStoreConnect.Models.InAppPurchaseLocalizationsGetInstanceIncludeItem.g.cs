
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseLocalizationsGetInstanceIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        InAppPurchaseV2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseLocalizationsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseLocalizationsGetInstanceIncludeItem value)
        {
            return value switch
            {
                InAppPurchaseLocalizationsGetInstanceIncludeItem.InAppPurchaseV2 => "inAppPurchaseV2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseLocalizationsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchaseV2" => InAppPurchaseLocalizationsGetInstanceIncludeItem.InAppPurchaseV2,
                _ => null,
            };
        }
    }
}