
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardReleasesGetInstanceFieldsGameCenterLeaderboardRelease
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterDetail,
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboard,
        /// <summary>
        ///
        /// </summary>
        Live,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardReleasesGetInstanceFieldsGameCenterLeaderboardReleaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardReleasesGetInstanceFieldsGameCenterLeaderboardRelease value)
        {
            return value switch
            {
                GameCenterLeaderboardReleasesGetInstanceFieldsGameCenterLeaderboardRelease.GameCenterDetail => "gameCenterDetail",
                GameCenterLeaderboardReleasesGetInstanceFieldsGameCenterLeaderboardRelease.GameCenterLeaderboard => "gameCenterLeaderboard",
                GameCenterLeaderboardReleasesGetInstanceFieldsGameCenterLeaderboardRelease.Live => "live",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardReleasesGetInstanceFieldsGameCenterLeaderboardRelease? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterDetail" => GameCenterLeaderboardReleasesGetInstanceFieldsGameCenterLeaderboardRelease.GameCenterDetail,
                "gameCenterLeaderboard" => GameCenterLeaderboardReleasesGetInstanceFieldsGameCenterLeaderboardRelease.GameCenterLeaderboard,
                "live" => GameCenterLeaderboardReleasesGetInstanceFieldsGameCenterLeaderboardRelease.Live,
                _ => null,
            };
        }
    }
}