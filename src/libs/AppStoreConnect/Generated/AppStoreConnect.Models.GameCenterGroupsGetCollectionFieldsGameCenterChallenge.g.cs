
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterGroupsGetCollectionFieldsGameCenterChallenge
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
    public static class GameCenterGroupsGetCollectionFieldsGameCenterChallengeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupsGetCollectionFieldsGameCenterChallenge value)
        {
            return value switch
            {
                GameCenterGroupsGetCollectionFieldsGameCenterChallenge.Archived => "archived",
                GameCenterGroupsGetCollectionFieldsGameCenterChallenge.ChallengeType => "challengeType",
                GameCenterGroupsGetCollectionFieldsGameCenterChallenge.GameCenterDetail => "gameCenterDetail",
                GameCenterGroupsGetCollectionFieldsGameCenterChallenge.GameCenterGroup => "gameCenterGroup",
                GameCenterGroupsGetCollectionFieldsGameCenterChallenge.Leaderboard => "leaderboard",
                GameCenterGroupsGetCollectionFieldsGameCenterChallenge.LeaderboardV2 => "leaderboardV2",
                GameCenterGroupsGetCollectionFieldsGameCenterChallenge.ReferenceName => "referenceName",
                GameCenterGroupsGetCollectionFieldsGameCenterChallenge.Repeatable => "repeatable",
                GameCenterGroupsGetCollectionFieldsGameCenterChallenge.VendorIdentifier => "vendorIdentifier",
                GameCenterGroupsGetCollectionFieldsGameCenterChallenge.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupsGetCollectionFieldsGameCenterChallenge? ToEnum(string value)
        {
            return value switch
            {
                "archived" => GameCenterGroupsGetCollectionFieldsGameCenterChallenge.Archived,
                "challengeType" => GameCenterGroupsGetCollectionFieldsGameCenterChallenge.ChallengeType,
                "gameCenterDetail" => GameCenterGroupsGetCollectionFieldsGameCenterChallenge.GameCenterDetail,
                "gameCenterGroup" => GameCenterGroupsGetCollectionFieldsGameCenterChallenge.GameCenterGroup,
                "leaderboard" => GameCenterGroupsGetCollectionFieldsGameCenterChallenge.Leaderboard,
                "leaderboardV2" => GameCenterGroupsGetCollectionFieldsGameCenterChallenge.LeaderboardV2,
                "referenceName" => GameCenterGroupsGetCollectionFieldsGameCenterChallenge.ReferenceName,
                "repeatable" => GameCenterGroupsGetCollectionFieldsGameCenterChallenge.Repeatable,
                "vendorIdentifier" => GameCenterGroupsGetCollectionFieldsGameCenterChallenge.VendorIdentifier,
                "versions" => GameCenterGroupsGetCollectionFieldsGameCenterChallenge.Versions,
                _ => null,
            };
        }
    }
}