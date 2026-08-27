
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie
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
    public static class GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie value)
        {
            return value switch
            {
                GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie.Achievements => "achievements",
                GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie.AchievementsV2 => "achievementsV2",
                GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie.Archived => "archived",
                GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie.GameCenterDetail => "gameCenterDetail",
                GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie.GameCenterGroup => "gameCenterGroup",
                GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie.Leaderboards => "leaderboards",
                GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie.LeaderboardsV2 => "leaderboardsV2",
                GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie.MaximumPlayersCount => "maximumPlayersCount",
                GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie.MinimumPlayersCount => "minimumPlayersCount",
                GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie.PlayStyle => "playStyle",
                GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie.Properties => "properties",
                GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie.ReferenceName => "referenceName",
                GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie.SupportsPartyCode => "supportsPartyCode",
                GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie.VendorIdentifier => "vendorIdentifier",
                GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie? ToEnum(string value)
        {
            return value switch
            {
                "achievements" => GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie.Achievements,
                "achievementsV2" => GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie.AchievementsV2,
                "archived" => GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie.Archived,
                "gameCenterDetail" => GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie.GameCenterDetail,
                "gameCenterGroup" => GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie.GameCenterGroup,
                "leaderboards" => GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie.Leaderboards,
                "leaderboardsV2" => GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie.LeaderboardsV2,
                "maximumPlayersCount" => GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie.MaximumPlayersCount,
                "minimumPlayersCount" => GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie.MinimumPlayersCount,
                "playStyle" => GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie.PlayStyle,
                "properties" => GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie.Properties,
                "referenceName" => GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie.ReferenceName,
                "supportsPartyCode" => GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie.SupportsPartyCode,
                "vendorIdentifier" => GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie.VendorIdentifier,
                "versions" => GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie.Versions,
                _ => null,
            };
        }
    }
}