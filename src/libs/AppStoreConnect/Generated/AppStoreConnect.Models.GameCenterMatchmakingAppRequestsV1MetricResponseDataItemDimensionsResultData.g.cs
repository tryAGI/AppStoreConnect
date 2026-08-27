
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterMatchmakingAppRequestsV1MetricResponseDataItemDimensionsResultData
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
    public static class GameCenterMatchmakingAppRequestsV1MetricResponseDataItemDimensionsResultDataExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingAppRequestsV1MetricResponseDataItemDimensionsResultData value)
        {
            return value switch
            {
                GameCenterMatchmakingAppRequestsV1MetricResponseDataItemDimensionsResultData.Canceled => "CANCELED",
                GameCenterMatchmakingAppRequestsV1MetricResponseDataItemDimensionsResultData.Expired => "EXPIRED",
                GameCenterMatchmakingAppRequestsV1MetricResponseDataItemDimensionsResultData.Matched => "MATCHED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingAppRequestsV1MetricResponseDataItemDimensionsResultData? ToEnum(string value)
        {
            return value switch
            {
                "CANCELED" => GameCenterMatchmakingAppRequestsV1MetricResponseDataItemDimensionsResultData.Canceled,
                "EXPIRED" => GameCenterMatchmakingAppRequestsV1MetricResponseDataItemDimensionsResultData.Expired,
                "MATCHED" => GameCenterMatchmakingAppRequestsV1MetricResponseDataItemDimensionsResultData.Matched,
                _ => null,
            };
        }
    }
}