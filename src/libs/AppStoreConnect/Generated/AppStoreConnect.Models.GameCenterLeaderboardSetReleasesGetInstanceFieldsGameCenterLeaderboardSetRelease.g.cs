
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterLeaderboardSetRelease
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterDetail,
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboardSet,
        /// <summary>
        ///
        /// </summary>
        Live,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterLeaderboardSetReleaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterLeaderboardSetRelease value)
        {
            return value switch
            {
                GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterLeaderboardSetRelease.GameCenterDetail => "gameCenterDetail",
                GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterLeaderboardSetRelease.GameCenterLeaderboardSet => "gameCenterLeaderboardSet",
                GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterLeaderboardSetRelease.Live => "live",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterLeaderboardSetRelease? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterDetail" => GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterLeaderboardSetRelease.GameCenterDetail,
                "gameCenterLeaderboardSet" => GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterLeaderboardSetRelease.GameCenterLeaderboardSet,
                "live" => GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterLeaderboardSetRelease.Live,
                _ => null,
            };
        }
    }
}