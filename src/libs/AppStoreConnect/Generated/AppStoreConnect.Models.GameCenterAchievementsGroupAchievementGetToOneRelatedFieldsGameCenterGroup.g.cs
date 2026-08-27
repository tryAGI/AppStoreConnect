
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterGroup
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
    public static class GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterGroupExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterGroup value)
        {
            return value switch
            {
                GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterGroup.GameCenterAchievements => "gameCenterAchievements",
                GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterGroup.GameCenterAchievementsV2 => "gameCenterAchievementsV2",
                GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterGroup.GameCenterActivities => "gameCenterActivities",
                GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterGroup.GameCenterChallenges => "gameCenterChallenges",
                GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterGroup.GameCenterDetails => "gameCenterDetails",
                GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterGroup.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterGroup.GameCenterLeaderboardSetsV2 => "gameCenterLeaderboardSetsV2",
                GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterGroup.GameCenterLeaderboards => "gameCenterLeaderboards",
                GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterGroup.GameCenterLeaderboardsV2 => "gameCenterLeaderboardsV2",
                GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterGroup.ReferenceName => "referenceName",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterGroup? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievements" => GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterGroup.GameCenterAchievements,
                "gameCenterAchievementsV2" => GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterGroup.GameCenterAchievementsV2,
                "gameCenterActivities" => GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterGroup.GameCenterActivities,
                "gameCenterChallenges" => GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterGroup.GameCenterChallenges,
                "gameCenterDetails" => GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterGroup.GameCenterDetails,
                "gameCenterLeaderboardSets" => GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterGroup.GameCenterLeaderboardSets,
                "gameCenterLeaderboardSetsV2" => GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterGroup.GameCenterLeaderboardSetsV2,
                "gameCenterLeaderboards" => GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterGroup.GameCenterLeaderboards,
                "gameCenterLeaderboardsV2" => GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterGroup.GameCenterLeaderboardsV2,
                "referenceName" => GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterGroup.ReferenceName,
                _ => null,
            };
        }
    }
}