
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseVersionLocalizationsLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        InAppPurchaseLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseVersionLocalizationsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseVersionLocalizationsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                InAppPurchaseVersionLocalizationsLinkagesResponseDataItemType.InAppPurchaseLocalizations => "inAppPurchaseLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseVersionLocalizationsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchaseLocalizations" => InAppPurchaseVersionLocalizationsLinkagesResponseDataItemType.InAppPurchaseLocalizations,
                _ => null,
            };
        }
    }
}