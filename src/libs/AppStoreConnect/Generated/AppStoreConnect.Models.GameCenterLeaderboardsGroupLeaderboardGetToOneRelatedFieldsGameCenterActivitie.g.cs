
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterActivitie
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
    public static class GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterActivitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterActivitie value)
        {
            return value switch
            {
                GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterActivitie.Achievements => "achievements",
                GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterActivitie.AchievementsV2 => "achievementsV2",
                GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterActivitie.Archived => "archived",
                GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterActivitie.GameCenterDetail => "gameCenterDetail",
                GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterActivitie.GameCenterGroup => "gameCenterGroup",
                GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterActivitie.Leaderboards => "leaderboards",
                GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterActivitie.LeaderboardsV2 => "leaderboardsV2",
                GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterActivitie.MaximumPlayersCount => "maximumPlayersCount",
                GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterActivitie.MinimumPlayersCount => "minimumPlayersCount",
                GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterActivitie.PlayStyle => "playStyle",
                GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterActivitie.Properties => "properties",
                GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterActivitie.ReferenceName => "referenceName",
                GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterActivitie.SupportsPartyCode => "supportsPartyCode",
                GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterActivitie.VendorIdentifier => "vendorIdentifier",
                GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterActivitie.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterActivitie? ToEnum(string value)
        {
            return value switch
            {
                "achievements" => GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterActivitie.Achievements,
                "achievementsV2" => GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterActivitie.AchievementsV2,
                "archived" => GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterActivitie.Archived,
                "gameCenterDetail" => GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterActivitie.GameCenterDetail,
                "gameCenterGroup" => GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterActivitie.GameCenterGroup,
                "leaderboards" => GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterActivitie.Leaderboards,
                "leaderboardsV2" => GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterActivitie.LeaderboardsV2,
                "maximumPlayersCount" => GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterActivitie.MaximumPlayersCount,
                "minimumPlayersCount" => GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterActivitie.MinimumPlayersCount,
                "playStyle" => GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterActivitie.PlayStyle,
                "properties" => GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterActivitie.Properties,
                "referenceName" => GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterActivitie.ReferenceName,
                "supportsPartyCode" => GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterActivitie.SupportsPartyCode,
                "vendorIdentifier" => GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterActivitie.VendorIdentifier,
                "versions" => GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterActivitie.Versions,
                _ => null,
            };
        }
    }
}