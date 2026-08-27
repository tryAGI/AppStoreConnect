
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardVersionV2CreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboardVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardVersionV2CreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardVersionV2CreateRequestDataType value)
        {
            return value switch
            {
                GameCenterLeaderboardVersionV2CreateRequestDataType.GameCenterLeaderboardVersions => "gameCenterLeaderboardVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardVersionV2CreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardVersions" => GameCenterLeaderboardVersionV2CreateRequestDataType.GameCenterLeaderboardVersions,
                _ => null,
            };
        }
    }
}