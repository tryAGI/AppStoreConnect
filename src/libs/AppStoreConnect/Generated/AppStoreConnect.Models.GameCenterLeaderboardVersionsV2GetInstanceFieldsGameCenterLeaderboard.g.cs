
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardVersionsV2GetInstanceFieldsGameCenterLeaderboard
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
    public static class GameCenterLeaderboardVersionsV2GetInstanceFieldsGameCenterLeaderboardExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardVersionsV2GetInstanceFieldsGameCenterLeaderboard value)
        {
            return value switch
            {
                GameCenterLeaderboardVersionsV2GetInstanceFieldsGameCenterLeaderboard.Activity => "activity",
                GameCenterLeaderboardVersionsV2GetInstanceFieldsGameCenterLeaderboard.ActivityProperties => "activityProperties",
                GameCenterLeaderboardVersionsV2GetInstanceFieldsGameCenterLeaderboard.Archived => "archived",
                GameCenterLeaderboardVersionsV2GetInstanceFieldsGameCenterLeaderboard.Challenge => "challenge",
                GameCenterLeaderboardVersionsV2GetInstanceFieldsGameCenterLeaderboard.DefaultFormatter => "defaultFormatter",
                GameCenterLeaderboardVersionsV2GetInstanceFieldsGameCenterLeaderboard.GameCenterDetail => "gameCenterDetail",
                GameCenterLeaderboardVersionsV2GetInstanceFieldsGameCenterLeaderboard.GameCenterGroup => "gameCenterGroup",
                GameCenterLeaderboardVersionsV2GetInstanceFieldsGameCenterLeaderboard.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                GameCenterLeaderboardVersionsV2GetInstanceFieldsGameCenterLeaderboard.RecurrenceDuration => "recurrenceDuration",
                GameCenterLeaderboardVersionsV2GetInstanceFieldsGameCenterLeaderboard.RecurrenceRule => "recurrenceRule",
                GameCenterLeaderboardVersionsV2GetInstanceFieldsGameCenterLeaderboard.RecurrenceStartDate => "recurrenceStartDate",
                GameCenterLeaderboardVersionsV2GetInstanceFieldsGameCenterLeaderboard.ReferenceName => "referenceName",
                GameCenterLeaderboardVersionsV2GetInstanceFieldsGameCenterLeaderboard.ScoreRangeEnd => "scoreRangeEnd",
                GameCenterLeaderboardVersionsV2GetInstanceFieldsGameCenterLeaderboard.ScoreRangeStart => "scoreRangeStart",
                GameCenterLeaderboardVersionsV2GetInstanceFieldsGameCenterLeaderboard.ScoreSortType => "scoreSortType",
                GameCenterLeaderboardVersionsV2GetInstanceFieldsGameCenterLeaderboard.SubmissionType => "submissionType",
                GameCenterLeaderboardVersionsV2GetInstanceFieldsGameCenterLeaderboard.VendorIdentifier => "vendorIdentifier",
                GameCenterLeaderboardVersionsV2GetInstanceFieldsGameCenterLeaderboard.Versions => "versions",
                GameCenterLeaderboardVersionsV2GetInstanceFieldsGameCenterLeaderboard.Visibility => "visibility",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardVersionsV2GetInstanceFieldsGameCenterLeaderboard? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterLeaderboardVersionsV2GetInstanceFieldsGameCenterLeaderboard.Activity,
                "activityProperties" => GameCenterLeaderboardVersionsV2GetInstanceFieldsGameCenterLeaderboard.ActivityProperties,
                "archived" => GameCenterLeaderboardVersionsV2GetInstanceFieldsGameCenterLeaderboard.Archived,
                "challenge" => GameCenterLeaderboardVersionsV2GetInstanceFieldsGameCenterLeaderboard.Challenge,
                "defaultFormatter" => GameCenterLeaderboardVersionsV2GetInstanceFieldsGameCenterLeaderboard.DefaultFormatter,
                "gameCenterDetail" => GameCenterLeaderboardVersionsV2GetInstanceFieldsGameCenterLeaderboard.GameCenterDetail,
                "gameCenterGroup" => GameCenterLeaderboardVersionsV2GetInstanceFieldsGameCenterLeaderboard.GameCenterGroup,
                "gameCenterLeaderboardSets" => GameCenterLeaderboardVersionsV2GetInstanceFieldsGameCenterLeaderboard.GameCenterLeaderboardSets,
                "recurrenceDuration" => GameCenterLeaderboardVersionsV2GetInstanceFieldsGameCenterLeaderboard.RecurrenceDuration,
                "recurrenceRule" => GameCenterLeaderboardVersionsV2GetInstanceFieldsGameCenterLeaderboard.RecurrenceRule,
                "recurrenceStartDate" => GameCenterLeaderboardVersionsV2GetInstanceFieldsGameCenterLeaderboard.RecurrenceStartDate,
                "referenceName" => GameCenterLeaderboardVersionsV2GetInstanceFieldsGameCenterLeaderboard.ReferenceName,
                "scoreRangeEnd" => GameCenterLeaderboardVersionsV2GetInstanceFieldsGameCenterLeaderboard.ScoreRangeEnd,
                "scoreRangeStart" => GameCenterLeaderboardVersionsV2GetInstanceFieldsGameCenterLeaderboard.ScoreRangeStart,
                "scoreSortType" => GameCenterLeaderboardVersionsV2GetInstanceFieldsGameCenterLeaderboard.ScoreSortType,
                "submissionType" => GameCenterLeaderboardVersionsV2GetInstanceFieldsGameCenterLeaderboard.SubmissionType,
                "vendorIdentifier" => GameCenterLeaderboardVersionsV2GetInstanceFieldsGameCenterLeaderboard.VendorIdentifier,
                "versions" => GameCenterLeaderboardVersionsV2GetInstanceFieldsGameCenterLeaderboard.Versions,
                "visibility" => GameCenterLeaderboardVersionsV2GetInstanceFieldsGameCenterLeaderboard.Visibility,
                _ => null,
            };
        }
    }
}