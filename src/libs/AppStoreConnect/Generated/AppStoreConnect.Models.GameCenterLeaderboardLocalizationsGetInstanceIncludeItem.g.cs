
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardLocalizationsGetInstanceIncludeItem
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
    public static class GameCenterLeaderboardLocalizationsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardLocalizationsGetInstanceIncludeItem value)
        {
            return value switch
            {
                GameCenterLeaderboardLocalizationsGetInstanceIncludeItem.GameCenterLeaderboard => "gameCenterLeaderboard",
                GameCenterLeaderboardLocalizationsGetInstanceIncludeItem.GameCenterLeaderboardImage => "gameCenterLeaderboardImage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardLocalizationsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboard" => GameCenterLeaderboardLocalizationsGetInstanceIncludeItem.GameCenterLeaderboard,
                "gameCenterLeaderboardImage" => GameCenterLeaderboardLocalizationsGetInstanceIncludeItem.GameCenterLeaderboardImage,
                _ => null,
            };
        }
    }
}