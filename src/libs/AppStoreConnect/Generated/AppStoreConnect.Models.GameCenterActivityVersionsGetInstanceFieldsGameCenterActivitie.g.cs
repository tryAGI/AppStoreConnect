
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterActivityVersionsGetInstanceFieldsGameCenterActivitie
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
    public static class GameCenterActivityVersionsGetInstanceFieldsGameCenterActivitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterActivityVersionsGetInstanceFieldsGameCenterActivitie value)
        {
            return value switch
            {
                GameCenterActivityVersionsGetInstanceFieldsGameCenterActivitie.Achievements => "achievements",
                GameCenterActivityVersionsGetInstanceFieldsGameCenterActivitie.AchievementsV2 => "achievementsV2",
                GameCenterActivityVersionsGetInstanceFieldsGameCenterActivitie.Archived => "archived",
                GameCenterActivityVersionsGetInstanceFieldsGameCenterActivitie.GameCenterDetail => "gameCenterDetail",
                GameCenterActivityVersionsGetInstanceFieldsGameCenterActivitie.GameCenterGroup => "gameCenterGroup",
                GameCenterActivityVersionsGetInstanceFieldsGameCenterActivitie.Leaderboards => "leaderboards",
                GameCenterActivityVersionsGetInstanceFieldsGameCenterActivitie.LeaderboardsV2 => "leaderboardsV2",
                GameCenterActivityVersionsGetInstanceFieldsGameCenterActivitie.MaximumPlayersCount => "maximumPlayersCount",
                GameCenterActivityVersionsGetInstanceFieldsGameCenterActivitie.MinimumPlayersCount => "minimumPlayersCount",
                GameCenterActivityVersionsGetInstanceFieldsGameCenterActivitie.PlayStyle => "playStyle",
                GameCenterActivityVersionsGetInstanceFieldsGameCenterActivitie.Properties => "properties",
                GameCenterActivityVersionsGetInstanceFieldsGameCenterActivitie.ReferenceName => "referenceName",
                GameCenterActivityVersionsGetInstanceFieldsGameCenterActivitie.SupportsPartyCode => "supportsPartyCode",
                GameCenterActivityVersionsGetInstanceFieldsGameCenterActivitie.VendorIdentifier => "vendorIdentifier",
                GameCenterActivityVersionsGetInstanceFieldsGameCenterActivitie.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterActivityVersionsGetInstanceFieldsGameCenterActivitie? ToEnum(string value)
        {
            return value switch
            {
                "achievements" => GameCenterActivityVersionsGetInstanceFieldsGameCenterActivitie.Achievements,
                "achievementsV2" => GameCenterActivityVersionsGetInstanceFieldsGameCenterActivitie.AchievementsV2,
                "archived" => GameCenterActivityVersionsGetInstanceFieldsGameCenterActivitie.Archived,
                "gameCenterDetail" => GameCenterActivityVersionsGetInstanceFieldsGameCenterActivitie.GameCenterDetail,
                "gameCenterGroup" => GameCenterActivityVersionsGetInstanceFieldsGameCenterActivitie.GameCenterGroup,
                "leaderboards" => GameCenterActivityVersionsGetInstanceFieldsGameCenterActivitie.Leaderboards,
                "leaderboardsV2" => GameCenterActivityVersionsGetInstanceFieldsGameCenterActivitie.LeaderboardsV2,
                "maximumPlayersCount" => GameCenterActivityVersionsGetInstanceFieldsGameCenterActivitie.MaximumPlayersCount,
                "minimumPlayersCount" => GameCenterActivityVersionsGetInstanceFieldsGameCenterActivitie.MinimumPlayersCount,
                "playStyle" => GameCenterActivityVersionsGetInstanceFieldsGameCenterActivitie.PlayStyle,
                "properties" => GameCenterActivityVersionsGetInstanceFieldsGameCenterActivitie.Properties,
                "referenceName" => GameCenterActivityVersionsGetInstanceFieldsGameCenterActivitie.ReferenceName,
                "supportsPartyCode" => GameCenterActivityVersionsGetInstanceFieldsGameCenterActivitie.SupportsPartyCode,
                "vendorIdentifier" => GameCenterActivityVersionsGetInstanceFieldsGameCenterActivitie.VendorIdentifier,
                "versions" => GameCenterActivityVersionsGetInstanceFieldsGameCenterActivitie.Versions,
                _ => null,
            };
        }
    }
}