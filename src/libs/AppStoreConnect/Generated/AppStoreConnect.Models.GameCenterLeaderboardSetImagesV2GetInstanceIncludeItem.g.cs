
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardSetImagesV2GetInstanceIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        Localization,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardSetImagesV2GetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetImagesV2GetInstanceIncludeItem value)
        {
            return value switch
            {
                GameCenterLeaderboardSetImagesV2GetInstanceIncludeItem.Localization => "localization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetImagesV2GetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "localization" => GameCenterLeaderboardSetImagesV2GetInstanceIncludeItem.Localization,
                _ => null,
            };
        }
    }
}