
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardsGetInstanceFieldsGameCenterActivitie
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
    public static class GameCenterLeaderboardsGetInstanceFieldsGameCenterActivitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardsGetInstanceFieldsGameCenterActivitie value)
        {
            return value switch
            {
                GameCenterLeaderboardsGetInstanceFieldsGameCenterActivitie.Achievements => "achievements",
                GameCenterLeaderboardsGetInstanceFieldsGameCenterActivitie.AchievementsV2 => "achievementsV2",
                GameCenterLeaderboardsGetInstanceFieldsGameCenterActivitie.Archived => "archived",
                GameCenterLeaderboardsGetInstanceFieldsGameCenterActivitie.GameCenterDetail => "gameCenterDetail",
                GameCenterLeaderboardsGetInstanceFieldsGameCenterActivitie.GameCenterGroup => "gameCenterGroup",
                GameCenterLeaderboardsGetInstanceFieldsGameCenterActivitie.Leaderboards => "leaderboards",
                GameCenterLeaderboardsGetInstanceFieldsGameCenterActivitie.LeaderboardsV2 => "leaderboardsV2",
                GameCenterLeaderboardsGetInstanceFieldsGameCenterActivitie.MaximumPlayersCount => "maximumPlayersCount",
                GameCenterLeaderboardsGetInstanceFieldsGameCenterActivitie.MinimumPlayersCount => "minimumPlayersCount",
                GameCenterLeaderboardsGetInstanceFieldsGameCenterActivitie.PlayStyle => "playStyle",
                GameCenterLeaderboardsGetInstanceFieldsGameCenterActivitie.Properties => "properties",
                GameCenterLeaderboardsGetInstanceFieldsGameCenterActivitie.ReferenceName => "referenceName",
                GameCenterLeaderboardsGetInstanceFieldsGameCenterActivitie.SupportsPartyCode => "supportsPartyCode",
                GameCenterLeaderboardsGetInstanceFieldsGameCenterActivitie.VendorIdentifier => "vendorIdentifier",
                GameCenterLeaderboardsGetInstanceFieldsGameCenterActivitie.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardsGetInstanceFieldsGameCenterActivitie? ToEnum(string value)
        {
            return value switch
            {
                "achievements" => GameCenterLeaderboardsGetInstanceFieldsGameCenterActivitie.Achievements,
                "achievementsV2" => GameCenterLeaderboardsGetInstanceFieldsGameCenterActivitie.AchievementsV2,
                "archived" => GameCenterLeaderboardsGetInstanceFieldsGameCenterActivitie.Archived,
                "gameCenterDetail" => GameCenterLeaderboardsGetInstanceFieldsGameCenterActivitie.GameCenterDetail,
                "gameCenterGroup" => GameCenterLeaderboardsGetInstanceFieldsGameCenterActivitie.GameCenterGroup,
                "leaderboards" => GameCenterLeaderboardsGetInstanceFieldsGameCenterActivitie.Leaderboards,
                "leaderboardsV2" => GameCenterLeaderboardsGetInstanceFieldsGameCenterActivitie.LeaderboardsV2,
                "maximumPlayersCount" => GameCenterLeaderboardsGetInstanceFieldsGameCenterActivitie.MaximumPlayersCount,
                "minimumPlayersCount" => GameCenterLeaderboardsGetInstanceFieldsGameCenterActivitie.MinimumPlayersCount,
                "playStyle" => GameCenterLeaderboardsGetInstanceFieldsGameCenterActivitie.PlayStyle,
                "properties" => GameCenterLeaderboardsGetInstanceFieldsGameCenterActivitie.Properties,
                "referenceName" => GameCenterLeaderboardsGetInstanceFieldsGameCenterActivitie.ReferenceName,
                "supportsPartyCode" => GameCenterLeaderboardsGetInstanceFieldsGameCenterActivitie.SupportsPartyCode,
                "vendorIdentifier" => GameCenterLeaderboardsGetInstanceFieldsGameCenterActivitie.VendorIdentifier,
                "versions" => GameCenterLeaderboardsGetInstanceFieldsGameCenterActivitie.Versions,
                _ => null,
            };
        }
    }
}