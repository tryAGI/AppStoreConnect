
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardRelationshipsGameCenterDetailDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterDetails,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardRelationshipsGameCenterDetailDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardRelationshipsGameCenterDetailDataType value)
        {
            return value switch
            {
                GameCenterLeaderboardRelationshipsGameCenterDetailDataType.GameCenterDetails => "gameCenterDetails",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardRelationshipsGameCenterDetailDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterDetails" => GameCenterLeaderboardRelationshipsGameCenterDetailDataType.GameCenterDetails,
                _ => null,
            };
        }
    }
}