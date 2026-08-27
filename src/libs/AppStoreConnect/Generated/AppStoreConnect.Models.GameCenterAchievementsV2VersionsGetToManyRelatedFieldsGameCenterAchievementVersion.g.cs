
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementVersion
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
    public static class GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementVersion value)
        {
            return value switch
            {
                GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementVersion.Achievement => "achievement",
                GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementVersion.Localizations => "localizations",
                GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementVersion.State => "state",
                GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementVersion? ToEnum(string value)
        {
            return value switch
            {
                "achievement" => GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementVersion.Achievement,
                "localizations" => GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementVersion.Localizations,
                "state" => GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementVersion.State,
                "version" => GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementVersion.Version,
                _ => null,
            };
        }
    }
}