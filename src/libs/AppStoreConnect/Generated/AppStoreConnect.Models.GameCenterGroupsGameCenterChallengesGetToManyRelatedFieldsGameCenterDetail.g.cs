
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetail
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
    public static class GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetail value)
        {
            return value switch
            {
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetail.AchievementReleases => "achievementReleases",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetail.ActivityReleases => "activityReleases",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetail.App => "app",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetail.ArcadeEnabled => "arcadeEnabled",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetail.ChallengeEnabled => "challengeEnabled",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetail.ChallengeReleases => "challengeReleases",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetail.ChallengesMinimumPlatformVersions => "challengesMinimumPlatformVersions",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetail.DefaultGroupLeaderboard => "defaultGroupLeaderboard",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetail.DefaultGroupLeaderboardV2 => "defaultGroupLeaderboardV2",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetail.DefaultLeaderboard => "defaultLeaderboard",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetail.DefaultLeaderboardV2 => "defaultLeaderboardV2",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetail.GameCenterAchievements => "gameCenterAchievements",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetail.GameCenterAchievementsV2 => "gameCenterAchievementsV2",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetail.GameCenterActivities => "gameCenterActivities",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetail.GameCenterAppVersions => "gameCenterAppVersions",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetail.GameCenterChallenges => "gameCenterChallenges",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetail.GameCenterGroup => "gameCenterGroup",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetail.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetail.GameCenterLeaderboardSetsV2 => "gameCenterLeaderboardSetsV2",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetail.GameCenterLeaderboards => "gameCenterLeaderboards",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetail.GameCenterLeaderboardsV2 => "gameCenterLeaderboardsV2",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetail.LeaderboardReleases => "leaderboardReleases",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetail.LeaderboardSetReleases => "leaderboardSetReleases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetail? ToEnum(string value)
        {
            return value switch
            {
                "achievementReleases" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetail.AchievementReleases,
                "activityReleases" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetail.ActivityReleases,
                "app" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetail.App,
                "arcadeEnabled" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetail.ArcadeEnabled,
                "challengeEnabled" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetail.ChallengeEnabled,
                "challengeReleases" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetail.ChallengeReleases,
                "challengesMinimumPlatformVersions" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetail.ChallengesMinimumPlatformVersions,
                "defaultGroupLeaderboard" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetail.DefaultGroupLeaderboard,
                "defaultGroupLeaderboardV2" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetail.DefaultGroupLeaderboardV2,
                "defaultLeaderboard" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetail.DefaultLeaderboard,
                "defaultLeaderboardV2" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetail.DefaultLeaderboardV2,
                "gameCenterAchievements" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetail.GameCenterAchievements,
                "gameCenterAchievementsV2" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetail.GameCenterAchievementsV2,
                "gameCenterActivities" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetail.GameCenterActivities,
                "gameCenterAppVersions" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetail.GameCenterAppVersions,
                "gameCenterChallenges" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetail.GameCenterChallenges,
                "gameCenterGroup" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetail.GameCenterGroup,
                "gameCenterLeaderboardSets" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetail.GameCenterLeaderboardSets,
                "gameCenterLeaderboardSetsV2" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetail.GameCenterLeaderboardSetsV2,
                "gameCenterLeaderboards" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetail.GameCenterLeaderboards,
                "gameCenterLeaderboardsV2" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetail.GameCenterLeaderboardsV2,
                "leaderboardReleases" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetail.LeaderboardReleases,
                "leaderboardSetReleases" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterDetail.LeaderboardSetReleases,
                _ => null,
            };
        }
    }
}