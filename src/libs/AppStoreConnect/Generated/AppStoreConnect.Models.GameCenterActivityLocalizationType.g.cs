
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterActivityLocalizationType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterActivityLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterActivityLocalizationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterActivityLocalizationType value)
        {
            return value switch
            {
                GameCenterActivityLocalizationType.GameCenterActivityLocalizations => "gameCenterActivityLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterActivityLocalizationType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterActivityLocalizations" => GameCenterActivityLocalizationType.GameCenterActivityLocalizations,
                _ => null,
            };
        }
    }
}