
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterGroupsGetInstanceFieldsGameCenterChallenge
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
    public static class GameCenterGroupsGetInstanceFieldsGameCenterChallengeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupsGetInstanceFieldsGameCenterChallenge value)
        {
            return value switch
            {
                GameCenterGroupsGetInstanceFieldsGameCenterChallenge.Archived => "archived",
                GameCenterGroupsGetInstanceFieldsGameCenterChallenge.ChallengeType => "challengeType",
                GameCenterGroupsGetInstanceFieldsGameCenterChallenge.GameCenterDetail => "gameCenterDetail",
                GameCenterGroupsGetInstanceFieldsGameCenterChallenge.GameCenterGroup => "gameCenterGroup",
                GameCenterGroupsGetInstanceFieldsGameCenterChallenge.Leaderboard => "leaderboard",
                GameCenterGroupsGetInstanceFieldsGameCenterChallenge.LeaderboardV2 => "leaderboardV2",
                GameCenterGroupsGetInstanceFieldsGameCenterChallenge.ReferenceName => "referenceName",
                GameCenterGroupsGetInstanceFieldsGameCenterChallenge.Repeatable => "repeatable",
                GameCenterGroupsGetInstanceFieldsGameCenterChallenge.VendorIdentifier => "vendorIdentifier",
                GameCenterGroupsGetInstanceFieldsGameCenterChallenge.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupsGetInstanceFieldsGameCenterChallenge? ToEnum(string value)
        {
            return value switch
            {
                "archived" => GameCenterGroupsGetInstanceFieldsGameCenterChallenge.Archived,
                "challengeType" => GameCenterGroupsGetInstanceFieldsGameCenterChallenge.ChallengeType,
                "gameCenterDetail" => GameCenterGroupsGetInstanceFieldsGameCenterChallenge.GameCenterDetail,
                "gameCenterGroup" => GameCenterGroupsGetInstanceFieldsGameCenterChallenge.GameCenterGroup,
                "leaderboard" => GameCenterGroupsGetInstanceFieldsGameCenterChallenge.Leaderboard,
                "leaderboardV2" => GameCenterGroupsGetInstanceFieldsGameCenterChallenge.LeaderboardV2,
                "referenceName" => GameCenterGroupsGetInstanceFieldsGameCenterChallenge.ReferenceName,
                "repeatable" => GameCenterGroupsGetInstanceFieldsGameCenterChallenge.Repeatable,
                "vendorIdentifier" => GameCenterGroupsGetInstanceFieldsGameCenterChallenge.VendorIdentifier,
                "versions" => GameCenterGroupsGetInstanceFieldsGameCenterChallenge.Versions,
                _ => null,
            };
        }
    }
}