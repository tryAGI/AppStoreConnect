
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppPriceScheduleType
    {
        /// <summary>
        /// 
        /// </summary>
        AppPriceSchedules,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppPriceScheduleTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPriceScheduleType value)
        {
            return value switch
            {
                AppPriceScheduleType.AppPriceSchedules => "appPriceSchedules",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPriceScheduleType? ToEnum(string value)
        {
            return value switch
            {
                "appPriceSchedules" => AppPriceScheduleType.AppPriceSchedules,
                _ => null,
            };
        }
    }
}