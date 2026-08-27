
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie
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
    public static class GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie value)
        {
            return value switch
            {
                GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.Achievements => "achievements",
                GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.AchievementsV2 => "achievementsV2",
                GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.Archived => "archived",
                GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.GameCenterDetail => "gameCenterDetail",
                GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.GameCenterGroup => "gameCenterGroup",
                GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.Leaderboards => "leaderboards",
                GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.LeaderboardsV2 => "leaderboardsV2",
                GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.MaximumPlayersCount => "maximumPlayersCount",
                GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.MinimumPlayersCount => "minimumPlayersCount",
                GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.PlayStyle => "playStyle",
                GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.Properties => "properties",
                GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.ReferenceName => "referenceName",
                GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.SupportsPartyCode => "supportsPartyCode",
                GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.VendorIdentifier => "vendorIdentifier",
                GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie? ToEnum(string value)
        {
            return value switch
            {
                "achievements" => GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.Achievements,
                "achievementsV2" => GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.AchievementsV2,
                "archived" => GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.Archived,
                "gameCenterDetail" => GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.GameCenterDetail,
                "gameCenterGroup" => GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.GameCenterGroup,
                "leaderboards" => GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.Leaderboards,
                "leaderboardsV2" => GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.LeaderboardsV2,
                "maximumPlayersCount" => GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.MaximumPlayersCount,
                "minimumPlayersCount" => GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.MinimumPlayersCount,
                "playStyle" => GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.PlayStyle,
                "properties" => GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.Properties,
                "referenceName" => GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.ReferenceName,
                "supportsPartyCode" => GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.SupportsPartyCode,
                "vendorIdentifier" => GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.VendorIdentifier,
                "versions" => GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.Versions,
                _ => null,
            };
        }
    }
}