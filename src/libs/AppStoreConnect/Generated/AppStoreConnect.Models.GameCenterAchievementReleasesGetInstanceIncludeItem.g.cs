
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterAchievementReleasesGetInstanceIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterAchievement,
        /// <summary>
        /// 
        /// </summary>
        GameCenterDetail,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterAchievementReleasesGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementReleasesGetInstanceIncludeItem value)
        {
            return value switch
            {
                GameCenterAchievementReleasesGetInstanceIncludeItem.GameCenterAchievement => "gameCenterAchievement",
                GameCenterAchievementReleasesGetInstanceIncludeItem.GameCenterDetail => "gameCenterDetail",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementReleasesGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievement" => GameCenterAchievementReleasesGetInstanceIncludeItem.GameCenterAchievement,
                "gameCenterDetail" => GameCenterAchievementReleasesGetInstanceIncludeItem.GameCenterDetail,
                _ => null,
            };
        }
    }
}