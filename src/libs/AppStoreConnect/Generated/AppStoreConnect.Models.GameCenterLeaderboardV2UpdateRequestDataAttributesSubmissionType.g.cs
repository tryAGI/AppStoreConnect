
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardV2UpdateRequestDataAttributesSubmissionType
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
    public static class GameCenterLeaderboardV2UpdateRequestDataAttributesSubmissionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardV2UpdateRequestDataAttributesSubmissionType value)
        {
            return value switch
            {
                GameCenterLeaderboardV2UpdateRequestDataAttributesSubmissionType.BestScore => "BEST_SCORE",
                GameCenterLeaderboardV2UpdateRequestDataAttributesSubmissionType.MostRecentScore => "MOST_RECENT_SCORE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardV2UpdateRequestDataAttributesSubmissionType? ToEnum(string value)
        {
            return value switch
            {
                "BEST_SCORE" => GameCenterLeaderboardV2UpdateRequestDataAttributesSubmissionType.BestScore,
                "MOST_RECENT_SCORE" => GameCenterLeaderboardV2UpdateRequestDataAttributesSubmissionType.MostRecentScore,
                _ => null,
            };
        }
    }
}