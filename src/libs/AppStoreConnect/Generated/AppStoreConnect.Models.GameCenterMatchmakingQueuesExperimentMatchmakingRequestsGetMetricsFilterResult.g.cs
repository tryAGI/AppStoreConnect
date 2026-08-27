
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsFilterResult
    {
        /// <summary>
        ///
        /// </summary>
        Canceled,
        /// <summary>
        ///
        /// </summary>
        Expired,
        /// <summary>
        ///
        /// </summary>
        Matched,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsFilterResultExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsFilterResult value)
        {
            return value switch
            {
                GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsFilterResult.Canceled => "CANCELED",
                GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsFilterResult.Expired => "EXPIRED",
                GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsFilterResult.Matched => "MATCHED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsFilterResult? ToEnum(string value)
        {
            return value switch
            {
                "CANCELED" => GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsFilterResult.Canceled,
                "EXPIRED" => GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsFilterResult.Expired,
                "MATCHED" => GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsFilterResult.Matched,
                _ => null,
            };
        }
    }
}