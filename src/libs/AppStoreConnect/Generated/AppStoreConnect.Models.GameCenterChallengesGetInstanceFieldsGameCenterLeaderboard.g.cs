
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterChallengesGetInstanceFieldsGameCenterLeaderboard
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
    public static class GameCenterChallengesGetInstanceFieldsGameCenterLeaderboardExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterChallengesGetInstanceFieldsGameCenterLeaderboard value)
        {
            return value switch
            {
                GameCenterChallengesGetInstanceFieldsGameCenterLeaderboard.Activity => "activity",
                GameCenterChallengesGetInstanceFieldsGameCenterLeaderboard.ActivityProperties => "activityProperties",
                GameCenterChallengesGetInstanceFieldsGameCenterLeaderboard.Archived => "archived",
                GameCenterChallengesGetInstanceFieldsGameCenterLeaderboard.Challenge => "challenge",
                GameCenterChallengesGetInstanceFieldsGameCenterLeaderboard.DefaultFormatter => "defaultFormatter",
                GameCenterChallengesGetInstanceFieldsGameCenterLeaderboard.GameCenterDetail => "gameCenterDetail",
                GameCenterChallengesGetInstanceFieldsGameCenterLeaderboard.GameCenterGroup => "gameCenterGroup",
                GameCenterChallengesGetInstanceFieldsGameCenterLeaderboard.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                GameCenterChallengesGetInstanceFieldsGameCenterLeaderboard.GroupLeaderboard => "groupLeaderboard",
                GameCenterChallengesGetInstanceFieldsGameCenterLeaderboard.Localizations => "localizations",
                GameCenterChallengesGetInstanceFieldsGameCenterLeaderboard.RecurrenceDuration => "recurrenceDuration",
                GameCenterChallengesGetInstanceFieldsGameCenterLeaderboard.RecurrenceRule => "recurrenceRule",
                GameCenterChallengesGetInstanceFieldsGameCenterLeaderboard.RecurrenceStartDate => "recurrenceStartDate",
                GameCenterChallengesGetInstanceFieldsGameCenterLeaderboard.ReferenceName => "referenceName",
                GameCenterChallengesGetInstanceFieldsGameCenterLeaderboard.Releases => "releases",
                GameCenterChallengesGetInstanceFieldsGameCenterLeaderboard.ScoreRangeEnd => "scoreRangeEnd",
                GameCenterChallengesGetInstanceFieldsGameCenterLeaderboard.ScoreRangeStart => "scoreRangeStart",
                GameCenterChallengesGetInstanceFieldsGameCenterLeaderboard.ScoreSortType => "scoreSortType",
                GameCenterChallengesGetInstanceFieldsGameCenterLeaderboard.SubmissionType => "submissionType",
                GameCenterChallengesGetInstanceFieldsGameCenterLeaderboard.VendorIdentifier => "vendorIdentifier",
                GameCenterChallengesGetInstanceFieldsGameCenterLeaderboard.Versions => "versions",
                GameCenterChallengesGetInstanceFieldsGameCenterLeaderboard.Visibility => "visibility",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterChallengesGetInstanceFieldsGameCenterLeaderboard? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterChallengesGetInstanceFieldsGameCenterLeaderboard.Activity,
                "activityProperties" => GameCenterChallengesGetInstanceFieldsGameCenterLeaderboard.ActivityProperties,
                "archived" => GameCenterChallengesGetInstanceFieldsGameCenterLeaderboard.Archived,
                "challenge" => GameCenterChallengesGetInstanceFieldsGameCenterLeaderboard.Challenge,
                "defaultFormatter" => GameCenterChallengesGetInstanceFieldsGameCenterLeaderboard.DefaultFormatter,
                "gameCenterDetail" => GameCenterChallengesGetInstanceFieldsGameCenterLeaderboard.GameCenterDetail,
                "gameCenterGroup" => GameCenterChallengesGetInstanceFieldsGameCenterLeaderboard.GameCenterGroup,
                "gameCenterLeaderboardSets" => GameCenterChallengesGetInstanceFieldsGameCenterLeaderboard.GameCenterLeaderboardSets,
                "groupLeaderboard" => GameCenterChallengesGetInstanceFieldsGameCenterLeaderboard.GroupLeaderboard,
                "localizations" => GameCenterChallengesGetInstanceFieldsGameCenterLeaderboard.Localizations,
                "recurrenceDuration" => GameCenterChallengesGetInstanceFieldsGameCenterLeaderboard.RecurrenceDuration,
                "recurrenceRule" => GameCenterChallengesGetInstanceFieldsGameCenterLeaderboard.RecurrenceRule,
                "recurrenceStartDate" => GameCenterChallengesGetInstanceFieldsGameCenterLeaderboard.RecurrenceStartDate,
                "referenceName" => GameCenterChallengesGetInstanceFieldsGameCenterLeaderboard.ReferenceName,
                "releases" => GameCenterChallengesGetInstanceFieldsGameCenterLeaderboard.Releases,
                "scoreRangeEnd" => GameCenterChallengesGetInstanceFieldsGameCenterLeaderboard.ScoreRangeEnd,
                "scoreRangeStart" => GameCenterChallengesGetInstanceFieldsGameCenterLeaderboard.ScoreRangeStart,
                "scoreSortType" => GameCenterChallengesGetInstanceFieldsGameCenterLeaderboard.ScoreSortType,
                "submissionType" => GameCenterChallengesGetInstanceFieldsGameCenterLeaderboard.SubmissionType,
                "vendorIdentifier" => GameCenterChallengesGetInstanceFieldsGameCenterLeaderboard.VendorIdentifier,
                "versions" => GameCenterChallengesGetInstanceFieldsGameCenterLeaderboard.Versions,
                "visibility" => GameCenterChallengesGetInstanceFieldsGameCenterLeaderboard.Visibility,
                _ => null,
            };
        }
    }
}