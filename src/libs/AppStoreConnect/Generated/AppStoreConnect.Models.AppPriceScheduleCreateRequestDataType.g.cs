
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppPriceScheduleCreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppPriceSchedules,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppPriceScheduleCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPriceScheduleCreateRequestDataType value)
        {
            return value switch
            {
                AppPriceScheduleCreateRequestDataType.AppPriceSchedules => "appPriceSchedules",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPriceScheduleCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "appPriceSchedules" => AppPriceScheduleCreateRequestDataType.AppPriceSchedules,
                _ => null,
            };
        }
    }
}