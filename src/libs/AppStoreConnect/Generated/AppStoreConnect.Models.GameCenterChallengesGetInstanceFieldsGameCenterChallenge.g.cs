
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterChallengesGetInstanceFieldsGameCenterChallenge
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
    public static class GameCenterChallengesGetInstanceFieldsGameCenterChallengeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterChallengesGetInstanceFieldsGameCenterChallenge value)
        {
            return value switch
            {
                GameCenterChallengesGetInstanceFieldsGameCenterChallenge.Archived => "archived",
                GameCenterChallengesGetInstanceFieldsGameCenterChallenge.ChallengeType => "challengeType",
                GameCenterChallengesGetInstanceFieldsGameCenterChallenge.GameCenterDetail => "gameCenterDetail",
                GameCenterChallengesGetInstanceFieldsGameCenterChallenge.GameCenterGroup => "gameCenterGroup",
                GameCenterChallengesGetInstanceFieldsGameCenterChallenge.Leaderboard => "leaderboard",
                GameCenterChallengesGetInstanceFieldsGameCenterChallenge.LeaderboardV2 => "leaderboardV2",
                GameCenterChallengesGetInstanceFieldsGameCenterChallenge.ReferenceName => "referenceName",
                GameCenterChallengesGetInstanceFieldsGameCenterChallenge.Repeatable => "repeatable",
                GameCenterChallengesGetInstanceFieldsGameCenterChallenge.VendorIdentifier => "vendorIdentifier",
                GameCenterChallengesGetInstanceFieldsGameCenterChallenge.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterChallengesGetInstanceFieldsGameCenterChallenge? ToEnum(string value)
        {
            return value switch
            {
                "archived" => GameCenterChallengesGetInstanceFieldsGameCenterChallenge.Archived,
                "challengeType" => GameCenterChallengesGetInstanceFieldsGameCenterChallenge.ChallengeType,
                "gameCenterDetail" => GameCenterChallengesGetInstanceFieldsGameCenterChallenge.GameCenterDetail,
                "gameCenterGroup" => GameCenterChallengesGetInstanceFieldsGameCenterChallenge.GameCenterGroup,
                "leaderboard" => GameCenterChallengesGetInstanceFieldsGameCenterChallenge.Leaderboard,
                "leaderboardV2" => GameCenterChallengesGetInstanceFieldsGameCenterChallenge.LeaderboardV2,
                "referenceName" => GameCenterChallengesGetInstanceFieldsGameCenterChallenge.ReferenceName,
                "repeatable" => GameCenterChallengesGetInstanceFieldsGameCenterChallenge.Repeatable,
                "vendorIdentifier" => GameCenterChallengesGetInstanceFieldsGameCenterChallenge.VendorIdentifier,
                "versions" => GameCenterChallengesGetInstanceFieldsGameCenterChallenge.Versions,
                _ => null,
            };
        }
    }
}