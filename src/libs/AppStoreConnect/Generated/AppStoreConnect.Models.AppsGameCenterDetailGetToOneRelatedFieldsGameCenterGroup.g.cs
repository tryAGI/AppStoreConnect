
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsGameCenterDetailGetToOneRelatedFieldsGameCenterGroup
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
    public static class AppsGameCenterDetailGetToOneRelatedFieldsGameCenterGroupExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGameCenterDetailGetToOneRelatedFieldsGameCenterGroup value)
        {
            return value switch
            {
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterGroup.GameCenterAchievements => "gameCenterAchievements",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterGroup.GameCenterAchievementsV2 => "gameCenterAchievementsV2",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterGroup.GameCenterActivities => "gameCenterActivities",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterGroup.GameCenterChallenges => "gameCenterChallenges",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterGroup.GameCenterDetails => "gameCenterDetails",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterGroup.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterGroup.GameCenterLeaderboardSetsV2 => "gameCenterLeaderboardSetsV2",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterGroup.GameCenterLeaderboards => "gameCenterLeaderboards",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterGroup.GameCenterLeaderboardsV2 => "gameCenterLeaderboardsV2",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterGroup.ReferenceName => "referenceName",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGameCenterDetailGetToOneRelatedFieldsGameCenterGroup? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievements" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterGroup.GameCenterAchievements,
                "gameCenterAchievementsV2" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterGroup.GameCenterAchievementsV2,
                "gameCenterActivities" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterGroup.GameCenterActivities,
                "gameCenterChallenges" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterGroup.GameCenterChallenges,
                "gameCenterDetails" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterGroup.GameCenterDetails,
                "gameCenterLeaderboardSets" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterGroup.GameCenterLeaderboardSets,
                "gameCenterLeaderboardSetsV2" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterGroup.GameCenterLeaderboardSetsV2,
                "gameCenterLeaderboards" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterGroup.GameCenterLeaderboards,
                "gameCenterLeaderboardsV2" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterGroup.GameCenterLeaderboardsV2,
                "referenceName" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterGroup.ReferenceName,
                _ => null,
            };
        }
    }
}