
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardEntrySubmissionType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboardEntrySubmissions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardEntrySubmissionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardEntrySubmissionType value)
        {
            return value switch
            {
                GameCenterLeaderboardEntrySubmissionType.GameCenterLeaderboardEntrySubmissions => "gameCenterLeaderboardEntrySubmissions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardEntrySubmissionType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardEntrySubmissions" => GameCenterLeaderboardEntrySubmissionType.GameCenterLeaderboardEntrySubmissions,
                _ => null,
            };
        }
    }
}