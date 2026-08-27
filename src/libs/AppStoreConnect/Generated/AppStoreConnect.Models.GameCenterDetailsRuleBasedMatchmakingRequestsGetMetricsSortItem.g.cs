
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsSortItem
    {
        /// <summary>
        ///
        /// </summary>
        MinusaverageSecondsInQueue,
        /// <summary>
        ///
        /// </summary>
        Minuscount,
        /// <summary>
        ///
        /// </summary>
        Minusp50SecondsInQueue,
        /// <summary>
        ///
        /// </summary>
        Minusp95SecondsInQueue,
        /// <summary>
        ///
        /// </summary>
        AverageSecondsInQueue,
        /// <summary>
        ///
        /// </summary>
        Count,
        /// <summary>
        ///
        /// </summary>
        P50SecondsInQueue,
        /// <summary>
        ///
        /// </summary>
        P95SecondsInQueue,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsSortItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsSortItem value)
        {
            return value switch
            {
                GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsSortItem.MinusaverageSecondsInQueue => "-averageSecondsInQueue",
                GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsSortItem.Minuscount => "-count",
                GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsSortItem.Minusp50SecondsInQueue => "-p50SecondsInQueue",
                GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsSortItem.Minusp95SecondsInQueue => "-p95SecondsInQueue",
                GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsSortItem.AverageSecondsInQueue => "averageSecondsInQueue",
                GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsSortItem.Count => "count",
                GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsSortItem.P50SecondsInQueue => "p50SecondsInQueue",
                GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsSortItem.P95SecondsInQueue => "p95SecondsInQueue",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsSortItem? ToEnum(string value)
        {
            return value switch
            {
                "-averageSecondsInQueue" => GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsSortItem.MinusaverageSecondsInQueue,
                "-count" => GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsSortItem.Minuscount,
                "-p50SecondsInQueue" => GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsSortItem.Minusp50SecondsInQueue,
                "-p95SecondsInQueue" => GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsSortItem.Minusp95SecondsInQueue,
                "averageSecondsInQueue" => GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsSortItem.AverageSecondsInQueue,
                "count" => GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsSortItem.Count,
                "p50SecondsInQueue" => GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsSortItem.P50SecondsInQueue,
                "p95SecondsInQueue" => GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsSortItem.P95SecondsInQueue,
                _ => null,
            };
        }
    }
}