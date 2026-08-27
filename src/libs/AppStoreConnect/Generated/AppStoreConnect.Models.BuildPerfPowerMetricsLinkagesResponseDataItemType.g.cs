
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildPerfPowerMetricsLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        PerfPowerMetrics,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildPerfPowerMetricsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildPerfPowerMetricsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                BuildPerfPowerMetricsLinkagesResponseDataItemType.PerfPowerMetrics => "perfPowerMetrics",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildPerfPowerMetricsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "perfPowerMetrics" => BuildPerfPowerMetricsLinkagesResponseDataItemType.PerfPowerMetrics,
                _ => null,
            };
        }
    }
}