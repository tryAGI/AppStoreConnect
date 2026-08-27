
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsBetaTesterUsagesGetMetricsPeriod
    {
        /// <summary>
        /// 
        /// </summary>
        P30d,
        /// <summary>
        /// 
        /// </summary>
        P365d,
        /// <summary>
        /// 
        /// </summary>
        P7d,
        /// <summary>
        /// 
        /// </summary>
        P90d,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsBetaTesterUsagesGetMetricsPeriodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsBetaTesterUsagesGetMetricsPeriod value)
        {
            return value switch
            {
                AppsBetaTesterUsagesGetMetricsPeriod.P30d => "P30D",
                AppsBetaTesterUsagesGetMetricsPeriod.P365d => "P365D",
                AppsBetaTesterUsagesGetMetricsPeriod.P7d => "P7D",
                AppsBetaTesterUsagesGetMetricsPeriod.P90d => "P90D",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsBetaTesterUsagesGetMetricsPeriod? ToEnum(string value)
        {
            return value switch
            {
                "P30D" => AppsBetaTesterUsagesGetMetricsPeriod.P30d,
                "P365D" => AppsBetaTesterUsagesGetMetricsPeriod.P365d,
                "P7D" => AppsBetaTesterUsagesGetMetricsPeriod.P7d,
                "P90D" => AppsBetaTesterUsagesGetMetricsPeriod.P90d,
                _ => null,
            };
        }
    }
}