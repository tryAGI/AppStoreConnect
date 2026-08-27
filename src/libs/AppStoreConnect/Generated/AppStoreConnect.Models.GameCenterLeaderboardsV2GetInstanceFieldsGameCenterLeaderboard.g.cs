
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardsV2GetInstanceFieldsGameCenterLeaderboard
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
    public static class GameCenterLeaderboardsV2GetInstanceFieldsGameCenterLeaderboardExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardsV2GetInstanceFieldsGameCenterLeaderboard value)
        {
            return value switch
            {
                GameCenterLeaderboardsV2GetInstanceFieldsGameCenterLeaderboard.Activity => "activity",
                GameCenterLeaderboardsV2GetInstanceFieldsGameCenterLeaderboard.ActivityProperties => "activityProperties",
                GameCenterLeaderboardsV2GetInstanceFieldsGameCenterLeaderboard.Archived => "archived",
                GameCenterLeaderboardsV2GetInstanceFieldsGameCenterLeaderboard.Challenge => "challenge",
                GameCenterLeaderboardsV2GetInstanceFieldsGameCenterLeaderboard.DefaultFormatter => "defaultFormatter",
                GameCenterLeaderboardsV2GetInstanceFieldsGameCenterLeaderboard.GameCenterDetail => "gameCenterDetail",
                GameCenterLeaderboardsV2GetInstanceFieldsGameCenterLeaderboard.GameCenterGroup => "gameCenterGroup",
                GameCenterLeaderboardsV2GetInstanceFieldsGameCenterLeaderboard.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                GameCenterLeaderboardsV2GetInstanceFieldsGameCenterLeaderboard.RecurrenceDuration => "recurrenceDuration",
                GameCenterLeaderboardsV2GetInstanceFieldsGameCenterLeaderboard.RecurrenceRule => "recurrenceRule",
                GameCenterLeaderboardsV2GetInstanceFieldsGameCenterLeaderboard.RecurrenceStartDate => "recurrenceStartDate",
                GameCenterLeaderboardsV2GetInstanceFieldsGameCenterLeaderboard.ReferenceName => "referenceName",
                GameCenterLeaderboardsV2GetInstanceFieldsGameCenterLeaderboard.ScoreRangeEnd => "scoreRangeEnd",
                GameCenterLeaderboardsV2GetInstanceFieldsGameCenterLeaderboard.ScoreRangeStart => "scoreRangeStart",
                GameCenterLeaderboardsV2GetInstanceFieldsGameCenterLeaderboard.ScoreSortType => "scoreSortType",
                GameCenterLeaderboardsV2GetInstanceFieldsGameCenterLeaderboard.SubmissionType => "submissionType",
                GameCenterLeaderboardsV2GetInstanceFieldsGameCenterLeaderboard.VendorIdentifier => "vendorIdentifier",
                GameCenterLeaderboardsV2GetInstanceFieldsGameCenterLeaderboard.Versions => "versions",
                GameCenterLeaderboardsV2GetInstanceFieldsGameCenterLeaderboard.Visibility => "visibility",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardsV2GetInstanceFieldsGameCenterLeaderboard? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterLeaderboardsV2GetInstanceFieldsGameCenterLeaderboard.Activity,
                "activityProperties" => GameCenterLeaderboardsV2GetInstanceFieldsGameCenterLeaderboard.ActivityProperties,
                "archived" => GameCenterLeaderboardsV2GetInstanceFieldsGameCenterLeaderboard.Archived,
                "challenge" => GameCenterLeaderboardsV2GetInstanceFieldsGameCenterLeaderboard.Challenge,
                "defaultFormatter" => GameCenterLeaderboardsV2GetInstanceFieldsGameCenterLeaderboard.DefaultFormatter,
                "gameCenterDetail" => GameCenterLeaderboardsV2GetInstanceFieldsGameCenterLeaderboard.GameCenterDetail,
                "gameCenterGroup" => GameCenterLeaderboardsV2GetInstanceFieldsGameCenterLeaderboard.GameCenterGroup,
                "gameCenterLeaderboardSets" => GameCenterLeaderboardsV2GetInstanceFieldsGameCenterLeaderboard.GameCenterLeaderboardSets,
                "recurrenceDuration" => GameCenterLeaderboardsV2GetInstanceFieldsGameCenterLeaderboard.RecurrenceDuration,
                "recurrenceRule" => GameCenterLeaderboardsV2GetInstanceFieldsGameCenterLeaderboard.RecurrenceRule,
                "recurrenceStartDate" => GameCenterLeaderboardsV2GetInstanceFieldsGameCenterLeaderboard.RecurrenceStartDate,
                "referenceName" => GameCenterLeaderboardsV2GetInstanceFieldsGameCenterLeaderboard.ReferenceName,
                "scoreRangeEnd" => GameCenterLeaderboardsV2GetInstanceFieldsGameCenterLeaderboard.ScoreRangeEnd,
                "scoreRangeStart" => GameCenterLeaderboardsV2GetInstanceFieldsGameCenterLeaderboard.ScoreRangeStart,
                "scoreSortType" => GameCenterLeaderboardsV2GetInstanceFieldsGameCenterLeaderboard.ScoreSortType,
                "submissionType" => GameCenterLeaderboardsV2GetInstanceFieldsGameCenterLeaderboard.SubmissionType,
                "vendorIdentifier" => GameCenterLeaderboardsV2GetInstanceFieldsGameCenterLeaderboard.VendorIdentifier,
                "versions" => GameCenterLeaderboardsV2GetInstanceFieldsGameCenterLeaderboard.Versions,
                "visibility" => GameCenterLeaderboardsV2GetInstanceFieldsGameCenterLeaderboard.Visibility,
                _ => null,
            };
        }
    }
}