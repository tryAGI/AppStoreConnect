
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterDetailsGetInstanceFieldsGameCenterLeaderboard
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
    public static class GameCenterDetailsGetInstanceFieldsGameCenterLeaderboardExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsGetInstanceFieldsGameCenterLeaderboard value)
        {
            return value switch
            {
                GameCenterDetailsGetInstanceFieldsGameCenterLeaderboard.Activity => "activity",
                GameCenterDetailsGetInstanceFieldsGameCenterLeaderboard.ActivityProperties => "activityProperties",
                GameCenterDetailsGetInstanceFieldsGameCenterLeaderboard.Archived => "archived",
                GameCenterDetailsGetInstanceFieldsGameCenterLeaderboard.Challenge => "challenge",
                GameCenterDetailsGetInstanceFieldsGameCenterLeaderboard.DefaultFormatter => "defaultFormatter",
                GameCenterDetailsGetInstanceFieldsGameCenterLeaderboard.GameCenterDetail => "gameCenterDetail",
                GameCenterDetailsGetInstanceFieldsGameCenterLeaderboard.GameCenterGroup => "gameCenterGroup",
                GameCenterDetailsGetInstanceFieldsGameCenterLeaderboard.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                GameCenterDetailsGetInstanceFieldsGameCenterLeaderboard.GroupLeaderboard => "groupLeaderboard",
                GameCenterDetailsGetInstanceFieldsGameCenterLeaderboard.Localizations => "localizations",
                GameCenterDetailsGetInstanceFieldsGameCenterLeaderboard.RecurrenceDuration => "recurrenceDuration",
                GameCenterDetailsGetInstanceFieldsGameCenterLeaderboard.RecurrenceRule => "recurrenceRule",
                GameCenterDetailsGetInstanceFieldsGameCenterLeaderboard.RecurrenceStartDate => "recurrenceStartDate",
                GameCenterDetailsGetInstanceFieldsGameCenterLeaderboard.ReferenceName => "referenceName",
                GameCenterDetailsGetInstanceFieldsGameCenterLeaderboard.Releases => "releases",
                GameCenterDetailsGetInstanceFieldsGameCenterLeaderboard.ScoreRangeEnd => "scoreRangeEnd",
                GameCenterDetailsGetInstanceFieldsGameCenterLeaderboard.ScoreRangeStart => "scoreRangeStart",
                GameCenterDetailsGetInstanceFieldsGameCenterLeaderboard.ScoreSortType => "scoreSortType",
                GameCenterDetailsGetInstanceFieldsGameCenterLeaderboard.SubmissionType => "submissionType",
                GameCenterDetailsGetInstanceFieldsGameCenterLeaderboard.VendorIdentifier => "vendorIdentifier",
                GameCenterDetailsGetInstanceFieldsGameCenterLeaderboard.Versions => "versions",
                GameCenterDetailsGetInstanceFieldsGameCenterLeaderboard.Visibility => "visibility",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsGetInstanceFieldsGameCenterLeaderboard? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterDetailsGetInstanceFieldsGameCenterLeaderboard.Activity,
                "activityProperties" => GameCenterDetailsGetInstanceFieldsGameCenterLeaderboard.ActivityProperties,
                "archived" => GameCenterDetailsGetInstanceFieldsGameCenterLeaderboard.Archived,
                "challenge" => GameCenterDetailsGetInstanceFieldsGameCenterLeaderboard.Challenge,
                "defaultFormatter" => GameCenterDetailsGetInstanceFieldsGameCenterLeaderboard.DefaultFormatter,
                "gameCenterDetail" => GameCenterDetailsGetInstanceFieldsGameCenterLeaderboard.GameCenterDetail,
                "gameCenterGroup" => GameCenterDetailsGetInstanceFieldsGameCenterLeaderboard.GameCenterGroup,
                "gameCenterLeaderboardSets" => GameCenterDetailsGetInstanceFieldsGameCenterLeaderboard.GameCenterLeaderboardSets,
                "groupLeaderboard" => GameCenterDetailsGetInstanceFieldsGameCenterLeaderboard.GroupLeaderboard,
                "localizations" => GameCenterDetailsGetInstanceFieldsGameCenterLeaderboard.Localizations,
                "recurrenceDuration" => GameCenterDetailsGetInstanceFieldsGameCenterLeaderboard.RecurrenceDuration,
                "recurrenceRule" => GameCenterDetailsGetInstanceFieldsGameCenterLeaderboard.RecurrenceRule,
                "recurrenceStartDate" => GameCenterDetailsGetInstanceFieldsGameCenterLeaderboard.RecurrenceStartDate,
                "referenceName" => GameCenterDetailsGetInstanceFieldsGameCenterLeaderboard.ReferenceName,
                "releases" => GameCenterDetailsGetInstanceFieldsGameCenterLeaderboard.Releases,
                "scoreRangeEnd" => GameCenterDetailsGetInstanceFieldsGameCenterLeaderboard.ScoreRangeEnd,
                "scoreRangeStart" => GameCenterDetailsGetInstanceFieldsGameCenterLeaderboard.ScoreRangeStart,
                "scoreSortType" => GameCenterDetailsGetInstanceFieldsGameCenterLeaderboard.ScoreSortType,
                "submissionType" => GameCenterDetailsGetInstanceFieldsGameCenterLeaderboard.SubmissionType,
                "vendorIdentifier" => GameCenterDetailsGetInstanceFieldsGameCenterLeaderboard.VendorIdentifier,
                "versions" => GameCenterDetailsGetInstanceFieldsGameCenterLeaderboard.Versions,
                "visibility" => GameCenterDetailsGetInstanceFieldsGameCenterLeaderboard.Visibility,
                _ => null,
            };
        }
    }
}