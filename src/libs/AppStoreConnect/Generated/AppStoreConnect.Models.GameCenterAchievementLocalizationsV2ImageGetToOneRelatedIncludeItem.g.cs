
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterAchievementLocalizationsV2ImageGetToOneRelatedIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        Localization,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterAchievementLocalizationsV2ImageGetToOneRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementLocalizationsV2ImageGetToOneRelatedIncludeItem value)
        {
            return value switch
            {
                GameCenterAchievementLocalizationsV2ImageGetToOneRelatedIncludeItem.Localization => "localization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementLocalizationsV2ImageGetToOneRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "localization" => GameCenterAchievementLocalizationsV2ImageGetToOneRelatedIncludeItem.Localization,
                _ => null,
            };
        }
    }
}