
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsGroupByItem
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
    public static class GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsGroupByItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsGroupByItem value)
        {
            return value switch
            {
                GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsGroupByItem.GameCenterDetail => "gameCenterDetail",
                GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsGroupByItem.Result => "result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsGroupByItem? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterDetail" => GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsGroupByItem.GameCenterDetail,
                "result" => GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsGroupByItem.Result,
                _ => null,
            };
        }
    }
}