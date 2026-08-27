
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterActivitiesGetInstanceFieldsGameCenterActivitie
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
    public static class GameCenterActivitiesGetInstanceFieldsGameCenterActivitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterActivitiesGetInstanceFieldsGameCenterActivitie value)
        {
            return value switch
            {
                GameCenterActivitiesGetInstanceFieldsGameCenterActivitie.Achievements => "achievements",
                GameCenterActivitiesGetInstanceFieldsGameCenterActivitie.AchievementsV2 => "achievementsV2",
                GameCenterActivitiesGetInstanceFieldsGameCenterActivitie.Archived => "archived",
                GameCenterActivitiesGetInstanceFieldsGameCenterActivitie.GameCenterDetail => "gameCenterDetail",
                GameCenterActivitiesGetInstanceFieldsGameCenterActivitie.GameCenterGroup => "gameCenterGroup",
                GameCenterActivitiesGetInstanceFieldsGameCenterActivitie.Leaderboards => "leaderboards",
                GameCenterActivitiesGetInstanceFieldsGameCenterActivitie.LeaderboardsV2 => "leaderboardsV2",
                GameCenterActivitiesGetInstanceFieldsGameCenterActivitie.MaximumPlayersCount => "maximumPlayersCount",
                GameCenterActivitiesGetInstanceFieldsGameCenterActivitie.MinimumPlayersCount => "minimumPlayersCount",
                GameCenterActivitiesGetInstanceFieldsGameCenterActivitie.PlayStyle => "playStyle",
                GameCenterActivitiesGetInstanceFieldsGameCenterActivitie.Properties => "properties",
                GameCenterActivitiesGetInstanceFieldsGameCenterActivitie.ReferenceName => "referenceName",
                GameCenterActivitiesGetInstanceFieldsGameCenterActivitie.SupportsPartyCode => "supportsPartyCode",
                GameCenterActivitiesGetInstanceFieldsGameCenterActivitie.VendorIdentifier => "vendorIdentifier",
                GameCenterActivitiesGetInstanceFieldsGameCenterActivitie.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterActivitiesGetInstanceFieldsGameCenterActivitie? ToEnum(string value)
        {
            return value switch
            {
                "achievements" => GameCenterActivitiesGetInstanceFieldsGameCenterActivitie.Achievements,
                "achievementsV2" => GameCenterActivitiesGetInstanceFieldsGameCenterActivitie.AchievementsV2,
                "archived" => GameCenterActivitiesGetInstanceFieldsGameCenterActivitie.Archived,
                "gameCenterDetail" => GameCenterActivitiesGetInstanceFieldsGameCenterActivitie.GameCenterDetail,
                "gameCenterGroup" => GameCenterActivitiesGetInstanceFieldsGameCenterActivitie.GameCenterGroup,
                "leaderboards" => GameCenterActivitiesGetInstanceFieldsGameCenterActivitie.Leaderboards,
                "leaderboardsV2" => GameCenterActivitiesGetInstanceFieldsGameCenterActivitie.LeaderboardsV2,
                "maximumPlayersCount" => GameCenterActivitiesGetInstanceFieldsGameCenterActivitie.MaximumPlayersCount,
                "minimumPlayersCount" => GameCenterActivitiesGetInstanceFieldsGameCenterActivitie.MinimumPlayersCount,
                "playStyle" => GameCenterActivitiesGetInstanceFieldsGameCenterActivitie.PlayStyle,
                "properties" => GameCenterActivitiesGetInstanceFieldsGameCenterActivitie.Properties,
                "referenceName" => GameCenterActivitiesGetInstanceFieldsGameCenterActivitie.ReferenceName,
                "supportsPartyCode" => GameCenterActivitiesGetInstanceFieldsGameCenterActivitie.SupportsPartyCode,
                "vendorIdentifier" => GameCenterActivitiesGetInstanceFieldsGameCenterActivitie.VendorIdentifier,
                "versions" => GameCenterActivitiesGetInstanceFieldsGameCenterActivitie.Versions,
                _ => null,
            };
        }
    }
}