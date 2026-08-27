
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterGroup
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
    public static class GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterGroupExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterGroup value)
        {
            return value switch
            {
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterGroup.GameCenterAchievements => "gameCenterAchievements",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterGroup.GameCenterAchievementsV2 => "gameCenterAchievementsV2",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterGroup.GameCenterActivities => "gameCenterActivities",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterGroup.GameCenterChallenges => "gameCenterChallenges",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterGroup.GameCenterDetails => "gameCenterDetails",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterGroup.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterGroup.GameCenterLeaderboardSetsV2 => "gameCenterLeaderboardSetsV2",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterGroup.GameCenterLeaderboards => "gameCenterLeaderboards",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterGroup.GameCenterLeaderboardsV2 => "gameCenterLeaderboardsV2",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterGroup.ReferenceName => "referenceName",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterGroup? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievements" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterGroup.GameCenterAchievements,
                "gameCenterAchievementsV2" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterGroup.GameCenterAchievementsV2,
                "gameCenterActivities" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterGroup.GameCenterActivities,
                "gameCenterChallenges" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterGroup.GameCenterChallenges,
                "gameCenterDetails" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterGroup.GameCenterDetails,
                "gameCenterLeaderboardSets" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterGroup.GameCenterLeaderboardSets,
                "gameCenterLeaderboardSetsV2" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterGroup.GameCenterLeaderboardSetsV2,
                "gameCenterLeaderboards" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterGroup.GameCenterLeaderboards,
                "gameCenterLeaderboardsV2" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterGroup.GameCenterLeaderboardsV2,
                "referenceName" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterGroup.ReferenceName,
                _ => null,
            };
        }
    }
}