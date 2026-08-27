
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardSetMemberLocalizationsGetCollectionIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboard,
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboardSet,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardSetMemberLocalizationsGetCollectionIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetMemberLocalizationsGetCollectionIncludeItem value)
        {
            return value switch
            {
                GameCenterLeaderboardSetMemberLocalizationsGetCollectionIncludeItem.GameCenterLeaderboard => "gameCenterLeaderboard",
                GameCenterLeaderboardSetMemberLocalizationsGetCollectionIncludeItem.GameCenterLeaderboardSet => "gameCenterLeaderboardSet",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetMemberLocalizationsGetCollectionIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboard" => GameCenterLeaderboardSetMemberLocalizationsGetCollectionIncludeItem.GameCenterLeaderboard,
                "gameCenterLeaderboardSet" => GameCenterLeaderboardSetMemberLocalizationsGetCollectionIncludeItem.GameCenterLeaderboardSet,
                _ => null,
            };
        }
    }
}