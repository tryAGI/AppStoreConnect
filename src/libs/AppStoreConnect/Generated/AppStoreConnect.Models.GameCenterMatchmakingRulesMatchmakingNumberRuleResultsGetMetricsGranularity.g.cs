
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsGranularity
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
    public static class GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsGranularityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsGranularity value)
        {
            return value switch
            {
                GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsGranularity.P1d => "P1D",
                GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsGranularity.Pt15m => "PT15M",
                GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsGranularity.Pt1h => "PT1H",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsGranularity? ToEnum(string value)
        {
            return value switch
            {
                "P1D" => GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsGranularity.P1d,
                "PT15M" => GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsGranularity.Pt15m,
                "PT1H" => GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsGranularity.Pt1h,
                _ => null,
            };
        }
    }
}