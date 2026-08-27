
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterDetailsLeaderboardReleasesGetToManyRelatedIncludeItem
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
    public static class GameCenterDetailsLeaderboardReleasesGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsLeaderboardReleasesGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                GameCenterDetailsLeaderboardReleasesGetToManyRelatedIncludeItem.GameCenterDetail => "gameCenterDetail",
                GameCenterDetailsLeaderboardReleasesGetToManyRelatedIncludeItem.GameCenterLeaderboard => "gameCenterLeaderboard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsLeaderboardReleasesGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterDetail" => GameCenterDetailsLeaderboardReleasesGetToManyRelatedIncludeItem.GameCenterDetail,
                "gameCenterLeaderboard" => GameCenterDetailsLeaderboardReleasesGetToManyRelatedIncludeItem.GameCenterLeaderboard,
                _ => null,
            };
        }
    }
}