
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterGroup
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
    public static class GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterGroupExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterGroup value)
        {
            return value switch
            {
                GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterGroup.GameCenterAchievements => "gameCenterAchievements",
                GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterGroup.GameCenterAchievementsV2 => "gameCenterAchievementsV2",
                GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterGroup.GameCenterActivities => "gameCenterActivities",
                GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterGroup.GameCenterChallenges => "gameCenterChallenges",
                GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterGroup.GameCenterDetails => "gameCenterDetails",
                GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterGroup.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterGroup.GameCenterLeaderboardSetsV2 => "gameCenterLeaderboardSetsV2",
                GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterGroup.GameCenterLeaderboards => "gameCenterLeaderboards",
                GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterGroup.GameCenterLeaderboardsV2 => "gameCenterLeaderboardsV2",
                GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterGroup.ReferenceName => "referenceName",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterGroup? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievements" => GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterGroup.GameCenterAchievements,
                "gameCenterAchievementsV2" => GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterGroup.GameCenterAchievementsV2,
                "gameCenterActivities" => GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterGroup.GameCenterActivities,
                "gameCenterChallenges" => GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterGroup.GameCenterChallenges,
                "gameCenterDetails" => GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterGroup.GameCenterDetails,
                "gameCenterLeaderboardSets" => GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterGroup.GameCenterLeaderboardSets,
                "gameCenterLeaderboardSetsV2" => GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterGroup.GameCenterLeaderboardSetsV2,
                "gameCenterLeaderboards" => GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterGroup.GameCenterLeaderboards,
                "gameCenterLeaderboardsV2" => GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterGroup.GameCenterLeaderboardsV2,
                "referenceName" => GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterGroup.ReferenceName,
                _ => null,
            };
        }
    }
}