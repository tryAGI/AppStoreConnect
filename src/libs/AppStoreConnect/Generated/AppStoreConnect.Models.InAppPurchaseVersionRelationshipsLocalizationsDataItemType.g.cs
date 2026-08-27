
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseVersionRelationshipsLocalizationsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        InAppPurchaseLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseVersionRelationshipsLocalizationsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseVersionRelationshipsLocalizationsDataItemType value)
        {
            return value switch
            {
                InAppPurchaseVersionRelationshipsLocalizationsDataItemType.InAppPurchaseLocalizations => "inAppPurchaseLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseVersionRelationshipsLocalizationsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchaseLocalizations" => InAppPurchaseVersionRelationshipsLocalizationsDataItemType.InAppPurchaseLocalizations,
                _ => null,
            };
        }
    }
}