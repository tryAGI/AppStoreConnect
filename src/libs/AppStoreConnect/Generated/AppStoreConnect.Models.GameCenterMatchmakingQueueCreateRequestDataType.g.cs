
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterMatchmakingQueueCreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterMatchmakingQueues,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterMatchmakingQueueCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingQueueCreateRequestDataType value)
        {
            return value switch
            {
                GameCenterMatchmakingQueueCreateRequestDataType.GameCenterMatchmakingQueues => "gameCenterMatchmakingQueues",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingQueueCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterMatchmakingQueues" => GameCenterMatchmakingQueueCreateRequestDataType.GameCenterMatchmakingQueues,
                _ => null,
            };
        }
    }
}