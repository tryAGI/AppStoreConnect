
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterMatchmakingTestPlayerPropertyType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterMatchmakingTestPlayerProperties,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterMatchmakingTestPlayerPropertyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingTestPlayerPropertyType value)
        {
            return value switch
            {
                GameCenterMatchmakingTestPlayerPropertyType.GameCenterMatchmakingTestPlayerProperties => "gameCenterMatchmakingTestPlayerProperties",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingTestPlayerPropertyType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterMatchmakingTestPlayerProperties" => GameCenterMatchmakingTestPlayerPropertyType.GameCenterMatchmakingTestPlayerProperties,
                _ => null,
            };
        }
    }
}