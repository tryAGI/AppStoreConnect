
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchasePriceScheduleType
    {
        /// <summary>
        ///
        /// </summary>
        InAppPurchasePriceSchedules,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchasePriceScheduleTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasePriceScheduleType value)
        {
            return value switch
            {
                InAppPurchasePriceScheduleType.InAppPurchasePriceSchedules => "inAppPurchasePriceSchedules",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasePriceScheduleType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchasePriceSchedules" => InAppPurchasePriceScheduleType.InAppPurchasePriceSchedules,
                _ => null,
            };
        }
    }
}