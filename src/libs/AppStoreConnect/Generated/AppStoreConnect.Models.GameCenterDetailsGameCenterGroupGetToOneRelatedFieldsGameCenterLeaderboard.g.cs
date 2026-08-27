
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboard
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
        Versions,
        /// <summary>
        ///
        /// </summary>
        Visibility,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboardExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboard value)
        {
            return value switch
            {
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboard.Activity => "activity",
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboard.ActivityProperties => "activityProperties",
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboard.Archived => "archived",
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboard.Challenge => "challenge",
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboard.DefaultFormatter => "defaultFormatter",
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboard.GameCenterDetail => "gameCenterDetail",
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboard.GameCenterGroup => "gameCenterGroup",
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboard.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboard.GroupLeaderboard => "groupLeaderboard",
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboard.Localizations => "localizations",
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboard.RecurrenceDuration => "recurrenceDuration",
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboard.RecurrenceRule => "recurrenceRule",
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboard.RecurrenceStartDate => "recurrenceStartDate",
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboard.ReferenceName => "referenceName",
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboard.Releases => "releases",
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboard.ScoreRangeEnd => "scoreRangeEnd",
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboard.ScoreRangeStart => "scoreRangeStart",
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboard.ScoreSortType => "scoreSortType",
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboard.SubmissionType => "submissionType",
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboard.VendorIdentifier => "vendorIdentifier",
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboard.Versions => "versions",
                GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboard.Visibility => "visibility",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboard? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboard.Activity,
                "activityProperties" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboard.ActivityProperties,
                "archived" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboard.Archived,
                "challenge" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboard.Challenge,
                "defaultFormatter" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboard.DefaultFormatter,
                "gameCenterDetail" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboard.GameCenterDetail,
                "gameCenterGroup" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboard.GameCenterGroup,
                "gameCenterLeaderboardSets" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboard.GameCenterLeaderboardSets,
                "groupLeaderboard" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboard.GroupLeaderboard,
                "localizations" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboard.Localizations,
                "recurrenceDuration" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboard.RecurrenceDuration,
                "recurrenceRule" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboard.RecurrenceRule,
                "recurrenceStartDate" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboard.RecurrenceStartDate,
                "referenceName" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboard.ReferenceName,
                "releases" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboard.Releases,
                "scoreRangeEnd" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboard.ScoreRangeEnd,
                "scoreRangeStart" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboard.ScoreRangeStart,
                "scoreSortType" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboard.ScoreSortType,
                "submissionType" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboard.SubmissionType,
                "vendorIdentifier" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboard.VendorIdentifier,
                "versions" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboard.Versions,
                "visibility" => GameCenterDetailsGameCenterGroupGetToOneRelatedFieldsGameCenterLeaderboard.Visibility,
                _ => null,
            };
        }
    }
}