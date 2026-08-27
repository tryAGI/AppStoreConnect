
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterDetail
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
    public static class GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterDetail value)
        {
            return value switch
            {
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterDetail.AchievementReleases => "achievementReleases",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterDetail.ActivityReleases => "activityReleases",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterDetail.App => "app",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterDetail.ArcadeEnabled => "arcadeEnabled",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterDetail.ChallengeEnabled => "challengeEnabled",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterDetail.ChallengeReleases => "challengeReleases",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterDetail.ChallengesMinimumPlatformVersions => "challengesMinimumPlatformVersions",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterDetail.DefaultGroupLeaderboard => "defaultGroupLeaderboard",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterDetail.DefaultGroupLeaderboardV2 => "defaultGroupLeaderboardV2",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterDetail.DefaultLeaderboard => "defaultLeaderboard",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterDetail.DefaultLeaderboardV2 => "defaultLeaderboardV2",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterDetail.GameCenterAchievements => "gameCenterAchievements",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterDetail.GameCenterAchievementsV2 => "gameCenterAchievementsV2",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterDetail.GameCenterActivities => "gameCenterActivities",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterDetail.GameCenterAppVersions => "gameCenterAppVersions",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterDetail.GameCenterChallenges => "gameCenterChallenges",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterDetail.GameCenterGroup => "gameCenterGroup",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterDetail.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterDetail.GameCenterLeaderboardSetsV2 => "gameCenterLeaderboardSetsV2",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterDetail.GameCenterLeaderboards => "gameCenterLeaderboards",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterDetail.GameCenterLeaderboardsV2 => "gameCenterLeaderboardsV2",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterDetail.LeaderboardReleases => "leaderboardReleases",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterDetail.LeaderboardSetReleases => "leaderboardSetReleases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterDetail? ToEnum(string value)
        {
            return value switch
            {
                "achievementReleases" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterDetail.AchievementReleases,
                "activityReleases" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterDetail.ActivityReleases,
                "app" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterDetail.App,
                "arcadeEnabled" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterDetail.ArcadeEnabled,
                "challengeEnabled" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterDetail.ChallengeEnabled,
                "challengeReleases" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterDetail.ChallengeReleases,
                "challengesMinimumPlatformVersions" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterDetail.ChallengesMinimumPlatformVersions,
                "defaultGroupLeaderboard" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterDetail.DefaultGroupLeaderboard,
                "defaultGroupLeaderboardV2" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterDetail.DefaultGroupLeaderboardV2,
                "defaultLeaderboard" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterDetail.DefaultLeaderboard,
                "defaultLeaderboardV2" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterDetail.DefaultLeaderboardV2,
                "gameCenterAchievements" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterDetail.GameCenterAchievements,
                "gameCenterAchievementsV2" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterDetail.GameCenterAchievementsV2,
                "gameCenterActivities" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterDetail.GameCenterActivities,
                "gameCenterAppVersions" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterDetail.GameCenterAppVersions,
                "gameCenterChallenges" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterDetail.GameCenterChallenges,
                "gameCenterGroup" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterDetail.GameCenterGroup,
                "gameCenterLeaderboardSets" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterDetail.GameCenterLeaderboardSets,
                "gameCenterLeaderboardSetsV2" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterDetail.GameCenterLeaderboardSetsV2,
                "gameCenterLeaderboards" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterDetail.GameCenterLeaderboards,
                "gameCenterLeaderboardsV2" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterDetail.GameCenterLeaderboardsV2,
                "leaderboardReleases" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterDetail.LeaderboardReleases,
                "leaderboardSetReleases" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterDetail.LeaderboardSetReleases,
                _ => null,
            };
        }
    }
}