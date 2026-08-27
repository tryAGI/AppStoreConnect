
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterChallenge
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
    public static class GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterChallengeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterChallenge value)
        {
            return value switch
            {
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterChallenge.Archived => "archived",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterChallenge.ChallengeType => "challengeType",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterChallenge.GameCenterDetail => "gameCenterDetail",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterChallenge.GameCenterGroup => "gameCenterGroup",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterChallenge.Leaderboard => "leaderboard",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterChallenge.LeaderboardV2 => "leaderboardV2",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterChallenge.ReferenceName => "referenceName",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterChallenge.Repeatable => "repeatable",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterChallenge.VendorIdentifier => "vendorIdentifier",
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterChallenge.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterChallenge? ToEnum(string value)
        {
            return value switch
            {
                "archived" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterChallenge.Archived,
                "challengeType" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterChallenge.ChallengeType,
                "gameCenterDetail" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterChallenge.GameCenterDetail,
                "gameCenterGroup" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterChallenge.GameCenterGroup,
                "leaderboard" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterChallenge.Leaderboard,
                "leaderboardV2" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterChallenge.LeaderboardV2,
                "referenceName" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterChallenge.ReferenceName,
                "repeatable" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterChallenge.Repeatable,
                "vendorIdentifier" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterChallenge.VendorIdentifier,
                "versions" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterChallenge.Versions,
                _ => null,
            };
        }
    }
}