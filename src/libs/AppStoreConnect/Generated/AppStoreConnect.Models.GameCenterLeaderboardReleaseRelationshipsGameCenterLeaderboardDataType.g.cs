
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardReleaseRelationshipsGameCenterLeaderboardDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboards,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardReleaseRelationshipsGameCenterLeaderboardDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardReleaseRelationshipsGameCenterLeaderboardDataType value)
        {
            return value switch
            {
                GameCenterLeaderboardReleaseRelationshipsGameCenterLeaderboardDataType.GameCenterLeaderboards => "gameCenterLeaderboards",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardReleaseRelationshipsGameCenterLeaderboardDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboards" => GameCenterLeaderboardReleaseRelationshipsGameCenterLeaderboardDataType.GameCenterLeaderboards,
                _ => null,
            };
        }
    }
}