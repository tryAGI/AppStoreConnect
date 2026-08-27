
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseVersionCreateRequestDataRelationshipsInAppPurchaseDataType
    {
        /// <summary>
        ///
        /// </summary>
        InAppPurchases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseVersionCreateRequestDataRelationshipsInAppPurchaseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseVersionCreateRequestDataRelationshipsInAppPurchaseDataType value)
        {
            return value switch
            {
                InAppPurchaseVersionCreateRequestDataRelationshipsInAppPurchaseDataType.InAppPurchases => "inAppPurchases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseVersionCreateRequestDataRelationshipsInAppPurchaseDataType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchases" => InAppPurchaseVersionCreateRequestDataRelationshipsInAppPurchaseDataType.InAppPurchases,
                _ => null,
            };
        }
    }
}