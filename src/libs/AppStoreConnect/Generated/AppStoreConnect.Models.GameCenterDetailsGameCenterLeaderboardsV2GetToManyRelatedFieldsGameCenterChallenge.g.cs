
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge
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
    public static class GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallengeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge value)
        {
            return value switch
            {
                GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge.Archived => "archived",
                GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge.ChallengeType => "challengeType",
                GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge.GameCenterDetail => "gameCenterDetail",
                GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge.GameCenterGroup => "gameCenterGroup",
                GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge.Leaderboard => "leaderboard",
                GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge.LeaderboardV2 => "leaderboardV2",
                GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge.ReferenceName => "referenceName",
                GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge.Repeatable => "repeatable",
                GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge.VendorIdentifier => "vendorIdentifier",
                GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge? ToEnum(string value)
        {
            return value switch
            {
                "archived" => GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge.Archived,
                "challengeType" => GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge.ChallengeType,
                "gameCenterDetail" => GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge.GameCenterDetail,
                "gameCenterGroup" => GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge.GameCenterGroup,
                "leaderboard" => GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge.Leaderboard,
                "leaderboardV2" => GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge.LeaderboardV2,
                "referenceName" => GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge.ReferenceName,
                "repeatable" => GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge.Repeatable,
                "vendorIdentifier" => GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge.VendorIdentifier,
                "versions" => GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge.Versions,
                _ => null,
            };
        }
    }
}