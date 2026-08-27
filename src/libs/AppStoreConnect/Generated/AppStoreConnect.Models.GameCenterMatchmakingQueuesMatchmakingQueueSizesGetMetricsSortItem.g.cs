
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterMatchmakingQueuesMatchmakingQueueSizesGetMetricsSortItem
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
    public static class GameCenterMatchmakingQueuesMatchmakingQueueSizesGetMetricsSortItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingQueuesMatchmakingQueueSizesGetMetricsSortItem value)
        {
            return value switch
            {
                GameCenterMatchmakingQueuesMatchmakingQueueSizesGetMetricsSortItem.MinusaverageNumberOfRequests => "-averageNumberOfRequests",
                GameCenterMatchmakingQueuesMatchmakingQueueSizesGetMetricsSortItem.Minuscount => "-count",
                GameCenterMatchmakingQueuesMatchmakingQueueSizesGetMetricsSortItem.Minusp50NumberOfRequests => "-p50NumberOfRequests",
                GameCenterMatchmakingQueuesMatchmakingQueueSizesGetMetricsSortItem.Minusp95NumberOfRequests => "-p95NumberOfRequests",
                GameCenterMatchmakingQueuesMatchmakingQueueSizesGetMetricsSortItem.AverageNumberOfRequests => "averageNumberOfRequests",
                GameCenterMatchmakingQueuesMatchmakingQueueSizesGetMetricsSortItem.Count => "count",
                GameCenterMatchmakingQueuesMatchmakingQueueSizesGetMetricsSortItem.P50NumberOfRequests => "p50NumberOfRequests",
                GameCenterMatchmakingQueuesMatchmakingQueueSizesGetMetricsSortItem.P95NumberOfRequests => "p95NumberOfRequests",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingQueuesMatchmakingQueueSizesGetMetricsSortItem? ToEnum(string value)
        {
            return value switch
            {
                "-averageNumberOfRequests" => GameCenterMatchmakingQueuesMatchmakingQueueSizesGetMetricsSortItem.MinusaverageNumberOfRequests,
                "-count" => GameCenterMatchmakingQueuesMatchmakingQueueSizesGetMetricsSortItem.Minuscount,
                "-p50NumberOfRequests" => GameCenterMatchmakingQueuesMatchmakingQueueSizesGetMetricsSortItem.Minusp50NumberOfRequests,
                "-p95NumberOfRequests" => GameCenterMatchmakingQueuesMatchmakingQueueSizesGetMetricsSortItem.Minusp95NumberOfRequests,
                "averageNumberOfRequests" => GameCenterMatchmakingQueuesMatchmakingQueueSizesGetMetricsSortItem.AverageNumberOfRequests,
                "count" => GameCenterMatchmakingQueuesMatchmakingQueueSizesGetMetricsSortItem.Count,
                "p50NumberOfRequests" => GameCenterMatchmakingQueuesMatchmakingQueueSizesGetMetricsSortItem.P50NumberOfRequests,
                "p95NumberOfRequests" => GameCenterMatchmakingQueuesMatchmakingQueueSizesGetMetricsSortItem.P95NumberOfRequests,
                _ => null,
            };
        }
    }
}