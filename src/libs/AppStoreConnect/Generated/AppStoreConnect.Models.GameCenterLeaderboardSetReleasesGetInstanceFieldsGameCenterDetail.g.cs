
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterDetail
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
    public static class GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterDetail value)
        {
            return value switch
            {
                GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterDetail.AchievementReleases => "achievementReleases",
                GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterDetail.ActivityReleases => "activityReleases",
                GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterDetail.App => "app",
                GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterDetail.ArcadeEnabled => "arcadeEnabled",
                GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterDetail.ChallengeEnabled => "challengeEnabled",
                GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterDetail.ChallengeReleases => "challengeReleases",
                GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterDetail.ChallengesMinimumPlatformVersions => "challengesMinimumPlatformVersions",
                GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterDetail.DefaultGroupLeaderboard => "defaultGroupLeaderboard",
                GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterDetail.DefaultGroupLeaderboardV2 => "defaultGroupLeaderboardV2",
                GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterDetail.DefaultLeaderboard => "defaultLeaderboard",
                GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterDetail.DefaultLeaderboardV2 => "defaultLeaderboardV2",
                GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterDetail.GameCenterAchievements => "gameCenterAchievements",
                GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterDetail.GameCenterAchievementsV2 => "gameCenterAchievementsV2",
                GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterDetail.GameCenterActivities => "gameCenterActivities",
                GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterDetail.GameCenterAppVersions => "gameCenterAppVersions",
                GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterDetail.GameCenterChallenges => "gameCenterChallenges",
                GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterDetail.GameCenterGroup => "gameCenterGroup",
                GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterDetail.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterDetail.GameCenterLeaderboardSetsV2 => "gameCenterLeaderboardSetsV2",
                GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterDetail.GameCenterLeaderboards => "gameCenterLeaderboards",
                GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterDetail.GameCenterLeaderboardsV2 => "gameCenterLeaderboardsV2",
                GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterDetail.LeaderboardReleases => "leaderboardReleases",
                GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterDetail.LeaderboardSetReleases => "leaderboardSetReleases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterDetail? ToEnum(string value)
        {
            return value switch
            {
                "achievementReleases" => GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterDetail.AchievementReleases,
                "activityReleases" => GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterDetail.ActivityReleases,
                "app" => GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterDetail.App,
                "arcadeEnabled" => GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterDetail.ArcadeEnabled,
                "challengeEnabled" => GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterDetail.ChallengeEnabled,
                "challengeReleases" => GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterDetail.ChallengeReleases,
                "challengesMinimumPlatformVersions" => GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterDetail.ChallengesMinimumPlatformVersions,
                "defaultGroupLeaderboard" => GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterDetail.DefaultGroupLeaderboard,
                "defaultGroupLeaderboardV2" => GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterDetail.DefaultGroupLeaderboardV2,
                "defaultLeaderboard" => GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterDetail.DefaultLeaderboard,
                "defaultLeaderboardV2" => GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterDetail.DefaultLeaderboardV2,
                "gameCenterAchievements" => GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterDetail.GameCenterAchievements,
                "gameCenterAchievementsV2" => GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterDetail.GameCenterAchievementsV2,
                "gameCenterActivities" => GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterDetail.GameCenterActivities,
                "gameCenterAppVersions" => GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterDetail.GameCenterAppVersions,
                "gameCenterChallenges" => GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterDetail.GameCenterChallenges,
                "gameCenterGroup" => GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterDetail.GameCenterGroup,
                "gameCenterLeaderboardSets" => GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterDetail.GameCenterLeaderboardSets,
                "gameCenterLeaderboardSetsV2" => GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterDetail.GameCenterLeaderboardSetsV2,
                "gameCenterLeaderboards" => GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterDetail.GameCenterLeaderboards,
                "gameCenterLeaderboardsV2" => GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterDetail.GameCenterLeaderboardsV2,
                "leaderboardReleases" => GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterDetail.LeaderboardReleases,
                "leaderboardSetReleases" => GameCenterLeaderboardSetReleasesGetInstanceFieldsGameCenterDetail.LeaderboardSetReleases,
                _ => null,
            };
        }
    }
}