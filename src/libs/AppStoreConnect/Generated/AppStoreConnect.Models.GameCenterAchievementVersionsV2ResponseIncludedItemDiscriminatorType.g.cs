
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAchievementVersionsV2ResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterAchievementLocalizations,
        /// <summary>
        ///
        /// </summary>
        GameCenterAchievements,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterAchievementVersionsV2ResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementVersionsV2ResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                GameCenterAchievementVersionsV2ResponseIncludedItemDiscriminatorType.GameCenterAchievementLocalizations => "gameCenterAchievementLocalizations",
                GameCenterAchievementVersionsV2ResponseIncludedItemDiscriminatorType.GameCenterAchievements => "gameCenterAchievements",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementVersionsV2ResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievementLocalizations" => GameCenterAchievementVersionsV2ResponseIncludedItemDiscriminatorType.GameCenterAchievementLocalizations,
                "gameCenterAchievements" => GameCenterAchievementVersionsV2ResponseIncludedItemDiscriminatorType.GameCenterAchievements,
                _ => null,
            };
        }
    }
}