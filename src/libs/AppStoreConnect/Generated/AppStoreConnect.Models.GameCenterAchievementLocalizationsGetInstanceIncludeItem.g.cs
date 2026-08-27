
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAchievementLocalizationsGetInstanceIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterAchievement,
        /// <summary>
        ///
        /// </summary>
        GameCenterAchievementImage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterAchievementLocalizationsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementLocalizationsGetInstanceIncludeItem value)
        {
            return value switch
            {
                GameCenterAchievementLocalizationsGetInstanceIncludeItem.GameCenterAchievement => "gameCenterAchievement",
                GameCenterAchievementLocalizationsGetInstanceIncludeItem.GameCenterAchievementImage => "gameCenterAchievementImage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementLocalizationsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievement" => GameCenterAchievementLocalizationsGetInstanceIncludeItem.GameCenterAchievement,
                "gameCenterAchievementImage" => GameCenterAchievementLocalizationsGetInstanceIncludeItem.GameCenterAchievementImage,
                _ => null,
            };
        }
    }
}