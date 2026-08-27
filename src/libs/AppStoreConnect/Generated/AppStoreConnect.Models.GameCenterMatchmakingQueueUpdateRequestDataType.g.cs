
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterMatchmakingQueueUpdateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterMatchmakingQueues,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterMatchmakingQueueUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingQueueUpdateRequestDataType value)
        {
            return value switch
            {
                GameCenterMatchmakingQueueUpdateRequestDataType.GameCenterMatchmakingQueues => "gameCenterMatchmakingQueues",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingQueueUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterMatchmakingQueues" => GameCenterMatchmakingQueueUpdateRequestDataType.GameCenterMatchmakingQueues,
                _ => null,
            };
        }
    }
}