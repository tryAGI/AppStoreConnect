
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterDetailsClassicMatchmakingRequestsGetMetricsSortItem
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
    public static class GameCenterDetailsClassicMatchmakingRequestsGetMetricsSortItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsClassicMatchmakingRequestsGetMetricsSortItem value)
        {
            return value switch
            {
                GameCenterDetailsClassicMatchmakingRequestsGetMetricsSortItem.MinusaverageSecondsInQueue => "-averageSecondsInQueue",
                GameCenterDetailsClassicMatchmakingRequestsGetMetricsSortItem.Minuscount => "-count",
                GameCenterDetailsClassicMatchmakingRequestsGetMetricsSortItem.Minusp50SecondsInQueue => "-p50SecondsInQueue",
                GameCenterDetailsClassicMatchmakingRequestsGetMetricsSortItem.Minusp95SecondsInQueue => "-p95SecondsInQueue",
                GameCenterDetailsClassicMatchmakingRequestsGetMetricsSortItem.AverageSecondsInQueue => "averageSecondsInQueue",
                GameCenterDetailsClassicMatchmakingRequestsGetMetricsSortItem.Count => "count",
                GameCenterDetailsClassicMatchmakingRequestsGetMetricsSortItem.P50SecondsInQueue => "p50SecondsInQueue",
                GameCenterDetailsClassicMatchmakingRequestsGetMetricsSortItem.P95SecondsInQueue => "p95SecondsInQueue",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsClassicMatchmakingRequestsGetMetricsSortItem? ToEnum(string value)
        {
            return value switch
            {
                "-averageSecondsInQueue" => GameCenterDetailsClassicMatchmakingRequestsGetMetricsSortItem.MinusaverageSecondsInQueue,
                "-count" => GameCenterDetailsClassicMatchmakingRequestsGetMetricsSortItem.Minuscount,
                "-p50SecondsInQueue" => GameCenterDetailsClassicMatchmakingRequestsGetMetricsSortItem.Minusp50SecondsInQueue,
                "-p95SecondsInQueue" => GameCenterDetailsClassicMatchmakingRequestsGetMetricsSortItem.Minusp95SecondsInQueue,
                "averageSecondsInQueue" => GameCenterDetailsClassicMatchmakingRequestsGetMetricsSortItem.AverageSecondsInQueue,
                "count" => GameCenterDetailsClassicMatchmakingRequestsGetMetricsSortItem.Count,
                "p50SecondsInQueue" => GameCenterDetailsClassicMatchmakingRequestsGetMetricsSortItem.P50SecondsInQueue,
                "p95SecondsInQueue" => GameCenterDetailsClassicMatchmakingRequestsGetMetricsSortItem.P95SecondsInQueue,
                _ => null,
            };
        }
    }
}