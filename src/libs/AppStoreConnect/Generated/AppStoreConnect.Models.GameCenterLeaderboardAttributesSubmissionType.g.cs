
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardAttributesSubmissionType
    {
        /// <summary>
        ///
        /// </summary>
        BestScore,
        /// <summary>
        ///
        /// </summary>
        MostRecentScore,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardAttributesSubmissionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardAttributesSubmissionType value)
        {
            return value switch
            {
                GameCenterLeaderboardAttributesSubmissionType.BestScore => "BEST_SCORE",
                GameCenterLeaderboardAttributesSubmissionType.MostRecentScore => "MOST_RECENT_SCORE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardAttributesSubmissionType? ToEnum(string value)
        {
            return value switch
            {
                "BEST_SCORE" => GameCenterLeaderboardAttributesSubmissionType.BestScore,
                "MOST_RECENT_SCORE" => GameCenterLeaderboardAttributesSubmissionType.MostRecentScore,
                _ => null,
            };
        }
    }
}