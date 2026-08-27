
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchasePricePointEqualizationsLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        InAppPurchasePricePoints,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchasePricePointEqualizationsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasePricePointEqualizationsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                InAppPurchasePricePointEqualizationsLinkagesResponseDataItemType.InAppPurchasePricePoints => "inAppPurchasePricePoints",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasePricePointEqualizationsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchasePricePoints" => InAppPurchasePricePointEqualizationsLinkagesResponseDataItemType.InAppPurchasePricePoints,
                _ => null,
            };
        }
    }
}