
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallenge
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
    public static class GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallengeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallenge value)
        {
            return value switch
            {
                GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallenge.Archived => "archived",
                GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallenge.ChallengeType => "challengeType",
                GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallenge.GameCenterDetail => "gameCenterDetail",
                GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallenge.GameCenterGroup => "gameCenterGroup",
                GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallenge.Leaderboard => "leaderboard",
                GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallenge.LeaderboardV2 => "leaderboardV2",
                GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallenge.ReferenceName => "referenceName",
                GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallenge.Repeatable => "repeatable",
                GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallenge.VendorIdentifier => "vendorIdentifier",
                GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallenge.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallenge? ToEnum(string value)
        {
            return value switch
            {
                "archived" => GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallenge.Archived,
                "challengeType" => GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallenge.ChallengeType,
                "gameCenterDetail" => GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallenge.GameCenterDetail,
                "gameCenterGroup" => GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallenge.GameCenterGroup,
                "leaderboard" => GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallenge.Leaderboard,
                "leaderboardV2" => GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallenge.LeaderboardV2,
                "referenceName" => GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallenge.ReferenceName,
                "repeatable" => GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallenge.Repeatable,
                "vendorIdentifier" => GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallenge.VendorIdentifier,
                "versions" => GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallenge.Versions,
                _ => null,
            };
        }
    }
}