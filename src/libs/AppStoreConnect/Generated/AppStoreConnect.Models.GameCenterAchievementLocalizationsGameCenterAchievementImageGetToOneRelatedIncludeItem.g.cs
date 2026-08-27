
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterAchievementLocalizationsGameCenterAchievementImageGetToOneRelatedIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterAchievementLocalization,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterAchievementLocalizationsGameCenterAchievementImageGetToOneRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementLocalizationsGameCenterAchievementImageGetToOneRelatedIncludeItem value)
        {
            return value switch
            {
                GameCenterAchievementLocalizationsGameCenterAchievementImageGetToOneRelatedIncludeItem.GameCenterAchievementLocalization => "gameCenterAchievementLocalization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementLocalizationsGameCenterAchievementImageGetToOneRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievementLocalization" => GameCenterAchievementLocalizationsGameCenterAchievementImageGetToOneRelatedIncludeItem.GameCenterAchievementLocalization,
                _ => null,
            };
        }
    }
}