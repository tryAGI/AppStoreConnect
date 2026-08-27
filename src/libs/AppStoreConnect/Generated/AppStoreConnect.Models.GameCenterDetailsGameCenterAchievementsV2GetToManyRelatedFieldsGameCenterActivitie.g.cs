
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie
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
    public static class GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie value)
        {
            return value switch
            {
                GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie.Achievements => "achievements",
                GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie.AchievementsV2 => "achievementsV2",
                GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie.Archived => "archived",
                GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie.GameCenterDetail => "gameCenterDetail",
                GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie.GameCenterGroup => "gameCenterGroup",
                GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie.Leaderboards => "leaderboards",
                GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie.LeaderboardsV2 => "leaderboardsV2",
                GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie.MaximumPlayersCount => "maximumPlayersCount",
                GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie.MinimumPlayersCount => "minimumPlayersCount",
                GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie.PlayStyle => "playStyle",
                GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie.Properties => "properties",
                GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie.ReferenceName => "referenceName",
                GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie.SupportsPartyCode => "supportsPartyCode",
                GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie.VendorIdentifier => "vendorIdentifier",
                GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie? ToEnum(string value)
        {
            return value switch
            {
                "achievements" => GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie.Achievements,
                "achievementsV2" => GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie.AchievementsV2,
                "archived" => GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie.Archived,
                "gameCenterDetail" => GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie.GameCenterDetail,
                "gameCenterGroup" => GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie.GameCenterGroup,
                "leaderboards" => GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie.Leaderboards,
                "leaderboardsV2" => GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie.LeaderboardsV2,
                "maximumPlayersCount" => GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie.MaximumPlayersCount,
                "minimumPlayersCount" => GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie.MinimumPlayersCount,
                "playStyle" => GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie.PlayStyle,
                "properties" => GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie.Properties,
                "referenceName" => GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie.ReferenceName,
                "supportsPartyCode" => GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie.SupportsPartyCode,
                "vendorIdentifier" => GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie.VendorIdentifier,
                "versions" => GameCenterDetailsGameCenterAchievementsV2GetToManyRelatedFieldsGameCenterActivitie.Versions,
                _ => null,
            };
        }
    }
}