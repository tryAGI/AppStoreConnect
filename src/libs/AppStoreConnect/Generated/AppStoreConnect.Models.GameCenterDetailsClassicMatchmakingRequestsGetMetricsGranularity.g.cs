
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterDetailsClassicMatchmakingRequestsGetMetricsGranularity
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
    public static class GameCenterDetailsClassicMatchmakingRequestsGetMetricsGranularityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsClassicMatchmakingRequestsGetMetricsGranularity value)
        {
            return value switch
            {
                GameCenterDetailsClassicMatchmakingRequestsGetMetricsGranularity.P1d => "P1D",
                GameCenterDetailsClassicMatchmakingRequestsGetMetricsGranularity.Pt15m => "PT15M",
                GameCenterDetailsClassicMatchmakingRequestsGetMetricsGranularity.Pt1h => "PT1H",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsClassicMatchmakingRequestsGetMetricsGranularity? ToEnum(string value)
        {
            return value switch
            {
                "P1D" => GameCenterDetailsClassicMatchmakingRequestsGetMetricsGranularity.P1d,
                "PT15M" => GameCenterDetailsClassicMatchmakingRequestsGetMetricsGranularity.Pt15m,
                "PT1H" => GameCenterDetailsClassicMatchmakingRequestsGetMetricsGranularity.Pt1h,
                _ => null,
            };
        }
    }
}