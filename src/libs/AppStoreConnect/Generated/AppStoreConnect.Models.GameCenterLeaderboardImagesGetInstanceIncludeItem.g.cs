
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardImagesGetInstanceIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterLeaderboardLocalization,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardImagesGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardImagesGetInstanceIncludeItem value)
        {
            return value switch
            {
                GameCenterLeaderboardImagesGetInstanceIncludeItem.GameCenterLeaderboardLocalization => "gameCenterLeaderboardLocalization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardImagesGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardLocalization" => GameCenterLeaderboardImagesGetInstanceIncludeItem.GameCenterLeaderboardLocalization,
                _ => null,
            };
        }
    }
}