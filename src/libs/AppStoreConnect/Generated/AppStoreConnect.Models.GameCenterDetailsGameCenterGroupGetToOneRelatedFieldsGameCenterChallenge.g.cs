
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterChallenge
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
    public static class GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterChallengeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterChallenge value)
        {
            return value switch
            {
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterChallenge.Archived => "archived",
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterChallenge.ChallengeType => "challengeType",
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterChallenge.GameCenterDetail => "gameCenterDetail",
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterChallenge.GameCenterGroup => "gameCenterGroup",
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterChallenge.Leaderboard => "leaderboard",
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterChallenge.LeaderboardV2 => "leaderboardV2",
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterChallenge.ReferenceName => "referenceName",
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterChallenge.Repeatable => "repeatable",
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterChallenge.VendorIdentifier => "vendorIdentifier",
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterChallenge.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterChallenge? ToEnum(string value)
        {
            return value switch
            {
                "archived" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterChallenge.Archived,
                "challengeType" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterChallenge.ChallengeType,
                "gameCenterDetail" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterChallenge.GameCenterDetail,
                "gameCenterGroup" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterChallenge.GameCenterGroup,
                "leaderboard" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterChallenge.Leaderboard,
                "leaderboardV2" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterChallenge.LeaderboardV2,
                "referenceName" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterChallenge.ReferenceName,
                "repeatable" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterChallenge.Repeatable,
                "vendorIdentifier" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterChallenge.VendorIdentifier,
                "versions" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterChallenge.Versions,
                _ => null,
            };
        }
    }
}