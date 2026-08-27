
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterAchievementLocalizationsGetInstanceFieldsGameCenterAchievementLocalization
    {
        /// <summary>
        /// 
        /// </summary>
        AfterEarnedDescription,
        /// <summary>
        /// 
        /// </summary>
        BeforeEarnedDescription,
        /// <summary>
        /// 
        /// </summary>
        GameCenterAchievement,
        /// <summary>
        /// 
        /// </summary>
        GameCenterAchievementImage,
        /// <summary>
        /// 
        /// </summary>
        Locale,
        /// <summary>
        /// 
        /// </summary>
        Name,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterAchievementLocalizationsGetInstanceFieldsGameCenterAchievementLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementLocalizationsGetInstanceFieldsGameCenterAchievementLocalization value)
        {
            return value switch
            {
                GameCenterAchievementLocalizationsGetInstanceFieldsGameCenterAchievementLocalization.AfterEarnedDescription => "afterEarnedDescription",
                GameCenterAchievementLocalizationsGetInstanceFieldsGameCenterAchievementLocalization.BeforeEarnedDescription => "beforeEarnedDescription",
                GameCenterAchievementLocalizationsGetInstanceFieldsGameCenterAchievementLocalization.GameCenterAchievement => "gameCenterAchievement",
                GameCenterAchievementLocalizationsGetInstanceFieldsGameCenterAchievementLocalization.GameCenterAchievementImage => "gameCenterAchievementImage",
                GameCenterAchievementLocalizationsGetInstanceFieldsGameCenterAchievementLocalization.Locale => "locale",
                GameCenterAchievementLocalizationsGetInstanceFieldsGameCenterAchievementLocalization.Name => "name",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementLocalizationsGetInstanceFieldsGameCenterAchievementLocalization? ToEnum(string value)
        {
            return value switch
            {
                "afterEarnedDescription" => GameCenterAchievementLocalizationsGetInstanceFieldsGameCenterAchievementLocalization.AfterEarnedDescription,
                "beforeEarnedDescription" => GameCenterAchievementLocalizationsGetInstanceFieldsGameCenterAchievementLocalization.BeforeEarnedDescription,
                "gameCenterAchievement" => GameCenterAchievementLocalizationsGetInstanceFieldsGameCenterAchievementLocalization.GameCenterAchievement,
                "gameCenterAchievementImage" => GameCenterAchievementLocalizationsGetInstanceFieldsGameCenterAchievementLocalization.GameCenterAchievementImage,
                "locale" => GameCenterAchievementLocalizationsGetInstanceFieldsGameCenterAchievementLocalization.Locale,
                "name" => GameCenterAchievementLocalizationsGetInstanceFieldsGameCenterAchievementLocalization.Name,
                _ => null,
            };
        }
    }
}