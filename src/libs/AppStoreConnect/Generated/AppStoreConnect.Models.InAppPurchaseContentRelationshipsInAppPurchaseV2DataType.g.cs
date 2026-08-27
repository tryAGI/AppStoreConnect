
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchaseContentRelationshipsInAppPurchaseV2DataType
    {
        /// <summary>
        /// 
        /// </summary>
        InAppPurchases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseContentRelationshipsInAppPurchaseV2DataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseContentRelationshipsInAppPurchaseV2DataType value)
        {
            return value switch
            {
                InAppPurchaseContentRelationshipsInAppPurchaseV2DataType.InAppPurchases => "inAppPurchases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseContentRelationshipsInAppPurchaseV2DataType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchases" => InAppPurchaseContentRelationshipsInAppPurchaseV2DataType.InAppPurchases,
                _ => null,
            };
        }
    }
}