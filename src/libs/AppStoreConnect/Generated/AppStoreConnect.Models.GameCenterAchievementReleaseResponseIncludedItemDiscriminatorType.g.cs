
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAchievementReleaseResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterAchievements,
        /// <summary>
        ///
        /// </summary>
        GameCenterDetails,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterAchievementReleaseResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementReleaseResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                GameCenterAchievementReleaseResponseIncludedItemDiscriminatorType.GameCenterAchievements => "gameCenterAchievements",
                GameCenterAchievementReleaseResponseIncludedItemDiscriminatorType.GameCenterDetails => "gameCenterDetails",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementReleaseResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievements" => GameCenterAchievementReleaseResponseIncludedItemDiscriminatorType.GameCenterAchievements,
                "gameCenterDetails" => GameCenterAchievementReleaseResponseIncludedItemDiscriminatorType.GameCenterDetails,
                _ => null,
            };
        }
    }
}