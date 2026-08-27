
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardV2CreateRequestDataAttributesSubmissionType
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
    public static class GameCenterLeaderboardV2CreateRequestDataAttributesSubmissionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardV2CreateRequestDataAttributesSubmissionType value)
        {
            return value switch
            {
                GameCenterLeaderboardV2CreateRequestDataAttributesSubmissionType.BestScore => "BEST_SCORE",
                GameCenterLeaderboardV2CreateRequestDataAttributesSubmissionType.MostRecentScore => "MOST_RECENT_SCORE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardV2CreateRequestDataAttributesSubmissionType? ToEnum(string value)
        {
            return value switch
            {
                "BEST_SCORE" => GameCenterLeaderboardV2CreateRequestDataAttributesSubmissionType.BestScore,
                "MOST_RECENT_SCORE" => GameCenterLeaderboardV2CreateRequestDataAttributesSubmissionType.MostRecentScore,
                _ => null,
            };
        }
    }
}