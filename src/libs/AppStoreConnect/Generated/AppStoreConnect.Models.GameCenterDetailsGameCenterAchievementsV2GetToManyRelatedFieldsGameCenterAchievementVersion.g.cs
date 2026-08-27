
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievementVersion
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
    public static class GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievementVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievementVersion value)
        {
            return value switch
            {
                GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievementVersion.Achievement => "achievement",
                GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievementVersion.Localizations => "localizations",
                GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievementVersion.State => "state",
                GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievementVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievementVersion? ToEnum(string value)
        {
            return value switch
            {
                "achievement" => GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievementVersion.Achievement,
                "localizations" => GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievementVersion.Localizations,
                "state" => GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievementVersion.State,
                "version" => GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievementVersion.Version,
                _ => null,
            };
        }
    }
}