
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard
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
        GroupLeaderboard,
        /// <summary>
        ///
        /// </summary>
        Localizations,
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
        Releases,
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
        Visibility,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard value)
        {
            return value switch
            {
                GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.Activity => "activity",
                GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.ActivityProperties => "activityProperties",
                GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.Archived => "archived",
                GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.Challenge => "challenge",
                GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.DefaultFormatter => "defaultFormatter",
                GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.GameCenterDetail => "gameCenterDetail",
                GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.GameCenterGroup => "gameCenterGroup",
                GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.GroupLeaderboard => "groupLeaderboard",
                GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.Localizations => "localizations",
                GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.RecurrenceDuration => "recurrenceDuration",
                GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.RecurrenceRule => "recurrenceRule",
                GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.RecurrenceStartDate => "recurrenceStartDate",
                GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.ReferenceName => "referenceName",
                GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.Releases => "releases",
                GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.ScoreRangeEnd => "scoreRangeEnd",
                GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.ScoreRangeStart => "scoreRangeStart",
                GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.ScoreSortType => "scoreSortType",
                GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.SubmissionType => "submissionType",
                GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.VendorIdentifier => "vendorIdentifier",
                GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.Visibility => "visibility",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.Activity,
                "activityProperties" => GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.ActivityProperties,
                "archived" => GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.Archived,
                "challenge" => GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.Challenge,
                "defaultFormatter" => GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.DefaultFormatter,
                "gameCenterDetail" => GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.GameCenterDetail,
                "gameCenterGroup" => GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.GameCenterGroup,
                "gameCenterLeaderboardSets" => GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.GameCenterLeaderboardSets,
                "groupLeaderboard" => GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.GroupLeaderboard,
                "localizations" => GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.Localizations,
                "recurrenceDuration" => GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.RecurrenceDuration,
                "recurrenceRule" => GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.RecurrenceRule,
                "recurrenceStartDate" => GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.RecurrenceStartDate,
                "referenceName" => GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.ReferenceName,
                "releases" => GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.Releases,
                "scoreRangeEnd" => GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.ScoreRangeEnd,
                "scoreRangeStart" => GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.ScoreRangeStart,
                "scoreSortType" => GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.ScoreSortType,
                "submissionType" => GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.SubmissionType,
                "vendorIdentifier" => GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.VendorIdentifier,
                "visibility" => GameCenterDetailsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.Visibility,
                _ => null,
            };
        }
    }
}