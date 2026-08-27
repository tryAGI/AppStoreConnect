
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterDetail
    {
        /// <summary>
        ///
        /// </summary>
        AchievementReleases,
        /// <summary>
        ///
        /// </summary>
        ActivityReleases,
        /// <summary>
        ///
        /// </summary>
        App,
        /// <summary>
        ///
        /// </summary>
        ArcadeEnabled,
        /// <summary>
        ///
        /// </summary>
        ChallengeEnabled,
        /// <summary>
        ///
        /// </summary>
        ChallengeReleases,
        /// <summary>
        ///
        /// </summary>
        ChallengesMinimumPlatformVersions,
        /// <summary>
        ///
        /// </summary>
        DefaultGroupLeaderboard,
        /// <summary>
        ///
        /// </summary>
        DefaultGroupLeaderboardV2,
        /// <summary>
        ///
        /// </summary>
        DefaultLeaderboard,
        /// <summary>
        ///
        /// </summary>
        DefaultLeaderboardV2,
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
        GameCenterAppVersions,
        /// <summary>
        ///
        /// </summary>
        GameCenterChallenges,
        /// <summary>
        ///
        /// </summary>
        GameCenterGroup,
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
        LeaderboardReleases,
        /// <summary>
        ///
        /// </summary>
        LeaderboardSetReleases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterDetail value)
        {
            return value switch
            {
                GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterDetail.AchievementReleases => "achievementReleases",
                GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterDetail.ActivityReleases => "activityReleases",
                GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterDetail.App => "app",
                GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterDetail.ArcadeEnabled => "arcadeEnabled",
                GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterDetail.ChallengeEnabled => "challengeEnabled",
                GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterDetail.ChallengeReleases => "challengeReleases",
                GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterDetail.ChallengesMinimumPlatformVersions => "challengesMinimumPlatformVersions",
                GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterDetail.DefaultGroupLeaderboard => "defaultGroupLeaderboard",
                GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterDetail.DefaultGroupLeaderboardV2 => "defaultGroupLeaderboardV2",
                GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterDetail.DefaultLeaderboard => "defaultLeaderboard",
                GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterDetail.DefaultLeaderboardV2 => "defaultLeaderboardV2",
                GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterDetail.GameCenterAchievements => "gameCenterAchievements",
                GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterDetail.GameCenterAchievementsV2 => "gameCenterAchievementsV2",
                GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterDetail.GameCenterActivities => "gameCenterActivities",
                GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterDetail.GameCenterAppVersions => "gameCenterAppVersions",
                GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterDetail.GameCenterChallenges => "gameCenterChallenges",
                GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterDetail.GameCenterGroup => "gameCenterGroup",
                GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterDetail.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterDetail.GameCenterLeaderboardSetsV2 => "gameCenterLeaderboardSetsV2",
                GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterDetail.GameCenterLeaderboards => "gameCenterLeaderboards",
                GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterDetail.GameCenterLeaderboardsV2 => "gameCenterLeaderboardsV2",
                GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterDetail.LeaderboardReleases => "leaderboardReleases",
                GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterDetail.LeaderboardSetReleases => "leaderboardSetReleases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterDetail? ToEnum(string value)
        {
            return value switch
            {
                "achievementReleases" => GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterDetail.AchievementReleases,
                "activityReleases" => GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterDetail.ActivityReleases,
                "app" => GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterDetail.App,
                "arcadeEnabled" => GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterDetail.ArcadeEnabled,
                "challengeEnabled" => GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterDetail.ChallengeEnabled,
                "challengeReleases" => GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterDetail.ChallengeReleases,
                "challengesMinimumPlatformVersions" => GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterDetail.ChallengesMinimumPlatformVersions,
                "defaultGroupLeaderboard" => GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterDetail.DefaultGroupLeaderboard,
                "defaultGroupLeaderboardV2" => GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterDetail.DefaultGroupLeaderboardV2,
                "defaultLeaderboard" => GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterDetail.DefaultLeaderboard,
                "defaultLeaderboardV2" => GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterDetail.DefaultLeaderboardV2,
                "gameCenterAchievements" => GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterDetail.GameCenterAchievements,
                "gameCenterAchievementsV2" => GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterDetail.GameCenterAchievementsV2,
                "gameCenterActivities" => GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterDetail.GameCenterActivities,
                "gameCenterAppVersions" => GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterDetail.GameCenterAppVersions,
                "gameCenterChallenges" => GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterDetail.GameCenterChallenges,
                "gameCenterGroup" => GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterDetail.GameCenterGroup,
                "gameCenterLeaderboardSets" => GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterDetail.GameCenterLeaderboardSets,
                "gameCenterLeaderboardSetsV2" => GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterDetail.GameCenterLeaderboardSetsV2,
                "gameCenterLeaderboards" => GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterDetail.GameCenterLeaderboards,
                "gameCenterLeaderboardsV2" => GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterDetail.GameCenterLeaderboardsV2,
                "leaderboardReleases" => GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterDetail.LeaderboardReleases,
                "leaderboardSetReleases" => GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterDetail.LeaderboardSetReleases,
                _ => null,
            };
        }
    }
}