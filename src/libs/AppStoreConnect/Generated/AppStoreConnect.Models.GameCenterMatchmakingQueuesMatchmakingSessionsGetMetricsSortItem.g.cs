
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterMatchmakingQueuesMatchmakingSessionsGetMetricsSortItem
    {
        /// <summary>
        /// 
        /// </summary>
        MinusaveragePlayerCount,
        /// <summary>
        /// 
        /// </summary>
        Minuscount,
        /// <summary>
        /// 
        /// </summary>
        Minusp50PlayerCount,
        /// <summary>
        /// 
        /// </summary>
        Minusp95PlayerCount,
        /// <summary>
        /// 
        /// </summary>
        AveragePlayerCount,
        /// <summary>
        /// 
        /// </summary>
        Count,
        /// <summary>
        /// 
        /// </summary>
        P50PlayerCount,
        /// <summary>
        /// 
        /// </summary>
        P95PlayerCount,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterMatchmakingQueuesMatchmakingSessionsGetMetricsSortItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingQueuesMatchmakingSessionsGetMetricsSortItem value)
        {
            return value switch
            {
                GameCenterMatchmakingQueuesMatchmakingSessionsGetMetricsSortItem.MinusaveragePlayerCount => "-averagePlayerCount",
                GameCenterMatchmakingQueuesMatchmakingSessionsGetMetricsSortItem.Minuscount => "-count",
                GameCenterMatchmakingQueuesMatchmakingSessionsGetMetricsSortItem.Minusp50PlayerCount => "-p50PlayerCount",
                GameCenterMatchmakingQueuesMatchmakingSessionsGetMetricsSortItem.Minusp95PlayerCount => "-p95PlayerCount",
                GameCenterMatchmakingQueuesMatchmakingSessionsGetMetricsSortItem.AveragePlayerCount => "averagePlayerCount",
                GameCenterMatchmakingQueuesMatchmakingSessionsGetMetricsSortItem.Count => "count",
                GameCenterMatchmakingQueuesMatchmakingSessionsGetMetricsSortItem.P50PlayerCount => "p50PlayerCount",
                GameCenterMatchmakingQueuesMatchmakingSessionsGetMetricsSortItem.P95PlayerCount => "p95PlayerCount",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingQueuesMatchmakingSessionsGetMetricsSortItem? ToEnum(string value)
        {
            return value switch
            {
                "-averagePlayerCount" => GameCenterMatchmakingQueuesMatchmakingSessionsGetMetricsSortItem.MinusaveragePlayerCount,
                "-count" => GameCenterMatchmakingQueuesMatchmakingSessionsGetMetricsSortItem.Minuscount,
                "-p50PlayerCount" => GameCenterMatchmakingQueuesMatchmakingSessionsGetMetricsSortItem.Minusp50PlayerCount,
                "-p95PlayerCount" => GameCenterMatchmakingQueuesMatchmakingSessionsGetMetricsSortItem.Minusp95PlayerCount,
                "averagePlayerCount" => GameCenterMatchmakingQueuesMatchmakingSessionsGetMetricsSortItem.AveragePlayerCount,
                "count" => GameCenterMatchmakingQueuesMatchmakingSessionsGetMetricsSortItem.Count,
                "p50PlayerCount" => GameCenterMatchmakingQueuesMatchmakingSessionsGetMetricsSortItem.P50PlayerCount,
                "p95PlayerCount" => GameCenterMatchmakingQueuesMatchmakingSessionsGetMetricsSortItem.P95PlayerCount,
                _ => null,
            };
        }
    }
}