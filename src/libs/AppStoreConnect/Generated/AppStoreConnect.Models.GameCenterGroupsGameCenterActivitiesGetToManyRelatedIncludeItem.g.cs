
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterGroupsGameCenterActivitiesGetToManyRelatedIncludeItem
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
    public static class GameCenterGroupsGameCenterActivitiesGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupsGameCenterActivitiesGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                GameCenterGroupsGameCenterActivitiesGetToManyRelatedIncludeItem.Achievements => "achievements",
                GameCenterGroupsGameCenterActivitiesGetToManyRelatedIncludeItem.AchievementsV2 => "achievementsV2",
                GameCenterGroupsGameCenterActivitiesGetToManyRelatedIncludeItem.GameCenterDetail => "gameCenterDetail",
                GameCenterGroupsGameCenterActivitiesGetToManyRelatedIncludeItem.GameCenterGroup => "gameCenterGroup",
                GameCenterGroupsGameCenterActivitiesGetToManyRelatedIncludeItem.Leaderboards => "leaderboards",
                GameCenterGroupsGameCenterActivitiesGetToManyRelatedIncludeItem.LeaderboardsV2 => "leaderboardsV2",
                GameCenterGroupsGameCenterActivitiesGetToManyRelatedIncludeItem.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupsGameCenterActivitiesGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "achievements" => GameCenterGroupsGameCenterActivitiesGetToManyRelatedIncludeItem.Achievements,
                "achievementsV2" => GameCenterGroupsGameCenterActivitiesGetToManyRelatedIncludeItem.AchievementsV2,
                "gameCenterDetail" => GameCenterGroupsGameCenterActivitiesGetToManyRelatedIncludeItem.GameCenterDetail,
                "gameCenterGroup" => GameCenterGroupsGameCenterActivitiesGetToManyRelatedIncludeItem.GameCenterGroup,
                "leaderboards" => GameCenterGroupsGameCenterActivitiesGetToManyRelatedIncludeItem.Leaderboards,
                "leaderboardsV2" => GameCenterGroupsGameCenterActivitiesGetToManyRelatedIncludeItem.LeaderboardsV2,
                "versions" => GameCenterGroupsGameCenterActivitiesGetToManyRelatedIncludeItem.Versions,
                _ => null,
            };
        }
    }
}