
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterActivityCreateRequestDataRelationshipsGameCenterGroupDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterGroups,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterActivityCreateRequestDataRelationshipsGameCenterGroupDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterActivityCreateRequestDataRelationshipsGameCenterGroupDataType value)
        {
            return value switch
            {
                GameCenterActivityCreateRequestDataRelationshipsGameCenterGroupDataType.GameCenterGroups => "gameCenterGroups",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterActivityCreateRequestDataRelationshipsGameCenterGroupDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterGroups" => GameCenterActivityCreateRequestDataRelationshipsGameCenterGroupDataType.GameCenterGroups,
                _ => null,
            };
        }
    }
}