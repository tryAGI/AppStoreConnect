
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardSetLocalizationsV2ImageGetToOneRelatedIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        Localization,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardSetLocalizationsV2ImageGetToOneRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetLocalizationsV2ImageGetToOneRelatedIncludeItem value)
        {
            return value switch
            {
                GameCenterLeaderboardSetLocalizationsV2ImageGetToOneRelatedIncludeItem.Localization => "localization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetLocalizationsV2ImageGetToOneRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "localization" => GameCenterLeaderboardSetLocalizationsV2ImageGetToOneRelatedIncludeItem.Localization,
                _ => null,
            };
        }
    }
}