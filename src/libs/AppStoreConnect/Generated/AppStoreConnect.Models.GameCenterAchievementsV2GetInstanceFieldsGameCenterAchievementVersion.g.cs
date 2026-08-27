
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterAchievementsV2GetInstanceFieldsGameCenterAchievementVersion
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
    public static class GameCenterAchievementsV2GetInstanceFieldsGameCenterAchievementVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementsV2GetInstanceFieldsGameCenterAchievementVersion value)
        {
            return value switch
            {
                GameCenterAchievementsV2GetInstanceFieldsGameCenterAchievementVersion.Achievement => "achievement",
                GameCenterAchievementsV2GetInstanceFieldsGameCenterAchievementVersion.Localizations => "localizations",
                GameCenterAchievementsV2GetInstanceFieldsGameCenterAchievementVersion.State => "state",
                GameCenterAchievementsV2GetInstanceFieldsGameCenterAchievementVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementsV2GetInstanceFieldsGameCenterAchievementVersion? ToEnum(string value)
        {
            return value switch
            {
                "achievement" => GameCenterAchievementsV2GetInstanceFieldsGameCenterAchievementVersion.Achievement,
                "localizations" => GameCenterAchievementsV2GetInstanceFieldsGameCenterAchievementVersion.Localizations,
                "state" => GameCenterAchievementsV2GetInstanceFieldsGameCenterAchievementVersion.State,
                "version" => GameCenterAchievementsV2GetInstanceFieldsGameCenterAchievementVersion.Version,
                _ => null,
            };
        }
    }
}