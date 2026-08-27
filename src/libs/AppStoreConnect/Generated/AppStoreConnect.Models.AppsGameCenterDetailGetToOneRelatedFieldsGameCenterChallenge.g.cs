
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsGameCenterDetailGetToOneRelatedFieldsGameCenterChallenge
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
    public static class AppsGameCenterDetailGetToOneRelatedFieldsGameCenterChallengeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGameCenterDetailGetToOneRelatedFieldsGameCenterChallenge value)
        {
            return value switch
            {
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterChallenge.Archived => "archived",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterChallenge.ChallengeType => "challengeType",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterChallenge.GameCenterDetail => "gameCenterDetail",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterChallenge.GameCenterGroup => "gameCenterGroup",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterChallenge.Leaderboard => "leaderboard",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterChallenge.LeaderboardV2 => "leaderboardV2",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterChallenge.ReferenceName => "referenceName",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterChallenge.Repeatable => "repeatable",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterChallenge.VendorIdentifier => "vendorIdentifier",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterChallenge.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGameCenterDetailGetToOneRelatedFieldsGameCenterChallenge? ToEnum(string value)
        {
            return value switch
            {
                "archived" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterChallenge.Archived,
                "challengeType" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterChallenge.ChallengeType,
                "gameCenterDetail" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterChallenge.GameCenterDetail,
                "gameCenterGroup" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterChallenge.GameCenterGroup,
                "leaderboard" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterChallenge.Leaderboard,
                "leaderboardV2" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterChallenge.LeaderboardV2,
                "referenceName" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterChallenge.ReferenceName,
                "repeatable" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterChallenge.Repeatable,
                "vendorIdentifier" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterChallenge.VendorIdentifier,
                "versions" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterChallenge.Versions,
                _ => null,
            };
        }
    }
}