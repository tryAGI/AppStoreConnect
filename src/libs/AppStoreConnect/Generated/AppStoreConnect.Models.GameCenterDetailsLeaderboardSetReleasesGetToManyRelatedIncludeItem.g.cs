
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedIncludeItem
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
    public static class GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedIncludeItem.GameCenterDetail => "gameCenterDetail",
                GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedIncludeItem.GameCenterLeaderboardSet => "gameCenterLeaderboardSet",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterDetail" => GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedIncludeItem.GameCenterDetail,
                "gameCenterLeaderboardSet" => GameCenterDetailsLeaderboardSetReleasesGetToManyRelatedIncludeItem.GameCenterLeaderboardSet,
                _ => null,
            };
        }
    }
}