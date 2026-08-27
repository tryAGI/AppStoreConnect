
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchaseImageCreateRequestDataRelationshipsInAppPurchaseDataType
    {
        /// <summary>
        /// 
        /// </summary>
        InAppPurchases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseImageCreateRequestDataRelationshipsInAppPurchaseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseImageCreateRequestDataRelationshipsInAppPurchaseDataType value)
        {
            return value switch
            {
                InAppPurchaseImageCreateRequestDataRelationshipsInAppPurchaseDataType.InAppPurchases => "inAppPurchases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseImageCreateRequestDataRelationshipsInAppPurchaseDataType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchases" => InAppPurchaseImageCreateRequestDataRelationshipsInAppPurchaseDataType.InAppPurchases,
                _ => null,
            };
        }
    }
}