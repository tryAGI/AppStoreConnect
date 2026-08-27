
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard
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
    public static class GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterLeaderboardExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard value)
        {
            return value switch
            {
                GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.Activity => "activity",
                GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.ActivityProperties => "activityProperties",
                GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.Archived => "archived",
                GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.Challenge => "challenge",
                GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.DefaultFormatter => "defaultFormatter",
                GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.GameCenterDetail => "gameCenterDetail",
                GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.GameCenterGroup => "gameCenterGroup",
                GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.GroupLeaderboard => "groupLeaderboard",
                GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.Localizations => "localizations",
                GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.RecurrenceDuration => "recurrenceDuration",
                GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.RecurrenceRule => "recurrenceRule",
                GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.RecurrenceStartDate => "recurrenceStartDate",
                GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.ReferenceName => "referenceName",
                GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.Releases => "releases",
                GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.ScoreRangeEnd => "scoreRangeEnd",
                GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.ScoreRangeStart => "scoreRangeStart",
                GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.ScoreSortType => "scoreSortType",
                GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.SubmissionType => "submissionType",
                GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.VendorIdentifier => "vendorIdentifier",
                GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.Visibility => "visibility",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.Activity,
                "activityProperties" => GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.ActivityProperties,
                "archived" => GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.Archived,
                "challenge" => GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.Challenge,
                "defaultFormatter" => GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.DefaultFormatter,
                "gameCenterDetail" => GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.GameCenterDetail,
                "gameCenterGroup" => GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.GameCenterGroup,
                "gameCenterLeaderboardSets" => GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.GameCenterLeaderboardSets,
                "groupLeaderboard" => GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.GroupLeaderboard,
                "localizations" => GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.Localizations,
                "recurrenceDuration" => GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.RecurrenceDuration,
                "recurrenceRule" => GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.RecurrenceRule,
                "recurrenceStartDate" => GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.RecurrenceStartDate,
                "referenceName" => GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.ReferenceName,
                "releases" => GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.Releases,
                "scoreRangeEnd" => GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.ScoreRangeEnd,
                "scoreRangeStart" => GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.ScoreRangeStart,
                "scoreSortType" => GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.ScoreSortType,
                "submissionType" => GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.SubmissionType,
                "vendorIdentifier" => GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.VendorIdentifier,
                "visibility" => GameCenterLeaderboardsGroupLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.Visibility,
                _ => null,
            };
        }
    }
}