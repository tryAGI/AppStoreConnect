
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievementVersion
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
    public static class GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievementVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievementVersion value)
        {
            return value switch
            {
                GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievementVersion.Achievement => "achievement",
                GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievementVersion.Localizations => "localizations",
                GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievementVersion.State => "state",
                GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievementVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievementVersion? ToEnum(string value)
        {
            return value switch
            {
                "achievement" => GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievementVersion.Achievement,
                "localizations" => GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievementVersion.Localizations,
                "state" => GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievementVersion.State,
                "version" => GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterAchievementVersion.Version,
                _ => null,
            };
        }
    }
}