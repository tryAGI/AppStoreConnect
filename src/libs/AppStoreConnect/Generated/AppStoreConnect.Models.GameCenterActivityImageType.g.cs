
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterActivityImageType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterActivityImages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterActivityImageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterActivityImageType value)
        {
            return value switch
            {
                GameCenterActivityImageType.GameCenterActivityImages => "gameCenterActivityImages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterActivityImageType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterActivityImages" => GameCenterActivityImageType.GameCenterActivityImages,
                _ => null,
            };
        }
    }
}