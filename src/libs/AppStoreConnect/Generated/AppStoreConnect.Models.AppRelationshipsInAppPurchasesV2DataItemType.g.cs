
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppRelationshipsInAppPurchasesV2DataItemType
    {
        /// <summary>
        ///
        /// </summary>
        InAppPurchases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppRelationshipsInAppPurchasesV2DataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppRelationshipsInAppPurchasesV2DataItemType value)
        {
            return value switch
            {
                AppRelationshipsInAppPurchasesV2DataItemType.InAppPurchases => "inAppPurchases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppRelationshipsInAppPurchasesV2DataItemType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchases" => AppRelationshipsInAppPurchasesV2DataItemType.InAppPurchases,
                _ => null,
            };
        }
    }
}