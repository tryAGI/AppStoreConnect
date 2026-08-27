
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterDetailsGameCenterActivitiesGetToManyRelatedIncludeItem
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
    public static class GameCenterDetailsGameCenterActivitiesGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsGameCenterActivitiesGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                GameCenterDetailsGameCenterActivitiesGetToManyRelatedIncludeItem.Achievements => "achievements",
                GameCenterDetailsGameCenterActivitiesGetToManyRelatedIncludeItem.AchievementsV2 => "achievementsV2",
                GameCenterDetailsGameCenterActivitiesGetToManyRelatedIncludeItem.GameCenterDetail => "gameCenterDetail",
                GameCenterDetailsGameCenterActivitiesGetToManyRelatedIncludeItem.GameCenterGroup => "gameCenterGroup",
                GameCenterDetailsGameCenterActivitiesGetToManyRelatedIncludeItem.Leaderboards => "leaderboards",
                GameCenterDetailsGameCenterActivitiesGetToManyRelatedIncludeItem.LeaderboardsV2 => "leaderboardsV2",
                GameCenterDetailsGameCenterActivitiesGetToManyRelatedIncludeItem.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsGameCenterActivitiesGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "achievements" => GameCenterDetailsGameCenterActivitiesGetToManyRelatedIncludeItem.Achievements,
                "achievementsV2" => GameCenterDetailsGameCenterActivitiesGetToManyRelatedIncludeItem.AchievementsV2,
                "gameCenterDetail" => GameCenterDetailsGameCenterActivitiesGetToManyRelatedIncludeItem.GameCenterDetail,
                "gameCenterGroup" => GameCenterDetailsGameCenterActivitiesGetToManyRelatedIncludeItem.GameCenterGroup,
                "leaderboards" => GameCenterDetailsGameCenterActivitiesGetToManyRelatedIncludeItem.Leaderboards,
                "leaderboardsV2" => GameCenterDetailsGameCenterActivitiesGetToManyRelatedIncludeItem.LeaderboardsV2,
                "versions" => GameCenterDetailsGameCenterActivitiesGetToManyRelatedIncludeItem.Versions,
                _ => null,
            };
        }
    }
}