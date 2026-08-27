
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardSetImageV2Type
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboardSetImages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardSetImageV2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetImageV2Type value)
        {
            return value switch
            {
                GameCenterLeaderboardSetImageV2Type.GameCenterLeaderboardSetImages => "gameCenterLeaderboardSetImages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetImageV2Type? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardSetImages" => GameCenterLeaderboardSetImageV2Type.GameCenterLeaderboardSetImages,
                _ => null,
            };
        }
    }
}