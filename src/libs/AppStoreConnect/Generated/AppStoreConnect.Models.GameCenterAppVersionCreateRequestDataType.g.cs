
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAppVersionCreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterAppVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterAppVersionCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAppVersionCreateRequestDataType value)
        {
            return value switch
            {
                GameCenterAppVersionCreateRequestDataType.GameCenterAppVersions => "gameCenterAppVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAppVersionCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAppVersions" => GameCenterAppVersionCreateRequestDataType.GameCenterAppVersions,
                _ => null,
            };
        }
    }
}