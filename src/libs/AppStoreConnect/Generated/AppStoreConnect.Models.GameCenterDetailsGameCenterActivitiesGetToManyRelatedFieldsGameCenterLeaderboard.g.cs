
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard
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
    public static class GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboardExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard value)
        {
            return value switch
            {
                GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.Activity => "activity",
                GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.ActivityProperties => "activityProperties",
                GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.Archived => "archived",
                GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.Challenge => "challenge",
                GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.DefaultFormatter => "defaultFormatter",
                GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.GameCenterDetail => "gameCenterDetail",
                GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.GameCenterGroup => "gameCenterGroup",
                GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.GroupLeaderboard => "groupLeaderboard",
                GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.Localizations => "localizations",
                GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.RecurrenceDuration => "recurrenceDuration",
                GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.RecurrenceRule => "recurrenceRule",
                GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.RecurrenceStartDate => "recurrenceStartDate",
                GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.ReferenceName => "referenceName",
                GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.Releases => "releases",
                GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.ScoreRangeEnd => "scoreRangeEnd",
                GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.ScoreRangeStart => "scoreRangeStart",
                GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.ScoreSortType => "scoreSortType",
                GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.SubmissionType => "submissionType",
                GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.VendorIdentifier => "vendorIdentifier",
                GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.Versions => "versions",
                GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.Visibility => "visibility",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.Activity,
                "activityProperties" => GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.ActivityProperties,
                "archived" => GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.Archived,
                "challenge" => GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.Challenge,
                "defaultFormatter" => GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.DefaultFormatter,
                "gameCenterDetail" => GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.GameCenterDetail,
                "gameCenterGroup" => GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.GameCenterGroup,
                "gameCenterLeaderboardSets" => GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.GameCenterLeaderboardSets,
                "groupLeaderboard" => GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.GroupLeaderboard,
                "localizations" => GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.Localizations,
                "recurrenceDuration" => GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.RecurrenceDuration,
                "recurrenceRule" => GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.RecurrenceRule,
                "recurrenceStartDate" => GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.RecurrenceStartDate,
                "referenceName" => GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.ReferenceName,
                "releases" => GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.Releases,
                "scoreRangeEnd" => GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.ScoreRangeEnd,
                "scoreRangeStart" => GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.ScoreRangeStart,
                "scoreSortType" => GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.ScoreSortType,
                "submissionType" => GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.SubmissionType,
                "vendorIdentifier" => GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.VendorIdentifier,
                "versions" => GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.Versions,
                "visibility" => GameCenterDetailsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.Visibility,
                _ => null,
            };
        }
    }
}