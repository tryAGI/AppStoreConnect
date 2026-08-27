
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseRelationshipsAppsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        Apps,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseRelationshipsAppsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseRelationshipsAppsDataItemType value)
        {
            return value switch
            {
                InAppPurchaseRelationshipsAppsDataItemType.Apps => "apps",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseRelationshipsAppsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "apps" => InAppPurchaseRelationshipsAppsDataItemType.Apps,
                _ => null,
            };
        }
    }
}