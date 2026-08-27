
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterAchievementsGetInstanceFieldsGameCenterActivitie
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
    public static class GameCenterAchievementsGetInstanceFieldsGameCenterActivitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementsGetInstanceFieldsGameCenterActivitie value)
        {
            return value switch
            {
                GameCenterAchievementsGetInstanceFieldsGameCenterActivitie.Achievements => "achievements",
                GameCenterAchievementsGetInstanceFieldsGameCenterActivitie.AchievementsV2 => "achievementsV2",
                GameCenterAchievementsGetInstanceFieldsGameCenterActivitie.Archived => "archived",
                GameCenterAchievementsGetInstanceFieldsGameCenterActivitie.GameCenterDetail => "gameCenterDetail",
                GameCenterAchievementsGetInstanceFieldsGameCenterActivitie.GameCenterGroup => "gameCenterGroup",
                GameCenterAchievementsGetInstanceFieldsGameCenterActivitie.Leaderboards => "leaderboards",
                GameCenterAchievementsGetInstanceFieldsGameCenterActivitie.LeaderboardsV2 => "leaderboardsV2",
                GameCenterAchievementsGetInstanceFieldsGameCenterActivitie.MaximumPlayersCount => "maximumPlayersCount",
                GameCenterAchievementsGetInstanceFieldsGameCenterActivitie.MinimumPlayersCount => "minimumPlayersCount",
                GameCenterAchievementsGetInstanceFieldsGameCenterActivitie.PlayStyle => "playStyle",
                GameCenterAchievementsGetInstanceFieldsGameCenterActivitie.Properties => "properties",
                GameCenterAchievementsGetInstanceFieldsGameCenterActivitie.ReferenceName => "referenceName",
                GameCenterAchievementsGetInstanceFieldsGameCenterActivitie.SupportsPartyCode => "supportsPartyCode",
                GameCenterAchievementsGetInstanceFieldsGameCenterActivitie.VendorIdentifier => "vendorIdentifier",
                GameCenterAchievementsGetInstanceFieldsGameCenterActivitie.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementsGetInstanceFieldsGameCenterActivitie? ToEnum(string value)
        {
            return value switch
            {
                "achievements" => GameCenterAchievementsGetInstanceFieldsGameCenterActivitie.Achievements,
                "achievementsV2" => GameCenterAchievementsGetInstanceFieldsGameCenterActivitie.AchievementsV2,
                "archived" => GameCenterAchievementsGetInstanceFieldsGameCenterActivitie.Archived,
                "gameCenterDetail" => GameCenterAchievementsGetInstanceFieldsGameCenterActivitie.GameCenterDetail,
                "gameCenterGroup" => GameCenterAchievementsGetInstanceFieldsGameCenterActivitie.GameCenterGroup,
                "leaderboards" => GameCenterAchievementsGetInstanceFieldsGameCenterActivitie.Leaderboards,
                "leaderboardsV2" => GameCenterAchievementsGetInstanceFieldsGameCenterActivitie.LeaderboardsV2,
                "maximumPlayersCount" => GameCenterAchievementsGetInstanceFieldsGameCenterActivitie.MaximumPlayersCount,
                "minimumPlayersCount" => GameCenterAchievementsGetInstanceFieldsGameCenterActivitie.MinimumPlayersCount,
                "playStyle" => GameCenterAchievementsGetInstanceFieldsGameCenterActivitie.PlayStyle,
                "properties" => GameCenterAchievementsGetInstanceFieldsGameCenterActivitie.Properties,
                "referenceName" => GameCenterAchievementsGetInstanceFieldsGameCenterActivitie.ReferenceName,
                "supportsPartyCode" => GameCenterAchievementsGetInstanceFieldsGameCenterActivitie.SupportsPartyCode,
                "vendorIdentifier" => GameCenterAchievementsGetInstanceFieldsGameCenterActivitie.VendorIdentifier,
                "versions" => GameCenterAchievementsGetInstanceFieldsGameCenterActivitie.Versions,
                _ => null,
            };
        }
    }
}