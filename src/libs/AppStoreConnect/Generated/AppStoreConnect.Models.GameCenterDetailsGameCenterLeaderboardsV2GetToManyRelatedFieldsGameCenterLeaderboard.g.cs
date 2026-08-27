
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard
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
    public static class GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard value)
        {
            return value switch
            {
                GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard.Activity => "activity",
                GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard.ActivityProperties => "activityProperties",
                GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard.Archived => "archived",
                GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard.Challenge => "challenge",
                GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard.DefaultFormatter => "defaultFormatter",
                GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard.GameCenterDetail => "gameCenterDetail",
                GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard.GameCenterGroup => "gameCenterGroup",
                GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard.RecurrenceDuration => "recurrenceDuration",
                GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard.RecurrenceRule => "recurrenceRule",
                GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard.RecurrenceStartDate => "recurrenceStartDate",
                GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard.ReferenceName => "referenceName",
                GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard.ScoreRangeEnd => "scoreRangeEnd",
                GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard.ScoreRangeStart => "scoreRangeStart",
                GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard.ScoreSortType => "scoreSortType",
                GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard.SubmissionType => "submissionType",
                GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard.VendorIdentifier => "vendorIdentifier",
                GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard.Versions => "versions",
                GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard.Visibility => "visibility",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard.Activity,
                "activityProperties" => GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard.ActivityProperties,
                "archived" => GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard.Archived,
                "challenge" => GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard.Challenge,
                "defaultFormatter" => GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard.DefaultFormatter,
                "gameCenterDetail" => GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard.GameCenterDetail,
                "gameCenterGroup" => GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard.GameCenterGroup,
                "gameCenterLeaderboardSets" => GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard.GameCenterLeaderboardSets,
                "recurrenceDuration" => GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard.RecurrenceDuration,
                "recurrenceRule" => GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard.RecurrenceRule,
                "recurrenceStartDate" => GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard.RecurrenceStartDate,
                "referenceName" => GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard.ReferenceName,
                "scoreRangeEnd" => GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard.ScoreRangeEnd,
                "scoreRangeStart" => GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard.ScoreRangeStart,
                "scoreSortType" => GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard.ScoreSortType,
                "submissionType" => GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard.SubmissionType,
                "vendorIdentifier" => GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard.VendorIdentifier,
                "versions" => GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard.Versions,
                "visibility" => GameCenterDetailsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard.Visibility,
                _ => null,
            };
        }
    }
}