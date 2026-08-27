
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsGroupByItem
    {
        /// <summary>
        /// 
        /// </summary>
        Result,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsGroupByItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsGroupByItem value)
        {
            return value switch
            {
                GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsGroupByItem.Result => "result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsGroupByItem? ToEnum(string value)
        {
            return value switch
            {
                "result" => GameCenterDetailsRuleBasedMatchmakingRequestsGetMetricsGroupByItem.Result,
                _ => null,
            };
        }
    }
}