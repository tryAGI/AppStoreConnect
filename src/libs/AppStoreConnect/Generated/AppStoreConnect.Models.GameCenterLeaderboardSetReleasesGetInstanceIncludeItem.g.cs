
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardSetReleasesGetInstanceIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterDetail,
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboardSet,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardSetReleasesGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetReleasesGetInstanceIncludeItem value)
        {
            return value switch
            {
                GameCenterLeaderboardSetReleasesGetInstanceIncludeItem.GameCenterDetail => "gameCenterDetail",
                GameCenterLeaderboardSetReleasesGetInstanceIncludeItem.GameCenterLeaderboardSet => "gameCenterLeaderboardSet",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetReleasesGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterDetail" => GameCenterLeaderboardSetReleasesGetInstanceIncludeItem.GameCenterDetail,
                "gameCenterLeaderboardSet" => GameCenterLeaderboardSetReleasesGetInstanceIncludeItem.GameCenterLeaderboardSet,
                _ => null,
            };
        }
    }
}