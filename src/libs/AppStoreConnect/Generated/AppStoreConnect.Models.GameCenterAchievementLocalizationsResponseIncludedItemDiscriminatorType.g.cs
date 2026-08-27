
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterAchievementLocalizationsResponseIncludedItemDiscriminatorType
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
    public static class GameCenterAchievementLocalizationsResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementLocalizationsResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                GameCenterAchievementLocalizationsResponseIncludedItemDiscriminatorType.GameCenterAchievementImages => "gameCenterAchievementImages",
                GameCenterAchievementLocalizationsResponseIncludedItemDiscriminatorType.GameCenterAchievements => "gameCenterAchievements",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementLocalizationsResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievementImages" => GameCenterAchievementLocalizationsResponseIncludedItemDiscriminatorType.GameCenterAchievementImages,
                "gameCenterAchievements" => GameCenterAchievementLocalizationsResponseIncludedItemDiscriminatorType.GameCenterAchievements,
                _ => null,
            };
        }
    }
}