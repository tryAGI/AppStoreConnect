
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsGranularity
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
    public static class GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsGranularityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsGranularity value)
        {
            return value switch
            {
                GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsGranularity.P1d => "P1D",
                GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsGranularity.Pt15m => "PT15M",
                GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsGranularity.Pt1h => "PT1H",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsGranularity? ToEnum(string value)
        {
            return value switch
            {
                "P1D" => GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsGranularity.P1d,
                "PT15M" => GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsGranularity.Pt15m,
                "PT1H" => GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsGranularity.Pt1h,
                _ => null,
            };
        }
    }
}