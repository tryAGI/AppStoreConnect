
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchaseVersionsGetInstanceIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Images,
        /// <summary>
        /// 
        /// </summary>
        InAppPurchase,
        /// <summary>
        /// 
        /// </summary>
        Localizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseVersionsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseVersionsGetInstanceIncludeItem value)
        {
            return value switch
            {
                InAppPurchaseVersionsGetInstanceIncludeItem.Image => "image",
                InAppPurchaseVersionsGetInstanceIncludeItem.Images => "images",
                InAppPurchaseVersionsGetInstanceIncludeItem.InAppPurchase => "inAppPurchase",
                InAppPurchaseVersionsGetInstanceIncludeItem.Localizations => "localizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseVersionsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "image" => InAppPurchaseVersionsGetInstanceIncludeItem.Image,
                "images" => InAppPurchaseVersionsGetInstanceIncludeItem.Images,
                "inAppPurchase" => InAppPurchaseVersionsGetInstanceIncludeItem.InAppPurchase,
                "localizations" => InAppPurchaseVersionsGetInstanceIncludeItem.Localizations,
                _ => null,
            };
        }
    }
}