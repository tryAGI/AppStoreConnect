
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterDetailUpdateRequestDataRelationshipsGameCenterGroupDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterGroups,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterDetailUpdateRequestDataRelationshipsGameCenterGroupDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailUpdateRequestDataRelationshipsGameCenterGroupDataType value)
        {
            return value switch
            {
                GameCenterDetailUpdateRequestDataRelationshipsGameCenterGroupDataType.GameCenterGroups => "gameCenterGroups",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailUpdateRequestDataRelationshipsGameCenterGroupDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterGroups" => GameCenterDetailUpdateRequestDataRelationshipsGameCenterGroupDataType.GameCenterGroups,
                _ => null,
            };
        }
    }
}