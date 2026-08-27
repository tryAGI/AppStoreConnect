
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardImagesV2GetInstanceIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        Localization,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardImagesV2GetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardImagesV2GetInstanceIncludeItem value)
        {
            return value switch
            {
                GameCenterLeaderboardImagesV2GetInstanceIncludeItem.Localization => "localization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardImagesV2GetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "localization" => GameCenterLeaderboardImagesV2GetInstanceIncludeItem.Localization,
                _ => null,
            };
        }
    }
}