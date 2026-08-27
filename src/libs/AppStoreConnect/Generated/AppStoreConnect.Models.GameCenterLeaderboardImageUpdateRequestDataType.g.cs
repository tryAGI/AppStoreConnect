
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardImageUpdateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboardImages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardImageUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardImageUpdateRequestDataType value)
        {
            return value switch
            {
                GameCenterLeaderboardImageUpdateRequestDataType.GameCenterLeaderboardImages => "gameCenterLeaderboardImages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardImageUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardImages" => GameCenterLeaderboardImageUpdateRequestDataType.GameCenterLeaderboardImages,
                _ => null,
            };
        }
    }
}