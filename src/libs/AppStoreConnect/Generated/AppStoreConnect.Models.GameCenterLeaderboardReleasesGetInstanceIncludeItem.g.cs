
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardReleasesGetInstanceIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterDetail,
        /// <summary>
        /// 
        /// </summary>
        GameCenterLeaderboard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardReleasesGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardReleasesGetInstanceIncludeItem value)
        {
            return value switch
            {
                GameCenterLeaderboardReleasesGetInstanceIncludeItem.GameCenterDetail => "gameCenterDetail",
                GameCenterLeaderboardReleasesGetInstanceIncludeItem.GameCenterLeaderboard => "gameCenterLeaderboard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardReleasesGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterDetail" => GameCenterLeaderboardReleasesGetInstanceIncludeItem.GameCenterDetail,
                "gameCenterLeaderboard" => GameCenterLeaderboardReleasesGetInstanceIncludeItem.GameCenterLeaderboard,
                _ => null,
            };
        }
    }
}