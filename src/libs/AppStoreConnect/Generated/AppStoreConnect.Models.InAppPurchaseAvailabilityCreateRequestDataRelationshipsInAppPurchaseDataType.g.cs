
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchaseAvailabilityCreateRequestDataRelationshipsInAppPurchaseDataType
    {
        /// <summary>
        /// 
        /// </summary>
        InAppPurchases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseAvailabilityCreateRequestDataRelationshipsInAppPurchaseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseAvailabilityCreateRequestDataRelationshipsInAppPurchaseDataType value)
        {
            return value switch
            {
                InAppPurchaseAvailabilityCreateRequestDataRelationshipsInAppPurchaseDataType.InAppPurchases => "inAppPurchases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseAvailabilityCreateRequestDataRelationshipsInAppPurchaseDataType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchases" => InAppPurchaseAvailabilityCreateRequestDataRelationshipsInAppPurchaseDataType.InAppPurchases,
                _ => null,
            };
        }
    }
}