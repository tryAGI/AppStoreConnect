
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterAchievementImagesV2GetInstanceIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        Localization,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterAchievementImagesV2GetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementImagesV2GetInstanceIncludeItem value)
        {
            return value switch
            {
                GameCenterAchievementImagesV2GetInstanceIncludeItem.Localization => "localization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementImagesV2GetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "localization" => GameCenterAchievementImagesV2GetInstanceIncludeItem.Localization,
                _ => null,
            };
        }
    }
}