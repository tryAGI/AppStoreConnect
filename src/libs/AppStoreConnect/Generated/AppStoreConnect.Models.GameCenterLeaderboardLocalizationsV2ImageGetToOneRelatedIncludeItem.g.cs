
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardLocalizationsV2ImageGetToOneRelatedIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        Localization,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardLocalizationsV2ImageGetToOneRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardLocalizationsV2ImageGetToOneRelatedIncludeItem value)
        {
            return value switch
            {
                GameCenterLeaderboardLocalizationsV2ImageGetToOneRelatedIncludeItem.Localization => "localization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardLocalizationsV2ImageGetToOneRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "localization" => GameCenterLeaderboardLocalizationsV2ImageGetToOneRelatedIncludeItem.Localization,
                _ => null,
            };
        }
    }
}