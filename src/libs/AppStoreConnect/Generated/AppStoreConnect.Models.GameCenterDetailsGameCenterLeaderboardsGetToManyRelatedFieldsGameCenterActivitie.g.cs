
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie
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
    public static class GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie value)
        {
            return value switch
            {
                GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.Achievements => "achievements",
                GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.AchievementsV2 => "achievementsV2",
                GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.Archived => "archived",
                GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.GameCenterDetail => "gameCenterDetail",
                GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.GameCenterGroup => "gameCenterGroup",
                GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.Leaderboards => "leaderboards",
                GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.LeaderboardsV2 => "leaderboardsV2",
                GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.MaximumPlayersCount => "maximumPlayersCount",
                GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.MinimumPlayersCount => "minimumPlayersCount",
                GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.PlayStyle => "playStyle",
                GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.Properties => "properties",
                GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.ReferenceName => "referenceName",
                GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.SupportsPartyCode => "supportsPartyCode",
                GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.VendorIdentifier => "vendorIdentifier",
                GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie? ToEnum(string value)
        {
            return value switch
            {
                "achievements" => GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.Achievements,
                "achievementsV2" => GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.AchievementsV2,
                "archived" => GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.Archived,
                "gameCenterDetail" => GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.GameCenterDetail,
                "gameCenterGroup" => GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.GameCenterGroup,
                "leaderboards" => GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.Leaderboards,
                "leaderboardsV2" => GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.LeaderboardsV2,
                "maximumPlayersCount" => GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.MaximumPlayersCount,
                "minimumPlayersCount" => GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.MinimumPlayersCount,
                "playStyle" => GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.PlayStyle,
                "properties" => GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.Properties,
                "referenceName" => GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.ReferenceName,
                "supportsPartyCode" => GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.SupportsPartyCode,
                "vendorIdentifier" => GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.VendorIdentifier,
                "versions" => GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.Versions,
                _ => null,
            };
        }
    }
}