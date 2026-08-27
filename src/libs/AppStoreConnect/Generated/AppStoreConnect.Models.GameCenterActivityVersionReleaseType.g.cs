
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterActivityVersionReleaseType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterActivityVersionReleases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterActivityVersionReleaseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterActivityVersionReleaseType value)
        {
            return value switch
            {
                GameCenterActivityVersionReleaseType.GameCenterActivityVersionReleases => "gameCenterActivityVersionReleases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterActivityVersionReleaseType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterActivityVersionReleases" => GameCenterActivityVersionReleaseType.GameCenterActivityVersionReleases,
                _ => null,
            };
        }
    }
}