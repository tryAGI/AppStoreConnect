
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardLocalizationsV2GetInstanceIncludeItem
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
    public static class GameCenterLeaderboardLocalizationsV2GetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardLocalizationsV2GetInstanceIncludeItem value)
        {
            return value switch
            {
                GameCenterLeaderboardLocalizationsV2GetInstanceIncludeItem.Image => "image",
                GameCenterLeaderboardLocalizationsV2GetInstanceIncludeItem.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardLocalizationsV2GetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "image" => GameCenterLeaderboardLocalizationsV2GetInstanceIncludeItem.Image,
                "version" => GameCenterLeaderboardLocalizationsV2GetInstanceIncludeItem.Version,
                _ => null,
            };
        }
    }
}