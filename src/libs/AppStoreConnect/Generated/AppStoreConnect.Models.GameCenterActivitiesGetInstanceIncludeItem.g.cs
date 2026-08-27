
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterActivitiesGetInstanceIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        Achievements,
        /// <summary>
        /// 
        /// </summary>
        AchievementsV2,
        /// <summary>
        /// 
        /// </summary>
        GameCenterDetail,
        /// <summary>
        /// 
        /// </summary>
        GameCenterGroup,
        /// <summary>
        /// 
        /// </summary>
        Leaderboards,
        /// <summary>
        /// 
        /// </summary>
        LeaderboardsV2,
        /// <summary>
        /// 
        /// </summary>
        Versions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterActivitiesGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterActivitiesGetInstanceIncludeItem value)
        {
            return value switch
            {
                GameCenterActivitiesGetInstanceIncludeItem.Achievements => "achievements",
                GameCenterActivitiesGetInstanceIncludeItem.AchievementsV2 => "achievementsV2",
                GameCenterActivitiesGetInstanceIncludeItem.GameCenterDetail => "gameCenterDetail",
                GameCenterActivitiesGetInstanceIncludeItem.GameCenterGroup => "gameCenterGroup",
                GameCenterActivitiesGetInstanceIncludeItem.Leaderboards => "leaderboards",
                GameCenterActivitiesGetInstanceIncludeItem.LeaderboardsV2 => "leaderboardsV2",
                GameCenterActivitiesGetInstanceIncludeItem.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterActivitiesGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "achievements" => GameCenterActivitiesGetInstanceIncludeItem.Achievements,
                "achievementsV2" => GameCenterActivitiesGetInstanceIncludeItem.AchievementsV2,
                "gameCenterDetail" => GameCenterActivitiesGetInstanceIncludeItem.GameCenterDetail,
                "gameCenterGroup" => GameCenterActivitiesGetInstanceIncludeItem.GameCenterGroup,
                "leaderboards" => GameCenterActivitiesGetInstanceIncludeItem.Leaderboards,
                "leaderboardsV2" => GameCenterActivitiesGetInstanceIncludeItem.LeaderboardsV2,
                "versions" => GameCenterActivitiesGetInstanceIncludeItem.Versions,
                _ => null,
            };
        }
    }
}