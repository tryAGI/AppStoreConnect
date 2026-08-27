
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterGroup
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
    public static class GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterGroupExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterGroup value)
        {
            return value switch
            {
                GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterGroup.GameCenterAchievements => "gameCenterAchievements",
                GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterGroup.GameCenterAchievementsV2 => "gameCenterAchievementsV2",
                GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterGroup.GameCenterActivities => "gameCenterActivities",
                GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterGroup.GameCenterChallenges => "gameCenterChallenges",
                GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterGroup.GameCenterDetails => "gameCenterDetails",
                GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterGroup.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterGroup.GameCenterLeaderboardSetsV2 => "gameCenterLeaderboardSetsV2",
                GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterGroup.GameCenterLeaderboards => "gameCenterLeaderboards",
                GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterGroup.GameCenterLeaderboardsV2 => "gameCenterLeaderboardsV2",
                GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterGroup.ReferenceName => "referenceName",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterGroup? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievements" => GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterGroup.GameCenterAchievements,
                "gameCenterAchievementsV2" => GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterGroup.GameCenterAchievementsV2,
                "gameCenterActivities" => GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterGroup.GameCenterActivities,
                "gameCenterChallenges" => GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterGroup.GameCenterChallenges,
                "gameCenterDetails" => GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterGroup.GameCenterDetails,
                "gameCenterLeaderboardSets" => GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterGroup.GameCenterLeaderboardSets,
                "gameCenterLeaderboardSetsV2" => GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterGroup.GameCenterLeaderboardSetsV2,
                "gameCenterLeaderboards" => GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterGroup.GameCenterLeaderboards,
                "gameCenterLeaderboardsV2" => GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterGroup.GameCenterLeaderboardsV2,
                "referenceName" => GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterGroup.ReferenceName,
                _ => null,
            };
        }
    }
}