
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboard
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
    public static class GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboardExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboard value)
        {
            return value switch
            {
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboard.Activity => "activity",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboard.ActivityProperties => "activityProperties",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboard.Archived => "archived",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboard.Challenge => "challenge",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboard.DefaultFormatter => "defaultFormatter",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboard.GameCenterDetail => "gameCenterDetail",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboard.GameCenterGroup => "gameCenterGroup",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboard.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboard.GroupLeaderboard => "groupLeaderboard",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboard.Localizations => "localizations",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboard.RecurrenceDuration => "recurrenceDuration",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboard.RecurrenceRule => "recurrenceRule",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboard.RecurrenceStartDate => "recurrenceStartDate",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboard.ReferenceName => "referenceName",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboard.Releases => "releases",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboard.ScoreRangeEnd => "scoreRangeEnd",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboard.ScoreRangeStart => "scoreRangeStart",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboard.ScoreSortType => "scoreSortType",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboard.SubmissionType => "submissionType",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboard.VendorIdentifier => "vendorIdentifier",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboard.Versions => "versions",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboard.Visibility => "visibility",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboard? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboard.Activity,
                "activityProperties" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboard.ActivityProperties,
                "archived" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboard.Archived,
                "challenge" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboard.Challenge,
                "defaultFormatter" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboard.DefaultFormatter,
                "gameCenterDetail" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboard.GameCenterDetail,
                "gameCenterGroup" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboard.GameCenterGroup,
                "gameCenterLeaderboardSets" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboard.GameCenterLeaderboardSets,
                "groupLeaderboard" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboard.GroupLeaderboard,
                "localizations" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboard.Localizations,
                "recurrenceDuration" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboard.RecurrenceDuration,
                "recurrenceRule" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboard.RecurrenceRule,
                "recurrenceStartDate" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboard.RecurrenceStartDate,
                "referenceName" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboard.ReferenceName,
                "releases" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboard.Releases,
                "scoreRangeEnd" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboard.ScoreRangeEnd,
                "scoreRangeStart" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboard.ScoreRangeStart,
                "scoreSortType" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboard.ScoreSortType,
                "submissionType" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboard.SubmissionType,
                "vendorIdentifier" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboard.VendorIdentifier,
                "versions" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboard.Versions,
                "visibility" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterLeaderboard.Visibility,
                _ => null,
            };
        }
    }
}