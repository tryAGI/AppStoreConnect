
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterActivityLocalizationUpdateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterActivityLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterActivityLocalizationUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterActivityLocalizationUpdateRequestDataType value)
        {
            return value switch
            {
                GameCenterActivityLocalizationUpdateRequestDataType.GameCenterActivityLocalizations => "gameCenterActivityLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterActivityLocalizationUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterActivityLocalizations" => GameCenterActivityLocalizationUpdateRequestDataType.GameCenterActivityLocalizations,
                _ => null,
            };
        }
    }
}