
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterActivityVersionType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterActivityVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterActivityVersionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterActivityVersionType value)
        {
            return value switch
            {
                GameCenterActivityVersionType.GameCenterActivityVersions => "gameCenterActivityVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterActivityVersionType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterActivityVersions" => GameCenterActivityVersionType.GameCenterActivityVersions,
                _ => null,
            };
        }
    }
}