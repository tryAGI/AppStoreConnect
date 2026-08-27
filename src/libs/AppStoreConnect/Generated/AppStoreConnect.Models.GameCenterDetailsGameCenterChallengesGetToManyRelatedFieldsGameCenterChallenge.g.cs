
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallenge
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
    public static class GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallengeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallenge value)
        {
            return value switch
            {
                GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallenge.Archived => "archived",
                GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallenge.ChallengeType => "challengeType",
                GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallenge.GameCenterDetail => "gameCenterDetail",
                GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallenge.GameCenterGroup => "gameCenterGroup",
                GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallenge.Leaderboard => "leaderboard",
                GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallenge.LeaderboardV2 => "leaderboardV2",
                GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallenge.ReferenceName => "referenceName",
                GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallenge.Repeatable => "repeatable",
                GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallenge.VendorIdentifier => "vendorIdentifier",
                GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallenge.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallenge? ToEnum(string value)
        {
            return value switch
            {
                "archived" => GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallenge.Archived,
                "challengeType" => GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallenge.ChallengeType,
                "gameCenterDetail" => GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallenge.GameCenterDetail,
                "gameCenterGroup" => GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallenge.GameCenterGroup,
                "leaderboard" => GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallenge.Leaderboard,
                "leaderboardV2" => GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallenge.LeaderboardV2,
                "referenceName" => GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallenge.ReferenceName,
                "repeatable" => GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallenge.Repeatable,
                "vendorIdentifier" => GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallenge.VendorIdentifier,
                "versions" => GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallenge.Versions,
                _ => null,
            };
        }
    }
}