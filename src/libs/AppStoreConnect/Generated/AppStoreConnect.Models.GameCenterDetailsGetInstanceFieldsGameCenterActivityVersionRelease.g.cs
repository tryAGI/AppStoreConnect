
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterDetailsGetInstanceFieldsGameCenterActivityVersionRelease
    {
        /// <summary>
        /// 
        /// </summary>
        Version,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterDetailsGetInstanceFieldsGameCenterActivityVersionReleaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsGetInstanceFieldsGameCenterActivityVersionRelease value)
        {
            return value switch
            {
                GameCenterDetailsGetInstanceFieldsGameCenterActivityVersionRelease.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsGetInstanceFieldsGameCenterActivityVersionRelease? ToEnum(string value)
        {
            return value switch
            {
                "version" => GameCenterDetailsGetInstanceFieldsGameCenterActivityVersionRelease.Version,
                _ => null,
            };
        }
    }
}