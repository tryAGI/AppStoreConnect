
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardSetLocalizationsV2GetInstanceIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        Image,
        /// <summary>
        ///
        /// </summary>
        Version,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardSetLocalizationsV2GetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetLocalizationsV2GetInstanceIncludeItem value)
        {
            return value switch
            {
                GameCenterLeaderboardSetLocalizationsV2GetInstanceIncludeItem.Image => "image",
                GameCenterLeaderboardSetLocalizationsV2GetInstanceIncludeItem.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetLocalizationsV2GetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "image" => GameCenterLeaderboardSetLocalizationsV2GetInstanceIncludeItem.Image,
                "version" => GameCenterLeaderboardSetLocalizationsV2GetInstanceIncludeItem.Version,
                _ => null,
            };
        }
    }
}