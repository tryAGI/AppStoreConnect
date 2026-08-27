
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterDetailRelationshipsAppDataType
    {
        /// <summary>
        ///
        /// </summary>
        Apps,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterDetailRelationshipsAppDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailRelationshipsAppDataType value)
        {
            return value switch
            {
                GameCenterDetailRelationshipsAppDataType.Apps => "apps",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailRelationshipsAppDataType? ToEnum(string value)
        {
            return value switch
            {
                "apps" => GameCenterDetailRelationshipsAppDataType.Apps,
                _ => null,
            };
        }
    }
}