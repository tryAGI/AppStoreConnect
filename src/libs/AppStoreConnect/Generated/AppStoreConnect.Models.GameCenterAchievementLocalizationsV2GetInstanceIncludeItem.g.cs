
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterAchievementLocalizationsV2GetInstanceIncludeItem
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
    public static class GameCenterAchievementLocalizationsV2GetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementLocalizationsV2GetInstanceIncludeItem value)
        {
            return value switch
            {
                GameCenterAchievementLocalizationsV2GetInstanceIncludeItem.Image => "image",
                GameCenterAchievementLocalizationsV2GetInstanceIncludeItem.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementLocalizationsV2GetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "image" => GameCenterAchievementLocalizationsV2GetInstanceIncludeItem.Image,
                "version" => GameCenterAchievementLocalizationsV2GetInstanceIncludeItem.Version,
                _ => null,
            };
        }
    }
}