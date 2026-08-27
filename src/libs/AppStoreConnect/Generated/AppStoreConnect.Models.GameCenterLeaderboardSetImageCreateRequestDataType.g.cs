
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardSetImageCreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboardSetImages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardSetImageCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetImageCreateRequestDataType value)
        {
            return value switch
            {
                GameCenterLeaderboardSetImageCreateRequestDataType.GameCenterLeaderboardSetImages => "gameCenterLeaderboardSetImages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetImageCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardSetImages" => GameCenterLeaderboardSetImageCreateRequestDataType.GameCenterLeaderboardSetImages,
                _ => null,
            };
        }
    }
}