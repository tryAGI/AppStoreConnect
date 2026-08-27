
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterAchievementVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterAchievementVersion
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
    public static class GameCenterAchievementVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterAchievementVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterAchievementVersion value)
        {
            return value switch
            {
                GameCenterAchievementVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterAchievementVersion.Achievement => "achievement",
                GameCenterAchievementVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterAchievementVersion.Localizations => "localizations",
                GameCenterAchievementVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterAchievementVersion.State => "state",
                GameCenterAchievementVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterAchievementVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterAchievementVersion? ToEnum(string value)
        {
            return value switch
            {
                "achievement" => GameCenterAchievementVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterAchievementVersion.Achievement,
                "localizations" => GameCenterAchievementVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterAchievementVersion.Localizations,
                "state" => GameCenterAchievementVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterAchievementVersion.State,
                "version" => GameCenterAchievementVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterAchievementVersion.Version,
                _ => null,
            };
        }
    }
}