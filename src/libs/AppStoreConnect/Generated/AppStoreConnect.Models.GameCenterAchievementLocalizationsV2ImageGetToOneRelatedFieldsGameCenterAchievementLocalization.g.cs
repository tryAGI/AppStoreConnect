
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAchievementLocalizationsV2ImageGetToOneRelatedFieldsGameCenterAchievementLocalization
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
        Image,
        /// <summary>
        ///
        /// </summary>
        Locale,
        /// <summary>
        ///
        /// </summary>
        Name,
        /// <summary>
        ///
        /// </summary>
        Version,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterAchievementLocalizationsV2ImageGetToOneRelatedFieldsGameCenterAchievementLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementLocalizationsV2ImageGetToOneRelatedFieldsGameCenterAchievementLocalization value)
        {
            return value switch
            {
                GameCenterAchievementLocalizationsV2ImageGetToOneRelatedFieldsGameCenterAchievementLocalization.AfterEarnedDescription => "afterEarnedDescription",
                GameCenterAchievementLocalizationsV2ImageGetToOneRelatedFieldsGameCenterAchievementLocalization.BeforeEarnedDescription => "beforeEarnedDescription",
                GameCenterAchievementLocalizationsV2ImageGetToOneRelatedFieldsGameCenterAchievementLocalization.Image => "image",
                GameCenterAchievementLocalizationsV2ImageGetToOneRelatedFieldsGameCenterAchievementLocalization.Locale => "locale",
                GameCenterAchievementLocalizationsV2ImageGetToOneRelatedFieldsGameCenterAchievementLocalization.Name => "name",
                GameCenterAchievementLocalizationsV2ImageGetToOneRelatedFieldsGameCenterAchievementLocalization.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementLocalizationsV2ImageGetToOneRelatedFieldsGameCenterAchievementLocalization? ToEnum(string value)
        {
            return value switch
            {
                "afterEarnedDescription" => GameCenterAchievementLocalizationsV2ImageGetToOneRelatedFieldsGameCenterAchievementLocalization.AfterEarnedDescription,
                "beforeEarnedDescription" => GameCenterAchievementLocalizationsV2ImageGetToOneRelatedFieldsGameCenterAchievementLocalization.BeforeEarnedDescription,
                "image" => GameCenterAchievementLocalizationsV2ImageGetToOneRelatedFieldsGameCenterAchievementLocalization.Image,
                "locale" => GameCenterAchievementLocalizationsV2ImageGetToOneRelatedFieldsGameCenterAchievementLocalization.Locale,
                "name" => GameCenterAchievementLocalizationsV2ImageGetToOneRelatedFieldsGameCenterAchievementLocalization.Name,
                "version" => GameCenterAchievementLocalizationsV2ImageGetToOneRelatedFieldsGameCenterAchievementLocalization.Version,
                _ => null,
            };
        }
    }
}