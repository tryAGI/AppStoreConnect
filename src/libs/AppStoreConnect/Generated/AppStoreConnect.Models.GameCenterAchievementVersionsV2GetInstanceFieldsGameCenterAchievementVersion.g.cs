
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAchievementVersionsV2GetInstanceFieldsGameCenterAchievementVersion
    {
        /// <summary>
        ///
        /// </summary>
        Achievement,
        /// <summary>
        ///
        /// </summary>
        Localizations,
        /// <summary>
        ///
        /// </summary>
        State,
        /// <summary>
        ///
        /// </summary>
        Version,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterAchievementVersionsV2GetInstanceFieldsGameCenterAchievementVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementVersionsV2GetInstanceFieldsGameCenterAchievementVersion value)
        {
            return value switch
            {
                GameCenterAchievementVersionsV2GetInstanceFieldsGameCenterAchievementVersion.Achievement => "achievement",
                GameCenterAchievementVersionsV2GetInstanceFieldsGameCenterAchievementVersion.Localizations => "localizations",
                GameCenterAchievementVersionsV2GetInstanceFieldsGameCenterAchievementVersion.State => "state",
                GameCenterAchievementVersionsV2GetInstanceFieldsGameCenterAchievementVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementVersionsV2GetInstanceFieldsGameCenterAchievementVersion? ToEnum(string value)
        {
            return value switch
            {
                "achievement" => GameCenterAchievementVersionsV2GetInstanceFieldsGameCenterAchievementVersion.Achievement,
                "localizations" => GameCenterAchievementVersionsV2GetInstanceFieldsGameCenterAchievementVersion.Localizations,
                "state" => GameCenterAchievementVersionsV2GetInstanceFieldsGameCenterAchievementVersion.State,
                "version" => GameCenterAchievementVersionsV2GetInstanceFieldsGameCenterAchievementVersion.Version,
                _ => null,
            };
        }
    }
}