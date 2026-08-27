
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitie
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
    public static class GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitie value)
        {
            return value switch
            {
                GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitie.Achievements => "achievements",
                GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitie.AchievementsV2 => "achievementsV2",
                GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitie.Archived => "archived",
                GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitie.GameCenterDetail => "gameCenterDetail",
                GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitie.GameCenterGroup => "gameCenterGroup",
                GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitie.Leaderboards => "leaderboards",
                GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitie.LeaderboardsV2 => "leaderboardsV2",
                GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitie.MaximumPlayersCount => "maximumPlayersCount",
                GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitie.MinimumPlayersCount => "minimumPlayersCount",
                GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitie.PlayStyle => "playStyle",
                GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitie.Properties => "properties",
                GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitie.ReferenceName => "referenceName",
                GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitie.SupportsPartyCode => "supportsPartyCode",
                GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitie.VendorIdentifier => "vendorIdentifier",
                GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitie.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitie? ToEnum(string value)
        {
            return value switch
            {
                "achievements" => GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitie.Achievements,
                "achievementsV2" => GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitie.AchievementsV2,
                "archived" => GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitie.Archived,
                "gameCenterDetail" => GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitie.GameCenterDetail,
                "gameCenterGroup" => GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitie.GameCenterGroup,
                "leaderboards" => GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitie.Leaderboards,
                "leaderboardsV2" => GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitie.LeaderboardsV2,
                "maximumPlayersCount" => GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitie.MaximumPlayersCount,
                "minimumPlayersCount" => GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitie.MinimumPlayersCount,
                "playStyle" => GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitie.PlayStyle,
                "properties" => GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitie.Properties,
                "referenceName" => GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitie.ReferenceName,
                "supportsPartyCode" => GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitie.SupportsPartyCode,
                "vendorIdentifier" => GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitie.VendorIdentifier,
                "versions" => GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitie.Versions,
                _ => null,
            };
        }
    }
}