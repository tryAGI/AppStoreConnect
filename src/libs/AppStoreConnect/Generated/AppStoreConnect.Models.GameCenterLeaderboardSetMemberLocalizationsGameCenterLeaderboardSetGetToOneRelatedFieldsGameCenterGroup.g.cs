
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardSetGetToOneRelatedFieldsGameCenterGroup
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
    public static class GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardSetGetToOneRelatedFieldsGameCenterGroupExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardSetGetToOneRelatedFieldsGameCenterGroup value)
        {
            return value switch
            {
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardSetGetToOneRelatedFieldsGameCenterGroup.GameCenterAchievements => "gameCenterAchievements",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardSetGetToOneRelatedFieldsGameCenterGroup.GameCenterAchievementsV2 => "gameCenterAchievementsV2",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardSetGetToOneRelatedFieldsGameCenterGroup.GameCenterActivities => "gameCenterActivities",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardSetGetToOneRelatedFieldsGameCenterGroup.GameCenterChallenges => "gameCenterChallenges",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardSetGetToOneRelatedFieldsGameCenterGroup.GameCenterDetails => "gameCenterDetails",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardSetGetToOneRelatedFieldsGameCenterGroup.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardSetGetToOneRelatedFieldsGameCenterGroup.GameCenterLeaderboardSetsV2 => "gameCenterLeaderboardSetsV2",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardSetGetToOneRelatedFieldsGameCenterGroup.GameCenterLeaderboards => "gameCenterLeaderboards",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardSetGetToOneRelatedFieldsGameCenterGroup.GameCenterLeaderboardsV2 => "gameCenterLeaderboardsV2",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardSetGetToOneRelatedFieldsGameCenterGroup.ReferenceName => "referenceName",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardSetGetToOneRelatedFieldsGameCenterGroup? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievements" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardSetGetToOneRelatedFieldsGameCenterGroup.GameCenterAchievements,
                "gameCenterAchievementsV2" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardSetGetToOneRelatedFieldsGameCenterGroup.GameCenterAchievementsV2,
                "gameCenterActivities" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardSetGetToOneRelatedFieldsGameCenterGroup.GameCenterActivities,
                "gameCenterChallenges" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardSetGetToOneRelatedFieldsGameCenterGroup.GameCenterChallenges,
                "gameCenterDetails" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardSetGetToOneRelatedFieldsGameCenterGroup.GameCenterDetails,
                "gameCenterLeaderboardSets" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardSetGetToOneRelatedFieldsGameCenterGroup.GameCenterLeaderboardSets,
                "gameCenterLeaderboardSetsV2" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardSetGetToOneRelatedFieldsGameCenterGroup.GameCenterLeaderboardSetsV2,
                "gameCenterLeaderboards" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardSetGetToOneRelatedFieldsGameCenterGroup.GameCenterLeaderboards,
                "gameCenterLeaderboardsV2" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardSetGetToOneRelatedFieldsGameCenterGroup.GameCenterLeaderboardsV2,
                "referenceName" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardSetGetToOneRelatedFieldsGameCenterGroup.ReferenceName,
                _ => null,
            };
        }
    }
}