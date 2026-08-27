
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterMatchmakingAppRequestsV1MetricResponseDataItemGranularity
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
    public static class GameCenterMatchmakingAppRequestsV1MetricResponseDataItemGranularityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingAppRequestsV1MetricResponseDataItemGranularity value)
        {
            return value switch
            {
                GameCenterMatchmakingAppRequestsV1MetricResponseDataItemGranularity.P1d => "P1D",
                GameCenterMatchmakingAppRequestsV1MetricResponseDataItemGranularity.Pt15m => "PT15M",
                GameCenterMatchmakingAppRequestsV1MetricResponseDataItemGranularity.Pt1h => "PT1H",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingAppRequestsV1MetricResponseDataItemGranularity? ToEnum(string value)
        {
            return value switch
            {
                "P1D" => GameCenterMatchmakingAppRequestsV1MetricResponseDataItemGranularity.P1d,
                "PT15M" => GameCenterMatchmakingAppRequestsV1MetricResponseDataItemGranularity.Pt15m,
                "PT1H" => GameCenterMatchmakingAppRequestsV1MetricResponseDataItemGranularity.Pt1h,
                _ => null,
            };
        }
    }
}