
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboard
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
    public static class GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboardExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboard value)
        {
            return value switch
            {
                GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboard.Activity => "activity",
                GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboard.ActivityProperties => "activityProperties",
                GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboard.Archived => "archived",
                GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboard.Challenge => "challenge",
                GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboard.DefaultFormatter => "defaultFormatter",
                GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboard.GameCenterDetail => "gameCenterDetail",
                GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboard.GameCenterGroup => "gameCenterGroup",
                GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboard.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboard.GroupLeaderboard => "groupLeaderboard",
                GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboard.Localizations => "localizations",
                GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboard.RecurrenceDuration => "recurrenceDuration",
                GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboard.RecurrenceRule => "recurrenceRule",
                GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboard.RecurrenceStartDate => "recurrenceStartDate",
                GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboard.ReferenceName => "referenceName",
                GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboard.Releases => "releases",
                GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboard.ScoreRangeEnd => "scoreRangeEnd",
                GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboard.ScoreRangeStart => "scoreRangeStart",
                GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboard.ScoreSortType => "scoreSortType",
                GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboard.SubmissionType => "submissionType",
                GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboard.VendorIdentifier => "vendorIdentifier",
                GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboard.Visibility => "visibility",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboard? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboard.Activity,
                "activityProperties" => GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboard.ActivityProperties,
                "archived" => GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboard.Archived,
                "challenge" => GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboard.Challenge,
                "defaultFormatter" => GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboard.DefaultFormatter,
                "gameCenterDetail" => GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboard.GameCenterDetail,
                "gameCenterGroup" => GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboard.GameCenterGroup,
                "gameCenterLeaderboardSets" => GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboard.GameCenterLeaderboardSets,
                "groupLeaderboard" => GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboard.GroupLeaderboard,
                "localizations" => GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboard.Localizations,
                "recurrenceDuration" => GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboard.RecurrenceDuration,
                "recurrenceRule" => GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboard.RecurrenceRule,
                "recurrenceStartDate" => GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboard.RecurrenceStartDate,
                "referenceName" => GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboard.ReferenceName,
                "releases" => GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboard.Releases,
                "scoreRangeEnd" => GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboard.ScoreRangeEnd,
                "scoreRangeStart" => GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboard.ScoreRangeStart,
                "scoreSortType" => GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboard.ScoreSortType,
                "submissionType" => GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboard.SubmissionType,
                "vendorIdentifier" => GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboard.VendorIdentifier,
                "visibility" => GameCenterLeaderboardSetsGroupLeaderboardSetGetToOneRelatedFieldsGameCenterLeaderboard.Visibility,
                _ => null,
            };
        }
    }
}