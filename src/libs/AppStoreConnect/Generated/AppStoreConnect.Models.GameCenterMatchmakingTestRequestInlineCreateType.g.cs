
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterMatchmakingTestRequestInlineCreateType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterMatchmakingTestRequests,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterMatchmakingTestRequestInlineCreateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingTestRequestInlineCreateType value)
        {
            return value switch
            {
                GameCenterMatchmakingTestRequestInlineCreateType.GameCenterMatchmakingTestRequests => "gameCenterMatchmakingTestRequests",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingTestRequestInlineCreateType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterMatchmakingTestRequests" => GameCenterMatchmakingTestRequestInlineCreateType.GameCenterMatchmakingTestRequests,
                _ => null,
            };
        }
    }
}