
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardSetLocalizationsGameCenterLeaderboardSetImageGetToOneRelatedIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboardSetLocalization,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardSetLocalizationsGameCenterLeaderboardSetImageGetToOneRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetLocalizationsGameCenterLeaderboardSetImageGetToOneRelatedIncludeItem value)
        {
            return value switch
            {
                GameCenterLeaderboardSetLocalizationsGameCenterLeaderboardSetImageGetToOneRelatedIncludeItem.GameCenterLeaderboardSetLocalization => "gameCenterLeaderboardSetLocalization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetLocalizationsGameCenterLeaderboardSetImageGetToOneRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardSetLocalization" => GameCenterLeaderboardSetLocalizationsGameCenterLeaderboardSetImageGetToOneRelatedIncludeItem.GameCenterLeaderboardSetLocalization,
                _ => null,
            };
        }
    }
}