
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterActivityLocalizationsResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterActivityImages,
        /// <summary>
        /// 
        /// </summary>
        GameCenterActivityVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterActivityLocalizationsResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterActivityLocalizationsResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                GameCenterActivityLocalizationsResponseIncludedItemDiscriminatorType.GameCenterActivityImages => "gameCenterActivityImages",
                GameCenterActivityLocalizationsResponseIncludedItemDiscriminatorType.GameCenterActivityVersions => "gameCenterActivityVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterActivityLocalizationsResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterActivityImages" => GameCenterActivityLocalizationsResponseIncludedItemDiscriminatorType.GameCenterActivityImages,
                "gameCenterActivityVersions" => GameCenterActivityLocalizationsResponseIncludedItemDiscriminatorType.GameCenterActivityVersions,
                _ => null,
            };
        }
    }
}