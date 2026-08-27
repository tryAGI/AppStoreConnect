
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterActivityLocalizationCreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterActivityLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterActivityLocalizationCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterActivityLocalizationCreateRequestDataType value)
        {
            return value switch
            {
                GameCenterActivityLocalizationCreateRequestDataType.GameCenterActivityLocalizations => "gameCenterActivityLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterActivityLocalizationCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterActivityLocalizations" => GameCenterActivityLocalizationCreateRequestDataType.GameCenterActivityLocalizations,
                _ => null,
            };
        }
    }
}