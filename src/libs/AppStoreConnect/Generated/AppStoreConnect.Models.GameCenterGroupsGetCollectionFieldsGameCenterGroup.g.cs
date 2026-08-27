
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterGroupsGetCollectionFieldsGameCenterGroup
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
    public static class GameCenterGroupsGetCollectionFieldsGameCenterGroupExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupsGetCollectionFieldsGameCenterGroup value)
        {
            return value switch
            {
                GameCenterGroupsGetCollectionFieldsGameCenterGroup.GameCenterAchievements => "gameCenterAchievements",
                GameCenterGroupsGetCollectionFieldsGameCenterGroup.GameCenterAchievementsV2 => "gameCenterAchievementsV2",
                GameCenterGroupsGetCollectionFieldsGameCenterGroup.GameCenterActivities => "gameCenterActivities",
                GameCenterGroupsGetCollectionFieldsGameCenterGroup.GameCenterChallenges => "gameCenterChallenges",
                GameCenterGroupsGetCollectionFieldsGameCenterGroup.GameCenterDetails => "gameCenterDetails",
                GameCenterGroupsGetCollectionFieldsGameCenterGroup.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                GameCenterGroupsGetCollectionFieldsGameCenterGroup.GameCenterLeaderboardSetsV2 => "gameCenterLeaderboardSetsV2",
                GameCenterGroupsGetCollectionFieldsGameCenterGroup.GameCenterLeaderboards => "gameCenterLeaderboards",
                GameCenterGroupsGetCollectionFieldsGameCenterGroup.GameCenterLeaderboardsV2 => "gameCenterLeaderboardsV2",
                GameCenterGroupsGetCollectionFieldsGameCenterGroup.ReferenceName => "referenceName",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupsGetCollectionFieldsGameCenterGroup? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievements" => GameCenterGroupsGetCollectionFieldsGameCenterGroup.GameCenterAchievements,
                "gameCenterAchievementsV2" => GameCenterGroupsGetCollectionFieldsGameCenterGroup.GameCenterAchievementsV2,
                "gameCenterActivities" => GameCenterGroupsGetCollectionFieldsGameCenterGroup.GameCenterActivities,
                "gameCenterChallenges" => GameCenterGroupsGetCollectionFieldsGameCenterGroup.GameCenterChallenges,
                "gameCenterDetails" => GameCenterGroupsGetCollectionFieldsGameCenterGroup.GameCenterDetails,
                "gameCenterLeaderboardSets" => GameCenterGroupsGetCollectionFieldsGameCenterGroup.GameCenterLeaderboardSets,
                "gameCenterLeaderboardSetsV2" => GameCenterGroupsGetCollectionFieldsGameCenterGroup.GameCenterLeaderboardSetsV2,
                "gameCenterLeaderboards" => GameCenterGroupsGetCollectionFieldsGameCenterGroup.GameCenterLeaderboards,
                "gameCenterLeaderboardsV2" => GameCenterGroupsGetCollectionFieldsGameCenterGroup.GameCenterLeaderboardsV2,
                "referenceName" => GameCenterGroupsGetCollectionFieldsGameCenterGroup.ReferenceName,
                _ => null,
            };
        }
    }
}