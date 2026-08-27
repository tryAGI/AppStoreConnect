
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsGameCenterDetailGetToOneRelatedFieldsGameCenterDetail
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
    public static class AppsGameCenterDetailGetToOneRelatedFieldsGameCenterDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGameCenterDetailGetToOneRelatedFieldsGameCenterDetail value)
        {
            return value switch
            {
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterDetail.AchievementReleases => "achievementReleases",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterDetail.ActivityReleases => "activityReleases",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterDetail.App => "app",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterDetail.ArcadeEnabled => "arcadeEnabled",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterDetail.ChallengeEnabled => "challengeEnabled",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterDetail.ChallengeReleases => "challengeReleases",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterDetail.ChallengesMinimumPlatformVersions => "challengesMinimumPlatformVersions",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterDetail.DefaultGroupLeaderboard => "defaultGroupLeaderboard",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterDetail.DefaultGroupLeaderboardV2 => "defaultGroupLeaderboardV2",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterDetail.DefaultLeaderboard => "defaultLeaderboard",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterDetail.DefaultLeaderboardV2 => "defaultLeaderboardV2",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterDetail.GameCenterAchievements => "gameCenterAchievements",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterDetail.GameCenterAchievementsV2 => "gameCenterAchievementsV2",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterDetail.GameCenterActivities => "gameCenterActivities",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterDetail.GameCenterAppVersions => "gameCenterAppVersions",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterDetail.GameCenterChallenges => "gameCenterChallenges",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterDetail.GameCenterGroup => "gameCenterGroup",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterDetail.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterDetail.GameCenterLeaderboardSetsV2 => "gameCenterLeaderboardSetsV2",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterDetail.GameCenterLeaderboards => "gameCenterLeaderboards",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterDetail.GameCenterLeaderboardsV2 => "gameCenterLeaderboardsV2",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterDetail.LeaderboardReleases => "leaderboardReleases",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterDetail.LeaderboardSetReleases => "leaderboardSetReleases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGameCenterDetailGetToOneRelatedFieldsGameCenterDetail? ToEnum(string value)
        {
            return value switch
            {
                "achievementReleases" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterDetail.AchievementReleases,
                "activityReleases" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterDetail.ActivityReleases,
                "app" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterDetail.App,
                "arcadeEnabled" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterDetail.ArcadeEnabled,
                "challengeEnabled" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterDetail.ChallengeEnabled,
                "challengeReleases" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterDetail.ChallengeReleases,
                "challengesMinimumPlatformVersions" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterDetail.ChallengesMinimumPlatformVersions,
                "defaultGroupLeaderboard" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterDetail.DefaultGroupLeaderboard,
                "defaultGroupLeaderboardV2" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterDetail.DefaultGroupLeaderboardV2,
                "defaultLeaderboard" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterDetail.DefaultLeaderboard,
                "defaultLeaderboardV2" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterDetail.DefaultLeaderboardV2,
                "gameCenterAchievements" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterDetail.GameCenterAchievements,
                "gameCenterAchievementsV2" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterDetail.GameCenterAchievementsV2,
                "gameCenterActivities" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterDetail.GameCenterActivities,
                "gameCenterAppVersions" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterDetail.GameCenterAppVersions,
                "gameCenterChallenges" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterDetail.GameCenterChallenges,
                "gameCenterGroup" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterDetail.GameCenterGroup,
                "gameCenterLeaderboardSets" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterDetail.GameCenterLeaderboardSets,
                "gameCenterLeaderboardSetsV2" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterDetail.GameCenterLeaderboardSetsV2,
                "gameCenterLeaderboards" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterDetail.GameCenterLeaderboards,
                "gameCenterLeaderboardsV2" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterDetail.GameCenterLeaderboardsV2,
                "leaderboardReleases" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterDetail.LeaderboardReleases,
                "leaderboardSetReleases" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterDetail.LeaderboardSetReleases,
                _ => null,
            };
        }
    }
}