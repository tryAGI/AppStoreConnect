
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterDetail
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
    public static class GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterDetail value)
        {
            return value switch
            {
                GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterDetail.AchievementReleases => "achievementReleases",
                GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterDetail.ActivityReleases => "activityReleases",
                GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterDetail.App => "app",
                GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterDetail.ArcadeEnabled => "arcadeEnabled",
                GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterDetail.ChallengeEnabled => "challengeEnabled",
                GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterDetail.ChallengeReleases => "challengeReleases",
                GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterDetail.ChallengesMinimumPlatformVersions => "challengesMinimumPlatformVersions",
                GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterDetail.DefaultGroupLeaderboard => "defaultGroupLeaderboard",
                GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterDetail.DefaultGroupLeaderboardV2 => "defaultGroupLeaderboardV2",
                GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterDetail.DefaultLeaderboard => "defaultLeaderboard",
                GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterDetail.DefaultLeaderboardV2 => "defaultLeaderboardV2",
                GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterDetail.GameCenterAchievements => "gameCenterAchievements",
                GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterDetail.GameCenterAchievementsV2 => "gameCenterAchievementsV2",
                GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterDetail.GameCenterActivities => "gameCenterActivities",
                GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterDetail.GameCenterAppVersions => "gameCenterAppVersions",
                GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterDetail.GameCenterChallenges => "gameCenterChallenges",
                GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterDetail.GameCenterGroup => "gameCenterGroup",
                GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterDetail.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterDetail.GameCenterLeaderboardSetsV2 => "gameCenterLeaderboardSetsV2",
                GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterDetail.GameCenterLeaderboards => "gameCenterLeaderboards",
                GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterDetail.GameCenterLeaderboardsV2 => "gameCenterLeaderboardsV2",
                GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterDetail.LeaderboardReleases => "leaderboardReleases",
                GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterDetail.LeaderboardSetReleases => "leaderboardSetReleases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterDetail? ToEnum(string value)
        {
            return value switch
            {
                "achievementReleases" => GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterDetail.AchievementReleases,
                "activityReleases" => GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterDetail.ActivityReleases,
                "app" => GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterDetail.App,
                "arcadeEnabled" => GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterDetail.ArcadeEnabled,
                "challengeEnabled" => GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterDetail.ChallengeEnabled,
                "challengeReleases" => GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterDetail.ChallengeReleases,
                "challengesMinimumPlatformVersions" => GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterDetail.ChallengesMinimumPlatformVersions,
                "defaultGroupLeaderboard" => GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterDetail.DefaultGroupLeaderboard,
                "defaultGroupLeaderboardV2" => GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterDetail.DefaultGroupLeaderboardV2,
                "defaultLeaderboard" => GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterDetail.DefaultLeaderboard,
                "defaultLeaderboardV2" => GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterDetail.DefaultLeaderboardV2,
                "gameCenterAchievements" => GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterDetail.GameCenterAchievements,
                "gameCenterAchievementsV2" => GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterDetail.GameCenterAchievementsV2,
                "gameCenterActivities" => GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterDetail.GameCenterActivities,
                "gameCenterAppVersions" => GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterDetail.GameCenterAppVersions,
                "gameCenterChallenges" => GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterDetail.GameCenterChallenges,
                "gameCenterGroup" => GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterDetail.GameCenterGroup,
                "gameCenterLeaderboardSets" => GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterDetail.GameCenterLeaderboardSets,
                "gameCenterLeaderboardSetsV2" => GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterDetail.GameCenterLeaderboardSetsV2,
                "gameCenterLeaderboards" => GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterDetail.GameCenterLeaderboards,
                "gameCenterLeaderboardsV2" => GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterDetail.GameCenterLeaderboardsV2,
                "leaderboardReleases" => GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterDetail.LeaderboardReleases,
                "leaderboardSetReleases" => GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterDetail.LeaderboardSetReleases,
                _ => null,
            };
        }
    }
}