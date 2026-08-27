
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie
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
    public static class GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie value)
        {
            return value switch
            {
                GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie.Achievements => "achievements",
                GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie.AchievementsV2 => "achievementsV2",
                GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie.Archived => "archived",
                GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie.GameCenterDetail => "gameCenterDetail",
                GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie.GameCenterGroup => "gameCenterGroup",
                GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie.Leaderboards => "leaderboards",
                GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie.LeaderboardsV2 => "leaderboardsV2",
                GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie.MaximumPlayersCount => "maximumPlayersCount",
                GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie.MinimumPlayersCount => "minimumPlayersCount",
                GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie.PlayStyle => "playStyle",
                GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie.Properties => "properties",
                GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie.ReferenceName => "referenceName",
                GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie.SupportsPartyCode => "supportsPartyCode",
                GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie.VendorIdentifier => "vendorIdentifier",
                GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie? ToEnum(string value)
        {
            return value switch
            {
                "achievements" => GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie.Achievements,
                "achievementsV2" => GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie.AchievementsV2,
                "archived" => GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie.Archived,
                "gameCenterDetail" => GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie.GameCenterDetail,
                "gameCenterGroup" => GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie.GameCenterGroup,
                "leaderboards" => GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie.Leaderboards,
                "leaderboardsV2" => GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie.LeaderboardsV2,
                "maximumPlayersCount" => GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie.MaximumPlayersCount,
                "minimumPlayersCount" => GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie.MinimumPlayersCount,
                "playStyle" => GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie.PlayStyle,
                "properties" => GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie.Properties,
                "referenceName" => GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie.ReferenceName,
                "supportsPartyCode" => GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie.SupportsPartyCode,
                "vendorIdentifier" => GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie.VendorIdentifier,
                "versions" => GameCenterGroupsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie.Versions,
                _ => null,
            };
        }
    }
}