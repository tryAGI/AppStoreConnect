
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetricsGroupByItem
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterMatchmakingQueue,
        /// <summary>
        /// 
        /// </summary>
        Result,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetricsGroupByItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetricsGroupByItem value)
        {
            return value switch
            {
                GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetricsGroupByItem.GameCenterMatchmakingQueue => "gameCenterMatchmakingQueue",
                GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetricsGroupByItem.Result => "result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetricsGroupByItem? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterMatchmakingQueue" => GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetricsGroupByItem.GameCenterMatchmakingQueue,
                "result" => GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetricsGroupByItem.Result,
                _ => null,
            };
        }
    }
}