
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterActivitie
    {
        /// <summary>
        /// 
        /// </summary>
        Achievements,
        /// <summary>
        /// 
        /// </summary>
        AchievementsV2,
        /// <summary>
        /// 
        /// </summary>
        Archived,
        /// <summary>
        /// 
        /// </summary>
        GameCenterDetail,
        /// <summary>
        /// 
        /// </summary>
        GameCenterGroup,
        /// <summary>
        /// 
        /// </summary>
        Leaderboards,
        /// <summary>
        /// 
        /// </summary>
        LeaderboardsV2,
        /// <summary>
        /// 
        /// </summary>
        MaximumPlayersCount,
        /// <summary>
        /// 
        /// </summary>
        MinimumPlayersCount,
        /// <summary>
        /// 
        /// </summary>
        PlayStyle,
        /// <summary>
        /// 
        /// </summary>
        Properties,
        /// <summary>
        /// 
        /// </summary>
        ReferenceName,
        /// <summary>
        /// 
        /// </summary>
        SupportsPartyCode,
        /// <summary>
        /// 
        /// </summary>
        VendorIdentifier,
        /// <summary>
        /// 
        /// </summary>
        Versions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterActivitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterActivitie value)
        {
            return value switch
            {
                GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterActivitie.Achievements => "achievements",
                GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterActivitie.AchievementsV2 => "achievementsV2",
                GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterActivitie.Archived => "archived",
                GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterActivitie.GameCenterDetail => "gameCenterDetail",
                GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterActivitie.GameCenterGroup => "gameCenterGroup",
                GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterActivitie.Leaderboards => "leaderboards",
                GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterActivitie.LeaderboardsV2 => "leaderboardsV2",
                GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterActivitie.MaximumPlayersCount => "maximumPlayersCount",
                GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterActivitie.MinimumPlayersCount => "minimumPlayersCount",
                GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterActivitie.PlayStyle => "playStyle",
                GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterActivitie.Properties => "properties",
                GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterActivitie.ReferenceName => "referenceName",
                GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterActivitie.SupportsPartyCode => "supportsPartyCode",
                GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterActivitie.VendorIdentifier => "vendorIdentifier",
                GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterActivitie.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterActivitie? ToEnum(string value)
        {
            return value switch
            {
                "achievements" => GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterActivitie.Achievements,
                "achievementsV2" => GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterActivitie.AchievementsV2,
                "archived" => GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterActivitie.Archived,
                "gameCenterDetail" => GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterActivitie.GameCenterDetail,
                "gameCenterGroup" => GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterActivitie.GameCenterGroup,
                "leaderboards" => GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterActivitie.Leaderboards,
                "leaderboardsV2" => GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterActivitie.LeaderboardsV2,
                "maximumPlayersCount" => GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterActivitie.MaximumPlayersCount,
                "minimumPlayersCount" => GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterActivitie.MinimumPlayersCount,
                "playStyle" => GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterActivitie.PlayStyle,
                "properties" => GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterActivitie.Properties,
                "referenceName" => GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterActivitie.ReferenceName,
                "supportsPartyCode" => GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterActivitie.SupportsPartyCode,
                "vendorIdentifier" => GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterActivitie.VendorIdentifier,
                "versions" => GameCenterAchievementsGroupAchievementGetToOneRelatedFieldsGameCenterActivitie.Versions,
                _ => null,
            };
        }
    }
}