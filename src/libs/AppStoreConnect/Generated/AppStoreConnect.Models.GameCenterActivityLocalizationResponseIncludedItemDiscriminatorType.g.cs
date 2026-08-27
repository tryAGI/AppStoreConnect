
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterActivityLocalizationResponseIncludedItemDiscriminatorType
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
    public static class GameCenterActivityLocalizationResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterActivityLocalizationResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                GameCenterActivityLocalizationResponseIncludedItemDiscriminatorType.GameCenterActivityImages => "gameCenterActivityImages",
                GameCenterActivityLocalizationResponseIncludedItemDiscriminatorType.GameCenterActivityVersions => "gameCenterActivityVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterActivityLocalizationResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterActivityImages" => GameCenterActivityLocalizationResponseIncludedItemDiscriminatorType.GameCenterActivityImages,
                "gameCenterActivityVersions" => GameCenterActivityLocalizationResponseIncludedItemDiscriminatorType.GameCenterActivityVersions,
                _ => null,
            };
        }
    }
}