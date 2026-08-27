
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardSetImagesGetInstanceIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboardSetLocalization,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardSetImagesGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetImagesGetInstanceIncludeItem value)
        {
            return value switch
            {
                GameCenterLeaderboardSetImagesGetInstanceIncludeItem.GameCenterLeaderboardSetLocalization => "gameCenterLeaderboardSetLocalization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetImagesGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardSetLocalization" => GameCenterLeaderboardSetImagesGetInstanceIncludeItem.GameCenterLeaderboardSetLocalization,
                _ => null,
            };
        }
    }
}