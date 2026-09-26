
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterDetailPlayerUpdateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterDetailPlayers,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterDetailPlayerUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailPlayerUpdateRequestDataType value)
        {
            return value switch
            {
                GameCenterDetailPlayerUpdateRequestDataType.GameCenterDetailPlayers => "gameCenterDetailPlayers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailPlayerUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterDetailPlayers" => GameCenterDetailPlayerUpdateRequestDataType.GameCenterDetailPlayers,
                _ => null,
            };
        }
    }
}