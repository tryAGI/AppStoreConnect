
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchaseV2RelationshipsInAppPurchaseLocalizationsDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        InAppPurchaseLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseV2RelationshipsInAppPurchaseLocalizationsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseV2RelationshipsInAppPurchaseLocalizationsDataItemType value)
        {
            return value switch
            {
                InAppPurchaseV2RelationshipsInAppPurchaseLocalizationsDataItemType.InAppPurchaseLocalizations => "inAppPurchaseLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseV2RelationshipsInAppPurchaseLocalizationsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchaseLocalizations" => InAppPurchaseV2RelationshipsInAppPurchaseLocalizationsDataItemType.InAppPurchaseLocalizations,
                _ => null,
            };
        }
    }
}