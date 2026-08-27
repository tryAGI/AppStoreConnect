
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppPerfPowerMetricsLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        PerfPowerMetrics,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppPerfPowerMetricsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPerfPowerMetricsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                AppPerfPowerMetricsLinkagesResponseDataItemType.PerfPowerMetrics => "perfPowerMetrics",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPerfPowerMetricsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "perfPowerMetrics" => AppPerfPowerMetricsLinkagesResponseDataItemType.PerfPowerMetrics,
                _ => null,
            };
        }
    }
}