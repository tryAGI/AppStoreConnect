
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchasePriceScheduleCreateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        InAppPurchasePriceSchedules,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchasePriceScheduleCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasePriceScheduleCreateRequestDataType value)
        {
            return value switch
            {
                InAppPurchasePriceScheduleCreateRequestDataType.InAppPurchasePriceSchedules => "inAppPurchasePriceSchedules",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasePriceScheduleCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchasePriceSchedules" => InAppPurchasePriceScheduleCreateRequestDataType.InAppPurchasePriceSchedules,
                _ => null,
            };
        }
    }
}