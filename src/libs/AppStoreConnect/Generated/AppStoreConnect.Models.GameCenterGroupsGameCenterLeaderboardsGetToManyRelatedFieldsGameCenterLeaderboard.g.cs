
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard
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
    public static class GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboardExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard value)
        {
            return value switch
            {
                GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard.Activity => "activity",
                GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard.ActivityProperties => "activityProperties",
                GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard.Archived => "archived",
                GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard.Challenge => "challenge",
                GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard.DefaultFormatter => "defaultFormatter",
                GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard.GameCenterDetail => "gameCenterDetail",
                GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard.GameCenterGroup => "gameCenterGroup",
                GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard.GroupLeaderboard => "groupLeaderboard",
                GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard.Localizations => "localizations",
                GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard.RecurrenceDuration => "recurrenceDuration",
                GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard.RecurrenceRule => "recurrenceRule",
                GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard.RecurrenceStartDate => "recurrenceStartDate",
                GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard.ReferenceName => "referenceName",
                GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard.Releases => "releases",
                GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard.ScoreRangeEnd => "scoreRangeEnd",
                GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard.ScoreRangeStart => "scoreRangeStart",
                GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard.ScoreSortType => "scoreSortType",
                GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard.SubmissionType => "submissionType",
                GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard.VendorIdentifier => "vendorIdentifier",
                GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard.Visibility => "visibility",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard.Activity,
                "activityProperties" => GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard.ActivityProperties,
                "archived" => GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard.Archived,
                "challenge" => GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard.Challenge,
                "defaultFormatter" => GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard.DefaultFormatter,
                "gameCenterDetail" => GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard.GameCenterDetail,
                "gameCenterGroup" => GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard.GameCenterGroup,
                "gameCenterLeaderboardSets" => GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard.GameCenterLeaderboardSets,
                "groupLeaderboard" => GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard.GroupLeaderboard,
                "localizations" => GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard.Localizations,
                "recurrenceDuration" => GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard.RecurrenceDuration,
                "recurrenceRule" => GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard.RecurrenceRule,
                "recurrenceStartDate" => GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard.RecurrenceStartDate,
                "referenceName" => GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard.ReferenceName,
                "releases" => GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard.Releases,
                "scoreRangeEnd" => GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard.ScoreRangeEnd,
                "scoreRangeStart" => GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard.ScoreRangeStart,
                "scoreSortType" => GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard.ScoreSortType,
                "submissionType" => GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard.SubmissionType,
                "vendorIdentifier" => GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard.VendorIdentifier,
                "visibility" => GameCenterGroupsGameCenterLeaderboardsGetToManyRelatedFieldsGameCenterLeaderboard.Visibility,
                _ => null,
            };
        }
    }
}