
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardsGetInstanceFieldsGameCenterChallenge
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
    public static class GameCenterLeaderboardsGetInstanceFieldsGameCenterChallengeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardsGetInstanceFieldsGameCenterChallenge value)
        {
            return value switch
            {
                GameCenterLeaderboardsGetInstanceFieldsGameCenterChallenge.Archived => "archived",
                GameCenterLeaderboardsGetInstanceFieldsGameCenterChallenge.ChallengeType => "challengeType",
                GameCenterLeaderboardsGetInstanceFieldsGameCenterChallenge.GameCenterDetail => "gameCenterDetail",
                GameCenterLeaderboardsGetInstanceFieldsGameCenterChallenge.GameCenterGroup => "gameCenterGroup",
                GameCenterLeaderboardsGetInstanceFieldsGameCenterChallenge.Leaderboard => "leaderboard",
                GameCenterLeaderboardsGetInstanceFieldsGameCenterChallenge.LeaderboardV2 => "leaderboardV2",
                GameCenterLeaderboardsGetInstanceFieldsGameCenterChallenge.ReferenceName => "referenceName",
                GameCenterLeaderboardsGetInstanceFieldsGameCenterChallenge.Repeatable => "repeatable",
                GameCenterLeaderboardsGetInstanceFieldsGameCenterChallenge.VendorIdentifier => "vendorIdentifier",
                GameCenterLeaderboardsGetInstanceFieldsGameCenterChallenge.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardsGetInstanceFieldsGameCenterChallenge? ToEnum(string value)
        {
            return value switch
            {
                "archived" => GameCenterLeaderboardsGetInstanceFieldsGameCenterChallenge.Archived,
                "challengeType" => GameCenterLeaderboardsGetInstanceFieldsGameCenterChallenge.ChallengeType,
                "gameCenterDetail" => GameCenterLeaderboardsGetInstanceFieldsGameCenterChallenge.GameCenterDetail,
                "gameCenterGroup" => GameCenterLeaderboardsGetInstanceFieldsGameCenterChallenge.GameCenterGroup,
                "leaderboard" => GameCenterLeaderboardsGetInstanceFieldsGameCenterChallenge.Leaderboard,
                "leaderboardV2" => GameCenterLeaderboardsGetInstanceFieldsGameCenterChallenge.LeaderboardV2,
                "referenceName" => GameCenterLeaderboardsGetInstanceFieldsGameCenterChallenge.ReferenceName,
                "repeatable" => GameCenterLeaderboardsGetInstanceFieldsGameCenterChallenge.Repeatable,
                "vendorIdentifier" => GameCenterLeaderboardsGetInstanceFieldsGameCenterChallenge.VendorIdentifier,
                "versions" => GameCenterLeaderboardsGetInstanceFieldsGameCenterChallenge.Versions,
                _ => null,
            };
        }
    }
}