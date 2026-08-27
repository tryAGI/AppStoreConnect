
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterActivityVersionRelationshipsDefaultImageDataType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterActivityImages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterActivityVersionRelationshipsDefaultImageDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterActivityVersionRelationshipsDefaultImageDataType value)
        {
            return value switch
            {
                GameCenterActivityVersionRelationshipsDefaultImageDataType.GameCenterActivityImages => "gameCenterActivityImages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterActivityVersionRelationshipsDefaultImageDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterActivityImages" => GameCenterActivityVersionRelationshipsDefaultImageDataType.GameCenterActivityImages,
                _ => null,
            };
        }
    }
}