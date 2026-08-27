
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterActivityLocalizationsGetInstanceIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Version,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterActivityLocalizationsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterActivityLocalizationsGetInstanceIncludeItem value)
        {
            return value switch
            {
                GameCenterActivityLocalizationsGetInstanceIncludeItem.Image => "image",
                GameCenterActivityLocalizationsGetInstanceIncludeItem.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterActivityLocalizationsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "image" => GameCenterActivityLocalizationsGetInstanceIncludeItem.Image,
                "version" => GameCenterActivityLocalizationsGetInstanceIncludeItem.Version,
                _ => null,
            };
        }
    }
}