
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterActivityLocalizationImageLinkageResponseDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterActivityImages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterActivityLocalizationImageLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterActivityLocalizationImageLinkageResponseDataType value)
        {
            return value switch
            {
                GameCenterActivityLocalizationImageLinkageResponseDataType.GameCenterActivityImages => "gameCenterActivityImages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterActivityLocalizationImageLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterActivityImages" => GameCenterActivityLocalizationImageLinkageResponseDataType.GameCenterActivityImages,
                _ => null,
            };
        }
    }
}