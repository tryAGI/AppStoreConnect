
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterGroupsGetInstanceIncludeItem
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
    public static class GameCenterGroupsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupsGetInstanceIncludeItem value)
        {
            return value switch
            {
                GameCenterGroupsGetInstanceIncludeItem.GameCenterAchievements => "gameCenterAchievements",
                GameCenterGroupsGetInstanceIncludeItem.GameCenterAchievementsV2 => "gameCenterAchievementsV2",
                GameCenterGroupsGetInstanceIncludeItem.GameCenterActivities => "gameCenterActivities",
                GameCenterGroupsGetInstanceIncludeItem.GameCenterChallenges => "gameCenterChallenges",
                GameCenterGroupsGetInstanceIncludeItem.GameCenterDetails => "gameCenterDetails",
                GameCenterGroupsGetInstanceIncludeItem.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                GameCenterGroupsGetInstanceIncludeItem.GameCenterLeaderboardSetsV2 => "gameCenterLeaderboardSetsV2",
                GameCenterGroupsGetInstanceIncludeItem.GameCenterLeaderboards => "gameCenterLeaderboards",
                GameCenterGroupsGetInstanceIncludeItem.GameCenterLeaderboardsV2 => "gameCenterLeaderboardsV2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievements" => GameCenterGroupsGetInstanceIncludeItem.GameCenterAchievements,
                "gameCenterAchievementsV2" => GameCenterGroupsGetInstanceIncludeItem.GameCenterAchievementsV2,
                "gameCenterActivities" => GameCenterGroupsGetInstanceIncludeItem.GameCenterActivities,
                "gameCenterChallenges" => GameCenterGroupsGetInstanceIncludeItem.GameCenterChallenges,
                "gameCenterDetails" => GameCenterGroupsGetInstanceIncludeItem.GameCenterDetails,
                "gameCenterLeaderboardSets" => GameCenterGroupsGetInstanceIncludeItem.GameCenterLeaderboardSets,
                "gameCenterLeaderboardSetsV2" => GameCenterGroupsGetInstanceIncludeItem.GameCenterLeaderboardSetsV2,
                "gameCenterLeaderboards" => GameCenterGroupsGetInstanceIncludeItem.GameCenterLeaderboards,
                "gameCenterLeaderboardsV2" => GameCenterGroupsGetInstanceIncludeItem.GameCenterLeaderboardsV2,
                _ => null,
            };
        }
    }
}