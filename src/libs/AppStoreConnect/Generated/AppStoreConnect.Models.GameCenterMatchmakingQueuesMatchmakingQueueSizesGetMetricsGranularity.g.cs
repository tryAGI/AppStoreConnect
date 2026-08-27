
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterMatchmakingQueuesMatchmakingQueueSizesGetMetricsGranularity
    {
        /// <summary>
        ///
        /// </summary>
        P1d,
        /// <summary>
        ///
        /// </summary>
        Pt15m,
        /// <summary>
        ///
        /// </summary>
        Pt1h,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterMatchmakingQueuesMatchmakingQueueSizesGetMetricsGranularityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingQueuesMatchmakingQueueSizesGetMetricsGranularity value)
        {
            return value switch
            {
                GameCenterMatchmakingQueuesMatchmakingQueueSizesGetMetricsGranularity.P1d => "P1D",
                GameCenterMatchmakingQueuesMatchmakingQueueSizesGetMetricsGranularity.Pt15m => "PT15M",
                GameCenterMatchmakingQueuesMatchmakingQueueSizesGetMetricsGranularity.Pt1h => "PT1H",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingQueuesMatchmakingQueueSizesGetMetricsGranularity? ToEnum(string value)
        {
            return value switch
            {
                "P1D" => GameCenterMatchmakingQueuesMatchmakingQueueSizesGetMetricsGranularity.P1d,
                "PT15M" => GameCenterMatchmakingQueuesMatchmakingQueueSizesGetMetricsGranularity.Pt15m,
                "PT1H" => GameCenterMatchmakingQueuesMatchmakingQueueSizesGetMetricsGranularity.Pt1h,
                _ => null,
            };
        }
    }
}