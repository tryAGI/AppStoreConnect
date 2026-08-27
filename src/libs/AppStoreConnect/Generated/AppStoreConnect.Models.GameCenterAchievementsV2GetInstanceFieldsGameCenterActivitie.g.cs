
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAchievementsV2GetInstanceFieldsGameCenterActivitie
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
    public static class GameCenterAchievementsV2GetInstanceFieldsGameCenterActivitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementsV2GetInstanceFieldsGameCenterActivitie value)
        {
            return value switch
            {
                GameCenterAchievementsV2GetInstanceFieldsGameCenterActivitie.Achievements => "achievements",
                GameCenterAchievementsV2GetInstanceFieldsGameCenterActivitie.AchievementsV2 => "achievementsV2",
                GameCenterAchievementsV2GetInstanceFieldsGameCenterActivitie.Archived => "archived",
                GameCenterAchievementsV2GetInstanceFieldsGameCenterActivitie.GameCenterDetail => "gameCenterDetail",
                GameCenterAchievementsV2GetInstanceFieldsGameCenterActivitie.GameCenterGroup => "gameCenterGroup",
                GameCenterAchievementsV2GetInstanceFieldsGameCenterActivitie.Leaderboards => "leaderboards",
                GameCenterAchievementsV2GetInstanceFieldsGameCenterActivitie.LeaderboardsV2 => "leaderboardsV2",
                GameCenterAchievementsV2GetInstanceFieldsGameCenterActivitie.MaximumPlayersCount => "maximumPlayersCount",
                GameCenterAchievementsV2GetInstanceFieldsGameCenterActivitie.MinimumPlayersCount => "minimumPlayersCount",
                GameCenterAchievementsV2GetInstanceFieldsGameCenterActivitie.PlayStyle => "playStyle",
                GameCenterAchievementsV2GetInstanceFieldsGameCenterActivitie.Properties => "properties",
                GameCenterAchievementsV2GetInstanceFieldsGameCenterActivitie.ReferenceName => "referenceName",
                GameCenterAchievementsV2GetInstanceFieldsGameCenterActivitie.SupportsPartyCode => "supportsPartyCode",
                GameCenterAchievementsV2GetInstanceFieldsGameCenterActivitie.VendorIdentifier => "vendorIdentifier",
                GameCenterAchievementsV2GetInstanceFieldsGameCenterActivitie.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementsV2GetInstanceFieldsGameCenterActivitie? ToEnum(string value)
        {
            return value switch
            {
                "achievements" => GameCenterAchievementsV2GetInstanceFieldsGameCenterActivitie.Achievements,
                "achievementsV2" => GameCenterAchievementsV2GetInstanceFieldsGameCenterActivitie.AchievementsV2,
                "archived" => GameCenterAchievementsV2GetInstanceFieldsGameCenterActivitie.Archived,
                "gameCenterDetail" => GameCenterAchievementsV2GetInstanceFieldsGameCenterActivitie.GameCenterDetail,
                "gameCenterGroup" => GameCenterAchievementsV2GetInstanceFieldsGameCenterActivitie.GameCenterGroup,
                "leaderboards" => GameCenterAchievementsV2GetInstanceFieldsGameCenterActivitie.Leaderboards,
                "leaderboardsV2" => GameCenterAchievementsV2GetInstanceFieldsGameCenterActivitie.LeaderboardsV2,
                "maximumPlayersCount" => GameCenterAchievementsV2GetInstanceFieldsGameCenterActivitie.MaximumPlayersCount,
                "minimumPlayersCount" => GameCenterAchievementsV2GetInstanceFieldsGameCenterActivitie.MinimumPlayersCount,
                "playStyle" => GameCenterAchievementsV2GetInstanceFieldsGameCenterActivitie.PlayStyle,
                "properties" => GameCenterAchievementsV2GetInstanceFieldsGameCenterActivitie.Properties,
                "referenceName" => GameCenterAchievementsV2GetInstanceFieldsGameCenterActivitie.ReferenceName,
                "supportsPartyCode" => GameCenterAchievementsV2GetInstanceFieldsGameCenterActivitie.SupportsPartyCode,
                "vendorIdentifier" => GameCenterAchievementsV2GetInstanceFieldsGameCenterActivitie.VendorIdentifier,
                "versions" => GameCenterAchievementsV2GetInstanceFieldsGameCenterActivitie.Versions,
                _ => null,
            };
        }
    }
}