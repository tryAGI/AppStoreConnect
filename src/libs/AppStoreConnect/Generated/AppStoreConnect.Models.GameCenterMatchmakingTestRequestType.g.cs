
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterMatchmakingTestRequestType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterMatchmakingTestRequests,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterMatchmakingTestRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingTestRequestType value)
        {
            return value switch
            {
                GameCenterMatchmakingTestRequestType.GameCenterMatchmakingTestRequests => "gameCenterMatchmakingTestRequests",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingTestRequestType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterMatchmakingTestRequests" => GameCenterMatchmakingTestRequestType.GameCenterMatchmakingTestRequests,
                _ => null,
            };
        }
    }
}