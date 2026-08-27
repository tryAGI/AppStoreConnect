
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterGroupsGetCollectionFieldsGameCenterActivitie
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
    public static class GameCenterGroupsGetCollectionFieldsGameCenterActivitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupsGetCollectionFieldsGameCenterActivitie value)
        {
            return value switch
            {
                GameCenterGroupsGetCollectionFieldsGameCenterActivitie.Achievements => "achievements",
                GameCenterGroupsGetCollectionFieldsGameCenterActivitie.AchievementsV2 => "achievementsV2",
                GameCenterGroupsGetCollectionFieldsGameCenterActivitie.Archived => "archived",
                GameCenterGroupsGetCollectionFieldsGameCenterActivitie.GameCenterDetail => "gameCenterDetail",
                GameCenterGroupsGetCollectionFieldsGameCenterActivitie.GameCenterGroup => "gameCenterGroup",
                GameCenterGroupsGetCollectionFieldsGameCenterActivitie.Leaderboards => "leaderboards",
                GameCenterGroupsGetCollectionFieldsGameCenterActivitie.LeaderboardsV2 => "leaderboardsV2",
                GameCenterGroupsGetCollectionFieldsGameCenterActivitie.MaximumPlayersCount => "maximumPlayersCount",
                GameCenterGroupsGetCollectionFieldsGameCenterActivitie.MinimumPlayersCount => "minimumPlayersCount",
                GameCenterGroupsGetCollectionFieldsGameCenterActivitie.PlayStyle => "playStyle",
                GameCenterGroupsGetCollectionFieldsGameCenterActivitie.Properties => "properties",
                GameCenterGroupsGetCollectionFieldsGameCenterActivitie.ReferenceName => "referenceName",
                GameCenterGroupsGetCollectionFieldsGameCenterActivitie.SupportsPartyCode => "supportsPartyCode",
                GameCenterGroupsGetCollectionFieldsGameCenterActivitie.VendorIdentifier => "vendorIdentifier",
                GameCenterGroupsGetCollectionFieldsGameCenterActivitie.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupsGetCollectionFieldsGameCenterActivitie? ToEnum(string value)
        {
            return value switch
            {
                "achievements" => GameCenterGroupsGetCollectionFieldsGameCenterActivitie.Achievements,
                "achievementsV2" => GameCenterGroupsGetCollectionFieldsGameCenterActivitie.AchievementsV2,
                "archived" => GameCenterGroupsGetCollectionFieldsGameCenterActivitie.Archived,
                "gameCenterDetail" => GameCenterGroupsGetCollectionFieldsGameCenterActivitie.GameCenterDetail,
                "gameCenterGroup" => GameCenterGroupsGetCollectionFieldsGameCenterActivitie.GameCenterGroup,
                "leaderboards" => GameCenterGroupsGetCollectionFieldsGameCenterActivitie.Leaderboards,
                "leaderboardsV2" => GameCenterGroupsGetCollectionFieldsGameCenterActivitie.LeaderboardsV2,
                "maximumPlayersCount" => GameCenterGroupsGetCollectionFieldsGameCenterActivitie.MaximumPlayersCount,
                "minimumPlayersCount" => GameCenterGroupsGetCollectionFieldsGameCenterActivitie.MinimumPlayersCount,
                "playStyle" => GameCenterGroupsGetCollectionFieldsGameCenterActivitie.PlayStyle,
                "properties" => GameCenterGroupsGetCollectionFieldsGameCenterActivitie.Properties,
                "referenceName" => GameCenterGroupsGetCollectionFieldsGameCenterActivitie.ReferenceName,
                "supportsPartyCode" => GameCenterGroupsGetCollectionFieldsGameCenterActivitie.SupportsPartyCode,
                "vendorIdentifier" => GameCenterGroupsGetCollectionFieldsGameCenterActivitie.VendorIdentifier,
                "versions" => GameCenterGroupsGetCollectionFieldsGameCenterActivitie.Versions,
                _ => null,
            };
        }
    }
}