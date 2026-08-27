
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterAchievementImagesGetInstanceFieldsGameCenterAchievementLocalization
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
    public static class GameCenterAchievementImagesGetInstanceFieldsGameCenterAchievementLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementImagesGetInstanceFieldsGameCenterAchievementLocalization value)
        {
            return value switch
            {
                GameCenterAchievementImagesGetInstanceFieldsGameCenterAchievementLocalization.AfterEarnedDescription => "afterEarnedDescription",
                GameCenterAchievementImagesGetInstanceFieldsGameCenterAchievementLocalization.BeforeEarnedDescription => "beforeEarnedDescription",
                GameCenterAchievementImagesGetInstanceFieldsGameCenterAchievementLocalization.GameCenterAchievement => "gameCenterAchievement",
                GameCenterAchievementImagesGetInstanceFieldsGameCenterAchievementLocalization.GameCenterAchievementImage => "gameCenterAchievementImage",
                GameCenterAchievementImagesGetInstanceFieldsGameCenterAchievementLocalization.Locale => "locale",
                GameCenterAchievementImagesGetInstanceFieldsGameCenterAchievementLocalization.Name => "name",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementImagesGetInstanceFieldsGameCenterAchievementLocalization? ToEnum(string value)
        {
            return value switch
            {
                "afterEarnedDescription" => GameCenterAchievementImagesGetInstanceFieldsGameCenterAchievementLocalization.AfterEarnedDescription,
                "beforeEarnedDescription" => GameCenterAchievementImagesGetInstanceFieldsGameCenterAchievementLocalization.BeforeEarnedDescription,
                "gameCenterAchievement" => GameCenterAchievementImagesGetInstanceFieldsGameCenterAchievementLocalization.GameCenterAchievement,
                "gameCenterAchievementImage" => GameCenterAchievementImagesGetInstanceFieldsGameCenterAchievementLocalization.GameCenterAchievementImage,
                "locale" => GameCenterAchievementImagesGetInstanceFieldsGameCenterAchievementLocalization.Locale,
                "name" => GameCenterAchievementImagesGetInstanceFieldsGameCenterAchievementLocalization.Name,
                _ => null,
            };
        }
    }
}