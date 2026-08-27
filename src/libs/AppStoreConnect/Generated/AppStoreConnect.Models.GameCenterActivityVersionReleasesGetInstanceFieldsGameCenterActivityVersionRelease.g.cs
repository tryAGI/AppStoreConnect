
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterActivityVersionReleasesGetInstanceFieldsGameCenterActivityVersionRelease
    {
        /// <summary>
        /// 
        /// </summary>
        Version,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterActivityVersionReleasesGetInstanceFieldsGameCenterActivityVersionReleaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterActivityVersionReleasesGetInstanceFieldsGameCenterActivityVersionRelease value)
        {
            return value switch
            {
                GameCenterActivityVersionReleasesGetInstanceFieldsGameCenterActivityVersionRelease.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterActivityVersionReleasesGetInstanceFieldsGameCenterActivityVersionRelease? ToEnum(string value)
        {
            return value switch
            {
                "version" => GameCenterActivityVersionReleasesGetInstanceFieldsGameCenterActivityVersionRelease.Version,
                _ => null,
            };
        }
    }
}