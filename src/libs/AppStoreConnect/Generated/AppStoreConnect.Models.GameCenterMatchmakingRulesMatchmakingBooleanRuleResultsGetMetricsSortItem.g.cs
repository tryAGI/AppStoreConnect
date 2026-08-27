
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetricsSortItem
    {
        /// <summary>
        /// 
        /// </summary>
        Minuscount,
        /// <summary>
        /// 
        /// </summary>
        Count,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetricsSortItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetricsSortItem value)
        {
            return value switch
            {
                GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetricsSortItem.Minuscount => "-count",
                GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetricsSortItem.Count => "count",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetricsSortItem? ToEnum(string value)
        {
            return value switch
            {
                "-count" => GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetricsSortItem.Minuscount,
                "count" => GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetricsSortItem.Count,
                _ => null,
            };
        }
    }
}