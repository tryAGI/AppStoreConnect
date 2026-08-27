
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchaseV2RelationshipsIapPriceScheduleDataType
    {
        /// <summary>
        /// 
        /// </summary>
        InAppPurchasePriceSchedules,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseV2RelationshipsIapPriceScheduleDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseV2RelationshipsIapPriceScheduleDataType value)
        {
            return value switch
            {
                InAppPurchaseV2RelationshipsIapPriceScheduleDataType.InAppPurchasePriceSchedules => "inAppPurchasePriceSchedules",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseV2RelationshipsIapPriceScheduleDataType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchasePriceSchedules" => InAppPurchaseV2RelationshipsIapPriceScheduleDataType.InAppPurchasePriceSchedules,
                _ => null,
            };
        }
    }
}