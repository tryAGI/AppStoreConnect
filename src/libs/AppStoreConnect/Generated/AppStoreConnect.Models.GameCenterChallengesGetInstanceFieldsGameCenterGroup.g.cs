
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterChallengesGetInstanceFieldsGameCenterGroup
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
    public static class GameCenterChallengesGetInstanceFieldsGameCenterGroupExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterChallengesGetInstanceFieldsGameCenterGroup value)
        {
            return value switch
            {
                GameCenterChallengesGetInstanceFieldsGameCenterGroup.GameCenterAchievements => "gameCenterAchievements",
                GameCenterChallengesGetInstanceFieldsGameCenterGroup.GameCenterAchievementsV2 => "gameCenterAchievementsV2",
                GameCenterChallengesGetInstanceFieldsGameCenterGroup.GameCenterActivities => "gameCenterActivities",
                GameCenterChallengesGetInstanceFieldsGameCenterGroup.GameCenterChallenges => "gameCenterChallenges",
                GameCenterChallengesGetInstanceFieldsGameCenterGroup.GameCenterDetails => "gameCenterDetails",
                GameCenterChallengesGetInstanceFieldsGameCenterGroup.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                GameCenterChallengesGetInstanceFieldsGameCenterGroup.GameCenterLeaderboardSetsV2 => "gameCenterLeaderboardSetsV2",
                GameCenterChallengesGetInstanceFieldsGameCenterGroup.GameCenterLeaderboards => "gameCenterLeaderboards",
                GameCenterChallengesGetInstanceFieldsGameCenterGroup.GameCenterLeaderboardsV2 => "gameCenterLeaderboardsV2",
                GameCenterChallengesGetInstanceFieldsGameCenterGroup.ReferenceName => "referenceName",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterChallengesGetInstanceFieldsGameCenterGroup? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievements" => GameCenterChallengesGetInstanceFieldsGameCenterGroup.GameCenterAchievements,
                "gameCenterAchievementsV2" => GameCenterChallengesGetInstanceFieldsGameCenterGroup.GameCenterAchievementsV2,
                "gameCenterActivities" => GameCenterChallengesGetInstanceFieldsGameCenterGroup.GameCenterActivities,
                "gameCenterChallenges" => GameCenterChallengesGetInstanceFieldsGameCenterGroup.GameCenterChallenges,
                "gameCenterDetails" => GameCenterChallengesGetInstanceFieldsGameCenterGroup.GameCenterDetails,
                "gameCenterLeaderboardSets" => GameCenterChallengesGetInstanceFieldsGameCenterGroup.GameCenterLeaderboardSets,
                "gameCenterLeaderboardSetsV2" => GameCenterChallengesGetInstanceFieldsGameCenterGroup.GameCenterLeaderboardSetsV2,
                "gameCenterLeaderboards" => GameCenterChallengesGetInstanceFieldsGameCenterGroup.GameCenterLeaderboards,
                "gameCenterLeaderboardsV2" => GameCenterChallengesGetInstanceFieldsGameCenterGroup.GameCenterLeaderboardsV2,
                "referenceName" => GameCenterChallengesGetInstanceFieldsGameCenterGroup.ReferenceName,
                _ => null,
            };
        }
    }
}