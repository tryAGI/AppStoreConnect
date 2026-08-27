
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterAchievementReleasesGetInstanceFieldsGameCenterAchievementRelease
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
    public static class GameCenterAchievementReleasesGetInstanceFieldsGameCenterAchievementReleaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementReleasesGetInstanceFieldsGameCenterAchievementRelease value)
        {
            return value switch
            {
                GameCenterAchievementReleasesGetInstanceFieldsGameCenterAchievementRelease.GameCenterAchievement => "gameCenterAchievement",
                GameCenterAchievementReleasesGetInstanceFieldsGameCenterAchievementRelease.GameCenterDetail => "gameCenterDetail",
                GameCenterAchievementReleasesGetInstanceFieldsGameCenterAchievementRelease.Live => "live",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementReleasesGetInstanceFieldsGameCenterAchievementRelease? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievement" => GameCenterAchievementReleasesGetInstanceFieldsGameCenterAchievementRelease.GameCenterAchievement,
                "gameCenterDetail" => GameCenterAchievementReleasesGetInstanceFieldsGameCenterAchievementRelease.GameCenterDetail,
                "live" => GameCenterAchievementReleasesGetInstanceFieldsGameCenterAchievementRelease.Live,
                _ => null,
            };
        }
    }
}