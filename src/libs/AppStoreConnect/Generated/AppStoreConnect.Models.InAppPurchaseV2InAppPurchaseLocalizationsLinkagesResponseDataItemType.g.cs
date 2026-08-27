
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseV2InAppPurchaseLocalizationsLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        InAppPurchaseLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseV2InAppPurchaseLocalizationsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseV2InAppPurchaseLocalizationsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                InAppPurchaseV2InAppPurchaseLocalizationsLinkagesResponseDataItemType.InAppPurchaseLocalizations => "inAppPurchaseLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseV2InAppPurchaseLocalizationsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchaseLocalizations" => InAppPurchaseV2InAppPurchaseLocalizationsLinkagesResponseDataItemType.InAppPurchaseLocalizations,
                _ => null,
            };
        }
    }
}