
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsSortItem
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
    public static class GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsSortItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsSortItem value)
        {
            return value switch
            {
                GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsSortItem.Minuscount => "-count",
                GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsSortItem.Count => "count",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsSortItem? ToEnum(string value)
        {
            return value switch
            {
                "-count" => GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsSortItem.Minuscount,
                "count" => GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsSortItem.Count,
                _ => null,
            };
        }
    }
}