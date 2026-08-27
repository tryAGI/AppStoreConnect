
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterMatchmakingQueueType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterMatchmakingQueues,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterMatchmakingQueueTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingQueueType value)
        {
            return value switch
            {
                GameCenterMatchmakingQueueType.GameCenterMatchmakingQueues => "gameCenterMatchmakingQueues",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingQueueType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterMatchmakingQueues" => GameCenterMatchmakingQueueType.GameCenterMatchmakingQueues,
                _ => null,
            };
        }
    }
}