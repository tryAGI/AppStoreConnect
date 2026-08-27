
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterGroupsGetInstanceFieldsGameCenterLeaderboard
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
    public static class GameCenterGroupsGetInstanceFieldsGameCenterLeaderboardExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupsGetInstanceFieldsGameCenterLeaderboard value)
        {
            return value switch
            {
                GameCenterGroupsGetInstanceFieldsGameCenterLeaderboard.Activity => "activity",
                GameCenterGroupsGetInstanceFieldsGameCenterLeaderboard.ActivityProperties => "activityProperties",
                GameCenterGroupsGetInstanceFieldsGameCenterLeaderboard.Archived => "archived",
                GameCenterGroupsGetInstanceFieldsGameCenterLeaderboard.Challenge => "challenge",
                GameCenterGroupsGetInstanceFieldsGameCenterLeaderboard.DefaultFormatter => "defaultFormatter",
                GameCenterGroupsGetInstanceFieldsGameCenterLeaderboard.GameCenterDetail => "gameCenterDetail",
                GameCenterGroupsGetInstanceFieldsGameCenterLeaderboard.GameCenterGroup => "gameCenterGroup",
                GameCenterGroupsGetInstanceFieldsGameCenterLeaderboard.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                GameCenterGroupsGetInstanceFieldsGameCenterLeaderboard.GroupLeaderboard => "groupLeaderboard",
                GameCenterGroupsGetInstanceFieldsGameCenterLeaderboard.Localizations => "localizations",
                GameCenterGroupsGetInstanceFieldsGameCenterLeaderboard.RecurrenceDuration => "recurrenceDuration",
                GameCenterGroupsGetInstanceFieldsGameCenterLeaderboard.RecurrenceRule => "recurrenceRule",
                GameCenterGroupsGetInstanceFieldsGameCenterLeaderboard.RecurrenceStartDate => "recurrenceStartDate",
                GameCenterGroupsGetInstanceFieldsGameCenterLeaderboard.ReferenceName => "referenceName",
                GameCenterGroupsGetInstanceFieldsGameCenterLeaderboard.Releases => "releases",
                GameCenterGroupsGetInstanceFieldsGameCenterLeaderboard.ScoreRangeEnd => "scoreRangeEnd",
                GameCenterGroupsGetInstanceFieldsGameCenterLeaderboard.ScoreRangeStart => "scoreRangeStart",
                GameCenterGroupsGetInstanceFieldsGameCenterLeaderboard.ScoreSortType => "scoreSortType",
                GameCenterGroupsGetInstanceFieldsGameCenterLeaderboard.SubmissionType => "submissionType",
                GameCenterGroupsGetInstanceFieldsGameCenterLeaderboard.VendorIdentifier => "vendorIdentifier",
                GameCenterGroupsGetInstanceFieldsGameCenterLeaderboard.Versions => "versions",
                GameCenterGroupsGetInstanceFieldsGameCenterLeaderboard.Visibility => "visibility",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupsGetInstanceFieldsGameCenterLeaderboard? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterGroupsGetInstanceFieldsGameCenterLeaderboard.Activity,
                "activityProperties" => GameCenterGroupsGetInstanceFieldsGameCenterLeaderboard.ActivityProperties,
                "archived" => GameCenterGroupsGetInstanceFieldsGameCenterLeaderboard.Archived,
                "challenge" => GameCenterGroupsGetInstanceFieldsGameCenterLeaderboard.Challenge,
                "defaultFormatter" => GameCenterGroupsGetInstanceFieldsGameCenterLeaderboard.DefaultFormatter,
                "gameCenterDetail" => GameCenterGroupsGetInstanceFieldsGameCenterLeaderboard.GameCenterDetail,
                "gameCenterGroup" => GameCenterGroupsGetInstanceFieldsGameCenterLeaderboard.GameCenterGroup,
                "gameCenterLeaderboardSets" => GameCenterGroupsGetInstanceFieldsGameCenterLeaderboard.GameCenterLeaderboardSets,
                "groupLeaderboard" => GameCenterGroupsGetInstanceFieldsGameCenterLeaderboard.GroupLeaderboard,
                "localizations" => GameCenterGroupsGetInstanceFieldsGameCenterLeaderboard.Localizations,
                "recurrenceDuration" => GameCenterGroupsGetInstanceFieldsGameCenterLeaderboard.RecurrenceDuration,
                "recurrenceRule" => GameCenterGroupsGetInstanceFieldsGameCenterLeaderboard.RecurrenceRule,
                "recurrenceStartDate" => GameCenterGroupsGetInstanceFieldsGameCenterLeaderboard.RecurrenceStartDate,
                "referenceName" => GameCenterGroupsGetInstanceFieldsGameCenterLeaderboard.ReferenceName,
                "releases" => GameCenterGroupsGetInstanceFieldsGameCenterLeaderboard.Releases,
                "scoreRangeEnd" => GameCenterGroupsGetInstanceFieldsGameCenterLeaderboard.ScoreRangeEnd,
                "scoreRangeStart" => GameCenterGroupsGetInstanceFieldsGameCenterLeaderboard.ScoreRangeStart,
                "scoreSortType" => GameCenterGroupsGetInstanceFieldsGameCenterLeaderboard.ScoreSortType,
                "submissionType" => GameCenterGroupsGetInstanceFieldsGameCenterLeaderboard.SubmissionType,
                "vendorIdentifier" => GameCenterGroupsGetInstanceFieldsGameCenterLeaderboard.VendorIdentifier,
                "versions" => GameCenterGroupsGetInstanceFieldsGameCenterLeaderboard.Versions,
                "visibility" => GameCenterGroupsGetInstanceFieldsGameCenterLeaderboard.Visibility,
                _ => null,
            };
        }
    }
}