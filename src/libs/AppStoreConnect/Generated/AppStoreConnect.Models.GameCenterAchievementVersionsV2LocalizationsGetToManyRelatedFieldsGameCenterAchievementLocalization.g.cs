
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterAchievementVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterAchievementLocalization
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
    public static class GameCenterAchievementVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterAchievementLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterAchievementLocalization value)
        {
            return value switch
            {
                GameCenterAchievementVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterAchievementLocalization.AfterEarnedDescription => "afterEarnedDescription",
                GameCenterAchievementVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterAchievementLocalization.BeforeEarnedDescription => "beforeEarnedDescription",
                GameCenterAchievementVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterAchievementLocalization.Image => "image",
                GameCenterAchievementVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterAchievementLocalization.Locale => "locale",
                GameCenterAchievementVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterAchievementLocalization.Name => "name",
                GameCenterAchievementVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterAchievementLocalization.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterAchievementLocalization? ToEnum(string value)
        {
            return value switch
            {
                "afterEarnedDescription" => GameCenterAchievementVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterAchievementLocalization.AfterEarnedDescription,
                "beforeEarnedDescription" => GameCenterAchievementVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterAchievementLocalization.BeforeEarnedDescription,
                "image" => GameCenterAchievementVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterAchievementLocalization.Image,
                "locale" => GameCenterAchievementVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterAchievementLocalization.Locale,
                "name" => GameCenterAchievementVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterAchievementLocalization.Name,
                "version" => GameCenterAchievementVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterAchievementLocalization.Version,
                _ => null,
            };
        }
    }
}