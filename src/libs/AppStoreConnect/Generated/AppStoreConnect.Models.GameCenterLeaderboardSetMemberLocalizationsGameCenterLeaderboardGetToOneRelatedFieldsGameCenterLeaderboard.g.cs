
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard
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
    public static class GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboardExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard value)
        {
            return value switch
            {
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.Activity => "activity",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.ActivityProperties => "activityProperties",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.Archived => "archived",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.Challenge => "challenge",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.DefaultFormatter => "defaultFormatter",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.GameCenterDetail => "gameCenterDetail",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.GameCenterGroup => "gameCenterGroup",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.GroupLeaderboard => "groupLeaderboard",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.Localizations => "localizations",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.RecurrenceDuration => "recurrenceDuration",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.RecurrenceRule => "recurrenceRule",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.RecurrenceStartDate => "recurrenceStartDate",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.ReferenceName => "referenceName",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.Releases => "releases",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.ScoreRangeEnd => "scoreRangeEnd",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.ScoreRangeStart => "scoreRangeStart",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.ScoreSortType => "scoreSortType",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.SubmissionType => "submissionType",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.VendorIdentifier => "vendorIdentifier",
                GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.Visibility => "visibility",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.Activity,
                "activityProperties" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.ActivityProperties,
                "archived" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.Archived,
                "challenge" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.Challenge,
                "defaultFormatter" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.DefaultFormatter,
                "gameCenterDetail" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.GameCenterDetail,
                "gameCenterGroup" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.GameCenterGroup,
                "gameCenterLeaderboardSets" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.GameCenterLeaderboardSets,
                "groupLeaderboard" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.GroupLeaderboard,
                "localizations" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.Localizations,
                "recurrenceDuration" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.RecurrenceDuration,
                "recurrenceRule" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.RecurrenceRule,
                "recurrenceStartDate" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.RecurrenceStartDate,
                "referenceName" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.ReferenceName,
                "releases" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.Releases,
                "scoreRangeEnd" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.ScoreRangeEnd,
                "scoreRangeStart" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.ScoreRangeStart,
                "scoreSortType" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.ScoreSortType,
                "submissionType" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.SubmissionType,
                "vendorIdentifier" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.VendorIdentifier,
                "visibility" => GameCenterLeaderboardSetMemberLocalizationsGameCenterLeaderboardGetToOneRelatedFieldsGameCenterLeaderboard.Visibility,
                _ => null,
            };
        }
    }
}