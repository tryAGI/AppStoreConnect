
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterDetailsGameCenterGroupGetToOneRelatedIncludeItem
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterDetailsGameCenterGroupGetToOneRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsGameCenterGroupGetToOneRelatedIncludeItem value)
        {
            return value switch
            {
                GameCenterDetailsGameCenterGroupGetToOneRelatedIncludeItem.GameCenterAchievements => "gameCenterAchievements",
                GameCenterDetailsGameCenterGroupGetToOneRelatedIncludeItem.GameCenterAchievementsV2 => "gameCenterAchievementsV2",
                GameCenterDetailsGameCenterGroupGetToOneRelatedIncludeItem.GameCenterActivities => "gameCenterActivities",
                GameCenterDetailsGameCenterGroupGetToOneRelatedIncludeItem.GameCenterChallenges => "gameCenterChallenges",
                GameCenterDetailsGameCenterGroupGetToOneRelatedIncludeItem.GameCenterDetails => "gameCenterDetails",
                GameCenterDetailsGameCenterGroupGetToOneRelatedIncludeItem.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                GameCenterDetailsGameCenterGroupGetToOneRelatedIncludeItem.GameCenterLeaderboardSetsV2 => "gameCenterLeaderboardSetsV2",
                GameCenterDetailsGameCenterGroupGetToOneRelatedIncludeItem.GameCenterLeaderboards => "gameCenterLeaderboards",
                GameCenterDetailsGameCenterGroupGetToOneRelatedIncludeItem.GameCenterLeaderboardsV2 => "gameCenterLeaderboardsV2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsGameCenterGroupGetToOneRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievements" => GameCenterDetailsGameCenterGroupGetToOneRelatedIncludeItem.GameCenterAchievements,
                "gameCenterAchievementsV2" => GameCenterDetailsGameCenterGroupGetToOneRelatedIncludeItem.GameCenterAchievementsV2,
                "gameCenterActivities" => GameCenterDetailsGameCenterGroupGetToOneRelatedIncludeItem.GameCenterActivities,
                "gameCenterChallenges" => GameCenterDetailsGameCenterGroupGetToOneRelatedIncludeItem.GameCenterChallenges,
                "gameCenterDetails" => GameCenterDetailsGameCenterGroupGetToOneRelatedIncludeItem.GameCenterDetails,
                "gameCenterLeaderboardSets" => GameCenterDetailsGameCenterGroupGetToOneRelatedIncludeItem.GameCenterLeaderboardSets,
                "gameCenterLeaderboardSetsV2" => GameCenterDetailsGameCenterGroupGetToOneRelatedIncludeItem.GameCenterLeaderboardSetsV2,
                "gameCenterLeaderboards" => GameCenterDetailsGameCenterGroupGetToOneRelatedIncludeItem.GameCenterLeaderboards,
                "gameCenterLeaderboardsV2" => GameCenterDetailsGameCenterGroupGetToOneRelatedIncludeItem.GameCenterLeaderboardsV2,
                _ => null,
            };
        }
    }
}