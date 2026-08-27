
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaTestersBetaTesterUsagesGetMetricsPeriod
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
    public static class BetaTestersBetaTesterUsagesGetMetricsPeriodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaTestersBetaTesterUsagesGetMetricsPeriod value)
        {
            return value switch
            {
                BetaTestersBetaTesterUsagesGetMetricsPeriod.P30d => "P30D",
                BetaTestersBetaTesterUsagesGetMetricsPeriod.P365d => "P365D",
                BetaTestersBetaTesterUsagesGetMetricsPeriod.P7d => "P7D",
                BetaTestersBetaTesterUsagesGetMetricsPeriod.P90d => "P90D",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaTestersBetaTesterUsagesGetMetricsPeriod? ToEnum(string value)
        {
            return value switch
            {
                "P30D" => BetaTestersBetaTesterUsagesGetMetricsPeriod.P30d,
                "P365D" => BetaTestersBetaTesterUsagesGetMetricsPeriod.P365d,
                "P7D" => BetaTestersBetaTesterUsagesGetMetricsPeriod.P7d,
                "P90D" => BetaTestersBetaTesterUsagesGetMetricsPeriod.P90d,
                _ => null,
            };
        }
    }
}