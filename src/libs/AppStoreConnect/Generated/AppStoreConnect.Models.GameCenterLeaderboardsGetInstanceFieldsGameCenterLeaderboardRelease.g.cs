
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardsGetInstanceFieldsGameCenterLeaderboardRelease
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
    public static class GameCenterLeaderboardsGetInstanceFieldsGameCenterLeaderboardReleaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardsGetInstanceFieldsGameCenterLeaderboardRelease value)
        {
            return value switch
            {
                GameCenterLeaderboardsGetInstanceFieldsGameCenterLeaderboardRelease.GameCenterDetail => "gameCenterDetail",
                GameCenterLeaderboardsGetInstanceFieldsGameCenterLeaderboardRelease.GameCenterLeaderboard => "gameCenterLeaderboard",
                GameCenterLeaderboardsGetInstanceFieldsGameCenterLeaderboardRelease.Live => "live",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardsGetInstanceFieldsGameCenterLeaderboardRelease? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterDetail" => GameCenterLeaderboardsGetInstanceFieldsGameCenterLeaderboardRelease.GameCenterDetail,
                "gameCenterLeaderboard" => GameCenterLeaderboardsGetInstanceFieldsGameCenterLeaderboardRelease.GameCenterLeaderboard,
                "live" => GameCenterLeaderboardsGetInstanceFieldsGameCenterLeaderboardRelease.Live,
                _ => null,
            };
        }
    }
}