
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseImagesGetInstanceIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        InAppPurchase,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseImagesGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseImagesGetInstanceIncludeItem value)
        {
            return value switch
            {
                InAppPurchaseImagesGetInstanceIncludeItem.InAppPurchase => "inAppPurchase",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseImagesGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchase" => InAppPurchaseImagesGetInstanceIncludeItem.InAppPurchase,
                _ => null,
            };
        }
    }
}