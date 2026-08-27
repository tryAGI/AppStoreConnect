
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAchievementVersionV2ResponseIncludedItemDiscriminatorType
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
    public static class GameCenterAchievementVersionV2ResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementVersionV2ResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                GameCenterAchievementVersionV2ResponseIncludedItemDiscriminatorType.GameCenterAchievementLocalizations => "gameCenterAchievementLocalizations",
                GameCenterAchievementVersionV2ResponseIncludedItemDiscriminatorType.GameCenterAchievements => "gameCenterAchievements",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementVersionV2ResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievementLocalizations" => GameCenterAchievementVersionV2ResponseIncludedItemDiscriminatorType.GameCenterAchievementLocalizations,
                "gameCenterAchievements" => GameCenterAchievementVersionV2ResponseIncludedItemDiscriminatorType.GameCenterAchievements,
                _ => null,
            };
        }
    }
}