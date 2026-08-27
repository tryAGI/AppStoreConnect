
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementLocalization
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
    public static class GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementLocalization value)
        {
            return value switch
            {
                GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementLocalization.AfterEarnedDescription => "afterEarnedDescription",
                GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementLocalization.BeforeEarnedDescription => "beforeEarnedDescription",
                GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementLocalization.Image => "image",
                GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementLocalization.Locale => "locale",
                GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementLocalization.Name => "name",
                GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementLocalization.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementLocalization? ToEnum(string value)
        {
            return value switch
            {
                "afterEarnedDescription" => GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementLocalization.AfterEarnedDescription,
                "beforeEarnedDescription" => GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementLocalization.BeforeEarnedDescription,
                "image" => GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementLocalization.Image,
                "locale" => GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementLocalization.Locale,
                "name" => GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementLocalization.Name,
                "version" => GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementLocalization.Version,
                _ => null,
            };
        }
    }
}