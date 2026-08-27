
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsBetaTesterUsagesGetMetricsGroupByItem
    {
        /// <summary>
        /// 
        /// </summary>
        BetaTesters,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsBetaTesterUsagesGetMetricsGroupByItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsBetaTesterUsagesGetMetricsGroupByItem value)
        {
            return value switch
            {
                AppsBetaTesterUsagesGetMetricsGroupByItem.BetaTesters => "betaTesters",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsBetaTesterUsagesGetMetricsGroupByItem? ToEnum(string value)
        {
            return value switch
            {
                "betaTesters" => AppsBetaTesterUsagesGetMetricsGroupByItem.BetaTesters,
                _ => null,
            };
        }
    }
}