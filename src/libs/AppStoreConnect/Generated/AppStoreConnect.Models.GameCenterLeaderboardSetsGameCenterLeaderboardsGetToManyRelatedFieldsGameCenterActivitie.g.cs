
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie
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
    public static class GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie value)
        {
            return value switch
            {
                GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.Achievements => "achievements",
                GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.AchievementsV2 => "achievementsV2",
                GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.Archived => "archived",
                GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.GameCenterDetail => "gameCenterDetail",
                GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.GameCenterGroup => "gameCenterGroup",
                GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.Leaderboards => "leaderboards",
                GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.LeaderboardsV2 => "leaderboardsV2",
                GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.MaximumPlayersCount => "maximumPlayersCount",
                GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.MinimumPlayersCount => "minimumPlayersCount",
                GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.PlayStyle => "playStyle",
                GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.Properties => "properties",
                GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.ReferenceName => "referenceName",
                GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.SupportsPartyCode => "supportsPartyCode",
                GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.VendorIdentifier => "vendorIdentifier",
                GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie? ToEnum(string value)
        {
            return value switch
            {
                "achievements" => GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.Achievements,
                "achievementsV2" => GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.AchievementsV2,
                "archived" => GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.Archived,
                "gameCenterDetail" => GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.GameCenterDetail,
                "gameCenterGroup" => GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.GameCenterGroup,
                "leaderboards" => GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.Leaderboards,
                "leaderboardsV2" => GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.LeaderboardsV2,
                "maximumPlayersCount" => GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.MaximumPlayersCount,
                "minimumPlayersCount" => GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.MinimumPlayersCount,
                "playStyle" => GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.PlayStyle,
                "properties" => GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.Properties,
                "referenceName" => GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.ReferenceName,
                "supportsPartyCode" => GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.SupportsPartyCode,
                "vendorIdentifier" => GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.VendorIdentifier,
                "versions" => GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterActivitie.Versions,
                _ => null,
            };
        }
    }
}