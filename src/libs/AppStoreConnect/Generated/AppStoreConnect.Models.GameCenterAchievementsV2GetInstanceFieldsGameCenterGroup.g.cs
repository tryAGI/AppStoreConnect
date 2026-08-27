
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAchievementsV2GetInstanceFieldsGameCenterGroup
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
    public static class GameCenterAchievementsV2GetInstanceFieldsGameCenterGroupExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementsV2GetInstanceFieldsGameCenterGroup value)
        {
            return value switch
            {
                GameCenterAchievementsV2GetInstanceFieldsGameCenterGroup.GameCenterAchievements => "gameCenterAchievements",
                GameCenterAchievementsV2GetInstanceFieldsGameCenterGroup.GameCenterAchievementsV2 => "gameCenterAchievementsV2",
                GameCenterAchievementsV2GetInstanceFieldsGameCenterGroup.GameCenterActivities => "gameCenterActivities",
                GameCenterAchievementsV2GetInstanceFieldsGameCenterGroup.GameCenterChallenges => "gameCenterChallenges",
                GameCenterAchievementsV2GetInstanceFieldsGameCenterGroup.GameCenterDetails => "gameCenterDetails",
                GameCenterAchievementsV2GetInstanceFieldsGameCenterGroup.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                GameCenterAchievementsV2GetInstanceFieldsGameCenterGroup.GameCenterLeaderboardSetsV2 => "gameCenterLeaderboardSetsV2",
                GameCenterAchievementsV2GetInstanceFieldsGameCenterGroup.GameCenterLeaderboards => "gameCenterLeaderboards",
                GameCenterAchievementsV2GetInstanceFieldsGameCenterGroup.GameCenterLeaderboardsV2 => "gameCenterLeaderboardsV2",
                GameCenterAchievementsV2GetInstanceFieldsGameCenterGroup.ReferenceName => "referenceName",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementsV2GetInstanceFieldsGameCenterGroup? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievements" => GameCenterAchievementsV2GetInstanceFieldsGameCenterGroup.GameCenterAchievements,
                "gameCenterAchievementsV2" => GameCenterAchievementsV2GetInstanceFieldsGameCenterGroup.GameCenterAchievementsV2,
                "gameCenterActivities" => GameCenterAchievementsV2GetInstanceFieldsGameCenterGroup.GameCenterActivities,
                "gameCenterChallenges" => GameCenterAchievementsV2GetInstanceFieldsGameCenterGroup.GameCenterChallenges,
                "gameCenterDetails" => GameCenterAchievementsV2GetInstanceFieldsGameCenterGroup.GameCenterDetails,
                "gameCenterLeaderboardSets" => GameCenterAchievementsV2GetInstanceFieldsGameCenterGroup.GameCenterLeaderboardSets,
                "gameCenterLeaderboardSetsV2" => GameCenterAchievementsV2GetInstanceFieldsGameCenterGroup.GameCenterLeaderboardSetsV2,
                "gameCenterLeaderboards" => GameCenterAchievementsV2GetInstanceFieldsGameCenterGroup.GameCenterLeaderboards,
                "gameCenterLeaderboardsV2" => GameCenterAchievementsV2GetInstanceFieldsGameCenterGroup.GameCenterLeaderboardsV2,
                "referenceName" => GameCenterAchievementsV2GetInstanceFieldsGameCenterGroup.ReferenceName,
                _ => null,
            };
        }
    }
}