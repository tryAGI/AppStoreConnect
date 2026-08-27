
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterDetailRelationshipsDefaultLeaderboardDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboards,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterDetailRelationshipsDefaultLeaderboardDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailRelationshipsDefaultLeaderboardDataType value)
        {
            return value switch
            {
                GameCenterDetailRelationshipsDefaultLeaderboardDataType.GameCenterLeaderboards => "gameCenterLeaderboards",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailRelationshipsDefaultLeaderboardDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboards" => GameCenterDetailRelationshipsDefaultLeaderboardDataType.GameCenterLeaderboards,
                _ => null,
            };
        }
    }
}