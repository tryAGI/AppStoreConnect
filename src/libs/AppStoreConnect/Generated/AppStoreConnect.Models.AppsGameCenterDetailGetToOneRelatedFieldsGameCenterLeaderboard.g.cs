
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboard
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
    public static class AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboardExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboard value)
        {
            return value switch
            {
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboard.Activity => "activity",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboard.ActivityProperties => "activityProperties",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboard.Archived => "archived",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboard.Challenge => "challenge",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboard.DefaultFormatter => "defaultFormatter",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboard.GameCenterDetail => "gameCenterDetail",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboard.GameCenterGroup => "gameCenterGroup",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboard.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboard.GroupLeaderboard => "groupLeaderboard",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboard.Localizations => "localizations",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboard.RecurrenceDuration => "recurrenceDuration",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboard.RecurrenceRule => "recurrenceRule",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboard.RecurrenceStartDate => "recurrenceStartDate",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboard.ReferenceName => "referenceName",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboard.Releases => "releases",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboard.ScoreRangeEnd => "scoreRangeEnd",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboard.ScoreRangeStart => "scoreRangeStart",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboard.ScoreSortType => "scoreSortType",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboard.SubmissionType => "submissionType",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboard.VendorIdentifier => "vendorIdentifier",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboard.Versions => "versions",
                AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboard.Visibility => "visibility",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboard? ToEnum(string value)
        {
            return value switch
            {
                "activity" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboard.Activity,
                "activityProperties" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboard.ActivityProperties,
                "archived" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboard.Archived,
                "challenge" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboard.Challenge,
                "defaultFormatter" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboard.DefaultFormatter,
                "gameCenterDetail" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboard.GameCenterDetail,
                "gameCenterGroup" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboard.GameCenterGroup,
                "gameCenterLeaderboardSets" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboard.GameCenterLeaderboardSets,
                "groupLeaderboard" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboard.GroupLeaderboard,
                "localizations" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboard.Localizations,
                "recurrenceDuration" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboard.RecurrenceDuration,
                "recurrenceRule" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboard.RecurrenceRule,
                "recurrenceStartDate" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboard.RecurrenceStartDate,
                "referenceName" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboard.ReferenceName,
                "releases" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboard.Releases,
                "scoreRangeEnd" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboard.ScoreRangeEnd,
                "scoreRangeStart" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboard.ScoreRangeStart,
                "scoreSortType" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboard.ScoreSortType,
                "submissionType" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboard.SubmissionType,
                "vendorIdentifier" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboard.VendorIdentifier,
                "versions" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboard.Versions,
                "visibility" => AppsGameCenterDetailGetToOneRelatedFieldsGameCenterLeaderboard.Visibility,
                _ => null,
            };
        }
    }
}