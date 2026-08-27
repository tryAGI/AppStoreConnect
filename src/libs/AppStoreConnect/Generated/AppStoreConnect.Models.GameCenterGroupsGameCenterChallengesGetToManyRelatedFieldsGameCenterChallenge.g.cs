
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallenge
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
    public static class GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallengeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallenge value)
        {
            return value switch
            {
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallenge.Archived => "archived",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallenge.ChallengeType => "challengeType",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallenge.GameCenterDetail => "gameCenterDetail",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallenge.GameCenterGroup => "gameCenterGroup",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallenge.Leaderboard => "leaderboard",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallenge.LeaderboardV2 => "leaderboardV2",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallenge.ReferenceName => "referenceName",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallenge.Repeatable => "repeatable",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallenge.VendorIdentifier => "vendorIdentifier",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallenge.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallenge? ToEnum(string value)
        {
            return value switch
            {
                "archived" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallenge.Archived,
                "challengeType" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallenge.ChallengeType,
                "gameCenterDetail" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallenge.GameCenterDetail,
                "gameCenterGroup" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallenge.GameCenterGroup,
                "leaderboard" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallenge.Leaderboard,
                "leaderboardV2" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallenge.LeaderboardV2,
                "referenceName" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallenge.ReferenceName,
                "repeatable" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallenge.Repeatable,
                "vendorIdentifier" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallenge.VendorIdentifier,
                "versions" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallenge.Versions,
                _ => null,
            };
        }
    }
}