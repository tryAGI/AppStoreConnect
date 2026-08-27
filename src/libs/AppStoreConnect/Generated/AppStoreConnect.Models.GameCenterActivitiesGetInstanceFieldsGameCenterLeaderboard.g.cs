
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterActivitiesGetInstanceFieldsGameCenterLeaderboard
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
    public static class GameCenterActivitiesGetInstanceFieldsGameCenterLeaderboardExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterActivitiesGetInstanceFieldsGameCenterLeaderboard value)
        {
            return value switch
            {
                GameCenterActivitiesGetInstanceFieldsGameCenterLeaderboard.Activity => "activity",
                GameCenterActivitiesGetInstanceFieldsGameCenterLeaderboard.ActivityProperties => "activityProperties",
                GameCenterActivitiesGetInstanceFieldsGameCenterLeaderboard.Archived => "archived",
                GameCenterActivitiesGetInstanceFieldsGameCenterLeaderboard.Challenge => "challenge",
                GameCenterActivitiesGetInstanceFieldsGameCenterLeaderboard.DefaultFormatter => "defaultFormatter",
                GameCenterActivitiesGetInstanceFieldsGameCenterLeaderboard.GameCenterDetail => "gameCenterDetail",
                GameCenterActivitiesGetInstanceFieldsGameCenterLeaderboard.GameCenterGroup => "gameCenterGroup",
                GameCenterActivitiesGetInstanceFieldsGameCenterLeaderboard.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                GameCenterActivitiesGetInstanceFieldsGameCenterLeaderboard.GroupLeaderboard => "groupLeaderboard",
                GameCenterActivitiesGetInstanceFieldsGameCenterLeaderboard.Localizations => "localizations",
                GameCenterActivitiesGetInstanceFieldsGameCenterLeaderboard.RecurrenceDuration => "recurrenceDuration",
                GameCenterActivitiesGetInstanceFieldsGameCenterLeaderboard.RecurrenceRule => "recurrenceRule",
                GameCenterActivitiesGetInstanceFieldsGameCenterLeaderboard.RecurrenceStartDate => "recurrenceStartDate",
                GameCenterActivitiesGetInstanceFieldsGameCenterLeaderboard.ReferenceName => "referenceName",
                GameCenterActivitiesGetInstanceFieldsGameCenterLeaderboard.Releases => "releases",
                GameCenterActivitiesGetInstanceFieldsGameCenterLeaderboard.ScoreRangeEnd => "scoreRangeEnd",
                GameCenterActivitiesGetInstanceFieldsGameCenterLeaderboard.ScoreRangeStart => "scoreRangeStart",
                GameCenterActivitiesGetInstanceFieldsGameCenterLeaderboard.ScoreSortType => "scoreSortType",
                GameCenterActivitiesGetInstanceFieldsGameCenterLeaderboard.SubmissionType => "submissionType",
                GameCenterActivitiesGetInstanceFieldsGameCenterLeaderboard.VendorIdentifier => "vendorIdentifier",
                GameCenterActivitiesGetInstanceFieldsGameCenterLeaderboard.Versions => "versions",
                GameCenterActivitiesGetInstanceFieldsGameCenterLeaderboard.Visibility => "visibility",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterActivitiesGetInstanceFieldsGameCenterLeaderboard? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterActivitiesGetInstanceFieldsGameCenterLeaderboard.Activity,
                "activityProperties" => GameCenterActivitiesGetInstanceFieldsGameCenterLeaderboard.ActivityProperties,
                "archived" => GameCenterActivitiesGetInstanceFieldsGameCenterLeaderboard.Archived,
                "challenge" => GameCenterActivitiesGetInstanceFieldsGameCenterLeaderboard.Challenge,
                "defaultFormatter" => GameCenterActivitiesGetInstanceFieldsGameCenterLeaderboard.DefaultFormatter,
                "gameCenterDetail" => GameCenterActivitiesGetInstanceFieldsGameCenterLeaderboard.GameCenterDetail,
                "gameCenterGroup" => GameCenterActivitiesGetInstanceFieldsGameCenterLeaderboard.GameCenterGroup,
                "gameCenterLeaderboardSets" => GameCenterActivitiesGetInstanceFieldsGameCenterLeaderboard.GameCenterLeaderboardSets,
                "groupLeaderboard" => GameCenterActivitiesGetInstanceFieldsGameCenterLeaderboard.GroupLeaderboard,
                "localizations" => GameCenterActivitiesGetInstanceFieldsGameCenterLeaderboard.Localizations,
                "recurrenceDuration" => GameCenterActivitiesGetInstanceFieldsGameCenterLeaderboard.RecurrenceDuration,
                "recurrenceRule" => GameCenterActivitiesGetInstanceFieldsGameCenterLeaderboard.RecurrenceRule,
                "recurrenceStartDate" => GameCenterActivitiesGetInstanceFieldsGameCenterLeaderboard.RecurrenceStartDate,
                "referenceName" => GameCenterActivitiesGetInstanceFieldsGameCenterLeaderboard.ReferenceName,
                "releases" => GameCenterActivitiesGetInstanceFieldsGameCenterLeaderboard.Releases,
                "scoreRangeEnd" => GameCenterActivitiesGetInstanceFieldsGameCenterLeaderboard.ScoreRangeEnd,
                "scoreRangeStart" => GameCenterActivitiesGetInstanceFieldsGameCenterLeaderboard.ScoreRangeStart,
                "scoreSortType" => GameCenterActivitiesGetInstanceFieldsGameCenterLeaderboard.ScoreSortType,
                "submissionType" => GameCenterActivitiesGetInstanceFieldsGameCenterLeaderboard.SubmissionType,
                "vendorIdentifier" => GameCenterActivitiesGetInstanceFieldsGameCenterLeaderboard.VendorIdentifier,
                "versions" => GameCenterActivitiesGetInstanceFieldsGameCenterLeaderboard.Versions,
                "visibility" => GameCenterActivitiesGetInstanceFieldsGameCenterLeaderboard.Visibility,
                _ => null,
            };
        }
    }
}