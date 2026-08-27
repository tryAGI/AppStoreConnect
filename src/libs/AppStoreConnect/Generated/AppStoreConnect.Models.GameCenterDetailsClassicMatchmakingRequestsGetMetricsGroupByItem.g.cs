
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterDetailsClassicMatchmakingRequestsGetMetricsGroupByItem
    {
        /// <summary>
        /// 
        /// </summary>
        Result,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterDetailsClassicMatchmakingRequestsGetMetricsGroupByItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsClassicMatchmakingRequestsGetMetricsGroupByItem value)
        {
            return value switch
            {
                GameCenterDetailsClassicMatchmakingRequestsGetMetricsGroupByItem.Result => "result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsClassicMatchmakingRequestsGetMetricsGroupByItem? ToEnum(string value)
        {
            return value switch
            {
                "result" => GameCenterDetailsClassicMatchmakingRequestsGetMetricsGroupByItem.Result,
                _ => null,
            };
        }
    }
}