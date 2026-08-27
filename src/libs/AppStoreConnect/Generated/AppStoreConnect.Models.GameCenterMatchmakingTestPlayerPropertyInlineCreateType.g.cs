
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterMatchmakingTestPlayerPropertyInlineCreateType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterMatchmakingTestPlayerProperties,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterMatchmakingTestPlayerPropertyInlineCreateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingTestPlayerPropertyInlineCreateType value)
        {
            return value switch
            {
                GameCenterMatchmakingTestPlayerPropertyInlineCreateType.GameCenterMatchmakingTestPlayerProperties => "gameCenterMatchmakingTestPlayerProperties",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingTestPlayerPropertyInlineCreateType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterMatchmakingTestPlayerProperties" => GameCenterMatchmakingTestPlayerPropertyInlineCreateType.GameCenterMatchmakingTestPlayerProperties,
                _ => null,
            };
        }
    }
}