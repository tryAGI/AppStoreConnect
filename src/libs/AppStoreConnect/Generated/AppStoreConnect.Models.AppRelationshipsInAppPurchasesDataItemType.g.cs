
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppRelationshipsInAppPurchasesDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        InAppPurchases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppRelationshipsInAppPurchasesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppRelationshipsInAppPurchasesDataItemType value)
        {
            return value switch
            {
                AppRelationshipsInAppPurchasesDataItemType.InAppPurchases => "inAppPurchases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppRelationshipsInAppPurchasesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchases" => AppRelationshipsInAppPurchasesDataItemType.InAppPurchases,
                _ => null,
            };
        }
    }
}