
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAchievementLocalizationResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterAchievementImages,
        /// <summary>
        ///
        /// </summary>
        GameCenterAchievements,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterAchievementLocalizationResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementLocalizationResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                GameCenterAchievementLocalizationResponseIncludedItemDiscriminatorType.GameCenterAchievementImages => "gameCenterAchievementImages",
                GameCenterAchievementLocalizationResponseIncludedItemDiscriminatorType.GameCenterAchievements => "gameCenterAchievements",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementLocalizationResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievementImages" => GameCenterAchievementLocalizationResponseIncludedItemDiscriminatorType.GameCenterAchievementImages,
                "gameCenterAchievements" => GameCenterAchievementLocalizationResponseIncludedItemDiscriminatorType.GameCenterAchievements,
                _ => null,
            };
        }
    }
}