
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementLocalization
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
    public static class GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementLocalization value)
        {
            return value switch
            {
                GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementLocalization.AfterEarnedDescription => "afterEarnedDescription",
                GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementLocalization.BeforeEarnedDescription => "beforeEarnedDescription",
                GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementLocalization.GameCenterAchievement => "gameCenterAchievement",
                GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementLocalization.GameCenterAchievementImage => "gameCenterAchievementImage",
                GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementLocalization.Locale => "locale",
                GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementLocalization.Name => "name",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementLocalization? ToEnum(string value)
        {
            return value switch
            {
                "afterEarnedDescription" => GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementLocalization.AfterEarnedDescription,
                "beforeEarnedDescription" => GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementLocalization.BeforeEarnedDescription,
                "gameCenterAchievement" => GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementLocalization.GameCenterAchievement,
                "gameCenterAchievementImage" => GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementLocalization.GameCenterAchievementImage,
                "locale" => GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementLocalization.Locale,
                "name" => GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterAchievementLocalization.Name,
                _ => null,
            };
        }
    }
}