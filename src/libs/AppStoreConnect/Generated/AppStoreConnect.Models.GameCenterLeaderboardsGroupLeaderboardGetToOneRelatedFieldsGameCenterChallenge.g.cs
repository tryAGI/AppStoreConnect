
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterChallenge
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
    public static class GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterChallengeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterChallenge value)
        {
            return value switch
            {
                GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterChallenge.Archived => "archived",
                GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterChallenge.ChallengeType => "challengeType",
                GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterChallenge.GameCenterDetail => "gameCenterDetail",
                GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterChallenge.GameCenterGroup => "gameCenterGroup",
                GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterChallenge.Leaderboard => "leaderboard",
                GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterChallenge.LeaderboardV2 => "leaderboardV2",
                GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterChallenge.ReferenceName => "referenceName",
                GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterChallenge.Repeatable => "repeatable",
                GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterChallenge.VendorIdentifier => "vendorIdentifier",
                GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterChallenge.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterChallenge? ToEnum(string value)
        {
            return value switch
            {
                "archived" => GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterChallenge.Archived,
                "challengeType" => GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterChallenge.ChallengeType,
                "gameCenterDetail" => GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterChallenge.GameCenterDetail,
                "gameCenterGroup" => GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterChallenge.GameCenterGroup,
                "leaderboard" => GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterChallenge.Leaderboard,
                "leaderboardV2" => GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterChallenge.LeaderboardV2,
                "referenceName" => GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterChallenge.ReferenceName,
                "repeatable" => GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterChallenge.Repeatable,
                "vendorIdentifier" => GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterChallenge.VendorIdentifier,
                "versions" => GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterChallenge.Versions,
                _ => null,
            };
        }
    }
}