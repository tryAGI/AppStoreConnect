
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterDetailsGetInstanceFieldsGameCenterChallenge
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
    public static class GameCenterDetailsGetInstanceFieldsGameCenterChallengeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsGetInstanceFieldsGameCenterChallenge value)
        {
            return value switch
            {
                GameCenterDetailsGetInstanceFieldsGameCenterChallenge.Archived => "archived",
                GameCenterDetailsGetInstanceFieldsGameCenterChallenge.ChallengeType => "challengeType",
                GameCenterDetailsGetInstanceFieldsGameCenterChallenge.GameCenterDetail => "gameCenterDetail",
                GameCenterDetailsGetInstanceFieldsGameCenterChallenge.GameCenterGroup => "gameCenterGroup",
                GameCenterDetailsGetInstanceFieldsGameCenterChallenge.Leaderboard => "leaderboard",
                GameCenterDetailsGetInstanceFieldsGameCenterChallenge.LeaderboardV2 => "leaderboardV2",
                GameCenterDetailsGetInstanceFieldsGameCenterChallenge.ReferenceName => "referenceName",
                GameCenterDetailsGetInstanceFieldsGameCenterChallenge.Repeatable => "repeatable",
                GameCenterDetailsGetInstanceFieldsGameCenterChallenge.VendorIdentifier => "vendorIdentifier",
                GameCenterDetailsGetInstanceFieldsGameCenterChallenge.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsGetInstanceFieldsGameCenterChallenge? ToEnum(string value)
        {
            return value switch
            {
                "archived" => GameCenterDetailsGetInstanceFieldsGameCenterChallenge.Archived,
                "challengeType" => GameCenterDetailsGetInstanceFieldsGameCenterChallenge.ChallengeType,
                "gameCenterDetail" => GameCenterDetailsGetInstanceFieldsGameCenterChallenge.GameCenterDetail,
                "gameCenterGroup" => GameCenterDetailsGetInstanceFieldsGameCenterChallenge.GameCenterGroup,
                "leaderboard" => GameCenterDetailsGetInstanceFieldsGameCenterChallenge.Leaderboard,
                "leaderboardV2" => GameCenterDetailsGetInstanceFieldsGameCenterChallenge.LeaderboardV2,
                "referenceName" => GameCenterDetailsGetInstanceFieldsGameCenterChallenge.ReferenceName,
                "repeatable" => GameCenterDetailsGetInstanceFieldsGameCenterChallenge.Repeatable,
                "vendorIdentifier" => GameCenterDetailsGetInstanceFieldsGameCenterChallenge.VendorIdentifier,
                "versions" => GameCenterDetailsGetInstanceFieldsGameCenterChallenge.Versions,
                _ => null,
            };
        }
    }
}