
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterGroupsGetInstanceFieldsGameCenterDetail
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
    public static class GameCenterGroupsGetInstanceFieldsGameCenterDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupsGetInstanceFieldsGameCenterDetail value)
        {
            return value switch
            {
                GameCenterGroupsGetInstanceFieldsGameCenterDetail.AchievementReleases => "achievementReleases",
                GameCenterGroupsGetInstanceFieldsGameCenterDetail.ActivityReleases => "activityReleases",
                GameCenterGroupsGetInstanceFieldsGameCenterDetail.App => "app",
                GameCenterGroupsGetInstanceFieldsGameCenterDetail.ArcadeEnabled => "arcadeEnabled",
                GameCenterGroupsGetInstanceFieldsGameCenterDetail.ChallengeEnabled => "challengeEnabled",
                GameCenterGroupsGetInstanceFieldsGameCenterDetail.ChallengeReleases => "challengeReleases",
                GameCenterGroupsGetInstanceFieldsGameCenterDetail.ChallengesMinimumPlatformVersions => "challengesMinimumPlatformVersions",
                GameCenterGroupsGetInstanceFieldsGameCenterDetail.DefaultGroupLeaderboard => "defaultGroupLeaderboard",
                GameCenterGroupsGetInstanceFieldsGameCenterDetail.DefaultGroupLeaderboardV2 => "defaultGroupLeaderboardV2",
                GameCenterGroupsGetInstanceFieldsGameCenterDetail.DefaultLeaderboard => "defaultLeaderboard",
                GameCenterGroupsGetInstanceFieldsGameCenterDetail.DefaultLeaderboardV2 => "defaultLeaderboardV2",
                GameCenterGroupsGetInstanceFieldsGameCenterDetail.GameCenterAchievements => "gameCenterAchievements",
                GameCenterGroupsGetInstanceFieldsGameCenterDetail.GameCenterAchievementsV2 => "gameCenterAchievementsV2",
                GameCenterGroupsGetInstanceFieldsGameCenterDetail.GameCenterActivities => "gameCenterActivities",
                GameCenterGroupsGetInstanceFieldsGameCenterDetail.GameCenterAppVersions => "gameCenterAppVersions",
                GameCenterGroupsGetInstanceFieldsGameCenterDetail.GameCenterChallenges => "gameCenterChallenges",
                GameCenterGroupsGetInstanceFieldsGameCenterDetail.GameCenterGroup => "gameCenterGroup",
                GameCenterGroupsGetInstanceFieldsGameCenterDetail.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                GameCenterGroupsGetInstanceFieldsGameCenterDetail.GameCenterLeaderboardSetsV2 => "gameCenterLeaderboardSetsV2",
                GameCenterGroupsGetInstanceFieldsGameCenterDetail.GameCenterLeaderboards => "gameCenterLeaderboards",
                GameCenterGroupsGetInstanceFieldsGameCenterDetail.GameCenterLeaderboardsV2 => "gameCenterLeaderboardsV2",
                GameCenterGroupsGetInstanceFieldsGameCenterDetail.LeaderboardReleases => "leaderboardReleases",
                GameCenterGroupsGetInstanceFieldsGameCenterDetail.LeaderboardSetReleases => "leaderboardSetReleases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupsGetInstanceFieldsGameCenterDetail? ToEnum(string value)
        {
            return value switch
            {
                "achievementReleases" => GameCenterGroupsGetInstanceFieldsGameCenterDetail.AchievementReleases,
                "activityReleases" => GameCenterGroupsGetInstanceFieldsGameCenterDetail.ActivityReleases,
                "app" => GameCenterGroupsGetInstanceFieldsGameCenterDetail.App,
                "arcadeEnabled" => GameCenterGroupsGetInstanceFieldsGameCenterDetail.ArcadeEnabled,
                "challengeEnabled" => GameCenterGroupsGetInstanceFieldsGameCenterDetail.ChallengeEnabled,
                "challengeReleases" => GameCenterGroupsGetInstanceFieldsGameCenterDetail.ChallengeReleases,
                "challengesMinimumPlatformVersions" => GameCenterGroupsGetInstanceFieldsGameCenterDetail.ChallengesMinimumPlatformVersions,
                "defaultGroupLeaderboard" => GameCenterGroupsGetInstanceFieldsGameCenterDetail.DefaultGroupLeaderboard,
                "defaultGroupLeaderboardV2" => GameCenterGroupsGetInstanceFieldsGameCenterDetail.DefaultGroupLeaderboardV2,
                "defaultLeaderboard" => GameCenterGroupsGetInstanceFieldsGameCenterDetail.DefaultLeaderboard,
                "defaultLeaderboardV2" => GameCenterGroupsGetInstanceFieldsGameCenterDetail.DefaultLeaderboardV2,
                "gameCenterAchievements" => GameCenterGroupsGetInstanceFieldsGameCenterDetail.GameCenterAchievements,
                "gameCenterAchievementsV2" => GameCenterGroupsGetInstanceFieldsGameCenterDetail.GameCenterAchievementsV2,
                "gameCenterActivities" => GameCenterGroupsGetInstanceFieldsGameCenterDetail.GameCenterActivities,
                "gameCenterAppVersions" => GameCenterGroupsGetInstanceFieldsGameCenterDetail.GameCenterAppVersions,
                "gameCenterChallenges" => GameCenterGroupsGetInstanceFieldsGameCenterDetail.GameCenterChallenges,
                "gameCenterGroup" => GameCenterGroupsGetInstanceFieldsGameCenterDetail.GameCenterGroup,
                "gameCenterLeaderboardSets" => GameCenterGroupsGetInstanceFieldsGameCenterDetail.GameCenterLeaderboardSets,
                "gameCenterLeaderboardSetsV2" => GameCenterGroupsGetInstanceFieldsGameCenterDetail.GameCenterLeaderboardSetsV2,
                "gameCenterLeaderboards" => GameCenterGroupsGetInstanceFieldsGameCenterDetail.GameCenterLeaderboards,
                "gameCenterLeaderboardsV2" => GameCenterGroupsGetInstanceFieldsGameCenterDetail.GameCenterLeaderboardsV2,
                "leaderboardReleases" => GameCenterGroupsGetInstanceFieldsGameCenterDetail.LeaderboardReleases,
                "leaderboardSetReleases" => GameCenterGroupsGetInstanceFieldsGameCenterDetail.LeaderboardSetReleases,
                _ => null,
            };
        }
    }
}