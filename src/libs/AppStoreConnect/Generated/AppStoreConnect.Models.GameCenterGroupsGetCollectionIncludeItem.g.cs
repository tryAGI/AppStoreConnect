
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterGroupsGetCollectionIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterAchievements,
        /// <summary>
        ///
        /// </summary>
        GameCenterAchievementsV2,
        /// <summary>
        ///
        /// </summary>
        GameCenterActivities,
        /// <summary>
        ///
        /// </summary>
        GameCenterChallenges,
        /// <summary>
        ///
        /// </summary>
        GameCenterDetails,
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboardSets,
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboardSetsV2,
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboards,
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboardsV2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterGroupsGetCollectionIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupsGetCollectionIncludeItem value)
        {
            return value switch
            {
                GameCenterGroupsGetCollectionIncludeItem.GameCenterAchievements => "gameCenterAchievements",
                GameCenterGroupsGetCollectionIncludeItem.GameCenterAchievementsV2 => "gameCenterAchievementsV2",
                GameCenterGroupsGetCollectionIncludeItem.GameCenterActivities => "gameCenterActivities",
                GameCenterGroupsGetCollectionIncludeItem.GameCenterChallenges => "gameCenterChallenges",
                GameCenterGroupsGetCollectionIncludeItem.GameCenterDetails => "gameCenterDetails",
                GameCenterGroupsGetCollectionIncludeItem.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                GameCenterGroupsGetCollectionIncludeItem.GameCenterLeaderboardSetsV2 => "gameCenterLeaderboardSetsV2",
                GameCenterGroupsGetCollectionIncludeItem.GameCenterLeaderboards => "gameCenterLeaderboards",
                GameCenterGroupsGetCollectionIncludeItem.GameCenterLeaderboardsV2 => "gameCenterLeaderboardsV2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupsGetCollectionIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievements" => GameCenterGroupsGetCollectionIncludeItem.GameCenterAchievements,
                "gameCenterAchievementsV2" => GameCenterGroupsGetCollectionIncludeItem.GameCenterAchievementsV2,
                "gameCenterActivities" => GameCenterGroupsGetCollectionIncludeItem.GameCenterActivities,
                "gameCenterChallenges" => GameCenterGroupsGetCollectionIncludeItem.GameCenterChallenges,
                "gameCenterDetails" => GameCenterGroupsGetCollectionIncludeItem.GameCenterDetails,
                "gameCenterLeaderboardSets" => GameCenterGroupsGetCollectionIncludeItem.GameCenterLeaderboardSets,
                "gameCenterLeaderboardSetsV2" => GameCenterGroupsGetCollectionIncludeItem.GameCenterLeaderboardSetsV2,
                "gameCenterLeaderboards" => GameCenterGroupsGetCollectionIncludeItem.GameCenterLeaderboards,
                "gameCenterLeaderboardsV2" => GameCenterGroupsGetCollectionIncludeItem.GameCenterLeaderboardsV2,
                _ => null,
            };
        }
    }
}