
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterDetailUpdateRequestDataRelationshipsDefaultGroupLeaderboardV2DataType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterLeaderboards,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterDetailUpdateRequestDataRelationshipsDefaultGroupLeaderboardV2DataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailUpdateRequestDataRelationshipsDefaultGroupLeaderboardV2DataType value)
        {
            return value switch
            {
                GameCenterDetailUpdateRequestDataRelationshipsDefaultGroupLeaderboardV2DataType.GameCenterLeaderboards => "gameCenterLeaderboards",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailUpdateRequestDataRelationshipsDefaultGroupLeaderboardV2DataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboards" => GameCenterDetailUpdateRequestDataRelationshipsDefaultGroupLeaderboardV2DataType.GameCenterLeaderboards,
                _ => null,
            };
        }
    }
}