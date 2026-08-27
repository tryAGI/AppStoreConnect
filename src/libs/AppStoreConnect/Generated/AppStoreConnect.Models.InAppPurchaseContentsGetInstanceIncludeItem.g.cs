
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchaseContentsGetInstanceIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        InAppPurchaseV2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseContentsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseContentsGetInstanceIncludeItem value)
        {
            return value switch
            {
                InAppPurchaseContentsGetInstanceIncludeItem.InAppPurchaseV2 => "inAppPurchaseV2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseContentsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchaseV2" => InAppPurchaseContentsGetInstanceIncludeItem.InAppPurchaseV2,
                _ => null,
            };
        }
    }
}