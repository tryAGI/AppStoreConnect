
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard
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
    public static class GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboardExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard value)
        {
            return value switch
            {
                GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.Activity => "activity",
                GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.ActivityProperties => "activityProperties",
                GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.Archived => "archived",
                GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.Challenge => "challenge",
                GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.DefaultFormatter => "defaultFormatter",
                GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.GameCenterDetail => "gameCenterDetail",
                GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.GameCenterGroup => "gameCenterGroup",
                GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.GroupLeaderboard => "groupLeaderboard",
                GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.Localizations => "localizations",
                GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.RecurrenceDuration => "recurrenceDuration",
                GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.RecurrenceRule => "recurrenceRule",
                GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.RecurrenceStartDate => "recurrenceStartDate",
                GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.ReferenceName => "referenceName",
                GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.Releases => "releases",
                GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.ScoreRangeEnd => "scoreRangeEnd",
                GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.ScoreRangeStart => "scoreRangeStart",
                GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.ScoreSortType => "scoreSortType",
                GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.SubmissionType => "submissionType",
                GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.VendorIdentifier => "vendorIdentifier",
                GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.Versions => "versions",
                GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.Visibility => "visibility",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.Activity,
                "activityProperties" => GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.ActivityProperties,
                "archived" => GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.Archived,
                "challenge" => GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.Challenge,
                "defaultFormatter" => GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.DefaultFormatter,
                "gameCenterDetail" => GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.GameCenterDetail,
                "gameCenterGroup" => GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.GameCenterGroup,
                "gameCenterLeaderboardSets" => GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.GameCenterLeaderboardSets,
                "groupLeaderboard" => GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.GroupLeaderboard,
                "localizations" => GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.Localizations,
                "recurrenceDuration" => GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.RecurrenceDuration,
                "recurrenceRule" => GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.RecurrenceRule,
                "recurrenceStartDate" => GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.RecurrenceStartDate,
                "referenceName" => GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.ReferenceName,
                "releases" => GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.Releases,
                "scoreRangeEnd" => GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.ScoreRangeEnd,
                "scoreRangeStart" => GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.ScoreRangeStart,
                "scoreSortType" => GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.ScoreSortType,
                "submissionType" => GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.SubmissionType,
                "vendorIdentifier" => GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.VendorIdentifier,
                "versions" => GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.Versions,
                "visibility" => GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard.Visibility,
                _ => null,
            };
        }
    }
}