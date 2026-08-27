
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterActivitie
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
    public static class GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterActivitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterActivitie value)
        {
            return value switch
            {
                GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterActivitie.Achievements => "achievements",
                GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterActivitie.AchievementsV2 => "achievementsV2",
                GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterActivitie.Archived => "archived",
                GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterActivitie.GameCenterDetail => "gameCenterDetail",
                GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterActivitie.GameCenterGroup => "gameCenterGroup",
                GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterActivitie.Leaderboards => "leaderboards",
                GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterActivitie.LeaderboardsV2 => "leaderboardsV2",
                GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterActivitie.MaximumPlayersCount => "maximumPlayersCount",
                GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterActivitie.MinimumPlayersCount => "minimumPlayersCount",
                GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterActivitie.PlayStyle => "playStyle",
                GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterActivitie.Properties => "properties",
                GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterActivitie.ReferenceName => "referenceName",
                GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterActivitie.SupportsPartyCode => "supportsPartyCode",
                GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterActivitie.VendorIdentifier => "vendorIdentifier",
                GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterActivitie.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterActivitie? ToEnum(string value)
        {
            return value switch
            {
                "achievements" => GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterActivitie.Achievements,
                "achievementsV2" => GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterActivitie.AchievementsV2,
                "archived" => GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterActivitie.Archived,
                "gameCenterDetail" => GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterActivitie.GameCenterDetail,
                "gameCenterGroup" => GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterActivitie.GameCenterGroup,
                "leaderboards" => GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterActivitie.Leaderboards,
                "leaderboardsV2" => GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterActivitie.LeaderboardsV2,
                "maximumPlayersCount" => GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterActivitie.MaximumPlayersCount,
                "minimumPlayersCount" => GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterActivitie.MinimumPlayersCount,
                "playStyle" => GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterActivitie.PlayStyle,
                "properties" => GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterActivitie.Properties,
                "referenceName" => GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterActivitie.ReferenceName,
                "supportsPartyCode" => GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterActivitie.SupportsPartyCode,
                "vendorIdentifier" => GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterActivitie.VendorIdentifier,
                "versions" => GameCenterAchievementLocalizationsGameCenterAchievementGetToOneRelatedFieldsGameCenterActivitie.Versions,
                _ => null,
            };
        }
    }
}