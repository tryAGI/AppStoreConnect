
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardsLocalizationsGetToManyRelatedIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterLeaderboard,
        /// <summary>
        /// 
        /// </summary>
        GameCenterLeaderboardImage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardsLocalizationsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardsLocalizationsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                GameCenterLeaderboardsLocalizationsGetToManyRelatedIncludeItem.GameCenterLeaderboard => "gameCenterLeaderboard",
                GameCenterLeaderboardsLocalizationsGetToManyRelatedIncludeItem.GameCenterLeaderboardImage => "gameCenterLeaderboardImage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardsLocalizationsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboard" => GameCenterLeaderboardsLocalizationsGetToManyRelatedIncludeItem.GameCenterLeaderboard,
                "gameCenterLeaderboardImage" => GameCenterLeaderboardsLocalizationsGetToManyRelatedIncludeItem.GameCenterLeaderboardImage,
                _ => null,
            };
        }
    }
}