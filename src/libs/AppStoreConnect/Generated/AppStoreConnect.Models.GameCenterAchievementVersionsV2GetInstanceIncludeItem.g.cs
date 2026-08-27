
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAchievementVersionsV2GetInstanceIncludeItem
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
    public static class GameCenterAchievementVersionsV2GetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementVersionsV2GetInstanceIncludeItem value)
        {
            return value switch
            {
                GameCenterAchievementVersionsV2GetInstanceIncludeItem.Achievement => "achievement",
                GameCenterAchievementVersionsV2GetInstanceIncludeItem.Localizations => "localizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementVersionsV2GetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "achievement" => GameCenterAchievementVersionsV2GetInstanceIncludeItem.Achievement,
                "localizations" => GameCenterAchievementVersionsV2GetInstanceIncludeItem.Localizations,
                _ => null,
            };
        }
    }
}