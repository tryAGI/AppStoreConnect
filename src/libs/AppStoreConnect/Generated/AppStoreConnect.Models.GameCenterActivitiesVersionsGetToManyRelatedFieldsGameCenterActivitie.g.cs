
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivitie
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
    public static class GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivitie value)
        {
            return value switch
            {
                GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivitie.Achievements => "achievements",
                GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivitie.AchievementsV2 => "achievementsV2",
                GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivitie.Archived => "archived",
                GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivitie.GameCenterDetail => "gameCenterDetail",
                GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivitie.GameCenterGroup => "gameCenterGroup",
                GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivitie.Leaderboards => "leaderboards",
                GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivitie.LeaderboardsV2 => "leaderboardsV2",
                GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivitie.MaximumPlayersCount => "maximumPlayersCount",
                GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivitie.MinimumPlayersCount => "minimumPlayersCount",
                GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivitie.PlayStyle => "playStyle",
                GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivitie.Properties => "properties",
                GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivitie.ReferenceName => "referenceName",
                GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivitie.SupportsPartyCode => "supportsPartyCode",
                GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivitie.VendorIdentifier => "vendorIdentifier",
                GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivitie.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivitie? ToEnum(string value)
        {
            return value switch
            {
                "achievements" => GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivitie.Achievements,
                "achievementsV2" => GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivitie.AchievementsV2,
                "archived" => GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivitie.Archived,
                "gameCenterDetail" => GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivitie.GameCenterDetail,
                "gameCenterGroup" => GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivitie.GameCenterGroup,
                "leaderboards" => GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivitie.Leaderboards,
                "leaderboardsV2" => GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivitie.LeaderboardsV2,
                "maximumPlayersCount" => GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivitie.MaximumPlayersCount,
                "minimumPlayersCount" => GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivitie.MinimumPlayersCount,
                "playStyle" => GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivitie.PlayStyle,
                "properties" => GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivitie.Properties,
                "referenceName" => GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivitie.ReferenceName,
                "supportsPartyCode" => GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivitie.SupportsPartyCode,
                "vendorIdentifier" => GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivitie.VendorIdentifier,
                "versions" => GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivitie.Versions,
                _ => null,
            };
        }
    }
}