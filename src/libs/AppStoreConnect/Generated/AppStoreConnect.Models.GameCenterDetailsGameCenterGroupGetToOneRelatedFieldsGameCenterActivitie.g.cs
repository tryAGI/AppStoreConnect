
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterActivitie
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
    public static class GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterActivitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterActivitie value)
        {
            return value switch
            {
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterActivitie.Achievements => "achievements",
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterActivitie.AchievementsV2 => "achievementsV2",
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterActivitie.Archived => "archived",
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterActivitie.GameCenterDetail => "gameCenterDetail",
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterActivitie.GameCenterGroup => "gameCenterGroup",
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterActivitie.Leaderboards => "leaderboards",
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterActivitie.LeaderboardsV2 => "leaderboardsV2",
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterActivitie.MaximumPlayersCount => "maximumPlayersCount",
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterActivitie.MinimumPlayersCount => "minimumPlayersCount",
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterActivitie.PlayStyle => "playStyle",
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterActivitie.Properties => "properties",
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterActivitie.ReferenceName => "referenceName",
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterActivitie.SupportsPartyCode => "supportsPartyCode",
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterActivitie.VendorIdentifier => "vendorIdentifier",
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterActivitie.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterActivitie? ToEnum(string value)
        {
            return value switch
            {
                "achievements" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterActivitie.Achievements,
                "achievementsV2" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterActivitie.AchievementsV2,
                "archived" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterActivitie.Archived,
                "gameCenterDetail" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterActivitie.GameCenterDetail,
                "gameCenterGroup" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterActivitie.GameCenterGroup,
                "leaderboards" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterActivitie.Leaderboards,
                "leaderboardsV2" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterActivitie.LeaderboardsV2,
                "maximumPlayersCount" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterActivitie.MaximumPlayersCount,
                "minimumPlayersCount" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterActivitie.MinimumPlayersCount,
                "playStyle" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterActivitie.PlayStyle,
                "properties" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterActivitie.Properties,
                "referenceName" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterActivitie.ReferenceName,
                "supportsPartyCode" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterActivitie.SupportsPartyCode,
                "vendorIdentifier" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterActivitie.VendorIdentifier,
                "versions" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterActivitie.Versions,
                _ => null,
            };
        }
    }
}