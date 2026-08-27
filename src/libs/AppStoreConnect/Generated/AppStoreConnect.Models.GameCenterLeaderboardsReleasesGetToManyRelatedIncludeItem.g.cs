
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardsReleasesGetToManyRelatedIncludeItem
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
    public static class GameCenterLeaderboardsReleasesGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardsReleasesGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                GameCenterLeaderboardsReleasesGetToManyRelatedIncludeItem.GameCenterDetail => "gameCenterDetail",
                GameCenterLeaderboardsReleasesGetToManyRelatedIncludeItem.GameCenterLeaderboard => "gameCenterLeaderboard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardsReleasesGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterDetail" => GameCenterLeaderboardsReleasesGetToManyRelatedIncludeItem.GameCenterDetail,
                "gameCenterLeaderboard" => GameCenterLeaderboardsReleasesGetToManyRelatedIncludeItem.GameCenterLeaderboard,
                _ => null,
            };
        }
    }
}