
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterDetailUpdateRequestDataRelationshipsDefaultGroupLeaderboardDataType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterLeaderboards,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterDetailUpdateRequestDataRelationshipsDefaultGroupLeaderboardDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailUpdateRequestDataRelationshipsDefaultGroupLeaderboardDataType value)
        {
            return value switch
            {
                GameCenterDetailUpdateRequestDataRelationshipsDefaultGroupLeaderboardDataType.GameCenterLeaderboards => "gameCenterLeaderboards",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailUpdateRequestDataRelationshipsDefaultGroupLeaderboardDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboards" => GameCenterDetailUpdateRequestDataRelationshipsDefaultGroupLeaderboardDataType.GameCenterLeaderboards,
                _ => null,
            };
        }
    }
}