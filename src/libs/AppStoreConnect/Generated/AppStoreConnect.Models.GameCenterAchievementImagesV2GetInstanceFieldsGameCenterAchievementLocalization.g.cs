
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAchievementImagesV2GetInstanceFieldsGameCenterAchievementLocalization
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
    public static class GameCenterAchievementImagesV2GetInstanceFieldsGameCenterAchievementLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementImagesV2GetInstanceFieldsGameCenterAchievementLocalization value)
        {
            return value switch
            {
                GameCenterAchievementImagesV2GetInstanceFieldsGameCenterAchievementLocalization.AfterEarnedDescription => "afterEarnedDescription",
                GameCenterAchievementImagesV2GetInstanceFieldsGameCenterAchievementLocalization.BeforeEarnedDescription => "beforeEarnedDescription",
                GameCenterAchievementImagesV2GetInstanceFieldsGameCenterAchievementLocalization.Image => "image",
                GameCenterAchievementImagesV2GetInstanceFieldsGameCenterAchievementLocalization.Locale => "locale",
                GameCenterAchievementImagesV2GetInstanceFieldsGameCenterAchievementLocalization.Name => "name",
                GameCenterAchievementImagesV2GetInstanceFieldsGameCenterAchievementLocalization.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementImagesV2GetInstanceFieldsGameCenterAchievementLocalization? ToEnum(string value)
        {
            return value switch
            {
                "afterEarnedDescription" => GameCenterAchievementImagesV2GetInstanceFieldsGameCenterAchievementLocalization.AfterEarnedDescription,
                "beforeEarnedDescription" => GameCenterAchievementImagesV2GetInstanceFieldsGameCenterAchievementLocalization.BeforeEarnedDescription,
                "image" => GameCenterAchievementImagesV2GetInstanceFieldsGameCenterAchievementLocalization.Image,
                "locale" => GameCenterAchievementImagesV2GetInstanceFieldsGameCenterAchievementLocalization.Locale,
                "name" => GameCenterAchievementImagesV2GetInstanceFieldsGameCenterAchievementLocalization.Name,
                "version" => GameCenterAchievementImagesV2GetInstanceFieldsGameCenterAchievementLocalization.Version,
                _ => null,
            };
        }
    }
}