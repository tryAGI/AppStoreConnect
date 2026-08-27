
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsGroupByItem
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterMatchmakingQueue,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsGroupByItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsGroupByItem value)
        {
            return value switch
            {
                GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsGroupByItem.GameCenterMatchmakingQueue => "gameCenterMatchmakingQueue",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsGroupByItem? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterMatchmakingQueue" => GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsGroupByItem.GameCenterMatchmakingQueue,
                _ => null,
            };
        }
    }
}