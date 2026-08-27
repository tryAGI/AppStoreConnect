
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsGetInstanceFieldsGameCenterDetail
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
    public static class AppsGetInstanceFieldsGameCenterDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGetInstanceFieldsGameCenterDetail value)
        {
            return value switch
            {
                AppsGetInstanceFieldsGameCenterDetail.AchievementReleases => "achievementReleases",
                AppsGetInstanceFieldsGameCenterDetail.ActivityReleases => "activityReleases",
                AppsGetInstanceFieldsGameCenterDetail.App => "app",
                AppsGetInstanceFieldsGameCenterDetail.ArcadeEnabled => "arcadeEnabled",
                AppsGetInstanceFieldsGameCenterDetail.ChallengeEnabled => "challengeEnabled",
                AppsGetInstanceFieldsGameCenterDetail.ChallengeReleases => "challengeReleases",
                AppsGetInstanceFieldsGameCenterDetail.ChallengesMinimumPlatformVersions => "challengesMinimumPlatformVersions",
                AppsGetInstanceFieldsGameCenterDetail.DefaultGroupLeaderboard => "defaultGroupLeaderboard",
                AppsGetInstanceFieldsGameCenterDetail.DefaultGroupLeaderboardV2 => "defaultGroupLeaderboardV2",
                AppsGetInstanceFieldsGameCenterDetail.DefaultLeaderboard => "defaultLeaderboard",
                AppsGetInstanceFieldsGameCenterDetail.DefaultLeaderboardV2 => "defaultLeaderboardV2",
                AppsGetInstanceFieldsGameCenterDetail.GameCenterAchievements => "gameCenterAchievements",
                AppsGetInstanceFieldsGameCenterDetail.GameCenterAchievementsV2 => "gameCenterAchievementsV2",
                AppsGetInstanceFieldsGameCenterDetail.GameCenterActivities => "gameCenterActivities",
                AppsGetInstanceFieldsGameCenterDetail.GameCenterAppVersions => "gameCenterAppVersions",
                AppsGetInstanceFieldsGameCenterDetail.GameCenterChallenges => "gameCenterChallenges",
                AppsGetInstanceFieldsGameCenterDetail.GameCenterGroup => "gameCenterGroup",
                AppsGetInstanceFieldsGameCenterDetail.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                AppsGetInstanceFieldsGameCenterDetail.GameCenterLeaderboardSetsV2 => "gameCenterLeaderboardSetsV2",
                AppsGetInstanceFieldsGameCenterDetail.GameCenterLeaderboards => "gameCenterLeaderboards",
                AppsGetInstanceFieldsGameCenterDetail.GameCenterLeaderboardsV2 => "gameCenterLeaderboardsV2",
                AppsGetInstanceFieldsGameCenterDetail.LeaderboardReleases => "leaderboardReleases",
                AppsGetInstanceFieldsGameCenterDetail.LeaderboardSetReleases => "leaderboardSetReleases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGetInstanceFieldsGameCenterDetail? ToEnum(string value)
        {
            return value switch
            {
                "achievementReleases" => AppsGetInstanceFieldsGameCenterDetail.AchievementReleases,
                "activityReleases" => AppsGetInstanceFieldsGameCenterDetail.ActivityReleases,
                "app" => AppsGetInstanceFieldsGameCenterDetail.App,
                "arcadeEnabled" => AppsGetInstanceFieldsGameCenterDetail.ArcadeEnabled,
                "challengeEnabled" => AppsGetInstanceFieldsGameCenterDetail.ChallengeEnabled,
                "challengeReleases" => AppsGetInstanceFieldsGameCenterDetail.ChallengeReleases,
                "challengesMinimumPlatformVersions" => AppsGetInstanceFieldsGameCenterDetail.ChallengesMinimumPlatformVersions,
                "defaultGroupLeaderboard" => AppsGetInstanceFieldsGameCenterDetail.DefaultGroupLeaderboard,
                "defaultGroupLeaderboardV2" => AppsGetInstanceFieldsGameCenterDetail.DefaultGroupLeaderboardV2,
                "defaultLeaderboard" => AppsGetInstanceFieldsGameCenterDetail.DefaultLeaderboard,
                "defaultLeaderboardV2" => AppsGetInstanceFieldsGameCenterDetail.DefaultLeaderboardV2,
                "gameCenterAchievements" => AppsGetInstanceFieldsGameCenterDetail.GameCenterAchievements,
                "gameCenterAchievementsV2" => AppsGetInstanceFieldsGameCenterDetail.GameCenterAchievementsV2,
                "gameCenterActivities" => AppsGetInstanceFieldsGameCenterDetail.GameCenterActivities,
                "gameCenterAppVersions" => AppsGetInstanceFieldsGameCenterDetail.GameCenterAppVersions,
                "gameCenterChallenges" => AppsGetInstanceFieldsGameCenterDetail.GameCenterChallenges,
                "gameCenterGroup" => AppsGetInstanceFieldsGameCenterDetail.GameCenterGroup,
                "gameCenterLeaderboardSets" => AppsGetInstanceFieldsGameCenterDetail.GameCenterLeaderboardSets,
                "gameCenterLeaderboardSetsV2" => AppsGetInstanceFieldsGameCenterDetail.GameCenterLeaderboardSetsV2,
                "gameCenterLeaderboards" => AppsGetInstanceFieldsGameCenterDetail.GameCenterLeaderboards,
                "gameCenterLeaderboardsV2" => AppsGetInstanceFieldsGameCenterDetail.GameCenterLeaderboardsV2,
                "leaderboardReleases" => AppsGetInstanceFieldsGameCenterDetail.LeaderboardReleases,
                "leaderboardSetReleases" => AppsGetInstanceFieldsGameCenterDetail.LeaderboardSetReleases,
                _ => null,
            };
        }
    }
}