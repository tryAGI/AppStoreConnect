
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterEnabledVersionType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterEnabledVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterEnabledVersionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterEnabledVersionType value)
        {
            return value switch
            {
                GameCenterEnabledVersionType.GameCenterEnabledVersions => "gameCenterEnabledVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterEnabledVersionType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterEnabledVersions" => GameCenterEnabledVersionType.GameCenterEnabledVersions,
                _ => null,
            };
        }
    }
}