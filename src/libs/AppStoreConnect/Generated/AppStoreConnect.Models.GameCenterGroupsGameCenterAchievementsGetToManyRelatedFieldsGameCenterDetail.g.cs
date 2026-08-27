
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetail
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
    public static class GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetail value)
        {
            return value switch
            {
                GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetail.AchievementReleases => "achievementReleases",
                GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetail.ActivityReleases => "activityReleases",
                GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetail.App => "app",
                GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetail.ArcadeEnabled => "arcadeEnabled",
                GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetail.ChallengeEnabled => "challengeEnabled",
                GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetail.ChallengeReleases => "challengeReleases",
                GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetail.ChallengesMinimumPlatformVersions => "challengesMinimumPlatformVersions",
                GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetail.DefaultGroupLeaderboard => "defaultGroupLeaderboard",
                GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetail.DefaultGroupLeaderboardV2 => "defaultGroupLeaderboardV2",
                GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetail.DefaultLeaderboard => "defaultLeaderboard",
                GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetail.DefaultLeaderboardV2 => "defaultLeaderboardV2",
                GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetail.GameCenterAchievements => "gameCenterAchievements",
                GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetail.GameCenterAchievementsV2 => "gameCenterAchievementsV2",
                GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetail.GameCenterActivities => "gameCenterActivities",
                GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetail.GameCenterAppVersions => "gameCenterAppVersions",
                GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetail.GameCenterChallenges => "gameCenterChallenges",
                GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetail.GameCenterGroup => "gameCenterGroup",
                GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetail.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetail.GameCenterLeaderboardSetsV2 => "gameCenterLeaderboardSetsV2",
                GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetail.GameCenterLeaderboards => "gameCenterLeaderboards",
                GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetail.GameCenterLeaderboardsV2 => "gameCenterLeaderboardsV2",
                GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetail.LeaderboardReleases => "leaderboardReleases",
                GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetail.LeaderboardSetReleases => "leaderboardSetReleases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetail? ToEnum(string value)
        {
            return value switch
            {
                "achievementReleases" => GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetail.AchievementReleases,
                "activityReleases" => GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetail.ActivityReleases,
                "app" => GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetail.App,
                "arcadeEnabled" => GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetail.ArcadeEnabled,
                "challengeEnabled" => GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetail.ChallengeEnabled,
                "challengeReleases" => GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetail.ChallengeReleases,
                "challengesMinimumPlatformVersions" => GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetail.ChallengesMinimumPlatformVersions,
                "defaultGroupLeaderboard" => GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetail.DefaultGroupLeaderboard,
                "defaultGroupLeaderboardV2" => GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetail.DefaultGroupLeaderboardV2,
                "defaultLeaderboard" => GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetail.DefaultLeaderboard,
                "defaultLeaderboardV2" => GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetail.DefaultLeaderboardV2,
                "gameCenterAchievements" => GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetail.GameCenterAchievements,
                "gameCenterAchievementsV2" => GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetail.GameCenterAchievementsV2,
                "gameCenterActivities" => GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetail.GameCenterActivities,
                "gameCenterAppVersions" => GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetail.GameCenterAppVersions,
                "gameCenterChallenges" => GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetail.GameCenterChallenges,
                "gameCenterGroup" => GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetail.GameCenterGroup,
                "gameCenterLeaderboardSets" => GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetail.GameCenterLeaderboardSets,
                "gameCenterLeaderboardSetsV2" => GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetail.GameCenterLeaderboardSetsV2,
                "gameCenterLeaderboards" => GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetail.GameCenterLeaderboards,
                "gameCenterLeaderboardsV2" => GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetail.GameCenterLeaderboardsV2,
                "leaderboardReleases" => GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetail.LeaderboardReleases,
                "leaderboardSetReleases" => GameCenterGroupsGameCenterAchievementsGetToManyRelatedFieldsGameCenterDetail.LeaderboardSetReleases,
                _ => null,
            };
        }
    }
}