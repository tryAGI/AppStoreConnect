
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterMatchmakingQueuesExperimentMatchmakingQueueSizesGetMetricsSortItem
    {
        /// <summary>
        ///
        /// </summary>
        MinusaverageNumberOfRequests,
        /// <summary>
        ///
        /// </summary>
        Minuscount,
        /// <summary>
        ///
        /// </summary>
        Minusp50NumberOfRequests,
        /// <summary>
        ///
        /// </summary>
        Minusp95NumberOfRequests,
        /// <summary>
        ///
        /// </summary>
        AverageNumberOfRequests,
        /// <summary>
        ///
        /// </summary>
        Count,
        /// <summary>
        ///
        /// </summary>
        P50NumberOfRequests,
        /// <summary>
        ///
        /// </summary>
        P95NumberOfRequests,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterMatchmakingQueuesExperimentMatchmakingQueueSizesGetMetricsSortItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingQueuesExperimentMatchmakingQueueSizesGetMetricsSortItem value)
        {
            return value switch
            {
                GameCenterMatchmakingQueuesExperimentMatchmakingQueueSizesGetMetricsSortItem.MinusaverageNumberOfRequests => "-averageNumberOfRequests",
                GameCenterMatchmakingQueuesExperimentMatchmakingQueueSizesGetMetricsSortItem.Minuscount => "-count",
                GameCenterMatchmakingQueuesExperimentMatchmakingQueueSizesGetMetricsSortItem.Minusp50NumberOfRequests => "-p50NumberOfRequests",
                GameCenterMatchmakingQueuesExperimentMatchmakingQueueSizesGetMetricsSortItem.Minusp95NumberOfRequests => "-p95NumberOfRequests",
                GameCenterMatchmakingQueuesExperimentMatchmakingQueueSizesGetMetricsSortItem.AverageNumberOfRequests => "averageNumberOfRequests",
                GameCenterMatchmakingQueuesExperimentMatchmakingQueueSizesGetMetricsSortItem.Count => "count",
                GameCenterMatchmakingQueuesExperimentMatchmakingQueueSizesGetMetricsSortItem.P50NumberOfRequests => "p50NumberOfRequests",
                GameCenterMatchmakingQueuesExperimentMatchmakingQueueSizesGetMetricsSortItem.P95NumberOfRequests => "p95NumberOfRequests",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingQueuesExperimentMatchmakingQueueSizesGetMetricsSortItem? ToEnum(string value)
        {
            return value switch
            {
                "-averageNumberOfRequests" => GameCenterMatchmakingQueuesExperimentMatchmakingQueueSizesGetMetricsSortItem.MinusaverageNumberOfRequests,
                "-count" => GameCenterMatchmakingQueuesExperimentMatchmakingQueueSizesGetMetricsSortItem.Minuscount,
                "-p50NumberOfRequests" => GameCenterMatchmakingQueuesExperimentMatchmakingQueueSizesGetMetricsSortItem.Minusp50NumberOfRequests,
                "-p95NumberOfRequests" => GameCenterMatchmakingQueuesExperimentMatchmakingQueueSizesGetMetricsSortItem.Minusp95NumberOfRequests,
                "averageNumberOfRequests" => GameCenterMatchmakingQueuesExperimentMatchmakingQueueSizesGetMetricsSortItem.AverageNumberOfRequests,
                "count" => GameCenterMatchmakingQueuesExperimentMatchmakingQueueSizesGetMetricsSortItem.Count,
                "p50NumberOfRequests" => GameCenterMatchmakingQueuesExperimentMatchmakingQueueSizesGetMetricsSortItem.P50NumberOfRequests,
                "p95NumberOfRequests" => GameCenterMatchmakingQueuesExperimentMatchmakingQueueSizesGetMetricsSortItem.P95NumberOfRequests,
                _ => null,
            };
        }
    }
}