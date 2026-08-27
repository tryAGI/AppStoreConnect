
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterActivityVersionReleasesGetInstanceIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        Version,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterActivityVersionReleasesGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterActivityVersionReleasesGetInstanceIncludeItem value)
        {
            return value switch
            {
                GameCenterActivityVersionReleasesGetInstanceIncludeItem.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterActivityVersionReleasesGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "version" => GameCenterActivityVersionReleasesGetInstanceIncludeItem.Version,
                _ => null,
            };
        }
    }
}