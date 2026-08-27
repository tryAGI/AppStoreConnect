
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardSetReleaseType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterLeaderboardSetReleases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardSetReleaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetReleaseType value)
        {
            return value switch
            {
                GameCenterLeaderboardSetReleaseType.GameCenterLeaderboardSetReleases => "gameCenterLeaderboardSetReleases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetReleaseType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardSetReleases" => GameCenterLeaderboardSetReleaseType.GameCenterLeaderboardSetReleases,
                _ => null,
            };
        }
    }
}