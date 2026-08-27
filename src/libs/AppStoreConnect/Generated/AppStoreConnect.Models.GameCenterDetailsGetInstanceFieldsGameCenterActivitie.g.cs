
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterDetailsGetInstanceFieldsGameCenterActivitie
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
    public static class GameCenterDetailsGetInstanceFieldsGameCenterActivitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsGetInstanceFieldsGameCenterActivitie value)
        {
            return value switch
            {
                GameCenterDetailsGetInstanceFieldsGameCenterActivitie.Achievements => "achievements",
                GameCenterDetailsGetInstanceFieldsGameCenterActivitie.AchievementsV2 => "achievementsV2",
                GameCenterDetailsGetInstanceFieldsGameCenterActivitie.Archived => "archived",
                GameCenterDetailsGetInstanceFieldsGameCenterActivitie.GameCenterDetail => "gameCenterDetail",
                GameCenterDetailsGetInstanceFieldsGameCenterActivitie.GameCenterGroup => "gameCenterGroup",
                GameCenterDetailsGetInstanceFieldsGameCenterActivitie.Leaderboards => "leaderboards",
                GameCenterDetailsGetInstanceFieldsGameCenterActivitie.LeaderboardsV2 => "leaderboardsV2",
                GameCenterDetailsGetInstanceFieldsGameCenterActivitie.MaximumPlayersCount => "maximumPlayersCount",
                GameCenterDetailsGetInstanceFieldsGameCenterActivitie.MinimumPlayersCount => "minimumPlayersCount",
                GameCenterDetailsGetInstanceFieldsGameCenterActivitie.PlayStyle => "playStyle",
                GameCenterDetailsGetInstanceFieldsGameCenterActivitie.Properties => "properties",
                GameCenterDetailsGetInstanceFieldsGameCenterActivitie.ReferenceName => "referenceName",
                GameCenterDetailsGetInstanceFieldsGameCenterActivitie.SupportsPartyCode => "supportsPartyCode",
                GameCenterDetailsGetInstanceFieldsGameCenterActivitie.VendorIdentifier => "vendorIdentifier",
                GameCenterDetailsGetInstanceFieldsGameCenterActivitie.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsGetInstanceFieldsGameCenterActivitie? ToEnum(string value)
        {
            return value switch
            {
                "achievements" => GameCenterDetailsGetInstanceFieldsGameCenterActivitie.Achievements,
                "achievementsV2" => GameCenterDetailsGetInstanceFieldsGameCenterActivitie.AchievementsV2,
                "archived" => GameCenterDetailsGetInstanceFieldsGameCenterActivitie.Archived,
                "gameCenterDetail" => GameCenterDetailsGetInstanceFieldsGameCenterActivitie.GameCenterDetail,
                "gameCenterGroup" => GameCenterDetailsGetInstanceFieldsGameCenterActivitie.GameCenterGroup,
                "leaderboards" => GameCenterDetailsGetInstanceFieldsGameCenterActivitie.Leaderboards,
                "leaderboardsV2" => GameCenterDetailsGetInstanceFieldsGameCenterActivitie.LeaderboardsV2,
                "maximumPlayersCount" => GameCenterDetailsGetInstanceFieldsGameCenterActivitie.MaximumPlayersCount,
                "minimumPlayersCount" => GameCenterDetailsGetInstanceFieldsGameCenterActivitie.MinimumPlayersCount,
                "playStyle" => GameCenterDetailsGetInstanceFieldsGameCenterActivitie.PlayStyle,
                "properties" => GameCenterDetailsGetInstanceFieldsGameCenterActivitie.Properties,
                "referenceName" => GameCenterDetailsGetInstanceFieldsGameCenterActivitie.ReferenceName,
                "supportsPartyCode" => GameCenterDetailsGetInstanceFieldsGameCenterActivitie.SupportsPartyCode,
                "vendorIdentifier" => GameCenterDetailsGetInstanceFieldsGameCenterActivitie.VendorIdentifier,
                "versions" => GameCenterDetailsGetInstanceFieldsGameCenterActivitie.Versions,
                _ => null,
            };
        }
    }
}