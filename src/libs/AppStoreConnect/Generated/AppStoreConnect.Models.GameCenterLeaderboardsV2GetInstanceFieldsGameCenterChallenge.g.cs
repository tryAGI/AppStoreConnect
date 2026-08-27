
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardsV2GetInstanceFieldsGameCenterChallenge
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
    public static class GameCenterLeaderboardsV2GetInstanceFieldsGameCenterChallengeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardsV2GetInstanceFieldsGameCenterChallenge value)
        {
            return value switch
            {
                GameCenterLeaderboardsV2GetInstanceFieldsGameCenterChallenge.Archived => "archived",
                GameCenterLeaderboardsV2GetInstanceFieldsGameCenterChallenge.ChallengeType => "challengeType",
                GameCenterLeaderboardsV2GetInstanceFieldsGameCenterChallenge.GameCenterDetail => "gameCenterDetail",
                GameCenterLeaderboardsV2GetInstanceFieldsGameCenterChallenge.GameCenterGroup => "gameCenterGroup",
                GameCenterLeaderboardsV2GetInstanceFieldsGameCenterChallenge.Leaderboard => "leaderboard",
                GameCenterLeaderboardsV2GetInstanceFieldsGameCenterChallenge.LeaderboardV2 => "leaderboardV2",
                GameCenterLeaderboardsV2GetInstanceFieldsGameCenterChallenge.ReferenceName => "referenceName",
                GameCenterLeaderboardsV2GetInstanceFieldsGameCenterChallenge.Repeatable => "repeatable",
                GameCenterLeaderboardsV2GetInstanceFieldsGameCenterChallenge.VendorIdentifier => "vendorIdentifier",
                GameCenterLeaderboardsV2GetInstanceFieldsGameCenterChallenge.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardsV2GetInstanceFieldsGameCenterChallenge? ToEnum(string value)
        {
            return value switch
            {
                "archived" => GameCenterLeaderboardsV2GetInstanceFieldsGameCenterChallenge.Archived,
                "challengeType" => GameCenterLeaderboardsV2GetInstanceFieldsGameCenterChallenge.ChallengeType,
                "gameCenterDetail" => GameCenterLeaderboardsV2GetInstanceFieldsGameCenterChallenge.GameCenterDetail,
                "gameCenterGroup" => GameCenterLeaderboardsV2GetInstanceFieldsGameCenterChallenge.GameCenterGroup,
                "leaderboard" => GameCenterLeaderboardsV2GetInstanceFieldsGameCenterChallenge.Leaderboard,
                "leaderboardV2" => GameCenterLeaderboardsV2GetInstanceFieldsGameCenterChallenge.LeaderboardV2,
                "referenceName" => GameCenterLeaderboardsV2GetInstanceFieldsGameCenterChallenge.ReferenceName,
                "repeatable" => GameCenterLeaderboardsV2GetInstanceFieldsGameCenterChallenge.Repeatable,
                "vendorIdentifier" => GameCenterLeaderboardsV2GetInstanceFieldsGameCenterChallenge.VendorIdentifier,
                "versions" => GameCenterLeaderboardsV2GetInstanceFieldsGameCenterChallenge.Versions,
                _ => null,
            };
        }
    }
}