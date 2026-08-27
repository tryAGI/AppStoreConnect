
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallenge
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
    public static class GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallenge value)
        {
            return value switch
            {
                GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallenge.Archived => "archived",
                GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallenge.ChallengeType => "challengeType",
                GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallenge.GameCenterDetail => "gameCenterDetail",
                GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallenge.GameCenterGroup => "gameCenterGroup",
                GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallenge.Leaderboard => "leaderboard",
                GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallenge.LeaderboardV2 => "leaderboardV2",
                GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallenge.ReferenceName => "referenceName",
                GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallenge.Repeatable => "repeatable",
                GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallenge.VendorIdentifier => "vendorIdentifier",
                GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallenge.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallenge? ToEnum(string value)
        {
            return value switch
            {
                "archived" => GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallenge.Archived,
                "challengeType" => GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallenge.ChallengeType,
                "gameCenterDetail" => GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallenge.GameCenterDetail,
                "gameCenterGroup" => GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallenge.GameCenterGroup,
                "leaderboard" => GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallenge.Leaderboard,
                "leaderboardV2" => GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallenge.LeaderboardV2,
                "referenceName" => GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallenge.ReferenceName,
                "repeatable" => GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallenge.Repeatable,
                "vendorIdentifier" => GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallenge.VendorIdentifier,
                "versions" => GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallenge.Versions,
                _ => null,
            };
        }
    }
}