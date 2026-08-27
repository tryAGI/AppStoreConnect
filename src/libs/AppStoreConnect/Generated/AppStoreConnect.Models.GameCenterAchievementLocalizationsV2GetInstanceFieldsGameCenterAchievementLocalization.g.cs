
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAchievementLocalizationsV2GetInstanceFieldsGameCenterAchievementLocalization
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
    public static class GameCenterAchievementLocalizationsV2GetInstanceFieldsGameCenterAchievementLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementLocalizationsV2GetInstanceFieldsGameCenterAchievementLocalization value)
        {
            return value switch
            {
                GameCenterAchievementLocalizationsV2GetInstanceFieldsGameCenterAchievementLocalization.AfterEarnedDescription => "afterEarnedDescription",
                GameCenterAchievementLocalizationsV2GetInstanceFieldsGameCenterAchievementLocalization.BeforeEarnedDescription => "beforeEarnedDescription",
                GameCenterAchievementLocalizationsV2GetInstanceFieldsGameCenterAchievementLocalization.Image => "image",
                GameCenterAchievementLocalizationsV2GetInstanceFieldsGameCenterAchievementLocalization.Locale => "locale",
                GameCenterAchievementLocalizationsV2GetInstanceFieldsGameCenterAchievementLocalization.Name => "name",
                GameCenterAchievementLocalizationsV2GetInstanceFieldsGameCenterAchievementLocalization.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementLocalizationsV2GetInstanceFieldsGameCenterAchievementLocalization? ToEnum(string value)
        {
            return value switch
            {
                "afterEarnedDescription" => GameCenterAchievementLocalizationsV2GetInstanceFieldsGameCenterAchievementLocalization.AfterEarnedDescription,
                "beforeEarnedDescription" => GameCenterAchievementLocalizationsV2GetInstanceFieldsGameCenterAchievementLocalization.BeforeEarnedDescription,
                "image" => GameCenterAchievementLocalizationsV2GetInstanceFieldsGameCenterAchievementLocalization.Image,
                "locale" => GameCenterAchievementLocalizationsV2GetInstanceFieldsGameCenterAchievementLocalization.Locale,
                "name" => GameCenterAchievementLocalizationsV2GetInstanceFieldsGameCenterAchievementLocalization.Name,
                "version" => GameCenterAchievementLocalizationsV2GetInstanceFieldsGameCenterAchievementLocalization.Version,
                _ => null,
            };
        }
    }
}