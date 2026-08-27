
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsGameCenterDetailGetToOneRelatedIncludeItem
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
    public static class AppsGameCenterDetailGetToOneRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGameCenterDetailGetToOneRelatedIncludeItem value)
        {
            return value switch
            {
                AppsGameCenterDetailGetToOneRelatedIncludeItem.AchievementReleases => "achievementReleases",
                AppsGameCenterDetailGetToOneRelatedIncludeItem.ActivityReleases => "activityReleases",
                AppsGameCenterDetailGetToOneRelatedIncludeItem.App => "app",
                AppsGameCenterDetailGetToOneRelatedIncludeItem.ChallengeReleases => "challengeReleases",
                AppsGameCenterDetailGetToOneRelatedIncludeItem.ChallengesMinimumPlatformVersions => "challengesMinimumPlatformVersions",
                AppsGameCenterDetailGetToOneRelatedIncludeItem.DefaultGroupLeaderboard => "defaultGroupLeaderboard",
                AppsGameCenterDetailGetToOneRelatedIncludeItem.DefaultGroupLeaderboardV2 => "defaultGroupLeaderboardV2",
                AppsGameCenterDetailGetToOneRelatedIncludeItem.DefaultLeaderboard => "defaultLeaderboard",
                AppsGameCenterDetailGetToOneRelatedIncludeItem.DefaultLeaderboardV2 => "defaultLeaderboardV2",
                AppsGameCenterDetailGetToOneRelatedIncludeItem.GameCenterAchievements => "gameCenterAchievements",
                AppsGameCenterDetailGetToOneRelatedIncludeItem.GameCenterAchievementsV2 => "gameCenterAchievementsV2",
                AppsGameCenterDetailGetToOneRelatedIncludeItem.GameCenterActivities => "gameCenterActivities",
                AppsGameCenterDetailGetToOneRelatedIncludeItem.GameCenterAppVersions => "gameCenterAppVersions",
                AppsGameCenterDetailGetToOneRelatedIncludeItem.GameCenterChallenges => "gameCenterChallenges",
                AppsGameCenterDetailGetToOneRelatedIncludeItem.GameCenterGroup => "gameCenterGroup",
                AppsGameCenterDetailGetToOneRelatedIncludeItem.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                AppsGameCenterDetailGetToOneRelatedIncludeItem.GameCenterLeaderboardSetsV2 => "gameCenterLeaderboardSetsV2",
                AppsGameCenterDetailGetToOneRelatedIncludeItem.GameCenterLeaderboards => "gameCenterLeaderboards",
                AppsGameCenterDetailGetToOneRelatedIncludeItem.GameCenterLeaderboardsV2 => "gameCenterLeaderboardsV2",
                AppsGameCenterDetailGetToOneRelatedIncludeItem.LeaderboardReleases => "leaderboardReleases",
                AppsGameCenterDetailGetToOneRelatedIncludeItem.LeaderboardSetReleases => "leaderboardSetReleases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGameCenterDetailGetToOneRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "achievementReleases" => AppsGameCenterDetailGetToOneRelatedIncludeItem.AchievementReleases,
                "activityReleases" => AppsGameCenterDetailGetToOneRelatedIncludeItem.ActivityReleases,
                "app" => AppsGameCenterDetailGetToOneRelatedIncludeItem.App,
                "challengeReleases" => AppsGameCenterDetailGetToOneRelatedIncludeItem.ChallengeReleases,
                "challengesMinimumPlatformVersions" => AppsGameCenterDetailGetToOneRelatedIncludeItem.ChallengesMinimumPlatformVersions,
                "defaultGroupLeaderboard" => AppsGameCenterDetailGetToOneRelatedIncludeItem.DefaultGroupLeaderboard,
                "defaultGroupLeaderboardV2" => AppsGameCenterDetailGetToOneRelatedIncludeItem.DefaultGroupLeaderboardV2,
                "defaultLeaderboard" => AppsGameCenterDetailGetToOneRelatedIncludeItem.DefaultLeaderboard,
                "defaultLeaderboardV2" => AppsGameCenterDetailGetToOneRelatedIncludeItem.DefaultLeaderboardV2,
                "gameCenterAchievements" => AppsGameCenterDetailGetToOneRelatedIncludeItem.GameCenterAchievements,
                "gameCenterAchievementsV2" => AppsGameCenterDetailGetToOneRelatedIncludeItem.GameCenterAchievementsV2,
                "gameCenterActivities" => AppsGameCenterDetailGetToOneRelatedIncludeItem.GameCenterActivities,
                "gameCenterAppVersions" => AppsGameCenterDetailGetToOneRelatedIncludeItem.GameCenterAppVersions,
                "gameCenterChallenges" => AppsGameCenterDetailGetToOneRelatedIncludeItem.GameCenterChallenges,
                "gameCenterGroup" => AppsGameCenterDetailGetToOneRelatedIncludeItem.GameCenterGroup,
                "gameCenterLeaderboardSets" => AppsGameCenterDetailGetToOneRelatedIncludeItem.GameCenterLeaderboardSets,
                "gameCenterLeaderboardSetsV2" => AppsGameCenterDetailGetToOneRelatedIncludeItem.GameCenterLeaderboardSetsV2,
                "gameCenterLeaderboards" => AppsGameCenterDetailGetToOneRelatedIncludeItem.GameCenterLeaderboards,
                "gameCenterLeaderboardsV2" => AppsGameCenterDetailGetToOneRelatedIncludeItem.GameCenterLeaderboardsV2,
                "leaderboardReleases" => AppsGameCenterDetailGetToOneRelatedIncludeItem.LeaderboardReleases,
                "leaderboardSetReleases" => AppsGameCenterDetailGetToOneRelatedIncludeItem.LeaderboardSetReleases,
                _ => null,
            };
        }
    }
}