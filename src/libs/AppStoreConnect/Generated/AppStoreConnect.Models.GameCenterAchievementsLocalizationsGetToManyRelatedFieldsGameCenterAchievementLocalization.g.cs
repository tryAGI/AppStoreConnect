
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievementLocalization
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
    public static class GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievementLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievementLocalization value)
        {
            return value switch
            {
                GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievementLocalization.AfterEarnedDescription => "afterEarnedDescription",
                GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievementLocalization.BeforeEarnedDescription => "beforeEarnedDescription",
                GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievementLocalization.GameCenterAchievement => "gameCenterAchievement",
                GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievementLocalization.GameCenterAchievementImage => "gameCenterAchievementImage",
                GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievementLocalization.Locale => "locale",
                GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievementLocalization.Name => "name",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievementLocalization? ToEnum(string value)
        {
            return value switch
            {
                "afterEarnedDescription" => GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievementLocalization.AfterEarnedDescription,
                "beforeEarnedDescription" => GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievementLocalization.BeforeEarnedDescription,
                "gameCenterAchievement" => GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievementLocalization.GameCenterAchievement,
                "gameCenterAchievementImage" => GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievementLocalization.GameCenterAchievementImage,
                "locale" => GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievementLocalization.Locale,
                "name" => GameCenterAchievementsLocalizationsGetToManyRelatedFieldsGameCenterAchievementLocalization.Name,
                _ => null,
            };
        }
    }
}