
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsSortItem
    {
        /// <summary>
        ///
        /// </summary>
        MinusaverageResult,
        /// <summary>
        ///
        /// </summary>
        Minuscount,
        /// <summary>
        ///
        /// </summary>
        Minusp50Result,
        /// <summary>
        ///
        /// </summary>
        Minusp95Result,
        /// <summary>
        ///
        /// </summary>
        AverageResult,
        /// <summary>
        ///
        /// </summary>
        Count,
        /// <summary>
        ///
        /// </summary>
        P50Result,
        /// <summary>
        ///
        /// </summary>
        P95Result,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsSortItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsSortItem value)
        {
            return value switch
            {
                GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsSortItem.MinusaverageResult => "-averageResult",
                GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsSortItem.Minuscount => "-count",
                GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsSortItem.Minusp50Result => "-p50Result",
                GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsSortItem.Minusp95Result => "-p95Result",
                GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsSortItem.AverageResult => "averageResult",
                GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsSortItem.Count => "count",
                GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsSortItem.P50Result => "p50Result",
                GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsSortItem.P95Result => "p95Result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsSortItem? ToEnum(string value)
        {
            return value switch
            {
                "-averageResult" => GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsSortItem.MinusaverageResult,
                "-count" => GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsSortItem.Minuscount,
                "-p50Result" => GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsSortItem.Minusp50Result,
                "-p95Result" => GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsSortItem.Minusp95Result,
                "averageResult" => GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsSortItem.AverageResult,
                "count" => GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsSortItem.Count,
                "p50Result" => GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsSortItem.P50Result,
                "p95Result" => GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsSortItem.P95Result,
                _ => null,
            };
        }
    }
}