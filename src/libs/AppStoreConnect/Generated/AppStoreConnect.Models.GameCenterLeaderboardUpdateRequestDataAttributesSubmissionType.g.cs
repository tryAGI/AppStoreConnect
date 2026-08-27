
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardUpdateRequestDataAttributesSubmissionType
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
    public static class GameCenterLeaderboardUpdateRequestDataAttributesSubmissionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardUpdateRequestDataAttributesSubmissionType value)
        {
            return value switch
            {
                GameCenterLeaderboardUpdateRequestDataAttributesSubmissionType.BestScore => "BEST_SCORE",
                GameCenterLeaderboardUpdateRequestDataAttributesSubmissionType.MostRecentScore => "MOST_RECENT_SCORE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardUpdateRequestDataAttributesSubmissionType? ToEnum(string value)
        {
            return value switch
            {
                "BEST_SCORE" => GameCenterLeaderboardUpdateRequestDataAttributesSubmissionType.BestScore,
                "MOST_RECENT_SCORE" => GameCenterLeaderboardUpdateRequestDataAttributesSubmissionType.MostRecentScore,
                _ => null,
            };
        }
    }
}