
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboard
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
    public static class GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboardExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboard value)
        {
            return value switch
            {
                GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboard.Activity => "activity",
                GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboard.ActivityProperties => "activityProperties",
                GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboard.Archived => "archived",
                GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboard.Challenge => "challenge",
                GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboard.DefaultFormatter => "defaultFormatter",
                GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboard.GameCenterDetail => "gameCenterDetail",
                GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboard.GameCenterGroup => "gameCenterGroup",
                GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboard.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboard.GroupLeaderboard => "groupLeaderboard",
                GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboard.Localizations => "localizations",
                GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboard.RecurrenceDuration => "recurrenceDuration",
                GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboard.RecurrenceRule => "recurrenceRule",
                GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboard.RecurrenceStartDate => "recurrenceStartDate",
                GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboard.ReferenceName => "referenceName",
                GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboard.Releases => "releases",
                GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboard.ScoreRangeEnd => "scoreRangeEnd",
                GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboard.ScoreRangeStart => "scoreRangeStart",
                GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboard.ScoreSortType => "scoreSortType",
                GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboard.SubmissionType => "submissionType",
                GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboard.VendorIdentifier => "vendorIdentifier",
                GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboard.Visibility => "visibility",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboard? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboard.Activity,
                "activityProperties" => GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboard.ActivityProperties,
                "archived" => GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboard.Archived,
                "challenge" => GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboard.Challenge,
                "defaultFormatter" => GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboard.DefaultFormatter,
                "gameCenterDetail" => GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboard.GameCenterDetail,
                "gameCenterGroup" => GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboard.GameCenterGroup,
                "gameCenterLeaderboardSets" => GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboard.GameCenterLeaderboardSets,
                "groupLeaderboard" => GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboard.GroupLeaderboard,
                "localizations" => GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboard.Localizations,
                "recurrenceDuration" => GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboard.RecurrenceDuration,
                "recurrenceRule" => GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboard.RecurrenceRule,
                "recurrenceStartDate" => GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboard.RecurrenceStartDate,
                "referenceName" => GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboard.ReferenceName,
                "releases" => GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboard.Releases,
                "scoreRangeEnd" => GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboard.ScoreRangeEnd,
                "scoreRangeStart" => GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboard.ScoreRangeStart,
                "scoreSortType" => GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboard.ScoreSortType,
                "submissionType" => GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboard.SubmissionType,
                "vendorIdentifier" => GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboard.VendorIdentifier,
                "visibility" => GameCenterLeaderboardLocalizationsGetInstanceFieldsGameCenterLeaderboard.Visibility,
                _ => null,
            };
        }
    }
}