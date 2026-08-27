
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard
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
    public static class GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard value)
        {
            return value switch
            {
                GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.Activity => "activity",
                GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.ActivityProperties => "activityProperties",
                GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.Archived => "archived",
                GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.Challenge => "challenge",
                GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.DefaultFormatter => "defaultFormatter",
                GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.GameCenterDetail => "gameCenterDetail",
                GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.GameCenterGroup => "gameCenterGroup",
                GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.RecurrenceDuration => "recurrenceDuration",
                GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.RecurrenceRule => "recurrenceRule",
                GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.RecurrenceStartDate => "recurrenceStartDate",
                GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.ReferenceName => "referenceName",
                GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.ScoreRangeEnd => "scoreRangeEnd",
                GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.ScoreRangeStart => "scoreRangeStart",
                GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.ScoreSortType => "scoreSortType",
                GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.SubmissionType => "submissionType",
                GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.VendorIdentifier => "vendorIdentifier",
                GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.Versions => "versions",
                GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.Visibility => "visibility",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.Activity,
                "activityProperties" => GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.ActivityProperties,
                "archived" => GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.Archived,
                "challenge" => GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.Challenge,
                "defaultFormatter" => GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.DefaultFormatter,
                "gameCenterDetail" => GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.GameCenterDetail,
                "gameCenterGroup" => GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.GameCenterGroup,
                "gameCenterLeaderboardSets" => GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.GameCenterLeaderboardSets,
                "recurrenceDuration" => GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.RecurrenceDuration,
                "recurrenceRule" => GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.RecurrenceRule,
                "recurrenceStartDate" => GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.RecurrenceStartDate,
                "referenceName" => GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.ReferenceName,
                "scoreRangeEnd" => GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.ScoreRangeEnd,
                "scoreRangeStart" => GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.ScoreRangeStart,
                "scoreSortType" => GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.ScoreSortType,
                "submissionType" => GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.SubmissionType,
                "vendorIdentifier" => GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.VendorIdentifier,
                "versions" => GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.Versions,
                "visibility" => GameCenterDetailsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.Visibility,
                _ => null,
            };
        }
    }
}