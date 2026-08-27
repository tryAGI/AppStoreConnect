
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchasePriceScheduleCreateRequestDataRelationshipsInAppPurchaseDataType
    {
        /// <summary>
        /// 
        /// </summary>
        InAppPurchases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchasePriceScheduleCreateRequestDataRelationshipsInAppPurchaseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasePriceScheduleCreateRequestDataRelationshipsInAppPurchaseDataType value)
        {
            return value switch
            {
                InAppPurchasePriceScheduleCreateRequestDataRelationshipsInAppPurchaseDataType.InAppPurchases => "inAppPurchases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasePriceScheduleCreateRequestDataRelationshipsInAppPurchaseDataType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchases" => InAppPurchasePriceScheduleCreateRequestDataRelationshipsInAppPurchaseDataType.InAppPurchases,
                _ => null,
            };
        }
    }
}