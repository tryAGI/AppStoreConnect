
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsGranularity
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
    public static class GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsGranularityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsGranularity value)
        {
            return value switch
            {
                GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsGranularity.P1d => "P1D",
                GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsGranularity.Pt15m => "PT15M",
                GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsGranularity.Pt1h => "PT1H",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsGranularity? ToEnum(string value)
        {
            return value switch
            {
                "P1D" => GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsGranularity.P1d,
                "PT15M" => GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsGranularity.Pt15m,
                "PT1H" => GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsGranularity.Pt1h,
                _ => null,
            };
        }
    }
}