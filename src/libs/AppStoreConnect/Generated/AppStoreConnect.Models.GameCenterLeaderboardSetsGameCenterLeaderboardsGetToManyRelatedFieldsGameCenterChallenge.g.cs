
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge
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
    public static class GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallengeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge value)
        {
            return value switch
            {
                GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge.Archived => "archived",
                GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge.ChallengeType => "challengeType",
                GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge.GameCenterDetail => "gameCenterDetail",
                GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge.GameCenterGroup => "gameCenterGroup",
                GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge.Leaderboard => "leaderboard",
                GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge.LeaderboardV2 => "leaderboardV2",
                GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge.ReferenceName => "referenceName",
                GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge.Repeatable => "repeatable",
                GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge.VendorIdentifier => "vendorIdentifier",
                GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge? ToEnum(string value)
        {
            return value switch
            {
                "archived" => GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge.Archived,
                "challengeType" => GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge.ChallengeType,
                "gameCenterDetail" => GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge.GameCenterDetail,
                "gameCenterGroup" => GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge.GameCenterGroup,
                "leaderboard" => GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge.Leaderboard,
                "leaderboardV2" => GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge.LeaderboardV2,
                "referenceName" => GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge.ReferenceName,
                "repeatable" => GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge.Repeatable,
                "vendorIdentifier" => GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge.VendorIdentifier,
                "versions" => GameCenterLeaderboardSetsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge.Versions,
                _ => null,
            };
        }
    }
}