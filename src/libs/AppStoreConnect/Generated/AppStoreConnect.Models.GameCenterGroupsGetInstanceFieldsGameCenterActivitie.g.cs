
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterGroupsGetInstanceFieldsGameCenterActivitie
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
    public static class GameCenterGroupsGetInstanceFieldsGameCenterActivitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupsGetInstanceFieldsGameCenterActivitie value)
        {
            return value switch
            {
                GameCenterGroupsGetInstanceFieldsGameCenterActivitie.Achievements => "achievements",
                GameCenterGroupsGetInstanceFieldsGameCenterActivitie.AchievementsV2 => "achievementsV2",
                GameCenterGroupsGetInstanceFieldsGameCenterActivitie.Archived => "archived",
                GameCenterGroupsGetInstanceFieldsGameCenterActivitie.GameCenterDetail => "gameCenterDetail",
                GameCenterGroupsGetInstanceFieldsGameCenterActivitie.GameCenterGroup => "gameCenterGroup",
                GameCenterGroupsGetInstanceFieldsGameCenterActivitie.Leaderboards => "leaderboards",
                GameCenterGroupsGetInstanceFieldsGameCenterActivitie.LeaderboardsV2 => "leaderboardsV2",
                GameCenterGroupsGetInstanceFieldsGameCenterActivitie.MaximumPlayersCount => "maximumPlayersCount",
                GameCenterGroupsGetInstanceFieldsGameCenterActivitie.MinimumPlayersCount => "minimumPlayersCount",
                GameCenterGroupsGetInstanceFieldsGameCenterActivitie.PlayStyle => "playStyle",
                GameCenterGroupsGetInstanceFieldsGameCenterActivitie.Properties => "properties",
                GameCenterGroupsGetInstanceFieldsGameCenterActivitie.ReferenceName => "referenceName",
                GameCenterGroupsGetInstanceFieldsGameCenterActivitie.SupportsPartyCode => "supportsPartyCode",
                GameCenterGroupsGetInstanceFieldsGameCenterActivitie.VendorIdentifier => "vendorIdentifier",
                GameCenterGroupsGetInstanceFieldsGameCenterActivitie.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupsGetInstanceFieldsGameCenterActivitie? ToEnum(string value)
        {
            return value switch
            {
                "achievements" => GameCenterGroupsGetInstanceFieldsGameCenterActivitie.Achievements,
                "achievementsV2" => GameCenterGroupsGetInstanceFieldsGameCenterActivitie.AchievementsV2,
                "archived" => GameCenterGroupsGetInstanceFieldsGameCenterActivitie.Archived,
                "gameCenterDetail" => GameCenterGroupsGetInstanceFieldsGameCenterActivitie.GameCenterDetail,
                "gameCenterGroup" => GameCenterGroupsGetInstanceFieldsGameCenterActivitie.GameCenterGroup,
                "leaderboards" => GameCenterGroupsGetInstanceFieldsGameCenterActivitie.Leaderboards,
                "leaderboardsV2" => GameCenterGroupsGetInstanceFieldsGameCenterActivitie.LeaderboardsV2,
                "maximumPlayersCount" => GameCenterGroupsGetInstanceFieldsGameCenterActivitie.MaximumPlayersCount,
                "minimumPlayersCount" => GameCenterGroupsGetInstanceFieldsGameCenterActivitie.MinimumPlayersCount,
                "playStyle" => GameCenterGroupsGetInstanceFieldsGameCenterActivitie.PlayStyle,
                "properties" => GameCenterGroupsGetInstanceFieldsGameCenterActivitie.Properties,
                "referenceName" => GameCenterGroupsGetInstanceFieldsGameCenterActivitie.ReferenceName,
                "supportsPartyCode" => GameCenterGroupsGetInstanceFieldsGameCenterActivitie.SupportsPartyCode,
                "vendorIdentifier" => GameCenterGroupsGetInstanceFieldsGameCenterActivitie.VendorIdentifier,
                "versions" => GameCenterGroupsGetInstanceFieldsGameCenterActivitie.Versions,
                _ => null,
            };
        }
    }
}