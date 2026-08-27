
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterActivityLocalizationRelationshipsImageDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterActivityImages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterActivityLocalizationRelationshipsImageDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterActivityLocalizationRelationshipsImageDataType value)
        {
            return value switch
            {
                GameCenterActivityLocalizationRelationshipsImageDataType.GameCenterActivityImages => "gameCenterActivityImages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterActivityLocalizationRelationshipsImageDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterActivityImages" => GameCenterActivityLocalizationRelationshipsImageDataType.GameCenterActivityImages,
                _ => null,
            };
        }
    }
}