
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsGranularity
    {
        /// <summary>
        ///
        /// </summary>
        P1d,
        /// <summary>
        ///
        /// </summary>
        Pt15m,
        /// <summary>
        ///
        /// </summary>
        Pt1h,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsGranularityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsGranularity value)
        {
            return value switch
            {
                GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsGranularity.P1d => "P1D",
                GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsGranularity.Pt15m => "PT15M",
                GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsGranularity.Pt1h => "PT1H",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsGranularity? ToEnum(string value)
        {
            return value switch
            {
                "P1D" => GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsGranularity.P1d,
                "PT15M" => GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsGranularity.Pt15m,
                "PT1H" => GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsGranularity.Pt1h,
                _ => null,
            };
        }
    }
}