
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterGroupsGetCollectionFieldsGameCenterLeaderboard
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
    public static class GameCenterGroupsGetCollectionFieldsGameCenterLeaderboardExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupsGetCollectionFieldsGameCenterLeaderboard value)
        {
            return value switch
            {
                GameCenterGroupsGetCollectionFieldsGameCenterLeaderboard.Activity => "activity",
                GameCenterGroupsGetCollectionFieldsGameCenterLeaderboard.ActivityProperties => "activityProperties",
                GameCenterGroupsGetCollectionFieldsGameCenterLeaderboard.Archived => "archived",
                GameCenterGroupsGetCollectionFieldsGameCenterLeaderboard.Challenge => "challenge",
                GameCenterGroupsGetCollectionFieldsGameCenterLeaderboard.DefaultFormatter => "defaultFormatter",
                GameCenterGroupsGetCollectionFieldsGameCenterLeaderboard.GameCenterDetail => "gameCenterDetail",
                GameCenterGroupsGetCollectionFieldsGameCenterLeaderboard.GameCenterGroup => "gameCenterGroup",
                GameCenterGroupsGetCollectionFieldsGameCenterLeaderboard.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                GameCenterGroupsGetCollectionFieldsGameCenterLeaderboard.GroupLeaderboard => "groupLeaderboard",
                GameCenterGroupsGetCollectionFieldsGameCenterLeaderboard.Localizations => "localizations",
                GameCenterGroupsGetCollectionFieldsGameCenterLeaderboard.RecurrenceDuration => "recurrenceDuration",
                GameCenterGroupsGetCollectionFieldsGameCenterLeaderboard.RecurrenceRule => "recurrenceRule",
                GameCenterGroupsGetCollectionFieldsGameCenterLeaderboard.RecurrenceStartDate => "recurrenceStartDate",
                GameCenterGroupsGetCollectionFieldsGameCenterLeaderboard.ReferenceName => "referenceName",
                GameCenterGroupsGetCollectionFieldsGameCenterLeaderboard.Releases => "releases",
                GameCenterGroupsGetCollectionFieldsGameCenterLeaderboard.ScoreRangeEnd => "scoreRangeEnd",
                GameCenterGroupsGetCollectionFieldsGameCenterLeaderboard.ScoreRangeStart => "scoreRangeStart",
                GameCenterGroupsGetCollectionFieldsGameCenterLeaderboard.ScoreSortType => "scoreSortType",
                GameCenterGroupsGetCollectionFieldsGameCenterLeaderboard.SubmissionType => "submissionType",
                GameCenterGroupsGetCollectionFieldsGameCenterLeaderboard.VendorIdentifier => "vendorIdentifier",
                GameCenterGroupsGetCollectionFieldsGameCenterLeaderboard.Versions => "versions",
                GameCenterGroupsGetCollectionFieldsGameCenterLeaderboard.Visibility => "visibility",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupsGetCollectionFieldsGameCenterLeaderboard? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterGroupsGetCollectionFieldsGameCenterLeaderboard.Activity,
                "activityProperties" => GameCenterGroupsGetCollectionFieldsGameCenterLeaderboard.ActivityProperties,
                "archived" => GameCenterGroupsGetCollectionFieldsGameCenterLeaderboard.Archived,
                "challenge" => GameCenterGroupsGetCollectionFieldsGameCenterLeaderboard.Challenge,
                "defaultFormatter" => GameCenterGroupsGetCollectionFieldsGameCenterLeaderboard.DefaultFormatter,
                "gameCenterDetail" => GameCenterGroupsGetCollectionFieldsGameCenterLeaderboard.GameCenterDetail,
                "gameCenterGroup" => GameCenterGroupsGetCollectionFieldsGameCenterLeaderboard.GameCenterGroup,
                "gameCenterLeaderboardSets" => GameCenterGroupsGetCollectionFieldsGameCenterLeaderboard.GameCenterLeaderboardSets,
                "groupLeaderboard" => GameCenterGroupsGetCollectionFieldsGameCenterLeaderboard.GroupLeaderboard,
                "localizations" => GameCenterGroupsGetCollectionFieldsGameCenterLeaderboard.Localizations,
                "recurrenceDuration" => GameCenterGroupsGetCollectionFieldsGameCenterLeaderboard.RecurrenceDuration,
                "recurrenceRule" => GameCenterGroupsGetCollectionFieldsGameCenterLeaderboard.RecurrenceRule,
                "recurrenceStartDate" => GameCenterGroupsGetCollectionFieldsGameCenterLeaderboard.RecurrenceStartDate,
                "referenceName" => GameCenterGroupsGetCollectionFieldsGameCenterLeaderboard.ReferenceName,
                "releases" => GameCenterGroupsGetCollectionFieldsGameCenterLeaderboard.Releases,
                "scoreRangeEnd" => GameCenterGroupsGetCollectionFieldsGameCenterLeaderboard.ScoreRangeEnd,
                "scoreRangeStart" => GameCenterGroupsGetCollectionFieldsGameCenterLeaderboard.ScoreRangeStart,
                "scoreSortType" => GameCenterGroupsGetCollectionFieldsGameCenterLeaderboard.ScoreSortType,
                "submissionType" => GameCenterGroupsGetCollectionFieldsGameCenterLeaderboard.SubmissionType,
                "vendorIdentifier" => GameCenterGroupsGetCollectionFieldsGameCenterLeaderboard.VendorIdentifier,
                "versions" => GameCenterGroupsGetCollectionFieldsGameCenterLeaderboard.Versions,
                "visibility" => GameCenterGroupsGetCollectionFieldsGameCenterLeaderboard.Visibility,
                _ => null,
            };
        }
    }
}