
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardSetMemberLocalizationsGetCollectionFieldsGameCenterLeaderboard
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
    public static class GameCenterLeaderboardSetMemberLocalizationsGetCollectionFieldsGameCenterLeaderboardExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetMemberLocalizationsGetCollectionFieldsGameCenterLeaderboard value)
        {
            return value switch
            {
                GameCenterLeaderboardSetMemberLocalizationsGetCollectionFieldsGameCenterLeaderboard.Activity => "activity",
                GameCenterLeaderboardSetMemberLocalizationsGetCollectionFieldsGameCenterLeaderboard.ActivityProperties => "activityProperties",
                GameCenterLeaderboardSetMemberLocalizationsGetCollectionFieldsGameCenterLeaderboard.Archived => "archived",
                GameCenterLeaderboardSetMemberLocalizationsGetCollectionFieldsGameCenterLeaderboard.Challenge => "challenge",
                GameCenterLeaderboardSetMemberLocalizationsGetCollectionFieldsGameCenterLeaderboard.DefaultFormatter => "defaultFormatter",
                GameCenterLeaderboardSetMemberLocalizationsGetCollectionFieldsGameCenterLeaderboard.GameCenterDetail => "gameCenterDetail",
                GameCenterLeaderboardSetMemberLocalizationsGetCollectionFieldsGameCenterLeaderboard.GameCenterGroup => "gameCenterGroup",
                GameCenterLeaderboardSetMemberLocalizationsGetCollectionFieldsGameCenterLeaderboard.GameCenterLeaderboardSets => "gameCenterLeaderboardSets",
                GameCenterLeaderboardSetMemberLocalizationsGetCollectionFieldsGameCenterLeaderboard.GroupLeaderboard => "groupLeaderboard",
                GameCenterLeaderboardSetMemberLocalizationsGetCollectionFieldsGameCenterLeaderboard.Localizations => "localizations",
                GameCenterLeaderboardSetMemberLocalizationsGetCollectionFieldsGameCenterLeaderboard.RecurrenceDuration => "recurrenceDuration",
                GameCenterLeaderboardSetMemberLocalizationsGetCollectionFieldsGameCenterLeaderboard.RecurrenceRule => "recurrenceRule",
                GameCenterLeaderboardSetMemberLocalizationsGetCollectionFieldsGameCenterLeaderboard.RecurrenceStartDate => "recurrenceStartDate",
                GameCenterLeaderboardSetMemberLocalizationsGetCollectionFieldsGameCenterLeaderboard.ReferenceName => "referenceName",
                GameCenterLeaderboardSetMemberLocalizationsGetCollectionFieldsGameCenterLeaderboard.Releases => "releases",
                GameCenterLeaderboardSetMemberLocalizationsGetCollectionFieldsGameCenterLeaderboard.ScoreRangeEnd => "scoreRangeEnd",
                GameCenterLeaderboardSetMemberLocalizationsGetCollectionFieldsGameCenterLeaderboard.ScoreRangeStart => "scoreRangeStart",
                GameCenterLeaderboardSetMemberLocalizationsGetCollectionFieldsGameCenterLeaderboard.ScoreSortType => "scoreSortType",
                GameCenterLeaderboardSetMemberLocalizationsGetCollectionFieldsGameCenterLeaderboard.SubmissionType => "submissionType",
                GameCenterLeaderboardSetMemberLocalizationsGetCollectionFieldsGameCenterLeaderboard.VendorIdentifier => "vendorIdentifier",
                GameCenterLeaderboardSetMemberLocalizationsGetCollectionFieldsGameCenterLeaderboard.Visibility => "visibility",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetMemberLocalizationsGetCollectionFieldsGameCenterLeaderboard? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterLeaderboardSetMemberLocalizationsGetCollectionFieldsGameCenterLeaderboard.Activity,
                "activityProperties" => GameCenterLeaderboardSetMemberLocalizationsGetCollectionFieldsGameCenterLeaderboard.ActivityProperties,
                "archived" => GameCenterLeaderboardSetMemberLocalizationsGetCollectionFieldsGameCenterLeaderboard.Archived,
                "challenge" => GameCenterLeaderboardSetMemberLocalizationsGetCollectionFieldsGameCenterLeaderboard.Challenge,
                "defaultFormatter" => GameCenterLeaderboardSetMemberLocalizationsGetCollectionFieldsGameCenterLeaderboard.DefaultFormatter,
                "gameCenterDetail" => GameCenterLeaderboardSetMemberLocalizationsGetCollectionFieldsGameCenterLeaderboard.GameCenterDetail,
                "gameCenterGroup" => GameCenterLeaderboardSetMemberLocalizationsGetCollectionFieldsGameCenterLeaderboard.GameCenterGroup,
                "gameCenterLeaderboardSets" => GameCenterLeaderboardSetMemberLocalizationsGetCollectionFieldsGameCenterLeaderboard.GameCenterLeaderboardSets,
                "groupLeaderboard" => GameCenterLeaderboardSetMemberLocalizationsGetCollectionFieldsGameCenterLeaderboard.GroupLeaderboard,
                "localizations" => GameCenterLeaderboardSetMemberLocalizationsGetCollectionFieldsGameCenterLeaderboard.Localizations,
                "recurrenceDuration" => GameCenterLeaderboardSetMemberLocalizationsGetCollectionFieldsGameCenterLeaderboard.RecurrenceDuration,
                "recurrenceRule" => GameCenterLeaderboardSetMemberLocalizationsGetCollectionFieldsGameCenterLeaderboard.RecurrenceRule,
                "recurrenceStartDate" => GameCenterLeaderboardSetMemberLocalizationsGetCollectionFieldsGameCenterLeaderboard.RecurrenceStartDate,
                "referenceName" => GameCenterLeaderboardSetMemberLocalizationsGetCollectionFieldsGameCenterLeaderboard.ReferenceName,
                "releases" => GameCenterLeaderboardSetMemberLocalizationsGetCollectionFieldsGameCenterLeaderboard.Releases,
                "scoreRangeEnd" => GameCenterLeaderboardSetMemberLocalizationsGetCollectionFieldsGameCenterLeaderboard.ScoreRangeEnd,
                "scoreRangeStart" => GameCenterLeaderboardSetMemberLocalizationsGetCollectionFieldsGameCenterLeaderboard.ScoreRangeStart,
                "scoreSortType" => GameCenterLeaderboardSetMemberLocalizationsGetCollectionFieldsGameCenterLeaderboard.ScoreSortType,
                "submissionType" => GameCenterLeaderboardSetMemberLocalizationsGetCollectionFieldsGameCenterLeaderboard.SubmissionType,
                "vendorIdentifier" => GameCenterLeaderboardSetMemberLocalizationsGetCollectionFieldsGameCenterLeaderboard.VendorIdentifier,
                "visibility" => GameCenterLeaderboardSetMemberLocalizationsGetCollectionFieldsGameCenterLeaderboard.Visibility,
                _ => null,
            };
        }
    }
}