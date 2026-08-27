
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivitie
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
    public static class GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivitie value)
        {
            return value switch
            {
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivitie.Achievements => "achievements",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivitie.AchievementsV2 => "achievementsV2",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivitie.Archived => "archived",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivitie.GameCenterDetail => "gameCenterDetail",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivitie.GameCenterGroup => "gameCenterGroup",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivitie.Leaderboards => "leaderboards",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivitie.LeaderboardsV2 => "leaderboardsV2",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivitie.MaximumPlayersCount => "maximumPlayersCount",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivitie.MinimumPlayersCount => "minimumPlayersCount",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivitie.PlayStyle => "playStyle",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivitie.Properties => "properties",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivitie.ReferenceName => "referenceName",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivitie.SupportsPartyCode => "supportsPartyCode",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivitie.VendorIdentifier => "vendorIdentifier",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivitie.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivitie? ToEnum(string value)
        {
            return value switch
            {
                "achievements" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivitie.Achievements,
                "achievementsV2" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivitie.AchievementsV2,
                "archived" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivitie.Archived,
                "gameCenterDetail" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivitie.GameCenterDetail,
                "gameCenterGroup" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivitie.GameCenterGroup,
                "leaderboards" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivitie.Leaderboards,
                "leaderboardsV2" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivitie.LeaderboardsV2,
                "maximumPlayersCount" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivitie.MaximumPlayersCount,
                "minimumPlayersCount" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivitie.MinimumPlayersCount,
                "playStyle" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivitie.PlayStyle,
                "properties" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivitie.Properties,
                "referenceName" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivitie.ReferenceName,
                "supportsPartyCode" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivitie.SupportsPartyCode,
                "vendorIdentifier" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivitie.VendorIdentifier,
                "versions" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivitie.Versions,
                _ => null,
            };
        }
    }
}