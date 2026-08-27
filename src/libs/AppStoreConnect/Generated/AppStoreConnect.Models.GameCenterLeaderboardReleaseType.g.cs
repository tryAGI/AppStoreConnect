
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardReleaseType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboardReleases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardReleaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardReleaseType value)
        {
            return value switch
            {
                GameCenterLeaderboardReleaseType.GameCenterLeaderboardReleases => "gameCenterLeaderboardReleases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardReleaseType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardReleases" => GameCenterLeaderboardReleaseType.GameCenterLeaderboardReleases,
                _ => null,
            };
        }
    }
}