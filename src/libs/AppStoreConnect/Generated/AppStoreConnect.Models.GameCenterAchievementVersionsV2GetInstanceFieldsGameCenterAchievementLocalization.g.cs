
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAchievementVersionsV2GetInstanceFieldsGameCenterAchievementLocalization
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
    public static class GameCenterAchievementVersionsV2GetInstanceFieldsGameCenterAchievementLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementVersionsV2GetInstanceFieldsGameCenterAchievementLocalization value)
        {
            return value switch
            {
                GameCenterAchievementVersionsV2GetInstanceFieldsGameCenterAchievementLocalization.AfterEarnedDescription => "afterEarnedDescription",
                GameCenterAchievementVersionsV2GetInstanceFieldsGameCenterAchievementLocalization.BeforeEarnedDescription => "beforeEarnedDescription",
                GameCenterAchievementVersionsV2GetInstanceFieldsGameCenterAchievementLocalization.Image => "image",
                GameCenterAchievementVersionsV2GetInstanceFieldsGameCenterAchievementLocalization.Locale => "locale",
                GameCenterAchievementVersionsV2GetInstanceFieldsGameCenterAchievementLocalization.Name => "name",
                GameCenterAchievementVersionsV2GetInstanceFieldsGameCenterAchievementLocalization.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementVersionsV2GetInstanceFieldsGameCenterAchievementLocalization? ToEnum(string value)
        {
            return value switch
            {
                "afterEarnedDescription" => GameCenterAchievementVersionsV2GetInstanceFieldsGameCenterAchievementLocalization.AfterEarnedDescription,
                "beforeEarnedDescription" => GameCenterAchievementVersionsV2GetInstanceFieldsGameCenterAchievementLocalization.BeforeEarnedDescription,
                "image" => GameCenterAchievementVersionsV2GetInstanceFieldsGameCenterAchievementLocalization.Image,
                "locale" => GameCenterAchievementVersionsV2GetInstanceFieldsGameCenterAchievementLocalization.Locale,
                "name" => GameCenterAchievementVersionsV2GetInstanceFieldsGameCenterAchievementLocalization.Name,
                "version" => GameCenterAchievementVersionsV2GetInstanceFieldsGameCenterAchievementLocalization.Version,
                _ => null,
            };
        }
    }
}