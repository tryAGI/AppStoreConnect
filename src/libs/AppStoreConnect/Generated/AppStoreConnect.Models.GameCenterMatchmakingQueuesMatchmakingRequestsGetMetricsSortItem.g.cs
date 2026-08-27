
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsSortItem
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
    public static class GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsSortItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsSortItem value)
        {
            return value switch
            {
                GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsSortItem.MinusaverageSecondsInQueue => "-averageSecondsInQueue",
                GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsSortItem.Minuscount => "-count",
                GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsSortItem.Minusp50SecondsInQueue => "-p50SecondsInQueue",
                GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsSortItem.Minusp95SecondsInQueue => "-p95SecondsInQueue",
                GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsSortItem.AverageSecondsInQueue => "averageSecondsInQueue",
                GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsSortItem.Count => "count",
                GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsSortItem.P50SecondsInQueue => "p50SecondsInQueue",
                GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsSortItem.P95SecondsInQueue => "p95SecondsInQueue",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsSortItem? ToEnum(string value)
        {
            return value switch
            {
                "-averageSecondsInQueue" => GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsSortItem.MinusaverageSecondsInQueue,
                "-count" => GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsSortItem.Minuscount,
                "-p50SecondsInQueue" => GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsSortItem.Minusp50SecondsInQueue,
                "-p95SecondsInQueue" => GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsSortItem.Minusp95SecondsInQueue,
                "averageSecondsInQueue" => GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsSortItem.AverageSecondsInQueue,
                "count" => GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsSortItem.Count,
                "p50SecondsInQueue" => GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsSortItem.P50SecondsInQueue,
                "p95SecondsInQueue" => GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsSortItem.P95SecondsInQueue,
                _ => null,
            };
        }
    }
}