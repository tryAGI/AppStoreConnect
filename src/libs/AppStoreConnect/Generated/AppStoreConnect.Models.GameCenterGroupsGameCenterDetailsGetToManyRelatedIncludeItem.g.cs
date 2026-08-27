
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterGroupsGameCenterDetailsGetToManyRelatedIncludeItem
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
    public static class GameCenterGroupsGameCenterDetailsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupsGameCenterDetailsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                GameCenterGroupsGameCenterDetailsGetToManyRelatedIncludeItem.AchievementReleases => "achievementReleases",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedIncludeItem.ActivityReleases => "activityReleases",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedIncludeItem.App => "app",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedIncludeItem.ChallengeReleases => "challengeReleases",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedIncludeItem.ChallengesMinimumPlatformVersions => "challengesMinimumPlatformVersions",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedIncludeItem.DefaultGroupLeaderboard => "defaultGroupLeaderboard",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedIncludeItem.DefaultGroupLeaderboardV2 => "defaultGroupLeaderboardV2",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedIncludeItem.DefaultLeaderboard => "defaultLeaderboard",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedIncludeItem.DefaultLeaderboardV2 => "defaultLeaderboardV2",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedIncludeItem.GameCenterAchievements => "gameCenterAchievements",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedIncludeItem.GameCenterAchievementsV2 => "gameCenterAchievementsV2",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedIncludeItem.GameCenterActivities => "gameCenterActivities",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedIncludeItem.GameCenterAppVersions => "gameCenterAppVersions",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedIncludeItem.GameCenterChallenges => "gameCenterChallenges",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedIncludeItem.GameCenterGroup => "gameCenterGroup",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedIncludeItem.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedIncludeItem.GameCenterLeaderboardSetsV2 => "gameCenterLeaderboardSetsV2",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedIncludeItem.GameCenterLeaderboards => "gameCenterLeaderboards",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedIncludeItem.GameCenterLeaderboardsV2 => "gameCenterLeaderboardsV2",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedIncludeItem.LeaderboardReleases => "leaderboardReleases",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedIncludeItem.LeaderboardSetReleases => "leaderboardSetReleases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupsGameCenterDetailsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "achievementReleases" => GameCenterGroupsGameCenterDetailsGetToManyRelatedIncludeItem.AchievementReleases,
                "activityReleases" => GameCenterGroupsGameCenterDetailsGetToManyRelatedIncludeItem.ActivityReleases,
                "app" => GameCenterGroupsGameCenterDetailsGetToManyRelatedIncludeItem.App,
                "challengeReleases" => GameCenterGroupsGameCenterDetailsGetToManyRelatedIncludeItem.ChallengeReleases,
                "challengesMinimumPlatformVersions" => GameCenterGroupsGameCenterDetailsGetToManyRelatedIncludeItem.ChallengesMinimumPlatformVersions,
                "defaultGroupLeaderboard" => GameCenterGroupsGameCenterDetailsGetToManyRelatedIncludeItem.DefaultGroupLeaderboard,
                "defaultGroupLeaderboardV2" => GameCenterGroupsGameCenterDetailsGetToManyRelatedIncludeItem.DefaultGroupLeaderboardV2,
                "defaultLeaderboard" => GameCenterGroupsGameCenterDetailsGetToManyRelatedIncludeItem.DefaultLeaderboard,
                "defaultLeaderboardV2" => GameCenterGroupsGameCenterDetailsGetToManyRelatedIncludeItem.DefaultLeaderboardV2,
                "gameCenterAchievements" => GameCenterGroupsGameCenterDetailsGetToManyRelatedIncludeItem.GameCenterAchievements,
                "gameCenterAchievementsV2" => GameCenterGroupsGameCenterDetailsGetToManyRelatedIncludeItem.GameCenterAchievementsV2,
                "gameCenterActivities" => GameCenterGroupsGameCenterDetailsGetToManyRelatedIncludeItem.GameCenterActivities,
                "gameCenterAppVersions" => GameCenterGroupsGameCenterDetailsGetToManyRelatedIncludeItem.GameCenterAppVersions,
                "gameCenterChallenges" => GameCenterGroupsGameCenterDetailsGetToManyRelatedIncludeItem.GameCenterChallenges,
                "gameCenterGroup" => GameCenterGroupsGameCenterDetailsGetToManyRelatedIncludeItem.GameCenterGroup,
                "gameCenterLeaderboardSets" => GameCenterGroupsGameCenterDetailsGetToManyRelatedIncludeItem.GameCenterLeaderboardSets,
                "gameCenterLeaderboardSetsV2" => GameCenterGroupsGameCenterDetailsGetToManyRelatedIncludeItem.GameCenterLeaderboardSetsV2,
                "gameCenterLeaderboards" => GameCenterGroupsGameCenterDetailsGetToManyRelatedIncludeItem.GameCenterLeaderboards,
                "gameCenterLeaderboardsV2" => GameCenterGroupsGameCenterDetailsGetToManyRelatedIncludeItem.GameCenterLeaderboardsV2,
                "leaderboardReleases" => GameCenterGroupsGameCenterDetailsGetToManyRelatedIncludeItem.LeaderboardReleases,
                "leaderboardSetReleases" => GameCenterGroupsGameCenterDetailsGetToManyRelatedIncludeItem.LeaderboardSetReleases,
                _ => null,
            };
        }
    }
}