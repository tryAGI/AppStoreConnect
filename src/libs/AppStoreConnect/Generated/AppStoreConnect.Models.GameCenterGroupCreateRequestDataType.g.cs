
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterGroupCreateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterGroups,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterGroupCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupCreateRequestDataType value)
        {
            return value switch
            {
                GameCenterGroupCreateRequestDataType.GameCenterGroups => "gameCenterGroups",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterGroups" => GameCenterGroupCreateRequestDataType.GameCenterGroups,
                _ => null,
            };
        }
    }
}