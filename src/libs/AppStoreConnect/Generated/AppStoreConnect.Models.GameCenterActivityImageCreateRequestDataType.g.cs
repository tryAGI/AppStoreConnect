
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterActivityImageCreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterActivityImages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterActivityImageCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterActivityImageCreateRequestDataType value)
        {
            return value switch
            {
                GameCenterActivityImageCreateRequestDataType.GameCenterActivityImages => "gameCenterActivityImages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterActivityImageCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterActivityImages" => GameCenterActivityImageCreateRequestDataType.GameCenterActivityImages,
                _ => null,
            };
        }
    }
}