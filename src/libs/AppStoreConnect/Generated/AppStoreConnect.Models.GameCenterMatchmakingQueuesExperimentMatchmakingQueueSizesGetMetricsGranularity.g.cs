
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterMatchmakingQueuesExperimentMatchmakingQueueSizesGetMetricsGranularity
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
    public static class GameCenterMatchmakingQueuesExperimentMatchmakingQueueSizesGetMetricsGranularityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingQueuesExperimentMatchmakingQueueSizesGetMetricsGranularity value)
        {
            return value switch
            {
                GameCenterMatchmakingQueuesExperimentMatchmakingQueueSizesGetMetricsGranularity.P1d => "P1D",
                GameCenterMatchmakingQueuesExperimentMatchmakingQueueSizesGetMetricsGranularity.Pt15m => "PT15M",
                GameCenterMatchmakingQueuesExperimentMatchmakingQueueSizesGetMetricsGranularity.Pt1h => "PT1H",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingQueuesExperimentMatchmakingQueueSizesGetMetricsGranularity? ToEnum(string value)
        {
            return value switch
            {
                "P1D" => GameCenterMatchmakingQueuesExperimentMatchmakingQueueSizesGetMetricsGranularity.P1d,
                "PT15M" => GameCenterMatchmakingQueuesExperimentMatchmakingQueueSizesGetMetricsGranularity.Pt15m,
                "PT1H" => GameCenterMatchmakingQueuesExperimentMatchmakingQueueSizesGetMetricsGranularity.Pt1h,
                _ => null,
            };
        }
    }
}