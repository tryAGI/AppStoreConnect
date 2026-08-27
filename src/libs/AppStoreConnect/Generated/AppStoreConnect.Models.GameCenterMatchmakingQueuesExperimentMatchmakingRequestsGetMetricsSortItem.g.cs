
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsSortItem
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
    public static class GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsSortItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsSortItem value)
        {
            return value switch
            {
                GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsSortItem.MinusaverageSecondsInQueue => "-averageSecondsInQueue",
                GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsSortItem.Minuscount => "-count",
                GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsSortItem.Minusp50SecondsInQueue => "-p50SecondsInQueue",
                GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsSortItem.Minusp95SecondsInQueue => "-p95SecondsInQueue",
                GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsSortItem.AverageSecondsInQueue => "averageSecondsInQueue",
                GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsSortItem.Count => "count",
                GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsSortItem.P50SecondsInQueue => "p50SecondsInQueue",
                GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsSortItem.P95SecondsInQueue => "p95SecondsInQueue",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsSortItem? ToEnum(string value)
        {
            return value switch
            {
                "-averageSecondsInQueue" => GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsSortItem.MinusaverageSecondsInQueue,
                "-count" => GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsSortItem.Minuscount,
                "-p50SecondsInQueue" => GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsSortItem.Minusp50SecondsInQueue,
                "-p95SecondsInQueue" => GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsSortItem.Minusp95SecondsInQueue,
                "averageSecondsInQueue" => GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsSortItem.AverageSecondsInQueue,
                "count" => GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsSortItem.Count,
                "p50SecondsInQueue" => GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsSortItem.P50SecondsInQueue,
                "p95SecondsInQueue" => GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsSortItem.P95SecondsInQueue,
                _ => null,
            };
        }
    }
}