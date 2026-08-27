
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDimensionsResultData
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
    public static class GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDimensionsResultDataExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDimensionsResultData value)
        {
            return value switch
            {
                GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDimensionsResultData.Canceled => "CANCELED",
                GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDimensionsResultData.Expired => "EXPIRED",
                GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDimensionsResultData.Matched => "MATCHED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDimensionsResultData? ToEnum(string value)
        {
            return value switch
            {
                "CANCELED" => GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDimensionsResultData.Canceled,
                "EXPIRED" => GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDimensionsResultData.Expired,
                "MATCHED" => GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDimensionsResultData.Matched,
                _ => null,
            };
        }
    }
}