
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard
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
    public static class GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard value)
        {
            return value switch
            {
                GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.Activity => "activity",
                GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.ActivityProperties => "activityProperties",
                GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.Archived => "archived",
                GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.Challenge => "challenge",
                GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.DefaultFormatter => "defaultFormatter",
                GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.GameCenterDetail => "gameCenterDetail",
                GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.GameCenterGroup => "gameCenterGroup",
                GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.RecurrenceDuration => "recurrenceDuration",
                GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.RecurrenceRule => "recurrenceRule",
                GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.RecurrenceStartDate => "recurrenceStartDate",
                GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.ReferenceName => "referenceName",
                GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.ScoreRangeEnd => "scoreRangeEnd",
                GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.ScoreRangeStart => "scoreRangeStart",
                GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.ScoreSortType => "scoreSortType",
                GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.SubmissionType => "submissionType",
                GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.VendorIdentifier => "vendorIdentifier",
                GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.Versions => "versions",
                GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.Visibility => "visibility",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.Activity,
                "activityProperties" => GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.ActivityProperties,
                "archived" => GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.Archived,
                "challenge" => GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.Challenge,
                "defaultFormatter" => GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.DefaultFormatter,
                "gameCenterDetail" => GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.GameCenterDetail,
                "gameCenterGroup" => GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.GameCenterGroup,
                "gameCenterLeaderboardSets" => GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.GameCenterLeaderboardSets,
                "recurrenceDuration" => GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.RecurrenceDuration,
                "recurrenceRule" => GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.RecurrenceRule,
                "recurrenceStartDate" => GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.RecurrenceStartDate,
                "referenceName" => GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.ReferenceName,
                "scoreRangeEnd" => GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.ScoreRangeEnd,
                "scoreRangeStart" => GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.ScoreRangeStart,
                "scoreSortType" => GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.ScoreSortType,
                "submissionType" => GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.SubmissionType,
                "vendorIdentifier" => GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.VendorIdentifier,
                "versions" => GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.Versions,
                "visibility" => GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboard.Visibility,
                _ => null,
            };
        }
    }
}