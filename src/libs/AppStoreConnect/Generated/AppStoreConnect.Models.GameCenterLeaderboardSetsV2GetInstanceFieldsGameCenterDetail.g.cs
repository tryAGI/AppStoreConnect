
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterDetail
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
    public static class GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterDetail value)
        {
            return value switch
            {
                GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterDetail.AchievementReleases => "achievementReleases",
                GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterDetail.ActivityReleases => "activityReleases",
                GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterDetail.App => "app",
                GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterDetail.ArcadeEnabled => "arcadeEnabled",
                GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterDetail.ChallengeEnabled => "challengeEnabled",
                GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterDetail.ChallengeReleases => "challengeReleases",
                GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterDetail.ChallengesMinimumPlatformVersions => "challengesMinimumPlatformVersions",
                GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterDetail.DefaultGroupLeaderboard => "defaultGroupLeaderboard",
                GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterDetail.DefaultGroupLeaderboardV2 => "defaultGroupLeaderboardV2",
                GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterDetail.DefaultLeaderboard => "defaultLeaderboard",
                GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterDetail.DefaultLeaderboardV2 => "defaultLeaderboardV2",
                GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterDetail.GameCenterAchievements => "gameCenterAchievements",
                GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterDetail.GameCenterAchievementsV2 => "gameCenterAchievementsV2",
                GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterDetail.GameCenterActivities => "gameCenterActivities",
                GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterDetail.GameCenterAppVersions => "gameCenterAppVersions",
                GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterDetail.GameCenterChallenges => "gameCenterChallenges",
                GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterDetail.GameCenterGroup => "gameCenterGroup",
                GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterDetail.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterDetail.GameCenterLeaderboardSetsV2 => "gameCenterLeaderboardSetsV2",
                GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterDetail.GameCenterLeaderboards => "gameCenterLeaderboards",
                GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterDetail.GameCenterLeaderboardsV2 => "gameCenterLeaderboardsV2",
                GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterDetail.LeaderboardReleases => "leaderboardReleases",
                GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterDetail.LeaderboardSetReleases => "leaderboardSetReleases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterDetail? ToEnum(string value)
        {
            return value switch
            {
                "achievementReleases" => GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterDetail.AchievementReleases,
                "activityReleases" => GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterDetail.ActivityReleases,
                "app" => GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterDetail.App,
                "arcadeEnabled" => GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterDetail.ArcadeEnabled,
                "challengeEnabled" => GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterDetail.ChallengeEnabled,
                "challengeReleases" => GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterDetail.ChallengeReleases,
                "challengesMinimumPlatformVersions" => GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterDetail.ChallengesMinimumPlatformVersions,
                "defaultGroupLeaderboard" => GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterDetail.DefaultGroupLeaderboard,
                "defaultGroupLeaderboardV2" => GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterDetail.DefaultGroupLeaderboardV2,
                "defaultLeaderboard" => GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterDetail.DefaultLeaderboard,
                "defaultLeaderboardV2" => GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterDetail.DefaultLeaderboardV2,
                "gameCenterAchievements" => GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterDetail.GameCenterAchievements,
                "gameCenterAchievementsV2" => GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterDetail.GameCenterAchievementsV2,
                "gameCenterActivities" => GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterDetail.GameCenterActivities,
                "gameCenterAppVersions" => GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterDetail.GameCenterAppVersions,
                "gameCenterChallenges" => GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterDetail.GameCenterChallenges,
                "gameCenterGroup" => GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterDetail.GameCenterGroup,
                "gameCenterLeaderboardSets" => GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterDetail.GameCenterLeaderboardSets,
                "gameCenterLeaderboardSetsV2" => GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterDetail.GameCenterLeaderboardSetsV2,
                "gameCenterLeaderboards" => GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterDetail.GameCenterLeaderboards,
                "gameCenterLeaderboardsV2" => GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterDetail.GameCenterLeaderboardsV2,
                "leaderboardReleases" => GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterDetail.LeaderboardReleases,
                "leaderboardSetReleases" => GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterDetail.LeaderboardSetReleases,
                _ => null,
            };
        }
    }
}