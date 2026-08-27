
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterDetailUpdateRequestDataRelationshipsDefaultLeaderboardV2DataType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterLeaderboards,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterDetailUpdateRequestDataRelationshipsDefaultLeaderboardV2DataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailUpdateRequestDataRelationshipsDefaultLeaderboardV2DataType value)
        {
            return value switch
            {
                GameCenterDetailUpdateRequestDataRelationshipsDefaultLeaderboardV2DataType.GameCenterLeaderboards => "gameCenterLeaderboards",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailUpdateRequestDataRelationshipsDefaultLeaderboardV2DataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboards" => GameCenterDetailUpdateRequestDataRelationshipsDefaultLeaderboardV2DataType.GameCenterLeaderboards,
                _ => null,
            };
        }
    }
}