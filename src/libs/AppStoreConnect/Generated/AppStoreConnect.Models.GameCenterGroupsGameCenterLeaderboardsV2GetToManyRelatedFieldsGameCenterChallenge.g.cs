
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge
    {
        /// <summary>
        ///
        /// </summary>
        Archived,
        /// <summary>
        ///
        /// </summary>
        ChallengeType,
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
        Leaderboard,
        /// <summary>
        ///
        /// </summary>
        LeaderboardV2,
        /// <summary>
        ///
        /// </summary>
        ReferenceName,
        /// <summary>
        ///
        /// </summary>
        Repeatable,
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
    public static class GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallengeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge value)
        {
            return value switch
            {
                GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge.Archived => "archived",
                GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge.ChallengeType => "challengeType",
                GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge.GameCenterDetail => "gameCenterDetail",
                GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge.GameCenterGroup => "gameCenterGroup",
                GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge.Leaderboard => "leaderboard",
                GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge.LeaderboardV2 => "leaderboardV2",
                GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge.ReferenceName => "referenceName",
                GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge.Repeatable => "repeatable",
                GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge.VendorIdentifier => "vendorIdentifier",
                GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge? ToEnum(string value)
        {
            return value switch
            {
                "archived" => GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge.Archived,
                "challengeType" => GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge.ChallengeType,
                "gameCenterDetail" => GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge.GameCenterDetail,
                "gameCenterGroup" => GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge.GameCenterGroup,
                "leaderboard" => GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge.Leaderboard,
                "leaderboardV2" => GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge.LeaderboardV2,
                "referenceName" => GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge.ReferenceName,
                "repeatable" => GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge.Repeatable,
                "vendorIdentifier" => GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge.VendorIdentifier,
                "versions" => GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge.Versions,
                _ => null,
            };
        }
    }
}