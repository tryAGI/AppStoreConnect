
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsGameCenterDetailGetToOneRelatedFieldsGameCenterActivitie
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
    public static class AppsGameCenterDetailGetToOneRelatedFieldsGameCenterActivitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGameCenterDetailGetToOneRelatedFieldsGameCenterActivitie value)
        {
            return value switch
            {
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterActivitie.Achievements => "achievements",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterActivitie.AchievementsV2 => "achievementsV2",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterActivitie.Archived => "archived",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterActivitie.GameCenterDetail => "gameCenterDetail",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterActivitie.GameCenterGroup => "gameCenterGroup",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterActivitie.Leaderboards => "leaderboards",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterActivitie.LeaderboardsV2 => "leaderboardsV2",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterActivitie.MaximumPlayersCount => "maximumPlayersCount",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterActivitie.MinimumPlayersCount => "minimumPlayersCount",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterActivitie.PlayStyle => "playStyle",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterActivitie.Properties => "properties",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterActivitie.ReferenceName => "referenceName",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterActivitie.SupportsPartyCode => "supportsPartyCode",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterActivitie.VendorIdentifier => "vendorIdentifier",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterActivitie.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGameCenterDetailGetToOneRelatedFieldsGameCenterActivitie? ToEnum(string value)
        {
            return value switch
            {
                "achievements" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterActivitie.Achievements,
                "achievementsV2" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterActivitie.AchievementsV2,
                "archived" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterActivitie.Archived,
                "gameCenterDetail" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterActivitie.GameCenterDetail,
                "gameCenterGroup" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterActivitie.GameCenterGroup,
                "leaderboards" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterActivitie.Leaderboards,
                "leaderboardsV2" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterActivitie.LeaderboardsV2,
                "maximumPlayersCount" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterActivitie.MaximumPlayersCount,
                "minimumPlayersCount" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterActivitie.MinimumPlayersCount,
                "playStyle" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterActivitie.PlayStyle,
                "properties" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterActivitie.Properties,
                "referenceName" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterActivitie.ReferenceName,
                "supportsPartyCode" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterActivitie.SupportsPartyCode,
                "vendorIdentifier" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterActivitie.VendorIdentifier,
                "versions" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterActivitie.Versions,
                _ => null,
            };
        }
    }
}