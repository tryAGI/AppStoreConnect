
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardV2AttributesSubmissionType
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
    public static class GameCenterLeaderboardV2AttributesSubmissionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardV2AttributesSubmissionType value)
        {
            return value switch
            {
                GameCenterLeaderboardV2AttributesSubmissionType.BestScore => "BEST_SCORE",
                GameCenterLeaderboardV2AttributesSubmissionType.MostRecentScore => "MOST_RECENT_SCORE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardV2AttributesSubmissionType? ToEnum(string value)
        {
            return value switch
            {
                "BEST_SCORE" => GameCenterLeaderboardV2AttributesSubmissionType.BestScore,
                "MOST_RECENT_SCORE" => GameCenterLeaderboardV2AttributesSubmissionType.MostRecentScore,
                _ => null,
            };
        }
    }
}