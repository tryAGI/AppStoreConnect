
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterAchievementsGetInstanceFieldsGameCenterAchievementRelease
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
    public static class GameCenterAchievementsGetInstanceFieldsGameCenterAchievementReleaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementsGetInstanceFieldsGameCenterAchievementRelease value)
        {
            return value switch
            {
                GameCenterAchievementsGetInstanceFieldsGameCenterAchievementRelease.GameCenterAchievement => "gameCenterAchievement",
                GameCenterAchievementsGetInstanceFieldsGameCenterAchievementRelease.GameCenterDetail => "gameCenterDetail",
                GameCenterAchievementsGetInstanceFieldsGameCenterAchievementRelease.Live => "live",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementsGetInstanceFieldsGameCenterAchievementRelease? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievement" => GameCenterAchievementsGetInstanceFieldsGameCenterAchievementRelease.GameCenterAchievement,
                "gameCenterDetail" => GameCenterAchievementsGetInstanceFieldsGameCenterAchievementRelease.GameCenterDetail,
                "live" => GameCenterAchievementsGetInstanceFieldsGameCenterAchievementRelease.Live,
                _ => null,
            };
        }
    }
}