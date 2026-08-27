
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterGroup
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
    public static class GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterGroupExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterGroup value)
        {
            return value switch
            {
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterGroup.GameCenterAchievements => "gameCenterAchievements",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterGroup.GameCenterAchievementsV2 => "gameCenterAchievementsV2",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterGroup.GameCenterActivities => "gameCenterActivities",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterGroup.GameCenterChallenges => "gameCenterChallenges",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterGroup.GameCenterDetails => "gameCenterDetails",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterGroup.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterGroup.GameCenterLeaderboardSetsV2 => "gameCenterLeaderboardSetsV2",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterGroup.GameCenterLeaderboards => "gameCenterLeaderboards",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterGroup.GameCenterLeaderboardsV2 => "gameCenterLeaderboardsV2",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterGroup.ReferenceName => "referenceName",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterGroup? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievements" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterGroup.GameCenterAchievements,
                "gameCenterAchievementsV2" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterGroup.GameCenterAchievementsV2,
                "gameCenterActivities" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterGroup.GameCenterActivities,
                "gameCenterChallenges" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterGroup.GameCenterChallenges,
                "gameCenterDetails" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterGroup.GameCenterDetails,
                "gameCenterLeaderboardSets" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterGroup.GameCenterLeaderboardSets,
                "gameCenterLeaderboardSetsV2" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterGroup.GameCenterLeaderboardSetsV2,
                "gameCenterLeaderboards" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterGroup.GameCenterLeaderboards,
                "gameCenterLeaderboardsV2" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterGroup.GameCenterLeaderboardsV2,
                "referenceName" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterGroup.ReferenceName,
                _ => null,
            };
        }
    }
}