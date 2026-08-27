
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge
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
    public static class GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallengeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge value)
        {
            return value switch
            {
                GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge.Archived => "archived",
                GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge.ChallengeType => "challengeType",
                GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge.GameCenterDetail => "gameCenterDetail",
                GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge.GameCenterGroup => "gameCenterGroup",
                GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge.Leaderboard => "leaderboard",
                GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge.LeaderboardV2 => "leaderboardV2",
                GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge.ReferenceName => "referenceName",
                GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge.Repeatable => "repeatable",
                GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge.VendorIdentifier => "vendorIdentifier",
                GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge? ToEnum(string value)
        {
            return value switch
            {
                "archived" => GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge.Archived,
                "challengeType" => GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge.ChallengeType,
                "gameCenterDetail" => GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge.GameCenterDetail,
                "gameCenterGroup" => GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge.GameCenterGroup,
                "leaderboard" => GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge.Leaderboard,
                "leaderboardV2" => GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge.LeaderboardV2,
                "referenceName" => GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge.ReferenceName,
                "repeatable" => GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge.Repeatable,
                "vendorIdentifier" => GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge.VendorIdentifier,
                "versions" => GameCenterLeaderboardSetsV2GameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge.Versions,
                _ => null,
            };
        }
    }
}