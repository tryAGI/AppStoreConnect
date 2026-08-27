
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsGroupByItem
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterDetail,
        /// <summary>
        ///
        /// </summary>
        Result,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsGroupByItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsGroupByItem value)
        {
            return value switch
            {
                GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsGroupByItem.GameCenterDetail => "gameCenterDetail",
                GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsGroupByItem.Result => "result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsGroupByItem? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterDetail" => GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsGroupByItem.GameCenterDetail,
                "result" => GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsGroupByItem.Result,
                _ => null,
            };
        }
    }
}