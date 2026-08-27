
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardsV2GetInstanceFieldsGameCenterActivitie
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
    public static class GameCenterLeaderboardsV2GetInstanceFieldsGameCenterActivitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardsV2GetInstanceFieldsGameCenterActivitie value)
        {
            return value switch
            {
                GameCenterLeaderboardsV2GetInstanceFieldsGameCenterActivitie.Achievements => "achievements",
                GameCenterLeaderboardsV2GetInstanceFieldsGameCenterActivitie.AchievementsV2 => "achievementsV2",
                GameCenterLeaderboardsV2GetInstanceFieldsGameCenterActivitie.Archived => "archived",
                GameCenterLeaderboardsV2GetInstanceFieldsGameCenterActivitie.GameCenterDetail => "gameCenterDetail",
                GameCenterLeaderboardsV2GetInstanceFieldsGameCenterActivitie.GameCenterGroup => "gameCenterGroup",
                GameCenterLeaderboardsV2GetInstanceFieldsGameCenterActivitie.Leaderboards => "leaderboards",
                GameCenterLeaderboardsV2GetInstanceFieldsGameCenterActivitie.LeaderboardsV2 => "leaderboardsV2",
                GameCenterLeaderboardsV2GetInstanceFieldsGameCenterActivitie.MaximumPlayersCount => "maximumPlayersCount",
                GameCenterLeaderboardsV2GetInstanceFieldsGameCenterActivitie.MinimumPlayersCount => "minimumPlayersCount",
                GameCenterLeaderboardsV2GetInstanceFieldsGameCenterActivitie.PlayStyle => "playStyle",
                GameCenterLeaderboardsV2GetInstanceFieldsGameCenterActivitie.Properties => "properties",
                GameCenterLeaderboardsV2GetInstanceFieldsGameCenterActivitie.ReferenceName => "referenceName",
                GameCenterLeaderboardsV2GetInstanceFieldsGameCenterActivitie.SupportsPartyCode => "supportsPartyCode",
                GameCenterLeaderboardsV2GetInstanceFieldsGameCenterActivitie.VendorIdentifier => "vendorIdentifier",
                GameCenterLeaderboardsV2GetInstanceFieldsGameCenterActivitie.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardsV2GetInstanceFieldsGameCenterActivitie? ToEnum(string value)
        {
            return value switch
            {
                "achievements" => GameCenterLeaderboardsV2GetInstanceFieldsGameCenterActivitie.Achievements,
                "achievementsV2" => GameCenterLeaderboardsV2GetInstanceFieldsGameCenterActivitie.AchievementsV2,
                "archived" => GameCenterLeaderboardsV2GetInstanceFieldsGameCenterActivitie.Archived,
                "gameCenterDetail" => GameCenterLeaderboardsV2GetInstanceFieldsGameCenterActivitie.GameCenterDetail,
                "gameCenterGroup" => GameCenterLeaderboardsV2GetInstanceFieldsGameCenterActivitie.GameCenterGroup,
                "leaderboards" => GameCenterLeaderboardsV2GetInstanceFieldsGameCenterActivitie.Leaderboards,
                "leaderboardsV2" => GameCenterLeaderboardsV2GetInstanceFieldsGameCenterActivitie.LeaderboardsV2,
                "maximumPlayersCount" => GameCenterLeaderboardsV2GetInstanceFieldsGameCenterActivitie.MaximumPlayersCount,
                "minimumPlayersCount" => GameCenterLeaderboardsV2GetInstanceFieldsGameCenterActivitie.MinimumPlayersCount,
                "playStyle" => GameCenterLeaderboardsV2GetInstanceFieldsGameCenterActivitie.PlayStyle,
                "properties" => GameCenterLeaderboardsV2GetInstanceFieldsGameCenterActivitie.Properties,
                "referenceName" => GameCenterLeaderboardsV2GetInstanceFieldsGameCenterActivitie.ReferenceName,
                "supportsPartyCode" => GameCenterLeaderboardsV2GetInstanceFieldsGameCenterActivitie.SupportsPartyCode,
                "vendorIdentifier" => GameCenterLeaderboardsV2GetInstanceFieldsGameCenterActivitie.VendorIdentifier,
                "versions" => GameCenterLeaderboardsV2GetInstanceFieldsGameCenterActivitie.Versions,
                _ => null,
            };
        }
    }
}