
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterDetailsGetInstanceFieldsGameCenterAchievementRelease
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterAchievement,
        /// <summary>
        ///
        /// </summary>
        GameCenterDetail,
        /// <summary>
        ///
        /// </summary>
        Live,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterDetailsGetInstanceFieldsGameCenterAchievementReleaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsGetInstanceFieldsGameCenterAchievementRelease value)
        {
            return value switch
            {
                GameCenterDetailsGetInstanceFieldsGameCenterAchievementRelease.GameCenterAchievement => "gameCenterAchievement",
                GameCenterDetailsGetInstanceFieldsGameCenterAchievementRelease.GameCenterDetail => "gameCenterDetail",
                GameCenterDetailsGetInstanceFieldsGameCenterAchievementRelease.Live => "live",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsGetInstanceFieldsGameCenterAchievementRelease? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievement" => GameCenterDetailsGetInstanceFieldsGameCenterAchievementRelease.GameCenterAchievement,
                "gameCenterDetail" => GameCenterDetailsGetInstanceFieldsGameCenterAchievementRelease.GameCenterDetail,
                "live" => GameCenterDetailsGetInstanceFieldsGameCenterAchievementRelease.Live,
                _ => null,
            };
        }
    }
}