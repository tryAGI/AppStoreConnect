
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterMatchmakingQueuesMatchmakingSessionsGetMetricsGranularity
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
    public static class GameCenterMatchmakingQueuesMatchmakingSessionsGetMetricsGranularityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingQueuesMatchmakingSessionsGetMetricsGranularity value)
        {
            return value switch
            {
                GameCenterMatchmakingQueuesMatchmakingSessionsGetMetricsGranularity.P1d => "P1D",
                GameCenterMatchmakingQueuesMatchmakingSessionsGetMetricsGranularity.Pt15m => "PT15M",
                GameCenterMatchmakingQueuesMatchmakingSessionsGetMetricsGranularity.Pt1h => "PT1H",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingQueuesMatchmakingSessionsGetMetricsGranularity? ToEnum(string value)
        {
            return value switch
            {
                "P1D" => GameCenterMatchmakingQueuesMatchmakingSessionsGetMetricsGranularity.P1d,
                "PT15M" => GameCenterMatchmakingQueuesMatchmakingSessionsGetMetricsGranularity.Pt15m,
                "PT1H" => GameCenterMatchmakingQueuesMatchmakingSessionsGetMetricsGranularity.Pt1h,
                _ => null,
            };
        }
    }
}