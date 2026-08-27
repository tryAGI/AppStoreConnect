
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterAppVersionUpdateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterAppVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterAppVersionUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAppVersionUpdateRequestDataType value)
        {
            return value switch
            {
                GameCenterAppVersionUpdateRequestDataType.GameCenterAppVersions => "gameCenterAppVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAppVersionUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAppVersions" => GameCenterAppVersionUpdateRequestDataType.GameCenterAppVersions,
                _ => null,
            };
        }
    }
}