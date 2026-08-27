
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAchievementReleasesResponseIncludedItemDiscriminatorType
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
    public static class GameCenterAchievementReleasesResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementReleasesResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                GameCenterAchievementReleasesResponseIncludedItemDiscriminatorType.GameCenterAchievements => "gameCenterAchievements",
                GameCenterAchievementReleasesResponseIncludedItemDiscriminatorType.GameCenterDetails => "gameCenterDetails",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementReleasesResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievements" => GameCenterAchievementReleasesResponseIncludedItemDiscriminatorType.GameCenterAchievements,
                "gameCenterDetails" => GameCenterAchievementReleasesResponseIncludedItemDiscriminatorType.GameCenterDetails,
                _ => null,
            };
        }
    }
}