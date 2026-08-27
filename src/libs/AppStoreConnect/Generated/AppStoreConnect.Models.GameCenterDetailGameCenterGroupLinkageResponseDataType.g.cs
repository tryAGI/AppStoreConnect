
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterDetailGameCenterGroupLinkageResponseDataType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterGroups,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterDetailGameCenterGroupLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailGameCenterGroupLinkageResponseDataType value)
        {
            return value switch
            {
                GameCenterDetailGameCenterGroupLinkageResponseDataType.GameCenterGroups => "gameCenterGroups",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailGameCenterGroupLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterGroups" => GameCenterDetailGameCenterGroupLinkageResponseDataType.GameCenterGroups,
                _ => null,
            };
        }
    }
}