
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboard
    {
        /// <summary>
        ///
        /// </summary>
        Activity,
        /// <summary>
        ///
        /// </summary>
        ActivityProperties,
        /// <summary>
        ///
        /// </summary>
        Archived,
        /// <summary>
        ///
        /// </summary>
        Challenge,
        /// <summary>
        ///
        /// </summary>
        DefaultFormatter,
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
        GameCenterLeaderboardSets,
        /// <summary>
        ///
        /// </summary>
        RecurrenceDuration,
        /// <summary>
        ///
        /// </summary>
        RecurrenceRule,
        /// <summary>
        ///
        /// </summary>
        RecurrenceStartDate,
        /// <summary>
        ///
        /// </summary>
        ReferenceName,
        /// <summary>
        ///
        /// </summary>
        ScoreRangeEnd,
        /// <summary>
        ///
        /// </summary>
        ScoreRangeStart,
        /// <summary>
        ///
        /// </summary>
        ScoreSortType,
        /// <summary>
        ///
        /// </summary>
        SubmissionType,
        /// <summary>
        ///
        /// </summary>
        VendorIdentifier,
        /// <summary>
        ///
        /// </summary>
        Versions,
        /// <summary>
        ///
        /// </summary>
        Visibility,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboardExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboard value)
        {
            return value switch
            {
                GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboard.Activity => "activity",
                GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboard.ActivityProperties => "activityProperties",
                GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboard.Archived => "archived",
                GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboard.Challenge => "challenge",
                GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboard.DefaultFormatter => "defaultFormatter",
                GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboard.GameCenterDetail => "gameCenterDetail",
                GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboard.GameCenterGroup => "gameCenterGroup",
                GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboard.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboard.RecurrenceDuration => "recurrenceDuration",
                GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboard.RecurrenceRule => "recurrenceRule",
                GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboard.RecurrenceStartDate => "recurrenceStartDate",
                GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboard.ReferenceName => "referenceName",
                GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboard.ScoreRangeEnd => "scoreRangeEnd",
                GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboard.ScoreRangeStart => "scoreRangeStart",
                GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboard.ScoreSortType => "scoreSortType",
                GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboard.SubmissionType => "submissionType",
                GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboard.VendorIdentifier => "vendorIdentifier",
                GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboard.Versions => "versions",
                GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboard.Visibility => "visibility",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboard? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboard.Activity,
                "activityProperties" => GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboard.ActivityProperties,
                "archived" => GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboard.Archived,
                "challenge" => GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboard.Challenge,
                "defaultFormatter" => GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboard.DefaultFormatter,
                "gameCenterDetail" => GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboard.GameCenterDetail,
                "gameCenterGroup" => GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboard.GameCenterGroup,
                "gameCenterLeaderboardSets" => GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboard.GameCenterLeaderboardSets,
                "recurrenceDuration" => GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboard.RecurrenceDuration,
                "recurrenceRule" => GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboard.RecurrenceRule,
                "recurrenceStartDate" => GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboard.RecurrenceStartDate,
                "referenceName" => GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboard.ReferenceName,
                "scoreRangeEnd" => GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboard.ScoreRangeEnd,
                "scoreRangeStart" => GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboard.ScoreRangeStart,
                "scoreSortType" => GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboard.ScoreSortType,
                "submissionType" => GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboard.SubmissionType,
                "vendorIdentifier" => GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboard.VendorIdentifier,
                "versions" => GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboard.Versions,
                "visibility" => GameCenterLeaderboardSetsV2GetInstanceFieldsGameCenterLeaderboard.Visibility,
                _ => null,
            };
        }
    }
}