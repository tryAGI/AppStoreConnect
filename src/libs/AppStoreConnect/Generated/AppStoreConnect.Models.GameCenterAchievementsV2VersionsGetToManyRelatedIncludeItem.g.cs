
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAchievementsV2VersionsGetToManyRelatedIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        Achievement,
        /// <summary>
        ///
        /// </summary>
        Localizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterAchievementsV2VersionsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementsV2VersionsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                GameCenterAchievementsV2VersionsGetToManyRelatedIncludeItem.Achievement => "achievement",
                GameCenterAchievementsV2VersionsGetToManyRelatedIncludeItem.Localizations => "localizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementsV2VersionsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "achievement" => GameCenterAchievementsV2VersionsGetToManyRelatedIncludeItem.Achievement,
                "localizations" => GameCenterAchievementsV2VersionsGetToManyRelatedIncludeItem.Localizations,
                _ => null,
            };
        }
    }
}