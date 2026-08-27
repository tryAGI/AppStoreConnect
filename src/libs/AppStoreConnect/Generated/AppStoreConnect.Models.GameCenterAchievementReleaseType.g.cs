
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAchievementReleaseType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterAchievementReleases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterAchievementReleaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementReleaseType value)
        {
            return value switch
            {
                GameCenterAchievementReleaseType.GameCenterAchievementReleases => "gameCenterAchievementReleases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementReleaseType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievementReleases" => GameCenterAchievementReleaseType.GameCenterAchievementReleases,
                _ => null,
            };
        }
    }
}