
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseV2RelationshipsVersionsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        InAppPurchaseVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseV2RelationshipsVersionsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseV2RelationshipsVersionsDataItemType value)
        {
            return value switch
            {
                InAppPurchaseV2RelationshipsVersionsDataItemType.InAppPurchaseVersions => "inAppPurchaseVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseV2RelationshipsVersionsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchaseVersions" => InAppPurchaseV2RelationshipsVersionsDataItemType.InAppPurchaseVersions,
                _ => null,
            };
        }
    }
}