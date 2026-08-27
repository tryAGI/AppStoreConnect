
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge
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
    public static class GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallengeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge value)
        {
            return value switch
            {
                GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge.Archived => "archived",
                GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge.ChallengeType => "challengeType",
                GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge.GameCenterDetail => "gameCenterDetail",
                GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge.GameCenterGroup => "gameCenterGroup",
                GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge.Leaderboard => "leaderboard",
                GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge.LeaderboardV2 => "leaderboardV2",
                GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge.ReferenceName => "referenceName",
                GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge.Repeatable => "repeatable",
                GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge.VendorIdentifier => "vendorIdentifier",
                GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge? ToEnum(string value)
        {
            return value switch
            {
                "archived" => GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge.Archived,
                "challengeType" => GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge.ChallengeType,
                "gameCenterDetail" => GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge.GameCenterDetail,
                "gameCenterGroup" => GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge.GameCenterGroup,
                "leaderboard" => GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge.Leaderboard,
                "leaderboardV2" => GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge.LeaderboardV2,
                "referenceName" => GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge.ReferenceName,
                "repeatable" => GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge.Repeatable,
                "vendorIdentifier" => GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge.VendorIdentifier,
                "versions" => GameCenterDetailsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterChallenge.Versions,
                _ => null,
            };
        }
    }
}