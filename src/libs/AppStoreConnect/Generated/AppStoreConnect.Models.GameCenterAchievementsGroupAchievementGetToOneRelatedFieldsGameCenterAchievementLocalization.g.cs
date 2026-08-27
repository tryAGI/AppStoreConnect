
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievementLocalization
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
    public static class GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievementLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievementLocalization value)
        {
            return value switch
            {
                GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievementLocalization.AfterEarnedDescription => "afterEarnedDescription",
                GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievementLocalization.BeforeEarnedDescription => "beforeEarnedDescription",
                GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievementLocalization.GameCenterAchievement => "gameCenterAchievement",
                GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievementLocalization.GameCenterAchievementImage => "gameCenterAchievementImage",
                GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievementLocalization.Locale => "locale",
                GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievementLocalization.Name => "name",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievementLocalization? ToEnum(string value)
        {
            return value switch
            {
                "afterEarnedDescription" => GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievementLocalization.AfterEarnedDescription,
                "beforeEarnedDescription" => GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievementLocalization.BeforeEarnedDescription,
                "gameCenterAchievement" => GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievementLocalization.GameCenterAchievement,
                "gameCenterAchievementImage" => GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievementLocalization.GameCenterAchievementImage,
                "locale" => GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievementLocalization.Locale,
                "name" => GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterAchievementLocalization.Name,
                _ => null,
            };
        }
    }
}