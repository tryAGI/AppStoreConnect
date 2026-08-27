
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterActivitie
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
    public static class GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterActivitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterActivitie value)
        {
            return value switch
            {
                GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterActivitie.Achievements => "achievements",
                GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterActivitie.AchievementsV2 => "achievementsV2",
                GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterActivitie.Archived => "archived",
                GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterActivitie.GameCenterDetail => "gameCenterDetail",
                GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterActivitie.GameCenterGroup => "gameCenterGroup",
                GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterActivitie.Leaderboards => "leaderboards",
                GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterActivitie.LeaderboardsV2 => "leaderboardsV2",
                GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterActivitie.MaximumPlayersCount => "maximumPlayersCount",
                GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterActivitie.MinimumPlayersCount => "minimumPlayersCount",
                GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterActivitie.PlayStyle => "playStyle",
                GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterActivitie.Properties => "properties",
                GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterActivitie.ReferenceName => "referenceName",
                GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterActivitie.SupportsPartyCode => "supportsPartyCode",
                GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterActivitie.VendorIdentifier => "vendorIdentifier",
                GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterActivitie.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterActivitie? ToEnum(string value)
        {
            return value switch
            {
                "achievements" => GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterActivitie.Achievements,
                "achievementsV2" => GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterActivitie.AchievementsV2,
                "archived" => GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterActivitie.Archived,
                "gameCenterDetail" => GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterActivitie.GameCenterDetail,
                "gameCenterGroup" => GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterActivitie.GameCenterGroup,
                "leaderboards" => GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterActivitie.Leaderboards,
                "leaderboardsV2" => GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterActivitie.LeaderboardsV2,
                "maximumPlayersCount" => GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterActivitie.MaximumPlayersCount,
                "minimumPlayersCount" => GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterActivitie.MinimumPlayersCount,
                "playStyle" => GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterActivitie.PlayStyle,
                "properties" => GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterActivitie.Properties,
                "referenceName" => GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterActivitie.ReferenceName,
                "supportsPartyCode" => GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterActivitie.SupportsPartyCode,
                "vendorIdentifier" => GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterActivitie.VendorIdentifier,
                "versions" => GameCenterDetailsGameCenterAchievementsGetToManyRelatedFieldsGameCenterActivitie.Versions,
                _ => null,
            };
        }
    }
}