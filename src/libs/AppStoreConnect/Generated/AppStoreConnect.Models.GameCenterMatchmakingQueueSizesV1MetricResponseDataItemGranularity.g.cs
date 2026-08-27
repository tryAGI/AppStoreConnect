
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterMatchmakingQueueSizesV1MetricResponseDataItemGranularity
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
    public static class GameCenterMatchmakingQueueSizesV1MetricResponseDataItemGranularityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingQueueSizesV1MetricResponseDataItemGranularity value)
        {
            return value switch
            {
                GameCenterMatchmakingQueueSizesV1MetricResponseDataItemGranularity.P1d => "P1D",
                GameCenterMatchmakingQueueSizesV1MetricResponseDataItemGranularity.Pt15m => "PT15M",
                GameCenterMatchmakingQueueSizesV1MetricResponseDataItemGranularity.Pt1h => "PT1H",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingQueueSizesV1MetricResponseDataItemGranularity? ToEnum(string value)
        {
            return value switch
            {
                "P1D" => GameCenterMatchmakingQueueSizesV1MetricResponseDataItemGranularity.P1d,
                "PT15M" => GameCenterMatchmakingQueueSizesV1MetricResponseDataItemGranularity.Pt15m,
                "PT1H" => GameCenterMatchmakingQueueSizesV1MetricResponseDataItemGranularity.Pt1h,
                _ => null,
            };
        }
    }
}