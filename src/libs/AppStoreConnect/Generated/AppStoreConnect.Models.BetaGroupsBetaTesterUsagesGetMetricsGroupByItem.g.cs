
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaGroupsBetaTesterUsagesGetMetricsGroupByItem
    {
        /// <summary>
        /// 
        /// </summary>
        BetaTesters,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaGroupsBetaTesterUsagesGetMetricsGroupByItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaGroupsBetaTesterUsagesGetMetricsGroupByItem value)
        {
            return value switch
            {
                BetaGroupsBetaTesterUsagesGetMetricsGroupByItem.BetaTesters => "betaTesters",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaGroupsBetaTesterUsagesGetMetricsGroupByItem? ToEnum(string value)
        {
            return value switch
            {
                "betaTesters" => BetaGroupsBetaTesterUsagesGetMetricsGroupByItem.BetaTesters,
                _ => null,
            };
        }
    }
}