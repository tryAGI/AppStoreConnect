
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAppVersionType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterAppVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterAppVersionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAppVersionType value)
        {
            return value switch
            {
                GameCenterAppVersionType.GameCenterAppVersions => "gameCenterAppVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAppVersionType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAppVersions" => GameCenterAppVersionType.GameCenterAppVersions,
                _ => null,
            };
        }
    }
}