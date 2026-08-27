
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardCreateRequestDataAttributesSubmissionType
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
    public static class GameCenterLeaderboardCreateRequestDataAttributesSubmissionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardCreateRequestDataAttributesSubmissionType value)
        {
            return value switch
            {
                GameCenterLeaderboardCreateRequestDataAttributesSubmissionType.BestScore => "BEST_SCORE",
                GameCenterLeaderboardCreateRequestDataAttributesSubmissionType.MostRecentScore => "MOST_RECENT_SCORE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardCreateRequestDataAttributesSubmissionType? ToEnum(string value)
        {
            return value switch
            {
                "BEST_SCORE" => GameCenterLeaderboardCreateRequestDataAttributesSubmissionType.BestScore,
                "MOST_RECENT_SCORE" => GameCenterLeaderboardCreateRequestDataAttributesSubmissionType.MostRecentScore,
                _ => null,
            };
        }
    }
}