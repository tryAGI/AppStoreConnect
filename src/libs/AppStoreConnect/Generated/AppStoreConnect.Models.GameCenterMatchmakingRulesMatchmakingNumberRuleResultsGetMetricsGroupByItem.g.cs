
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsGroupByItem
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterMatchmakingQueue,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsGroupByItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsGroupByItem value)
        {
            return value switch
            {
                GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsGroupByItem.GameCenterMatchmakingQueue => "gameCenterMatchmakingQueue",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsGroupByItem? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterMatchmakingQueue" => GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsGroupByItem.GameCenterMatchmakingQueue,
                _ => null,
            };
        }
    }
}