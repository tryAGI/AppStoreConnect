
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardV2RelationshipsGameCenterGroupDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterGroups,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardV2RelationshipsGameCenterGroupDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardV2RelationshipsGameCenterGroupDataType value)
        {
            return value switch
            {
                GameCenterLeaderboardV2RelationshipsGameCenterGroupDataType.GameCenterGroups => "gameCenterGroups",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardV2RelationshipsGameCenterGroupDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterGroups" => GameCenterLeaderboardV2RelationshipsGameCenterGroupDataType.GameCenterGroups,
                _ => null,
            };
        }
    }
}