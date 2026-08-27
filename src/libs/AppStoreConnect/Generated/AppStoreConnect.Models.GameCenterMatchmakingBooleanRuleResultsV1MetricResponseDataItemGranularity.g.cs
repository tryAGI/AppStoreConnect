
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterMatchmakingBooleanRuleResultsV1MetricResponseDataItemGranularity
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
    public static class GameCenterMatchmakingBooleanRuleResultsV1MetricResponseDataItemGranularityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingBooleanRuleResultsV1MetricResponseDataItemGranularity value)
        {
            return value switch
            {
                GameCenterMatchmakingBooleanRuleResultsV1MetricResponseDataItemGranularity.P1d => "P1D",
                GameCenterMatchmakingBooleanRuleResultsV1MetricResponseDataItemGranularity.Pt15m => "PT15M",
                GameCenterMatchmakingBooleanRuleResultsV1MetricResponseDataItemGranularity.Pt1h => "PT1H",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingBooleanRuleResultsV1MetricResponseDataItemGranularity? ToEnum(string value)
        {
            return value switch
            {
                "P1D" => GameCenterMatchmakingBooleanRuleResultsV1MetricResponseDataItemGranularity.P1d,
                "PT15M" => GameCenterMatchmakingBooleanRuleResultsV1MetricResponseDataItemGranularity.Pt15m,
                "PT1H" => GameCenterMatchmakingBooleanRuleResultsV1MetricResponseDataItemGranularity.Pt1h,
                _ => null,
            };
        }
    }
}