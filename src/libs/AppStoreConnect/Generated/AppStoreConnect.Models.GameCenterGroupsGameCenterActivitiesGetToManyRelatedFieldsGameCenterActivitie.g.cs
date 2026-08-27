
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie
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
    public static class GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie value)
        {
            return value switch
            {
                GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie.Achievements => "achievements",
                GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie.AchievementsV2 => "achievementsV2",
                GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie.Archived => "archived",
                GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie.GameCenterDetail => "gameCenterDetail",
                GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie.GameCenterGroup => "gameCenterGroup",
                GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie.Leaderboards => "leaderboards",
                GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie.LeaderboardsV2 => "leaderboardsV2",
                GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie.MaximumPlayersCount => "maximumPlayersCount",
                GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie.MinimumPlayersCount => "minimumPlayersCount",
                GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie.PlayStyle => "playStyle",
                GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie.Properties => "properties",
                GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie.ReferenceName => "referenceName",
                GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie.SupportsPartyCode => "supportsPartyCode",
                GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie.VendorIdentifier => "vendorIdentifier",
                GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie? ToEnum(string value)
        {
            return value switch
            {
                "achievements" => GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie.Achievements,
                "achievementsV2" => GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie.AchievementsV2,
                "archived" => GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie.Archived,
                "gameCenterDetail" => GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie.GameCenterDetail,
                "gameCenterGroup" => GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie.GameCenterGroup,
                "leaderboards" => GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie.Leaderboards,
                "leaderboardsV2" => GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie.LeaderboardsV2,
                "maximumPlayersCount" => GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie.MaximumPlayersCount,
                "minimumPlayersCount" => GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie.MinimumPlayersCount,
                "playStyle" => GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie.PlayStyle,
                "properties" => GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie.Properties,
                "referenceName" => GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie.ReferenceName,
                "supportsPartyCode" => GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie.SupportsPartyCode,
                "vendorIdentifier" => GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie.VendorIdentifier,
                "versions" => GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie.Versions,
                _ => null,
            };
        }
    }
}