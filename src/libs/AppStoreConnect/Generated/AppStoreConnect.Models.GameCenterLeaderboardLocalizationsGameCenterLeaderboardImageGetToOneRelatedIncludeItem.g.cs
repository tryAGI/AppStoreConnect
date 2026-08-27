
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardLocalizationsGameCenterLeaderboardImageGetToOneRelatedIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboardLocalization,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardLocalizationsGameCenterLeaderboardImageGetToOneRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardLocalizationsGameCenterLeaderboardImageGetToOneRelatedIncludeItem value)
        {
            return value switch
            {
                GameCenterLeaderboardLocalizationsGameCenterLeaderboardImageGetToOneRelatedIncludeItem.GameCenterLeaderboardLocalization => "gameCenterLeaderboardLocalization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardLocalizationsGameCenterLeaderboardImageGetToOneRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardLocalization" => GameCenterLeaderboardLocalizationsGameCenterLeaderboardImageGetToOneRelatedIncludeItem.GameCenterLeaderboardLocalization,
                _ => null,
            };
        }
    }
}