
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardSetsGetInstanceFieldsGameCenterDetail
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
    public static class GameCenterLeaderboardSetsGetInstanceFieldsGameCenterDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetsGetInstanceFieldsGameCenterDetail value)
        {
            return value switch
            {
                GameCenterLeaderboardSetsGetInstanceFieldsGameCenterDetail.AchievementReleases => "achievementReleases",
                GameCenterLeaderboardSetsGetInstanceFieldsGameCenterDetail.ActivityReleases => "activityReleases",
                GameCenterLeaderboardSetsGetInstanceFieldsGameCenterDetail.App => "app",
                GameCenterLeaderboardSetsGetInstanceFieldsGameCenterDetail.ArcadeEnabled => "arcadeEnabled",
                GameCenterLeaderboardSetsGetInstanceFieldsGameCenterDetail.ChallengeEnabled => "challengeEnabled",
                GameCenterLeaderboardSetsGetInstanceFieldsGameCenterDetail.ChallengeReleases => "challengeReleases",
                GameCenterLeaderboardSetsGetInstanceFieldsGameCenterDetail.ChallengesMinimumPlatformVersions => "challengesMinimumPlatformVersions",
                GameCenterLeaderboardSetsGetInstanceFieldsGameCenterDetail.DefaultGroupLeaderboard => "defaultGroupLeaderboard",
                GameCenterLeaderboardSetsGetInstanceFieldsGameCenterDetail.DefaultGroupLeaderboardV2 => "defaultGroupLeaderboardV2",
                GameCenterLeaderboardSetsGetInstanceFieldsGameCenterDetail.DefaultLeaderboard => "defaultLeaderboard",
                GameCenterLeaderboardSetsGetInstanceFieldsGameCenterDetail.DefaultLeaderboardV2 => "defaultLeaderboardV2",
                GameCenterLeaderboardSetsGetInstanceFieldsGameCenterDetail.GameCenterAchievements => "gameCenterAchievements",
                GameCenterLeaderboardSetsGetInstanceFieldsGameCenterDetail.GameCenterAchievementsV2 => "gameCenterAchievementsV2",
                GameCenterLeaderboardSetsGetInstanceFieldsGameCenterDetail.GameCenterActivities => "gameCenterActivities",
                GameCenterLeaderboardSetsGetInstanceFieldsGameCenterDetail.GameCenterAppVersions => "gameCenterAppVersions",
                GameCenterLeaderboardSetsGetInstanceFieldsGameCenterDetail.GameCenterChallenges => "gameCenterChallenges",
                GameCenterLeaderboardSetsGetInstanceFieldsGameCenterDetail.GameCenterGroup => "gameCenterGroup",
                GameCenterLeaderboardSetsGetInstanceFieldsGameCenterDetail.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                GameCenterLeaderboardSetsGetInstanceFieldsGameCenterDetail.GameCenterLeaderboardSetsV2 => "gameCenterLeaderboardSetsV2",
                GameCenterLeaderboardSetsGetInstanceFieldsGameCenterDetail.GameCenterLeaderboards => "gameCenterLeaderboards",
                GameCenterLeaderboardSetsGetInstanceFieldsGameCenterDetail.GameCenterLeaderboardsV2 => "gameCenterLeaderboardsV2",
                GameCenterLeaderboardSetsGetInstanceFieldsGameCenterDetail.LeaderboardReleases => "leaderboardReleases",
                GameCenterLeaderboardSetsGetInstanceFieldsGameCenterDetail.LeaderboardSetReleases => "leaderboardSetReleases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetsGetInstanceFieldsGameCenterDetail? ToEnum(string value)
        {
            return value switch
            {
                "achievementReleases" => GameCenterLeaderboardSetsGetInstanceFieldsGameCenterDetail.AchievementReleases,
                "activityReleases" => GameCenterLeaderboardSetsGetInstanceFieldsGameCenterDetail.ActivityReleases,
                "app" => GameCenterLeaderboardSetsGetInstanceFieldsGameCenterDetail.App,
                "arcadeEnabled" => GameCenterLeaderboardSetsGetInstanceFieldsGameCenterDetail.ArcadeEnabled,
                "challengeEnabled" => GameCenterLeaderboardSetsGetInstanceFieldsGameCenterDetail.ChallengeEnabled,
                "challengeReleases" => GameCenterLeaderboardSetsGetInstanceFieldsGameCenterDetail.ChallengeReleases,
                "challengesMinimumPlatformVersions" => GameCenterLeaderboardSetsGetInstanceFieldsGameCenterDetail.ChallengesMinimumPlatformVersions,
                "defaultGroupLeaderboard" => GameCenterLeaderboardSetsGetInstanceFieldsGameCenterDetail.DefaultGroupLeaderboard,
                "defaultGroupLeaderboardV2" => GameCenterLeaderboardSetsGetInstanceFieldsGameCenterDetail.DefaultGroupLeaderboardV2,
                "defaultLeaderboard" => GameCenterLeaderboardSetsGetInstanceFieldsGameCenterDetail.DefaultLeaderboard,
                "defaultLeaderboardV2" => GameCenterLeaderboardSetsGetInstanceFieldsGameCenterDetail.DefaultLeaderboardV2,
                "gameCenterAchievements" => GameCenterLeaderboardSetsGetInstanceFieldsGameCenterDetail.GameCenterAchievements,
                "gameCenterAchievementsV2" => GameCenterLeaderboardSetsGetInstanceFieldsGameCenterDetail.GameCenterAchievementsV2,
                "gameCenterActivities" => GameCenterLeaderboardSetsGetInstanceFieldsGameCenterDetail.GameCenterActivities,
                "gameCenterAppVersions" => GameCenterLeaderboardSetsGetInstanceFieldsGameCenterDetail.GameCenterAppVersions,
                "gameCenterChallenges" => GameCenterLeaderboardSetsGetInstanceFieldsGameCenterDetail.GameCenterChallenges,
                "gameCenterGroup" => GameCenterLeaderboardSetsGetInstanceFieldsGameCenterDetail.GameCenterGroup,
                "gameCenterLeaderboardSets" => GameCenterLeaderboardSetsGetInstanceFieldsGameCenterDetail.GameCenterLeaderboardSets,
                "gameCenterLeaderboardSetsV2" => GameCenterLeaderboardSetsGetInstanceFieldsGameCenterDetail.GameCenterLeaderboardSetsV2,
                "gameCenterLeaderboards" => GameCenterLeaderboardSetsGetInstanceFieldsGameCenterDetail.GameCenterLeaderboards,
                "gameCenterLeaderboardsV2" => GameCenterLeaderboardSetsGetInstanceFieldsGameCenterDetail.GameCenterLeaderboardsV2,
                "leaderboardReleases" => GameCenterLeaderboardSetsGetInstanceFieldsGameCenterDetail.LeaderboardReleases,
                "leaderboardSetReleases" => GameCenterLeaderboardSetsGetInstanceFieldsGameCenterDetail.LeaderboardSetReleases,
                _ => null,
            };
        }
    }
}