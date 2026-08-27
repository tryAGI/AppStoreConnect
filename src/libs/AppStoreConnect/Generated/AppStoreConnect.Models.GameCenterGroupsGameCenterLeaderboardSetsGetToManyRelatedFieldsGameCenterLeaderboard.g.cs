
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard
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
    public static class GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboardExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard value)
        {
            return value switch
            {
                GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.Activity => "activity",
                GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.ActivityProperties => "activityProperties",
                GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.Archived => "archived",
                GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.Challenge => "challenge",
                GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.DefaultFormatter => "defaultFormatter",
                GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.GameCenterDetail => "gameCenterDetail",
                GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.GameCenterGroup => "gameCenterGroup",
                GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.GroupLeaderboard => "groupLeaderboard",
                GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.Localizations => "localizations",
                GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.RecurrenceDuration => "recurrenceDuration",
                GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.RecurrenceRule => "recurrenceRule",
                GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.RecurrenceStartDate => "recurrenceStartDate",
                GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.ReferenceName => "referenceName",
                GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.Releases => "releases",
                GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.ScoreRangeEnd => "scoreRangeEnd",
                GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.ScoreRangeStart => "scoreRangeStart",
                GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.ScoreSortType => "scoreSortType",
                GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.SubmissionType => "submissionType",
                GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.VendorIdentifier => "vendorIdentifier",
                GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.Visibility => "visibility",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.Activity,
                "activityProperties" => GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.ActivityProperties,
                "archived" => GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.Archived,
                "challenge" => GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.Challenge,
                "defaultFormatter" => GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.DefaultFormatter,
                "gameCenterDetail" => GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.GameCenterDetail,
                "gameCenterGroup" => GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.GameCenterGroup,
                "gameCenterLeaderboardSets" => GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.GameCenterLeaderboardSets,
                "groupLeaderboard" => GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.GroupLeaderboard,
                "localizations" => GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.Localizations,
                "recurrenceDuration" => GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.RecurrenceDuration,
                "recurrenceRule" => GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.RecurrenceRule,
                "recurrenceStartDate" => GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.RecurrenceStartDate,
                "referenceName" => GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.ReferenceName,
                "releases" => GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.Releases,
                "scoreRangeEnd" => GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.ScoreRangeEnd,
                "scoreRangeStart" => GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.ScoreRangeStart,
                "scoreSortType" => GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.ScoreSortType,
                "submissionType" => GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.SubmissionType,
                "vendorIdentifier" => GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.VendorIdentifier,
                "visibility" => GameCenterGroupsGameCenterLeaderboardSetsGetToManyRelatedFieldsGameCenterLeaderboard.Visibility,
                _ => null,
            };
        }
    }
}