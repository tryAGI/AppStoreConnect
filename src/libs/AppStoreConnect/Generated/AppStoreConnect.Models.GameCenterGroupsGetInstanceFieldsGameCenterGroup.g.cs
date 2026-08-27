
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterGroupsGetInstanceFieldsGameCenterGroup
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
        /// <summary>
        ///
        /// </summary>
        ReferenceName,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterGroupsGetInstanceFieldsGameCenterGroupExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupsGetInstanceFieldsGameCenterGroup value)
        {
            return value switch
            {
                GameCenterGroupsGetInstanceFieldsGameCenterGroup.GameCenterAchievements => "gameCenterAchievements",
                GameCenterGroupsGetInstanceFieldsGameCenterGroup.GameCenterAchievementsV2 => "gameCenterAchievementsV2",
                GameCenterGroupsGetInstanceFieldsGameCenterGroup.GameCenterActivities => "gameCenterActivities",
                GameCenterGroupsGetInstanceFieldsGameCenterGroup.GameCenterChallenges => "gameCenterChallenges",
                GameCenterGroupsGetInstanceFieldsGameCenterGroup.GameCenterDetails => "gameCenterDetails",
                GameCenterGroupsGetInstanceFieldsGameCenterGroup.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                GameCenterGroupsGetInstanceFieldsGameCenterGroup.GameCenterLeaderboardSetsV2 => "gameCenterLeaderboardSetsV2",
                GameCenterGroupsGetInstanceFieldsGameCenterGroup.GameCenterLeaderboards => "gameCenterLeaderboards",
                GameCenterGroupsGetInstanceFieldsGameCenterGroup.GameCenterLeaderboardsV2 => "gameCenterLeaderboardsV2",
                GameCenterGroupsGetInstanceFieldsGameCenterGroup.ReferenceName => "referenceName",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupsGetInstanceFieldsGameCenterGroup? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievements" => GameCenterGroupsGetInstanceFieldsGameCenterGroup.GameCenterAchievements,
                "gameCenterAchievementsV2" => GameCenterGroupsGetInstanceFieldsGameCenterGroup.GameCenterAchievementsV2,
                "gameCenterActivities" => GameCenterGroupsGetInstanceFieldsGameCenterGroup.GameCenterActivities,
                "gameCenterChallenges" => GameCenterGroupsGetInstanceFieldsGameCenterGroup.GameCenterChallenges,
                "gameCenterDetails" => GameCenterGroupsGetInstanceFieldsGameCenterGroup.GameCenterDetails,
                "gameCenterLeaderboardSets" => GameCenterGroupsGetInstanceFieldsGameCenterGroup.GameCenterLeaderboardSets,
                "gameCenterLeaderboardSetsV2" => GameCenterGroupsGetInstanceFieldsGameCenterGroup.GameCenterLeaderboardSetsV2,
                "gameCenterLeaderboards" => GameCenterGroupsGetInstanceFieldsGameCenterGroup.GameCenterLeaderboards,
                "gameCenterLeaderboardsV2" => GameCenterGroupsGetInstanceFieldsGameCenterGroup.GameCenterLeaderboardsV2,
                "referenceName" => GameCenterGroupsGetInstanceFieldsGameCenterGroup.ReferenceName,
                _ => null,
            };
        }
    }
}