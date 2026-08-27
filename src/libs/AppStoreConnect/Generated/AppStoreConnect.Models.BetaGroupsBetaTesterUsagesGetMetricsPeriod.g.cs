
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaGroupsBetaTesterUsagesGetMetricsPeriod
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
    public static class BetaGroupsBetaTesterUsagesGetMetricsPeriodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaGroupsBetaTesterUsagesGetMetricsPeriod value)
        {
            return value switch
            {
                BetaGroupsBetaTesterUsagesGetMetricsPeriod.P30d => "P30D",
                BetaGroupsBetaTesterUsagesGetMetricsPeriod.P365d => "P365D",
                BetaGroupsBetaTesterUsagesGetMetricsPeriod.P7d => "P7D",
                BetaGroupsBetaTesterUsagesGetMetricsPeriod.P90d => "P90D",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaGroupsBetaTesterUsagesGetMetricsPeriod? ToEnum(string value)
        {
            return value switch
            {
                "P30D" => BetaGroupsBetaTesterUsagesGetMetricsPeriod.P30d,
                "P365D" => BetaGroupsBetaTesterUsagesGetMetricsPeriod.P365d,
                "P7D" => BetaGroupsBetaTesterUsagesGetMetricsPeriod.P7d,
                "P90D" => BetaGroupsBetaTesterUsagesGetMetricsPeriod.P90d,
                _ => null,
            };
        }
    }
}