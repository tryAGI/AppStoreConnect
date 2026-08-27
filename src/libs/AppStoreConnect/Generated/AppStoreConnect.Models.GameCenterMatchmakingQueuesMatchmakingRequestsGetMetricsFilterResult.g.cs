
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsFilterResult
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
    public static class GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsFilterResultExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsFilterResult value)
        {
            return value switch
            {
                GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsFilterResult.Canceled => "CANCELED",
                GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsFilterResult.Expired => "EXPIRED",
                GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsFilterResult.Matched => "MATCHED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsFilterResult? ToEnum(string value)
        {
            return value switch
            {
                "CANCELED" => GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsFilterResult.Canceled,
                "EXPIRED" => GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsFilterResult.Expired,
                "MATCHED" => GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsFilterResult.Matched,
                _ => null,
            };
        }
    }
}