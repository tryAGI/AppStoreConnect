
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsFilterResult
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
    public static class GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsFilterResultExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsFilterResult value)
        {
            return value switch
            {
                GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsFilterResult.Canceled => "CANCELED",
                GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsFilterResult.Expired => "EXPIRED",
                GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsFilterResult.Matched => "MATCHED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsFilterResult? ToEnum(string value)
        {
            return value switch
            {
                "CANCELED" => GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsFilterResult.Canceled,
                "EXPIRED" => GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsFilterResult.Expired,
                "MATCHED" => GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsFilterResult.Matched,
                _ => null,
            };
        }
    }
}