
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardEntrySubmissionCreateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterLeaderboardEntrySubmissions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardEntrySubmissionCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardEntrySubmissionCreateRequestDataType value)
        {
            return value switch
            {
                GameCenterLeaderboardEntrySubmissionCreateRequestDataType.GameCenterLeaderboardEntrySubmissions => "gameCenterLeaderboardEntrySubmissions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardEntrySubmissionCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardEntrySubmissions" => GameCenterLeaderboardEntrySubmissionCreateRequestDataType.GameCenterLeaderboardEntrySubmissions,
                _ => null,
            };
        }
    }
}