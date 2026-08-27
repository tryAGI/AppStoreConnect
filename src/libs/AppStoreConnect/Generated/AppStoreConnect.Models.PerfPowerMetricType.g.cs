
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum PerfPowerMetricType
    {
        /// <summary>
        ///
        /// </summary>
        PerfPowerMetrics,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PerfPowerMetricTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PerfPowerMetricType value)
        {
            return value switch
            {
                PerfPowerMetricType.PerfPowerMetrics => "perfPowerMetrics",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PerfPowerMetricType? ToEnum(string value)
        {
            return value switch
            {
                "perfPowerMetrics" => PerfPowerMetricType.PerfPowerMetrics,
                _ => null,
            };
        }
    }
}