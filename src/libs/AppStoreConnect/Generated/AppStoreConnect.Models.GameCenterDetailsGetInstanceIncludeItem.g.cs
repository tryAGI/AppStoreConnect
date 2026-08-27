
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterDetailsGetInstanceIncludeItem
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
    public static class GameCenterDetailsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsGetInstanceIncludeItem value)
        {
            return value switch
            {
                GameCenterDetailsGetInstanceIncludeItem.AchievementReleases => "achievementReleases",
                GameCenterDetailsGetInstanceIncludeItem.ActivityReleases => "activityReleases",
                GameCenterDetailsGetInstanceIncludeItem.App => "app",
                GameCenterDetailsGetInstanceIncludeItem.ChallengeReleases => "challengeReleases",
                GameCenterDetailsGetInstanceIncludeItem.ChallengesMinimumPlatformVersions => "challengesMinimumPlatformVersions",
                GameCenterDetailsGetInstanceIncludeItem.DefaultGroupLeaderboard => "defaultGroupLeaderboard",
                GameCenterDetailsGetInstanceIncludeItem.DefaultGroupLeaderboardV2 => "defaultGroupLeaderboardV2",
                GameCenterDetailsGetInstanceIncludeItem.DefaultLeaderboard => "defaultLeaderboard",
                GameCenterDetailsGetInstanceIncludeItem.DefaultLeaderboardV2 => "defaultLeaderboardV2",
                GameCenterDetailsGetInstanceIncludeItem.GameCenterAchievements => "gameCenterAchievements",
                GameCenterDetailsGetInstanceIncludeItem.GameCenterAchievementsV2 => "gameCenterAchievementsV2",
                GameCenterDetailsGetInstanceIncludeItem.GameCenterActivities => "gameCenterActivities",
                GameCenterDetailsGetInstanceIncludeItem.GameCenterAppVersions => "gameCenterAppVersions",
                GameCenterDetailsGetInstanceIncludeItem.GameCenterChallenges => "gameCenterChallenges",
                GameCenterDetailsGetInstanceIncludeItem.GameCenterGroup => "gameCenterGroup",
                GameCenterDetailsGetInstanceIncludeItem.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                GameCenterDetailsGetInstanceIncludeItem.GameCenterLeaderboardSetsV2 => "gameCenterLeaderboardSetsV2",
                GameCenterDetailsGetInstanceIncludeItem.GameCenterLeaderboards => "gameCenterLeaderboards",
                GameCenterDetailsGetInstanceIncludeItem.GameCenterLeaderboardsV2 => "gameCenterLeaderboardsV2",
                GameCenterDetailsGetInstanceIncludeItem.LeaderboardReleases => "leaderboardReleases",
                GameCenterDetailsGetInstanceIncludeItem.LeaderboardSetReleases => "leaderboardSetReleases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "achievementReleases" => GameCenterDetailsGetInstanceIncludeItem.AchievementReleases,
                "activityReleases" => GameCenterDetailsGetInstanceIncludeItem.ActivityReleases,
                "app" => GameCenterDetailsGetInstanceIncludeItem.App,
                "challengeReleases" => GameCenterDetailsGetInstanceIncludeItem.ChallengeReleases,
                "challengesMinimumPlatformVersions" => GameCenterDetailsGetInstanceIncludeItem.ChallengesMinimumPlatformVersions,
                "defaultGroupLeaderboard" => GameCenterDetailsGetInstanceIncludeItem.DefaultGroupLeaderboard,
                "defaultGroupLeaderboardV2" => GameCenterDetailsGetInstanceIncludeItem.DefaultGroupLeaderboardV2,
                "defaultLeaderboard" => GameCenterDetailsGetInstanceIncludeItem.DefaultLeaderboard,
                "defaultLeaderboardV2" => GameCenterDetailsGetInstanceIncludeItem.DefaultLeaderboardV2,
                "gameCenterAchievements" => GameCenterDetailsGetInstanceIncludeItem.GameCenterAchievements,
                "gameCenterAchievementsV2" => GameCenterDetailsGetInstanceIncludeItem.GameCenterAchievementsV2,
                "gameCenterActivities" => GameCenterDetailsGetInstanceIncludeItem.GameCenterActivities,
                "gameCenterAppVersions" => GameCenterDetailsGetInstanceIncludeItem.GameCenterAppVersions,
                "gameCenterChallenges" => GameCenterDetailsGetInstanceIncludeItem.GameCenterChallenges,
                "gameCenterGroup" => GameCenterDetailsGetInstanceIncludeItem.GameCenterGroup,
                "gameCenterLeaderboardSets" => GameCenterDetailsGetInstanceIncludeItem.GameCenterLeaderboardSets,
                "gameCenterLeaderboardSetsV2" => GameCenterDetailsGetInstanceIncludeItem.GameCenterLeaderboardSetsV2,
                "gameCenterLeaderboards" => GameCenterDetailsGetInstanceIncludeItem.GameCenterLeaderboards,
                "gameCenterLeaderboardsV2" => GameCenterDetailsGetInstanceIncludeItem.GameCenterLeaderboardsV2,
                "leaderboardReleases" => GameCenterDetailsGetInstanceIncludeItem.LeaderboardReleases,
                "leaderboardSetReleases" => GameCenterDetailsGetInstanceIncludeItem.LeaderboardSetReleases,
                _ => null,
            };
        }
    }
}