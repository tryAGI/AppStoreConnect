
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterAchievementLocalizationsV2GetInstanceFieldsGameCenterAchievementVersion
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
    public static class GameCenterAchievementLocalizationsV2GetInstanceFieldsGameCenterAchievementVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementLocalizationsV2GetInstanceFieldsGameCenterAchievementVersion value)
        {
            return value switch
            {
                GameCenterAchievementLocalizationsV2GetInstanceFieldsGameCenterAchievementVersion.Achievement => "achievement",
                GameCenterAchievementLocalizationsV2GetInstanceFieldsGameCenterAchievementVersion.Localizations => "localizations",
                GameCenterAchievementLocalizationsV2GetInstanceFieldsGameCenterAchievementVersion.State => "state",
                GameCenterAchievementLocalizationsV2GetInstanceFieldsGameCenterAchievementVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementLocalizationsV2GetInstanceFieldsGameCenterAchievementVersion? ToEnum(string value)
        {
            return value switch
            {
                "achievement" => GameCenterAchievementLocalizationsV2GetInstanceFieldsGameCenterAchievementVersion.Achievement,
                "localizations" => GameCenterAchievementLocalizationsV2GetInstanceFieldsGameCenterAchievementVersion.Localizations,
                "state" => GameCenterAchievementLocalizationsV2GetInstanceFieldsGameCenterAchievementVersion.State,
                "version" => GameCenterAchievementLocalizationsV2GetInstanceFieldsGameCenterAchievementVersion.Version,
                _ => null,
            };
        }
    }
}