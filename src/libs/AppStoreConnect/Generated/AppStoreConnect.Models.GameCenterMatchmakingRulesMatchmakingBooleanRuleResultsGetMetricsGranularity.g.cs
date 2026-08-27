
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetricsGranularity
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
    public static class GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetricsGranularityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetricsGranularity value)
        {
            return value switch
            {
                GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetricsGranularity.P1d => "P1D",
                GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetricsGranularity.Pt15m => "PT15M",
                GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetricsGranularity.Pt1h => "PT1H",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetricsGranularity? ToEnum(string value)
        {
            return value switch
            {
                "P1D" => GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetricsGranularity.P1d,
                "PT15M" => GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetricsGranularity.Pt15m,
                "PT1H" => GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetricsGranularity.Pt1h,
                _ => null,
            };
        }
    }
}