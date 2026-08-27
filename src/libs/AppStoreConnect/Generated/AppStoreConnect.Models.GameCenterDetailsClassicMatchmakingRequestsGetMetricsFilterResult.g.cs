
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterDetailsClassicMatchmakingRequestsGetMetricsFilterResult
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
    public static class GameCenterDetailsClassicMatchmakingRequestsGetMetricsFilterResultExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsClassicMatchmakingRequestsGetMetricsFilterResult value)
        {
            return value switch
            {
                GameCenterDetailsClassicMatchmakingRequestsGetMetricsFilterResult.Canceled => "CANCELED",
                GameCenterDetailsClassicMatchmakingRequestsGetMetricsFilterResult.Expired => "EXPIRED",
                GameCenterDetailsClassicMatchmakingRequestsGetMetricsFilterResult.Matched => "MATCHED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsClassicMatchmakingRequestsGetMetricsFilterResult? ToEnum(string value)
        {
            return value switch
            {
                "CANCELED" => GameCenterDetailsClassicMatchmakingRequestsGetMetricsFilterResult.Canceled,
                "EXPIRED" => GameCenterDetailsClassicMatchmakingRequestsGetMetricsFilterResult.Expired,
                "MATCHED" => GameCenterDetailsClassicMatchmakingRequestsGetMetricsFilterResult.Matched,
                _ => null,
            };
        }
    }
}