
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAchievementLocalizationsGameCenterAchievementImageGetToOneRelatedFieldsGameCenterAchievementLocalization
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
    public static class GameCenterAchievementLocalizationsGameCenterAchievementImageGetToOneRelatedFieldsGameCenterAchievementLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementLocalizationsGameCenterAchievementImageGetToOneRelatedFieldsGameCenterAchievementLocalization value)
        {
            return value switch
            {
                GameCenterAchievementLocalizationsGameCenterAchievementImageGetToOneRelatedFieldsGameCenterAchievementLocalization.AfterEarnedDescription => "afterEarnedDescription",
                GameCenterAchievementLocalizationsGameCenterAchievementImageGetToOneRelatedFieldsGameCenterAchievementLocalization.BeforeEarnedDescription => "beforeEarnedDescription",
                GameCenterAchievementLocalizationsGameCenterAchievementImageGetToOneRelatedFieldsGameCenterAchievementLocalization.GameCenterAchievement => "gameCenterAchievement",
                GameCenterAchievementLocalizationsGameCenterAchievementImageGetToOneRelatedFieldsGameCenterAchievementLocalization.GameCenterAchievementImage => "gameCenterAchievementImage",
                GameCenterAchievementLocalizationsGameCenterAchievementImageGetToOneRelatedFieldsGameCenterAchievementLocalization.Locale => "locale",
                GameCenterAchievementLocalizationsGameCenterAchievementImageGetToOneRelatedFieldsGameCenterAchievementLocalization.Name => "name",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementLocalizationsGameCenterAchievementImageGetToOneRelatedFieldsGameCenterAchievementLocalization? ToEnum(string value)
        {
            return value switch
            {
                "afterEarnedDescription" => GameCenterAchievementLocalizationsGameCenterAchievementImageGetToOneRelatedFieldsGameCenterAchievementLocalization.AfterEarnedDescription,
                "beforeEarnedDescription" => GameCenterAchievementLocalizationsGameCenterAchievementImageGetToOneRelatedFieldsGameCenterAchievementLocalization.BeforeEarnedDescription,
                "gameCenterAchievement" => GameCenterAchievementLocalizationsGameCenterAchievementImageGetToOneRelatedFieldsGameCenterAchievementLocalization.GameCenterAchievement,
                "gameCenterAchievementImage" => GameCenterAchievementLocalizationsGameCenterAchievementImageGetToOneRelatedFieldsGameCenterAchievementLocalization.GameCenterAchievementImage,
                "locale" => GameCenterAchievementLocalizationsGameCenterAchievementImageGetToOneRelatedFieldsGameCenterAchievementLocalization.Locale,
                "name" => GameCenterAchievementLocalizationsGameCenterAchievementImageGetToOneRelatedFieldsGameCenterAchievementLocalization.Name,
                _ => null,
            };
        }
    }
}